using System.ComponentModel.DataAnnotations;

namespace WriteOn.Models;

public class Moderator
{
    [Key]
    public required string Username { get; set; }  // Unique identifier for the moderator
    public required string ModCredentialsID { get; set; }  // One-to-One relationship with ModCredentials; foreign key
    public required string ModAccountID { get; set; }  // One-to-One relationship with ModAccount; foreign key
}