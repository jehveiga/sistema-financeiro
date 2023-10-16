using Domain.Interfaces.Generics;
using Entities.Entities;

namespace Domain.Interfaces.ICategoria
{
    public interface InterfaceCategory : InterfaceGeneric<Category>
    {
        Task<IList<Category>> ListarCategoriasUsuario(string emailUsuario);
    }
}
