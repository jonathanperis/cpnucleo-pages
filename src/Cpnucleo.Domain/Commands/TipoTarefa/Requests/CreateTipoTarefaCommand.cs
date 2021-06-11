using Cpnucleo.Domain.Commands.TipoTarefa.Validations;

namespace Cpnucleo.Domain.Commands.TipoTarefa.Requests
{
    public class CreateTipoTarefaCommand : TipoTarefaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new CreateTipoTarefaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
