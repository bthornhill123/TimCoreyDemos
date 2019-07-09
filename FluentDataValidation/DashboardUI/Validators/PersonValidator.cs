using FluentValidation;
using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardUI.Validators
{
    public class PersonValidator : AbstractValidator<PersonModel>
    {
        public PersonValidator()
        {
            RuleFor(p => p.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is empty.")
                .Length(2, 50).WithMessage("Invalid ({TotalLength}) {PropertyName} length.")
                .Must(BeAValidName).WithMessage("{PropertyName} contains invalid characters.");
            
            RuleFor(p => p.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is empty.")
                .Length(2, 50).WithMessage("Invalid ({TotalLength}) {PropertyName} length.")
                .Must(BeAValidName).WithMessage("{PropertyName} contains invalid characters.");

            RuleFor(p => p.DateOfBirth)
                .Must(BeAValidAge).WithMessage("Invalid {PropertyName}");
        }

        protected bool BeAValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");

            return name.All(Char.IsLetter);
        }

        protected bool BeAValidAge(DateTime date)
        {
            int currentYear = DateTime.Now.Year;
            int birthYear = date.Year;

            if(birthYear <= currentYear && birthYear > (currentYear - 120))
            {
                return true;
            }

            return false;
        }
    }
}
