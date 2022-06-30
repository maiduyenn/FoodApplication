using FoodApplication.Areas.Identity.Data;
using FoodApplication.Models;
using FoodApplication.Models.Requests;

namespace FoodApplication.Interface
{
    public interface IOrderService
    {
        Task<OrderModel> CreateOrder(OrderRequest Product, ApplicationUser user);
        Task<List<OrderModel>> GetOrdersByUser(ApplicationUser user);
        Task<List<OrderModel>> GetAllOrders();
        Task<OrderResponse> GetOrderById(string id);
    }
}
