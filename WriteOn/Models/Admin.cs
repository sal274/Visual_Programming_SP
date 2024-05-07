namespace WriteOn.Models;

public class Admin
{
  public required int AdminID { get; set; }  // Primary key for Admins table
  public required string Username { get; set; }  // Unique identifier for the admin
  public required AdminCredentials Credentials { get; set; }  // One-to-One relationship with AdminCredentials
  public required AdminAccount Account { get; set; }  // One-to-One relationship with AdminAccount
}