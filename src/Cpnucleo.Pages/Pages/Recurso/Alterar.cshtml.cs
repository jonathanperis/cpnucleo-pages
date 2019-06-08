﻿using Cpnucleo.Pages.Models;
using Cpnucleo.Pages.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Cpnucleo.Pages.Pages.Recurso
{
    [Authorize]
    public class AlterarModel : PageModel
    {
        private readonly IRecursoRepository _recursoRepository;

        public AlterarModel(IRecursoRepository recursoRepository) => _recursoRepository = recursoRepository;

        [BindProperty]
        public RecursoItem Recurso { get; set; }

        public async Task<IActionResult> OnGetAsync(int idRecurso)
        {
            Recurso = await _recursoRepository.Consultar(idRecurso);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(RecursoItem recurso)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _recursoRepository.Alterar(recurso);

            return RedirectToPage("Listar");
        }
    }
}