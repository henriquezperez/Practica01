using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica01.Models
{
    public class Estudiante
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Autoincrement
        public int Id { get; set; }
       
        public string Name { get; set; } //string? -> valores nulos

        public string LastName { get; set; }
    }
}
