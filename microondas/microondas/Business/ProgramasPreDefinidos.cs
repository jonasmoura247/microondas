using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microondas.Business
{
    public class ProgramasPreDefinidos
    {
        private List<ProgramaAquecimento> programas;

        public ProgramasPreDefinidos()
        {
            programas = new List<ProgramaAquecimento>
            {
                //alt + 259 ♥ 
                new ProgramaAquecimento("Pipoca", "Pipoca", 180, 7, "♥", "Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um estouro e outro, interrompa o aquecimento."),
                //alt + 260 ♦ 
                new ProgramaAquecimento("Leite", "Leite", 300, 5, "♦", "Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode causar fervura imediata causando risco de queimaduras."),
                //alt + 261 ♣ 
                new ProgramaAquecimento("Carne", "Carne", 840, 4, "♣", "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme."),
                //alt + 262 ♠
                new ProgramaAquecimento("Frango", "Frango", 480, 7, "♠", "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme."),
                //alt + 254 ■
                new ProgramaAquecimento("Feijao", "Feijao", 480, 9, "■", "Deixe o recipiente destampado e em casos de plástico, cuidado ao retirar o recipiente pois o mesmo pode perder resistência em altas temperaturas."),
            };
        }

        public List<ProgramaAquecimento> ObterProgramas()
        {
            return programas;
        }

        public ProgramaAquecimento ObterProgramaPorNome(string nome)
        {
            return programas.Find(p => p.Nome == nome);
        }
    }
}
