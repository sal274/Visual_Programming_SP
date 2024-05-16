using System.ComponentModel.DataAnnotations;

namespace WriteOn.Models;

public class UserAccount
{
    [Key]
    public required string UserAccountID { get; set; }  // Primary key for UserAccount table
    public required string Username { get; set; }  // Foreign key referencing User
}
