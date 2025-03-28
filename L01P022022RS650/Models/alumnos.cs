using System.ComponentModel.DataAnnotations;
namespace L01P022022RS650.Models
{
    public class alumnos
    {
        /*
         * (id           INT IDENTITY(1, 1) PRIMARY KEY,
             codigo       VARCHAR(10),
             nombre       VARCHAR(50),
             apellidos    VARCHAR(50),
             dui          INT,
             estado       INT
            );
         */
        [Key]
        public int id { get; set; }
        [StringLength(10, ErrorMessage = "La cantidad  maxima de caracateres valida es {1}")]
        [Display(Name = "Codigo")]
        public string? codigo { get; set; }
        [StringLength(50, ErrorMessage = "La cantidad  maxima de caracateres valida es {1}")]
        [Display(Name = "Nombre")]
        public string? nombre { get; set; }
        [StringLength(50, ErrorMessage = "La cantidad  maxima de caracateres valida es {1}")]
        [Display(Name = "Apellidos")]
        public string? apellidos { get; set; }
        [Display(Name = "DUI")]
        //Controlar con una expression regular que el dui tenga 9 digitos
        [RegularExpression(@"^\d{9}$", ErrorMessage = "El dui debe tener 9 digitos")]
        public int dui { get; set; }
        [Display(Name = "Estado")]
        [Range(0, 1, ErrorMessage = "El estado debe ser 0 o 1")]

        public int estado { get; set; }
    }
}
