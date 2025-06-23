using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SymphonyLimited.Data;
using SymphonyLimited.Entity;

namespace SymphonyLimited.Controllers
{
    public class EntranceExamsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EntranceExamsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EntranceExams
        public async Task<IActionResult> Index()
        {
            return View(await _context.EntranceExams.ToListAsync());
        }

        // GET: EntranceExams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entranceExam = await _context.EntranceExams
                .FirstOrDefaultAsync(m => m.EntranceExamId == id);
            if (entranceExam == null)
            {
                return NotFound();
            }

            return View(entranceExam);
        }

        // GET: EntranceExams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EntranceExams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EntranceExamId,ExamDate,ExamFee,IsActive")] EntranceExam entranceExam)
        {
            if (ModelState.IsValid)
            {
                _context.Add(entranceExam);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(entranceExam);
        }

        // GET: EntranceExams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entranceExam = await _context.EntranceExams.FindAsync(id);
            if (entranceExam == null)
            {
                return NotFound();
            }
            return View(entranceExam);
        }

        // POST: EntranceExams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EntranceExamId,ExamDate,ExamFee,IsActive")] EntranceExam entranceExam)
        {
            if (id != entranceExam.EntranceExamId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entranceExam);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntranceExamExists(entranceExam.EntranceExamId))
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
            return View(entranceExam);
        }

        // GET: EntranceExams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entranceExam = await _context.EntranceExams
                .FirstOrDefaultAsync(m => m.EntranceExamId == id);
            if (entranceExam == null)
            {
                return NotFound();
            }

            return View(entranceExam);
        }

        // POST: EntranceExams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var entranceExam = await _context.EntranceExams.FindAsync(id);
            if (entranceExam != null)
            {
                _context.EntranceExams.Remove(entranceExam);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntranceExamExists(int id)
        {
            return _context.EntranceExams.Any(e => e.EntranceExamId == id);
        }
    }
}
