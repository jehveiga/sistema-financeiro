using Domain.Interfaces.Generics;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace Infrastructure.Repository.Generics
{
    public abstract class RepositoryGenerics<T> : InterfaceGeneric<T> where T : class
    {
        protected readonly ContextBase Db;
        protected readonly DbSet<T> DbSet;

        protected RepositoryGenerics(ContextBase context)
        {
            Db = context;
            DbSet = context.Set<T>();
        }

        public virtual async Task<T> GetEntityById(int id) => await DbSet.FindAsync(id);

        public virtual async Task<IList<T>> List() => await DbSet.AsNoTracking().ToListAsync();

        public IEnumerable<T> Search(Func<T, bool> predicate) => DbSet.AsNoTracking().Where(predicate).ToList();

        public virtual async Task Add(T entity)
        {
            await DbSet.AddAsync(entity);
            await Db.SaveChangesAsync();
        }

        public virtual async Task Delete(T entity)
        {
            DbSet.Remove(entity);
            await Db.SaveChangesAsync();
        }

        public virtual async Task Update(T entity)
        {
            DbSet.Update(entity);
            await Db.SaveChangesAsync();
        }

        #region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);



        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }
        #endregion
    }
}