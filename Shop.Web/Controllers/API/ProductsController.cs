
namespace Shop.Web.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("api/[Controller]")]
    public class ProductsController : Controller
    {
        public ProductsController(ProductsController productsController)
        {
        }
    }
}
