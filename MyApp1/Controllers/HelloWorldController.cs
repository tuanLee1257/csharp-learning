using Microsoft.AspNetCore.Mvc;
using MyApp1.Models;

public class HelloWorldController : Controller
{
    private static List<DogViewModel> dogList = new List<DogViewModel>();
    public IActionResult Index()
    {
        return View(dogList);
    }
    public IActionResult Create()
    {
        var dogVm = new DogViewModel();
        return View(dogVm);
    }
    public IActionResult CreateDog(DogViewModel dogViewModel)
    {
        dogList.Add(dogViewModel);
        return RedirectToAction(nameof(Index));
    }
}