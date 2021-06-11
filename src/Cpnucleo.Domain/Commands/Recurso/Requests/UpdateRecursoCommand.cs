using Cpnucleo.Domain.Commands.Recurso.Validations;

namespace Cpnucleo.Domain.Commands.Recurso.Requests
{
    public class UpdateRecursoCommand : RecursoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new UpdateRecursoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
