using System;
using System.ComponentModel.DataAnnotations;
namespace Hackaton.App.Dominio
{
    public class Migrantes
    {
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellidos { get; set; }
        [Required]
        public string tipo_documento { get; set; }
        [Required]
        public string identificacion { get; set; }
        [Required]
        public string pais_origen { get; set; }
        [Required]
        public string fecha_nacimiento { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string direccion_actual { get; set; }
        public string ciudad { get; set; }
        public string situacion_laboral { get; set; }
    }
}

