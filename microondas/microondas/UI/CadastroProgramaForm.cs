using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using microondas.Data;

namespace microondas.UI
{
    public partial class CadastroProgramaForm : Form
    {
        // Lista para armazenar os caracteres de aquecimento já utilizados
        private List<char> caracteresUtilizados = new List<char> { '.' };
        private ProgramasRepository _repository;
        private string _caminhoArquivoJson;

        // Evento para notificar que um programa foi cadastrado
        public event Action ProgramaCadastrado;

        public CadastroProgramaForm()
        {
            InitializeComponent();

            // Define o caminho do arquivo JSON na pasta do projeto
            string caminhoPastaProjeto = AppDomain.CurrentDomain.BaseDirectory;
            string caminhoPastaData = Path.Combine(caminhoPastaProjeto, "Data");

            // Verifica se a pasta "Data" existe; se não, cria a pasta
            if (!Directory.Exists(caminhoPastaData))
            {
                Directory.CreateDirectory(caminhoPastaData);
            }

            // Define o caminho completo do arquivo JSON
            _caminhoArquivoJson = Path.Combine(caminhoPastaData, "programas.json");

            // Inicializa o repositório com o caminho do arquivo JSON
            _repository = new ProgramasRepository(_caminhoArquivoJson);

            // Exibe o caminho do arquivo (opcional)
            MessageBox.Show($"Arquivo JSON será salvo em: {_caminhoArquivoJson}");
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            // Validação dos campos obrigatórios
            if (string.IsNullOrEmpty(txtNome.Text) ||
                string.IsNullOrEmpty(txtAlimento.Text) ||
                numTempo.Value == 0 ||
                numPotencia.Value == 0 ||
                string.IsNullOrEmpty(txtCaractere.Text))
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação do caractere de aquecimento
            if (txtCaractere.Text.Length != 1)
            {
                MessageBox.Show("O campo de caractere de aquecimento deve conter exatamente um caractere!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            char caractereAquecimento = txtCaractere.Text[0];

            // Carrega os programas existentes do arquivo JSON
            List<ProgramaAquecimento> programas = _repository.CarregarProgramas();

            // Verifica se o caractere já está em uso em algum programa
            foreach (var programa in programas)
            {
                if (programa.CaractereAquecimento == caractereAquecimento)
                {
                    MessageBox.Show("O caractere de aquecimento não pode ser repetido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Adiciona o caractere à lista de caracteres utilizados
            caracteresUtilizados.Add(caractereAquecimento);

            // Cria um objeto ProgramaAquecimento com os dados do formulário
            ProgramaAquecimento novoPrograma = new ProgramaAquecimento
            {
                Nome = txtNome.Text,
                Alimento = txtAlimento.Text,
                Tempo = (int)numTempo.Value,
                Potencia = (int)numPotencia.Value,
                CaractereAquecimento = caractereAquecimento,
                Instrucoes = txtInstrucoes.Text // Opcional
            };

            // Adiciona o novo programa à lista
            programas.Add(novoPrograma);

            // Salva a lista atualizada no arquivo JSON
            _repository.SalvarProgramas(programas);

            // Dispara o evento para notificar que um programa foi cadastrado
            ProgramaCadastrado?.Invoke();

            MessageBox.Show("Programa salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Fecha o formulário após salvar
            this.Close();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            // Fecha o formulário de cadastro
            this.Close();
        }
    }
}