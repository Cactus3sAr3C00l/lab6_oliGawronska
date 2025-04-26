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
    public partial class Form2 : Form
    {
        private int x_row, y_row, time, dyd, croc, szopy;
        private int timeLeft; 
        private int foundDydelfs = 0; 
        private Timer gameTimer = new Timer();
        private Random random = new Random(); 
        private bool gameOver = false; 

        private Dictionary<Button, string> buttonContents = new Dictionary<Button, string>();

        Form1 form1;
        List<Button> myGrid = new List<Button>();

        private Color defaultColor = Color.Gray;
        private Color emptyColor = Color.LightGray;
        private Color dydelfColor = Color.Green;
        private Color krokodylColor = Color.Red;
        private Color szopColor = Color.Orange;

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.opened = false;
           
            gameTimer.Stop();
        }

        public Form2(int x_row2, int y_row2, int time2, int dyd2, int croc2, int szopy2, Form1 form)
        {
            form1 = form;
            InitializeComponent();

            this.x_row = x_row2;
            this.y_row = y_row2;
            this.time = time2;
            this.dyd = dyd2;
            this.croc = croc2;
            this.szopy = szopy2;
            this.timeLeft = time2;

            button1.Text = timeLeft.ToString();

        
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;

          
            makeGrid(x_row, y_row, time, dyd, croc, szopy);

           
            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            
            timeLeft--;
            button1.Text = timeLeft.ToString();

            
            if (timeLeft <= 0)
            {
                EndGame(false, "Czas się skończył! Przegrałeś!");
            }
        }

        private void onChange(object sender, EventArgs e)
        {
            if (gameOver) return; 

            Button clickedButton = (Button)sender;

           
            if (clickedButton.Tag != null && clickedButton.Text == "K")
            {
                
                clickedButton.BackColor = defaultColor;
                clickedButton.Text = "";
                clickedButton.Tag = null; 
                return; 
            }

           
            if (buttonContents.ContainsKey(clickedButton))
            {
                string content = buttonContents[clickedButton];

                switch (content)
                {
                    case "Empty":
                      
                        clickedButton.BackColor = emptyColor;
                        clickedButton.Enabled = false; 
                        break;

                    case "Dydelf":
                       
                        clickedButton.BackColor = dydelfColor;
                        clickedButton.Text = "D";
                        clickedButton.Enabled = false;
                        foundDydelfs++;

                     
                        if (foundDydelfs >= dyd)
                        {
                            EndGame(true, "Gratulacje! Znalazłeś wszystkie dydelfy!");
                        }
                        break;

                    case "Krokodyl":
                       
                        clickedButton.BackColor = krokodylColor;
                        clickedButton.Text = "K";

                    
                        clickedButton.Tag = DateTime.Now;

                   
                        Timer krokodylTimer = new Timer();
                        krokodylTimer.Interval = 2000; 
                        krokodylTimer.Tick += (s, args) => {
                            krokodylTimer.Stop();

                          
                            if (clickedButton.Tag != null && clickedButton.Text == "K")
                            {
                                EndGame(false, "Krokodyl Cię dorwał! Przegrałeś!");
                            }
                        };
                        krokodylTimer.Start();
                        break;

                    case "Szop":
                        clickedButton.BackColor = szopColor;
                        clickedButton.Text = "S";

                        Timer szopTimer = new Timer();
                        szopTimer.Interval = 2000; 
                        szopTimer.Tick += (s, args) => {
                            szopTimer.Stop();

                            
                            clickedButton.BackColor = defaultColor;
                            clickedButton.Text = "";

                           
                            CloseSurroundingButtons(clickedButton);
                        };
                        szopTimer.Start();
                        break;
                }
            }
        }
        private void EndGame(bool isWin, string message)
        {
            
            gameTimer.Stop();
            gameOver = true;

        
            MessageBox.Show(message, isWin ? "Wygrana!" : "Przegrana!", MessageBoxButtons.OK,
                isWin ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            RevealAllItems();
        }

        private void RevealAllItems()
        {
          
            foreach (var pair in buttonContents)
            {
                Button btn = pair.Key;
                string content = pair.Value;

                switch (content)
                {
                    case "Dydelf":
                        btn.BackColor = dydelfColor;
                        btn.Text = "D";
                        break;
                    case "Krokodyl":
                        btn.BackColor = krokodylColor;
                        btn.Text = "K";
                        break;
                    case "Szop":
                        btn.BackColor = szopColor;
                        btn.Text = "S";
                        break;
                }
            }
        }

        private void CloseSurroundingButtons(Button centerButton)
        {
            int centerIndex = myGrid.IndexOf(centerButton);
            if (centerIndex == -1) return;

            int centerRow = centerIndex / y_row;
            int centerCol = centerIndex % y_row;

            for (int i = Math.Max(0, centerRow - 1); i <= Math.Min(x_row - 1, centerRow + 1); i++)
            {
                for (int j = Math.Max(0, centerCol - 1); j <= Math.Min(y_row - 1, centerCol + 1); j++)
                {
                    int adjIndex = i * y_row + j;
                    if (adjIndex >= 0 && adjIndex < myGrid.Count)
                    {
                        Button adjButton = myGrid[adjIndex];
                        adjButton.BackColor = defaultColor;
                        adjButton.Text = "";
                    }
                }
            }
        }

        private void makeGrid(int x_row2, int y_row2, int time2, int dyd2, int croc2, int szopy)
        {
            int buttonWidth = 40;
            int buttonHeight = 40;
            int horizontalSpacing = 5;
            int verticalSpacing = 5;
            int startX = 140;
            int startY = 15;
            int posX = 0, posY = 0;

            List<int> positions = new List<int>();
            for (int i = 0; i < x_row2 * y_row2; i++)
            {
                positions.Add(i);
            }

            ShuffleList(positions);

            List<int> dydelfPositions = positions.Take(dyd2).ToList();
            List<int> krokodylPositions = positions.Skip(dyd2).Take(croc2).ToList();
            List<int> szopPositions = positions.Skip(dyd2 + croc2).Take(szopy).ToList();

           
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
                    btn.BackColor = defaultColor;

                 
                    int position = i * y_row2 + j;
                    if (dydelfPositions.Contains(position))
                    {
                        buttonContents[btn] = "Dydelf";
                    }
                    else if (krokodylPositions.Contains(position))
                    {
                        buttonContents[btn] = "Krokodyl";
                    }
                    else if (szopPositions.Contains(position))
                    {
                        buttonContents[btn] = "Szop";
                    }
                    else
                    {
                        buttonContents[btn] = "Empty";
                    }

                    btn.Click += new EventHandler(onChange);
                    Controls.Add(btn);
                    myGrid.Add(btn);
                }
            }

          
            this.Size = new Size(posX + 100, posY + 100);
        }


        private void ShuffleList<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Pozostało {timeLeft} sekund!", "Czas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}