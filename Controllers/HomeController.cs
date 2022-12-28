using Aspnetsiu.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aspnetsiu.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            List<Category> categories = new List<Category>();
            List<Slider> sliders = new List<Slider>();

            //Categories
            categories.Add(new Category { Name = "Paltar", Img = "cat-1.jpg", Id = 1 , Products=products});
            categories.Add(new Category { Name = "Kamera",Img = "cat-2.jpg", Id=2 , Products=products});
            categories.Add(new Category { Name = "Ayaqqabi", Img = "cat-3.jpg", Id = 3, Products = products });
            categories.Add(new Category { Name = "Krem", Img = "cat-4.jpg", Id = 4, Products = products });
            categories.Add(new Category { Name = "Krem", Img = "cat-4.jpg", Id = 8, Products = products });
            categories.Add(new Category { Name = "Ayaqqabi", Img = "cat-3.jpg", Id = 7, Products = products });
            categories.Add(new Category { Name = "Kamera", Img = "cat-2.jpg", Id = 6, Products = products });
            categories.Add(new Category { Name = "Paltar", Img = "cat-1.jpg", Id = 9, Products = products });
            categories.Add(new Category { Name = "Kamera", Img = "cat-2.jpg", Id = 10, Products = products });
            categories.Add(new Category { Name = "Paltar", Img = "cat-1.jpg", Id = 5, Products = products });
            categories.Add(new Category { Name = "Krem", Img = "cat-4.jpg", Id = 12, Products = products });
            categories.Add(new Category { Name = "Ayaqqabi", Img = "cat-3.jpg", Id = 11, Products = products });

            //Product
            products.Add(new Product{Name = "Camera",DiscountPrice = 123.00f, Price = 210.00f, Description = "camerayam satiliram",Img = "product-1.jpg"});
            products.Add(new Product{Name = "Koynek", DiscountPrice = 30.00f, Price = 45.00f, Description = "koyneyem satiliram",Img = "product-2.jpg"});
            products.Add(new Product{Name = "Lampa", DiscountPrice = 21.00f, Price = 54.00f, Description = "lampayam satiliram",Img = "product-3.jpg"});
            products.Add(new Product{Name = "Nike", DiscountPrice = 99.00f, Price = 178.00f, Description = "ayaqqabiyam satiliram", Img = "product-4.jpg"});
            products.Add(new Product{Name = "Dron", DiscountPrice = 400.00f, Price = 600.00f, Description = "dronam satiliram",Img = "product-5.jpg"});
            products.Add(new Product{Name = "Apple Watch", DiscountPrice = 99.99f, Price = 145.00f, Description = "saatam satiliram",Img = "product-6.jpg"});
            products.Add(new Product{Name = "Paltar", DiscountPrice = 50.00f, Price = 76.00f,Description = "paltaram satiliram",Img = "product-7.jpg"});
            products.Add(new Product{Name = "Krem", DiscountPrice = 21.00f,Price=30.00f,Description = "kremem satiliram",Img = "product-8.jpg"});

            //Slider
            sliders.Add( new Slider {Id=1,Title="Men Fashion", Description="sortikle ireli",Img= "carousel-1.jpg" });
            sliders.Add(new Slider { Id = 2, Title = "Women Fashion", Description = "cropla ireli", Img = "carousel-2.jpg" });
            sliders.Add(new Slider { Id = 3, Title = "Kids Fashion", Description = "coplu sokla ireli", Img = "carousel-3.jpg" });
            ViewBag.Sliders = sliders;
            ViewBag.Categories = categories;
            return View(products);
        }
        public IActionResult Shop()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Name = "Camera", DiscountPrice = 123.00f, Price = 210.00f, Description = "camerayam satiliram", Img = "product-1.jpg" });
            products.Add(new Product { Name = "Koynek", DiscountPrice = 30.00f, Price = 45.00f, Description = "koyneyem satiliram", Img = "product-2.jpg" });
            products.Add(new Product { Name = "Lampa", DiscountPrice = 21.00f, Price = 54.00f, Description = "lampayam satiliram", Img = "product-3.jpg" });
            products.Add(new Product { Name = "Nike", DiscountPrice = 99.00f, Price = 178.00f, Description = "ayaqqabiyam satiliram", Img = "product-4.jpg" });
            products.Add(new Product { Name = "Dron", DiscountPrice = 400.00f, Price = 600.00f, Description = "dronam satiliram", Img = "product-5.jpg" });
            products.Add(new Product { Name = "Apple Watch", DiscountPrice = 99.99f, Price = 145.00f, Description = "saatam satiliram", Img = "product-6.jpg" });
            products.Add(new Product { Name = "Paltar", DiscountPrice = 50.00f, Price = 76.00f, Description = "paltaram satiliram", Img = "product-7.jpg" });
            products.Add(new Product { Name = "Krem", DiscountPrice = 21.00f, Price = 30.00f, Description = "kremem satiliram", Img = "product-8.jpg" });
            return View(products);
        }
        public IActionResult ShopDetail()
        {
            return View();
        }
    }
}
