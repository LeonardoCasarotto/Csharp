using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Es0321_Form
{
    public partial class Form1 : Form
    {
         static List<AstronautaInAdd> trainingList;
         static List<AstronautainMiss> astrmissionList;
         static List<Missione> missionList;

        public Form1()
        {
            InitializeComponent();
            missionList = new List<Missione>();
            astrmissionList = new List<AstronautainMiss>();
            trainingList = new List<AstronautaInAdd>();

            

            dGridA.RowHeadersVisible = true;
            dGridA.SelectionMode = 0;
           
            dGridA.DefaultCellStyle.SelectionBackColor = Color.White;
            dGridA.DefaultCellStyle.SelectionForeColor = Color.Black;
            dGridA.ColumnCount = 3;
            dGridA.Columns[0].Name = "Id";
            dGridA.Columns[1].Name = "Ruolo";
 
            dGridA.Columns[2].Name = "Missione";

            dGridA.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#d9e1f2"); ;
            dGridA.ReadOnly = true;
            dGridA.Visible = true;



            dGridB.RowHeadersVisible = true;
            dGridB.SelectionMode = 0;

            dGridB.DefaultCellStyle.SelectionBackColor = Color.White;
            dGridB.DefaultCellStyle.SelectionForeColor = Color.Black;
            dGridB.ColumnCount = 4;
            dGridB.Columns[0].Name = "Id";
            dGridB.Columns[1].Name = "Ruolo";

            dGridB.Columns[2].Name = "Ore Tecniche";
            dGridB.Columns[3].Name = "Ore Pratiche";

            dGridB.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#d9e1f2"); ;
            dGridB.ReadOnly = true;
            dGridB.Visible = true;







        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Json()
        {
            if (File.Exists("data.json"))
            {

                File.Delete("data.json");
            }
            StreamWriter Sr = new StreamWriter("main.json");

            /*foreach (Missione mi in missionList)
            {
                Sr.WriteLine(Text.JsonSerializer.Serialize(mi));
            }*/
            Sr.Close();

        }

        public void Ordina(List<Astronauta> l)
        {
            for (int i = 0; i < l.Count - 1; i++)
                for (int j = 0; j < l.Count - i - 1; j++)
                    if (l[j].missions.Count > l[j + 1].missions.Count)
                    {
                        // swap temp and arr[i]
                        Astronauta temp = l[j];
                        l[j] = l[j + 1];
                        l[j + 1] = temp;
                    }


        }






        public void AggiornaA(List<AstronautainMiss> a)
        {

            int i = 0;
            foreach(AstronautainMiss h in a)
            {
                dGridA.Rows.Add(i, h.role, h.incorso);
                i++;
            }
        }

        public void AggiornaB(List<AstronautaInAdd> j)
        {
            int i = 0;
            foreach (AstronautaInAdd h in j)
            {
                dGridB.Rows.Add(i, h.role, h.hoursTechnique,h.hoursPhisique);
                i++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:

                    Ordina(astrmissionList as List<Astronauta>);
                    break;
                case 2:

                    break;

            }
        }
    }
}
