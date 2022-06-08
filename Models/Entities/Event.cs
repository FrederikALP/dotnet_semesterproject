using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace cbsStudents.Models.Entities;

public class Event
{
    public int EventId { get; set; }

    [Display(Name="Event")]
    [Required(ErrorMessage = "Please fill out Event title")]
    [MinLength(3, ErrorMessage = "Minimum 3 characters")]
    public string? EventTitle { get; set; }

    [Display(Name="Description")]
    [Required]
    [MinLength(10)]
    public string? EventText { get; set; }

    [Display(Name="Location")]
    public string? Location { get; set; }

    [Display(Name="Start Date")]
    [DataType(DataType.DateTime)]
    public DateTime StartDate { get; set; }

    [Display(Name="End Date")]
    [DataType(DataType.DateTime)]
    public DateTime EndDate { get; set; }

    [Display(Name="Photo")]
    public string? PhotoURL { get; set; }

    [Display(Name="Responsible")]
    public string? Responsible { get; set; }

    [Display(Name="Collaboration")]
    public string? Collaboration { get; set; }

    [Display(Name="Reserved Room")]
    public string? ReservedRoom { get; set; }

    [Display(Name="Status")]
    public PostStatus Status { get; set; }

    public List<EventComment> Comments { get; set; }

    public string UserId { get; set; }
    public IdentityUser? User { get; set; }

}

