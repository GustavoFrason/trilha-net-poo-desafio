using System.Runtime;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Exemplo para um smartphone Nokia");
Smartphone nokia = new Nokia(numero: "111111", modelo: "modelo nokia 1", IMEI: "NUMERO IMEI", memoria:64);
nokia.InstalarAplicativo("Whats");