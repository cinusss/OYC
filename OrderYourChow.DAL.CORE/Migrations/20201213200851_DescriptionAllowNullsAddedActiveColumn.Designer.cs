﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using OrderYourChow.DAL.CORE.Models;

namespace OrderYourChow.DAL.CORE.Migrations
{
    [DbContext(typeof(OrderYourChowContext))]
    [Migration("20201213200851_DescriptionAllowNullsAddedActiveColumn")]
    partial class DescriptionAllowNullsAddedActiveColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("OrderYourChow.Models.DPlan", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Sysdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Syslog")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasDefaultValueSql("(suser_name())");

                    b.Property<int>("WeekId")
                        .HasColumnType("int");

                    b.HasKey("PlanId")
                        .HasName("PK__D_PLAN__755C22B70D68E5B2");

                    b.HasIndex("WeekId");

                    b.ToTable("D_PLAN");
                });

            modelBuilder.Entity("OrderYourChow.Models.DPlanRecipe", b =>
                {
                    b.Property<int>("PlanRecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DayId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Sysdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Syslog")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasDefaultValueSql("(suser_name())");

                    b.HasKey("PlanRecipeId")
                        .HasName("PK__D_PLAN_R__531B21B7FFF811D6");

                    b.HasIndex("DayId");

                    b.HasIndex("RecipeId");

                    b.ToTable("D_PLAN_RECIPE");
                });

            modelBuilder.Entity("OrderYourChow.Models.DRecipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<bool>("Favourite")
                        .HasColumnType("bit");

                    b.Property<string>("MainImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Meat")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("Rating")
                        .HasColumnType("decimal(2,1)");

                    b.Property<DateTime>("Sysdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Syslog")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasDefaultValueSql("(suser_name())");

                    b.HasKey("RecipeId")
                        .HasName("PK__D_RECIPE__FDD988B019C05448");

                    b.HasIndex("CategoryId");

                    b.ToTable("D_RECIPE");
                });

            modelBuilder.Entity("OrderYourChow.Models.DRecipeImage", b =>
                {
                    b.Property<int>("RecipeImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Image")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Sysdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Syslog")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasDefaultValueSql("(suser_name())");

                    b.HasKey("RecipeImageId")
                        .HasName("PK__D_RECIPE__23E65C238874E5A7");

                    b.HasIndex("RecipeId");

                    b.ToTable("D_RECIPE_IMAGES");
                });

            modelBuilder.Entity("OrderYourChow.Models.DRecipeProduct", b =>
                {
                    b.Property<int>("RecipeProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductMeasureId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Sysdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Syslog")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasDefaultValueSql("(suser_name())");

                    b.HasKey("RecipeProductId")
                        .HasName("PK__D_RECIPE__3879DB74C27AE08D");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductMeasureId");

                    b.HasIndex("RecipeId");

                    b.ToTable("D_RECIPE_PRODUCT");
                });

            modelBuilder.Entity("OrderYourChow.Models.DShopping", b =>
                {
                    b.Property<int>("ShoppingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal?>("Cost")
                        .HasColumnType("money");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Shop")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Sysdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Syslog")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasDefaultValueSql("(suser_name())");

                    b.HasKey("ShoppingId")
                        .HasName("PK__D_SHOPPI__8E3AF518CAB77B3A");

                    b.ToTable("D_SHOPPING");
                });

            modelBuilder.Entity("OrderYourChow.Models.DShoppingList", b =>
                {
                    b.Property<int>("ShoppingListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Sysdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Syslog")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasDefaultValueSql("(suser_name())");

                    b.HasKey("ShoppingListId")
                        .HasName("PK__D_SHOPPI__6CBBDD145EB0D3C8");

                    b.HasIndex("RecipeId");

                    b.HasIndex("ShoppingId");

                    b.ToTable("D_SHOPPING_LIST");
                });

            modelBuilder.Entity("OrderYourChow.Models.SDay", b =>
                {
                    b.Property<int>("DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("Sysdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Syslog")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasDefaultValueSql("(suser_name())");

                    b.HasKey("DayId")
                        .HasName("PK__S_DAY__BF3DD8C568465FE9");

                    b.ToTable("S_DAY");
                });

            modelBuilder.Entity("OrderYourChow.Models.SProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Sysdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Syslog")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasDefaultValueSql("(suser_name())");

                    b.HasKey("ProductId")
                        .HasName("PK__S_PRODUC__B40CC6CD550497AE");

                    b.HasIndex("CategoryId");

                    b.ToTable("S_PRODUCT");
                });

            modelBuilder.Entity("OrderYourChow.Models.SProductCategory", b =>
                {
                    b.Property<int>("ProductCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Sysdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Syslog")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasDefaultValueSql("(suser_name())");

                    b.HasKey("ProductCategoryId")
                        .HasName("PK__S_PRODUC__3224ECCEAB43FBAA");

                    b.ToTable("S_PRODUCT_CATEGORY");
                });

            modelBuilder.Entity("OrderYourChow.Models.SProductMeasure", b =>
                {
                    b.Property<int>("ProductMeasureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Sysdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Syslog")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasDefaultValueSql("(suser_name())");

                    b.HasKey("ProductMeasureId")
                        .HasName("PK__S_PRODUC__4A00517B8885EE62");

                    b.ToTable("S_PRODUCT_MEASURE");
                });

            modelBuilder.Entity("OrderYourChow.Models.SRecipeCategory", b =>
                {
                    b.Property<int>("RecipeCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Sysdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Syslog")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasDefaultValueSql("(suser_name())");

                    b.HasKey("RecipeCategoryId")
                        .HasName("PK__S_RECIPE__747A031B1E2535C2");

                    b.ToTable("S_RECIPE_CATEGORY");
                });

            modelBuilder.Entity("OrderYourChow.Models.SWeek", b =>
                {
                    b.Property<int>("WeekId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("End")
                        .HasColumnType("date");

                    b.Property<DateTime>("Start")
                        .HasColumnType("date");

                    b.Property<DateTime>("Sysdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Syslog")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasDefaultValueSql("(suser_name())");

                    b.Property<int>("Week")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("WeekId")
                        .HasName("PK__S_WEEK__C814A5C1B8C5888A");

                    b.ToTable("S_WEEK");
                });

            modelBuilder.Entity("OrderYourChow.Models.DPlan", b =>
                {
                    b.HasOne("OrderYourChow.Models.SWeek", "Week")
                        .WithMany("DPlans")
                        .HasForeignKey("WeekId")
                        .HasConstraintName("FK__D_PLAN__Sysdate__44FF419A")
                        .IsRequired();

                    b.Navigation("Week");
                });

            modelBuilder.Entity("OrderYourChow.Models.DPlanRecipe", b =>
                {
                    b.HasOne("OrderYourChow.Models.SDay", "Day")
                        .WithMany("DPlanRecipes")
                        .HasForeignKey("DayId")
                        .HasConstraintName("FK__D_PLAN_RE__DayId__00200768")
                        .IsRequired();

                    b.HasOne("OrderYourChow.Models.DRecipe", "Recipe")
                        .WithMany("DPlanRecipes")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK__D_PLAN_RE__Sysda__7F2BE32F")
                        .IsRequired();

                    b.Navigation("Day");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("OrderYourChow.Models.DRecipe", b =>
                {
                    b.HasOne("OrderYourChow.Models.SRecipeCategory", "Category")
                        .WithMany("DRecipes")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK__D_RECIPE__Sysdat__6B24EA82")
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OrderYourChow.Models.DRecipeImage", b =>
                {
                    b.HasOne("OrderYourChow.Models.DRecipe", "Recipe")
                        .WithMany("DRecipeImages")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK__D_RECIPE___Sysda__18EBB532")
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("OrderYourChow.Models.DRecipeProduct", b =>
                {
                    b.HasOne("OrderYourChow.Models.SProduct", "Product")
                        .WithMany("DRecipeProducts")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__D_RECIPE___Produ__05D8E0BE")
                        .IsRequired();

                    b.HasOne("OrderYourChow.Models.SProductMeasure", "ProductMeasure")
                        .WithMany("DRecipeProducts")
                        .HasForeignKey("ProductMeasureId")
                        .HasConstraintName("FK__D_RECIPE___Produ__06CD04F7")
                        .IsRequired();

                    b.HasOne("OrderYourChow.Models.DRecipe", "Recipe")
                        .WithMany("DRecipeProducts")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK__D_RECIPE___Sysda__04E4BC85")
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductMeasure");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("OrderYourChow.Models.DShoppingList", b =>
                {
                    b.HasOne("OrderYourChow.Models.DRecipe", "Recipe")
                        .WithMany("DShoppingLists")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK__D_SHOPPIN__Sysda__797309D9")
                        .IsRequired();

                    b.HasOne("OrderYourChow.Models.DShopping", "Shopping")
                        .WithMany("DShoppingLists")
                        .HasForeignKey("ShoppingId")
                        .HasConstraintName("FK__D_SHOPPIN__Shopp__7A672E12")
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("Shopping");
                });

            modelBuilder.Entity("OrderYourChow.Models.SProduct", b =>
                {
                    b.HasOne("OrderYourChow.Models.SProductCategory", "Category")
                        .WithMany("SProducts")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK__S_PRODUCT__Sysda__619B8048")
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OrderYourChow.Models.DRecipe", b =>
                {
                    b.Navigation("DPlanRecipes");

                    b.Navigation("DRecipeImages");

                    b.Navigation("DRecipeProducts");

                    b.Navigation("DShoppingLists");
                });

            modelBuilder.Entity("OrderYourChow.Models.DShopping", b =>
                {
                    b.Navigation("DShoppingLists");
                });

            modelBuilder.Entity("OrderYourChow.Models.SDay", b =>
                {
                    b.Navigation("DPlanRecipes");
                });

            modelBuilder.Entity("OrderYourChow.Models.SProduct", b =>
                {
                    b.Navigation("DRecipeProducts");
                });

            modelBuilder.Entity("OrderYourChow.Models.SProductCategory", b =>
                {
                    b.Navigation("SProducts");
                });

            modelBuilder.Entity("OrderYourChow.Models.SProductMeasure", b =>
                {
                    b.Navigation("DRecipeProducts");
                });

            modelBuilder.Entity("OrderYourChow.Models.SRecipeCategory", b =>
                {
                    b.Navigation("DRecipes");
                });

            modelBuilder.Entity("OrderYourChow.Models.SWeek", b =>
                {
                    b.Navigation("DPlans");
                });
#pragma warning restore 612, 618
        }
    }
}
