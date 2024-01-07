﻿// <auto-generated />
using System;
using JewelShopProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JewelShopProject.Migrations
{
    [DbContext(typeof(DbContextJewel))]
    partial class DbContextJewelModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DimMst", b =>
                {
                    b.Property<int>("Style_Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Style_Code"), 1L, 1);

                    b.Property<string>("DimQltyMst_ID")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DimQlty_ID")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("Dim_Amt")
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("Dim_Crt")
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("Dim_Gm")
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("Dim_Pcs")
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("Dim_Rate")
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("Dim_Size")
                        .HasColumnType("numeric(10,2)");

                    b.HasKey("Style_Code");

                    b.ToTable("dimMsts");
                });

            modelBuilder.Entity("DimQltyMst", b =>
                {
                    b.Property<int>("DimQltyMst_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DimQltyMst_ID"), 1L, 1);

                    b.Property<string>("DimQlty")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DimQltyMst_ID");

                    b.ToTable("dimQltySubMsts");
                });

            modelBuilder.Entity("JewelShopProject.Models.AdminLoginMst", b =>
                {
                    b.Property<int>("AdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdId"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdId");

                    b.ToTable("adminLoginMsts");
                });

            modelBuilder.Entity("JewelShopProject.Models.BrandMst", b =>
                {
                    b.Property<int>("Brand_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Brand_ID"), 1L, 1);

                    b.Property<string>("Brand_Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Brand_ID");

                    b.ToTable("BrandMst");
                });

            modelBuilder.Entity("JewelShopProject.Models.CartList", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("MRP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("cartLists");
                });

            modelBuilder.Entity("JewelShopProject.Models.CatMst", b =>
                {
                    b.Property<int>("Cat_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cat_ID"), 1L, 1);

                    b.Property<string>("Cat_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cat_ID");

                    b.ToTable("catMsts");
                });

            modelBuilder.Entity("JewelShopProject.Models.CertifyMst", b =>
                {
                    b.Property<int>("Certify_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Certify_ID"), 1L, 1);

                    b.Property<string>("Certify_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Certify_ID");

                    b.ToTable("certifyMsts");
                });

            modelBuilder.Entity("JewelShopProject.Models.DimInfoMst", b =>
                {
                    b.Property<int>("DimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DimID"), 1L, 1);

                    b.Property<string>("DimCrt")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DimImgPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DimPrice")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DimSubType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DimType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DimID");

                    b.ToTable("DimInfoMst");
                });

            modelBuilder.Entity("JewelShopProject.Models.GoldKrtMst", b =>
                {
                    b.Property<int>("GoldType_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GoldType_ID"), 1L, 1);

                    b.Property<string>("Gold_Crt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GoldType_ID");

                    b.ToTable("goldKrtMsts");
                });

            modelBuilder.Entity("JewelShopProject.Models.Inquiry", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("Cdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("EmailID")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("inquiries");
                });

            modelBuilder.Entity("JewelShopProject.Models.ItemMst", b =>
                {
                    b.Property<int>("Style_Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Style_Code"), 1L, 1);

                    b.Property<int>("BrandMstBrand_ID")
                        .HasColumnType("int");

                    b.Property<int>("Brand_ID")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("Cat_ID")
                        .HasColumnType("int");

                    b.Property<int>("Certify_ID")
                        .HasColumnType("int");

                    b.Property<int>("GoldType_ID")
                        .HasColumnType("int");

                    b.Property<string>("Gold_Amt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gold_Making")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gold_Rate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gold_Wt")
                        .HasColumnType("int");

                    b.Property<string>("MRP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Net_Gold")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other_Making")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pairs")
                        .HasColumnType("int");

                    b.Property<int>("Prod_ID")
                        .HasColumnType("int");

                    b.Property<string>("Prod_Quality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Stone_Making")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stone_Wt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tot_Gross_Wt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tot_Making")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wstg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wstg_Per")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Style_Code");

                    b.HasIndex("BrandMstBrand_ID");

                    b.HasIndex("Cat_ID");

                    b.HasIndex("GoldType_ID");

                    b.HasIndex("Prod_ID");

                    b.ToTable("itemMsts");
                });

            modelBuilder.Entity("JewelShopProject.Models.JewelTypeMst", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("JewelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("jewelTypeMsts");
                });

            modelBuilder.Entity("JewelShopProject.Models.ProdMst", b =>
                {
                    b.Property<int>("Prod_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Prod_ID"), 1L, 1);

                    b.Property<string>("Prod_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Prod_ID");

                    b.ToTable("prodMsts");
                });

            modelBuilder.Entity("JewelShopProject.Models.StoneMst", b =>
                {
                    b.Property<int>("Style_Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Style_Code"), 1L, 1);

                    b.Property<int>("StoneQlty_ID")
                        .HasColumnType("int");

                    b.Property<int>("Stone_Amt")
                        .HasColumnType("int");

                    b.Property<int>("Stone_Crt")
                        .HasColumnType("int");

                    b.Property<int>("Stone_Gm")
                        .HasColumnType("int");

                    b.Property<int>("Stone_Pcs")
                        .HasColumnType("int");

                    b.Property<int>("Stone_Rate")
                        .HasColumnType("int");

                    b.HasKey("Style_Code");

                    b.HasIndex("StoneQlty_ID");

                    b.ToTable("stoneMsts");
                });

            modelBuilder.Entity("JewelShopProject.Models.StoneQltyMst", b =>
                {
                    b.Property<int>("StoneQlty_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoneQlty_ID"), 1L, 1);

                    b.Property<string>("StoneQlty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StoneQlty_ID");

                    b.ToTable("StoneQltyMst");
                });

            modelBuilder.Entity("JewelShopProject.Models.UserRegMst", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userID"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dob")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mobNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userFname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userLname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userID");

                    b.ToTable("userRegMsts");
                });

            modelBuilder.Entity("JewelShopProject.Models.ItemMst", b =>
                {
                    b.HasOne("JewelShopProject.Models.BrandMst", "BrandMst")
                        .WithMany()
                        .HasForeignKey("BrandMstBrand_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JewelShopProject.Models.CatMst", "CatMst")
                        .WithMany()
                        .HasForeignKey("Cat_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JewelShopProject.Models.GoldKrtMst", "GoldKrtMst")
                        .WithMany()
                        .HasForeignKey("GoldType_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JewelShopProject.Models.ProdMst", "ProdMst")
                        .WithMany()
                        .HasForeignKey("Prod_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BrandMst");

                    b.Navigation("CatMst");

                    b.Navigation("GoldKrtMst");

                    b.Navigation("ProdMst");
                });

            modelBuilder.Entity("JewelShopProject.Models.StoneMst", b =>
                {
                    b.HasOne("JewelShopProject.Models.StoneQltyMst", "StoneQltyMst")
                        .WithMany()
                        .HasForeignKey("StoneQlty_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StoneQltyMst");
                });
#pragma warning restore 612, 618
        }
    }
}
