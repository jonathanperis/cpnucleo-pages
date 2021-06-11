using Cpnucleo.Domain.Commands.Recurso.Validations;

namespace Cpnucleo.Domain.Commands.Recurso.Requests
{
    public class CreateRecursoCommand : RecursoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new CreateRecursoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
