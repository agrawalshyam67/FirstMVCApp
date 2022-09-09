using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers;

public class HelloWorldController : Controller
{
    private static List<DogViewModel> _dogs = new List<DogViewModel>();

    // GET
    public IActionResult Index()
    {
        return View(_dogs);
    }

    public IActionResult Create()
    {
        var dogVm = new DogViewModel();
        return View(dogVm);
    }

    public IActionResult CreateDog(DogViewModel dogViewModel)
    {
        _dogs.Add(dogViewModel);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Hello()
    {
        DogViewModel doggo1 = new DogViewModel()
        {
            Name = "Coco", 
            Age = 2
        };
        return View(doggo1);
    }
}