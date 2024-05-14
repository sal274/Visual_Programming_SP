namespace WriteOn.Models;

public class ModCredentials
{
    public required int ModCredentialsID { get; set; }  // Primary key for ModCredentials table
    public required string ModeratorUsername { get; set; }  // Foreign key referencing Moderator
    public required string Username { get; set; }
    public required string Password { get; set; }
}