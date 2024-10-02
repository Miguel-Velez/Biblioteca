﻿using lib_entidades;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IEstadosRepositorio
    {
        List<Estados> Listar();
        List<Estados> Buscar(Expression<Func<Estados, bool>> condiciones);
        Estados Guardar(Estados entidad);
        Estados Modificar(Estados entidad);
        Estados Borrar(Estados entidad);
    }
}