using System.ComponentModel.Design;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models.Entities;
namespace DemoMVC.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        //tra ve giao dien cho phep nhap tin
        return View();
    }
    [HttpPost]
    public IActionResult Index(Student std)
    {
        //su dung viewbag de truyen du lieu sang view
        ViewBag.ThongBao = std.StudentCode + "-" + std.FullName;
        return View();
    }
}