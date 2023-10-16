using Domain.Interfaces.IUsuarioSistemaFinanceiro;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;

namespace Infrastructure.Repository
{
    public class RepositoryUserSystemFinancial : RepositoryGenerics<UserSystemFinancial>, InterfaceUserSystemFinancial
    {
        public RepositoryUserSystemFinancial(ContextBase context) : base(context)
        {
        }
    }
}
