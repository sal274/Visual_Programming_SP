namespace WriteOn.Shared;

class CurrentUserState
{
    public int UserId { get; set; } = 0;
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}