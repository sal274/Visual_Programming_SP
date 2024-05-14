namespace WriteOn.Models;

public class AdminCredentials
{
    public required int AdminCredentialsID { get; set; }  // Primary key for AdminCredentials table
    public required string AdminUsername { get; set; }  // Foreign key referencing Admin
    public required string Username { get; set; }
    public required string Password { get; set; }
}