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
    public class ntt_LoaiSanPhamController : Controller
    {
        private readonly nttContext _context;

        public ntt_LoaiSanPhamController(nttContext context)
        {
            _context = context;
        }

        // GET: ntt_LoaiSanPham
        public async Task<IActionResult> nttIndex()
        {
            return View(await _context.ntt_LoaiSanPhams.ToListAsync());
        }

        // GET: ntt_LoaiSanPham/Details/5
        public async Task<IActionResult> nttDetails(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ntt_LoaiSanPham = await _context.ntt_LoaiSanPhams
                .FirstOrDefaultAsync(m => m.nttId == id);
            if (ntt_LoaiSanPham == null)
            {
                return NotFound();
            }

            return View(ntt_LoaiSanPham);
        }

        // GET: ntt_LoaiSanPham/Create
        public IActionResult nttCreate()
        {
            return View();
        }

        // POST: ntt_LoaiSanPham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> nttCreate([Bind("nttId,nttMaLoai,nttTenLoai,nttTrangThai")] ntt_LoaiSanPham ntt_LoaiSanPham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ntt_LoaiSanPham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(nttIndex));
            }
            return View(ntt_LoaiSanPham);
        }

        // GET: ntt_LoaiSanPham/Edit/5
        public async Task<IActionResult> nttEdit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ntt_LoaiSanPham = await _context.ntt_LoaiSanPhams.FindAsync(id);
            if (ntt_LoaiSanPham == null)
            {
                return NotFound();
            }
            return View(ntt_LoaiSanPham);
        }

        // POST: ntt_LoaiSanPham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> nttEdit(long id, [Bind("nttId,nttMaLoai,nttTenLoai,nttTrangThai")] ntt_LoaiSanPham ntt_LoaiSanPham)
        {
            if (id != ntt_LoaiSanPham.nttId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ntt_LoaiSanPham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ntt_LoaiSanPhamExists(ntt_LoaiSanPham.nttId))
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
            return View(ntt_LoaiSanPham);
        }

        // GET: ntt_LoaiSanPham/Delete/5
        public async Task<IActionResult> nttDelete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ntt_LoaiSanPham = await _context.ntt_LoaiSanPhams
                .FirstOrDefaultAsync(m => m.nttId == id);
            if (ntt_LoaiSanPham == null)
            {
                return NotFound();
            }

            return View(ntt_LoaiSanPham);
        }

        // POST: ntt_LoaiSanPham/Delete/5
        [HttpPost, ActionName("nttDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> nttDeleteConfirmed(long id)
        {
            var ntt_LoaiSanPham = await _context.ntt_LoaiSanPhams.FindAsync(id);
            if (ntt_LoaiSanPham != null)
            {
                _context.ntt_LoaiSanPhams.Remove(ntt_LoaiSanPham);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(nttIndex));
        }

        private bool ntt_LoaiSanPhamExists(long id)
        {
            return _context.ntt_LoaiSanPhams.Any(e => e.nttId == id);
        }
    }
}
