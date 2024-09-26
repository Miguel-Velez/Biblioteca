using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class DetallesRepositorio : IDetallesRepositorio
    {
        private Conexion? conexion = null;

        public DetallesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Detalles> Listar()
        {
            return conexion!.Listar<Detalles>();
        }

        public Detalles Guardar(Detalles entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Detalles Modificar(Detalles entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Detalles Borrar(Detalles entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}