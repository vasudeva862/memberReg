using CommonLayer;
using FluentValidation;

namespace Member_Registration_Portal_.Net.Validators
{
    public class SignUpRequestValidator : AbstractValidator<SignUpRequest>
    {
        public SignUpRequestValidator()
        {
            /*
            public string? Name { get; set; } = string.Empty;
            public string? EmailID { get; set; } = string.Empty;
            public string? Address { get; set; } = string.Empty;
            public string? State { get; set; } = string.Empty;
            public string? Country { get; set; } = string.Empty;
            public string? PanNumber { get; set; } = string.Empty;
            public string? ContactNumber { get; set; } = string.Empty;
            public string? DateOfBirth { get; set; } = string.Empty;
            public string? Password { get; set; } = string.Empty;
             */
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Name Is Required");
            RuleFor(x => x.Address)
                .NotEmpty()
                .NotNull()
                .WithMessage("Address Is Required");
        }
    }
}
