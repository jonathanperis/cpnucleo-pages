using Cpnucleo.Domain.Commands.Sistema.Validations;

namespace Cpnucleo.Domain.Commands.Sistema.Requests
{
    public class RemoveSistemaCommand : SistemaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new RemoveSistemaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
