using System.ComponentModel.DataAnnotations;

namespace proyecto.Models
{
    public class trabajo
    {
        [Key]
        public int id_trabajo { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public int empresa_id { get; set; }
        
        public double salario { get; set; }

        public int departamento_id { get; set; }

        public string imagen { get; set; }
    }
}
