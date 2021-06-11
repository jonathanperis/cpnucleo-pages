using Cpnucleo.Domain.Commands.RecursoProjeto.Validations;

namespace Cpnucleo.Domain.Commands.RecursoProjeto.Requests
{
    public class CreateRecursoProjetoCommand : RecursoProjetoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new CreateRecursoProjetoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
