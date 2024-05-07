namespace WriteOn.Models;

public class ModCredentials
{
    public required int ModCredentialsID { get; set; }  // Primary key for ModCredentials table
    public required int ModeratorID { get; set; }  // Foreign key referencing Moderator
    public required string Password { get; set; }
}