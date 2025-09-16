using System;
using System.Collections.Generic;

namespace AmigoOcultoApp
{
    public class Gerenciador
    {
        public void RemovaParticipante(List<string> lista, string nome)
        {
            if (lista.Contains(nome))
            {
                lista.Remove(nome);
                Console.WriteLine($"Participante {nome} foi removido com sucesso!");
            }
            else
            {
                Console.WriteLine($"Participante {nome} não foi encontrado na lista.");
            }
        }
    }
}
