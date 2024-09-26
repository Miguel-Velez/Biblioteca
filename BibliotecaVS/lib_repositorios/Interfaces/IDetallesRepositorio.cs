using lib_entidades;

namespace lib_repositorios.Interfaces
{
    public interface IDetallesRepositorio
    {
        List<Detalles> Listar();
        Detalles Guardar(Detalles entidad);
        Detalles Modificar(Detalles entidad);
        Detalles Borrar(Detalles entidad);
    }
}