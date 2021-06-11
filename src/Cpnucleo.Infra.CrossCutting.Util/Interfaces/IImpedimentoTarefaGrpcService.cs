using Cpnucleo.Infra.CrossCutting.Util.Commands.ImpedimentoTarefa.CreateImpedimentoTarefa;
using Cpnucleo.Infra.CrossCutting.Util.Commands.ImpedimentoTarefa.RemoveImpedimentoTarefa;
using Cpnucleo.Infra.CrossCutting.Util.Commands.ImpedimentoTarefa.UpdateImpedimentoTarefa;
using MagicOnion;

namespace Cpnucleo.Infra.CrossCutting.Util.Interfaces
{
    public interface IImpedimentoTarefaGrpcService : IService<IImpedimentoTarefaGrpcService>
    {
        UnaryResult<CreateImpedimentoTarefaResponse> AddAsync(CreateImpedimentoTarefaCommand command);

        UnaryResult<UpdateImpedimentoTarefaResponse> UpdateAsync(UpdateImpedimentoTarefaCommand command);

        UnaryResult<GetImpedimentoTarefaResponse> GetAsync(GetImpedimentoTarefaQuery query);

        UnaryResult<ListImpedimentoTarefaResponse> AllAsync(ListImpedimentoTarefaQuery query);

        UnaryResult<RemoveImpedimentoTarefaResponse> RemoveAsync(RemoveImpedimentoTarefaCommand command);

        UnaryResult<GetByTarefaResponse> GetByTarefaAsync(GetByTarefaQuery query);
    }
}
