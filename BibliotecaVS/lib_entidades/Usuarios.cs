using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace lib_entidades
{
    public class Usuarios
    {
        //Propiedades
        public int? Id { get; set; }
        public string? Usuario { get; set; }
        public string? Contraseña { get; set; }
        [NotMapped] public Personas? Persona { get; set; }
    }
}
