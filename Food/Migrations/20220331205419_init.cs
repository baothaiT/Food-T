﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    about_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    about_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    about_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    about_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.about_id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    cg_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cg_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cg_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cg_Sale = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.cg_Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactSystems",
                columns: table => new
                {
                    Contact_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Website = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactSystems", x => x.Contact_Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUsers",
                columns: table => new
                {
                    cu_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cu_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsers", x => x.cu_Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    couponId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    couponCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    couponPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.couponId);
                });

            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    deviceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    deviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    devicePostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    devicePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.deviceId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    pd_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pd_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Price = table.Column<int>(type: "int", nullable: false),
                    pd_ReducePrice = table.Column<int>(type: "int", nullable: false),
                    pd_NameImg1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_NameImg2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_NameImg3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_NameImg4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Rate = table.Column<int>(type: "int", nullable: false),
                    pd_ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_WaitForConfirmation = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.pd_Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shipping",
                columns: table => new
                {
                    ship_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ship_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ship_Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping", x => x.ship_Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscribeEmail",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscribeEmail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInRoleModel",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameRole = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInRoleModel", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    bill_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartsDevice",
                columns: table => new
                {
                    cartd_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cartd_DeviceId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartsDevice", x => x.cartd_Id);
                    table.ForeignKey(
                        name: "FK_CartsDevice_Device_cartd_DeviceId",
                        column: x => x.cartd_DeviceId,
                        principalTable: "Device",
                        principalColumn: "deviceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductsInCategories",
                columns: table => new
                {
                    pic_CategoriesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pic_productId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsInCategories", x => new { x.pic_productId, x.pic_CategoriesId });
                    table.ForeignKey(
                        name: "FK_ProductsInCategories_Categories_pic_CategoriesId",
                        column: x => x.pic_CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "cg_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsInCategories_Products_pic_productId",
                        column: x => x.pic_productId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    bill_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    bill_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    bill_PaidTotal = table.Column<int>(type: "int", nullable: false),
                    bill_ProductIdlist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductNamelist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductSizelist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductColorlist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductPricelist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Shipping = table.Column<int>(type: "int", nullable: false),
                    bill_Discount = table.Column<int>(type: "int", nullable: false),
                    bill_Confirmation = table.Column<bool>(type: "bit", nullable: false),
                    bill_DatetimeOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bill_PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_HideStatus = table.Column<bool>(type: "bit", nullable: false),
                    bill_WaitForConfirmation = table.Column<bool>(type: "bit", nullable: false),
                    bill_WaitPickup = table.Column<bool>(type: "bit", nullable: false),
                    bill_Delivering = table.Column<bool>(type: "bit", nullable: false),
                    bill_Delivered = table.Column<bool>(type: "bit", nullable: false),
                    bill_Cancelled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.bill_Id);
                    table.ForeignKey(
                        name: "FK_Bills_Users_bill_UserId",
                        column: x => x.bill_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    cart_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cart_UserID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.cart_Id);
                    table.ForeignKey(
                        name: "FK_Carts_Users_cart_UserID",
                        column: x => x.cart_UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    review_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    review_Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    review_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    review_HideStatus = table.Column<bool>(type: "bit", nullable: false),
                    review_ReviewType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    review_UploadTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.review_id);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_review_UserId",
                        column: x => x.review_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubReview",
                columns: table => new
                {
                    subReview_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    subReview_Commnet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subReview_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    subReview_HideStatus = table.Column<bool>(type: "bit", nullable: false),
                    subreview_SubReviewType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subReview_DateCommnet = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubReview", x => x.subReview_Id);
                    table.ForeignKey(
                        name: "FK_SubReview_Users_subReview_UserId",
                        column: x => x.subReview_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCartDevices",
                columns: table => new
                {
                    picd_CartId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    picd_ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    picd_amount = table.Column<int>(type: "int", nullable: false),
                    picd_size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    picd_color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCartDevices", x => new { x.picd_CartId, x.picd_ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInCartDevices_CartsDevice_picd_CartId",
                        column: x => x.picd_CartId,
                        principalTable: "CartsDevice",
                        principalColumn: "cartd_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCartDevices_Products_picd_ProductId",
                        column: x => x.picd_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCart",
                columns: table => new
                {
                    pic_CartId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pic_ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pic_amount = table.Column<int>(type: "int", nullable: false),
                    pic_size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pic_color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCart", x => new { x.pic_CartId, x.pic_ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInCart_Carts_pic_CartId",
                        column: x => x.pic_CartId,
                        principalTable: "Carts",
                        principalColumn: "cart_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCart_Products_pic_ProductId",
                        column: x => x.pic_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReviewInproduct",
                columns: table => new
                {
                    rip_ReviewId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    rip_ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewInproduct", x => new { x.rip_ProductId, x.rip_ReviewId });
                    table.ForeignKey(
                        name: "FK_ReviewInproduct_Products_rip_ProductId",
                        column: x => x.rip_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewInproduct_Reviews_rip_ReviewId",
                        column: x => x.rip_ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "review_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubReviewInReview",
                columns: table => new
                {
                    SRiR_ReviewId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SRiR_SubReviewId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubReviewInReview", x => new { x.SRiR_ReviewId, x.SRiR_SubReviewId });
                    table.ForeignKey(
                        name: "FK_SubReviewInReview_Reviews_SRiR_ReviewId",
                        column: x => x.SRiR_ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "review_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubReviewInReview_SubReview_SRiR_SubReviewId",
                        column: x => x.SRiR_SubReviewId,
                        principalTable: "SubReview",
                        principalColumn: "subReview_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "about_id", "about_Description", "about_Title", "about_Url" },
                values: new object[] { 1, "The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. \n \n When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove,the headline of Alphabet Village and the subline of her own road,the Line Lane.Pityful a rethoric question ran over her cheek,then she continued her way.", "Footwear the leading eCommerce Store around the Globe", "https://www.youtube.com/watch?v=F1vcruph8JA" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Type" },
                values: new object[,]
                {
                    { "0a0eb798-5f01-4c97-a232-1cd7ab2bb136", "Snack", "", "" },
                    { "00b26f75-5363-4481-a262-8662f81d95ae", "Banhmi", "", "" },
                    { "8ba538c4-5c93-4c36-b897-36f77c5265b0", "Dry food", "", "" },
                    { "5a758d90-c902-467c-8a07-42608ce261b3", "Food", "", "" },
                    { "8ca3a963-dbc6-4e35-916f-a30d6e8c78e7", "Drink", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cu_Id", "cu_Description", "cu_Email", "cu_FirstName", "cu_LastName", "cu_Subject" },
                values: new object[] { "7bbb76f3-ea48-45b9-9393-96a0244a3e6e", "Description", "Email", "FirstName", "LastName", "Subject" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "couponCode", "couponPrice" },
                values: new object[,]
                {
                    { "a654eb07-fda1-4edb-8524-b75a4197c454", "code50", 50 },
                    { "b1e67dc1-8a3e-4b80-9829-d1379f3b561c", "code10", 10 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_WaitForConfirmation" },
                values: new object[,]
                {
                    { "9ed048aa-c47f-4f58-b431-2ffa97090d57", "Sanfulou", "/images/item250x300/Sanfulou.png", "", "", "", "Sanfulou", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "003f6200-728c-48ec-84a5-fcaafcce068b", "stacbuk-cf", "/images/item250x300/stacbuk-cf.png", "", "", "", "stacbuk-cf", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "4bfa73fc-1db6-476e-873d-db0814be7374", "goicuon", "/images/item250x300/goicuon.png", "", "", "", "goicuon", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "24fba28c-ea3d-45fc-af6e-77773617ee2c", "trasuanhalam", "/images/item250x300/trasuanhalam.png", "", "", "", "trasuanhalam", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "b0234296-de8c-459c-89f5-583670ea267d", "RauMaMix", "/images/item250x300/RauMaMix.png", "", "", "", "RauMaMix", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "389995e2-5204-43a9-b7c2-aaa077ff6d0c", "quanngontrangbang", "/images/item250x300/quanngontrangbang.png", "", "", "", "quanngontrangbang", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "19f61034-e9db-48da-8c24-2e9e6253f2ce", "pizza", "/images/item250x300/pizza.png", "", "", "", "pizza", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "b691e33a-c2fa-40d7-9df2-b6bb2471f739", "ParisBaguete", "/images/item250x300/ParisBaguete.png", "", "", "", "ParisBaguete", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "87259847-1300-4ce1-85b2-c6e8f1eee2bd", "monngontrangbang", "/images/item250x300/monngontrangbang.png", "", "", "", "monngontrangbang", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "6ab79219-d352-4f5f-8af5-68c1f19e90bf", "mitronanvat", "/images/item250x300/mitronanvat.png", "", "", "", "mitronanvat", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "e3999b11-faa9-4555-92bb-475b312845cb", "loteria", "/images/item250x300/loteria.png", "", "", "", "loteria", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "2c5e5e69-bf19-4ac4-a266-969282815612", "KimBap", "/images/item250x300/KimBap.png", "", "", "", "KimBap", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "51939358-8c46-4d44-9a05-a60a79d45d01", "kfc", "/images/item250x300/kfc.png", "", "", "", "kfc", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "dd494930-73c1-4125-91d3-112da4bc94ee", "Royaltea", "/images/item250x300/Royaltea.png", "", "", "", "Royaltea", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "52bbef74-3f66-4fbc-9727-b7f2d9a97e56", "denhatthitnuong", "/images/item250x300/denhatthitnuong.png", "", "", "", "denhatthitnuong", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "1180c816-dc6b-4c5b-a9b5-f15b26dd39dd", "Bunxaochay", "/images/item250x300/Bunxaochay.png", "", "", "", "Bunxaochay", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "085ea4f0-7024-49cd-8870-da207de0e689", "comga", "/images/item250x300/comga.png", "", "", "", "comga", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "c02d53a6-06f2-4cbb-9dda-82ee30fc075a", "BanhCanhCua", "/images/item250x300/BanhCanhCua.png", "", "", "", "BanhCanhCua", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "453716fc-8d75-4755-ac1d-77fde9168531", "BanhMi", "/images/item250x300/BanhMi.png", "", "", "", "BanhMi", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "1ad6ef0c-6404-4941-9f0b-334d98a02f1b", "comgadenhat", "/images/item250x300/comgadenhat.png", "", "", "", "comgadenhat", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "e9f8b8c7-a992-496e-b2ec-4f2a1504eeab", "banhuotlongdalat", "/images/item250x300/banhuotlongdalat.png", "", "", "", "banhuotlongdalat", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "0486e418-f8eb-4dbf-ac97-f90f248eb0ba", "BoKho", "/images/item250x300/BoKho.png", "", "", "", "BoKho", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "752ab919-8d0a-4532-89fb-75e7202d72b5", "banhtrangtron", "/images/item250x300/banhtrangtron.png", "", "", "", "banhtrangtron", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "2dbc4b8e-aa6e-4429-acc5-824a79d7280f", "bundaumamtom", "/images/item250x300/bundaumamtom.png", "", "", "", "bundaumamtom", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "3c967128-6834-41ed-ba20-1d3ae4d633e5", "Xoixeoba3beo", "/images/item250x300/Xoixeoba3beo.png", "", "", "", "Xoixeoba3beo", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "abbec3ea-06d3-400e-b00c-56f7430d291c", "cocosummer", "/images/item250x300/cocosummer.png", "", "", "", "cocosummer", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "5c781810-092b-4d64-a4f7-75ca093a448c", "comboxao", "/images/item250x300/comboxao.png", "", "", "", "comboxao", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "1feb1f6e-afe1-4be0-b3d6-3f2a1405d4e2", "bunbo", "/images/item250x300/bunbo.png", "", "", "", "bunbo", "1", "2", "3", "4", 1, 5, 0, "Short Description", false }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "360E601E-92F2-4F08-832B-604A21293258", "137778e1-0519-4fe1-bfe4-9f66e04759b2", "Admin", "AppRole", "Admin", "admin" },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "d72eed5c-7124-48e8-b27d-e2558f8859a7", "Staff", "AppRole", "Staff", "staff" }
                });

            migrationBuilder.InsertData(
                table: "Shipping",
                columns: new[] { "ship_Id", "ship_Name", "ship_Price" },
                values: new object[] { "7CF94A7D-9239-446E-A404-086518F84652", "Ship", 5 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "bill_Address1", "bill_Address2", "bill_City", "bill_CompanyName", "bill_Country", "bill_PhoneNumber", "bill_PostalCode", "bill_State" },
                values: new object[,]
                {
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", 0, "ee5f0924-e4c6-4f78-91a1-735ce61785d4", "AppUser", new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@gmail.com", true, "staff", "staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEIJKapBxHvG5+6FIsMUqqw8ZGN/3T5sO4Ffqfvy6AOaKQSVzF39/ea5Q6j8iaqyVgQ==", null, false, "5333a4fa-a101-46e9-a6ff-ddddfb6e694f", false, "Staff", null, null, null, null, null, null, null, null },
                    { "DE544998-A3CC-4E12-ABB4-0642E57BD222", 0, "b30abf74-7e9c-4cb4-9e9e-d68c0a291ad2", "AppUser", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "admin", "admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPz7SL1lw6dZRMQTC5Kq5NCcbwFr/wmwFkiruW4RGIlt9dprJt4vl83jW1v/xdwk+A==", null, false, "4c254ba0-43ad-4305-b756-3b6f5f692b9c", false, "Admin", null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "bill_Cancelled", "bill_Confirmation", "bill_DatetimeOrder", "bill_Delivered", "bill_Delivering", "bill_Discount", "bill_HideStatus", "bill_Note", "bill_PaidTotal", "bill_PaymentMethod", "bill_ProductColorlist", "bill_ProductIdlist", "bill_ProductNamelist", "bill_ProductPricelist", "bill_ProductSizelist", "bill_Quantity", "bill_Shipping", "bill_UserId", "bill_WaitForConfirmation", "bill_WaitPickup" },
                values: new object[] { "D269BF93-A5E2-4C4A-8146-9967DDE80D30", false, true, new DateTime(2022, 4, 1, 3, 54, 18, 601, DateTimeKind.Local).AddTicks(699), false, false, 0, false, "", 2000, "Check Payment", null, "1|2|3|4", "product 1|product 2| product 3| product 4|", "550|450|350|640|", null, "1|1|2|1|", 10, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", false, false });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "cart_Id", "cart_UserID" },
                values: new object[,]
                {
                    { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "72309286-ECBB-4D20-AD95-2819D31E3400", "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" }
                });

            migrationBuilder.InsertData(
                table: "ProductsInCategories",
                columns: new[] { "pic_CategoriesId", "pic_productId" },
                values: new object[,]
                {
                    { "8ba538c4-5c93-4c36-b897-36f77c5265b0", "1ad6ef0c-6404-4941-9f0b-334d98a02f1b" },
                    { "8ba538c4-5c93-4c36-b897-36f77c5265b0", "52bbef74-3f66-4fbc-9727-b7f2d9a97e56" },
                    { "8ba538c4-5c93-4c36-b897-36f77c5265b0", "4bfa73fc-1db6-476e-873d-db0814be7374" },
                    { "0a0eb798-5f01-4c97-a232-1cd7ab2bb136", "51939358-8c46-4d44-9a05-a60a79d45d01" },
                    { "8ba538c4-5c93-4c36-b897-36f77c5265b0", "2c5e5e69-bf19-4ac4-a266-969282815612" },
                    { "0a0eb798-5f01-4c97-a232-1cd7ab2bb136", "e3999b11-faa9-4555-92bb-475b312845cb" },
                    { "00b26f75-5363-4481-a262-8662f81d95ae", "6ab79219-d352-4f5f-8af5-68c1f19e90bf" },
                    { "0a0eb798-5f01-4c97-a232-1cd7ab2bb136", "b691e33a-c2fa-40d7-9df2-b6bb2471f739" },
                    { "8ba538c4-5c93-4c36-b897-36f77c5265b0", "085ea4f0-7024-49cd-8870-da207de0e689" },
                    { "0a0eb798-5f01-4c97-a232-1cd7ab2bb136", "19f61034-e9db-48da-8c24-2e9e6253f2ce" },
                    { "0a0eb798-5f01-4c97-a232-1cd7ab2bb136", "389995e2-5204-43a9-b7c2-aaa077ff6d0c" },
                    { "8ca3a963-dbc6-4e35-916f-a30d6e8c78e7", "b0234296-de8c-459c-89f5-583670ea267d" },
                    { "8ca3a963-dbc6-4e35-916f-a30d6e8c78e7", "dd494930-73c1-4125-91d3-112da4bc94ee" },
                    { "0a0eb798-5f01-4c97-a232-1cd7ab2bb136", "9ed048aa-c47f-4f58-b431-2ffa97090d57" },
                    { "8ca3a963-dbc6-4e35-916f-a30d6e8c78e7", "003f6200-728c-48ec-84a5-fcaafcce068b" },
                    { "5a758d90-c902-467c-8a07-42608ce261b3", "87259847-1300-4ce1-85b2-c6e8f1eee2bd" },
                    { "8ba538c4-5c93-4c36-b897-36f77c5265b0", "5c781810-092b-4d64-a4f7-75ca093a448c" },
                    { "0a0eb798-5f01-4c97-a232-1cd7ab2bb136", "abbec3ea-06d3-400e-b00c-56f7430d291c" },
                    { "8ba538c4-5c93-4c36-b897-36f77c5265b0", "1180c816-dc6b-4c5b-a9b5-f15b26dd39dd" },
                    { "8ca3a963-dbc6-4e35-916f-a30d6e8c78e7", "24fba28c-ea3d-45fc-af6e-77773617ee2c" },
                    { "5a758d90-c902-467c-8a07-42608ce261b3", "c02d53a6-06f2-4cbb-9dda-82ee30fc075a" },
                    { "00b26f75-5363-4481-a262-8662f81d95ae", "453716fc-8d75-4755-ac1d-77fde9168531" },
                    { "0a0eb798-5f01-4c97-a232-1cd7ab2bb136", "752ab919-8d0a-4532-89fb-75e7202d72b5" },
                    { "0a0eb798-5f01-4c97-a232-1cd7ab2bb136", "3c967128-6834-41ed-ba20-1d3ae4d633e5" },
                    { "5a758d90-c902-467c-8a07-42608ce261b3", "0486e418-f8eb-4dbf-ac97-f90f248eb0ba" },
                    { "5a758d90-c902-467c-8a07-42608ce261b3", "1feb1f6e-afe1-4be0-b3d6-3f2a1405d4e2" },
                    { "8ba538c4-5c93-4c36-b897-36f77c5265b0", "2dbc4b8e-aa6e-4429-acc5-824a79d7280f" },
                    { "5a758d90-c902-467c-8a07-42608ce261b3", "e9f8b8c7-a992-496e-b2ec-4f2a1504eeab" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "review_id", "review_Comment", "review_HideStatus", "review_ReviewType", "review_UploadTime", "review_UserId" },
                values: new object[,]
                {
                    { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "Good2", false, "Review", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" },
                    { "C2A543C2-B1E2-4DC5-A131-9137E4673FA6", "Good3", false, "Review", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "Good1", false, "Review", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "DE544998-A3CC-4E12-ABB4-0642E57BD222" }
                });

            migrationBuilder.InsertData(
                table: "SubReview",
                columns: new[] { "subReview_Id", "subReview_Commnet", "subReview_DateCommnet", "subReview_HideStatus", "subReview_UserId", "subreview_SubReviewType" },
                values: new object[,]
                {
                    { "a2e47963-18ca-4231-8407-b48b422db085", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", "SubReview" },
                    { "33de4ff9-a947-4881-ab63-3e779f647c2c", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" },
                    { "8d737f02-f87a-4c56-95f7-10110f9a7b6c", "subreview 1", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "360E601E-92F2-4F08-832B-604A21293258", "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" }
                });

            migrationBuilder.InsertData(
                table: "ReviewInproduct",
                columns: new[] { "rip_ProductId", "rip_ReviewId" },
                values: new object[,]
                {
                    { "c02d53a6-06f2-4cbb-9dda-82ee30fc075a", "EEBA6608-AB75-4E83-909F-604B1A06F16C" },
                    { "c02d53a6-06f2-4cbb-9dda-82ee30fc075a", "C2A543C2-B1E2-4DC5-A131-9137E4673FA6" },
                    { "c02d53a6-06f2-4cbb-9dda-82ee30fc075a", "9EED8607-D2BB-45EE-AEE3-C59D858A7F97" }
                });

            migrationBuilder.InsertData(
                table: "SubReviewInReview",
                columns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                values: new object[,]
                {
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "8d737f02-f87a-4c56-95f7-10110f9a7b6c" },
                    { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "33de4ff9-a947-4881-ab63-3e779f647c2c" },
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "a2e47963-18ca-4231-8407-b48b422db085" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_bill_UserId",
                table: "Bills",
                column: "bill_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_cart_UserID",
                table: "Carts",
                column: "cart_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CartsDevice_cartd_DeviceId",
                table: "CartsDevice",
                column: "cartd_DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCart_pic_ProductId",
                table: "ProductInCart",
                column: "pic_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCartDevices_picd_ProductId",
                table: "ProductInCartDevices",
                column: "picd_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInCategories_pic_CategoriesId",
                table: "ProductsInCategories",
                column: "pic_CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewInproduct_rip_ReviewId",
                table: "ReviewInproduct",
                column: "rip_ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_review_UserId",
                table: "Reviews",
                column: "review_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SubReview_subReview_UserId",
                table: "SubReview",
                column: "subReview_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubReviewInReview_SRiR_SubReviewId",
                table: "SubReviewInReview",
                column: "SRiR_SubReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "ContactSystems");

            migrationBuilder.DropTable(
                name: "ContactUsers");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "ProductInCart");

            migrationBuilder.DropTable(
                name: "ProductInCartDevices");

            migrationBuilder.DropTable(
                name: "ProductsInCategories");

            migrationBuilder.DropTable(
                name: "ReviewInproduct");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Shipping");

            migrationBuilder.DropTable(
                name: "SubReviewInReview");

            migrationBuilder.DropTable(
                name: "SubscribeEmail");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserInRoleModel");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "CartsDevice");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "SubReview");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}