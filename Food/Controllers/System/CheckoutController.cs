using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Food.Data;
using Food.Entity;
using Food.Models;
using Food.StatisFile;
using Microsoft.AspNetCore.Http;

namespace Food.Controllers.System
{
    public class CheckoutController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<AppUser> _SignInManager;
        private readonly UserManager<AppUser> _UserManager;

        public CheckoutController(ApplicationDbContext context, UserManager<AppUser> UserManager, SignInManager<AppUser> SignInManager)
        {
            _context = context;
            _UserManager = UserManager;
            _SignInManager = SignInManager;
        }



        [Route("/checkout")]
        [HttpGet]
        public IActionResult Index()
        {
            //Count product in cart page
            var queryCart = _context.CartsDevice;
            ViewBag.CountProductInCart = queryCart.Count();

            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var userName = User.FindFirstValue(ClaimTypes.Name);

                //Query product in cart
                var query = from a in _context.Products
                            join b in _context.ProductInCart on a.pd_Id equals b.pic_ProductId
                            join c in _context.Cart on b.pic_CartId equals c.cart_Id
                            join d in _context.AppUser on c.cart_UserID equals d.Id
                            select new { a, b, c, d };


                query = query.Where(x => x.d.Id == userId);

                //// Product list
                //var productInCartModelQuery = query
                //    .Select(x => new ProductInCartModel()
                //    {
                //        ProductId = x.a.pd_Id,
                //        ProductName = x.a.pd_Name,
                //        ProductPrice = x.a.pd_Price,
                //        ProductImg1 = x.a.pd_Img1,
                //        Quantity = x.b.pic_amount,
                //        UserId = x.d.Id,
                //        Color = x.b.pic_color,
                //        Size = x.b.pic_size

                //    });


                var cartDetail = query.Select(a => new CheckOutModel()
                {
                    checkout_ProductName = a.a.pd_Name,
                    checkout_Quantity = a.b.pic_amount,
                    checkout_Price = a.a.pd_Price
                });

                

                
                // Get ReTotal
                int reTotal = 0;
                foreach (var item in cartDetail)
                {
                    reTotal += item.checkout_Price;
                }

                //Get CouponPrice In Session
                int discount;
                if ((HttpContext.Session.GetString(KeySession.sessionCouponPrice) == null) || (HttpContext.Session.GetString(KeySession.sessionCouponPrice) == ""))
                {
                    ViewBag.Discount = 0;
                    discount = 0;
                }
                else
                {
                    ViewBag.Discount = HttpContext.Session.GetString(KeySession.sessionCouponPrice);
                    discount = Int32.Parse(HttpContext.Session.GetString(KeySession.sessionCouponPrice)); 
                }

                ViewBag.Retotal = reTotal;

                //Get and set Price of shipping
                //Get Shipping Price
                var shipingQuery = _context.Shipping.FirstOrDefault(a => a.ship_Name == "ship");
                int ship;
                if (shipingQuery != null)
                {
                    ship = shipingQuery.ship_Price;
                    ViewBag.Ship = shipingQuery.ship_Price;
                }
                else
                {
                    ship = 0;
                    ViewBag.Ship = 0;
                }

                ViewBag.Total = reTotal + ship - discount;

                return View(cartDetail);
            }
            catch
            {

                return View();
            }

        }

        [Route("/checkout/Add")]
        [HttpPost]
        public async Task<IActionResult> AddToBill()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = User.FindFirstValue(ClaimTypes.Name);

            string firstName = Request.Form["FirstName"];
            string country = Request.Form["Country"];
            string lastName = Request.Form["LastName"];
            string address1 = Request.Form["Address"];
            string city = Request.Form["City"];
            string state = Request.Form["State"];
            string postal = Request.Form["Postal"];
            string email = Request.Form["Email"];
            string phone = Request.Form["Phone"];

            string address2 = Request.Form["Address2"];
            string reducePrice = Request.Form["Reduceprice"];

            //Query Database in table
            var query = from a in _context.Products
                        join b in _context.ProductInCart on a.pd_Id equals b.pic_ProductId
                        join c in _context.Cart on b.pic_CartId equals c.cart_Id
                        join d in _context.AppUser on c.cart_UserID equals d.Id
                        select new { a, b, c, d };

            query = query.Where(x => x.d.Id == userId);

            var productInCartModelQuery = query
                .Select(x => new ProductInCartModel()
                {
                    ProductId = x.a.pd_Id,
                    ProductName = x.a.pd_Name,
                    ProductPrice = x.a.pd_Price,
                    ProductImg1 = x.a.pd_Img1,
                    Quantity = x.b.pic_amount,
                    UserId = x.d.Id,
                    Color = x.b.pic_color,
                    Size = x.b.pic_size
                });


            var cartDetail = query.Select(a => new CheckOutModel()
            {
                checkout_ProductName = a.a.pd_Name,
                checkout_Quantity = a.b.pic_amount,
                checkout_Price = a.a.pd_Price
            });
            var shipingQuery = _context.Shipping.FirstOrDefault(a => a.ship_Name == "ship");

            ViewBag.Discount = reducePrice;
            int reTotal = 0;
            foreach (var item in cartDetail)
            {
                reTotal += item.checkout_Price;
            }

            ViewBag.Retotal = reTotal;
            ViewBag.Ship = 0;
            int ship = 0;

            if (shipingQuery != null)
            {
                string a = shipingQuery.ship_Price.ToString();
                ship = Int32.Parse(a);
                ViewBag.Ship = ship;
            }

            int discount = Int32.Parse(reducePrice.ToString());
            ViewBag.Total = reTotal + ship - discount;

            string productNameList = "";
            foreach (var item in cartDetail)
            {
                productNameList += "|" + item.checkout_Quantity + "|" + item.checkout_ProductName;
            }

            var bill = new Bills()
            {
                bill_Id = Guid.NewGuid().ToString(),
                bill_UserId = userId,
                bill_Discount = discount,
                bill_Shipping = ship,
                bill_PaidTotal = reTotal + ship - discount,
                bill_ProductNamelist = productNameList
            };

            /// Add
            _context.Bills.Add(bill);

            /// Remove
            var CartQuery = _context.Cart.FirstOrDefault(x => x.cart_UserID == userId);

            var ProductInCartQueryDelete = _context.ProductInCart.Where(a => a.pic_CartId == CartQuery.cart_Id);

            _context.ProductInCart.RemoveRange(ProductInCartQueryDelete);
            await _context.SaveChangesAsync();
            return Redirect("/paymentcomplete");
        }



    }
}
