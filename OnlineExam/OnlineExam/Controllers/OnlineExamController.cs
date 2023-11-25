using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace OnlineExam.Controllers;

public class OnlineExamController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
  public IActionResult LoginAdmin()
  { 
      return this.RedirectToAction("index", "Exams");
  }

  public IActionResult LoginUser()
  {
      return this.RedirectToAction("User", "OnlineExam");
  }
    public IActionResult USER()
  {
      return View();
  }

    public IActionResult Generate()
  {
      return this.RedirectToAction("Questions", "Exams");
  }
}