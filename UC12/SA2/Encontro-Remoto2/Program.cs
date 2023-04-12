
// dotnet run p/ rodar o projeto
using encontro_remoto2.Classes;

//metodo construtor
PessoaFisica novaPF= new PessoaFisica();

novaPF.nome= "Arnaldo";
novaPF.cpf= 123456789;
novaPF.dataN= new DateTime(1989, 01, 01);
novaPF.endereco= "Av. Construtor David Teixeira, 720";
novaPF.rendimento= 12000.00f;

Console.WriteLine("nome: " + novaPF.nome);
Console.WriteLine("CPF: " + novaPF.cpf);
Console.WriteLine($"Data de Nascimento: {novaPF.dataN}");
Console.WriteLine($"Endereço: {novaPF.endereco}");  
Console.WriteLine($"Rendimento: {novaPF.rendimento}");

