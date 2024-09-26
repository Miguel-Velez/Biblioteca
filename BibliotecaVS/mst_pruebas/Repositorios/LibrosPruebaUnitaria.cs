using lib_entidades;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class LibrosPruebaUnitaria
    {
        private ILibrosRepositorio? iRepositorio = null;
        private Libros? entidad = null;

        public LibrosPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=ANXKY\\SQLEXPRESS;database=DB_BIBLIOTECA;Integrated Security=True;TrustServerCertificate=true;";
            iRepositorio = new LibrosRepositorio(conexion);
        }

        [TestMethod]
        public void Ejecutar()
        {
            Guardar();
            Listar();
            Modificar();
            Borrar();
        }

        private void Guardar()
        {
            entidad = new Libros()
            {
                Persona = "Test",
                Nota1 = 1.2m,
                Nota2 = 2.4m,
                Nota3 = 3.9m,
                Nota4 = 4.8m,
                Nota5 = 5,
                Final = 0.0m,
                Fecha = DateTime.Now
            };
            entidad = iRepositorio!.Guardar(entidad);
            Assert.IsTrue(entidad.Id != 0);
        }

        private void Listar()
        {
            var lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }

        private void Modificar()
        {
            entidad!.Final = 3.0m;
            entidad = iRepositorio!.Modificar(entidad!);
            Assert.IsTrue(entidad!.Final == 3.0m);
        }

        private void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);
            Assert.IsTrue(entidad.Id != 0);
        }
    }
}