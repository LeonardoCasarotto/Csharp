﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Es0321_Class
{
    class Program
    {
         static LinkedList<AstronautaInAdd> trainingList;
         static LinkedList<AstronautainMiss> astrmissionList;
         static LinkedList<Missione> missionList;

        static void Main(string[] args)
        {
            missionList = new LinkedList<Missione>();
            astrmissionList = new LinkedList<AstronautainMiss>();
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






        static void Json()
        {
            if (File.Exists("data.json"))
            {

                File.Delete("data.json");
            }
            StreamWriter Sr = new StreamWriter("main.json");

            foreach(Missione mi in missionList)
            {
                Sr.WriteLine(JsonSerializer.Serialize(mi));
            }

        }
    }
}
