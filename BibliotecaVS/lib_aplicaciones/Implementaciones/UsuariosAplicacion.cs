﻿using lib_aplicaciones.Interfaces;
using lib_repositorios.Interfaces;
using lib_entidades.Modelos;
using System.Linq.Expressions;
namespace lib_aplicaciones.Implementaciones
{
    public class UsuariosAplicacion : IUsuariosAplicacion
    {
        private IUsuariosRepositorio? iRepositorio = null;
        public UsuariosAplicacion(IUsuariosRepositorio iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }
        public void Configurar(string string_conexion)
        {
            this.iRepositorio!.Configurar(string_conexion);
        }
        public Usuarios Borrar(Usuarios entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");
            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }
        public Usuarios Guardar(Usuarios entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");
            //entidad = Calcular(entidad);
            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }
        public List<Usuarios> Listar()
        {
            return iRepositorio!.Listar();
        }
        public List<Usuarios> Buscar(Usuarios entidad, string tipo)
        {
            Expression<Func<Usuarios, bool>>? condiciones = null;
            switch (tipo.ToUpper())
            {
                //case "NOMBRE": condiciones = x => x.Persona!.Contains(entidad.Persona!); break;
                default: condiciones = x => x.Id == entidad.Id; break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }
        public Usuarios Modificar(Usuarios entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");
            //entidad = Calcular(entidad);
            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }
        //private Usuarios Calcular(Usuarios entidad)
        //{
        //    entidad.Final = (entidad.Nota1 +
        //    entidad.Nota2 +
        //    entidad.Nota3 +
        //    entidad.Nota4 +
        //    entidad.Nota5) / 5;
        //    entidad.Fecha = DateTime.Now;
        //    return entidad;
        //}
    }
}