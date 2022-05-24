using Microsoft.AspNetCore.Mvc;
using cbsStudents.Models.Entities;
using CbsStudents.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cbsStudents.Controllers
{
    public class EventsController : Controller
    {
    private CbsStudentsContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public EventsController(CbsStudentsContext context, UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
        this._context = context;
    }

    // GET: Events
    [AllowAnonymous]
    public IActionResult Index(string SearchString = "")
    {
        if (SearchString == null)
        {
            SearchString = "";
        }
        var events = from e in _context.Events select e;

        events = events.Where(x => x.EventTitle.Contains(SearchString) ||
            x.EventText.Contains(SearchString)).Include(y => y.User);

        var vm = new EventIndexVm
        {
            Events = events.ToList(),
            SearchString = SearchString
        };

        return View(vm);
    }
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([Bind("Title", "Text", "Status")] Event events)
    {
        if (ModelState.IsValid)
        {
            // go ahead and save it into the database
            // redirectToAction()
            IdentityUser user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            events.UserId = user.Id;

            events.Created = DateTime.Now;
            _context.Events.Add(events);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        return View();
        // Console.WriteLine(post.Text + " " + post.Title);
        // return RedirectToAction("Test");
    }

    public IActionResult Edit(int id)
    {
        Event p = _context.Events.Include(x => x.User)
            .First(x => x.EventId == id);

        return View(p);
    }

    [HttpPost]
    public IActionResult Edit(int id, [Bind("Id", "Title", "Text", "Status")] Event events)
    {
        if (ModelState.IsValid)
        {
            _context.Events.Update(events);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        return View();
    }

}
}