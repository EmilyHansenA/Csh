using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Snake
{
    public partial class Form1 : Form
    {

        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        int maxWidth;
        int maxHeight;

        int Record;
        int Score;

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp;



        public Form1()
        {
            InitializeComponent();

            new Settings();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.direction != "right")
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right && Settings.direction != "left")
            {
                goRight = true;
            }

            if (e.KeyCode == Keys.Down && Settings.direction != "Down")
            {
                goDown = true;
            }

            if (e.KeyCode == Keys.Up && Settings.direction != "up")
            {
                goUp = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (goLeft)
            {
                Settings.direction = ("left");
            }
            if (goRight)
            {
                Settings.direction = ("right");
            }
            if (goDown)
            {
                Settings.direction = ("down");
            }
            if (goUp)
            {
                Settings.direction = ("up");
            }

            for (int i = Snake.Count -1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case "left" :
                            Snake[i].X--;
                            break;

                        case "right":
                            Snake[i].X++;
                            break;

                        case "down":
                            Snake[i].Y++;
                            break;

                        case "up":
                            Snake[i].Y--;
                            break;
                    }

                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }

                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
            pcBox.Invalidate();
        }

        private void UpdatePcBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics pcBox = e.Graphics;

            Brush snakeColor;

            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColor = Brushes.Black;
                }
                else
                {
                    snakeColor = Brushes.Green;
                }

                pcBox.FillEllipse(snakeColor, new Rectangle
                    (
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
            }


            pcBox.FillEllipse(Brushes.Red, new Rectangle
                (
                food.X * Settings.Width,
                food.Y * Settings.Height,
                Settings.Width, Settings.Height
                ));
        }

        private void RestartGame()
        {
            maxWidth = pcBox.Width / Settings.Width - 1;
            maxHeight = pcBox.Height / Settings.Height - 1;

            Snake.Clear();

            btnStart.Enabled = false;

            Score = 0;
            lblScore.Text = "Score: " + Score;

            Circle head = new Circle() { X = 10, Y = 5 };

            Snake.Add(head);

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            tmr.Start();
        }

        private void EatFood()
        {
            Score++;
            lblScore.Text = "Score: " + Score;

            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }

        private void GameOver()
        {

        }
    }
}
