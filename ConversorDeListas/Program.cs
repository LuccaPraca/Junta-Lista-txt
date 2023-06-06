using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o diretorio das listar que voce deseja juntar:");
        string pasta = Console.ReadLine();
        Console.WriteLine("Digite o nome do arqiovo com todos os dados:   Exemplo(LISTA.TXT)");
        string arquivoDestino = Console.ReadLine();

        // Obtém a lista de arquivos TXT na pasta
        string[] arquivos = Directory.GetFiles(pasta, "*.txt");

        // Cria ou sobrescreve o arquivo de destino
        using (StreamWriter writer = new StreamWriter(arquivoDestino))
        {
            // Itera sobre cada arquivo e copia as linhas para o arquivo de destino
            foreach (string arquivo in arquivos)
            {
                // Lê todas as linhas do arquivo atual
                string[] linhas = File.ReadAllLines(arquivo);

                // Escreve as linhas no arquivo de destino
                foreach (string linha in linhas)
                {
                    writer.WriteLine(linha);
                }
            }
        }

        Console.WriteLine($"Linhas dos arquivos TXT copiadas para o arquivo {arquivoDestino}");
        Console.ReadLine();
    }
}