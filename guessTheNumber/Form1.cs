using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessTheNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random(10000);
        Int32 a = 0;

        public void playAgain() {
           a = rnd.Next(0, 10000);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) > a) { label1.Text = "too big . try again"; }
            else if (Convert.ToInt32(textBox1.Text) < a) { label1.Text = "too small . try again"; }
            else  { label1.Text = " corect . play again";  }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playAgain();
        }
    }
}
