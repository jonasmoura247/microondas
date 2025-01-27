using microondas.Business;
using microondas.Data;
using microondas.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramaAquecimento = microondas.Business.ProgramaAquecimento;

namespace microondas
{
    public partial class MainForms : Form
    {
        private Aquecimento aquecimento;
        private ProgramasPreDefinidos programasPreDefinidos;
        private ProgramasRepository programasRepository;
  

        public MainForms()
        {
            InitializeComponent();

            temporizador = new Timer();
            temporizador.Interval = 1000;
            temporizador.Tick += temporizador_Tick;
            aquecimento = new Aquecimento();
            programasPreDefinidos = new ProgramasPreDefinidos();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            potenciaTracker.Maximum = 10; // Define o valor máximo do tracker como 10
            potenciaTracker.Value = 10;   // Define o valor inicial do tracker como 10
            potenciaValor.Text = "10";    // Define o valor inicial do texto como 10

            // Obtém o caminho do arquivo JSON
            string caminhoArquivoJson = ProgramasRepository.ObterCaminhoArquivoJson();

            // Inicializa o repositório com o caminho do arquivo JSON
            programasRepository = new ProgramasRepository(caminhoArquivoJson);

            // Carregar programas do JSON e preencher o ComboBox
            var programas = programasRepository.CarregarProgramas();

            comboBoxProgramas.Items.Clear(); // Limpa itens existentes
            foreach (var programa in programas)
            {
                comboBoxProgramas.Items.Add(programa.Nome); // Adiciona o nome do programa ao ComboBox
            }
        }

        private void AtualizarTempo(string novoDigito)
        {
            // Remove os dois pontos para facilitar a manipulação
            string tempoAtual = tempoValor.Text.Replace(":", "");

            // Adiciona o novo dígito e mantém apenas os últimos 4 dígitos
            tempoAtual += novoDigito;
            if (tempoAtual.Length > 4)
            {
                tempoAtual = tempoAtual.Substring(tempoAtual.Length - 4);
            }

            // Formata o tempo no padrão MM:SS
            string minutos = tempoAtual.Length >= 2 ? tempoAtual.Substring(0, 2) : "00";
            string segundos = tempoAtual.Length >= 4 ? tempoAtual.Substring(2, 2) : "00";

            // Atualiza o campo tempoValor
            tempoValor.Text = $"{minutos}:{segundos}";

        }

        private void botaoUm_Click(object sender, EventArgs e)
        {
            if (!aquecimento.EmExecucao || !aquecimento.ProgramaPreDefinido)
            {
                AtualizarTempo("1");
            }
        }

        private void botaoDois_Click(object sender, EventArgs e)
        {
            if (!aquecimento.EmExecucao || !aquecimento.ProgramaPreDefinido)
            {
                AtualizarTempo("2");
            }
        }

        private void botaoTres_Click(object sender, EventArgs e)
        {
            if (!aquecimento.EmExecucao || !aquecimento.ProgramaPreDefinido)
            {
                AtualizarTempo("3");
            }
        }

        private void botaoQuatro_Click(object sender, EventArgs e)
        {
            if (!aquecimento.EmExecucao || !aquecimento.ProgramaPreDefinido)
            {
                AtualizarTempo("4");
            }
        }

        private void botaoCinco_Click(object sender, EventArgs e)
        {
            if (!aquecimento.EmExecucao || !aquecimento.ProgramaPreDefinido)
            {
                AtualizarTempo("5");
            }
        }

        private void botaoSeis_Click(object sender, EventArgs e)
        {
            if (!aquecimento.EmExecucao || !aquecimento.ProgramaPreDefinido)
            {
                AtualizarTempo("6");
            }
        }

        private void botaoSete_Click(object sender, EventArgs e)
        {
            if (!aquecimento.EmExecucao || !aquecimento.ProgramaPreDefinido)
            {
                AtualizarTempo("7");
            }
        }

        private void botaoOito_Click(object sender, EventArgs e)
        {
            if (!aquecimento.EmExecucao || !aquecimento.ProgramaPreDefinido)
            {
                AtualizarTempo("8");
            }
        }

        private void botaoNove_Click(object sender, EventArgs e)
        {
            if (!aquecimento.EmExecucao || !aquecimento.ProgramaPreDefinido)
            {
                AtualizarTempo("9");
            }
        }

        private void botaoZero_Click(object sender, EventArgs e)
        {
            if (!aquecimento.EmExecucao || !aquecimento.ProgramaPreDefinido)
            {
                AtualizarTempo("0");
            }
        }

        private void botaoPipoca_Click(object sender, EventArgs e)
        {
            if (!aquecimento.EmExecucao || !aquecimento.ProgramaPreDefinido)
            {
                var programa = programasPreDefinidos.ObterProgramaPorNome("Pipoca");
                if (programa != null)
                {
                    ConfigurarPrograma(programa);
                }
            }
        }

        private void botaoLeite_Click(object sender, EventArgs e)
        {
            if (!aquecimento.EmExecucao || !aquecimento.ProgramaPreDefinido)
            {
                var programa = programasPreDefinidos.ObterProgramaPorNome("Leite");
                if (programa != null)
                {
                    ConfigurarPrograma(programa);
                }
            }
        }

        private void botaoCarne_Click(object sender, EventArgs e)
        {
            if (!aquecimento.EmExecucao || !aquecimento.ProgramaPreDefinido)
            {
                var programa = programasPreDefinidos.ObterProgramaPorNome("Carne");
                if (programa != null)
                {
                    ConfigurarPrograma(programa);
                }
            }
        }

        private void botaoFrango_Click(object sender, EventArgs e)
        {
            if (!aquecimento.EmExecucao || !aquecimento.ProgramaPreDefinido)
            {
                var programa = programasPreDefinidos.ObterProgramaPorNome("Frango");
                if (programa != null)
                {
                    ConfigurarPrograma(programa);
                }
            }
        }

        private void botaoFeijao_Click(object sender, EventArgs e)
        {
            if (!aquecimento.EmExecucao || !aquecimento.ProgramaPreDefinido)
            {
                var programa = programasPreDefinidos.ObterProgramaPorNome("Feijao");
                if (programa != null)
                {
                    ConfigurarPrograma(programa);
                }
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            aquecimento.PausarOuCancelar();

            if (!aquecimento.EmExecucao)
            {
                if (aquecimento.Tempo > 0)  // Se o aquecimento foi pausado
                {
                    labelAquecimento.Text = "Pausado";  // Atualiza a UI para "Pausado"
                                                        // Campos permanecem desabilitados se for um programa pré-definido
                }
                else  // Se o aquecimento foi cancelado ou ainda não foi iniciado
                {
                    // Limpa as informações de tempo e potência
                    tempoValor.Text = "00:00";  // Reseta o tempo para 00:00
                    potenciaTracker.Value = 10;  // Reseta a potência para o valor inicial (10)
                    potenciaValor.Text = "10";  // Atualiza a UI com o valor de potência
                    labelAquecimento.Text = "";  // Limpa a informação de status

                    // Reabilita os controles de tempo e potência
                    tempoValor.Enabled = true;
                    potenciaTracker.Enabled = true;

                    // Para o temporizador
                    temporizador.Stop();

                    // Reseta o estado do aquecimento
                    aquecimento.Resetar();
                }
            }
            else  // Se o aquecimento estava pausado e o botão foi pressionado novamente, continua
            {
                labelAquecimento.Text = "Aquecendo...";  // Indica que está em andamento
                temporizador.Start();  // Reinicia o temporizador
            }
        }


        private void botaoIniciar_Click(object sender, EventArgs e)
        {
            // Se for um programa pré-definido, impede alterações nos controles
            if (aquecimento.ProgramaPreDefinido)
            {
                tempoValor.Enabled = false;
                potenciaTracker.Enabled = false;
            }

            if (aquecimento.ProgramaPreDefinido)
            {
                // Se for um programa pré-definido, inicia o aquecimento sem adicionar tempo
                if (!aquecimento.EmExecucao)
                {
                    aquecimento.EmExecucao = true;
                    temporizador.Start();
                    labelAquecimento.Text = "Aquecendo...";
                }
            }
            else
            {
                // Se não for um programa pré-definido, segue a lógica normal
                if (aquecimento.EmExecucao)
                {
                    // Adiciona 30 segundos se o aquecimento já estiver em execução
                    aquecimento.AcrescentarTempo(30);
                }
                else
                {
                    // Inicia o aquecimento com o tempo e potência configurados
                    if (tempoValor.Text != "00:00")
                    {
                        string[] partes = tempoValor.Text.Split(':');
                        int minutos = int.Parse(partes[0]);
                        int segundos = int.Parse(partes[1]);
                        int tempoTotal = (minutos * 60) + segundos;

                        try
                        {
                            bool iniciado = aquecimento.Iniciar(tempoTotal, potenciaTracker.Value);
                            if (iniciado)
                            {
                                temporizador.Start();
                                labelAquecimento.Text = "Aquecendo...";
                            }
                        }
                        catch (ArgumentException ex)
                        {
                            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Início rápido
                        aquecimento.IniciarRapido();
                        temporizador.Start();
                        labelAquecimento.Text = "Aquecendo...";
                    }
                }
            }
        }

        private void potenciaTracker_Scroll(object sender, EventArgs e)
        {
            potenciaValor.Text = potenciaTracker.Value.ToString();
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            // Decrementa o tempo
            aquecimento.DecrementarTempo();

            string stringAquecimento = aquecimento.AtualizarStringAquecimento();
            labelAquecimento.Text = stringAquecimento;
           

            // Atualiza o campo tempoValor
            tempoValor.Text = aquecimento.ObterTempoRestanteFormatado();

            // Se o aquecimento acabou, atualiza a UI
            if (!aquecimento.EmExecucao)
            {
                potenciaTracker.Value = 10;
                potenciaValor.Text = "10";
                temporizador.Stop();

                // Se for um programa pré-definido, mantém os controles desabilitados
                if (aquecimento.ProgramaPreDefinido)
                {
                    tempoValor.Enabled = false;
                    potenciaTracker.Enabled = false;
                }
                else
                {
                    // Reabilita os controles de tempo e potência
                    tempoValor.Enabled = true;
                    potenciaTracker.Enabled = true;
                }
            }
        }

        private void ConfigurarPrograma(ProgramaAquecimento programa)
        {
            // Configura o tempo e a potência
            tempoValor.Text = $"{programa.Tempo / 60:00}:{programa.Tempo % 60:00}";
            potenciaTracker.Value = programa.Potencia;
            potenciaValor.Text = programa.Potencia.ToString();

            // Desabilita os controles de tempo e potência
            tempoValor.Enabled = false;
            potenciaTracker.Enabled = false;

            // Exibe as instruções complementares
            labelAquecimento.Text = $"Programa: {programa.Nome} - {programa.InstrucoesComplementares}";

            // Configura o aquecimento com o programa selecionado
            aquecimento.IniciarProgramaPreDefinido(programa);

            // Bloqueia o incremento de tempo para programas pré-definidos
            aquecimento.ProgramaPreDefinido = true;
        }

        private void botaoCadastrarPrograma_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário de cadastro
            CadastroProgramaForm cadastroForm = new CadastroProgramaForm();

            // Inscreve-se no evento
            cadastroForm.ProgramaCadastrado += CadastroForm_ProgramaCadastrado;

            // Exibe o formulário de cadastro como uma janela modal
            cadastroForm.ShowDialog();
        }

        // Método que será chamado quando um programa for cadastrado
        private void CadastroForm_ProgramaCadastrado()
        {
            // Recarrega os programas e atualiza o ComboBox
            CarregarProgramasNoComboBox();
        }

        // Método para carregar programas no ComboBox
        private void CarregarProgramasNoComboBox()
        {
            var programas = programasRepository.CarregarProgramas();
            comboBoxProgramas.Items.Clear(); // Limpa itens existentes
            foreach (var programa in programas)
            {
                comboBoxProgramas.Items.Add(programa.Nome); // Adiciona o nome do programa ao ComboBox
            }
        }

        private void comboBoxProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProgramas.SelectedItem != null)
            {
                string nomeProgramaSelecionado = comboBoxProgramas.SelectedItem.ToString();

                // Carregar programas do JSON
                var programas = programasRepository.CarregarProgramas();
                var programaSelecionado = programas.FirstOrDefault(p => p.Nome == nomeProgramaSelecionado);

                if (programaSelecionado != null)
                {
                    // Exibir as informações do programa selecionado
                    tempoValor.Text = $"{programaSelecionado.Tempo / 60:00}:{programaSelecionado.Tempo % 60:00}";
                    potenciaTracker.Value = programaSelecionado.Potencia;
                    potenciaValor.Text = programaSelecionado.Potencia.ToString();
                    
                    labelAquecimento.Text = $"Programa: {programaSelecionado.Nome} - {programaSelecionado.Instrucoes}";

                   
                    Console.WriteLine(programaSelecionado.CaractereAquecimento);

                    // Desabilitar os campos de entrada
                    tempoValor.Enabled = false;
                    potenciaTracker.Enabled = false;
                }
            }
        }
    }
}