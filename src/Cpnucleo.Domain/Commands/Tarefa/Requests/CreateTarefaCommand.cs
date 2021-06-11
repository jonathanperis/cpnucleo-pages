using Cpnucleo.Domain.Commands.Tarefa.Validations;

namespace Cpnucleo.Domain.Commands.Tarefa.Requests
{
    public class CreateTarefaCommand : TarefaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new CreateTarefaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
