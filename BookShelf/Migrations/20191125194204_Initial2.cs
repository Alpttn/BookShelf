using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShelf.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "37ae116e-fb07-47f9-a6a8-a33ad9285789", "AQAAAAEAACcQAAAAELKd6wJJGqf/ljUY8KeAHHrvv8Zyvh3pHkFBueaUR2jFMT00KWKrIfbUI4+nRI/5kA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "80764bea-0ae5-4882-8ee4-f28289e80edb", "AQAAAAEAACcQAAAAELsTYhqvSTfZaLK3pUumT41TY4dIiXpSzCLB+LSAz6TXv8THpTGpbyiOxNyT1lTgIg==" });
        }
    }
}
