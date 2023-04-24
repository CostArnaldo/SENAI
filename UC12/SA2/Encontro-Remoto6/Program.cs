// dotnet run p/ rodar o projeto
using encontro_remoto6.Classes;


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
string? opcao;
string? finalizar;

Utils.Apresentacao();
Console.ResetColor();
Console.Clear();
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Blue;


do
{
    Console.WriteLine("\x1b[1m");
    string topico = @$"
                              ESCOLHA UMA DAS OPÇÕES ABAIXO: ";
    foreach (char letra in topico)
    {
        Console.Write(letra);
        Thread.Sleep(80);
    }
    Console.WriteLine("\x1b[0m");
    Thread.Sleep(1500);

    Console.WriteLine("\x1b[1m");

    string escolhas = $@"   

                        1- Pessoa Física
                        2- Pessoa Jurídica
                        
                        0- Sair do Sistema 
                        
                        Escolha a opção desejada e tecla 'Enter'.";
    foreach (char letra in escolhas)
    {
        Console.Write(letra);
        Thread.Sleep(15);
    }
    Console.WriteLine("\x1b[0m");
    opcao = Console.ReadLine();
} while (opcao != "1" && opcao != "2" && opcao != "0");

if (opcao == "1")
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\x1b[1m");
    Console.WriteLine($"\n {"PESSOA FÍSICA"} \n");
    Thread.Sleep(2000);
    Console.WriteLine("\x1b[0m");
    Console.WriteLine($"Teste Maior de idade: {(novaPF.ValidarDataN("11/11/2020") ? "Reprovado" : "Aprovado")}");
    Console.WriteLine("nome: " + novaPF.nome);
    Console.WriteLine("CPF: " + novaPF.cpf.ToString(@"000\.000\.000\-00"));
    Console.WriteLine($"Data de Nascimento: {novaPF.dataN}");
    Console.WriteLine($"Maior de idade: {(novaPF.ValidarDataN(novaPF.dataN) ? "sim" : "não")}");
    Console.WriteLine($"Idade: {Math.Floor(idade.TotalDays / 365.0)}");
    Console.WriteLine($"Endereço: {novoEndPF.logradouro}, {novoEndPF.numero} - {novoEndPF.complemento} - {endComercial}");
    Console.WriteLine($"Rendimento: {novaPF.rendimento:C}");
    Console.WriteLine(($"Imposto P. Física: {novaPF.CalcularImposto(novaPF.rendimento):C}"));
    finalizar = Console.ReadLine();
}
else if (opcao == "2")
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\x1b[1m");
    Console.WriteLine($"\n {"PESSOA JÚRIDICA"} \n");
    Thread.Sleep(2000);
    Console.WriteLine("\x1b[0m");
    Console.WriteLine($"Razão Social: {novaPJ.razaoSocial}");
    Console.WriteLine($"CNPJ: {novaPJ.cnpj.ToString(@"00\.000\.000\.\0000\-00")}");
    Console.WriteLine($"Válido: {(novaPJ.ValidarCnpj(novaPJ.cnpj.ToString("00000000000000")) ? "sim" : "não")}");
    Console.WriteLine($"Endereço: {novoEndPJ.logradouro}, {novoEndPJ.numero} - {novoEndPJ.complemento} - {endComercialPJ}");
    Console.WriteLine($"Rendimento: {novaPJ.rendimento:C}");
    Console.WriteLine(($"Imposto P. Jurídica: {novaPJ.CalcularImposto(novaPJ.rendimento):C}"));
    finalizar = Console.ReadLine();
}
else if (opcao == "0")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\x1b[1m");
    Console.WriteLine($"Saindo do Sistema");
    Thread.Sleep(1000);
    Console.WriteLine("\x1b[0m");
}

Utils.Carregamento();

Console.ResetColor();







