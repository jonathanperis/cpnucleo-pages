using Cpnucleo.Domain.Commands.Recurso.Validations;

namespace Cpnucleo.Domain.Commands.Recurso.Requests
{
    public class RemoveRecursoCommand : RecursoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new RemoveRecursoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
