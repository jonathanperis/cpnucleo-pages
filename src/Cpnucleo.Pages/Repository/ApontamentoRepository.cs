using Cpnucleo.Pages.Data;
using Cpnucleo.Pages.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cpnucleo.Pages.Repository
{
    public class ApontamentoRepository : IApontamentoRepository
    {
        private readonly Context _context;

        private readonly ITarefaRepository _tarefaRepository;

        public ApontamentoRepository(Context context,
                                    ITarefaRepository tarefaRepository)
        {
            _context = context;
            _tarefaRepository = tarefaRepository;
        }        

        public async Task Incluir(ApontamentoItem apontamento)
        {           
            apontamento.DataInclusao = DateTime.Now;
            
            _context.Apontamentos.Add(apontamento);
            await _context.SaveChangesAsync();

            var tarefaItem = await _tarefaRepository.Consultar(apontamento.IdTarefa);
            tarefaItem.PercentualConcluido = apontamento.PercentualConcluido;

            await _tarefaRepository.Alterar(tarefaItem);            
        }

        public async Task Alterar(ApontamentoItem apontamento)
        {
            var apontamentoItem = _context.Apontamentos.Find(apontamento.IdApontamento);
            apontamentoItem.Descricao = apontamento.Descricao;
            apontamentoItem.DataApontamento = apontamento.DataApontamento;
            apontamentoItem.QtdHoras = apontamento.QtdHoras;
            apontamentoItem.PercentualConcluido = apontamento.PercentualConcluido;

            apontamentoItem.DataAlteracao = DateTime.Now;

            _context.Apontamentos.Update(apontamentoItem);
            await _context.SaveChangesAsync();
        }

        public async Task<ApontamentoItem> Consultar(int idApontamento)
        {
            return await _context.Apontamentos
                .AsNoTracking()
                .Include(x => x.Tarefa)
                .SingleOrDefaultAsync(x => x.IdApontamento == idApontamento);
        }

        public async Task<IEnumerable<ApontamentoItem>> Listar()
        {
            return await _context.Apontamentos
                .AsNoTracking()
                .Include(x => x.Tarefa)
                .OrderBy(x => x.DataInclusao)
                .ToListAsync();
        }  

        public async Task Remover(ApontamentoItem apontamento)
        {    
            var apontamentoItem = _context.Apontamentos.Find(apontamento.IdApontamento);            

            _context.Apontamentos.Remove(apontamentoItem);
            await _context.SaveChangesAsync();
        }

        public async Task<int> ObterTotalHorasPoridRecurso(int idRecurso, int idTarefa)
        {
            return await _context.Apontamentos
                .AsNoTracking()
                .Include(x => x.Tarefa)
                .OrderBy(x => x.DataInclusao)
                .Where(x => x.IdRecurso == idRecurso && x.IdTarefa == idTarefa)
                .SumAsync(x => x.QtdHoras);
        }              

        public async Task<IEnumerable<ApontamentoItem>> ListarPoridRecurso(int idRecurso)
        {
            return await _context.Apontamentos
                .AsNoTracking()
                .Include(x => x.Tarefa)
                .OrderBy(x => x.DataInclusao)
                .Where(x => x.IdRecurso == idRecurso && x.DataApontamento.Value > DateTime.Now.AddDays(-30))
                .ToListAsync();
        }                    
    }    
}