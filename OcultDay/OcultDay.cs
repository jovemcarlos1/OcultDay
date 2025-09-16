using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcultDay
{
    public class OcultDayMain
    {
        public OcultDayMain() {
            
        }
        public void Menu()
        {
            int valor;
            do
            {
                Console.WriteLine(
                    "Digite o id de uma das opções que deseja iniciar: \n" +
                    "[1] Adicionar partcipante\n" +
                    "[2] Remover participante\n" +
                    "[3] Listar participantes\n" +
                    "[4] Realizar sorteio\n" +
                    "[0] Sair"
                    );
                valor = int.Parse(Console.ReadLine()); 
                Escolha(valor);
            } while (valor != 0);
        }

        public void Escolha(int valor)
        {
            switch (valor)
            {
                case 1:
                    //AdicionarParticipante();
                    break;
                case 2:
                    //RemoverParticipante();
                    break;
                case 3:
                    //ListarParticipantes();
                    break;
                case 4:
                    //RealizarSorteio();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
