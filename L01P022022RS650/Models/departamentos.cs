using System.ComponentModel.DataAnnotations;

namespace L01P022022RS650.Models
{
    public class departamentos
    {
        /*
         * (id           INT IDENTITY(1, 1) PRIMARY KEY,
            departamento VARCHAR(50)
);
         */
        [Key]
        public int id { get; set; }
        [StringLength(50, ErrorMessage = "La cantidad  maxima de caracateres valida es {1}")]
        [Display(Name = "Departamento")]
        public string? departamento { get; set; }
    }
}
