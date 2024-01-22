using BlazorCustom.Components.Models;

namespace BlazorCustom.Components.Services;

public class DataSeedingService
{
    public List<UserAccount> GenerateUserAccount()
    {
        var user01 = new UserAccount
        {
            Id = Guid.NewGuid(),
            Username = "erasmus",
            EmailAddress = "erasmus@proton.me",
            FirstName = "Taufan",
            LastName = "Augusta",
            DateOfBirth = new DateOnly(year: 1996, month: 8, day: 19),
            Role = "Administrator",
            Privileges = new List<string>()
            {
                "Viewer",
                "Editor",
                "Administrator"
            },
            Shift = "Morning",
            JobTitle = "Developer",
            PasswordHash = "password",
            PasswordSalt = "salt",
            CreationDate = DateTimeOffset.Now,
            LastSignedIn = DateTimeOffset.Now
        };

        var user02 = new UserAccount
        {
            Id = Guid.NewGuid(),
            Username = "einharan",
            EmailAddress = "einharan@proton.me",
            FirstName = "",
            LastName = "Einharan",
            DateOfBirth = new DateOnly(year: 1995, month: 5, day: 15),
            Role = "Manager",
            Privileges = new List<string>()
            {
                "Viewer",
                "Editor",
            },
            Shift = "Morning",
            JobTitle = "Branch Manager",
            PasswordHash = "password",
            PasswordSalt = "salt",
            CreationDate = DateTimeOffset.Now,
            LastSignedIn = DateTimeOffset.Now
        };

        var user03 = new UserAccount
        {
            Id = Guid.NewGuid(),
            Username = "vincent",
            EmailAddress = "vincent@proton.me",
            FirstName = "Vincent",
            LastName = "Arkel",
            DateOfBirth = new DateOnly(year: 1998, month: 11, day: 5),
            Role = "Salesperson",
            Privileges = new List<string>()
            {
                "Viewer",
            },
            Shift = "Morning",
            JobTitle = "Field Agent",
            PasswordHash = "password",
            PasswordSalt = "salt",
            CreationDate = DateTimeOffset.Now,
            LastSignedIn = DateTimeOffset.Now
        };

        return new List<UserAccount>()
        {
            user01,
            user02,
            user03
        };
    }
}
