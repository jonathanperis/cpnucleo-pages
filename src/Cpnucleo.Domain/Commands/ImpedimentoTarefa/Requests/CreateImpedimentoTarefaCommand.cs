using Cpnucleo.Domain.Commands.ImpedimentoTarefa.Validations;

namespace Cpnucleo.Domain.Commands.ImpedimentoTarefa.Requests
{
    public class CreateImpedimentoTarefaCommand : ImpedimentoTarefaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new CreateImpedimentoTarefaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
