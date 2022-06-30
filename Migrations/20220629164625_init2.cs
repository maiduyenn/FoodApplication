using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodApplication.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Ranks",
                table: "Ranks");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("01810684-d544-4acb-b09d-e082ebd349f4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("5c02fc75-8158-41c3-9e10-11684c7a22b9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("678028ca-d2a6-4d00-9edd-1645a961568c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("91ddb623-9125-4e36-b3eb-e2ef92e9070f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("97fb1ce6-6082-4017-9fb2-640d57fe4939"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("a230a125-e905-43e5-8d10-f38d255193f9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("bf6acadf-6f2b-40ae-960b-acb7f2c9c33e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e594383f-c6a5-4891-bd6c-d6c88d9c8dbc"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("ea6f95fc-69f8-439a-94d6-aef887723c9c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("ece8b6a6-e45d-4a24-912e-7591e283ecef"));

            migrationBuilder.DropColumn(
                name: "SpentMoney",
                table: "Ranks");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Ranks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Ranks",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Discount",
                table: "Ranks",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "RankId",
                table: "Ranks",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<int>(
                name: "UserRankId",
                table: "Ranks",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<double>(
                name: "TotalSpent",
                table: "Ranks",
                type: "float",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ranks",
                table: "Ranks",
                column: "UserRankId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Ranks",
                table: "Ranks");

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

            migrationBuilder.DropColumn(
                name: "UserRankId",
                table: "Ranks");

            migrationBuilder.DropColumn(
                name: "TotalSpent",
                table: "Ranks");

            migrationBuilder.AlterColumn<int>(
                name: "Value",
                table: "Ranks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Ranks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RankId",
                table: "Ranks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Discount",
                table: "Ranks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SpentMoney",
                table: "Ranks",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ranks",
                table: "Ranks",
                column: "RankId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "ff62c306-7602-46bd-bc86-7dbfbfc69087");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "0cd9b3f4-7136-4993-875a-218faffff8c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35ab49c1-35e7-465a-84aa-9411af3240d2", "AQAAAAEAACcQAAAAEGxy9dFEkZ0bSwggaPtDORHyClxOk+OxmXvx75Sx/NPfLjNDZrUGsucJxoFBVokjyg==", "87625d79-a4ea-4ab9-9e47-fd0172ca3980" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "083f0025-e26e-43f3-af57-548a5a38983d", "AQAAAAEAACcQAAAAEP5BRECL7oeIJ6WVX38MUwpjUpHhreE41S2b0DllGyhMFuAQtoC7SaXbM64xGOQ6Rg==", "74039707-7908-4544-8794-66d2984f08c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "851e3114-878b-4316-9abf-abf604666eee", "AQAAAAEAACcQAAAAEK+Q3gsyyR8QTM3Dcd/Bc9QvM1VT3jkkhriunEsXkC3SGgDs7psgDN4tLEPJYFuzoQ==", "200c1e8e-9062-4451-a630-2e14880bccfe" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("01810684-d544-4acb-b09d-e082ebd349f4"), "Pizza Hải Sản loại 5 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate5.png", "Pizza siêu ngon số 5 thế giới", 17m },
                    { new Guid("5c02fc75-8158-41c3-9e10-11684c7a22b9"), "Pizza Hải Sản loại 7 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate7.png", "Pizza siêu ngon số 7 thế giới", 19m },
                    { new Guid("678028ca-d2a6-4d00-9edd-1645a961568c"), "Pizza Hải Sản loại 3 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate3.png", "Pizza siêu ngon số 3 thế giới", 15m },
                    { new Guid("91ddb623-9125-4e36-b3eb-e2ef92e9070f"), "Pizza Hải Sản loại 1 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate1.png", "Pizza siêu ngon số 1 thế giới", 13m },
                    { new Guid("97fb1ce6-6082-4017-9fb2-640d57fe4939"), "Pizza Hải Sản loại 2 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate2.png", "Pizza siêu ngon số 2 thế giới", 14m },
                    { new Guid("a230a125-e905-43e5-8d10-f38d255193f9"), "Pizza Hải Sản loại 6 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate6.png", "Pizza siêu ngon số 6 thế giới", 18m },
                    { new Guid("bf6acadf-6f2b-40ae-960b-acb7f2c9c33e"), "Pizza Hải Sản loại 0 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate0.png", "Pizza siêu ngon số 0 thế giới", 12m },
                    { new Guid("e594383f-c6a5-4891-bd6c-d6c88d9c8dbc"), "Pizza Hải Sản loại 9 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate9.png", "Pizza siêu ngon số 9 thế giới", 21m },
                    { new Guid("ea6f95fc-69f8-439a-94d6-aef887723c9c"), "Pizza Hải Sản loại 4 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate4.png", "Pizza siêu ngon số 4 thế giới", 16m },
                    { new Guid("ece8b6a6-e45d-4a24-912e-7591e283ecef"), "Pizza Hải Sản loại 8 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate8.png", "Pizza siêu ngon số 8 thế giới", 20m }
                });
        }
    }
}
