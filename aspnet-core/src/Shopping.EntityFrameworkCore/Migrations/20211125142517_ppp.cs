using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopping.Migrations
{
    public partial class ppp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "goodsSKUs");

            migrationBuilder.CreateTable(
                name: "tbCommodityInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommodityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommoditySubtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shelves = table.Column<bool>(type: "bit", nullable: false),
                    recommended = table.Column<bool>(type: "bit", nullable: false),
                    hot = table.Column<bool>(type: "bit", nullable: false),
                    Thesorting = table.Column<int>(type: "int", nullable: false),
                    Thesaleprice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thecostprice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Themarketprice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityDisplay = table.Column<int>(type: "int", nullable: false),
                    CommoditySaleBegin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommoditySalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CommodiSPromotion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CommodityDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityNum = table.Column<int>(type: "int", nullable: false),
                    CommodityWeight = table.Column<int>(type: "int", nullable: false),
                    CommodityFreight = table.Column<int>(type: "int", nullable: false),
                    CommodityBarCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityState = table.Column<int>(type: "int", nullable: false),
                    CommodityBorwseNum = table.Column<int>(type: "int", nullable: false),
                    CommoditySaleNum = table.Column<int>(type: "int", nullable: false),
                    CommodityEvaluaNum = table.Column<int>(type: "int", nullable: false),
                    CommodityAttrName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodSpeciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodTypeId = table.Column<int>(type: "int", nullable: false),
                    CommdTypeTwoId = table.Column<int>(type: "int", nullable: false),
                    ImgId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ordere = table.Column<int>(type: "int", nullable: false),
                    Todolteme = table.Column<int>(type: "int", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCommodityInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbCommoditySpecificas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommodSpeciName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodSpecTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodSpeciOrder = table.Column<int>(type: "int", nullable: false),
                    CommProductId = table.Column<int>(type: "int", nullable: false),
                    CommodSpeciDisplay = table.Column<bool>(type: "bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCommoditySpecificas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbSaleNums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderInfoId = table.Column<int>(type: "int", nullable: false),
                    CommodityId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Num = table.Column<int>(type: "int", nullable: false),
                    SmallImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbSaleNums", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbCommodityInfos");

            migrationBuilder.DropTable(
                name: "tbCommoditySpecificas");

            migrationBuilder.DropTable(
                name: "TbSaleNums");

            migrationBuilder.CreateTable(
                name: "goodsSKUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sort = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_goodsSKUs", x => x.Id);
                });
        }
    }
}
