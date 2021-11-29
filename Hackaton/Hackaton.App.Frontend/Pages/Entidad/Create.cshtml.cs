using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hackaton.App.Persistencia.AppRepositorios;
using Hackaton.App.Dominio;

namespace Hackaton.App.Frontend.Pages
{
    public class FormEntidadModel : PageModel
    {
        private readonly RepositorioEntidades repositorioEntidades;
        [BindProperty]
        public Entidad Entidad { get; set; }
        public FormEntidadModel(RepositorioEntidades repositorioEntidades )
        {
            this.repositorioEntidades = repositorioEntidades;         
        }
        public void OnGet()
        {
        
        }
        public IActionResult OnPost( )
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Entidad = repositorioEntidades.Create(Entidad );
            return RedirectToPage("./List");
        }
    }
}
