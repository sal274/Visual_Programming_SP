namespace WriteOn.Models;

public class UserCredentials
{
    public required int UserCredentialsID { get; set; }  // Primary key for UserCredentials table
    public required string Username { get; set; }  // Foreign key referencing User
    public required string Password { get; set; }
}
