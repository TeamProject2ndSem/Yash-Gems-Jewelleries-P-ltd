using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JewelShopProject.Migrations
{
    public partial class Initial : Migration
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
                    Brand_ID = table.Column<int>(type: "int", nullable: false)
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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MRP = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cartLists", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "catMsts",
                columns: table => new
                {
                    Cat_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cat_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catMsts", x => x.Cat_ID);
                });

            migrationBuilder.CreateTable(
                name: "certifyMsts",
                columns: table => new
                {
                    Certify_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Certify_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Style_Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DimQlty_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DimQltyMst_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
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
                    DimQltyMst_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DimQlty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dimQltySubMsts", x => x.DimQltyMst_ID);
                });

            migrationBuilder.CreateTable(
                name: "goldKrtMsts",
                columns: table => new
                {
                    GoldType_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gold_Crt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_goldKrtMsts", x => x.GoldType_ID);
                });

            migrationBuilder.CreateTable(
                name: "inquiries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JewelType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jewelTypeMsts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "prodMsts",
                columns: table => new
                {
                    Prod_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prod_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prodMsts", x => x.Prod_ID);
                });

            migrationBuilder.CreateTable(
                name: "StoneQltyMst",
                columns: table => new
                {
                    StoneQlty_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoneQlty = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoneQltyMst", x => x.StoneQlty_ID);
                });

            migrationBuilder.CreateTable(
                name: "userRegMsts",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userFname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userLname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mobNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cdate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRegMsts", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "itemMsts",
                columns: table => new
                {
                    Style_Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pairs = table.Column<int>(type: "int", nullable: false),
                    Brand_ID = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    BrandMstBrand_ID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Cat_ID = table.Column<int>(type: "int", nullable: false),
                    Prod_Quality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Certify_ID = table.Column<int>(type: "int", nullable: false),
                    Prod_ID = table.Column<int>(type: "int", nullable: false),
                    GoldType_ID = table.Column<int>(type: "int", nullable: false),
                    Gold_Wt = table.Column<int>(type: "int", nullable: false),
                    Stone_Wt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Net_Gold = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wstg_Per = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wstg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tot_Gross_Wt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gold_Rate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gold_Amt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gold_Making = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stone_Making = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Other_Making = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tot_Making = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MRP = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemMsts", x => x.Style_Code);
                    table.ForeignKey(
                        name: "FK_itemMsts_BrandMst_BrandMstBrand_ID",
                        column: x => x.BrandMstBrand_ID,
                        principalTable: "BrandMst",
                        principalColumn: "Brand_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_itemMsts_catMsts_Cat_ID",
                        column: x => x.Cat_ID,
                        principalTable: "catMsts",
                        principalColumn: "Cat_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_itemMsts_goldKrtMsts_GoldType_ID",
                        column: x => x.GoldType_ID,
                        principalTable: "goldKrtMsts",
                        principalColumn: "GoldType_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_itemMsts_prodMsts_Prod_ID",
                        column: x => x.Prod_ID,
                        principalTable: "prodMsts",
                        principalColumn: "Prod_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stoneMsts",
                columns: table => new
                {
                    Style_Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoneQlty_ID = table.Column<int>(type: "int", nullable: false),
                    Stone_Gm = table.Column<int>(type: "int", nullable: false),
                    Stone_Pcs = table.Column<int>(type: "int", nullable: false),
                    Stone_Crt = table.Column<int>(type: "int", nullable: false),
                    Stone_Rate = table.Column<int>(type: "int", nullable: false),
                    Stone_Amt = table.Column<int>(type: "int", nullable: false)
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
                name: "IX_itemMsts_BrandMstBrand_ID",
                table: "itemMsts",
                column: "BrandMstBrand_ID");

            migrationBuilder.CreateIndex(
                name: "IX_itemMsts_Cat_ID",
                table: "itemMsts",
                column: "Cat_ID");

            migrationBuilder.CreateIndex(
                name: "IX_itemMsts_GoldType_ID",
                table: "itemMsts",
                column: "GoldType_ID");

            migrationBuilder.CreateIndex(
                name: "IX_itemMsts_Prod_ID",
                table: "itemMsts",
                column: "Prod_ID");

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
                name: "cartLists");

            migrationBuilder.DropTable(
                name: "certifyMsts");

            migrationBuilder.DropTable(
                name: "DimInfoMst");

            migrationBuilder.DropTable(
                name: "dimMsts");

            migrationBuilder.DropTable(
                name: "dimQltySubMsts");

            migrationBuilder.DropTable(
                name: "inquiries");

            migrationBuilder.DropTable(
                name: "itemMsts");

            migrationBuilder.DropTable(
                name: "jewelTypeMsts");

            migrationBuilder.DropTable(
                name: "stoneMsts");

            migrationBuilder.DropTable(
                name: "userRegMsts");

            migrationBuilder.DropTable(
                name: "BrandMst");

            migrationBuilder.DropTable(
                name: "catMsts");

            migrationBuilder.DropTable(
                name: "goldKrtMsts");

            migrationBuilder.DropTable(
                name: "prodMsts");

            migrationBuilder.DropTable(
                name: "StoneQltyMst");
        }
    }
}
