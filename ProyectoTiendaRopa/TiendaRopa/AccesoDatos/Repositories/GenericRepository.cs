using System.Collections.Generic;
using System.Linq;
using AccesoDatos.Data;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : class
    {
        private readonly TiendaRopaDbContext context;

        public GenericRepository(TiendaRopaDbContext context)
        {
            this.context = context;
        }

        public List<T> ObtenerTodos()
        {
            return context.Set<T>().ToList();
        }

        public T? ObtenerPorId(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Agregar(T entidad)
        {
            context.Set<T>().Add(entidad);
            context.SaveChanges();
        }

        public void Modificar(T entidad)
        {
            var entidadExistente = context.Set<T>().Find(
                context.Entry(entidad).Property("Id").CurrentValue
            );

            if (entidadExistente != null)
            {
                context.Entry(entidadExistente).CurrentValues.SetValues(entidad);
            }
            else
            {
                context.Set<T>().Update(entidad);
            }

            context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            T? entidad = context.Set<T>().Find(id);

            if (entidad != null)
            {
                context.Set<T>().Remove(entidad);
                context.SaveChanges();
            }
        }
    }
}


