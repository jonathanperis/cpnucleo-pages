﻿using Cpnucleo.Application.Interfaces;
using Cpnucleo.Infra.CrossCutting.Util.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cpnucleo.RazorPages.Luna.Pages.Projeto
{
    [Authorize]
    public class IncluirModel : PageModel
    {
        private readonly IProjetoAppService _projetoAppService;
        private readonly ISistemaAppService _sistemaAppService;

        public IncluirModel(IProjetoAppService projetoAppService, ISistemaAppService sistemaAppService)
        {
            _projetoAppService = projetoAppService;
            _sistemaAppService = sistemaAppService;
        }

        [BindProperty]
        public ProjetoViewModel Projeto { get; set; }

        public SelectList SelectSistemas { get; set; }

        public IActionResult OnGet()
        {
            SelectSistemas = new SelectList(_sistemaAppService.Listar(), "Id", "Nome");

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                SelectSistemas = new SelectList(_sistemaAppService.Listar(), "Id", "Nome");

                return Page();
            }

            _projetoAppService.Incluir(Projeto);

            return RedirectToPage("Listar");
        }
    }
}