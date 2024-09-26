using lib_entidades;

namespace lib_repositorios.Interfaces
{
    public interface IUsuariosRepositorio
    {
        List<Usuarios> Listar();
        Usuarios Guardar(Usuarios entidad);
        Usuarios Modificar(Usuarios entidad);
        Usuarios Borrar(Usuarios entidad);
    }
}