using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculo;


namespace Calculo
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRO_CLIENTE = 4;
        public const int LISTAR_CLIENTES = 5;
        public const int CADASTRAR_USUARIO = 6;
        public const int LISTAR_USUARIOS = 7;
        public static void menu()
        {

            while (true)
            {
                string mensagem = "Olá user, bem vindo ao programa utilizando programação funcional." +
                    "\nDigite uma das opções abaixo:" +
                    "\n0 - Sair do programa" +
                    "\n1 - Ler arquivos" +
                    "\n2 - Para executar a tabuada" +
                    "\n3 - Cálcular média de alunos" +
                    "\n4 - Cadastrar clientes" +
                    "\n5 - Listar clientes" +
                    "\n6 - Cadastrar usuarios" +
                    "\n7 - Listar usuarios";

                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine(mensagem);
                int opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (opcao == LER_ARQUIVOS)
                {
                    Console.WriteLine("Lendo arquivos...");
                    lerArquivo.LerArquivo(1);
                }
                else if (opcao == TABUADA)
                {
                    Console.WriteLine("- Tabuada -");
                    Console.WriteLine("Qual valor você deseja calcular: ");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    Tabuada.CalculoTabuada(valor);
                    Console.WriteLine("==========================");
                }
                else if (opcao == CALCULO_MEDIA)
                {
                    Media.Aluno();
                }
                else if (opcao == CADASTRO_CLIENTE)
                {
                    Console.WriteLine("Cadastro de clientes:");
                    Console.Write("Nome do cliente: ");
                    var nome = Console.ReadLine();
                    Console.Write("Telefone: ");
                    var telefone = Console.ReadLine();
                    Console.Write("CPF: ");
                    var cpf = Console.ReadLine();

                    // chamando funcao cliente
                    Cliente a = new Cliente(nome, telefone, cpf);
                    a.Gravar();
                    Console.WriteLine("==========================");

                }
                else if (opcao == LISTAR_CLIENTES)
                {
                    foreach (Cliente i in Cliente.LerClientes())
                    {
                        Console.WriteLine(i.Nome);
                        Console.WriteLine(i.Telefone);
                        Console.WriteLine(i.CPF);
                        Console.WriteLine("==========================");

                    }
                }
                else if (opcao == CADASTRAR_USUARIO)
                {
                    Console.WriteLine("Cadastro de usuarios:");
                    Console.Write("Nome do usuario: ");
                    var nome = Console.ReadLine();
                    Console.Write("Telefone: ");
                    var telefone = Console.ReadLine();
                    Console.Write("CPF: ");
                    var cpf = Console.ReadLine();

                    // cadastrando e chamando funcao gravar usuario
                    Usuario a = new Usuario(nome, telefone, cpf);
                    a.Gravar();

                }
                else if (opcao == LISTAR_USUARIOS)
                {
                    foreach (Usuario u in Usuario.LerUsuario())
                    {
                        Console.WriteLine(u.Nome);
                        Console.WriteLine(u.Telefone);
                        Console.WriteLine(u.CPF);
                        Console.WriteLine("==========================");
                    }
                }


            }
        }
    }
}
