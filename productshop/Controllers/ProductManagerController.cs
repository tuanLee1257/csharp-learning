using Microsoft.AspNetCore.Mvc;
using productshop.Models;

namespace productshop.Controllers
{
    public class ProductManagerController : Controller
    {
        public List<Product> Products { get; set; } = new List<Product>();
        //{
        //        new Product(){ProductId=1,ProductName="Quần Jeans Skinny Wash Ripped Paint Splatter",ProductCategories="quần, quần jeans",ProductImgURL="https://product.hstatic.net/1000360022/product/dsc09140_f1e3facc759e414bbee904d71d65e314_large.jpg",ProductPrice=5.99},
        //        new Product(){ProductId=2,ProductName="Áo Tanktop Acid Wash Printed",ProductCategories="áo,áo tanktop",ProductImgURL="https://product.hstatic.net/1000360022/product/160_tanktop_2m_09_-_12_d9fa01a5141048d5ba0a514479d9315e_large.jpg",ProductPrice=5.99},
        //        new Product(){ProductId=3,ProductName="Áo Polo Basic Printed Form Slim",ProductCategories="áo",ProductImgURL="https://product.hstatic.net/1000360022/product/160_polo_theu_noi_3m_99_-_11_740bde0713b648e3aca4c3462597f53b_large.jpg",ProductPrice=5.99},
        //        new Product(){ProductId=4,ProductName="Quần Short Jeans W Detail",ProductType="quần, quần short",ProductImgURL="https://product.hstatic.net/1000360022/product/dsc09800_a3ce5c2415894bb3b7067d6b23e67c8e_large.jpg",ProductPrice=5.99},
        //        new Product(){ProductId=5,ProductName="Quần Jogger Summer Edition",ProductType="quần, quần jogger",ProductImgURL="https://product.hstatic.net/1000360022/product/dsc00259_0c7774a20126446bbf90048ad7b6b686_large.jpg",ProductPrice=5.99},
        //};

        public IActionResult Index()
        {
            return View(Products);
        }

        [HttpPost]
        public IActionResult AddNewProduct(Product newProduct)
        {
            Products.Add(newProduct);
            return RedirectToAction("Index");
        }
    }
}
