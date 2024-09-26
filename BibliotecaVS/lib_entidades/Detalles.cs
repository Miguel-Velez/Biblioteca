using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Detalles
    {
        //Propiedades
        public int? Id { get; set; }
        public Prestamos? Prestamo { get; set; }
        [NotMapped] public Libros? Libro { get; set; }
    }
}
