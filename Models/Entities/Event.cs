using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace cbsStudents.Models.Entities;

public class Event
{
    public int EventId { get; set; }


    [Required(ErrorMessage = "Please fill out Event title")]
    [MinLength(3, ErrorMessage = "Minimum 3 characters")]
    public string? EventTitle { get; set; }

    [Required]
    [MinLength(10)]
    public string? EventText { get; set; }

    public string? Location { get; set; }

    [DataType(DataType.Date)]
    public DateTime Created { get; set; }

    public PostStatus Status { get; set; }

    public string UserId { get; set; }
    public IdentityUser? User { get; set; }

}

