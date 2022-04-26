using App2022;
using System.IO;

Carros carros = new Carros();

carros.Nome = Console.ReadLine();
carros.Cor = Console.ReadLine();
carros.LetrasDaPlaca = Console.ReadLine();
carros.NumerosDaPlaca = int.Parse(Console.ReadLine());
carros.QauntidadeDePortas = int.Parse(Console.ReadLine());

string[] lines = { "Carro : " + carros.NomeDoCarro(), "Cor do Carro : " + carros.CorDoCarros(), "Placa Do Carro : " + carros.PlacaDoCarro(), "Portas do Carro : " + carros.PortasDoCarro() };

string docPath = @"C:\Users\Àlberto Barbòsa\Desktop\PastaImprime";

using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
{
    foreach (string line in lines)
        outputFile.WriteLine(line);
}