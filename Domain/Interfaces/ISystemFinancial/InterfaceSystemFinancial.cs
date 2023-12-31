﻿using Domain.Interfaces.Generics;
using Entities.Entities;

namespace Domain.Interfaces.ISistemaFinanceiro
{
    public interface InterfaceSystemFinancial : InterfaceGeneric<SystemFinancial>
    {
        Task<IList<SystemFinancial>> ListarSistemasUsuario(string emailUsuario);
    }
}
