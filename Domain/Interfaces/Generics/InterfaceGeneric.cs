﻿namespace Domain.Interfaces.Generics
{
    public interface InterfaceGeneric<T> : IDisposable where T : class
    {
        Task<T> GetEntityById(int id);
        Task<IList<T>> List();
        IEnumerable<T> Search(Func<T, bool> predicate); // Metodo para buscar qualquer entidade por qualquer parametro, 
                                                        // retorno uma List Enumerable de obj Entity
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
