using Cpnucleo.Domain.Commands.ImpedimentoTarefa.Validations;

namespace Cpnucleo.Domain.Commands.ImpedimentoTarefa.Requests
{
    public class RemoveImpedimentoTarefaCommand : ImpedimentoTarefaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new RemoveImpedimentoTarefaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
