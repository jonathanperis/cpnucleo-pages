using Cpnucleo.Domain.Commands.Tarefa.Validations;

namespace Cpnucleo.Domain.Commands.Tarefa.Requests
{
    public class RemoveTarefaCommand : TarefaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new RemoveTarefaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
