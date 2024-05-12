namespace WriteOn.Models;

public class Admin
{
  public required int AdminID { get; set; }  // Primary key for Admins table
  public required string Username { get; set; }  // Unique identifier for the admin
  public required int AdminCredentialsID { get; set; } // One-to-one relationship with AdminCredentials; foreign key
  public required int AdminAccountID { get; set; }  // One-to-One relationship with AdminAccount; foreign key
}