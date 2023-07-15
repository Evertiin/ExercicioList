using System;
using System.Collections.Generic;
using System.Globalization;

namespace CursoOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Credenciais> list = new List<Credenciais>();
            bool adicionarMaisUsuarios = true;
            while (adicionarMaisUsuarios)
            {

                Console.WriteLine("Bem vindo ao cadastrador de credenciais");
                Console.WriteLine("Digite abaixo suas credencias para cadastrar:");

                Console.WriteLine("Entre com seu Email:");


                string email = Console.ReadLine();
               



                while (string.IsNullOrEmpty(email))
                {
                    Console.WriteLine("Entre com seu Email válido:");
                    email = Console.ReadLine();
                    

                }

                Console.WriteLine("Entre com a senha:");

                string senha = Console.ReadLine();
                

                while (string.IsNullOrEmpty(senha))
                {
                    Console.WriteLine("Entre com uma senha válida");
                    senha = Console.ReadLine();
                    
                }


                bool usuarioExiste = list.Exists(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

                if (usuarioExiste)
                {
                    Console.WriteLine("Este e-mail já está cadastrado. Não é permitido cadastrá-lo novamente.");
                }
                else
                {
                    list.Add(new Credenciais(email, senha));
                    Console.WriteLine("Credenciais cadastradas com sucesso!");
                }


                Console.WriteLine("Deseja adicionar mais usuários? (s/n)");
                string resposta = Console.ReadLine();
                

                if (resposta.ToLower() != "s")
                {
                    adicionarMaisUsuarios = false;
                    Console.Clear();

                }
                


                
                

            }
            foreach (Credenciais obj in list)
            {
                Console.WriteLine("Emails já cadastrados:");
                Console.WriteLine(obj);
            }









        }
    }
}