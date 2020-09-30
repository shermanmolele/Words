using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Words
{
    public partial class Words : Form
    {
        public Words()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" )
            {
                label2.Text = textBox1.Text;
                MessageBox.Show("Word has been added");

            }
            else
            {
                MessageBox.Show("Please enter a word");
            }
        }

        private void Words_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
