using lib_entidades;

namespace lib_repositorios.Interfaces
{
    public interface IPrestamosRepositorio
    {
        List<Prestamos> Listar();
        Prestamos Guardar(Prestamos entidad);
        Prestamos Modificar(Prestamos entidad);
        Prestamos Borrar(Prestamos entidad);
    }
}