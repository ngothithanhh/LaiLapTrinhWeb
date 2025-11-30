using Microsoft.AspNetCore.Mvc;
using NgoThiThanh_231230902_temp2.Models;
using System.Diagnostics;

namespace NgoThiThanh_231230902_temp2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly QlhangHoaContext _context;

        public HomeController(ILogger<HomeController> logger, QlhangHoaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var hangHoas = _context.HangHoas.Where(h => h.Gia >= 100).ToList();
            return View(hangHoas);
        }

        public IActionResult HangHoaTheoId(int id)
        {
            var hangHoa = _context.HangHoas.Where(h => h.MaLoai == id).Select( h => new {h.TenHang, h.Anh, h.Gia}).ToList();

            return Json(hangHoa);
        }

        public IActionResult TimKiem(string keyword)
        {
            var ketqua = _context.HangHoas
                .Where(h => h.TenHang.Contains(keyword))
                .Select(h => new
                {
                    h.MaHang,
                    h.TenHang,
                    h.Gia,
                    anh = h.Anh ?? "no-image.jpg"
                })
                .ToList();

            return Json(ketqua);
        }

        public IActionResult LoadSanPham(int page = 1, int pageSize = 8)
        {
            var total = _context.HangHoas.Count();

            var data = _context.HangHoas
                .OrderBy(h => h.MaHang)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(h => new
                {
                    h.MaHang,
                    h.TenHang,
                    h.Gia,
                    anh = h.Anh ?? "no-image.jpg"
                })
                .ToList();

            return Json(new
            {
                data = data,
                currentPage = page,
                totalPages = (int)Math.Ceiling(total / (double)pageSize),
                hasNext = page < (int)Math.Ceiling(total / (double)pageSize),
                hasPrev = page > 1
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
