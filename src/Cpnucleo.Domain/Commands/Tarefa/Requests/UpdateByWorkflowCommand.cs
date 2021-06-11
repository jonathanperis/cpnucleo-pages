using Cpnucleo.Domain.Commands.Tarefa.Validations;

namespace Cpnucleo.Domain.Commands.Tarefa.Requests
{
    public class UpdateByWorkflowCommand : TarefaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new UpdateByWorkflowValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
