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
    public class EditEntidadModel : PageModel
    {
        private readonly RepositorioEntidades repositorioEntidades;
        [BindProperty]
        public Entidad Entidad {get;set;}   
        public EditEntidadModel(RepositorioEntidades repositorioEntidades)
        {    
            this.repositorioEntidades=repositorioEntidades;
        }
        public IActionResult OnGet(int entidadId)
        {
            Entidad=repositorioEntidades.GetEntidadWithId(entidadId);
            return Page(); 
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Entidad.id>0)
            {
            Entidad = repositorioEntidades.Update(Entidad);
            }
            return RedirectToPage("./List");
        }
    }
}