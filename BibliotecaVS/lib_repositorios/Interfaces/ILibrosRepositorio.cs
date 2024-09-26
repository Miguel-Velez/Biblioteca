using lib_entidades;

namespace lib_repositorios.Interfaces
{
    public interface ILibrosRepositorio
    {
        List<Libros> Listar();
        Libros Guardar(Libros entidad);
        Libros Modificar(Libros entidad);
        Libros Borrar(Libros entidad);
    }
}