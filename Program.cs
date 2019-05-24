using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertBase64
{
    class Program
    {
        static void Main(string[] args)
        {
            string diretorio = string.Empty;

            Console.Write($"Informe um Diretorio: ");
            diretorio = Console.ReadLine();

            if (Repository.ExisteDiretorio(diretorio))
            {
                Console.WriteLine($"Diretorio {diretorio} encontrado.");
                foreach (var arquivo in Repository.GetArquivosDiretorio(diretorio))
                {
                    Console.WriteLine($"Arquivo: {arquivo}");
                    Repository.ConverterArquivoParBase64(arquivo);

                    Console.WriteLine($"##############################################################################################");
                }
            }
            else
                Console.WriteLine($"Diretorio {diretorio} não existe.");

            Console.WriteLine($"Finish");
            Console.ReadKey();
        }
    }
}
