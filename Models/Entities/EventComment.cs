using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace cbsStudents.Models.Entities;

public class EventComment
{
    public int EventCommentId { get; set; }
    public string Text { get; set; }
    public DateTime TimeStamp { get; set; }
    
    public int EventId { get; set; }
    public Event Event { get; set; }

    public string UserId { get; set; }
    public IdentityUser? User { get; set; }


}