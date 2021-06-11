using Cpnucleo.Domain.Commands.Apontamento.Requests;

namespace Cpnucleo.Domain.Commands.Apontamento.Validations
{
    public class CreateApontamentoValidation : ApontamentoValidation<CreateApontamentoCommand>
    {
        public CreateApontamentoValidation()
        {
            ValidateDescricao();
            ValidateDataApontamento();
            ValidateQtdHoras();
            ValidateIdTarefa();
            ValidateIdRecurso();
        }
    }
}
