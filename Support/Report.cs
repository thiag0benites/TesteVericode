using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVericode.Support
{
    public class Report
    {
        public static void BuildHtmlReport()
        {
            try
            {
                // Obtém o diretório atual onde o executável está rodando
                string currentDirectory = Directory.GetCurrentDirectory();

                // Subir para o diretório raiz do projeto (1 nível acima)
                string projectRootDirectory = Directory.GetParent(currentDirectory).Parent.Parent.FullName;

                // Cria o caminho relativo para o arquivo build.bat na raiz do projeto
                string batFilePath = Path.Combine(projectRootDirectory, "build.bat");

                // Verifica se o arquivo existe antes de tentar executá-lo
                if (!File.Exists(batFilePath))
                {
                    Console.WriteLine("Arquivo build.bat não encontrado no diretório: " + currentDirectory);
                    return;
                }

                // Cria um novo processo para executar o arquivo batch
                Process process = new Process();
                process.StartInfo.FileName = batFilePath;
                process.StartInfo.RedirectStandardOutput = true;  // Opcional, para capturar a saída do batch
                process.StartInfo.UseShellExecute = false;  // Necessário para redirecionar a saída
                process.StartInfo.CreateNoWindow = true;  // Não exibe a janela do console

                // Inicia o processo
                process.Start();

                // Opcional: Exibe a saída do batch (caso você tenha redirecionado)
                string output = process.StandardOutput.ReadToEnd();
                Console.WriteLine(output);

                // Aguarda o processo terminar
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao executar o arquivo batch: " + ex.Message);
            }
        }
    }
}
