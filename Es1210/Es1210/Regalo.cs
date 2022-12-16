using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Es1210
{
    public class Regalo
    {
        private string nome;
        private string cognome;
        private string regalo_desiderato;
        private Color colore;

        public string GetNome()
        {
            return this.nome;
        }
        public string GetCognome()
        {
            return this.cognome;
        }
        public string GetRegalo()
        {
            return this.regalo_desiderato;
        }
        public Color GetColor()
        {
            return this.colore;
        }

        public Regalo()
        {
            nome = "";
            cognome = "";
            regalo_desiderato = "";
            colore = Color.FromArgb(0, 0, 0);
        }

        public Regalo(string name, string surname, string gift)
        {
            this.nome = name;
            this.cognome = surname;
            this.regalo_desiderato = gift;
            Random rn = new Random();
            int r = rn.Next(0, 255);
            int g = rn.Next(0, 255);
            int b = rn.Next(0, 255);
            this.colore = Color.FromArgb(r,g,b);

        }
    }
}
