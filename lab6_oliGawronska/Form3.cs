using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace lab6_oliGawronska
{
    public partial class Form3: Form
    {
        private int x_row, y_row, time, dyd, croc, szopy;
        Form1 form1;
     
        public Form3(int x_row2,int y_row2, int time2, int dyd2,int croc2, int szop2, Form1 form)
        {
            form1 = form;
            InitializeComponent();
            this.x_row = x_row2;
            this.y_row = y_row2;
            this.time = time2;
            this.dyd = dyd2;
            this.croc = croc2;
            this.szopy = szop2;

            x_textBox.Text = x_row.ToString();
            y_textBox.Text = y_row.ToString();
            richTextBox1.Text = time.ToString();
            dyd_textBox.Text = dyd.ToString();
            croc_textBox.Text = croc.ToString();
            szop.Text = szopy.ToString();
        }

        private void saveSettings_Click(object sender, EventArgs e)
        {
            if (x_row <= 10 && x_row>= 1 && y_row>=1 && y_row<= 10 && time >= 10 && time <= 60 && croc >= 0 && croc <= 1 && dyd>=1 && dyd <=6 && szopy >= 3 && szopy <= 8 )
            {
                form1.setVals(x_row, y_row, time, dyd, croc, szopy);
                form1.opened = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Prosze ustawic odpowiednie wartości zmiennych");
            }
        }
        private void dyd_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dyd_textBox.Text))
            {
                dyd = int.Parse(dyd_textBox.Text);
            }
        }

        private void croc_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(croc_textBox.Text))
            {
                croc = int.Parse(croc_textBox.Text);
            }
        }

        private void szop_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(szop.Text))
            {
                szopy = int.Parse(szop.Text);
            }
        }

        //czas
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                time = int.Parse(richTextBox1.Text);
            }
        }



        private void y_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(y_textBox.Text))
            {
                y_row = int.Parse(y_textBox.Text);
            }
        }

        private void x_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(x_textBox.Text))
            {
                x_row = int.Parse(x_textBox.Text);
                }
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.opened = false;

        }

    }
}
