using Dominio.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("aspirante")]
    public class Aspirante
    {
        [Column("aspiranteid")]
        public int AspiranteId { get; set; }

        [Column("nombre")]
        // Nombre del aspirante
        public string Nombre { get; set; }

        [Column("apellido")]
        // Apellido del aspirante
        public string Apellido { get; set; }

        [Column("identificacion")]
        // Identificación del aspirante
        public string Identificacion { get; set; }

        [Column("edad")]
        // Edad del aspirante
        public int Edad { get; set; }

        [Column("casa")]
        // Casa a la que desea pertenecer
        public EnumCasa Casa { get; set; }
    }
}
