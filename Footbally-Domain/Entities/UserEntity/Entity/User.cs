using Footbally_Common.Enums.User;
using Footbally_Domain.Entities.CommonEntity.Entity;

namespace Footbally_Domain.Entities.UserEntity.Entity;

public class User:BaseEntity
{
    public User(string fullName, string phoneNumber, UserRole role= UserRole.Normal)
    {
        FullName = fullName;
        PhoneNumber = phoneNumber;
        Role = role;
        FixPhoneNumberFormat();
        Validate();
    }

    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public UserRole Role { get; set; }

    protected override void Validate()
    {
        if (string.IsNullOrWhiteSpace(FullName))
            throw new ArgumentNullException("your phone number cannot be null or empty");

        if (string.IsNullOrWhiteSpace(PhoneNumber))
            throw new ArgumentNullException("your phone number cannot be null or empty");

        if (PhoneNumber.Length != 11)
            throw new InvalidOperationException("Phone Number most be 11 Charcter");

        if (!PhoneNumber.All(char.IsDigit))
            throw new InvalidOperationException("Phone Number most be digit");

    }

    private void FixPhoneNumberFormat()
    {
        if (PhoneNumber.StartsWith("+98"))
            PhoneNumber = $"09{PhoneNumber.Substring(3)}";
    }
}
