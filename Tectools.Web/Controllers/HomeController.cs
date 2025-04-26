using System.Diagnostics;
using Tectools.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Tectools.Web.Models;

namespace Tectools.Web.Controllers;

public class HomeController(
    ILogger<HomeController> logger, 
    IComponentService componentService,
    ICategoryService categoryService
    ) : Controller
{
    
    public async Task<IActionResult> Index()
    {
        var components = await componentService.GetComponents();
        var featuredComponents = await componentService.GetFeaturedComponents();
        var categories = await categoryService.GetCategories();
        
        HomeViewModel model = new HomeViewModel
        {
            Components = components,
            Categories = categories,
            FeaturedComponents = featuredComponents
        };  
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}