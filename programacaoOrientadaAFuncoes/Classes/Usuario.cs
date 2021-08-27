using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Usuario : Cliente
    {
        public Usuario(string _nome, string _telefone, string _cpf) : base(_nome, _telefone, _cpf)
        {
        }


        // override no metodo ler

        public static List<Usuario> LerUsuario()
        {
            var usuarios = new List<Usuario>();

            string caminhoBaseUsuario = @"C:\arquivos\usuarios.txt";
            if (File.Exists(caminhoBaseUsuario))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseUsuario))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var UsuarioArquivo = linha.Split(';');
                        var usuario = new Usuario(UsuarioArquivo[0], UsuarioArquivo[1],
                            UsuarioArquivo[2]);
                        usuarios.Add(usuario);

                    }
                }
            }
            return usuarios;
        }
        // override no metodo gravar
        new public void Gravar()
        {
            var usuarios = Usuario.LerUsuario();
            usuarios.Add(this);

            if (File.Exists(@"C:\arquivos\usuarios.txt"));
            {
                string conteudo = "nome;telefone;cpf;\n";
                foreach (Usuario c in usuarios)
                {
                    conteudo += c.Nome + ";" + c.Telefone + ";" + c.CPF + ";\n";
                }

                File.WriteAllText(@"C:\arquivos\usuarios.txt", conteudo);
            }
        }

    }
}
