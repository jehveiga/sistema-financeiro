using Domain.Interfaces.ICategoria;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;

namespace Infrastructure.Repository
{
    public class RepositoryCategory : RepositoryGenerics<Category>, InterfaceCategory
    {
        public RepositoryCategory(ContextBase context) : base(context)
        {
        }
    }
}
