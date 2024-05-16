using System.ComponentModel.DataAnnotations;

namespace WriteOn.Models;

public class User
{
    [Key]
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string UserCredentialsID { get; set; }  // One-to-One relationship with UserCredentials; foreign key
    public required string UserAccountID { get; set; }  // One-to-One relationship; foreign key
}
