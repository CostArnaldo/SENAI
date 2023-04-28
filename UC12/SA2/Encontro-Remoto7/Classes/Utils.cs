using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace encontro_remoto7.Classes
{
    public static class Utils
    {
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
        
    }
}

