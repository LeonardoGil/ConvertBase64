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

            AbrirArquivoZIP(diretorio);
            Console.ReadKey();
        }

        public List<string> ObterArquivoDecodificado(ZipArchiveEntry arquivo)
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
            return conteudo.Split('\n').ToList();
        }
        public void DefinirTratarArquivoTxt(ZipArchiveEntry arquivo)
        {
            List<string> conteudo = ObterArquivoDecodificado(arquivo);

            foreach (var linha in conteudo)
            {
                string[] aux = linha.Split('|');
                switch (arquivo.Name.Replace("Base64.txt", string.Empty))
                {
                    case "cliente":
                        CriarClienteDto(aux);
                        break;
                    case "bairro":
                        CriarBairroDto(aux);
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

        }


        public void CriarBairroDto(string[] bairro)
        {
            BairroDto bairrodto = new BairroDto();

            bairrodto.Id = int.Parse(bairro[0]);
            bairrodto.Nome = bairro[1];

            Console.WriteLine(bairrodto.ToString());
        }

        public void CriarClienteDto(string[] cliente)
        {
            ClienteDto clientedto = new ClienteDto();

            clientedto.Id = int.Parse(cliente[0]);

        }

        public void CriarCidadeDto(string[] cidade)
        {
            ClienteDto clientedto = new ClienteDto();

            clientedto.Id = int.Parse(cliente[0]);

        }


        public void AbrirArquivoZIP(string path)
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
                                DefinirTratarArquivoTxt(arquivo);
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
