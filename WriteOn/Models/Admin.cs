using System.ComponentModel.DataAnnotations;

namespace WriteOn.Models;

public class Admin
{
  [Key]
  public required string Username { get; set; }  // Unique identifier for the admin
  public required string AdminCredentialsID { get; set; } // One-to-one relationship with AdminCredentials; foreign key
  public required string AdminAccountID { get; set; }  // One-to-One relationship with AdminAccount; foreign key
}