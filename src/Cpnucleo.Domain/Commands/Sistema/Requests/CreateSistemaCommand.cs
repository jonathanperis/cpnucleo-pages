using Cpnucleo.Domain.Commands.Sistema.Validations;

namespace Cpnucleo.Domain.Commands.Sistema.Requests
{
    public class CreateSistemaCommand : SistemaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new CreateSistemaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
