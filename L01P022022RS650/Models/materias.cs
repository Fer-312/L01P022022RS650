using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022022RS650.Models
{
    public class materias
    {
        /*
         * (id                   INT IDENTITY(1, 1) PRIMARY KEY,
     materia              VARCHAR(100),
    unidades_valorativas INT,
    estado               CHAR(1)
);
         */
        [Key]
        public int id { get; set; }
        [StringLength(100, ErrorMessage = "La cantidad  maxima de caracateres valida es {1}")]
        [Display(Name ="Materia")]
        public string? materia { get; set; }
        [Display(Name = "Unidades Valorativas")]
        [Range(1, 10, ErrorMessage = "Las unidades valorativas deben estar entre 1 y 10")]
        public int unidades_valorativas { get; set; }
        [Display(Name = "Estado")]

        [RegularExpression(@"^[AI]$", ErrorMessage = "Solo se permiten los valores A o I")]
        public char estado { get; set; }
    }
}
