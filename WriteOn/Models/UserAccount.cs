namespace WriteOn.Models;

public class UserAccount
{
    public required int UserAccountID { get; set; }  // Primary key for UserAccount table
    public required int UserID { get; set; }  // Foreign key referencing User
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string Biography { get; set; } = string.Empty;
    public string WebsiteURL { get; set; } = string.Empty;
    public string PenName { get; set; } = string.Empty;
}