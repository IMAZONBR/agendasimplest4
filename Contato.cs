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
        private string email;

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
                    telefone = value;
                else
                    telefone = "00000000000";
            }
        }

        public string Email
        {
            get { return email; }   
            set { email = value; }
        }

        // Método construtor da classe.
        public Contato()
        {
            PrimeiroNome = "José";
            Sobrenome = "da Silva";
            Telefone = "11-91234-5678";
            Email = "exemplo@exemplo.com";
        }

        //Sobrecarga do método construtor da classe.
        public Contato (string primeiroNome, string sobrenome, string telefone, string email)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Email = email;
        }

        public override string ToString()
        {
            string saida = String.Empty;
            saida += String.Format("{0}, {1}", PrimeiroNome, Sobrenome);
            saida += String.Format("{0}-{1}-{2}",
                Telefone.Substring(0, 2),
                Telefone.Substring(2, 5),
                Telefone.Substring(7, 4)
                );
            saida += " "; // Apenas um espaço entre o telefone e e-mail.
            saida += String.Format("{0}", Email);

            return saida;
        }
    }
}
