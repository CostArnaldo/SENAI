// dotnet run p/ rodar o projeto
using encontro_remoto4.Classes;


//metodo construtor
PessoaFisica novaPF = new PessoaFisica();
PessoaJuridica novaPJ = new PessoaJuridica();
Endereco novoEndPf = new Endereco();

novaPF.nome = "Arnaldo";
novaPF.cpf = 12345678989;
novaPF.dataN = new DateTime(1989, 01, 01);
novaPF.endereco = novoEndPf;
novaPF.rendimento = 4000;
novaPJ.rendimento = 10000;

novoEndPf.logradouro = "Av. Construtor David Teixeira";
novoEndPf.numero = 800;
novoEndPf.complemento = "Cond. Mata da Praia";
novoEndPf.endComercial = false;


var endComercial = novoEndPf.endComercial ? "Comercial" : "Residencial";
var idade = DateTime.Today - novaPF.dataN;


Console.WriteLine("nome: " + novaPF.nome);
Console.WriteLine("CPF: " + novaPF.cpf.ToString(@"000\.000\.000\-00"));
Console.WriteLine($"Maior de idade: {(novaPF.ValidarDataN(novaPF.dataN) ? "sim" : "não")}");
Console.WriteLine($"Maior de idade Teste: {novaPF.ValidarDataN("11/11/2020")}");
Console.WriteLine($"Data de Nascimento: {novaPF.dataN}");
Console.WriteLine($"Idade: {Math.Floor(idade.TotalDays / 365.0)}");
Console.WriteLine($"Endereço: {novoEndPf.logradouro}, {novoEndPf.numero} - {novoEndPf.complemento} - {endComercial}");
Console.WriteLine($"Rendimento: {novaPF.rendimento:C}");
Console.WriteLine(($"Imposto P. Física: {novaPF.CalcularImposto(novaPF.rendimento):C}"));
Console.WriteLine(($"Imposto P. Jurídica: {novaPJ.CalcularImposto(novaPJ.rendimento):C}"));

