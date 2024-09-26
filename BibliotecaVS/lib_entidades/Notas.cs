using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Notas
    {
        //Propiedades
        public int? Id { get; set; }
        public string? Descripcion { get; set; }
        [NotMapped] public Prestamos? Prestamo { get; set; }
    }
}
