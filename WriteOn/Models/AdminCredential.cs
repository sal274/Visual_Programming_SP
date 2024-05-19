using System.ComponentModel.DataAnnotations;

namespace WriteOn.Models;

public class AdminCredentials
{
    [Key]
    public required string AdminCredentialsID { get; set; }  // Primary key for AdminCredentials table
    public required string AdminUsername { get; set; }  // Foreign key referencing Admin
    public required string Password { get; set; }
}