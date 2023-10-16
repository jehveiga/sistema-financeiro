using Domain.Interfaces.ISistemaFinanceiro;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;

namespace Infrastructure.Repository
{
    public class RepositorySystemFinancial : RepositoryGenerics<SystemFinancial>, InterfaceSystemFinancial
    {
        public RepositorySystemFinancial(ContextBase context) : base(context)
        {
        }

        public Task<IList<SystemFinancial>> ListarSistemasUsuario(string emailUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
