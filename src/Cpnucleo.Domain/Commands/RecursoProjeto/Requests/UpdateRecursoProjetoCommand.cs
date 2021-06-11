using Cpnucleo.Domain.Commands.RecursoProjeto.Validations;

namespace Cpnucleo.Domain.Commands.RecursoProjeto.Requests
{
    public class UpdateRecursoProjetoCommand : RecursoProjetoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new UpdateRecursoProjetoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
