namespace WriteOn.Models;

public class AdminAccount
{
    public required int AdminAccountID { get; set; }  // Primary key for AdminAccount table
    public required int AdminUsername { get; set; }  // Foreign key referencing Admin
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
}