using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lap12_10.Models;

namespace Lap12_10.Controllers
{
    public class ChiTietHoaDonsController : Controller
    {
        private readonly QlbanHangContext _context;

        public ChiTietHoaDonsController(QlbanHangContext context)
        {
            _context = context;
        }

        // GET: ChiTietHoaDons
        public async Task<IActionResult> Index()
        {
            var qlbanHangContext = _context.ChiTietHoaDons.Include(c => c.IdhoaDonNavigation).Include(c => c.SanPham);
            return View(await qlbanHangContext.ToListAsync());
        }

        // GET: ChiTietHoaDons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDon = await _context.ChiTietHoaDons
                .Include(c => c.IdhoaDonNavigation)
                .Include(c => c.SanPham)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chiTietHoaDon == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDon);
        }

        // GET: ChiTietHoaDons/Create
        public IActionResult Create()
        {
            ViewData["IdhoaDon"] = new SelectList(_context.HoaDons, "Id", "Id");
            ViewData["SanPhamId"] = new SelectList(_context.SanPhams, "Id", "Id");
            return View();
        }

        // POST: ChiTietHoaDons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdhoaDon,SanPhamId,SoLuongMua,DonGiaMua,ThanhTien,TrangThai")] ChiTietHoaDon chiTietHoaDon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietHoaDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdhoaDon"] = new SelectList(_context.HoaDons, "Id", "Id", chiTietHoaDon.IdhoaDon);
            ViewData["SanPhamId"] = new SelectList(_context.SanPhams, "Id", "Id", chiTietHoaDon.SanPhamId);
            return View(chiTietHoaDon);
        }

        // GET: ChiTietHoaDons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDon = await _context.ChiTietHoaDons.FindAsync(id);
            if (chiTietHoaDon == null)
            {
                return NotFound();
            }
            ViewData["IdhoaDon"] = new SelectList(_context.HoaDons, "Id", "Id", chiTietHoaDon.IdhoaDon);
            ViewData["SanPhamId"] = new SelectList(_context.SanPhams, "Id", "Id", chiTietHoaDon.SanPhamId);
            return View(chiTietHoaDon);
        }

        // POST: ChiTietHoaDons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdhoaDon,SanPhamId,SoLuongMua,DonGiaMua,ThanhTien,TrangThai")] ChiTietHoaDon chiTietHoaDon)
        {
            if (id != chiTietHoaDon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietHoaDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietHoaDonExists(chiTietHoaDon.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdhoaDon"] = new SelectList(_context.HoaDons, "Id", "Id", chiTietHoaDon.IdhoaDon);
            ViewData["SanPhamId"] = new SelectList(_context.SanPhams, "Id", "Id", chiTietHoaDon.SanPhamId);
            return View(chiTietHoaDon);
        }

        // GET: ChiTietHoaDons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDon = await _context.ChiTietHoaDons
                .Include(c => c.IdhoaDonNavigation)
                .Include(c => c.SanPham)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chiTietHoaDon == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDon);
        }

        // POST: ChiTietHoaDons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chiTietHoaDon = await _context.ChiTietHoaDons.FindAsync(id);
            if (chiTietHoaDon != null)
            {
                _context.ChiTietHoaDons.Remove(chiTietHoaDon);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietHoaDonExists(int id)
        {
            return _context.ChiTietHoaDons.Any(e => e.Id == id);
        }
    }
}
