﻿using Cpnucleo.Infra.CrossCutting.Util.ViewModels;
using Cpnucleo.RazorPages.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Cpnucleo.RazorPages.Pages.Impedimento
{
    [Authorize]
    public class AlterarModel : PageBase
    {
        private readonly ICpnucleoApiService _cpnucleoApiService;

        public AlterarModel(ICpnucleoApiService cpnucleoApiService)
        {
            _cpnucleoApiService = cpnucleoApiService;
        }

        [BindProperty]
        public ImpedimentoViewModel Impedimento { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            try
            {
                Impedimento = await _cpnucleoApiService.GetAsync<ImpedimentoViewModel>("impedimento", Token, id);

                return Page();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    Impedimento = await _cpnucleoApiService.GetAsync<ImpedimentoViewModel>("impedimento", Token, Impedimento.Id);

                    return Page();
                }

                await _cpnucleoApiService.PutAsync("impedimento", Token, Impedimento.Id, Impedimento);

                return RedirectToPage("Listar");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return Page();
            }
        }
    }
}