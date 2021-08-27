using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class lerArquivo
    {
        public static void LerArquivo(int numeroArquivo)
        {
            int indice = numeroArquivo;
            string arquivoComcaminho = @"C:\arquivos\arq" + numeroArquivo + ".txt";
            if (File.Exists(arquivoComcaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComcaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);


                    }
                }
                indice++;
                if (File.Exists(@"C:\arquivos\arq" + indice + ".txt"))
                {
                    LerArquivo(indice);
                }
            }
        }
    }
}
