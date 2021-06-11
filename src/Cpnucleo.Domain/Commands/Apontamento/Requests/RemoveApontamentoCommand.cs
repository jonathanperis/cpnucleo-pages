using Cpnucleo.Domain.Commands.Apontamento.Validations;

namespace Cpnucleo.Domain.Commands.Apontamento.Requests
{
    public class RemoveApontamentoCommand : ApontamentoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new RemoveApontamentoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
