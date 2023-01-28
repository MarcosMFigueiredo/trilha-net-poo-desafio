using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone8 = new Iphone("(83) 9 9952-7956", "Iphone 8", "8795622", 64);
iphone8.Ligar();
iphone8.ReceberLigacao();
iphone8.IntalarAplicativo("Itunes");

Console.WriteLine("\n");

Nokia nokia = new Nokia("(87) 9 8394-5687", "Nokia 8", "8789642", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.IntalarAplicativo("Nubank");