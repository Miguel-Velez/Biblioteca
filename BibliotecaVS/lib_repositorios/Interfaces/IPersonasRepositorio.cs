using lib_entidades;

namespace lib_repositorios.Interfaces
{
    public interface IPersonasRepositorio
    {
        List<Personas> Listar();
        Personas Guardar(Personas entidad);
        Personas Modificar(Personas entidad);
        Personas Borrar(Personas entidad);
    }
}