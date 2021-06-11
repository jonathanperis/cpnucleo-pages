using Cpnucleo.Domain.Commands.Apontamento.Validations;

namespace Cpnucleo.Domain.Commands.Apontamento.Requests
{
    public class CreateApontamentoCommand : ApontamentoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new CreateApontamentoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
