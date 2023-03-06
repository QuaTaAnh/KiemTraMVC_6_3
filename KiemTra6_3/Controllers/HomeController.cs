using KiemTra6_3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace KiemTra6_3.Controllers
{
    public class HomeController : Controller
    {
        QlbanVaLiContext db = new QlbanVaLiContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<TDanhMucSp> lstSanPham = db.TDanhMucSps.AsNoTracking().OrderBy(x => x.MaSp).ToList();
			return View(lstSanPham);
        }

        public IActionResult SanPhamTheoLoai(string maloai)
        {
			List<TDanhMucSp> lst = db.TDanhMucSps.AsNoTracking().Where(x => x.MaHangSx == maloai).OrderBy(x => x.MaHangSx).ToList();
			return View(lst);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}