using FoodApplication.Areas.Identity.Data;
using FoodApplication.Data;
using FoodApplication.Interface;
using FoodApplication.Models;
using FoodApplication.Models.Requests;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodApplication.Services
{
    public class OrderService : Controller, IOrderService
    {
        private readonly AuthContext _context;

        public OrderService(AuthContext context)
        {
            _context = context;
        }

        public async Task<OrderModel> CreateOrder(OrderRequest arg, ApplicationUser currentUser)
        {
            var order = new OrderModel
            {
                OrderDate = DateTime.Now,
                CustomerId = new Guid(currentUser.Id),
                CustomerName = arg.CustomerName,
                CustomerAddress = arg.CustomerAddress,
                Notes = arg.Notes,
                PhoneNumber = arg.PhoneNumber
            };
            await _context.AddAsync(order);
            if (arg.Products != null)
            {
                await SaveOrderDetail(arg, order);
            }
            if (_context.UserRank.Any(c => c.UserId.ToString() == currentUser.Id))
            {
                var existingRank = await _context.UserRank.FirstOrDefaultAsync(c => c.UserId.ToString() == currentUser.Id);
                existingRank.TotalSpent += arg.TotalPrice;
                await UpdateRank(existingRank);
                _context.Update(existingRank);
            }
            else
            {
                var rank = CheckRank(arg.TotalPrice);
                await _context.AddAsync(new UserRank { UserId = new Guid(currentUser.Id), TotalSpent = arg.TotalPrice, RankId = rank.Result.RankId });
            }
            await _context.SaveChangesAsync();
            return order;
        }

        private async Task SaveOrderDetail(OrderRequest arg, OrderModel orderModel)
        {
            var listOderdetails = arg.Products.Select(c => new OrderDetailModel
            {
                ProductId = c.ProductId,
                OrderId = orderModel.OrderId,
                Quantity = arg.Quantity,
                UnitPrice = c.Price,
                Discount = arg.Discount,
            }).ToList();
            await _context.AddRangeAsync(listOderdetails);
        }

        public async Task<List<OrderModel>> GetAllOrders()
        {
            var orders = await _context.Orders
             .Select(c => new OrderModel(c)).ToListAsync();
            return orders;
        }
        public async Task<List<OrderModel>> GetOrdersByUser(ApplicationUser currentUser)
        {
            var orders = await _context.Orders
             .Where(c => c.CustomerId == new Guid(currentUser.Id))
             .Select(c => new OrderModel(c)).ToListAsync();
            return orders;
        }

        public async Task<OrderResponse> GetOrderById(string id)
        {
            var oder = await
                _context.Orders
                .Include(c => c.OrderDetails)
                .FirstOrDefaultAsync(c => c.OrderId == new Guid(id));

            var oderResponse = new OrderResponse(oder);

            foreach (var item in oderResponse.OrderDetails)
            {
                item.Product = await _context.FindAsync<Product>(item.ProductId);
            }
            return oderResponse;
        }

        public async Task UpdateRank(UserRank userRank)
        {
            var ranks = await _context.Ranking.ToListAsync();
            Ranking rank = new Ranking();
            foreach (var item in ranks)
            {
                if (userRank.TotalSpent > item.TotalSpent)
                {
                    rank = item;
                }
            }
            userRank.RankId = rank.RankId;
            userRank.RankName = rank.RankName;
            userRank.Discount = rank.Discount;
        }

        public async Task<Ranking> CheckRank(decimal total)
        {
            var ranks = await _context.Ranking.ToListAsync();
            Ranking rank = new Ranking();
            foreach (var item in ranks)
            {
                if (total > item.TotalSpent)
                {
                    rank = item;
                }
            }
            return rank;
        }


        //public async Task<List<RankingResponse>> GetRanks()
        //{
        //    return await _context.Ranks.OrderByDescending(c => c.Rank).Select(c => new RankingResponse(c)).ToListAsync();
        //}

        //public async Task<double> Discount(string id)
        //{
        //    try
        //    {
        //        var rank = await _context.Ranks.FirstAsync(c => c.UserId == id);
        //        return rank.GetDiscount();
        //    }
        //    catch (Exception e)
        //    {
        //        return 0;
        //    }
        //}


    }
}

