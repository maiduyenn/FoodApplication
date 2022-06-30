using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodApplication.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("10835859-9455-47fd-b500-adaea0fa0e93"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("29d98ab0-a796-4ebf-ab2f-8f0c64affbe3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("2ca51096-d113-4ec6-9222-bf31e73e9fce"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("2f77b5cb-9d89-4ca8-bd68-524b1d8ddbec"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("3c3393a6-94cf-4219-a347-aca02081780c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("77c6f995-815e-4c29-bb47-d62fd78c96af"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("8acd6ffb-318c-477d-989e-e96ad9820145"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("a26cba11-474d-42ae-aaa9-6d698a463830"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e6b419f4-136d-4e6a-9c4f-81906df1937e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f2931a91-4912-4b11-a0c2-92ab8ab721bb"));

            migrationBuilder.CreateTable(
                name: "ReportTarget",
                columns: table => new
                {
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Target = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportTarget", x => x.TargetId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "ab789702-f182-4430-a8f8-f1282ef2daac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "42f22341-0018-4f8f-ab9a-315a912cf38d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "669fc521-4586-46e7-bdbd-30ea22a94b5a", "AQAAAAEAACcQAAAAEIdkdQUEfmZLw9pCmiEsj4iVJYi81xkbI1tx143HzdOjsVrRnMm+LHPoZdCIsADRZA==", "5836f24e-1924-4f0e-9f3f-36540ace374b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a40b61ba-c50a-4a42-a5ef-debd43d63210", "AQAAAAEAACcQAAAAEC8UjlON/5c6qnND5+xGjzZiQ3FkxHidZUVtk/1tEffxlfjbBj269oq11nMsBcB6fg==", "c62501ca-3b63-4eac-b209-0cdfab351863" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fb2afb2-66fe-4bc0-aeeb-459a827d6aae", "AQAAAAEAACcQAAAAEFiylRjn+lTjtsdBz/XcKilbgP4GwmYt4SwhZzCCQPjg+00FWWVH8WZ+uzB2cexnDw==", "196c0a27-4618-4b3d-9243-e9021c5d10ce" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("1e9439ab-061c-4cbd-b76f-eda319b512d4"), "Pizza Hải Sản loại 4 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate4.png", "Pizza siêu ngon số 4 thế giới", 16m },
                    { new Guid("2793bef6-5932-4059-81d8-952cc993c922"), "Pizza Hải Sản loại 8 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate8.png", "Pizza siêu ngon số 8 thế giới", 20m },
                    { new Guid("51a0bd4b-edbd-4c68-998e-f5bb270765fd"), "Pizza Hải Sản loại 3 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate3.png", "Pizza siêu ngon số 3 thế giới", 15m },
                    { new Guid("5937a890-9b72-4179-b323-caa8b0bb3c5f"), "Pizza Hải Sản loại 9 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate9.png", "Pizza siêu ngon số 9 thế giới", 21m },
                    { new Guid("6b725d52-be19-46d1-83e9-ea72b100f167"), "Pizza Hải Sản loại 1 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate1.png", "Pizza siêu ngon số 1 thế giới", 13m },
                    { new Guid("7224dd09-3acf-492a-b264-b74e4d880502"), "Pizza Hải Sản loại 0 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate0.png", "Pizza siêu ngon số 0 thế giới", 12m },
                    { new Guid("af547677-13d2-4b45-bf5a-c3d515e16c7f"), "Pizza Hải Sản loại 2 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate2.png", "Pizza siêu ngon số 2 thế giới", 14m },
                    { new Guid("b3723fa3-9851-4ff0-b0b9-6889ae36de6f"), "Pizza Hải Sản loại 5 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate5.png", "Pizza siêu ngon số 5 thế giới", 17m },
                    { new Guid("d6e6d474-44ab-49dc-b600-29faeed2ef61"), "Pizza Hải Sản loại 6 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate6.png", "Pizza siêu ngon số 6 thế giới", 18m },
                    { new Guid("e2581089-1e1c-4505-98d3-b3ad3c35ca7c"), "Pizza Hải Sản loại 7 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate7.png", "Pizza siêu ngon số 7 thế giới", 19m }
                });

            migrationBuilder.InsertData(
                table: "ReportTarget",
                columns: new[] { "TargetId", "Target" },
                values: new object[] { new Guid("2d5e174e-3b0e-446f-86af-483d56fd8210"), 2000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportTarget");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("1e9439ab-061c-4cbd-b76f-eda319b512d4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("2793bef6-5932-4059-81d8-952cc993c922"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("51a0bd4b-edbd-4c68-998e-f5bb270765fd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("5937a890-9b72-4179-b323-caa8b0bb3c5f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("6b725d52-be19-46d1-83e9-ea72b100f167"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("7224dd09-3acf-492a-b264-b74e4d880502"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("af547677-13d2-4b45-bf5a-c3d515e16c7f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("b3723fa3-9851-4ff0-b0b9-6889ae36de6f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("d6e6d474-44ab-49dc-b600-29faeed2ef61"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e2581089-1e1c-4505-98d3-b3ad3c35ca7c"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "ad218d1d-0515-4827-b62d-5710218d98ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "19d84541-4122-47af-98ae-dc0f99dbb7d9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33970939-ca0b-4e2c-bf1c-5561f8c95503", "AQAAAAEAACcQAAAAEIkpJFc1DIPesloOMdBMGL8A6TXRT0XiaOuogb4R6rmKXLcA5tJQHpPnIV++fLc2tQ==", "5f12416f-d7cb-4c99-98c7-567db3032050" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d5bf447-39e6-4e62-bde3-b569aa2a587e", "AQAAAAEAACcQAAAAENfooY11cpkl97BXKRqz2Yq6iXMeShfZalfRkbARQN/+UbFIF2+bA52JZPUwcR5WNw==", "7ce03c8f-ee97-4f82-ae09-d8ab932c4efb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2d3c6c6-79e9-4ef9-ba9e-ae60e59a0aca", "AQAAAAEAACcQAAAAEPyNDcZ0hOD4svh9lffJxK1HunKKSLXBFhaMsR56gxESj3zw7kJaj3MFIM4sl+x9xw==", "671b0044-d668-49fd-b27c-7088bdfed41b" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("10835859-9455-47fd-b500-adaea0fa0e93"), "Pizza Hải Sản loại 3 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate3.png", "Pizza siêu ngon số 3 thế giới", 15m },
                    { new Guid("29d98ab0-a796-4ebf-ab2f-8f0c64affbe3"), "Pizza Hải Sản loại 6 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate6.png", "Pizza siêu ngon số 6 thế giới", 18m },
                    { new Guid("2ca51096-d113-4ec6-9222-bf31e73e9fce"), "Pizza Hải Sản loại 2 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate2.png", "Pizza siêu ngon số 2 thế giới", 14m },
                    { new Guid("2f77b5cb-9d89-4ca8-bd68-524b1d8ddbec"), "Pizza Hải Sản loại 9 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate9.png", "Pizza siêu ngon số 9 thế giới", 21m },
                    { new Guid("3c3393a6-94cf-4219-a347-aca02081780c"), "Pizza Hải Sản loại 5 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate5.png", "Pizza siêu ngon số 5 thế giới", 17m },
                    { new Guid("77c6f995-815e-4c29-bb47-d62fd78c96af"), "Pizza Hải Sản loại 0 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate0.png", "Pizza siêu ngon số 0 thế giới", 12m },
                    { new Guid("8acd6ffb-318c-477d-989e-e96ad9820145"), "Pizza Hải Sản loại 7 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate7.png", "Pizza siêu ngon số 7 thế giới", 19m },
                    { new Guid("a26cba11-474d-42ae-aaa9-6d698a463830"), "Pizza Hải Sản loại 1 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate1.png", "Pizza siêu ngon số 1 thế giới", 13m },
                    { new Guid("e6b419f4-136d-4e6a-9c4f-81906df1937e"), "Pizza Hải Sản loại 8 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate8.png", "Pizza siêu ngon số 8 thế giới", 20m },
                    { new Guid("f2931a91-4912-4b11-a0c2-92ab8ab721bb"), "Pizza Hải Sản loại 4 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.", "/images/plate4.png", "Pizza siêu ngon số 4 thế giới", 16m }
                });
        }
    }
}
