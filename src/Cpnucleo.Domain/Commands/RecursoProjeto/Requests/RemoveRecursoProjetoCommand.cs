using Cpnucleo.Domain.Commands.RecursoProjeto.Validations;

namespace Cpnucleo.Domain.Commands.RecursoProjeto.Requests
{
    public class RemoveRecursoProjetoCommand : RecursoProjetoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new RemoveRecursoProjetoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
