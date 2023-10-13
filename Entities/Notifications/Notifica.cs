using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Notifications
{
    public class Notifica
    {
        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string Mensagem { get; set; }

        [NotMapped]
        public IList<Notifica> notificacoes;

        public Notifica()
        {
            notificacoes = new List<Notifica>();
        }

        public bool ValidarPropriedadeString(string valor, string nomePropriedade)
        {
            if (String.IsNullOrWhiteSpace(valor) || String.IsNullOrWhiteSpace(nomePropriedade))
            {
                notificacoes.Add(new Notifica
                {
                    Mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropriedade,
                });

                return false;

            }

            return true;
        }

        public bool ValidarPropriedadeInt(int valor, string nomePropriedade)
        {
            if (valor < 1 || String.IsNullOrWhiteSpace(nomePropriedade))
            {
                notificacoes.Add(new Notifica
                {
                    Mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropriedade,
                });

                return false;

            }

            return true;
        }
    }
}
