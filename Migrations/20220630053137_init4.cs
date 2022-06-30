using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodApplication.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Ranks",
                table: "Ranks");

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

            migrationBuilder.RenameTable(
                name: "Ranks",
                newName: "UserRank");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalSpent",
                table: "UserRank",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "UserRank",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRank",
                table: "UserRank",
                column: "UserRankId");

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

            migrationBuilder.UpdateData(
                table: "Ranking",
                keyColumn: "RankId",
                keyValue: new Guid("2b5e174e-3b0e-446f-86af-483d56fd7210"),
                column: "TotalSpent",
                value: 100m);

            migrationBuilder.UpdateData(
                table: "Ranking",
                keyColumn: "RankId",
                keyValue: new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"),
                column: "TotalSpent",
                value: 200m);

            migrationBuilder.UpdateData(
                table: "Ranking",
                keyColumn: "RankId",
                keyValue: new Guid("2d5e174e-3b0e-446f-86af-483d56fd7210"),
                column: "TotalSpent",
                value: 300m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRank",
                table: "UserRank");

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

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "UserRank");

            migrationBuilder.RenameTable(
                name: "UserRank",
                newName: "Ranks");

            migrationBuilder.AlterColumn<double>(
                name: "TotalSpent",
                table: "Ranks",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ranks",
                table: "Ranks",
                column: "UserRankId");

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

            migrationBuilder.UpdateData(
                table: "Ranking",
                keyColumn: "RankId",
                keyValue: new Guid("2b5e174e-3b0e-446f-86af-483d56fd7210"),
                column: "TotalSpent",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Ranking",
                keyColumn: "RankId",
                keyValue: new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"),
                column: "TotalSpent",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Ranking",
                keyColumn: "RankId",
                keyValue: new Guid("2d5e174e-3b0e-446f-86af-483d56fd7210"),
                column: "TotalSpent",
                value: 0m);
        }
    }
}
