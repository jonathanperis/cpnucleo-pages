using Cpnucleo.Domain.Commands.Apontamento.Requests;

namespace Cpnucleo.Domain.Commands.Apontamento.Validations
{
    public class RemoveApontamentoValidation : ApontamentoValidation<RemoveApontamentoCommand>
    {
        public RemoveApontamentoValidation()
        {
            ValidateId();
        }
    }
}
