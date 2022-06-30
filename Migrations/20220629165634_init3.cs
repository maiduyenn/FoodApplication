using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodApplication.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("101370c6-df29-43d6-8af1-beb2b1def226"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("284587a9-9189-4c4f-86e1-81f12f04dd0a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("419f5ff7-f658-4e70-be59-fbd56e36bbc4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("6c7b65e4-0951-4da9-9398-dac61df942e4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("a489e2a5-fe0f-4056-90a0-f3f58c76653f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("ac841026-b8ff-446a-911f-039cfc14b6f7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e6c30fe5-3af1-4f32-bffc-f2eab050cb30"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e852c4aa-1b14-403d-a2a5-00f3eee98284"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f07ac05e-f132-4d22-b72c-9b0d4a40525d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f8d834c7-bfcf-4ff5-9db3-6b86fa592785"));

            migrationBuilder.CreateTable(
                name: "Ranking",
                columns: table => new
                {
                    RankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalSpent = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranking", x => x.RankId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "2053da39-4e6a-41d8-8c3a-d5e6745f470f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "c72895eb-f4f6-4a62-8934-0fb01e69df6e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92186398-bf23-4552-b784-b12f46a3abe4", "AQAAAAEAACcQAAAAEOxxeGztEtM1MweDvPRIHdKUXy1q1uF/XNEITc4rk8SVSWuN0J9xqIQlE/zBzPRgfw==", "a22c56b4-e413-4c8d-99e1-6629c0d136e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cee6f69d-4c90-4ad9-a73a-18137e562a6d", "AQAAAAEAACcQAAAAEPOS5xZUGRw6EiSI/PUJ9z3YHTQV/3XMuly7zErTmVHC/FykeOSq07/KXETs0T88Iw==", "a3aeec53-d572-46a3-8ed5-a1e74bc1932a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba8c23e0-7e1d-4edf-aab9-7efc4f1f1896", "AQAAAAEAACcQAAAAEEHG5V9cFv4pWIOB8+Hqo+adtSWVcASUgPSNM3/5jmL/5piaof96vOyDMtkT0efR3w==", "99d4dc64-9690-49b4-ac22-752fc133ebd6" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("14418024-8d6f-43b0-803c-b13d79934985"), "Pizza Hải Sản loại 5 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate5.png", "Pizza siêu ngon số 5 thế giới", 17m },
                    { new Guid("73956fb4-e77e-411c-80c2-d6b264f076c5"), "Pizza Hải Sản loại 1 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate1.png", "Pizza siêu ngon số 1 thế giới", 13m },
                    { new Guid("739af934-0c1e-4849-89cd-cdc199164ede"), "Pizza Hải Sản loại 6 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate6.png", "Pizza siêu ngon số 6 thế giới", 18m },
                    { new Guid("944bdcf5-024a-4cb2-8099-f07e4a2dfd38"), "Pizza Hải Sản loại 3 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate3.png", "Pizza siêu ngon số 3 thế giới", 15m },
                    { new Guid("a4499732-ab3d-43ca-a61d-18ed442b746f"), "Pizza Hải Sản loại 0 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate0.png", "Pizza siêu ngon số 0 thế giới", 12m },
                    { new Guid("ad53446c-dd5c-4f64-bfad-9d2ab08c3172"), "Pizza Hải Sản loại 8 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate8.png", "Pizza siêu ngon số 8 thế giới", 20m },
                    { new Guid("b1469ebf-9591-40a0-af48-114c43f85b40"), "Pizza Hải Sản loại 2 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate2.png", "Pizza siêu ngon số 2 thế giới", 14m },
                    { new Guid("c4a1267f-7286-4c9c-bb83-fe6ec577de45"), "Pizza Hải Sản loại 4 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate4.png", "Pizza siêu ngon số 4 thế giới", 16m },
                    { new Guid("e3bbea66-afef-4c1e-ae7a-9ce75c4e2e21"), "Pizza Hải Sản loại 7 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate7.png", "Pizza siêu ngon số 7 thế giới", 19m },
                    { new Guid("e8811e2e-91e5-4485-8d08-b343d037f8d0"), "Pizza Hải Sản loại 9 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate9.png", "Pizza siêu ngon số 9 thế giới", 21m }
                });

            migrationBuilder.InsertData(
                table: "Ranking",
                columns: new[] { "RankId", "Discount", "RankName", "TotalSpent", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("2b5e174e-3b0e-446f-86af-483d56fd7210"), 5, "Broze", 0m, null, 0 },
                    { new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), 10, "Silver", 0m, null, 1 },
                    { new Guid("2d5e174e-3b0e-446f-86af-483d56fd7210"), 20, "Gold", 0m, null, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ranking");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("14418024-8d6f-43b0-803c-b13d79934985"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("73956fb4-e77e-411c-80c2-d6b264f076c5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("739af934-0c1e-4849-89cd-cdc199164ede"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("944bdcf5-024a-4cb2-8099-f07e4a2dfd38"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("a4499732-ab3d-43ca-a61d-18ed442b746f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("ad53446c-dd5c-4f64-bfad-9d2ab08c3172"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("b1469ebf-9591-40a0-af48-114c43f85b40"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c4a1267f-7286-4c9c-bb83-fe6ec577de45"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e3bbea66-afef-4c1e-ae7a-9ce75c4e2e21"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e8811e2e-91e5-4485-8d08-b343d037f8d0"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "aeca2508-8f5c-41e1-b9fa-46135ff2d3ce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "7514831f-79ca-4a5e-9344-278f717f29a3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4ba25e1-8560-4cc1-bdac-d8927c0e5079", "AQAAAAEAACcQAAAAENJ0Ic6g/hWGCEVzumXyYnLbhn0tMhCdZjeFFwlK/0VhdJ9sxtP9ffCgSlSlnoMmAg==", "579d4e26-14df-4625-b856-4e4124013a50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c7e5dd9-b3d5-442d-8254-58ff3e79d5f8", "AQAAAAEAACcQAAAAEGPkjHY233kpKUoh+P6gdT78+DyhsBnQSbxRyP9rX+I9AAY2j+8PGSOc4/rH2UOGxA==", "41c7d8f5-4f0a-489c-92c2-d31013143be5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9950ff9c-3353-4c45-97a8-3d5491a54fda", "AQAAAAEAACcQAAAAEPLUcHk23IBMnFFrd1c9VF7X3FRJpOY6EVE4AkYxFVryROxo8CHky56vLrhv1/yoZw==", "c5666f9f-fc48-42b3-844e-9d199d2a55a8" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("101370c6-df29-43d6-8af1-beb2b1def226"), "Pizza Hải Sản loại 2 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate2.png", "Pizza siêu ngon số 2 thế giới", 14m },
                    { new Guid("284587a9-9189-4c4f-86e1-81f12f04dd0a"), "Pizza Hải Sản loại 4 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate4.png", "Pizza siêu ngon số 4 thế giới", 16m },
                    { new Guid("419f5ff7-f658-4e70-be59-fbd56e36bbc4"), "Pizza Hải Sản loại 9 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate9.png", "Pizza siêu ngon số 9 thế giới", 21m },
                    { new Guid("6c7b65e4-0951-4da9-9398-dac61df942e4"), "Pizza Hải Sản loại 6 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate6.png", "Pizza siêu ngon số 6 thế giới", 18m },
                    { new Guid("a489e2a5-fe0f-4056-90a0-f3f58c76653f"), "Pizza Hải Sản loại 1 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate1.png", "Pizza siêu ngon số 1 thế giới", 13m },
                    { new Guid("ac841026-b8ff-446a-911f-039cfc14b6f7"), "Pizza Hải Sản loại 0 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate0.png", "Pizza siêu ngon số 0 thế giới", 12m },
                    { new Guid("e6c30fe5-3af1-4f32-bffc-f2eab050cb30"), "Pizza Hải Sản loại 7 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate7.png", "Pizza siêu ngon số 7 thế giới", 19m },
                    { new Guid("e852c4aa-1b14-403d-a2a5-00f3eee98284"), "Pizza Hải Sản loại 5 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate5.png", "Pizza siêu ngon số 5 thế giới", 17m },
                    { new Guid("f07ac05e-f132-4d22-b72c-9b0d4a40525d"), "Pizza Hải Sản loại 3 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate3.png", "Pizza siêu ngon số 3 thế giới", 15m },
                    { new Guid("f8d834c7-bfcf-4ff5-9db3-6b86fa592785"), "Pizza Hải Sản loại 8 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate8.png", "Pizza siêu ngon số 8 thế giới", 20m }
                });
        }
    }
}
