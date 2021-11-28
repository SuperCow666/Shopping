using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopping.Migrations
{
    public partial class k : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brandId = table.Column<int>(type: "int", nullable: false),
                    brandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brandLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brandorderby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isShow = table.Column<bool>(type: "bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "commonGoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sequence = table.Column<int>(type: "int", nullable: false),
                    putAway = table.Column<bool>(type: "bit", nullable: false),
                    recommend = table.Column<bool>(type: "bit", nullable: false),
                    hot = table.Column<bool>(type: "bit", nullable: false),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    goodsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ordry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brokerage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salesPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    costPice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    marketPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    classify = table.Column<int>(type: "int", nullable: false),
                    brand = table.Column<int>(type: "int", nullable: false),
                    updateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_commonGoods", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "brand");

            migrationBuilder.DropTable(
                name: "commonGoods");
        }
    }
}
