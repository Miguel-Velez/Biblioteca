using System;

namespace ConsoleApp.Definicion
{
    public class Personas
    {
        // Atributos 
        private int id = 0;
        private string cedula = "";
        private string nombre = "";
        private bool activo = false;


        //Propiedades
        public int Id { get => this.id; set => this.id = value; }
        public string Cedula { get => this.cedula; set => this.cedula = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public bool Activo { get => this.activo; set => this.activo = value; }

        //Metodos
        
    }
        public class Usuarios
    {
        // Atributos 
        private int id = 0;
        private string usuario = "";
        private string contraseña = "";
        private Personas? persona = null;

        //Propiedades
        public int Id { get => this.id; set => this.id = value; }
        public string Usuario { get => this.usuario; set => this.usuario = value; }
        public string Contraseña { get => this.contraseña; set => this.contraseña = value; }
        public Personas? Persona { get => this.persona; set => this.persona = value; }

        //Metodos
        
    }
        public class Prestamos
    {
        // Atributos 
        private int id = 0;
        private string numero = "";
        private string fecha = "";
        private Usuarios? usuario = null;

        //Propiedades
        public int Id { get => this.id; set => this.id = value; }
        public string Numero { get => this.numero; set => this.numero = value; }
        public string Fecha { get => this.fecha; set => this.fecha = value; }
        public Usuarios? Usuario { get => this.usuario; set => this.usuario = value; }

        //Metodos
        
    }
        public class Detalles
    {
        // Atributos 
        private int id = 0;
        private Prestamos? prestamo = null;
        private Libros? libro = null;

        //Propiedades
        public int Id { get => this.id; set => this.id = value; }
        public Prestamos? Prestamo { get => this.prestamo; set => this.prestamo = value; }
        public Libros? Libro { get => this.libro; set => this.libro = value; }

        //Metodos
        
    }
    public class Notas
    {
        // Atributos 
        private int id = 0;
        private string descripcion = "";
        private Libros? libro = null;

        //Propiedades
        public int Id { get => this.id; set => this.id = value; }
        public string Descripcion { get => this.numero; set => this.numero = value; }
        public Prestamos? Prestamo { get => this.prestamo; set => this.prestamo = value; }

        //Metodos
        
    }
    public class Libros
    {
        // Atributos 
        private int id = 0;
        private string nombre = "";
        private string autor = "";
        private Estados? estado = null;

        //Propiedades
        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Autor { get => this.autor; set => this.autor = value; }
        public Estados? Estado { get => this.estado; set => this.estado = value; }

        //Metodos
        
    }
    public class Estados
    {
        // Atributos 
        private int id = 0;
        private string tipo = "";

        //Propiedades
        public int Id { get => this.id; set => this.id = value; }
        public string Tipo { get => this.tipo; set => this.tipo = value; }

        //Metodos
        
    }
}