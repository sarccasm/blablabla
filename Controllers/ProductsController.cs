using Microsoft.AspNetCore.Mvc;

namespace OrderSystem.Controllers;

public class ProductsController : Controller
{
    public IActionResult Index() => View();
}
