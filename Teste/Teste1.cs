using System;

namespace ConvertBase64.Teste
{
    public class Teste1
    {
        public Teste1()
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
                    if (arquivo.EndsWith(".zip"))
                    {
                        Repository.LerArquivosInZip(arquivo);
                    }
                    else
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
