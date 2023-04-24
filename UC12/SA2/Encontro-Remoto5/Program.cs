// dotnet run p/ rodar o projeto
using encontro_remoto5.Classes;


//metodo construtor
PessoaFisica novaPF = new PessoaFisica();
PessoaJuridica novaPJ = new PessoaJuridica();
Endereco novoEndPF = new Endereco();
Endereco novoEndPJ = new Endereco();



novaPF.nome = "Arnaldo";
novaPF.cpf = 12345678989;
novaPF.dataN = new DateTime(1989, 01, 01);
novaPF.endereco = novoEndPF;
novaPF.rendimento = 4000;
novoEndPF.logradouro = "Av. Construtor David Teixeira";
novoEndPF.numero = 800;
novoEndPF.complemento = "Cond. Mata da Praia";
novoEndPF.endComercial = false;

novaPJ.razaoSocial = "A TI.ME";
novaPJ.cnpj = 12345678912345;
//54568863000199
novaPJ.rendimento = 10000;
novaPJ.endereco = novoEndPJ;
novoEndPJ.logradouro = "Av. Rozendo Serapião de Souza Filho";
novoEndPJ.numero = 213;
novoEndPJ.complemento = "Ed. Boulevard";
novoEndPJ.endComercial = true;



var endComercial = novoEndPF.endComercial ? "Comercial" : "Residencial"; 
var endComercialPJ = novoEndPJ.endComercial ? "Comercial" : "Residencial";
var idade = DateTime.Today - novaPF.dataN;



Console.WriteLine($"Teste Maior de idade: {(novaPF.ValidarDataN("11/11/2020") ? "Reprovado" : "Aprovado")}");
Console.WriteLine("nome: " + novaPF.nome);
Console.WriteLine("CPF: " + novaPF.cpf.ToString(@"000\.000\.000\-00"));
Console.WriteLine($"Data de Nascimento: {novaPF.dataN}");
Console.WriteLine($"Maior de idade: {(novaPF.ValidarDataN(novaPF.dataN) ? "sim" : "não")}");
Console.WriteLine($"Idade: {Math.Floor(idade.TotalDays / 365.0)}");
Console.WriteLine($"Endereço: {novoEndPF.logradouro}, {novoEndPF.numero} - {novoEndPF.complemento} - {endComercial}");
Console.WriteLine($"Rendimento: {novaPF.rendimento:C}");
Console.WriteLine(($"Imposto P. Física: {novaPF.CalcularImposto(novaPF.rendimento):C}"));
Console.WriteLine($"Razão Social: {novaPJ.razaoSocial}");
Console.WriteLine($"CNPJ: {novaPJ.cnpj.ToString(@"00\.000\.000\.\0000\-00")}");
Console.WriteLine($"Válido: {(novaPJ.ValidarCnpj(novaPJ.cnpj.ToString("00000000000000")) ? "sim" : "não")}");
Console.WriteLine($"Endereço: {novoEndPJ.logradouro}, {novoEndPJ.numero} - {novoEndPJ.complemento} - {endComercialPJ}");
Console.WriteLine($"Rendimento: {novaPJ.rendimento:C}");
Console.WriteLine(($"Imposto P. Jurídica: {novaPJ.CalcularImposto(novaPJ.rendimento):C}"));

