using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microondas.Business
{
    public class ProgramaCustomizado : ProgramaAquecimento
    {
        // Construtor para inicializar um programa customizado
        public ProgramaCustomizado(string nome, string alimento, int tempo, int potencia, string stringAquecimento, string instrucoes)
            : base(nome, alimento, tempo, potencia, stringAquecimento, instrucoes)
        {
        }

        // Método para validar o caractere de aquecimento
        public static bool ValidarCaractere(char caractere, List<ProgramaCustomizado> programasCustomizados)
        {
            // Verifica se o caractere é o padrão
            if (caractere == '.')
            {
                return false;
            }

            // Verifica se o caractere já existe em algum programa customizado
            foreach (var programa in programasCustomizados)
            {
                if (programa.StringAquecimento[0] == caractere) // StringAquecimento é um único caractere
                {
                    return false;
                }
            }

            return true;
        }
    }
}
