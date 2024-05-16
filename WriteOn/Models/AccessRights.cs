using System.ComponentModel.DataAnnotations;

namespace WriteOn.Models;

public class AccessRights
{
    [Key]
    public required string AccessRightsID { get; set; }  // Primary key for AccessRights table
    public required string Username { get; set; }  // Foreign key referencing User (could be Admin or Moderator)
    public required bool IsAdmin { get; set; }
    public required bool IsModerator { get; set; }
}