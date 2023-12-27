using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JewelShopProject.Migrations
{
    public partial class diminfomsts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BrandMst",
                columns: table => new
                {
                    Brand_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Brand_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandMst", x => x.Brand_ID);
                });

            migrationBuilder.CreateTable(
                name: "DimInfoMst",
                columns: table => new
                {
                    DimID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DimType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DimSubType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DimCrt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DimPrice = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DimImgPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimInfoMst", x => x.DimID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrandMst");

            migrationBuilder.DropTable(
                name: "DimInfoMst");
        }
    }
}
