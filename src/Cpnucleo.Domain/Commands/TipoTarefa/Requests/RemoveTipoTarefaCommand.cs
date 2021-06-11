using Cpnucleo.Domain.Commands.TipoTarefa.Validations;

namespace Cpnucleo.Domain.Commands.TipoTarefa.Requests
{
    public class RemoveTipoTarefaCommand : TipoTarefaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new RemoveTipoTarefaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
