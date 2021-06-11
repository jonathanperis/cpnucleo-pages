using Cpnucleo.Domain.Commands.TipoTarefa.Validations;

namespace Cpnucleo.Domain.Commands.TipoTarefa.Requests
{
    public class UpdateTipoTarefaCommand : TipoTarefaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new UpdateTipoTarefaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
