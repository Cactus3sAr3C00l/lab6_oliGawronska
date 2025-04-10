using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6_oliGawronska
{
    public partial class Form1: Form
    {
   
        private int x_row, y_row, time, dyd, croc;

       

        public bool opened = false;
        public Form1()
        {
            InitializeComponent();
            x_row = 3;
            y_row = 4;
            time = 30;
            dyd = 1;
            croc = 1;
        }
        public void setVals(int x_row2, int y_row2, int time2, int dyd2, int croc2)
        {
            this.x_row = x_row2;
            this.y_row = y_row2;
            this.time = time2;
            this.dyd = dyd2;
            this.croc = croc2;
        }
        private void settings_Click(object sender, EventArgs e)
        {
            if (opened == false)
            {
                Form3 form3;
                form3 = new Form3(x_row, y_row, time, dyd,croc, this);
                form3.Show();
                opened = true;
            }
        }

        //START
        private void start_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(x_row, y_row, time, dyd, croc, this);
            form2.Show();
            opened = true;
        }

    }
}
