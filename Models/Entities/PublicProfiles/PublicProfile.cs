using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace cbsStudents.Models.Entities;

public class PublicProfile
{
    public int PublicProfileId { get; set; }

    public String Logo { get; set; }

    public String CoverPhoto { get; set; }

    [Required(ErrorMessage = "Please fill out title")]
    public String  Header { get; set; }

    [Required(ErrorMessage = "Please fill out title")]
    public String Body { get; set; }

    public String PublicProfileEmail { get; set; }

    public String PublicProfileName { get; set; }

    public string UserId { get; set; }
    
    public IdentityUser? User { get; set; }

}