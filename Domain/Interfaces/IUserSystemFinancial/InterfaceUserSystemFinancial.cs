using Domain.Interfaces.Generics;
using Entities.Entities;

namespace Domain.Interfaces.IUsuarioSistemaFinanceiro
{
    public interface InterfaceUserSystemFinancial : InterfaceGeneric<UserSystemFinancial>
    {
        Task<IList<UserSystemFinancial>> ListarUsuarioSistema(int idSistema);
        Task RemoverUsuarios(List<UserSystemFinancial> usuarios);
        Task<UserSystemFinancial> ObterUsuarioPorEmail(string emailUsuario);
    }
}
