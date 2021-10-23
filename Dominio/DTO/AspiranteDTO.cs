using Dominio.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DTO
{
    public class AspiranteDTO
    {

        [Required]
        [StringLength(20, MinimumLength = 3)]
        // Nombre del aspirante
        public string Nombre { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        // Apellido del aspirante
        public string Apellido { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 3)]
        // Identificación del aspirante
        public string Identificacion { get; set; }

        [Required]
        [Range(1, 99)]
        // Edad del aspirante
        public int Edad { get; set; }

        [Range(0, 4)]
        // Casa a la que desea pertenecer
        public EnumCasa  Casa { get; set; }

    }
}
