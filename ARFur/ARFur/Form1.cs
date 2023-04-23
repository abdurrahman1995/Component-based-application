using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace ARFur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
         
        private void button1_Click(object sender, EventArgs e)
        {
            var c = new Class1();
            if(comboBox1.SelectedIndex==0)
            {
                double v = 25000;
               
                var c2 = c.FdisTwen(v);
                label2.Text = c2.ToString();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                double v = 150000;
                
                var c2 = c.FdisTwen(v);
                label2.Text = c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                double v = 50000;
                
                var c2 = c.FdisTwen(v);
                label2.Text = c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                double v = 60000;

                var c2 = c.FdisTwen(v);
                label2.Text = c2.ToString();
            }
            else
            {
                double v = 70000;
                
                var c2 = c.FdisTwen(v);
                label2.Text = c2.ToString();
            }
        }


        private void btn_fifp_Click(object sender, EventArgs e)
        {
            var c = new Class1();
            if (comboBox1.SelectedIndex == 0)
            {
                double v = 25000;

                var c2 = c.FdisFif(v);
                label2.Text = c2.ToString();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                double v = 150000;

                var c2 = c.FdisFif(v);
                label2.Text = c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                double v = 50000;

                var c2 = c.FdisFif(v);
                label2.Text = c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                double v = 60000;

                var c2 = c.FdisFif(v);
                label2.Text = c2.ToString();
            }
            else
            {
                double v = 70000;

                var c2 = c.FdisFif(v);
                label2.Text = c2.ToString();
            }
        }

        private void btn_tenp_Click(object sender, EventArgs e)
        {
            var c = new Class1();
            if (comboBox1.SelectedIndex == 0)
            {
                double v = 25000;

                var c2 = c.FdisTen(v);
                label2.Text = c2.ToString();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                double v = 150000;

                var c2 = c.FdisTen(v);
                label2.Text = c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                double v = 50000;

                var c2 = c.FdisTen(v);
                label2.Text = c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                double v = 60000;

                var c2 = c.FdisTen(v);
                label2.Text = c2.ToString();
            }
            else
            {
                double v = 70000;

                var c2 = c.FdisTen(v);
                label2.Text = c2.ToString();
            }
        }

        private void btn_senp_Click(object sender, EventArgs e)
        {
            var c = new Class1();
            if (comboBox1.SelectedIndex == 0)
            {
                double v = 25000;

                var c2 = c.FdisSev(v);
                label2.Text = c2.ToString();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                double v = 150000;

                var c2 = c.FdisSev(v);
                label2.Text = c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                double v = 50000;

                var c2 = c.FdisSev(v);
                label2.Text = c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                double v = 60000;

                var c2 = c.FdisSev(v);
                label2.Text = c2.ToString();
            }
            else
            {
                double v = 70000;

                var c2 = c.FdisSev(v);
                label2.Text = c2.ToString();
            }
        }
   

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }
    }
}
