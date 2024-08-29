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
        public string Cedula { get => this.nombre; set => this.nombre = value; }
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
        public string Usuario { get => this.nombre; set => this.nombre = value; }
        public string Contraseña { get => this.nombre; set => this.nombre = value; }
        public Personas? Persona { get => this.id; set => this.id = value; }

        //Metodos
        
    }
}