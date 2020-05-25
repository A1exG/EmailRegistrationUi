using EmailRegistrationUi.EmailRegistrationWebService;
using FluentValidation;

namespace EmailRegistrationUi.Services.Validator
{
    public class EmailValidator : AbstractValidator<Email>
    {
        public EmailValidator()
        {
            RuleFor(Email => Email.EmailName).NotNull();
            RuleFor(Email => Email.EmailRegistrationDate).NotNull();
            RuleFor(Email => Email.EmailTo).NotNull();
            RuleFor(Email => Email.EmailFrom).NotNull();
            RuleFor(Email => Email.EmailTag).NotNull();
            RuleFor(Email => Email.EmailContent).NotNull();
        }
    }
}
