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


namespace cbsStudents.Controllers;

public class PublicProfileController : Controller
{
    private CbsStudentsContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public PublicProfileController(CbsStudentsContext context, UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
        this._context = context;
    }

    // GET: Events
    [AllowAnonymous]
    public IActionResult Index()
    {
        return View();
    }
}