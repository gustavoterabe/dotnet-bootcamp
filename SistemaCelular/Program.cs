// See https://aka.ms/new-console-template for more information

using SistemaCelular.Models;

Nokia meuPrimeiroCelular = new Nokia("999235635", "Tijolo", "1111111111", 64);
IPhone meuSegundoCelular = new IPhone("999235635", "13", "222222222", 128);

Console.WriteLine("\nCelular Nokia");
meuPrimeiroCelular.Ligar();
meuPrimeiroCelular.InstalarAplicativo("Google Chrome");
meuPrimeiroCelular.ReceberLigacao();


Console.WriteLine("\nCelular IPhone");
meuSegundoCelular.Ligar();
meuSegundoCelular.InstalarAplicativo("Google Chrome");
meuSegundoCelular.ReceberLigacao();