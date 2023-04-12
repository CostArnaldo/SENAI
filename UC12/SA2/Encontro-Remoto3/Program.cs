// dotnet run p/ rodar o projeto
using encontro_remoto3.Classes;

//metodo construtor
PessoaFisica novaPF= new PessoaFisica();
PessoaJuridica novaPJ= new PessoaJuridica();


novaPF.nome= "Arnaldo";
novaPF.cpf= 12345678989;
novaPF.dataN= new DateTime(1989, 01, 01);
novaPF.endereco= "Av. Construtor David Teixeira, 720";
novaPF.rendimento= 4000;
novaPJ.rendimento= 10000;




Console.WriteLine("nome: " + novaPF.nome);
Console.WriteLine("CPF: " + novaPF.cpf.ToString(@"000\.000\.000\-00"));
Console.WriteLine($"Data de Nascimento: {novaPF.dataN}");
Console.WriteLine($"Endereço: {novaPF.endereco}");  
Console.WriteLine($"Rendimento: {novaPF.rendimento:C}");
Console.WriteLine(($"Imposto P. Física: {novaPF.CalcularImposto(novaPF.rendimento):C}"));
Console.WriteLine(($"Imposto P. Jurídica: {novaPJ.CalcularImposto(novaPJ.rendimento):C}"));