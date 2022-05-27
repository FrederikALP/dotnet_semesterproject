using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CbsStudents.Data;
using cbsStudents.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace cbsStudents.Controllers
{
    public class EventCommentsController : Controller
    {
        private readonly CbsStudentsContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public EventCommentsController(CbsStudentsContext context, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _context = context;

        }

        // GET: EventComments
        public async Task<IActionResult> Index()
        {

            var cbsStudentsContext = _context.EventComment.Include(e => e.Event).Include(e => e.User);
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
                .Include(e => e.User)
                .FirstOrDefaultAsync(m => m.EventCommentId == id);
            if (eventComment == null)
            {
                return NotFound();
            }

            return View(eventComment);
        }

        // GET: EventComments/Create
        public IActionResult Create(int id)
        {
            //ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewBag.UserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.EventId = id;
            
            return View();
        }

        // POST: EventComments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EventCommentId,Text,EventId")] EventComment eventComment)
        //public async Task<IActionResult> Create([Bind("EventCommentId,Text,TimeStamp,EventId,UserId")] EventComment eventComment)
        {
            /*if (ModelState.IsValid)
            {
                _context.Add(eventComment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", eventComment.UserId);
            return View(eventComment);*/

            if (ModelState.IsValid)
            {
                IdentityUser user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
                eventComment.UserId = user.Id;
                eventComment.TimeStamp = DateTime.Now;
                //eventComment.EventId = ViewBag.EventId;
                _context.Add(eventComment);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","Event");            
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", eventComment.EventId);
            //ViewData["UserId"] = new SelectList(_context.IdentityUserClaim, "Id", "Id", eventComment.UserId);
            return RedirectToAction("Index","Events"); 
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", eventComment.UserId);
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", eventComment.UserId);
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
                .Include(e => e.User)
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
