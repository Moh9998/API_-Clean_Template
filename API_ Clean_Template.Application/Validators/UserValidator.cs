using API__Clean_Template.Domain.Entities.User;
using FluentValidation;

namespace API__Clean_Template.Application.Validators
{
    public class UserValidator : AbstractValidator<User>
    {

        public UserValidator( )
        {
            RuleFor(x => x.Name).NotEmpty( ).WithMessage("Name is required");
            RuleFor(x => x.FatherName).NotEmpty( ).WithMessage("Father Name is required");
            RuleFor(x => x.GrandFatherName).NotEmpty( ).WithMessage("GrandFather Name is required");
            RuleFor(x => x.GreatGandFatherName).NotEmpty( ).WithMessage("GreatGandFather Name is required");
            RuleFor(x => x.LastName).NotEmpty( ).WithMessage("LastName is required");
            RuleFor(x => x.Fullname).NotEmpty( ).WithMessage("Fullname is required");
            RuleFor(x => x.MotherName).NotEmpty( ).WithMessage("MotherName is required");
            RuleFor(x => x.Email).NotEmpty( ).EmailAddress( ).WithMessage("Email is required");
            RuleFor(p => p.Password).NotEmpty( ).WithMessage("Your password cannot be empty")
                     .MinimumLength(8).WithMessage("Your password length must be at least 8.")
                     .MaximumLength(16).WithMessage("Your password length must not exceed 16.")
                     .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
                     .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
                     .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.")
                     .Matches(@"[\!\?\*\.]+").WithMessage("Your password must contain at least one (!? *.).");
            RuleFor(x => x.PhoneNumber).NotEmpty( ).WithMessage("PhoneNumber is required");

        }


    }
}
