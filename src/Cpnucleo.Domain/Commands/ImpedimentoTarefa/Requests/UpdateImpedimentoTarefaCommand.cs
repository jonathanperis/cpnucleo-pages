using Cpnucleo.Domain.Commands.ImpedimentoTarefa.Validations;

namespace Cpnucleo.Domain.Commands.ImpedimentoTarefa.Requests
{
    public class UpdateImpedimentoTarefaCommand : ImpedimentoTarefaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new UpdateImpedimentoTarefaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
