using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using System.Linq;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        private int PageSize = 4;
        private ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string category, int page = 1) => View(new ProductListViewModel
        {
            Products = repository.Products.Where(p => category == null || p.Category == category).OrderBy(p => p.ProductID).Skip((page - 1) * PageSize).Take(PageSize),
            PagingInfo = new PagingInfo { CurrentPage = page, ItemsPerPage = PageSize, TotalItems = category == null ? repository.Products.Count() : repository.Products.Where(e => e.Category == category).Count()},
            CurrentCategory = category
        });
        public ViewResult List() => View(repository.Products);
    }
}
 