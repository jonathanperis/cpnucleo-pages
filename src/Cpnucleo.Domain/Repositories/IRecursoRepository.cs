using Cpnucleo.Domain.Entities;
using System.Threading.Tasks;

namespace Cpnucleo.Domain.Repositories
{
    public interface IRecursoRepository : IGenericRepository<Recurso>
    {
        Task<Recurso> GetByLoginAsync(string login);
    }
}