using Cpnucleo.Domain.Commands.Projeto.Validations;

namespace Cpnucleo.Domain.Commands.Projeto.Requests
{
    public class UpdateProjetoCommand : ProjetoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new UpdateProjetoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
