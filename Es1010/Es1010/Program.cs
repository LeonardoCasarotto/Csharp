using System;
using static System.Console;


namespace Es1010
{
     class Program
    {
        
       
        static void Main(string[] args)
        {
          Squadra team = new Squadra();

            WriteLine("Nome\tCognome\tnascita\tNumero\t Ruolo\n");
            for(int i = 0; i < team.GetIndice(); i++)
            {
                WriteLine(team.GetNome(i) + "\t" + team.GetCognome(i) + "\t" + team.GetBirth(i).ToString("dd/MM/yyyy") + "\t" + team.GetRole(i));
            }

            
        }
        
    }
}
