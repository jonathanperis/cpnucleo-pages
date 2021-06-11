using Cpnucleo.Domain.Commands.Impedimento.Validations;

namespace Cpnucleo.Domain.Commands.Impedimento.Requests
{
    public class UpdateImpedimentoCommand : ImpedimentoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new UpdateImpedimentoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
