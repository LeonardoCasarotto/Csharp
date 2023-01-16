using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Es0116.Classes
{
    public class Prosciutto
    {
        public static void Reperimento()
        {
            Console.WriteLine("Il prosciutto è stato preso dal frigorifero");
            Thread.Sleep(2000);
            Console.WriteLine("Il prosciutto sta venendo affettato");
            Thread.Sleep(3000);
            Console.WriteLine("Il prosciutto è stato posizionato nel piatto.");
            Thread.Sleep(0);
        }
    }
}
