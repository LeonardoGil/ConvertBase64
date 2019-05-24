using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConvertBase64
{
    public static class Repository
    {
        public static bool ExisteDiretorio(string path)
        {
            if (string.IsNullOrEmpty(path))
                return false;

            return Directory.Exists(path); 
        }

        public static IEnumerable<string> GetArquivosDiretorio(string path)
        {
            IEnumerable<string> arquivos = Directory.EnumerateFiles(path);
            Console.WriteLine(arquivos.Count() == 0 ? $"Nenhum arquivo encontrado" : $"{arquivos.Count()} arquivo(s) encontrado(s)");
            return arquivos;
        }

        public static byte[] GetBytesArquivo(string nomearquivo)
        {
            byte[] conteudo = File.ReadAllBytes(nomearquivo);
            return conteudo;
        }

        public static void ConverterArquivoParBase64(string nomearquivo)
        {
            var conteudo = GetBytesArquivo(nomearquivo);

            if (conteudo == null)
            {
                Console.WriteLine($"Arquivo Vazio");
                return;
            }

            try
            {
                string conteudoConvertido = Convert.ToBase64String(conteudo);
                var arquivo = string.Concat(nomearquivo.Replace(".txt", string.Empty), "Base64.txt");

                if (File.Exists(arquivo))
                {
                    Console.WriteLine($"Arquivo ja existe");
                    return;
                }    
                else
                    File.AppendAllText(arquivo, conteudoConvertido);                

                Console.WriteLine($"Arquivo {arquivo} Criado com sucesso.");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
