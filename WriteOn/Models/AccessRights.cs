namespace WriteOn.Models;

public class AccessRights
{
    public required int AccessRightsID { get; set; }  // Primary key for AccessRights table
    public required int UserID { get; set; }  // Foreign key referencing User (could be Admin or Moderator)
    public required bool IsAdmin { get; set; }
    public required bool IsModerator { get; set; }
    public required bool CanPublishArticles { get; set; }
    public required bool CanEditArticles { get; set; }
    public required bool CanManageUsers { get; set; }
}