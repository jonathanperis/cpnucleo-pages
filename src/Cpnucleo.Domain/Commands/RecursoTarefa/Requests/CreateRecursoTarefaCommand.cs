using Cpnucleo.Domain.Commands.RecursoTarefa.Validations;

namespace Cpnucleo.Domain.Commands.RecursoTarefa.Requests
{
    public class CreateRecursoTarefaCommand : RecursoTarefaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new CreateRecursoTarefaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
