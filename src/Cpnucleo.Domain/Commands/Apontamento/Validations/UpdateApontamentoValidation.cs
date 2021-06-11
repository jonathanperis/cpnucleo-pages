using Cpnucleo.Domain.Commands.Apontamento.Requests;

namespace Cpnucleo.Domain.Commands.Apontamento.Validations
{
    public class UpdateApontamentoValidation : ApontamentoValidation<UpdateApontamentoCommand>
    {
        public UpdateApontamentoValidation()
        {
            ValidateId();
            ValidateDescricao();
            ValidateDataApontamento();
            ValidateQtdHoras();
            ValidateIdTarefa();
            ValidateIdRecurso();
            ValidateDataInclusao();
        }
    }
}
