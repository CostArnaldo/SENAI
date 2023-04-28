// dotnet run p/ rodar o projeto
using encontro_remoto7.Classes;

List<PessoaFisica> listaPF = new List<PessoaFisica>();
List<PessoaJuridica> listaPJ = new List<PessoaJuridica>();
List<Endereco> listaEnd = new List<Endereco>();

string? opcao;
string? finalizar;
string? reinicializar;



Utils.Apresentacao();
Console.ResetColor();
Console.Clear();
reinicializar:
reinicializar = Console.ReadLine();
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Blue;


Console.Clear();
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
        3- Cadastrar Pessoa Física 
        4- Cadastrar Pessoa Jurídica
            
        0- Sair do Sistema 
                        
Escolha a opção desejada e tecla 'Enter'.";
    foreach (char letra in escolhas)
    {
        Console.Write(letra);
        Thread.Sleep(15);
    }
    Console.WriteLine("\x1b[0m");
    opcao = Console.ReadLine();
    Console.Clear();
} while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "0");
Console.Clear();
if (opcao == "1")
{

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\x1b[1m");
    Console.WriteLine($"\n {"PESSOA FÍSICA"} \n");
    Thread.Sleep(2000);
    Console.WriteLine("\x1b[0m");

    foreach (PessoaFisica individuo in listaPF)
    {
        var idadeD = (DateTime.Today - individuo.dataN).Days;
        int idade = (idadeD / 365);

        Console.WriteLine($"Nome: {individuo.nome}");
        Console.WriteLine($"CPF:  {individuo.cpf.ToString(@"000\.000\.000\-00")}");
        Console.WriteLine($"Válido: {(individuo.ValidarCPF(individuo.cpf) ? "sim" : "não")}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Data de Nascimento Ex. DD/MM/YYYY: {individuo.dataN}");
        Console.WriteLine($"Maior de idade: {(individuo.ValidarDataN(individuo.dataN) ? "sim" : "não")}");
        Console.WriteLine($"Rendimento: {individuo.rendimento:C}");
        Console.WriteLine(($"Imposto P. Física: {individuo.CalcularImposto(individuo.rendimento):C}"));
        Thread.Sleep(500);
    }
    foreach (Endereco endereco in listaEnd)
    {
        Console.WriteLine($"Endereço: {endereco.logradouro}, {endereco.numero} - {endereco.complemento}");
    }
    finalizar = Console.ReadLine();
}
else if (opcao == "2")
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\x1b[1m");
    Console.WriteLine($"\n {"PESSOA JÚRIDICA"} \n");
    Thread.Sleep(2000);
    Console.WriteLine("\x1b[0m");

    foreach (PessoaJuridica instituicao in listaPJ)
    {
        Console.WriteLine($"Razão Social: {instituicao.razaoSocial}");
        Console.WriteLine($"CNPJ: {instituicao.cnpj.ToString(@"00\.000\.000\.\0000\-00")}");
        Console.WriteLine($"Válido: {(instituicao.ValidarCnpj(instituicao.cnpj.ToString("00000000000000")) ? "sim" : "não")}");
        Console.WriteLine($"Rendimento: {instituicao.rendimento:C}");
        Console.WriteLine(($"Imposto P. Jurídica: {instituicao.CalcularImposto(instituicao.rendimento):C}"));
    }
    foreach (Endereco endereco in listaEnd)
    {
        

        Console.WriteLine($"Endereço: {endereco.logradouro}, {endereco.numero} - {endereco.complemento} - Comercial?");
        if (endereco.endComercial == true) {
            Console.WriteLine("sim");
        } else {
            Console.WriteLine("não");
        }
    }
    finalizar = Console.ReadLine();
}
else if (opcao == "3")
{
    PessoaFisica novaPF = new PessoaFisica();
    Endereco novoEndPF = new Endereco();

    Console.WriteLine("Nome:");
    novaPF.nome = Console.ReadLine();

    long cpf;
Console.WriteLine("CPF:");
do
{
    try
    {
        cpf = long.Parse(Console.ReadLine() ?? "");
        var cpfString = cpf.ToString("D11");
        if (cpfString.Length != 11)
        {
            throw new FormatException(); 
        }
        break; 
    }
    catch (FormatException)
    {
        Console.WriteLine("CPF inválido. Digite novamente:");
    }
} while (true);
novaPF.cpf = cpf;




    Console.WriteLine("Data de Nascimento: DD/MM/AAAA");
    DateTime dataNascimento;
    do
    {
        try
        {
            dataNascimento = DateTime.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Data de nascimento inválida. Digite novamente:");
        }
    } while (true);
    novaPF.dataN = dataNascimento;

    Console.WriteLine("Rendimento mensal:");
    long rendimento;
    do
    {
        try
        {
            rendimento = long.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Valor inválido. Digite novamente:");
        }
    } while (true);
    novaPF.rendimento = rendimento;

    Console.WriteLine("Endereço: ");
    novoEndPF.logradouro = Console.ReadLine();

    Console.WriteLine("Número: ");
    int numero;
    do
    {
        try
        {
            numero = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Valor inválido. Digite novamente:");
        }
    } while (true);
    novoEndPF.numero = numero;

    Console.WriteLine("Complemento: ");
    novoEndPF.complemento = Console.ReadLine();

    listaPF.Add(novaPF);
    listaEnd.Add(novoEndPF);

    Console.WriteLine("Cadastro finalizado!");
    Thread.Sleep(2000);
    goto reinicializar;
}

else if (opcao == "4")
{
    PessoaJuridica novaPJ = new PessoaJuridica();
    Endereco novoEndPJ = new Endereco();


    Console.WriteLine("Razão Social: ");
    novaPJ.razaoSocial = Console.ReadLine();

    Console.WriteLine("CNPJ: ");
    long cnpj;
    do
    {
        try
        {
            cnpj = long.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("CNPJ inválido. Digite novamente:");
        }
    } while (true);
    novaPJ.cnpj = cnpj;

    Console.WriteLine("Faturamento mensal:");
    long rendimento;
    do
    {
        try
        {
            rendimento = long.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Valor inválido. Digite novamente:");
        }
    } while (true);
    novaPJ.rendimento = rendimento;

    Console.WriteLine("Endereço: ");
    novoEndPJ.logradouro = Console.ReadLine();
    Console.WriteLine("Número: ");

    int numero;
    do
    {
        try
        {
            numero = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Valor inválido. Digite novamente:");
        }
    } while (true);
    novoEndPJ.numero = numero;

    Console.WriteLine("Complemento: ");
    novoEndPJ.complemento = Console.ReadLine();

    bool endComercial;
    while (true)
    {
        Console.Write("Comercial? (digite 'sim' ou 'não'): ");
        string resposta = Console.ReadLine()?.ToLower() ?? "";


        if (resposta == "sim")
        {
            endComercial = true;
            break;
        }
        else if (resposta == "não")
        {
            endComercial = false;
            break;
        }
        else
        {
            Console.WriteLine("Resposta inválida. Por favor, digite 'sim' ou 'não'.");
        }

    }
    novoEndPJ.endComercial = endComercial;


    listaPJ.Add(novaPJ);
    listaEnd.Add(novoEndPJ);

    Console.WriteLine($@"              Cadastro finalizado!");
    Thread.Sleep(2000);
    goto reinicializar;
    
}
else if (opcao == "0")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\x1b[1m");
    Console.WriteLine($"Saindo do Sistema");
    Thread.Sleep(1000);
    Console.WriteLine("\x1b[0m");
}
Console.Clear();


Utils.Carregamento();

Console.ResetColor();

