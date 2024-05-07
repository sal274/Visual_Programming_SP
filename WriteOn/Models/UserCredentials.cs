namespace WriteOn.Models;

public class UserCredentials
{
    public required int UserCredentialsID { get; set; }  // Primary key for UserCredentials table
    public required int UserID { get; set; }  // Foreign key referencing User
    public required string Password { get; set; }
}
