using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wed_Ban_Hang__Tuan_3.Models;
using Wed_Ban_Hang__Tuan_3.Repositories;

namespace Wed_Ban_Hang__Tuan_3.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository,
                                 ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productRepository.GetAllAsync();
            return View(products);
        }
    } 
}