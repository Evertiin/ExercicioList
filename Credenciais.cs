using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoOO
{
    internal class Credenciais
    {
        public string Email { get; set; }
        public string Senha { get; set; }


        public Credenciais(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }
        
        public override string ToString()
        {
            return Email;
        }

    }
}
