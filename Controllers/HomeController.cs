using Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Final.Controllers;

public class HomeController : Controller
{
    private EFEntertainersRepository _repo;
    
    public HomeController(EFEntertainersRepository temp)
    {
        _repo = temp;
    }
    
    [HttpGet]

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Entertainers()
    {
        var entertainer = _repo.Entertainers.ToList()
            .OrderBy(x => x.EntStageName).ToList();
        return View(entertainer);
    }


    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Entertainer response)
    {
        _repo.Entertainers.Add(response);
        _repo.SaveChanges();
        return View("Confirmation", response);
    }
    
    [HttpGet]
    public IActionResult Profile(int id)
    {
        var profile = _repo.Entertainers
            .Single(x => x.EntertainerId == id);
        return View("Profile", profile);
    }
    
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var recordToEdit = _repo.Entertainers
            .Single((x => x.EntertainerId == id));
        return View("Create", recordToEdit);    }


    [HttpPost]
    public IActionResult Edit(Entertainer updatedInfo)
    {
        _repo.Update(updatedInfo);
        _repo.SaveChanges();
        return RedirectToAction("Entertainers");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var RecordToDelete = _repo.Entertainers
            .Single(x => x.EntertainerId == id);
        return View("Delete", RecordToDelete);    }

}