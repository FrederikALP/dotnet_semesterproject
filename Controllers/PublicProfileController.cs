using Microsoft.AspNetCore.Mvc;
using cbsStudents.Models.Entities;
using CbsStudents.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace cbsStudents.Controllers;

public class PublicProfileController : Controller
{
    private CbsStudentsContext _context;
    private readonly UserManager<IdentityUser> _userManager;


    public IActionResult Index()
    {
        return View();
    }
}