using Cpnucleo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cpnucleo.Domain.Interfaces
{
    public interface IImpedimentoTarefaRepository : IGenericRepository<ImpedimentoTarefa>
    {
        Task<IEnumerable<ImpedimentoTarefa>> GetByTarefaAsync(Guid idTarefa);
    }
}