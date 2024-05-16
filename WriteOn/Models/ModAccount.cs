using System.ComponentModel.DataAnnotations;

namespace WriteOn.Models;

public class ModAccount
{
  [Key]
  public required string ModAccountID { get; set; }  // Primary key for ModAccount table
  public required string ModeratorUsername { get; set; }  // Foreign key referencing Moderator
  public required string Email { get; set; }
}