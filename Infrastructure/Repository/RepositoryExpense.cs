using Domain.Interfaces.IDespesa;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;

namespace Infrastructure.Repository
{
    public class RepositoryExpense : RepositoryGenerics<Expense>, InterfaceExpense
    {
        public RepositoryExpense(ContextBase context) : base(context)
        {
        }

        public Task<IList<Expense>> ListarDespesasUsuario(string emailUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Expense>> ListarDespesasUsuarioNaoPagasMesesAnterior(string emailUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
