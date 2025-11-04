using System.Text;
using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            //ViewResult
            return View();
        }
        public RedirectResult RedirectToGoogle()
        {
            //RedirectResult
            return Redirect("https://www.google.com/");
        }
        public RedirectToActionResult GoToHomeIndex()
        {
            //RedirectToActionResult
            return RedirectToAction("Index", "Home");
        }
        public JsonResult GetJson()
        {
            var data = new
            {
                Id = 1,
                FullName = "Nguyễn Văn A",
                Message = "Đây là dữ liệu Json từ Controller"
            };
            //JsonResult
            return Json(data);
        }
        public FileResult DownloadFile()
        {
            var fileContent = Encoding.UTF8.GetBytes("Xin chào. Đây là nội dung file.");
            var fileName = "example.txt";
            // FileResult
            return File(fileContent, "text/plain", fileName);
        }
        public IActionResult ErrorCode()
        {
            //StatusCodeResult
            return StatusCode(404, "Không tìm thấy tài nguyên theo yêu cầu");
        }
    }
}