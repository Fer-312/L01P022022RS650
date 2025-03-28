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
        public string? facultad { get; set; }
    }
}
