using API__Clean_Template.Domain.DomainBase;

namespace API__Clean_Template.Domain.Entities.User;

public class User : BaseEntity<int>
{
    public string Name { get; set; } = string.Empty;

    public string FatherName { get; set; } = string.Empty;

    public string GrandFatherName { get; set; } = string.Empty;

    public string GreatGandFatherName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Fullname { get; set; } = string.Empty;

    public string MotherName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string Verfication { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public bool IsValid { get; set; }

    public string Gender { get; set; } = string.Empty;

    public DateTime DateOfBirth { get; set; }

    public string Nationality { get; set; } = string.Empty;

    public string HousingType { get; set; } = string.Empty;

    public string Province { get; set; } = string.Empty;

    public string DocumentType { get; set; } = string.Empty;

    public string DocumentNumber { get; set; } = string.Empty;

    public DateTime IssueDate { get; set; }

    public DateTime ExpiryDateOfPassport { get; set; }

    public string CivilIdNumber { get; set; } = string.Empty;

    public string InformationOffice { get; set; } = string.Empty;

    public string Registry { get; set; } = string.Empty;

    public string RecordNumber { get; set; } = string.Empty;

    public string District { get; set; } = string.Empty;

    public string Alley { get; set; } = string.Empty;

    public string HouseNumber { get; set; } = string.Empty;

    public string AddressinOfIRAQ { get; set; } = string.Empty;


    public string Country { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public DateTime ExpirationDate { get; set; }

    public string NationalityIDnumber { get; set; } = string.Empty;


    public string URLIMG { get; set; } = string.Empty;

    public string URLPassport { get; set; } = string.Empty;

    public string URLFileFrontident { get; set; } = string.Empty;

    public string URLFileBackident { get; set; } = string.Empty;

    public string URLNationalityIDnumber { get; set; } = string.Empty;


    public string OTPFOREmail { get; set; } = string.Empty;


    public string OtpforPhone { get; set; } = string.Empty;




}
