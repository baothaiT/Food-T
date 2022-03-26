﻿using Microsoft.AspNetCore.Identity;
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

            //Query Database in table
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
            var shipingQuery = _context.Shipping.FirstOrDefault(a => a.ship_Name == "ship");

           
            int reTotal = 0;
            foreach (var item in cartDetail)
            {
                reTotal += item.checkout_Price;
            }
            ViewBag.Retotal = reTotal;
            //Discount 
            int discount = GetDiscount();

            ViewBag.Discount = discount;
            
            //Shipping
            int ship = GetShippingPrice("ship");
            ViewBag.Ship = 0;

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
