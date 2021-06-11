using Cpnucleo.Domain.Commands.Tarefa.Validations;

namespace Cpnucleo.Domain.Commands.Tarefa.Requests
{
    public class UpdateTarefaCommand : TarefaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new UpdateTarefaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
