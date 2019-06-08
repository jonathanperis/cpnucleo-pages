﻿using Cpnucleo.Pages.Models;
using Cpnucleo.Pages.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Cpnucleo.Pages.Pages.Projeto
{
    [Authorize]
    public class RemoverModel : PageModel
    {
        private readonly IRepository<ProjetoItem> _projetoRepository;

        public RemoverModel(IRepository<ProjetoItem> projetoRepository) => _projetoRepository = projetoRepository;

        [BindProperty]
        public ProjetoItem Projeto { get; set; }

        public async Task<IActionResult> OnGetAsync(int idProjeto)
        {
            Projeto = await _projetoRepository.Consultar(idProjeto);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(ProjetoItem projeto)
        {
            if (!ModelState.IsValid) return Page();

            await _projetoRepository.Remover(projeto);

            return RedirectToPage("Listar");
        }
    }
}