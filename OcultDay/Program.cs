using System;
using System.Collections.Generic;       
using System.Linq;  
using System.Text;
using System.Threading.Tasks;
using OcultDay2;
class OcultDay
{
    static List<string> ocultDays = new List<string>();
    static Dictionary<string, string> pares = new Dictionary<string, string>();
    static bool sorteioRealizado = false;

    static void Main(string[] args)
    {
        OsParticipantes participantes = new OsParticipantes();
        while (true) 
        {
            Console.Clear();
            Console.WriteLine("====== Sistema de Amigo Oculto ======");
            Console.WriteLine("1. Adicionar partcipante");
            Console.WriteLine("2. Remover participante");
            Console.WriteLine("3. Listar participantes");
            Console.WriteLine("4. Realizar sorteio");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                   participantes.AdicionarParticipante();
                    break;
                case "2":
                   // RemoverParticipante();
                    break;
                case "3":
                   // ListarParticipantes();
                    break;
                case "4":
                   // RealizarSorteio();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
        DateTime today = DateTime.Now;
        Console.WriteLine($"Today is: {today.ToString("D")}");
    }
}