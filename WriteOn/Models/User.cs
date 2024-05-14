namespace WriteOn.Models;

public class User
{
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required int UserCredentialsID { get; set; }  // One-to-One relationship with UserCredentials; foreign key
    public required int UserAccountID { get; set; }  // One-to-One relationship; foreign key
}
