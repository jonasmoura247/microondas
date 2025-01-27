using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microondas.Business
{
    public class Aquecimento
    {
        public int Tempo { get; private set; }  // Tempo do aquecimento em segundos
        public int Potencia { get; private set; }  // Potência do micro-ondas de 1 a 10
        public bool EmExecucao { get;  set; }  // Indica se o aquecimento está em andamento
        public bool ProgramaPreDefinido { get; set; } // Nova propriedade
        private int tempoRestante;
        private string stringAquecimento;// Tempo restante durante o aquecimento

        public Aquecimento()
        {
            // Inicializa os valores padrão
            Tempo = 30;  // Tempo padrão de 30 segundos
            Potencia = 10;  // Potência padrão de 10
            ProgramaPreDefinido = false; // Inicialmente, não é um programa pré-definido
            EmExecucao = false;
            tempoRestante = Tempo;
            stringAquecimento = "."; // Padrão
        }

        public void IniciarProgramaPreDefinido(ProgramaAquecimento programa)
        {
            Tempo = programa.Tempo;
            Potencia = programa.Potencia;
            stringAquecimento = programa.StringAquecimento;
            tempoRestante = Tempo;
 
        }

        public string AtualizarStringAquecimento()
        {
            int quantidadeDePontos = tempoRestante * Potencia;
            StringBuilder pontos = new StringBuilder();
            for (int i = 0; i < quantidadeDePontos; i++)
            {
                pontos.Append(stringAquecimento); // Usa o caractere personalizado
                if ((i + 1) % Potencia == 0)
                {
                    pontos.Append(" ");
                }
            }

            if (!EmExecucao && tempoRestante == 0)
            {
                pontos.Append("Aquecimento concluído");
            }

            return pontos.ToString();
        }

        public void Resetar()
        {
            Tempo = 0;
            Potencia = 10;
            EmExecucao = false;
            tempoRestante = 0;
            ProgramaPreDefinido = false;
        }

        public bool Iniciar(int tempo = 30, int potencia = 10)
        {
            // Validações
            if (tempo < 1 || tempo > 120)
            {
                throw new ArgumentException("Tempo inválido! O tempo deve ser entre 1 e 120 segundos.");
            }

            if (potencia < 1 || potencia > 10)
            {
                throw new ArgumentException("Potência inválida! A potência deve ser entre 1 e 10.");
            }

            // Inicializa os parâmetros
            Tempo = tempo;
            Potencia = potencia;
            tempoRestante = Tempo;
            EmExecucao = true;

            return true;
        }

        public void DecrementarTempo()
        {
            if (tempoRestante > 0)
            {
                tempoRestante--;
            }
            else
            {
                EmExecucao = false;
                ProgramaPreDefinido = false; 
                EmExecucao = false;
                Console.Beep(800, 500);
            }
        }

        public string ObterTempoRestanteFormatado()
        {
            int minutos = tempoRestante / 60;
            int segundos = tempoRestante % 60;
            return $"{minutos:00}:{segundos:00}";
        }

        public void AcrescentarTempo(int segundos)
        {
            if (EmExecucao)
            {
                tempoRestante += segundos;
                Console.WriteLine($"Adicionando {segundos} segundos. Tempo restante: {tempoRestante} segundos.");
            }
            else
            {
                Console.WriteLine("Não há aquecimento em andamento para adicionar tempo.");
            }
        }

        public void PausarOuCancelar()
        {
            if (EmExecucao)  // Se o aquecimento está em execução
            {
                // Pausa o aquecimento
                EmExecucao = false;
            }
            else if (tempoRestante > 0)  // Se o aquecimento está pausado
            {
                // Cancela o aquecimento
                Resetar();
            }
        }


        public void IniciarRapido()
        {
            // Inicia com 30 segundos e potência 10
            Iniciar(30, 10);
            stringAquecimento = ".";
        }

    }
}
