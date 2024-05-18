using System.ComponentModel.DataAnnotations;

namespace WriteOn.Models;

public class CurrentUserState
{
    [Key]
    public required string Username { get; set; }
    public required string Password { get; set; }
    public bool LoggedIn { get; set; } = false;
}