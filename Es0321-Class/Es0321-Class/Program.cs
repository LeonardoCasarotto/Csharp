using System;
using System.Collections.Generic;

namespace Es0321_Class
{
    class Program
    {
         static LinkedList<AstronautaInAdd> trainingList;
         static LinkedList<AstronautainMiss> missionList;

        static void Main(string[] args)
        {
            missionList = new LinkedList<AstronautainMiss>();
            trainingList = new LinkedList<AstronautaInAdd>();



            Console.WriteLine("Hello World!");
        }


        static void Menu()
        {
            Console.WriteLine(" Scegliere quale operazione si desidera fare :");
            Console.WriteLine("/t 1. Aggiungere un nuovo astronauta in allenamento");
            Console.WriteLine("/t 2. Preparare un astronauta per la missione");
            Console.WriteLine("/t 3. Addestrare tutti gli astronauti, indistintamente dallo stato");

            Console.WriteLine("/t 4. Ordinare gli astronauti");

        }
    }
}
