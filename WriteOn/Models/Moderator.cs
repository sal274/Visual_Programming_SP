namespace WriteOn.Models;

public class Moderator
{
    public required int ModeratorID { get; set; }  // Primary key for Moderators table
    public required string Username { get; set; }  // Unique identifier for the moderator
    public required ModCredentials Credentials { get; set; }  // One-to-One relationship with ModCredentials
    public required ModAccount Account { get; set; }  // One-to-One relationship with ModAccount
}