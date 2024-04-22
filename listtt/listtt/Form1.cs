using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace listtt
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

 

        private void button3_Click(object sender, EventArgs e)
        {
            check.Items.RemoveAt(check.SelectedIndex);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            check.Items.Add(str);
            textBox1.Clear();
        }

  
    }
}