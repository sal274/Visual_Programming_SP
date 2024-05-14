namespace WriteOn.Models;

public class AccessRights
{
    public required int AccessRightsID { get; set; }  // Primary key for AccessRights table
    public required string Username { get; set; }  // Foreign key referencing User (could be Admin or Moderator)
    public required int IsAdmin { get; set; }
    public required int IsModerator { get; set; }
}