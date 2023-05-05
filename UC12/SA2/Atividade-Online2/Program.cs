using Atividade_Online2;

PF pf = new PF();
PJ pj = new PJ();

string database = "./Database/Arnaldo.txt";

Console.WriteLine("Nome: ");
pf.nome = "Arnaldo";

Console.WriteLine("Razão Social: ");
pj.razaoSocial = "Arnaldo";


using (StreamWriter sw = new StreamWriter(database))
{
    sw.WriteLine($"Nome: {pf.nome}");
    sw.WriteLine($"Razão Social: {pj.razaoSocial}");

}

Console.WriteLine("Dados cadastrados com sucesso!");
Console.ReadLine();
