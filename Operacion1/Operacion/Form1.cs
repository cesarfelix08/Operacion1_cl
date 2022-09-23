using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacion1
{
        public partial class Form1
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                clresta oresta = new clresta(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                textBox3.Text = oresta.restar().ToString();
            }
        }
}
