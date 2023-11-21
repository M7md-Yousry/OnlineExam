using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace OnlineExam.Controllers;

public class OnlineExamController : Controller
{
  public IActionResult Index()
  {
      return View();
  }
  public IActionResult Admin()
  {
      return View();
  }

    public IActionResult USER()
  {
      return View();
  }
}