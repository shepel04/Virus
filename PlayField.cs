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
    public partial class PlayField : Form
    {
        int countInfected = 1;
        int height = 9;
        int width = 9;
        int distanceBetweenButtons = 30;           
        int remainingMovesCount = 50;
        int second = 50;        
        bool isTimerEnabled = false;
        int countRecursiveCalls = 0;
        int[] amountOfSameColors = new int[81];
        int countForArray = 0;
        int sumOfSameColors = 0;
           
        
        


        private static readonly Random rndGen = new Random();
        private Color[] colors = new Color[6] { Color.Green, Color.Blue, Color.Yellow, Color.Purple, Color.Peru, Color.LightSeaGreen};
        private Color randomColor;
        private Button[,] allButtons;

        public PlayField()
        {
            InitializeComponent();
        }

        private void PlayField_Load(object sender, EventArgs e)
        {
            
            Random random = new Random();
            allButtons = new Button[width, height];
            int indexOfColor = 0;
            for (int x = 9; (x - 9) < width * distanceBetweenButtons; x += distanceBetweenButtons)
            {
                for (int y = 9; (y - 9) < height * distanceBetweenButtons; y += distanceBetweenButtons)
                {                    
                    indexOfColor = rndGen.Next(0, colors.Length - 1); 
                    randomColor = colors[indexOfColor];
                    Button button = new Button();
                    button.Location = new Point(x, y);
                    button.Size = new Size(30, 30);
                    button.BackColor = randomColor;                    
                    button.Enabled = false;                    
                    Controls.Add(button);
                    allButtons[(x - 9) / distanceBetweenButtons, (y - 9) / distanceBetweenButtons] = button;
                    button.Click += new EventHandler(FieldClick);


                }
            }
            //CheckField(0, 0, Color.Red);
            //while (81 - sumOfSameColors * 3 >= 50)
            //{
            //    this.Close();
            //    PlayField newField = new PlayField();
            //    newField.Show();
            //}
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
            }
            
        }

        private void EnableNext(Button[,] allButtons, int currentX, int currentY)
        {
            if (currentY + 1 != 9) allButtons[currentX, currentY + 1].Enabled = true;
            if (currentX + 1 != 9) allButtons[currentX + 1, currentY].Enabled = true;
            if (currentY - 1 != -1) allButtons[currentX, currentY - 1].Enabled = true;
            if (currentX - 1 != -1) allButtons[currentX - 1, currentY].Enabled = true;
        }
        private void CheckField(int currentX, int currentY, Color colorOfCurrentButton)
        {
            for (int y = 0; y < height ; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int counterForCheck = 0;

                    if (x + 1 != 9)
                    {
                        if (allButtons[x, y].BackColor == allButtons[x + 1, y].BackColor)
                        {
                            counterForCheck++;

                        }
                                                
                        amountOfSameColors[countForArray] = counterForCheck;
                        countForArray++;
                        
                    }
                }
            }
            foreach (var item in amountOfSameColors)
            {
                if (item != 0)
                {
                    sumOfSameColors += item;
                }
            }
        }

        private void InfectButtons(int currentX, int currentY, Color colorOfCurrentButton)
        {
            if (allButtons[currentX, currentY].BackColor == colorOfCurrentButton)
            {
                countInfected++;
                   
                allButtons[currentX, currentY].BackColor = Color.Red;
                allButtons[currentX, currentY].Enabled = false;

                if (currentY - 1 != -1 && allButtons[currentX, currentY - 1].BackColor != Color.Red) allButtons[currentX, currentY - 1].Enabled = true;
                if (currentX - 1 != -1 && allButtons[currentX - 1, currentY ].BackColor != Color.Red) allButtons[currentX - 1, currentY].Enabled = true;
                        
                if (currentY + 1 != 9 && allButtons[currentX, currentY + 1].BackColor != Color.Red) allButtons[currentX, currentY + 1].Enabled = true;
                if (currentX + 1 != 9 && allButtons[currentX + 1, currentY].BackColor != Color.Red) allButtons[currentX + 1, currentY].Enabled = true;
                    

                if (currentY + 1 != 9 && colorOfCurrentButton == allButtons[currentX, currentY + 1].BackColor) InfectButtons(currentX, currentY + 1, colorOfCurrentButton);
                if (currentY - 1 != -1 && colorOfCurrentButton == allButtons[currentX, currentY - 1].BackColor) InfectButtons(currentX, currentY - 1, colorOfCurrentButton);
                if (currentX + 1 != 9 && colorOfCurrentButton == allButtons[currentX + 1, currentY].BackColor) InfectButtons(currentX + 1, currentY, colorOfCurrentButton);
                if (currentX - 1 != -1 && colorOfCurrentButton == allButtons[currentX - 1, currentY].BackColor) InfectButtons(currentX - 1, currentY, colorOfCurrentButton);
                    
            }               
            else 
            {
                EnableNext(allButtons, currentX, currentY);                   
            }
                       
        }
        void FieldClick(object sender, EventArgs e)
        {
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

            remainingMoves.Text = Convert.ToString(remainingMovesCount);
            
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

            InfectButtons(currentX, currentY, colorOfCurrentButton);
            
            --remainingMovesCount;
            if (remainingMovesCount == -2)
            {
                LoseForm lose = new LoseForm();
                lose.Show();
                timer1.Enabled = false;
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            label2.Text = Convert.ToString(second);
            --second;
            if (countInfected == 81)
            {
                VinForm vin = new VinForm();
                vin.Show();
                timer1.Enabled = false;

            }
            if (second <= -1)
            {
                LoseForm lose = new LoseForm();
                lose.Show();
                timer1.Enabled = false;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
