using Cpnucleo.Domain.Commands.Sistema.Validations;

namespace Cpnucleo.Domain.Commands.Sistema.Requests
{
    public class UpdateSistemaCommand : SistemaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new UpdateSistemaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
