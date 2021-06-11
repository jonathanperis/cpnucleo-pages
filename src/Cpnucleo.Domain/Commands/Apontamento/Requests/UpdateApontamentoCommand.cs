using Cpnucleo.Domain.Commands.Apontamento.Validations;

namespace Cpnucleo.Domain.Commands.Apontamento.Requests
{
    public class UpdateApontamentoCommand : ApontamentoCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new UpdateApontamentoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
