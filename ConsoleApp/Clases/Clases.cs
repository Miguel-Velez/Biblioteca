using System;

namespace ConsoleApp.Definicion
{
    public class Personas
    {
        //Propiedades
        public int? Id { get; set;}
        public string? Cedula { get; set;}
        public string? Nombre { get; set;}
        public bool? Activo { get; set;}
    }

        public class Usuarios
    {
        //Propiedades
        public int? Id { get; set;}
        public string? Usuario { get; set;}
        public string? Contraseña { get; set;}
        [NotMapped] public Personas? Persona { get; set;}
    }
    
    public class Estados
    {
        //Propiedades
        public int? Id { get; set;}
        public string? Tipo { get; set;}
    }

    public class Libros
    {
        //Propiedades
        public int? Id { get; set;}
        public string? Nombre { get; set;}
        public string? Autor { get; set;}
        [NotMapped] public Estados? Estado { get; set;}
    }

        public class Prestamos
    {
        //Propiedades
        public int Id? { get; set;}
        public string? Numero { get; set;}
        public string? Fecha { get; set;}
        [NotMapped] public Usuarios? Usuario { get; set;}
    }

        public class Detalles
    {
        //Propiedades
        public int? Id { get; set;}
        public Prestamos? Prestamo { get; set;}
        [NotMapped] public Libros? Libro { get; set;}
    }

    public class Notas
    {
        //Propiedades
        public int? Id { get; set;}
        public string? Descripcion { get; set;}
        [NotMapped] public Prestamos? Prestamo { get; set;}
    }

    
}