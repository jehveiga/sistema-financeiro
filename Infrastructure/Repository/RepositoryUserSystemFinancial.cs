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

        public Task<IList<UserSystemFinancial>> ListarUsuarioSistema(int idSistema)
        {
            throw new NotImplementedException();
        }

        public Task<UserSystemFinancial> ObterUsuarioPorEmail(string emailUsuario)
        {
            throw new NotImplementedException();
        }

        public Task RemoverUsuarios(List<UserSystemFinancial> usuarios)
        {
            throw new NotImplementedException();
        }
    }
}
