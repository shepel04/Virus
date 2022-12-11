using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virus
{
    public partial class PlayField_Player : Form
    {
        private int countInfected = 1;
        private int countUnInfected = 1;
        private int height = 9;
        private int width = 9;
        private int distanceBetweenButtons = 30;
        private int remainingMovesCount_Virus = 10;
        private int remainingMovesCount_Antivirus = 10;
        private int countMoves = 1;

        private static List<Button> cellsNearRed = new List<Button>();
        private static List<Button> cellsNearBlue = new List<Button>();

        private bool enable = true;
        private bool disable = false;
        private bool isFirstMove = true;
        private bool isFirsBlueSelect = false;
        private bool isFirsRedSelect = false;
        private bool isTimerEnabled = false;

        private static readonly Random rndGen = new Random();
        private Color[] colors = new Color[6] { Color.Green, Color.Gray, Color.Yellow, Color.Purple, Color.Peru, Color.LightSeaGreen};
        private Color randomColor;
        private Button[,] allButtons;

        public PlayField_Player()
        {
            InitializeComponent();
        }

        private void PlayField_Load(object sender, EventArgs e)
        {
            
            Random random = new Random();
            allButtons = new Button[width, height];
            int indexOfColor = 0;
            for (int x = 280; (x - 280) < width * distanceBetweenButtons; x += distanceBetweenButtons)
            {
                for (int y = 50; (y - 50) < height * distanceBetweenButtons; y += distanceBetweenButtons)
                {                    
                    indexOfColor = rndGen.Next(0, colors.Length); 
                    randomColor = colors[indexOfColor];
                    Button button = new Button();
                    button.Location = new Point(x, y);
                    button.Size = new Size(30, 30);
                    button.BackColor = randomColor;                    
                    button.Enabled = false;                    
                    Controls.Add(button);
                    allButtons[(x - 280) / distanceBetweenButtons, (y - 50) / distanceBetweenButtons] = button;
                    button.Click += new EventHandler(FieldClick);


                }
            }            
                FirstCheckEnabledButtons(allButtons);
        }

        private void FirstCheckEnabledButtons(Button[,] allButtons)
        {
            
            if (width - 9 == 0 && height - 9 == 0)
            {
                allButtons[0, 0].BackColor = Color.Red;
                allButtons[0, 0].Enabled = false;
                allButtons[1, 0].Enabled = true;                
                allButtons[0, 1].Enabled = true;
                allButtons[8, 8].BackColor = Color.Blue;
            }
            
        }

        private void EnableNext(Button[,] allButtons, int currentX, int currentY)
        {
            
            if (countMoves % 2 == 0)
            {
                if (currentY + 1 != 9)
                {
                    allButtons[currentX, currentY + 1].Enabled = true;
                    cellsNearBlue.Add(allButtons[currentX, currentY + 1]);
                }
                if (currentX + 1 != 9)
                {
                    allButtons[currentX + 1, currentY].Enabled = true;
                    cellsNearBlue.Add(allButtons[currentX + 1, currentY]);
                }
                if (currentY - 1 != -1)
                {
                    allButtons[currentX, currentY - 1].Enabled = true;
                    cellsNearBlue.Add(allButtons[currentX, currentY - 1]);
                }
                if (currentX - 1 != -1)
                {
                    allButtons[currentX - 1, currentY].Enabled = true;
                    cellsNearBlue.Add(allButtons[currentX - 1, currentY]);
                }
            }

            if (countMoves % 2 != 0)
            {
                if (currentY + 1 != 9)
                {
                    allButtons[currentX, currentY + 1].Enabled = true;
                    cellsNearRed.Add(allButtons[currentX, currentY + 1]);
                }
                if (currentX + 1 != 9)
                {
                    allButtons[currentX + 1, currentY].Enabled = true;
                    cellsNearRed.Add(allButtons[currentX + 1, currentY]);
                }
                if (currentY - 1 != -1)
                {
                    allButtons[currentX, currentY - 1].Enabled = true;
                    cellsNearRed.Add(allButtons[currentX, currentY - 1]);
                }
                if (currentX - 1 != -1)
                {
                    allButtons[currentX - 1, currentY].Enabled = true;
                    cellsNearRed.Add(allButtons[currentX - 1, currentY]);
                }
            }

        }
        

        private void InfectButtons(int currentX, int currentY, Color colorOfCurrentButton)
        {
            if (currentX == 0 && currentY == 1 && !isFirsRedSelect)
            {
                cellsNearRed.Add(allButtons[1, 0]);
                isFirsRedSelect = true;
            }
            else if (currentX == 1 && currentY == 0 && !isFirsRedSelect)
            {
                cellsNearRed.Add(allButtons[0, 1]);
                isFirsRedSelect = true;
            }
            if (allButtons[currentX, currentY].BackColor == colorOfCurrentButton)
            {
                ++countInfected;
                   
                allButtons[currentX, currentY].BackColor = Color.Red;
                allButtons[currentX, currentY].Enabled = false;

                if (currentY - 1 != -1 && allButtons[currentX, currentY - 1].BackColor != Color.Red)
                {
                    allButtons[currentX, currentY - 1].Enabled = true;
                    cellsNearRed.Add(allButtons[currentX, currentY - 1]);
                    
                }
                if (currentX - 1 != -1 && allButtons[currentX - 1, currentY].BackColor != Color.Red)
                {
                    allButtons[currentX - 1, currentY].Enabled = true;
                    cellsNearRed.Add(allButtons[currentX - 1, currentY]);
                    
                }

                if (currentY + 1 != 9 && allButtons[currentX, currentY + 1].BackColor != Color.Red)
                {
                    allButtons[currentX, currentY + 1].Enabled = true;
                    cellsNearRed.Add(allButtons[currentX, currentY + 1]);
                    
                }
                if (currentX + 1 != 9 && allButtons[currentX + 1, currentY].BackColor != Color.Red)
                {
                    allButtons[currentX + 1, currentY].Enabled = true;
                    cellsNearRed.Add(allButtons[currentX + 1, currentY]);
                    
                } 


                if (currentY + 1 != 9 && colorOfCurrentButton == allButtons[currentX, currentY + 1].BackColor)
                {
                    InfectButtons(currentX, currentY + 1, colorOfCurrentButton);
                }
                if (currentY - 1 != -1 && colorOfCurrentButton == allButtons[currentX, currentY - 1].BackColor)
                {
                    InfectButtons(currentX, currentY - 1, colorOfCurrentButton);
                }
                if (currentX + 1 != 9 && colorOfCurrentButton == allButtons[currentX + 1, currentY].BackColor)
                {
                    InfectButtons(currentX + 1, currentY, colorOfCurrentButton);
                }
                if (currentX - 1 != -1 && colorOfCurrentButton == allButtons[currentX - 1, currentY].BackColor)
                {
                    InfectButtons(currentX - 1, currentY, colorOfCurrentButton);
                } 
                    
            }               
            else 
            {
                EnableNext(allButtons, currentX, currentY);                   
            }
                       
        }

        private void UnInfectButtons(int currentX, int currentY, Color colorOfCurrentButton)
        {
            if (currentX == 7 && currentY == 8 && !isFirsBlueSelect)
            {
                cellsNearBlue.Add(allButtons[8, 7]);
                isFirsBlueSelect = true;    
            }
            else if (currentX == 8 && currentY == 7 && !isFirsBlueSelect)
            {
                cellsNearBlue.Add(allButtons[7, 8]);
                isFirsBlueSelect = true;
            }

            if (allButtons[currentX, currentY].BackColor == colorOfCurrentButton)
            {
                ++countUnInfected;

                allButtons[currentX, currentY].BackColor = Color.Blue;
                allButtons[currentX, currentY].Enabled = false;

                if (currentY - 1 != -1 && allButtons[currentX, currentY - 1].BackColor != Color.Blue)
                {
                    allButtons[currentX, currentY - 1].Enabled = true;
                    cellsNearBlue.Add(allButtons[currentX, currentY - 1]);
                }
                if (currentX - 1 != -1 && allButtons[currentX - 1, currentY].BackColor != Color.Blue)
                {
                    allButtons[currentX - 1, currentY].Enabled = true;
                    cellsNearBlue.Add(allButtons[currentX - 1, currentY]);
                }

                if (currentY + 1 != 9 && allButtons[currentX, currentY + 1].BackColor != Color.Blue)
                {
                    allButtons[currentX, currentY + 1].Enabled = true;
                    cellsNearBlue.Add(allButtons[currentX, currentY + 1]);
                }
                if (currentX + 1 != 9 && allButtons[currentX + 1, currentY].BackColor != Color.Blue)
                {
                    allButtons[currentX + 1, currentY].Enabled = true;
                    cellsNearBlue.Add(allButtons[currentX + 1, currentY]);
                } 


                if (currentY + 1 != 9 && colorOfCurrentButton == allButtons[currentX, currentY + 1].BackColor)
                {
                    UnInfectButtons(currentX, currentY + 1, colorOfCurrentButton);
                } 
                if (currentY - 1 != -1 && colorOfCurrentButton == allButtons[currentX, currentY - 1].BackColor)
                {
                    UnInfectButtons(currentX, currentY - 1, colorOfCurrentButton);
                } 
                if (currentX + 1 != 9 && colorOfCurrentButton == allButtons[currentX + 1, currentY].BackColor)
                {
                    UnInfectButtons(currentX + 1, currentY, colorOfCurrentButton);
                } 
                if (currentX - 1 != -1 && colorOfCurrentButton == allButtons[currentX - 1, currentY].BackColor)
                {
                    UnInfectButtons(currentX - 1, currentY, colorOfCurrentButton);
                } 

            }
            else
            {
                EnableNext(allButtons, currentX, currentY);
            }

        }

        void FieldClick(object sender, EventArgs e)
        {
           
            if (countMoves % 2 == 0)
            {
                --remainingMovesCount_Antivirus;
                exit_from_PlayField.Text = Convert.ToString(remainingMovesCount_Antivirus);                
                
            }
            else if (countMoves % 2 != 0)
            {
                --remainingMovesCount_Virus;
                remainingMoves_Virus.Text = Convert.ToString(remainingMovesCount_Virus);                
                
            }
            
            Button button = (Button)sender;
            
            Color colorOfCurrentButton = button.BackColor;
            int currentX = 0;
            int currentY = 0;
            if (!isTimerEnabled)
            {
                
                timer1.Start();
                timer1.Interval = 1000;
                isTimerEnabled = true;

            }


            
            
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (allButtons[x, y].BackColor == Color.Red)
                    {
                        allButtons[x, y].Enabled = false;
                    }
                    if (allButtons[x,y] == button)
                    {
                        currentX = x;
                        currentY = y;
                        break;  
                    }
                }
            }
            if (countMoves % 2 == 0)
            {
                UnInfectButtons(currentX, currentY, colorOfCurrentButton);
                
            }
            else
            InfectButtons(currentX, currentY, colorOfCurrentButton);
            
            ++countMoves;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private static void Enable_DisableRed(bool needStatus)
        {
            foreach (var item in cellsNearRed)
            {
                if (item == null) break;
                
                if (item != null)
                {
                    item.Enabled = needStatus;   

                }
                    
            }
        }
        private static void Enable_DisableBlue(bool needStatus)
        {
            foreach (var item in cellsNearBlue)
            {
                if (item == null) break;

                if (item != null)
                {
                    item.Enabled = needStatus;
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countMoves % 2 != 0)
            {
                current_move.ForeColor = Color.Red;
                current_move.Text = "Virus";

                Enable_DisableRed(enable);
                if (!isFirstMove)
                {
                    Enable_DisableBlue(disable);
                }

            }
            else
            {
                current_move.ForeColor = Color.Blue;
                current_move.Text = "Antivirus";
                if (isFirstMove)
                {
                    allButtons[8, 8].Enabled = false;
                    allButtons[8, 7].Enabled = true;
                    allButtons[7, 8].Enabled = true;
                    isFirstMove = false;
                }
                else
                {
                    Enable_DisableRed(disable);
                    Enable_DisableBlue(enable);
                }

            }
            if (remainingMovesCount_Virus == 0 && remainingMovesCount_Antivirus == 0)
            {
                if (countInfected > countUnInfected)
                {
                    RedWin redWin = new RedWin();
                    redWin.Show();
                    timer1.Enabled = false;
                }
                else if (countInfected < countUnInfected)
                {
                    BlueWin blueWin = new BlueWin();
                    blueWin.Show();
                    timer1.Enabled = false;
                }
                else
                {
                    DrawForm draw = new DrawForm();
                    draw.Show();
                    timer1.Enabled = false;
                }

            }

            score_virus.Text = Convert.ToString(countInfected);
            score_antivirus.Text = Convert.ToString(countUnInfected);
            foreach (var item in allButtons)
            {
                if (item.BackColor == Color.Blue || item.BackColor == Color.Red && item.Enabled == true)
                {
                    item.Enabled = false;
                    if (item.BackColor == Color.Blue)
                    {
                        cellsNearBlue.Remove(item);
                    }
                    else if (item.BackColor == Color.Red)
                    {
                        cellsNearRed.Remove(item);
                    }
                }
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();            
            Menu menu = new Menu();
            menu.Show();
        }

        private void score_virus_Click(object sender, EventArgs e)
        {

        }

        private void score_antivirus_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }

        //private void PlayField_FormClosing(Object sender, FormClosingEventArgs e)
        //{
        //    System.Diagnostics.Process.GetCurrentProcess().Kill();
        //    System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
        //    messageBoxCS.AppendFormat("{0} = {1}", "CloseReason", e.CloseReason);
        //    messageBoxCS.AppendLine();
        //    messageBoxCS.AppendFormat("{0} = {1}", "Cancel", e.Cancel);
        //    messageBoxCS.AppendLine();
        //    MessageBox.Show(messageBoxCS.ToString(), "FormClosing Event");
        //}
    
}
