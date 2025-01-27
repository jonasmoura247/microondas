using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using microondas.Data;

namespace microondas.Business
{
    public class ProgramaAquecimento
    {
        public string Nome { get; private set; }
        public string Alimento { get; private set; }
        public int Tempo { get; private set; } // Tempo em segundos
        public int Potencia { get; private set; } // Potência de 1 a 10
        public string StringAquecimento { get; set; } // Caractere único para representar o aquecimento
        public string InstrucoesComplementares { get; private set; }
        public object Instrucoes { get; set; }
        public string CaractereAquecimento { get; internal set; }

        public ProgramaAquecimento(string nome, string alimento, int tempo, int potencia, string stringAquecimento, string instrucoes)
        {
            Nome = nome;
            Alimento = alimento;
            Tempo = tempo;
            Potencia = potencia;
            StringAquecimento = stringAquecimento;
            InstrucoesComplementares = instrucoes;
        }
    }
}
