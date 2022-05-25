using Microsoft.AspNetCore.Mvc;
using cbsStudents.Models.Entities;
using CbsStudents.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace cbsStudents.Controllers;

[Authorize]
public class PostsController : Controller
{
    private CbsStudentsContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public PostsController(CbsStudentsContext context, UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
        this._context = context;
    }

    [AllowAnonymous]
    public IActionResult Index(string SearchString = "")
    {
        if (SearchString == null)
        {
            SearchString = "";
        }
        var posts = from p in _context.Posts select p;

        posts = posts.Where(x => x.Title.Contains(SearchString) ||
            x.Text.Contains(SearchString)).Include(y => y.User);

        // ViewBag.SearchString = SearchString;
        var vm = new PostIndexVm
        {
            Posts = posts.ToList(),
            SearchString = SearchString
        };

        return View(vm);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([Bind("Title", "Text", "Status")] Post post)
    {
        if (ModelState.IsValid)
        {
            // go ahead and save it into the database
            // redirectToAction()
            IdentityUser user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            post.UserId = user.Id;

            post.Created = DateTime.Now;
            _context.Posts.Add(post);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        return View();
        // Console.WriteLine(post.Text + " " + post.Title);
        // return RedirectToAction("Test");
    }

    public IActionResult Edit(int id)
    {
        Post p = _context.Posts.Include(x => x.Comments).ThenInclude(x => x.User)
            .First(x => x.Id == id);

        return View(p);
    }

    [HttpPost]
    public IActionResult Edit(int id, [Bind("Id", "Title", "Text", "Status")] Post post)
    {
        if (ModelState.IsValid)
        {
            _context.Posts.Update(post);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        return View();
    }

            // GET: Posts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Posts == null)
            {
                return NotFound();
            }

            var @post = await _context.Posts
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@post == null)
            {
                return NotFound();
            }

            return View(@post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Posts == null)
            {
                return Problem("Entity set 'CbsStudentsContext.Posts'  is null.");
            }
            var @post = await _context.Posts.FindAsync(id);
            if (@post != null)
            {
                _context.Posts.Remove(@post);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostsExists(int id)
        {
          return _context.Posts.Any(e => e.Id == id);
        }


}