using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace L01P022022RS650.Models
{
    public class facultades
    {
        /*
         id       INT IDENTITY(1, 1) PRIMARY KEY,
                    facultad VARCHAR(100)
         */
        [Key]
        public int id { get; set; }
        [Display(Name = "Facultad")]
        [StringLength(100, ErrorMessage = "La cantidad  maxima de caracateres valida es {1}")]
        public string? facultad { get; set; }
    }
}
