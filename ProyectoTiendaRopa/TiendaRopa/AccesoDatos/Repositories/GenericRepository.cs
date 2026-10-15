using System;
using System.Collections.Generic;
using System.Text;
using AccesoDatos.Data;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : class
    {
        public List<T> ObtenerTodos()
        {
            using var context = new TiendaRopaDbContext();

            return context.Set<T>().ToList();
        }

        public T? ObtenerPorId(int id)
        {
            using var context = new TiendaRopaDbContext();

            return context.Set<T>().Find(id);
        }

        public void Agregar(T entidad)
        {
            using var context = new TiendaRopaDbContext();

            context.Set<T>().Add(entidad);
            context.SaveChanges();
        }

        public void Modificar(T entidad)
        {
            using var context = new TiendaRopaDbContext();

            context.Set<T>().Update(entidad);
            context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            using var context = new TiendaRopaDbContext();

            T? entidad = context.Set<T>().Find(id);

            if (entidad != null)
            {
                context.Set<T>().Remove(entidad);
                context.SaveChanges();
            }
        }
    }
}

