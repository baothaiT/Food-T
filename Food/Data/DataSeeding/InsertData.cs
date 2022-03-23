using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Food.Entity;

namespace Food.Data.DataSeeding
{
    public static class InsertData
    {
        public static void Seed(this ModelBuilder builder)
        {


            //var hasher = new PasswordHasher<AppUsers>();



            //Table Products
            builder.Entity<Products>().HasData(
                new Products()
                {
                    pd_Id = 1,
                    pd_Name = "Fish",
                    pd_Description = "Description",
                    pd_Price = 1,
                    pd_ReducePrice = 0,
                    pd_Img1 = "https://drive.google.com/uc?id=1y-bME8oi9DccN-zG_Eo-aChLBs8pwVEI",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1YBpU6fwcCzV18ho__mhCCO0yD8ES-ef7",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1sBANC4Og5eumFJBTVLYGIp2qTBKfwSzh",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1A74yTUs0Lmya24nL5UPG8N6cV7GFhn5a",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "Short Description",
                    pd_Size = "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48",
                    pd_Brand = "Nike",
                    pd_Style = "CW2288-111",
                    pd_Color = "White/White",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 =true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 =true,
                    pd_Size12 =true,
                    pd_Size12_5= true,
                    pd_Size13_5=true,
                    pd_Size14 = true,
                    pd_Size14_5 =true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4"


                }
                );




        //Table About
        builder.Entity<About>().HasData(
                new About()
                {
                    about_id=1,
                    about_Url= "https://www.youtube.com/watch?v=F1vcruph8JA",
                    about_Title = "Footwear the leading eCommerce Store around the Globe",
                    about_Description = "The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. \n \n When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove,the headline of Alphabet Village and the subline of her own road,the Line Lane.Pityful a rethoric question ran over her cheek,then she continued her way."
                });

            var IdRoleStaff = "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd";
            var IdRoleAdmin = "360E601E-92F2-4F08-832B-604A21293258";



            //Table AppRole 2222222222222222222222222222222222222222222222222222222222222222222

            builder.Entity<AppRole>().HasData(
                new AppRole()
                {
                    Id = IdRoleStaff,
                    Name ="staff",
                    Description = "Staff"
                },
                new AppRole()
                {
                    Id = IdRoleAdmin,
                    Name = "admin",
                    Description = "admin"
                });


            var IdStaff = "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff";
            var IdAdmin = "DE544998-A3CC-4E12-ABB4-0642E57BD222";

            //Table AppUser 2222222222222222222222222222222222222222222222222222222222222222222

            var hasher = new PasswordHasher<AppUser>();

            builder.Entity<AppUser>().HasData(
            new AppUser
            {
                Id = IdAdmin,
                UserName = "Admin",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = "admin",
                LastName = "admin",
                DoB = new DateTime(2020, 01, 02)

            },
            new AppUser
            {
                Id = IdStaff,
                UserName = "Staff",
                NormalizedUserName = "STAFF@GMAIL.COM",
                NormalizedEmail = "STAFF@GMAIL.COM",
                Email = "staff@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = "staff",
                LastName = "staff",
                DoB = new DateTime(2020, 03, 02)

            });


            //Table AppUser - role 2222222222222222222222222222222222222222222222222222222222222222222
            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = IdRoleStaff,
                UserId = IdStaff
            },
            new IdentityUserRole<string>
            {
                RoleId = IdRoleAdmin,
                UserId = IdAdmin
            });





            var IdCart1 = "72309286-ECBB-4D20-AD95-2819D31E3400";
            var IdCart2 = "D355458F-1DD3-4834-AA28-6DA34B6357FF";


            //Table Cart

            builder.Entity<Cart>().HasData(
                new Cart()
                {
                    cart_Id = IdCart1,
                    cart_UserID = IdStaff

                },
                new Cart()
                {
                    cart_Id = IdCart2,
                    cart_UserID = IdAdmin

                });


            //Table Product In Cart

            builder.Entity<ProductInCart>().HasData(
                new ProductInCart()
                {
                     pic_CartId = IdCart2,
                     pic_ProductId =1,
                     pic_amount = 2,
                     pic_size = "7",
                     pic_color = "blue"

                });


            //Table Categories





            builder.Entity<Categories>().HasData(
                new Categories()
                {
                    cg_Id = 1,
                    cg_Name = "women",
                    cg_Type = "",
                    cg_Sale = ""

                },
                new Categories()
                {
                    cg_Id = 2,
                    cg_Name = "Man",
                    cg_Type = "",
                    cg_Sale = ""

                });





            //Table ContactSystem

            builder.Entity<ContactSystem>().HasData(
                new ContactSystem()
                {
                    Contact_Id = 1,
                    Contact_Address = " 123, An Lac A Ward, Binh Tan District, HCM",
                    Contact_Phone = "0123456789",
                    Contact_Email = "admin@gmail.com",
                    Contact_Website = "https://shoes.com"


                });



            //Table ContactUsers


            builder.Entity<ContactUsers>().HasData(
                new ContactUsers()
                {
                    cu_Id = 1,
                    cu_FirstName = "FirstName",
                    cu_LastName = "LastName",
                    cu_Email = "Email",
                    cu_Subject = "Subject",
                    cu_Description = "Description"
                });


            var ReviewId1 = "EEBA6608-AB75-4E83-909F-604B1A06F16C";
            var ReviewId2 = "9EED8607-D2BB-45EE-AEE3-C59D858A7F97";
            var ReviewId3 = "C2A543C2-B1E2-4DC5-A131-9137E4673FA6";




            //Table Reviews new DateTime(2020, 01, 02)


            builder.Entity<Reviews>().HasData(
                new Reviews()
                {
                    review_id = ReviewId1,
                    review_Comment = "Good1",
                    review_UserId = IdAdmin,
                    review_UploadTime = new DateTime(2020, 01, 02),
                    review_HideStatus = false,
                    review_ReviewType = "Review"

                },
                new Reviews()
                {
                    review_id = ReviewId2,
                    review_Comment = "Good2",
                    review_UserId = IdStaff,
                    review_UploadTime = new DateTime(2020, 01, 02),
                    review_HideStatus = false,
                    review_ReviewType = "Review"

                },
                new Reviews()
                {
                    review_id = ReviewId3,
                    review_Comment = "Good3",
                    review_UserId = IdAdmin,
                    review_UploadTime = new DateTime(2020, 01, 02),
                    review_HideStatus = false,
                    review_ReviewType = "Review"

                });

            var SubReviewId1 = Guid.NewGuid().ToString(); 
            var SubReviewId2 = Guid.NewGuid().ToString();
            var SubReviewId3 = Guid.NewGuid().ToString();


            // Table SubReview 

            builder.Entity<SubReview>().HasData(
                new SubReview()
                {
                    subReview_Id = SubReviewId1,
                    subReview_UserId = IdAdmin,
                    subReview_Commnet = "subreview 1",
                    subReview_DateCommnet = new DateTime(2020, 01, 02),
                    subReview_HideStatus = false,
                    subreview_SubReviewType = "SubReview"
                },
                new SubReview()
                {
                    subReview_Id = SubReviewId2,
                    subReview_UserId = IdStaff,
                    subReview_Commnet = "subreview 3",
                    subReview_DateCommnet = new DateTime(2020, 01, 03),
                    subReview_HideStatus = false,
                    subreview_SubReviewType = "SubReview"
                },
                new SubReview()
                {
                    subReview_Id = SubReviewId3,
                    subReview_UserId = IdAdmin,
                    subReview_Commnet = "subreview 3",
                    subReview_DateCommnet = new DateTime(2020, 01, 03),
                    subReview_HideStatus = false,
                    subreview_SubReviewType = "SubReview"
                }
                );

            builder.Entity<SubReviewInReview>().HasData(
                new SubReviewInReview()
                {
                    SRiR_ReviewId = ReviewId1,
                    SRiR_SubReviewId = SubReviewId1
                },
                new SubReviewInReview()
                {
                    SRiR_ReviewId = ReviewId1,
                    SRiR_SubReviewId = SubReviewId2
                },
                new SubReviewInReview()
                {
                    SRiR_ReviewId = ReviewId2,
                    SRiR_SubReviewId = SubReviewId3
                }
                );

            //Table ProductInCategories
            builder.Entity<ProductsInCategories>().HasData(
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 1
                });


            //Table ProductInCategories





            //Table ReviewInproduct



            builder.Entity<ReviewInproduct>().HasData(
                new ReviewInproduct()
                {
                    rip_ProductId = 1,
                    rip_ReviewId = ReviewId1,
                },
                new ReviewInproduct()
                {
                    rip_ProductId = 1,
                    rip_ReviewId = ReviewId2,
                },
                new ReviewInproduct()
                {
                    rip_ProductId = 1,
                    rip_ReviewId = ReviewId3,
                });


            builder.Entity<Coupons>().HasData(
                new Coupons()
                {
                    couponId = Guid.NewGuid().ToString(),
                    couponCode ="code10",
                    couponPrice = 10
                },
                new Coupons()
                {
                    couponId = Guid.NewGuid().ToString(),
                    couponCode = "code50",
                    couponPrice = 50
                });



            string billId1 = "D269BF93-A5E2-4C4A-8146-9967DDE80D30";
            string billId2 = "AFD66490-12F5-4EA7-BFF6-425624290D6D";

            //Table Bills

            builder.Entity<Bills>().HasData(
                new Bills()
                {
                    bill_Id = billId1,
                    bill_UserId = IdStaff,
                    bill_PaidTotal = 2000,
                    bill_ProductIdlist = "1|2|3|4",
                    bill_ProductNamelist = "product 1|product 2| product 3| product 4",
                    bill_ProductSizelist = "7|8|9|14",
                    bill_ProductColorlist = "Blue|Red|Black|Green",
                    bill_ProductPricelist = "550|450|350|640",
                    bill_Shipping = 10,
                    bill_Discount = 0,
                    bill_Confirmation = true,
                    bill_DatetimeOrder = DateTime.Now,
                    bill_PaymentMethod = "Check Payment",
                    bill_Note = "",
                    bill_Quantity = "1|1|2|1",
                    bill_HideStatus = false,
                    bill_WaitForConfirmation = false,
                    bill_WaitPickup = false,
                    bill_Delivering = false,
                    bill_Delivered =  false,
                    bill_Cancelled = false
                }); ;

            //Table Shiping

            string shipId = "7CF94A7D-9239-446E-A404-086518F84652";

            builder.Entity<Shipping>().HasData(
                new Shipping()
                {
                    ship_Id = shipId,
                    ship_Name ="Ship",
                    ship_Price = 5
                });


        }    
                
               
    }   
}
