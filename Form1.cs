using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domaci_ukol_2_kolacka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                string vstup = textBox1.Text;
                string[] slova = vstup.Split(' ','\t');
                foreach (string i in slova)
                {
                    if (i.Any(char.IsDigit)) { listBox1.Items.Add(i); }
                }
            }
            catch { MessageBox.Show("Shit happends.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
