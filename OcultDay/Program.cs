// See https://aka.ms/new-console-template for more information
using OcultDay;

Console.WriteLine("Bem vindo ao OcultDay!");
OsParticipantes participantes = new OsParticipantes();

OcultDayMain ocultDay = new OcultDayMain(
    participantes
    );
ocultDay.Menu();
Console.WriteLine("Teste");