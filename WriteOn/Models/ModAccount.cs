namespace WriteOn.Models;

public class ModAccount
{
  public required int ModAccountID { get; set; }  // Primary key for ModAccount table
  public required string ModeratorUsername { get; set; }  // Foreign key referencing Moderator
  public required string FirstName { get; set; }
  public required string LastName { get; set; }
  public required string Email { get; set; }
}