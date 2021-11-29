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
    public class ListEntidadModel: PageModel
    {
        [BindProperty]
        public Entidad Entidad {get;set;}
        private readonly RepositorioEntidades repositorioEntidades;
        public IEnumerable<Entidad> Entidades {get;set;} 
        public ListEntidadModel(RepositorioEntidades repositorioEntidades)
        {
        this.repositorioEntidades=repositorioEntidades;
        }
        public void OnGet()
        {
        Entidades=repositorioEntidades.GetAll();
        }
        public IActionResult OnPost()
        {
            if(Entidad.id>0)
            {
             repositorioEntidades.Delete(Entidad.id);
            }

            return RedirectToPage("./List");
        }
    }
}