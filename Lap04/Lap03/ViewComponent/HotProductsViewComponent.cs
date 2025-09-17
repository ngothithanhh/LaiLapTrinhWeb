using Lap03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lap03.ViewComponents
{
    public class HotProductsViewComponent: ViewComponent
    {
        protected Products product = new Products();

        public IViewComponentResult Invoke()
        {
            var products = product.GetProductsList();
            return View(products);
        }
    }
}
