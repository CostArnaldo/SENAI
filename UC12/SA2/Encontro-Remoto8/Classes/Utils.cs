using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace encontro_remoto8.Classes
{
    public static class Utils
    {
        public static void Apresentacao()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("\x1b[1m\x1b[4m");
            string[] titles = { "SISTEMA"," ", "DE"," ", "CÁLCULO", " ", "DE", " ", "IMPOSTO", "\n",
                            "para pessoas físicas e jurídicas" };

            foreach (string title in titles)
            {
                Console.Write(title);
                Thread.Sleep(title == " " ? 100 : 500);

            }

            Thread.Sleep(3500);
            Console.WriteLine("\x1b[0m");
        }

        public static void Menu()
        {
               Console.WriteLine("\x1b[1m");
    string topico = @$"
                              ESCOLHA UMA DAS OPÇÕES ABAIXO: ";
    foreach (char letra in topico)
    {
        Console.Write(letra);
        Thread.Sleep(40);
    }
    Console.WriteLine("\x1b[0m");
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
        Thread.Sleep(20);
    }
    Console.WriteLine("\x1b[0m");
        }
        public static void Carregamento()
        {
            Console.WriteLine("\x1b[1m");
            string[] end = { "ENCERRANDO", ".", ".", "." };

            foreach (string e in end)
            {
                Console.Write(e);
                Thread.Sleep(e == "." ? 1000 : 100);
            };
            Console.WriteLine("\x1b[0m");
        }
        public static void TituloPF()
        {
            Console.WriteLine("\x1b[1m");
            Console.WriteLine($"\n {"PESSOA FÍSICA"} \n");
            Thread.Sleep(1000);
            Console.WriteLine("\x1b[0m");
        }
        public static void TituloPJ()
        {
            Console.WriteLine("\x1b[1m");
            Console.WriteLine($"\n {"PESSOA JÚRIDICA"} \n");
            Thread.Sleep(1000);
            Console.WriteLine("\x1b[0m");
        }

        public static void VerificarPastaArquivo(string caminho)
        {
            string pasta = caminho.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(caminho))
            {
                using (File.Create(caminho)) { }
            }

        }

    }
}

