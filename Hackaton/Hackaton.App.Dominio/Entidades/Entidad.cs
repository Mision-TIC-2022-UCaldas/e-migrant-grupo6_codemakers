using System;
using System.ComponentModel.DataAnnotations;

namespace Hackaton.App.Dominio{
    public class Entidad{
        public int id { get; set; }
        [Required]
        public string razon_social { get; set; }
        [Required]
        public string nit { get; set; }
        [Required]
        public string direccion { get; set; }
        [Required]
        public string ciudad{ get; set; }
        [Required]
        public string telefono { get; set; }
        public string email { get; set; }
        public string webpage {get; set;}
        [Required]
         public string sector {get; set;}
         [Required]
        public string servicio {get; set;}
    }
}
