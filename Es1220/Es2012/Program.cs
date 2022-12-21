using System;
using static System.Console;

namespace Es1220
{
    class Program
    {
        static void Main(string[] args)
        {
            var dispatcher = new Dispatcher();//publisher
            var handler = new Handler();//subscriber

            dispatcher.NameChange += handler.OnDispatcherNameChange;

            while (true)
            {

                WriteLine("\t---------------\t\n Inserire il nome del dispatcher");
                string nome = ReadLine();
                switch (nome)
                {
                    case "End": return;
                    default: dispatcher.SetNome(nome); break;
                }
            }
        }
    }
}
