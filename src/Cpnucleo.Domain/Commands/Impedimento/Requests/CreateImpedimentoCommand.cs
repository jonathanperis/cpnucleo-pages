using Cpnucleo.Domain.Commands.Impedimento.Validations;

namespace Cpnucleo.Domain.Commands.Impedimento.Requests
{
    public class CreateImpedimentoCommand : ImpedimentoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new CreateImpedimentoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
