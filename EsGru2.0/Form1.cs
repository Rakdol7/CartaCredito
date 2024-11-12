using System;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace EsGru2._0
{
    public partial class Form1 : Form
    {
        private Carta carta1;
        private Carta carta2;
        private ContoCorrente conto1;
        private ContoCorrente conto2;
        public Form1()
        {
            InitializeComponent();
            conto1 = new ContoCorrente("giovanni", "podium", 1000.0);
            carta1 = new Carta(conto1, "12345", "777");
            conto2 = new ContoCorrente("giorgio", "mediolanum", 800.0);
            carta2 = new Carta(conto2, "14445", "667");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(conto1.Saldo);
            label3.Text = Convert.ToString(conto2.Saldo);
        }

        private void InviaDenaro_Click(object sender, EventArgs e)
        {
            carta1.InviaDenaro(Convert.ToDouble(numericUpDown1.Value));
            label2.Text = Convert.ToString(conto1.Saldo);

        }

        private void RiceviDenaro_Click(object sender, EventArgs e)
        {
            carta1.PrelevaDenaro(Convert.ToDouble(numericUpDown1.Value));
            label2.Text = Convert.ToString(conto1.Saldo);

        }

        private void QTAdenaro_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InviaDenaro2_Click(object sender, EventArgs e)
        {
            carta2.InviaDenaro(Convert.ToDouble(numericUpDown1.Value));
            label3.Text = Convert.ToString(conto2.Saldo);
        }

        private void PrelevaDenaro2_Click(object sender, EventArgs e)
        {
            carta2.PrelevaDenaro(Convert.ToDouble(numericUpDown1.Value));
            label3.Text = Convert.ToString(conto2.Saldo);
        }

        private void TastoBonifico_Click(object sender, EventArgs e)
        {

        }
    }
}
