using Cpnucleo.Domain.Commands.RecursoTarefa.Validations;

namespace Cpnucleo.Domain.Commands.RecursoTarefa.Requests
{
    public class RemoveRecursoTarefaCommand : RecursoTarefaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new RemoveRecursoTarefaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
