using System.ComponentModel.DataAnnotations;

namespace WriteOn.Models;

public class AdminAccount
{
    [Key]
    public required string AdminAccountID { get; set; }  // Primary key for AdminAccount table
    public required string AdminUsername { get; set; }  // Foreign key referencing Admin
    public required string Email { get; set; }
}