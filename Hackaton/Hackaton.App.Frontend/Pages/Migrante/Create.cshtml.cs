using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hackaton.App.Persistencia.AppRepositorios;
using Hackaton.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace Hackaton.App.Frontend.Pages
{
    [Authorize]
    public class FormMigranteModel : PageModel
    {
        private readonly RepositorioMigrantes repositorioMigrantes;
        [BindProperty]
        public Migrantes Migrante {get;set;}
        public FormMigranteModel(RepositorioMigrantes repositorioMigrantes)
        {
            this.repositorioMigrantes=repositorioMigrantes;
        }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Migrante = repositorioMigrantes.Create(Migrante);
            return RedirectToPage("./List");
        }

    }
}
