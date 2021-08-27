using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    public class Cliente
    {

        // construtor que recebe o nome
        public Cliente(string _nome, string _telefone, string _cpf)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.CPF = _cpf;
        }

        public Cliente()
        {
        }

        public string Nome;
        public string Telefone;
        public string CPF;

        public virtual void Gravar()
        {
            var clientes = Cliente.LerClientes();
            clientes.Add(this);

            if (File.Exists(@"C:\arquivos\clientes.txt")) ;
            {
                string conteudo = "nome;telefone;cpf;\n";
                foreach (Cliente c in clientes)
                {
                    conteudo += c.Nome +";" + c.Telefone + ";" + c.CPF + ";\n";
                }

                File.WriteAllText(@"C:\arquivos\clientes.txt", conteudo);
            }
            }


            public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();
            
            string caminhoBaseClientes = @"C:\arquivos\clientes.txt";
            if (File.Exists(caminhoBaseClientes))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseClientes))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var clienteArquivo = linha.Split(';');
                        var cliente = new Cliente(clienteArquivo[0], clienteArquivo[1],
                            clienteArquivo[2]);
                        clientes.Add(cliente);

                    }
                }
             }
            return clientes;
        }
                   
        }
    }
