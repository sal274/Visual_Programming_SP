namespace WriteOn.Models;

public class Moderator
{
    public required int ModeratorID { get; set; }  // Primary key for Moderators table
    public required string Username { get; set; }  // Unique identifier for the moderator
    public required int ModCredentialsID { get; set; }  // One-to-One relationship with ModCredentials; foreign key
    public required int ModAccountID { get; set; }  // One-to-One relationship with ModAccount; foreign key
}