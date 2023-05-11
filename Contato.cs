using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSimples
{
    internal class Contato
    {
        /*
         * Variáveis internas da classe Contato.
         * a palavra-chave "private" indica que somente a classe
         * "Contato" tem acesso.
        */
        private string primeiroNome;
        private string sobrenome;
        private string telefone;

        // PROPRIEDADES (GET e SET)
        public string PrimeiroNome
        {
            get { return primeiroNome; }
            set { primeiroNome = value; }
        }

        public string Sobrenome
        { 
            get { return sobrenome; } 
            set { sobrenome = value; } 
        }

        public string Telefone
        {
            get { return telefone; }
            set {
                if (value.Length == 11)
                    Telefone = value;
                else
                    Telefone = "00-00000-0000";
            }
        }

        // Método construtor da classe.
        public Contato()
        {
            PrimeiroNome = "José";
            Sobrenome = "da Silva";
            Telefone = "11-91234-5678";
        }

        //Sobrecarga do método construtor da classe.
        public Contato (string primeiroNome, string sobrenome, string telefone)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        public override string ToString()
        {
            string saida = String.Empty;
            saida += String.Format("{0}, {1}", PrimeiroNome, Sobrenome);
            saida += String.Format("{0}-{1}-{2}",
                Telefone.Substring(0, 1),
                Telefone.Substring(2, 4),
                Telefone.Substring(7, 3));

            return saida;
        }
    }
}
