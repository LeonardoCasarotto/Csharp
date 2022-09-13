namespace Es1509
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Form seq = new Sequenza(Convert.ToInt32(numericUpDown1.Value));
            this.Hide();
            seq.ShowDialog();
            this.Close();
        }
    }
}