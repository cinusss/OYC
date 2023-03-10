// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderYourChow.DAL.CORE.Models;

#nullable disable

namespace OrderYourChow.DAL.CORE.Migrations
{
    [DbContext(typeof(OrderYourChowContext))]
    [Migration("20230116112307_RenamedRecipeFavouriteTable")]
    partial class RenamedRecipeFavouriteTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DDietDay", b =>
                {
                    b.Property<int>("DietDayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DietDayId"), 1L, 1);

                    b.Property<int>("DateDayId")
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

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DietDayId")
                        .HasName("PK__D_DIET_DAY__DietDayId");

                    b.HasIndex("DateDayId");

                    b.HasIndex("UserId");

                    b.ToTable("D_DIET_DAY", (string)null);
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DDietDayRecipe", b =>
                {
                    b.Property<int>("DietDayRecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DietDayRecipeId"), 1L, 1);

                    b.Property<int>("DietDayId")
                        .HasColumnType("int");

                    b.Property<bool>("Eaten")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<decimal>("Multiplier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal")
                        .HasDefaultValue(1m);

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

                    b.HasKey("DietDayRecipeId")
                        .HasName("PK__D_DIET_DAY_RECIPE_DietDayRecipeId");

                    b.HasIndex("DietDayId");

                    b.HasIndex("RecipeId");

                    b.ToTable("D_DIET_DAY_RECIPE", (string)null);
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DPlan", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlanId"), 1L, 1);

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

                    b.ToTable("D_PLAN", (string)null);
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DPlanRecipe", b =>
                {
                    b.Property<int>("PlanRecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlanRecipeId"), 1L, 1);

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

                    b.ToTable("D_PLAN_RECIPE", (string)null);
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DRecipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeId"), 1L, 1);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

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

                    b.ToTable("D_RECIPE", (string)null);
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DRecipeFavourite", b =>
                {
                    b.Property<int>("RecipeFavouriteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeFavouriteId"), 1L, 1);

                    b.Property<int?>("DRecipeRecipeId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RecipeFavouriteId")
                        .HasName("PK__D_RECIPE_FAVOURITE_RecipeFavouriteId");

                    b.HasIndex("DRecipeRecipeId");

                    b.ToTable("D_RECIPE_FAVOURITE", (string)null);
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DRecipeImage", b =>
                {
                    b.Property<int>("RecipeImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeImageId"), 1L, 1);

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

                    b.ToTable("D_RECIPE_IMAGES", (string)null);
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DRecipeProduct", b =>
                {
                    b.Property<int>("RecipeProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeProductId"), 1L, 1);

                    b.Property<decimal>("Count")
                        .HasColumnType("decimal(10,2)");

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

                    b.ToTable("D_RECIPE_PRODUCT", (string)null);
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DShopping", b =>
                {
                    b.Property<int>("ShoppingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingId"), 1L, 1);

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

                    b.ToTable("D_SHOPPING", (string)null);
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DShoppingList", b =>
                {
                    b.Property<int>("ShoppingListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingListId"), 1L, 1);

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

                    b.ToTable("D_SHOPPING_LIST", (string)null);
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DUser", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(320)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("MultiplierDiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

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

                    b.HasKey("UserId")
                        .HasName("PK__D_USER_UserId");

                    b.ToTable("D_USER", (string)null);
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.SDateDay", b =>
                {
                    b.Property<int>("DateDayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DateDayId"), 1L, 1);

                    b.Property<DateTime>("DateDay")
                        .HasColumnType("date");

                    b.Property<int>("DayId")
                        .HasColumnType("int");

                    b.HasKey("DateDayId")
                        .HasName("PK__S_DATE_DAY__DateDayId");

                    b.HasIndex("DayId");

                    b.ToTable("S_DATE_DAY", (string)null);
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.SDay", b =>
                {
                    b.Property<int>("DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DayId"), 1L, 1);

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

                    b.ToTable("S_DAY", (string)null);
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.SProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

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

                    b.ToTable("S_PRODUCT", (string)null);
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.SProductCategory", b =>
                {
                    b.Property<int>("ProductCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductCategoryId"), 1L, 1);

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

                    b.ToTable("S_PRODUCT_CATEGORY", (string)null);
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.SProductMeasure", b =>
                {
                    b.Property<int>("ProductMeasureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductMeasureId"), 1L, 1);

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

                    b.ToTable("S_PRODUCT_MEASURE", (string)null);
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.SRecipeCategory", b =>
                {
                    b.Property<int>("RecipeCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeCategoryId"), 1L, 1);

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

                    b.ToTable("S_RECIPE_CATEGORY", (string)null);
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.SWeek", b =>
                {
                    b.Property<int>("WeekId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WeekId"), 1L, 1);

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

                    b.ToTable("S_WEEK", (string)null);
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DDietDay", b =>
                {
                    b.HasOne("OrderYourChow.DAL.CORE.Models.SDateDay", "SDateDay")
                        .WithMany("DDietDays")
                        .HasForeignKey("DateDayId")
                        .IsRequired()
                        .HasConstraintName("FK__D_DIET_DAY__S_DATE_DAY");

                    b.HasOne("OrderYourChow.DAL.CORE.Models.DUser", "DUser")
                        .WithMany("DDietDays")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__D_DIET_DAY__D_USER");

                    b.Navigation("DUser");

                    b.Navigation("SDateDay");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DDietDayRecipe", b =>
                {
                    b.HasOne("OrderYourChow.DAL.CORE.Models.DDietDay", "DDietDay")
                        .WithMany("DDietDayRecipes")
                        .HasForeignKey("DietDayId")
                        .IsRequired()
                        .HasConstraintName("FK__D_DIET_DAY_RECIPE_D_DIET_DAY");

                    b.HasOne("OrderYourChow.DAL.CORE.Models.DRecipe", "DRecipe")
                        .WithMany("DDietDayRecipes")
                        .HasForeignKey("RecipeId")
                        .IsRequired()
                        .HasConstraintName("FK__D_DIET_DAY_RECIPE_D_RECIPE");

                    b.Navigation("DDietDay");

                    b.Navigation("DRecipe");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DPlan", b =>
                {
                    b.HasOne("OrderYourChow.DAL.CORE.Models.SWeek", "Week")
                        .WithMany("DPlans")
                        .HasForeignKey("WeekId")
                        .IsRequired()
                        .HasConstraintName("FK__D_PLAN__Sysdate__44FF419A");

                    b.Navigation("Week");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DPlanRecipe", b =>
                {
                    b.HasOne("OrderYourChow.DAL.CORE.Models.SDay", "Day")
                        .WithMany("DPlanRecipes")
                        .HasForeignKey("DayId")
                        .IsRequired()
                        .HasConstraintName("FK__D_PLAN_RE__DayId__00200768");

                    b.HasOne("OrderYourChow.DAL.CORE.Models.DRecipe", "Recipe")
                        .WithMany("DPlanRecipes")
                        .HasForeignKey("RecipeId")
                        .IsRequired()
                        .HasConstraintName("FK__D_PLAN_RE__Sysda__7F2BE32F");

                    b.Navigation("Day");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DRecipe", b =>
                {
                    b.HasOne("OrderYourChow.DAL.CORE.Models.SRecipeCategory", "Category")
                        .WithMany("DRecipes")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK__D_RECIPE__Sysdat__6B24EA82");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DRecipeFavourite", b =>
                {
                    b.HasOne("OrderYourChow.DAL.CORE.Models.DRecipe", "DRecipe")
                        .WithMany("DRecipeFavourite")
                        .HasForeignKey("DRecipeRecipeId");

                    b.Navigation("DRecipe");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DRecipeImage", b =>
                {
                    b.HasOne("OrderYourChow.DAL.CORE.Models.DRecipe", "Recipe")
                        .WithMany("DRecipeImages")
                        .HasForeignKey("RecipeId")
                        .IsRequired()
                        .HasConstraintName("FK__D_RECIPE___Sysda__18EBB532");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DRecipeProduct", b =>
                {
                    b.HasOne("OrderYourChow.DAL.CORE.Models.SProduct", "Product")
                        .WithMany("DRecipeProducts")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK__D_RECIPE___Produ__05D8E0BE");

                    b.HasOne("OrderYourChow.DAL.CORE.Models.SProductMeasure", "ProductMeasure")
                        .WithMany("DRecipeProducts")
                        .HasForeignKey("ProductMeasureId")
                        .IsRequired()
                        .HasConstraintName("FK__D_RECIPE___Produ__06CD04F7");

                    b.HasOne("OrderYourChow.DAL.CORE.Models.DRecipe", "Recipe")
                        .WithMany("DRecipeProducts")
                        .HasForeignKey("RecipeId")
                        .IsRequired()
                        .HasConstraintName("FK__D_RECIPE___Sysda__04E4BC85");

                    b.Navigation("Product");

                    b.Navigation("ProductMeasure");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DShoppingList", b =>
                {
                    b.HasOne("OrderYourChow.DAL.CORE.Models.DRecipe", "Recipe")
                        .WithMany("DShoppingLists")
                        .HasForeignKey("RecipeId")
                        .IsRequired()
                        .HasConstraintName("FK__D_SHOPPIN__Sysda__797309D9");

                    b.HasOne("OrderYourChow.DAL.CORE.Models.DShopping", "Shopping")
                        .WithMany("DShoppingLists")
                        .HasForeignKey("ShoppingId")
                        .IsRequired()
                        .HasConstraintName("FK__D_SHOPPIN__Shopp__7A672E12");

                    b.Navigation("Recipe");

                    b.Navigation("Shopping");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.SDateDay", b =>
                {
                    b.HasOne("OrderYourChow.DAL.CORE.Models.SDay", "SDay")
                        .WithMany("SDateDays")
                        .HasForeignKey("DayId")
                        .IsRequired()
                        .HasConstraintName("FK__S_DATE_DAY__S_DAY");

                    b.Navigation("SDay");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.SProduct", b =>
                {
                    b.HasOne("OrderYourChow.DAL.CORE.Models.SProductCategory", "Category")
                        .WithMany("SProducts")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK__S_PRODUCT__Sysda__619B8048");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DDietDay", b =>
                {
                    b.Navigation("DDietDayRecipes");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DRecipe", b =>
                {
                    b.Navigation("DDietDayRecipes");

                    b.Navigation("DPlanRecipes");

                    b.Navigation("DRecipeFavourite");

                    b.Navigation("DRecipeImages");

                    b.Navigation("DRecipeProducts");

                    b.Navigation("DShoppingLists");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DShopping", b =>
                {
                    b.Navigation("DShoppingLists");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.DUser", b =>
                {
                    b.Navigation("DDietDays");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.SDateDay", b =>
                {
                    b.Navigation("DDietDays");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.SDay", b =>
                {
                    b.Navigation("DPlanRecipes");

                    b.Navigation("SDateDays");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.SProduct", b =>
                {
                    b.Navigation("DRecipeProducts");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.SProductCategory", b =>
                {
                    b.Navigation("SProducts");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.SProductMeasure", b =>
                {
                    b.Navigation("DRecipeProducts");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.SRecipeCategory", b =>
                {
                    b.Navigation("DRecipes");
                });

            modelBuilder.Entity("OrderYourChow.DAL.CORE.Models.SWeek", b =>
                {
                    b.Navigation("DPlans");
                });
#pragma warning restore 612, 618
        }
    }
}
