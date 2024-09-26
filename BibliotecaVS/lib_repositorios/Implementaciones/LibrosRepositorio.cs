using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class LibrosRepositorio : ILibrosRepositorio
    {
        private Conexion? conexion = null;

        public LibrosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Libros> Listar()
        {
            return conexion!.Listar<Libros>();
        }

        public Libros Guardar(Libros entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Libros Modificar(Libros entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Libros Borrar(Libros entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}