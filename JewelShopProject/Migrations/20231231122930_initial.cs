using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JewelShopProject.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "adminLoginMsts",
                columns: table => new
                {
                    AdId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adminLoginMsts", x => x.AdId);
                });

            migrationBuilder.CreateTable(
                name: "BrandMst",
                columns: table => new
                {
                    Brand_ID = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandMst", x => x.Brand_ID);
                });

            migrationBuilder.CreateTable(
                name: "cartLists",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MRP = table.Column<decimal>(type: "numeric(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cartLists", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "catMsts",
                columns: table => new
                {
                    Cat_ID = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cat_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catMsts", x => x.Cat_ID);
                });

            migrationBuilder.CreateTable(
                name: "certifyMsts",
                columns: table => new
                {
                    Certify_ID = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Certify_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_certifyMsts", x => x.Certify_ID);
                });

            migrationBuilder.CreateTable(
                name: "DimInfoMst",
                columns: table => new
                {
                    DimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DimType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DimSubType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DimCrt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DimPrice = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DimImgPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimInfoMst", x => x.DimID);
                });

            migrationBuilder.CreateTable(
                name: "dimMsts",
                columns: table => new
                {
                    Style_Code = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DimQlty_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DimSubType_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Dim_Crt = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Dim_Pcs = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Dim_Gm = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Dim_Size = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Dim_Rate = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Dim_Amt = table.Column<decimal>(type: "numeric(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dimMsts", x => x.Style_Code);
                });

            migrationBuilder.CreateTable(
                name: "dimQltySubMsts",
                columns: table => new
                {
                    DimSubType_ID = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DimQlty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dimQltySubMsts", x => x.DimSubType_ID);
                });

            migrationBuilder.CreateTable(
                name: "goldKrtMsts",
                columns: table => new
                {
                    GoldType_ID = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gold_Crt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_goldKrtMsts", x => x.GoldType_ID);
                });

            migrationBuilder.CreateTable(
                name: "inquiries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EmailID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inquiries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "jewelTypeMsts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JewelType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jewelTypeMsts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "prodMsts",
                columns: table => new
                {
                    Prod_ID = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prod_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prodMsts", x => x.Prod_ID);
                });

            migrationBuilder.CreateTable(
                name: "StoneQltyMst",
                columns: table => new
                {
                    StoneQlty_ID = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoneQlty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoneQltyMst", x => x.StoneQlty_ID);
                });

            migrationBuilder.CreateTable(
                name: "userRegMsts",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userFname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userLname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    state = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    mobNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    emailID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    dob = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cdate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRegMsts", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "stoneMsts",
                columns: table => new
                {
                    Style_Code = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoneQlty_ID = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Stone_Gm = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Stone_Pcs = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Stone_Crt = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Stone_Rate = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Stone_Amt = table.Column<decimal>(type: "numeric(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stoneMsts", x => x.Style_Code);
                    table.ForeignKey(
                        name: "FK_stoneMsts_StoneQltyMst_StoneQlty_ID",
                        column: x => x.StoneQlty_ID,
                        principalTable: "StoneQltyMst",
                        principalColumn: "StoneQlty_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_stoneMsts_StoneQlty_ID",
                table: "stoneMsts",
                column: "StoneQlty_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "adminLoginMsts");

            migrationBuilder.DropTable(
                name: "BrandMst");

            migrationBuilder.DropTable(
                name: "cartLists");

            migrationBuilder.DropTable(
                name: "catMsts");

            migrationBuilder.DropTable(
                name: "certifyMsts");

            migrationBuilder.DropTable(
                name: "DimInfoMst");

            migrationBuilder.DropTable(
                name: "dimMsts");

            migrationBuilder.DropTable(
                name: "dimQltySubMsts");

            migrationBuilder.DropTable(
                name: "goldKrtMsts");

            migrationBuilder.DropTable(
                name: "inquiries");

            migrationBuilder.DropTable(
                name: "jewelTypeMsts");

            migrationBuilder.DropTable(
                name: "prodMsts");

            migrationBuilder.DropTable(
                name: "stoneMsts");

            migrationBuilder.DropTable(
                name: "userRegMsts");

            migrationBuilder.DropTable(
                name: "StoneQltyMst");
        }
    }
}
