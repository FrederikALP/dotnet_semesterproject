using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CbsStudents.Data;
using cbsStudents.Models.Entities;

namespace cbsStudents.Controllers
{
    public class EventCommentsController : Controller
    {
        private readonly CbsStudentsContext _context;

        public EventCommentsController(CbsStudentsContext context)
        {
            _context = context;
        }

        // GET: EventComments
        public async Task<IActionResult> Index()
        {
            var cbsStudentsContext = _context.EventComment.Include(e => e.Event);
            //var cbsStudentsContext = _context.EventComment.Include(e => e.Event).Include(e => e.User);
            return View(await cbsStudentsContext.ToListAsync());
        }

        // GET: EventComments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.EventComment == null)
            {
                return NotFound();
            }

            var eventComment = await _context.EventComment
                .Include(e => e.Event)
               // .Include(e => e.User)
                .FirstOrDefaultAsync(m => m.EventCommentId == id);
            if (eventComment == null)
            {
                return NotFound();
            }

            return View(eventComment);
        }

        // GET: EventComments/Create
        public IActionResult Create()
        {
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventText");
       //     ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: EventComments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EventCommentId,Text,TimeStamp,EventId,UserId")] EventComment eventComment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eventComment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventText", eventComment.EventId);
           // ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", eventComment.UserId);
            return View(eventComment);
        }

        // GET: EventComments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.EventComment == null)
            {
                return NotFound();
            }

            var eventComment = await _context.EventComment.FindAsync(id);
            if (eventComment == null)
            {
                return NotFound();
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventText", eventComment.EventId);
           // ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", eventComment.UserId);
            return View(eventComment);
        }

        // POST: EventComments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EventCommentId,Text,TimeStamp,EventId")] EventComment eventComment)
        //public async Task<IActionResult> Edit(int id, [Bind("EventCommentId,Text,TimeStamp,EventId,UserId")] EventComment eventComment)
        {
            if (id != eventComment.EventCommentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eventComment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventCommentExists(eventComment.EventCommentId))
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
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventText", eventComment.EventId);
            //ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", eventComment.UserId);
            return View(eventComment);
        }

        // GET: EventComments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.EventComment == null)
            {
                return NotFound();
            }

            var eventComment = await _context.EventComment
                .Include(e => e.Event)
                //.Include(e => e.User)
                .FirstOrDefaultAsync(m => m.EventCommentId == id);
            if (eventComment == null)
            {
                return NotFound();
            }

            return View(eventComment);
        }

        // POST: EventComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.EventComment == null)
            {
                return Problem("Entity set 'CbsStudentsContext.EventComment'  is null.");
            }
            var eventComment = await _context.EventComment.FindAsync(id);
            if (eventComment != null)
            {
                _context.EventComment.Remove(eventComment);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventCommentExists(int id)
        {
          return _context.EventComment.Any(e => e.EventCommentId == id);
        }
    }
}
