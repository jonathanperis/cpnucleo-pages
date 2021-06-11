using Cpnucleo.Domain.Commands.Projeto.Validations;

namespace Cpnucleo.Domain.Commands.Projeto.Requests
{
    public class RemoveProjetoCommand : ProjetoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new RemoveProjetoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
