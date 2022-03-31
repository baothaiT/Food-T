using System;
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
                    Contact_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Contact_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "Snack", "", "" },
                    { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "Dry food", "", "" },
                    { "18236757-322e-45ed-ba73-aaf7e8a3a4b7", "Food", "", "" },
                    { "1cc98150-48a1-4783-b933-17d316906ca5", "Drink", "", "" },
                    { "c2353234-ed9e-4d4b-a087-f25a71cdcac5", "Banhmi", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ContactSystems",
                columns: new[] { "Contact_Id", "Contact_Address", "Contact_Description", "Contact_Email", "Contact_Phone" },
                values: new object[] { "f9044bc9-530b-4de0-b0d4-89bcf3181642", "Huntsville, AL 35813, USA", "Prof Lord John Krebs provides a brief history of human food, from our remote ancestors 3 million years ago to the present day. By looking at the four great transitions in human food - cooking, agriculture, processing, and preservation - he considers a variety of questions, including why people like some kinds of foods and not others; how your senses contribute to flavor; the role of genetics in our likes and dislikes; and the differences in learning and culture around the world.", "support@foodshop.com ", "021.343.7575" });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cu_Id", "cu_Description", "cu_Email", "cu_FirstName", "cu_LastName", "cu_Subject" },
                values: new object[] { "28064fbc-8cdf-4c65-bc96-cf5014158295", "Description", "Email", "FirstName", "LastName", "Subject" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "couponCode", "couponPrice" },
                values: new object[,]
                {
                    { "6c833965-b764-4e8b-bc85-a108b3ece232", "code50", 50 },
                    { "2df89354-6e08-47d2-8b42-9ffaf3147050", "code10", 10 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_WaitForConfirmation" },
                values: new object[,]
                {
                    { "7fbd8fce-55f0-4d87-87c7-ab0ceeb44948", "Sanfulou", "/images/item250x300/Sanfulou.png", "", "", "", "Sanfulou", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "f06aa333-4851-4011-95c0-cda7aba28e84", "stacbuk-cf", "/images/item250x300/stacbuk-cf.png", "", "", "", "stacbuk-cf", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "55f7b643-ebca-40e1-b592-8811ba0ae3ba", "goicuon", "/images/item250x300/goicuon.png", "", "", "", "goicuon", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "1c16a5b8-787c-429f-8fc9-ee6b71c02d8f", "trasuanhalam", "/images/item250x300/trasuanhalam.png", "", "", "", "trasuanhalam", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "fcf6009d-f719-402d-80ad-2d6ee8040963", "RauMaMix", "/images/item250x300/RauMaMix.png", "", "", "", "RauMaMix", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "60c0e2bb-a07b-4a03-9cd7-44226a2cda01", "quanngontrangbang", "/images/item250x300/quanngontrangbang.png", "", "", "", "quanngontrangbang", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "49cb5a13-cf57-423c-954b-0d95f8c69a8a", "pizza", "/images/item250x300/pizza.png", "", "", "", "pizza", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "d80b0de3-9f4a-4482-8a54-e984aa2caed8", "ParisBaguete", "/images/item250x300/ParisBaguete.png", "", "", "", "ParisBaguete", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "8e28728f-725f-41f9-95be-e6e6ce83b1d6", "monngontrangbang", "/images/item250x300/monngontrangbang.png", "", "", "", "monngontrangbang", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "3a0e245a-d641-4ff7-b4de-c4ea64c837de", "mitronanvat", "/images/item250x300/mitronanvat.png", "", "", "", "mitronanvat", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "3497483f-ef59-4d93-b8e1-f4daf4c2ea1f", "loteria", "/images/item250x300/loteria.png", "", "", "", "loteria", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "980b9440-4392-4f3e-a339-d943a264ba93", "KimBap", "/images/item250x300/KimBap.png", "", "", "", "KimBap", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "8e5769df-3c2e-4634-9d19-c732af2ad555", "kfc", "/images/item250x300/kfc.png", "", "", "", "kfc", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "1c3c1297-782f-4729-a1ec-a326c91bfcbb", "Royaltea", "/images/item250x300/Royaltea.png", "", "", "", "Royaltea", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "232d9499-2e3f-490f-8541-45e08e12cc1e", "denhatthitnuong", "/images/item250x300/denhatthitnuong.png", "", "", "", "denhatthitnuong", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "d28ca46d-4808-4f94-9564-edfab255aa8e", "Bunxaochay", "/images/item250x300/Bunxaochay.png", "", "", "", "Bunxaochay", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "4464c176-42bc-4d8f-8ad4-9f37b50a98c7", "comga", "/images/item250x300/comga.png", "", "", "", "comga", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "5cc4b048-3bb8-4d2e-bfe3-4e7ded9559ea", "BanhCanhCua", "/images/item250x300/BanhCanhCua.png", "", "", "", "BanhCanhCua", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "489cd014-4707-400f-919e-4fbb346d205f", "BanhMi", "/images/item250x300/BanhMi.png", "", "", "", "BanhMi", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "47c84d2e-8da9-44d1-894f-e628c3a7de4c", "comgadenhat", "/images/item250x300/comgadenhat.png", "", "", "", "comgadenhat", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "38748005-289d-4ef7-9a49-fa1138b6cd00", "banhuotlongdalat", "/images/item250x300/banhuotlongdalat.png", "", "", "", "banhuotlongdalat", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "94a72205-0018-457b-bc59-916c38dcb9d0", "BoKho", "/images/item250x300/BoKho.png", "", "", "", "BoKho", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "8d142bf2-ef31-4a24-bd9b-784612b1d77e", "banhtrangtron", "/images/item250x300/banhtrangtron.png", "", "", "", "banhtrangtron", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "af35f87e-4dd0-4fe0-9862-62d0dee0c2fd", "bundaumamtom", "/images/item250x300/bundaumamtom.png", "", "", "", "bundaumamtom", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "511557c2-0003-4506-80d1-5c5332b6c58f", "Xoixeoba3beo", "/images/item250x300/Xoixeoba3beo.png", "", "", "", "Xoixeoba3beo", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "9ed428bf-1a86-41c2-90af-39f7507ca227", "cocosummer", "/images/item250x300/cocosummer.png", "", "", "", "cocosummer", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "3897bf54-af14-4dba-8dc5-b476a7c525cc", "comboxao", "/images/item250x300/comboxao.png", "", "", "", "comboxao", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "1457e167-87bd-4555-ae4e-0b4a1448e821", "bunbo", "/images/item250x300/bunbo.png", "", "", "", "bunbo", "1", "2", "3", "4", 1, 5, 0, "Short Description", false }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "360E601E-92F2-4F08-832B-604A21293258", "ead41db7-221b-4b99-ae8d-f2391b11028e", "Admin", "AppRole", "Admin", "admin" },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "de96fc9a-321b-4f56-a7a8-62dc16b0f6b4", "Staff", "AppRole", "Staff", "staff" }
                });

            migrationBuilder.InsertData(
                table: "Shipping",
                columns: new[] { "ship_Id", "ship_Name", "ship_Price" },
                values: new object[] { "7CF94A7D-9239-446E-A404-086518F84652", "Ship", 5 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "bill_Address1", "bill_Address2", "bill_City", "bill_CompanyName", "bill_Country", "bill_PhoneNumber", "bill_PostalCode", "bill_State" },
                values: new object[] { "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", 0, "1e593df0-89c0-4753-89b4-66816bde502c", "AppUser", new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@gmail.com", true, "staff", "staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEN6V67vweSFKXa/wtIbnrIBR8EWFGqa8fq16Dm9umrcqNJcBNy8HCf+UhgEtmeyiUA==", null, false, "6bc82d2a-2f94-4daf-abdf-4715c7c29160", false, "Staff", null, null, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "bill_Address1", "bill_Address2", "bill_City", "bill_CompanyName", "bill_Country", "bill_PhoneNumber", "bill_PostalCode", "bill_State" },
                values: new object[] { "DE544998-A3CC-4E12-ABB4-0642E57BD222", 0, "6a89164b-e1e9-4157-a972-956de4a83bbd", "AppUser", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "admin", "admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEC9hwtTPOq4VE5rc134sjsFaCRT5BAg6dnJT3noTT1Hr3gln1nSSN6oG+xmuQDsN8Q==", null, false, "559011d2-e696-4bbf-a3f1-9635492561c6", false, "Admin", null, null, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "bill_Cancelled", "bill_Confirmation", "bill_DatetimeOrder", "bill_Delivered", "bill_Delivering", "bill_Discount", "bill_HideStatus", "bill_Note", "bill_PaidTotal", "bill_PaymentMethod", "bill_ProductColorlist", "bill_ProductIdlist", "bill_ProductNamelist", "bill_ProductPricelist", "bill_ProductSizelist", "bill_Quantity", "bill_Shipping", "bill_UserId", "bill_WaitForConfirmation", "bill_WaitPickup" },
                values: new object[] { "D269BF93-A5E2-4C4A-8146-9967DDE80D30", false, true, new DateTime(2022, 4, 1, 5, 4, 28, 115, DateTimeKind.Local).AddTicks(2515), false, false, 0, false, "", 2000, "Check Payment", null, "1|2|3|4", "product 1|product 2| product 3| product 4|", "550|450|350|640|", null, "1|1|2|1|", 10, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", false, false });

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
                    { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "47c84d2e-8da9-44d1-894f-e628c3a7de4c" },
                    { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "232d9499-2e3f-490f-8541-45e08e12cc1e" },
                    { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "55f7b643-ebca-40e1-b592-8811ba0ae3ba" },
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "8e5769df-3c2e-4634-9d19-c732af2ad555" },
                    { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "980b9440-4392-4f3e-a339-d943a264ba93" },
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "3497483f-ef59-4d93-b8e1-f4daf4c2ea1f" },
                    { "c2353234-ed9e-4d4b-a087-f25a71cdcac5", "3a0e245a-d641-4ff7-b4de-c4ea64c837de" },
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "d80b0de3-9f4a-4482-8a54-e984aa2caed8" },
                    { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "4464c176-42bc-4d8f-8ad4-9f37b50a98c7" },
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "49cb5a13-cf57-423c-954b-0d95f8c69a8a" },
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "60c0e2bb-a07b-4a03-9cd7-44226a2cda01" },
                    { "1cc98150-48a1-4783-b933-17d316906ca5", "fcf6009d-f719-402d-80ad-2d6ee8040963" },
                    { "1cc98150-48a1-4783-b933-17d316906ca5", "1c3c1297-782f-4729-a1ec-a326c91bfcbb" },
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "7fbd8fce-55f0-4d87-87c7-ab0ceeb44948" },
                    { "1cc98150-48a1-4783-b933-17d316906ca5", "f06aa333-4851-4011-95c0-cda7aba28e84" },
                    { "18236757-322e-45ed-ba73-aaf7e8a3a4b7", "8e28728f-725f-41f9-95be-e6e6ce83b1d6" },
                    { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "3897bf54-af14-4dba-8dc5-b476a7c525cc" },
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "9ed428bf-1a86-41c2-90af-39f7507ca227" },
                    { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "d28ca46d-4808-4f94-9564-edfab255aa8e" },
                    { "1cc98150-48a1-4783-b933-17d316906ca5", "1c16a5b8-787c-429f-8fc9-ee6b71c02d8f" },
                    { "18236757-322e-45ed-ba73-aaf7e8a3a4b7", "5cc4b048-3bb8-4d2e-bfe3-4e7ded9559ea" },
                    { "c2353234-ed9e-4d4b-a087-f25a71cdcac5", "489cd014-4707-400f-919e-4fbb346d205f" },
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "8d142bf2-ef31-4a24-bd9b-784612b1d77e" },
                    { "07cf1e23-2691-4923-80f0-efbecef94a5c", "511557c2-0003-4506-80d1-5c5332b6c58f" },
                    { "18236757-322e-45ed-ba73-aaf7e8a3a4b7", "94a72205-0018-457b-bc59-916c38dcb9d0" },
                    { "18236757-322e-45ed-ba73-aaf7e8a3a4b7", "1457e167-87bd-4555-ae4e-0b4a1448e821" },
                    { "bd7f2c9a-44c8-442a-9128-296acc7111c3", "af35f87e-4dd0-4fe0-9862-62d0dee0c2fd" },
                    { "18236757-322e-45ed-ba73-aaf7e8a3a4b7", "38748005-289d-4ef7-9a49-fa1138b6cd00" }
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
                    { "60b032c6-3cd1-43f8-9777-bdbe23677589", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", "SubReview" },
                    { "f80033ea-49ca-477c-8f96-7aaaa96f91fb", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" },
                    { "134597a7-e2f9-4ff7-8ec4-2890a6357981", "subreview 1", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" }
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
                    { "5cc4b048-3bb8-4d2e-bfe3-4e7ded9559ea", "EEBA6608-AB75-4E83-909F-604B1A06F16C" },
                    { "5cc4b048-3bb8-4d2e-bfe3-4e7ded9559ea", "C2A543C2-B1E2-4DC5-A131-9137E4673FA6" },
                    { "5cc4b048-3bb8-4d2e-bfe3-4e7ded9559ea", "9EED8607-D2BB-45EE-AEE3-C59D858A7F97" }
                });

            migrationBuilder.InsertData(
                table: "SubReviewInReview",
                columns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                values: new object[,]
                {
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "134597a7-e2f9-4ff7-8ec4-2890a6357981" },
                    { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "f80033ea-49ca-477c-8f96-7aaaa96f91fb" },
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "60b032c6-3cd1-43f8-9777-bdbe23677589" }
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
