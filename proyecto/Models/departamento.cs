using System.ComponentModel.DataAnnotations;

namespace proyecto.Models
{
    public class departamento
    {
        [Key]
        public int id_departamento { get; set; }

        public string nombre { get; set; }
    }
}
