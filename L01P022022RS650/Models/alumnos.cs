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
        public string? codigo { get; set; }
        public string? nombre { get; set; }
        public string? apellidos { get; set; }
        public int dui { get; set; }
        public int estado { get; set; }
    }
}
