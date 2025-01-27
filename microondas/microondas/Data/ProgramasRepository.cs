using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace microondas.Data
{
    public class ProgramaAquecimento
    {
        public string Nome { get; set; }
        public string Alimento { get; set; }
        public int Tempo { get; set; }
        public int Potencia { get; set; }
        public char CaractereAquecimento { get; set; }
        public string Instrucoes { get; set; } // Opcional
    }

    public class ProgramasRepository
    {
        private readonly string _caminhoArquivoJson;

        public ProgramasRepository(string caminhoArquivoJson)
        {
            _caminhoArquivoJson = caminhoArquivoJson;
        }

        // Método estático para obter o caminho do arquivo JSON
        public static string ObterCaminhoArquivoJson()
        {
            string caminhoPastaProjeto = AppDomain.CurrentDomain.BaseDirectory;
            string caminhoPastaData = Path.Combine(caminhoPastaProjeto, "Data");

            // Verifica se a pasta "Data" existe; se não, cria a pasta
            if (!Directory.Exists(caminhoPastaData))
            {
                Directory.CreateDirectory(caminhoPastaData);
            }

            // Define o caminho completo do arquivo JSON
            return Path.Combine(caminhoPastaData, "programas.json");
        }

        // Salva a lista de programas em um arquivo JSON
        public void SalvarProgramas(List<ProgramaAquecimento> programas)
        {
            try
            {
                // Converte a lista de programas para JSON
                string json = JsonConvert.SerializeObject(programas, Formatting.Indented);

                // Salva o JSON no arquivo
                File.WriteAllText(_caminhoArquivoJson, json);
                Console.WriteLine("Programas salvos com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar programas: {ex.Message}");
            }
        }

        // Carrega a lista de programas de um arquivo JSON
        public List<ProgramaAquecimento> CarregarProgramas()
        {
            try
            {
                // Verifica se o arquivo existe
                if (File.Exists(_caminhoArquivoJson))
                {
                    // Lê o conteúdo do arquivo JSON
                    string json = File.ReadAllText(_caminhoArquivoJson);

                    // Converte o JSON de volta para uma lista de programas
                    List<ProgramaAquecimento> programas = JsonConvert.DeserializeObject<List<ProgramaAquecimento>>(json);
                    Console.WriteLine("Programas carregados com sucesso!");
                    return programas;
                }
                else
                {
                    Console.WriteLine("Arquivo JSON não encontrado. Retornando lista vazia.");
                    return new List<ProgramaAquecimento>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar programas: {ex.Message}");
                return new List<ProgramaAquecimento>();
            }
        }
    }
}