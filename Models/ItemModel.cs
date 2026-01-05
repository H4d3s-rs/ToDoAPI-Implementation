using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoAPI.Models;

public class ItemModel
{
    [Key]
    public int IdItem { get; set; }
 
    public string title { get; set; } = null!;

    [StringLength(100, MinimumLength = 3)]
    public string Description { get; set; } = null!;

    public bool IsCompleted { get; set; }

    public DateTime? DueTime { get; set; } 

    public DateTime CreatedAt { get; set; } = DateTime.Now.ToLocalTime();

    public DateTime UpdatedAt { get; set; } = DateTime.Now.ToLocalTime();

    public DateTime? DeletedAt { get; set; }

}
