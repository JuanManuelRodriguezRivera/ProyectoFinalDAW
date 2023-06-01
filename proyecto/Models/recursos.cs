using System.ComponentModel.DataAnnotations;
namespace proyecto.Models
{
    public class recursos
    {
        [Key]
        public int id_recursos { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string media { get; set; }
    }
}
