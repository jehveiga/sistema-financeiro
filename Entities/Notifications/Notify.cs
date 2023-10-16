using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Notifications
{
    public class Notify
    {
        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string Mensagem { get; set; }

        [NotMapped]
        public IList<Notify> notificacoes;

        public Notify()
        {
            notificacoes = new List<Notify>();
        }

        public bool ValidarPropriedadeString(string valor, string nomePropriedade)
        {
            if (String.IsNullOrWhiteSpace(valor) || String.IsNullOrWhiteSpace(nomePropriedade))
            {
                notificacoes.Add(new Notify
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
                notificacoes.Add(new Notify
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
