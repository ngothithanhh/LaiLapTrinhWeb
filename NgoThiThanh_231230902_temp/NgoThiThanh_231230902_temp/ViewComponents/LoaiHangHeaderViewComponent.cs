using Microsoft.AspNetCore.Mvc;
using NgoThiThanh_231230902_temp.Models;

namespace NgoThiThanh_231230902_temp.ViewComponents
{
    public class LoaiHangHeaderViewComponent:ViewComponent
    {
        private readonly QlhangHoaContext _context;

        public LoaiHangHeaderViewComponent(QlhangHoaContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loaiHangs =  await Task.FromResult(_context.LoaiHangs.ToList());
            return View(loaiHangs);
        }
    }
}
