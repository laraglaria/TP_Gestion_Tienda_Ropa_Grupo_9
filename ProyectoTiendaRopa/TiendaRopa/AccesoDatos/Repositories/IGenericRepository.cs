using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace AccesoDatos.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> ObtenerTodos();

        T? ObtenerPorId(int id);

        void Agregar(T entidad);

        void Modificar(T entidad);

        void Eliminar(int id);
    }
}

