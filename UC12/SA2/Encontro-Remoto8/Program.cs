// dotnet run p/ rodar o projeto
using encontro_remoto8.Classes;

PessoaFisica novaPF = new PessoaFisica();
Endereco novoEndPF = new Endereco();
PessoaJuridica novaPJ = new PessoaJuridica();
Endereco novoEndPJ = new Endereco();
PessoaJuridica metodoPJ = new PessoaJuridica();

List<PessoaFisica> listaPF = new List<PessoaFisica>();
List<PessoaJuridica> listaPJ = new List<PessoaJuridica>();
List<Endereco> listaEndPF = new List<Endereco>();
List<Endereco> listaEndPJ = new List<Endereco>();

string? opcao;
string? finalizar;
string? reinicializar;
string path = @"./Database/dadosPJ.csv";
string path2 = @"./Database/dadosPF.csv";

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
    Utils.Menu();
    opcao = Console.ReadLine();
    Console.Clear();
} while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "0");
Console.Clear();

if (opcao == "1")
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Utils.TituloPF();

    string[] linhas = File.ReadAllLines(path2);
    foreach (string linha in linhas)
    {
        string[] atributo = linha.Split(';');

        PessoaFisica individuo = new PessoaFisica();
        individuo.nome = atributo[0];
        individuo.cpf = long.Parse(atributo[1]);
        individuo.rendimento = long.Parse(atributo[2]);

        Endereco end = new Endereco();
        end.logradouro = atributo[3];
        end.numero = int.Parse(atributo[4]);
        end.complemento = atributo[5];
        
            var idadeD = (DateTime.Today - individuo.dataN).Days;
            int idade = (idadeD / 365);

            Console.WriteLine($"\x1b[1m Nome:\x1b[0m {individuo.nome}");
            Console.WriteLine($"\x1b[1m CPF: \x1b[0m {individuo.cpf.ToString(@"000\.000\.000\-00")}");
            Console.WriteLine($"\x1b[1m Válido: \x1b[0m {(individuo.ValidarCPF(individuo.cpf) ? "sim" : "não")}");
            Console.WriteLine($"\x1b[1m Idade: \x1b[0m {idade}");
            Console.WriteLine($"\x1b[1m Data de Nascimento Ex. DD/MM/YYYY: \x1b[0m {individuo.dataN}");
            Console.WriteLine($"\x1b[1m Maior de idade: \x1b[0m {(individuo.ValidarDataN(individuo.dataN) ? "sim" : "não")}");
            Console.WriteLine($"\x1b[1m Endereço: \x1b[0m {end.logradouro},{end.numero} - {end.complemento})");
            Console.WriteLine($"\x1b[1m Rendimento: \x1b[0m {individuo.rendimento:C}");
            Console.WriteLine(($"\x1b[1m Imposto P. Física: \x1b[0m {individuo.CalcularImposto(individuo.rendimento):C}"));
            Console.WriteLine();
        
    }
    Console.WriteLine();
    finalizar = Console.ReadLine();
}
else if (opcao == "2")
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Utils.TituloPJ();

    string[] linhas = File.ReadAllLines(path);
    foreach (string linha in linhas)
    {
        string[] atributo = linha.Split(';');

        PessoaJuridica instituicao = new PessoaJuridica();
        instituicao.razaoSocial = atributo[0];
        instituicao.cnpj = long.Parse(atributo[1]);
        instituicao.rendimento = long.Parse(atributo[2]);

        Endereco end = new Endereco();
        end.logradouro = atributo[3];
        end.numero = int.Parse(atributo[4]);
        end.complemento = atributo[5];
        end.endComercial = Convert.ToBoolean(atributo[6]);

        Console.WriteLine($"\x1b[1m Razão Social: \x1b[0m {instituicao.razaoSocial}");
        Console.WriteLine($"\x1b[1m CNPJ: \x1b[0m {instituicao.cnpj.ToString(@"00\.000\.000\.\0000\-00")}");
        Console.WriteLine($"\x1b[1m Válido: \x1b[0m {(instituicao.ValidarCnpj(instituicao.cnpj.ToString("00000000000000")) ? "sim" : "não")}");
        Console.WriteLine($"\x1b[1m Endereço: \x1b[0m {end.logradouro}, {end.numero} - {end.complemento} - Comercial? {(end.endComercial ? "sim" : "não")}");
        Console.WriteLine($"\x1b[1m Rendimento: \x1b[0m {instituicao.rendimento:C}");
        Console.WriteLine(($"\x1b[1m Imposto P. Jurídica: \x1b[0m {instituicao.CalcularImposto(instituicao.rendimento):C}"));
        Console.WriteLine();

    }

    Console.WriteLine();
    finalizar = Console.ReadLine();
}
else if (opcao == "3")
{
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
    while (!DateTime.TryParse(Console.ReadLine() ?? "", out dataNascimento))
    {
        Console.WriteLine("Data de nascimento inválida. Digite novamente:");
    }
    novaPF.dataN = dataNascimento;

    Console.WriteLine("Rendimento mensal:");
    long rendimento;
    while (!long.TryParse(Console.ReadLine() ?? "", out rendimento))
    {
        Console.WriteLine("Valor inválido. Digite novamente:");
    }
    novaPF.rendimento = rendimento;

    Console.WriteLine("Endereço: ");
    novoEndPF.logradouro = Console.ReadLine();

    Console.WriteLine("Número: ");
    int numero;
    while (!int.TryParse(Console.ReadLine() ?? "", out numero))
    {

        Console.WriteLine("Entrada inválida. Digíte um número válido.");
    }
    novoEndPF.numero = numero;

    Console.WriteLine("Complemento: ");
    novoEndPF.complemento = Console.ReadLine();

    listaPF.Add(novaPF);
    listaEndPF.Add(novoEndPF);

    using (StreamWriter sw = File.AppendText(path2))
    {
        sw.WriteLine($"{novaPF.nome};{novaPF.cpf};{novaPF.rendimento};{novoEndPF.logradouro};{novoEndPF.numero};{novoEndPF.complemento}");
    }

    Console.WriteLine($@"              Cadastro finalizado!");
    Thread.Sleep(2000);
    goto reinicializar;
}

else if (opcao == "4")
{
    Console.WriteLine("Razão Social: ");
    novaPJ.razaoSocial = Console.ReadLine();

    Console.WriteLine("CNPJ: ");
    long cnpj;
    while (!long.TryParse(Console.ReadLine() ?? "", out cnpj))
    {
        Console.WriteLine("CNPJ inválido. Digite novamente:");
    }
    novaPJ.cnpj = cnpj;

    Console.WriteLine("Faturamento mensal:");
    long rendimento;
    while (!long.TryParse(Console.ReadLine() ?? "", out rendimento))
    {
        Console.WriteLine("Valor inválido. Digite novamente:");
    }
    novaPJ.rendimento = rendimento;

    Console.WriteLine("Endereço: ");
    novoEndPJ.logradouro = Console.ReadLine();

    Console.WriteLine("Número: ");
    int numero;
    while (!int.TryParse(Console.ReadLine() ?? "", out numero))
    {

        Console.WriteLine("Entrada inválida. Digíte um número válido.");
    }
    novoEndPJ.numero = numero;

    Console.WriteLine("Complemento: ");
    novoEndPJ.complemento = Console.ReadLine();

    bool endComercial;
    while (true)
    {
        Console.Write("Comercial? (digite 's' p/ sim ou 'n' p/ não): ");
        string resposta = Console.ReadLine()?.ToLower() ?? "";

        if (resposta == "s")
        {
            endComercial = true;
            break;
        }
        else if (resposta == "n")
        {
            endComercial = false;
            break;
        }
        else
        {
            Console.WriteLine("Resposta inválida. Por favor, digite 's' ou 'n'.");
        }

    }
    novoEndPJ.endComercial = endComercial;

    listaPJ.Add(novaPJ);
    listaEndPJ.Add(novoEndPJ);

    using (StreamWriter sw = File.AppendText(path))
    {
        sw.WriteLine($"{novaPJ.razaoSocial};{novaPJ.cnpj};{novaPJ.rendimento};{novoEndPJ.logradouro};{novoEndPJ.numero};{novoEndPJ.complemento};{novoEndPJ.endComercial}");
    }

    Console.WriteLine($@"             Cadastro finalizado!");
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


