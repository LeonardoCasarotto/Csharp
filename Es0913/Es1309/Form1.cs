namespace Es1309
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value < 1)
            {
                numericUpDown1.Value = 0;
                MessageBox.Show("Inserire un valore valido!", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form inserimento = new Inserimento(Convert.ToInt32(numericUpDown1.Value));
                this.Hide();
                inserimento.ShowDialog();
                this.Close();
            }
        }
    }
}