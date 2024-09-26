using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace lib_entidades
{
    public class Prestamos
    {
        //Propiedades
        public int? Id { get; set; }
        public string? Numero { get; set; }
        public string? Fecha { get; set; }
        [NotMapped] public Usuarios? Usuario { get; set; }
    }
}

