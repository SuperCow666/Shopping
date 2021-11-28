using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopping.Migrations
{
    public partial class _0001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "orderAttacheds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderInfoId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productId = table.Column<int>(type: "int", nullable: false),
                    productSum = table.Column<int>(type: "int", nullable: false),
                    CountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderAttacheds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "orderTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderInfoId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    orderInfoTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    payWayInfoId = table.Column<int>(type: "int", nullable: false),
                    usersId = table.Column<int>(type: "int", nullable: false),
                    orderInfoAddre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    orderInfoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shoppAddreTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    orderInfoSalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    commodCountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    orderInfoBarCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    orderInfoPayPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    orderInfoActivePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    orderInfoState = table.Column<int>(type: "int", nullable: false),
                    orderInfoWaybillNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "taseKills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    seckillName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productId = table.Column<int>(type: "int", nullable: false),
                    seckillSatae = table.Column<int>(type: "int", nullable: false),
                    seckillPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    seckillSum = table.Column<int>(type: "int", nullable: false),
                    seckillastrict = table.Column<int>(type: "int", nullable: false),
                    seckillBegin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    seckillEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    seckillWeight = table.Column<int>(type: "int", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taseKills", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orderAttacheds");

            migrationBuilder.DropTable(
                name: "orderTables");

            migrationBuilder.DropTable(
                name: "taseKills");
        }
    }
}
