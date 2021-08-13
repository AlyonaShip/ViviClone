﻿// <auto-generated />
using System;
using Application.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Application.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200331142342_removeUnusedFieldLabelFromWare")]
    partial class removeUnusedFieldLabelFromWare
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Application.EntitiesModels.Entities.Announcement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<DateTime>("Date");

                    b.Property<bool>("IsEnable");

                    b.Property<DateTime>("LastUpdateDate");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeywords");

                    b.Property<string>("SubUrl")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .HasMaxLength(250);

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("LastName")
                        .HasMaxLength(250);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.ApplicationUserRole", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<DateTime?>("DateModificated")
                        .IsRequired();

                    b.Property<bool>("IsEnable");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeywords");

                    b.Property<string>("SubUrl")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("ColorTitle")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<bool>("IsEnable");

                    b.Property<string>("LogoImage");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeywords");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("Position");

                    b.Property<string>("ShortDescription")
                        .IsRequired();

                    b.Property<string>("SubUrl")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsEnable");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeywords");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("SubUrl");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.CategoryValues", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<bool>("IsEnable");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryValueses");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Chat.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("ChatGUID");

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<bool>("IsChatEnded");

                    b.Property<bool>("IsUserAuthorized");

                    b.Property<string>("SessionOrUserId");

                    b.Property<DateTimeOffset>("TimeToCloseChat");

                    b.Property<string>("UserNameOrEmail");

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Chat.ChatMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChatId");

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<bool>("IsMessageFromOperator");

                    b.Property<string>("Message");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("ChatMessages");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.GOW", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IconString");

                    b.Property<bool>("IsEnable");

                    b.Property<string>("LogoImage");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeywords");

                    b.Property<string>("Name");

                    b.Property<int?>("ParentId");

                    b.Property<string>("ShortDescription");

                    b.Property<string>("SubUrl");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("GOWs");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Data")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Order.DeliveryService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAlternateKey("Name");

                    b.ToTable("DeliveryServices");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Order.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountOfWares");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DeclarationNumber");

                    b.Property<int?>("DeliveryServiceId");

                    b.Property<string>("OrderNumber")
                        .IsRequired();

                    b.Property<int?>("OrderStatusId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryServiceId");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Order.OrderDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<Guid>("OrderId");

                    b.Property<int>("WareId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("WareId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Order.OrderHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Message");

                    b.Property<Guid>("OrderId");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("OrderHistories");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Order.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAlternateKey("StatusName");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId");

                    b.Property<string>("Body");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime?>("DateModificated");

                    b.Property<string>("ImageURL");

                    b.Property<bool>("IsEnable");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeywords");

                    b.Property<string>("SubUrl");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Promotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<DateTime>("Date");

                    b.Property<bool>("IsEnable");

                    b.Property<DateTime>("LastUpdateDate");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeywords");

                    b.Property<string>("SubUrl")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Ware", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrandId");

                    b.Property<bool>("IsEnable");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeywords");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<string>("SubUrl");

                    b.Property<string>("Text");

                    b.Property<string>("VendorCode");

                    b.Property<string>("WareImage");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Wares");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.WareGOW", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GOWId");

                    b.Property<int>("WareId");

                    b.HasKey("Id");

                    b.HasIndex("GOWId");

                    b.HasIndex("WareId");

                    b.ToTable("WareGOWs");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.WareVote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("Rate");

                    b.Property<int>("UserId");

                    b.Property<int>("WareId");

                    b.HasKey("Id");

                    b.HasIndex("WareId");

                    b.ToTable("WareVotes");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.WaresCategoryValues", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryValueId");

                    b.Property<int>("WareId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryValueId");

                    b.HasIndex("WareId");

                    b.ToTable("WCV");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.ApplicationUserRole", b =>
                {
                    b.HasOne("Application.EntitiesModels.Entities.ApplicationRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Application.EntitiesModels.Entities.ApplicationUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.CategoryValues", b =>
                {
                    b.HasOne("Application.EntitiesModels.Entities.Category", "Category")
                        .WithMany("CategoryValueses")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Chat.ChatMessage", b =>
                {
                    b.HasOne("Application.EntitiesModels.Entities.Chat.Chat", "Chat")
                        .WithMany("ChatMessages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.GOW", b =>
                {
                    b.HasOne("Application.EntitiesModels.Entities.GOW", "Parent")
                        .WithMany("Childs")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Order.Order", b =>
                {
                    b.HasOne("Application.EntitiesModels.Entities.Order.DeliveryService", "DeliveryService")
                        .WithMany("Orders")
                        .HasForeignKey("DeliveryServiceId");

                    b.HasOne("Application.EntitiesModels.Entities.Order.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId");

                    b.HasOne("Application.EntitiesModels.Entities.ApplicationUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Order.OrderDetails", b =>
                {
                    b.HasOne("Application.EntitiesModels.Entities.Order.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Application.EntitiesModels.Entities.Ware", "Ware")
                        .WithMany("OrderDetails")
                        .HasForeignKey("WareId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Order.OrderHistory", b =>
                {
                    b.HasOne("Application.EntitiesModels.Entities.Order.Order", "Order")
                        .WithMany("OrderHistories")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Application.EntitiesModels.Entities.ApplicationUser", "User")
                        .WithMany("OrderHistories")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Post", b =>
                {
                    b.HasOne("Application.EntitiesModels.Entities.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.Ware", b =>
                {
                    b.HasOne("Application.EntitiesModels.Entities.Brand", "Brand")
                        .WithMany("Wares")
                        .HasForeignKey("BrandId");
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.WareGOW", b =>
                {
                    b.HasOne("Application.EntitiesModels.Entities.GOW", "GOW")
                        .WithMany("WareGOWs")
                        .HasForeignKey("GOWId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Application.EntitiesModels.Entities.Ware", "Ware")
                        .WithMany("WareGOWs")
                        .HasForeignKey("WareId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.WareVote", b =>
                {
                    b.HasOne("Application.EntitiesModels.Entities.Ware", "Ware")
                        .WithMany("WareVote")
                        .HasForeignKey("WareId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.EntitiesModels.Entities.WaresCategoryValues", b =>
                {
                    b.HasOne("Application.EntitiesModels.Entities.CategoryValues", "CategoryValueses")
                        .WithMany("WCV")
                        .HasForeignKey("CategoryValueId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Application.EntitiesModels.Entities.Ware", "Ware")
                        .WithMany("WCV")
                        .HasForeignKey("WareId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Application.EntitiesModels.Entities.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Application.EntitiesModels.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Application.EntitiesModels.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Application.EntitiesModels.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
