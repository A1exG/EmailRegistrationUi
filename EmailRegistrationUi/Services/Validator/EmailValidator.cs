using EmailRegistrationUi.EmailRegistrationWebService;
using FluentValidation;

namespace EmailRegistrationUi.Services.Validator
{
    public class EmailValidator : AbstractValidator<Email>
    {
        public EmailValidator()
        {
            RuleFor(Email => Email.EmailName).NotEmpty();
            RuleFor(Email => Email.EmailRegistrationDate).NotEmpty();
            RuleFor(Email => Email.EmailTo).NotEmpty();
            RuleFor(Email => Email.EmailFrom).NotEmpty();
            RuleFor(Email => Email.EmailTag).NotEmpty();
            RuleFor(Email => Email.EmailContent).NotEmpty();
        }
    }
}
