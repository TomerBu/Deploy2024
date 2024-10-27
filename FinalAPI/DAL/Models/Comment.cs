using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public class Comment
{
    [Key]
    public int Id { get; set; }
    public required string Content { get; set; }
    
}
