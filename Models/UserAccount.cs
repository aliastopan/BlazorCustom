#nullable disable

namespace BlazorCustom.Models;

public class UserAccount
{
    public Guid Id { get; init; }
    public string Username { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get ; init; }
    public string EmailAddress { get; set; }
    public string Role { get; set; }
    public ICollection<string> Privileges { get; set; }
    public string Shift { get; set; }
    public string JobTitle { get; set; }
    public string PasswordHash { get; set; }
    public string PasswordSalt { get; set; }
    public DateTimeOffset CreationDate { get; init; }
    public DateTimeOffset LastSignedIn { get; set; }
}
