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
    public partial class Form2: Form
    {
        private int x_row, y_row, time, dyd, croc;
        Form1 form1;
        List<Button> myGrid = new List<Button>();

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.opened = false;
        }

        public Form2(int x_row2, int y_row2, int time2, int dyd2, int croc2, Form1 form)
        {
            form1 = form;
            InitializeComponent();
            this.x_row = x_row2;
            this.y_row = y_row2;
            this.time = time2;
            this.dyd = dyd2;
            this.croc = croc2;

            button1.Text = time.ToString();
            makeGrid(x_row, y_row, time, dyd, croc);


        }
        private void onChange(object sender, EventArgs e)
        {

        }
        private void makeGrid(int x_row2, int y_row2, int time2, int dyd2, int croc2)
        {
            int buttonWidth = 40;
            int buttonHeight = 40;
            int horizontalSpacing = 5;
            int verticalSpacing = 5;
            int startX = 140;
            int startY = 15;
            int posX=0, posY=0;
            
            for (int i = 0; i < x_row2; i++)
            {
                
                for (int j = 0; j < y_row2; j++)
                {
                     posX = startX + i * (buttonWidth + horizontalSpacing);
                     posY = startY + j * (buttonHeight + verticalSpacing);

                    Button btn = new Button();
                    btn.Location = new Point(posX, posY);
                    btn.Size = new Size(buttonWidth, buttonHeight);
                    btn.Name = $"btn_{i}_{j}";

                   
                    btn.Click += new EventHandler(onChange);

                    Controls.Add(btn);
                    myGrid.Add(btn);
                }
            }
            
            this.Size = new Size(posX+100, posY+100);

        }

        //czas
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
