using Cpnucleo.Domain.Commands.Impedimento.Validations;

namespace Cpnucleo.Domain.Commands.Impedimento.Requests
{
    public class RemoveImpedimentoCommand : ImpedimentoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new RemoveImpedimentoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
