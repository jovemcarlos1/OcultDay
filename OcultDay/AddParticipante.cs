using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcultDay
{
    public class Participante
    {
        public string Nome { get; set; }
    }
    public class OsParticipantes
    {
        public List<Participante> Participantes = new List<Participante>();
        public void AdicionarParticipante()
        {
            Console.Write("Digite o nome do participante: ");
            string nomeDigitado = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nomeDigitado))
            {
                Console.WriteLine("Nome inválido.Digite um nome.");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                return;
            }
            {

                Participante novoParticipante = new Participante { Nome = nomeDigitado };
                Participantes.Add(novoParticipante);

                Console.WriteLine($"Participante {nomeDigitado} adicionado com sucesso!");
            }
        }
    }
}
