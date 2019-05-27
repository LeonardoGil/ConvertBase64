using ConvertBase64.dtos;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace ConvertBase64.Teste
{
    public class Teste2
    {
        public Teste2()
        {
            string diretorio = string.Empty;

            Console.Write($"Informe um Diretorio: ");
            diretorio = Console.ReadLine();

            AbrirArquivo(diretorio);
            Console.ReadKey();
        }



        public string ObterArquivoDecodificado(ZipArchiveEntry arquivo)
        {
            string conteudo;
            byte[] conteudobase64;
            try
            {
                try
                {
                    using (StreamReader sr = new StreamReader(arquivo.Open()))
                    {
                        conteudobase64 = Convert.FromBase64String(sr.ReadLine());
                        conteudo = Encoding.UTF8.GetString(conteudobase64);
                    }
                }
                catch (IOException)
                {
                    throw;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return conteudo;
        }
        public void DefinirTipoArquivo(ZipArchiveEntry arquivo)
        {
            string conteudo = ObterArquivoDecodificado(arquivo);
            switch (arquivo.Name.Replace("Base64.txt", string.Empty))
            {
                case "cliente":
                    break;
                case "bairro": 
                    break;
                case "cidade":
                    break;
                case "produtoacumulado":
                    break;
                case "unificacao":
                    break;
                case "vendaacumulada":
                    break;
                case "visitador":
                    break;
                default:
                    break;
            }
        }
        public void CriarBairroDto(string conteudo)
        {
            BairroDto bairrodto = new BairroDto();

            
                   
        }

        public void TratarConteudoBairro(string conteudo)
        {
            string[] linhas = conteudo.Split('|');

            for (int j = 0; j < linhas.Count(); j++)
            {

            }
        }


        public void AbrirArquivo(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (ZipArchive arquivos = new ZipArchive(fs))
                    {
                        foreach (var arquivo in arquivos.Entries)
                        {
                            Console.WriteLine($"Arquivo {arquivo.FullName}");
                            if (arquivo.FullName.EndsWith(".txt"))
                                DefinirTipoArquivo(arquivo);
                        }
                    }
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

    }
}
