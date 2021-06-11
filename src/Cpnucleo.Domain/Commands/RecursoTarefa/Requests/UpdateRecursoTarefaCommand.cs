using Cpnucleo.Domain.Commands.RecursoTarefa.Validations;

namespace Cpnucleo.Domain.Commands.RecursoTarefa.Requests
{
    public class UpdateRecursoTarefaCommand : RecursoTarefaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new UpdateRecursoTarefaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
