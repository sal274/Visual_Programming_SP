using System.ComponentModel.DataAnnotations;

namespace WriteOn.Models;

public class UserCredentials
{
    [Key]
    public required string UserCredentialsID { get; set; }  // Primary key for UserCredentials table
    public required string Username { get; set; }  // Foreign key referencing User
    public required string Password { get; set; }
}
