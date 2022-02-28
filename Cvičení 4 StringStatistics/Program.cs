using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvičení_4_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
                + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
                + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
                + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
                + "posledni veta!";

            string[] subs = testovaciText.Split(' ');
            Console.WriteLine("{0}", string.Join(" ", subs));

            StringStatistics ss = new StringStatistics(testovaciText);
            
            Console.WriteLine("\n");
            Console.WriteLine("Word count:" + ss.CountWords());
            Console.WriteLine("Line count:" + ss.CountLines());
            Console.WriteLine("Sentences count:" + ss.CountSentences());
            Console.WriteLine("Longest words: {0}\n", string.Join(", ", ss.LongestWords()));
            Console.WriteLine("Shortest words: {0}\n", string.Join(", ", ss.ShortestWords()));
            Console.WriteLine("Most common words: {0}\n", string.Join(", ", ss.MostOftenWords()));
            Console.WriteLine("Alphabetic: {0}\n", string.Join(", ", ss.Alphabet()));
          

            Console.ReadLine();
        }
    }
}