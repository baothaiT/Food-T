using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Food.Data;
using Food.Models;

namespace Food.Controllers.System
{
    public class FoodController : Controller
    {

        private readonly ApplicationDbContext _context;

        public FoodController(ApplicationDbContext context)
        {
            _context = context;
        }


        [Route("/food")]
        [HttpGet("{categoriesName}")]
        public IActionResult Index(string categoriesName)
        {
            //Count product in cart page
            var queryCart = _context.CartsDevice;
            ViewBag.CountProductInCart = queryCart.Count();
            
            //Food
            var query = from a in _context.Products
                        join b in _context.ProductsInCategories on a.pd_Id equals b.pic_productId
                        join c in _context.Categories on b.pic_CategoriesId equals c.cg_Id
                        select new { a, c };
            if ((categoriesName == "")|| (categoriesName == null))
            {
                query = query.Where(x => x.c.cg_Name == categoriesName);
            }

            var productModelQuery = query
                .Select(x => new ProductModel()
                {
                    pd_Id = x.a.pd_Id,
                    pd_Img1 = x.a.pd_Img1,
                    pd_Name = x.a.pd_Name,
                    pd_Price = x.a.pd_Price,
                    pd_categoryName = x.c.cg_Name,
                    pd_ReducePrice = x.a.pd_ReducePrice
                });
            return View(productModelQuery);
        }


    }
}
