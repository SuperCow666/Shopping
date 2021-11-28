using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopping.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "generalGoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sequence = table.Column<int>(type: "int", nullable: false),
                    putAway = table.Column<bool>(type: "bit", nullable: false),
                    recommend = table.Column<bool>(type: "bit", nullable: false),
                    hot = table.Column<bool>(type: "bit", nullable: false),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    goodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ordry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brokerAge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salesPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    costPice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    marketPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brand = table.Column<int>(type: "int", nullable: false),
                    classify = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_generalGoods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "goodSKUValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    specId = table.Column<int>(type: "int", nullable: false),
                    Values = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_goodSKUValues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "goodsSKUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_goodsSKUs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "generalGoods");

            migrationBuilder.DropTable(
                name: "goodSKUValues");

            migrationBuilder.DropTable(
                name: "goodsSKUs");
        }
    }
}
