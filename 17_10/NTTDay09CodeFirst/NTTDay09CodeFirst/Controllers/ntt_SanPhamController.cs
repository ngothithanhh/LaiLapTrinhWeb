using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NTTDay09CodeFirst.Models;

namespace NTTDay09CodeFirst.Controllers
{
    public class ntt_SanPhamController : Controller
    {
        private readonly nttContext _context;

        public ntt_SanPhamController(nttContext context)
        {
            _context = context;
        }

        // GET: ntt_SanPham
        public async Task<IActionResult> nttIndex()
        {
            return View(await _context.ntt_SanPhams.ToListAsync());
        }

        // GET: ntt_SanPham/Details/5
        public async Task<IActionResult> nttDetails(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ntt_SanPham = await _context.ntt_SanPhams
                .FirstOrDefaultAsync(m => m.nttId == id);
            if (ntt_SanPham == null)
            {
                return NotFound();
            }

            return View(ntt_SanPham);
        }

        // GET: ntt_SanPham/Create
        public IActionResult nttCreate()
        {
            return View();
        }

        // POST: ntt_SanPham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> nttCreate([Bind("nttId,nttMaSP,nttTenSP,nttHinhAnh,nttSoLuong,nttDonGia,nttLoaiSPId")] ntt_SanPham ntt_SanPham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ntt_SanPham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(nttIndex));
            }
            return View(ntt_SanPham);
        }

        // GET: ntt_SanPham/Edit/5
        public async Task<IActionResult> nttEdit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ntt_SanPham = await _context.ntt_SanPhams.FindAsync(id);
            if (ntt_SanPham == null)
            {
                return NotFound();
            }
            return View(ntt_SanPham);
        }

        // POST: ntt_SanPham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> nttEdit(long id, [Bind("nttId,nttMaSP,nttTenSP,nttHinhAnh,nttSoLuong,nttDonGia,nttLoaiSPId")] ntt_SanPham ntt_SanPham)
        {
            if (id != ntt_SanPham.nttId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ntt_SanPham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ntt_SanPhamExists(ntt_SanPham.nttId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(nttIndex));
            }
            return View(ntt_SanPham);
        }

        // GET: ntt_SanPham/Delete/5
        public async Task<IActionResult> nttDelete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ntt_SanPham = await _context.ntt_SanPhams
                .FirstOrDefaultAsync(m => m.nttId == id);
            if (ntt_SanPham == null)
            {
                return NotFound();
            }

            return View(ntt_SanPham);
        }

        // POST: ntt_SanPham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> nttDeleteConfirmed(long id)
        {
            var ntt_SanPham = await _context.ntt_SanPhams.FindAsync(id);
            if (ntt_SanPham != null)
            {
                _context.ntt_SanPhams.Remove(ntt_SanPham);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(nttIndex));
        }

        private bool ntt_SanPhamExists(long id)
        {
            return _context.ntt_SanPhams.Any(e => e.nttId == id);
        }
    }
}
