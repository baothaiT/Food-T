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
using Food.StatisFile.Function;
using Microsoft.Extensions.Configuration;

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
            string namePc = Environment.MachineName;
            bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userIdString = "";
            if (userId != null)
            {
                userIdString = userId.ToString();
            }
            ViewBag.CountProductInCart = CheckCart.CheckProudctCart(_context, namePc, checkLogin, userIdString);


            try
            {
             
                var userName = User.FindFirstValue(ClaimTypes.Name);

                //Query product in cart
                var query = from a in _context.Products
                            join b in _context.ProductInCart on a.pd_Id equals b.pic_ProductId
                            join c in _context.Cart on b.pic_CartId equals c.cart_Id
                            join d in _context.AppUser on c.cart_UserID equals d.Id
                            select new { a, b, c, d };


                query = query.Where(x => x.d.Id == userId);

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
                ViewBag.Retotal = reTotal;

                //Get CouponPrice In Session
                int discount = GetDiscount();
                ViewBag.Discount = discount;

                

                //Get and set Price of shipping
                //Get Shipping Price

                int ship = GetShippingPrice("ship");

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
            
            
            bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();

            if (checkLogin)
            {
                //logined
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var userName = User.FindFirstValue(ClaimTypes.Name);
                AddBill(userId, checkLogin);
            }
            else
            {
                // No login
                string email = Request.Form["Email"];
                string firstName = Request.Form["FirstName"];
                var user = new AppUser { UserName = firstName, Email = email, EmailConfirmed= true };
                var result = await _UserManager.CreateAsync(user, "123@123Aa");

                string mess = "Account:" + email+ " | Password: 123@123Aa";

                
                if (result.Succeeded)
                {
                    SendMail(email, "New account for food shop", mess);
                    AddBill(user.Id, checkLogin);
                }
            }
            return Redirect("/paymentcomplete");
        }

        public async void AddBill(string userId, bool checklogin)
        {

            string namePc = Environment.MachineName;

            string firstName = Request.Form["FirstName"];
            string country = Request.Form["Country"];
            string lastName = Request.Form["LastName"];
            string address1 = Request.Form["Address"];
            string city = Request.Form["City"];
            string state = Request.Form["State"];
            string postal = Request.Form["Postal"];
            string email = Request.Form["Email"];
            string phone = Request.Form["Phone"];
            
            if(checklogin)
            {
                //Query Database in table -- logined
                var query = from a in _context.Products
                            join b in _context.ProductInCart on a.pd_Id equals b.pic_ProductId
                            join c in _context.Cart on b.pic_CartId equals c.cart_Id
                            join d in _context.AppUser on c.cart_UserID equals d.Id
                            select new { a, b, c, d };

                query = query.Where(x => x.d.Id == userId);

                //Create checkout model -- 2
                var cartDetail = query.Select(a => new CheckOutModel()
                {
                    checkout_ProductName = a.a.pd_Name,
                    checkout_Quantity = a.b.pic_amount,
                    checkout_Price = a.a.pd_Price,
                    Id = a.a.pd_Id
                });

                //Read reTotal -- 2
                int reTotal = 0;
                foreach (var item in cartDetail)
                {
                    reTotal += item.checkout_Price;
                }
                ViewBag.Retotal = reTotal;

                //Read Discount -- 2
                int discount = GetDiscount();
                ViewBag.Discount = discount;

                //Read Shipping -- 2
                int ship = GetShippingPrice("ship");
                ViewBag.Ship = 0;
                ViewBag.Total = reTotal + ship - discount;

                //Create list -- 2
                string productNameList = "";
                string productIdList = "";
                foreach (var item in cartDetail)
                {
                    productNameList += "|" + item.checkout_Quantity + "|" + item.checkout_ProductName;
                    productIdList += "|" + item.Id;
                }

                //Create bill -- 2
                var bill = new Bills()
                {
                    bill_Id = Guid.NewGuid().ToString(),
                    bill_UserId = userId,
                    bill_Discount = discount,
                    bill_Shipping = ship,
                    bill_PaidTotal = reTotal + ship - discount,
                    bill_ProductNamelist = productNameList,
                    bill_PaymentMethod = "Cash on Delivery"
                };
                
                /// Add -- 2
                _context.Bills.Add(bill);

                /// Remove -- logined
                var CartQuery = _context.Cart.FirstOrDefault(x => x.cart_UserID == userId);
                var ProductInCartQueryDelete = _context.ProductInCart.Where(a => a.pic_CartId == CartQuery.cart_Id);
                _context.ProductInCart.RemoveRange(ProductInCartQueryDelete);
                await _context.SaveChangesAsync();
            }
            else
            {
                //Query produdct in Cart
                var query = from a in _context.Products
                            join b in _context.ProductInCartDevices on a.pd_Id equals b.picd_ProductId
                            join c in _context.CartsDevice on b.picd_CartId equals c.cartd_Id
                            join d in _context.Devices on c.cartd_DeviceId equals d.deviceId
                            select new { a, b, c, d };
                query = query.Where(x => x.d.deviceName == namePc);

                //Create checkout model -- 2
                var cartDetail = query.Select(a => new CheckOutModel()
                {
                    checkout_ProductName = a.a.pd_Name,
                    checkout_Quantity = a.b.picd_amount,
                    checkout_Price = a.a.pd_Price,
                    Id = a.a.pd_Id
                });

                //Read reTotal -- 2
                int reTotal = 0;
                foreach (var item in cartDetail)
                {
                    reTotal += item.checkout_Price;
                }
                ViewBag.Retotal = reTotal;

                //Read Discount -- 2
                int discount = GetDiscount();
                ViewBag.Discount = discount;

                //Read Shipping -- 2
                int ship = GetShippingPrice("ship");
                ViewBag.Ship = 0;
                ViewBag.Total = reTotal + ship - discount;

                //Create list -- 2
                string productNameList = "";
                string productIdList = "";
                foreach (var item in cartDetail)
                {
                    productNameList += "|" + item.checkout_Quantity + "|" + item.checkout_ProductName;
                    productIdList += "|" + item.Id;
                }

                //Create bill -- 2
                var bill = new Bills()
                {
                    bill_Id = Guid.NewGuid().ToString(),
                    bill_UserId = userId,
                    bill_Discount = discount,
                    bill_Shipping = ship,
                    bill_PaidTotal = reTotal + ship - discount,
                    bill_ProductNamelist = productNameList,
                    bill_PaymentMethod = "Cash on Delivery"
                };

                /// Add -- 2
                _context.Bills.Add(bill);

                /// Remove -- logined
                
                var queryIdProduct = _context.Devices.FirstOrDefault(x => x.deviceName == namePc);
                var CartQuery = _context.CartsDevice.FirstOrDefault(x => x.cartd_DeviceId == queryIdProduct.deviceId);
                var ProductInCartQueryDelete = _context.ProductInCartDevices.Where(a => a.picd_CartId == CartQuery.cartd_Id);
                _context.ProductInCartDevices.RemoveRange(ProductInCartQueryDelete);
                await _context.SaveChangesAsync();
            }
            
        }


        public void SendMail(string Mailto, string subject, string boddy)
        {
            var smtpacountJson = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("MailSettings")["Mail"];
            var smtppasswordJson = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("MailSettings")["Password"];

            String mailgui = smtpacountJson.ToString();
            string smtpacount = smtpacountJson.ToString();
            string smtppassword = smtppasswordJson.ToString();

            MailUtils.MailUtils.SendMailGoogleSmtp(
                mailgui,
                Mailto,
                subject,
                boddy,
                smtpacount,
                smtppassword

            ).Wait();
        }

        private int GetDiscount()
        {
            int discount = 0;
            if ((HttpContext.Session.GetString(KeySession.sessionCouponPrice) == null) || (HttpContext.Session.GetString(KeySession.sessionCouponPrice) == ""))
            {
                ViewBag.CouponPrice = 0;
            }
            else
            {
                discount = Int32.Parse(HttpContext.Session.GetString(KeySession.sessionCouponPrice));
                ViewBag.CouponPrice = HttpContext.Session.GetString(KeySession.sessionCouponPrice);
            }
            return discount;
        }

        private int GetShippingPrice(string NameShip)
        {
            var shipingQuery = _context.Shipping.FirstOrDefault(a => a.ship_Name == NameShip);
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
            return ship;
        }
    }


}
