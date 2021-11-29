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
    public class DetailsEntidadModel : PageModel
    {
        private readonly RepositorioEntidades repositorioEntidades;
        public Entidad Entidad {get;set;}
 
        public DetailsEntidadModel(RepositorioEntidades repositorioEntidades)
        {
            this.repositorioEntidades=repositorioEntidades;
        }
 
        public IActionResult OnGet(int entidadId)
        {
            Entidad = repositorioEntidades.GetEntidadWithId(entidadId);
                return Page();
 
        }
    }
}