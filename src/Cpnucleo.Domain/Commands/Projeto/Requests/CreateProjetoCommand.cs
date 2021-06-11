using Cpnucleo.Domain.Commands.Projeto.Validations;

namespace Cpnucleo.Domain.Commands.Projeto.Requests
{
    public class CreateProjetoCommand : ProjetoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new CreateProjetoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
