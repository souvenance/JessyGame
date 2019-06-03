using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game1
{
    public partial class Form1 : Form
    {
        private List<circle> snake = new List<circle>();
        private circle food = new circle();

        public Form1()
        {
            InitializeComponent();
            //set setting to defaut
            new setting ();
            //set game sppeed and start timer
            gametimer .Interval =1000/setting .speed ;
            gametimer.Tick += UpdateScreen;
            gametimer .Start ();
            //gametimer.Stop();
            // start new game
            StartGame();
        }
         private void StartGame()
         {
             lblgameOver.Visible = false;
             pickbad.Visible = false;
             pickcool.Visible = false;
             pickhappy.Visible = false;
             //set setting to defaut
             new setting ();

             //create new player object
             snake .Clear ();
             circle head = new circle ();
             head .x =10;
             head .y =5;
             snake .Add (head);
             lblscord .Text =setting .score .ToString ();
             GenerateFood();
         }
        // place random food game
        private void GenerateFood()
        {
            int maxXpos =pbcanvas .Size .Width /setting .width ;
            int maxYpost=pbcanvas .Size .Height /setting .height ;

            Random random= new Random ();
            food =new circle ();
            food.x = random.Next(0,maxXpos );
            food.y = random.Next(0, maxYpost);
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            //check for game over
            if (setting.GameOver == true)
            {
                //check if enter is pressed
                if (input.keyPressed(Keys.Enter))
                {
                    StartGame();  
                }
            }
            else
            {
                if (input.keyPressed(Keys.Right) && setting.direction != Direction.Left)
                    setting.direction = Direction.right;
                else if (input.keyPressed(Keys.Left) && setting.direction != Direction.right)
                    setting.direction = Direction.Left;
                else if (input.keyPressed(Keys.Up) && setting.direction != Direction.Down)
                    setting.direction = Direction.Up;
                else if (input.keyPressed(Keys.Down) && setting.direction != Direction.Up)
                    setting.direction = Direction.Down;

               MovePlayer();
            }
            pbcanvas.Invalidate();
        }

        private void pbcanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (!setting.GameOver )
            {
                //set colour of snake
                Brush snakeColour;
                //draw snake
                for (int i = 0; i < snake.Count; i++)
                {
                    if (i == 0)
                        snakeColour = Brushes.Black;  // draw head
                    else
                        snakeColour = Brushes.Green; //RestoreBounds of body
                    // draw snake
                    canvas.FillEllipse (snakeColour ,
                        new Rectangle (snake [i].x  * setting .width ,
                            snake [i].y * setting .height ,
                            setting .width ,setting .height ));
                    // draw food
                    canvas .FillEllipse (Brushes .Red ,
                        new Rectangle (food .x  * setting .width ,
                            food .y * setting .height ,setting .width ,setting .height ));
                }
            }
            else
            {
                string gamerOver;
                if (setting.score <= 400)
                {
                    gamerOver = "Gane over \nYour final score is: " + setting.score + "\nBad score \nPres Enter to try again";
                    lblgameOver.Text =gamerOver;
                    lblgameOver.Visible = true;
                    pickbad.Visible = true;
                }
                else if (setting.score <= 900)
                {
                    gamerOver = "Gane over \nYour final score is: " + setting.score + "\n good score \nPres Enter to try again";
                    lblgameOver.Text = gamerOver;
                    lblgameOver.Visible = true;
                    pickcool.Visible = true;
                }
                else if (setting.score > 900)
                {
                    gamerOver = "Gane over \nYour final score is: " + setting.score + "\n verry good score \nPres Enter to try again";
                    lblgameOver.Text = gamerOver;
                    lblgameOver.Visible = true;
                    pickhappy.Visible = true;
                }
              
            }
        }

        private void MovePlayer()
        {
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                //move head
                if (i == 0)
                {
                    switch (setting.direction)
                    {
                        case Direction.right:
                            snake[i].x++;
                            break;
                        case Direction.Left:
                            snake[i].x--;
                            break;
                        case Direction.Up:
                            snake[i].y--;
                            break;
                        case Direction.Down:
                            snake[i].y++;
                            break;
                    }
                    //get maximu x and y pos 
                    int maxXpos = pbcanvas.Size.Width / setting.width;
                    int maxYpos = pbcanvas.Size.Height / setting.height;
                    //detect collission with game borders
                    if (snake[i].x < 0 || snake[i].y < 0 || snake[i].x >= maxXpos || snake[i].y >= maxYpos) 
                    {
                       Die();
                    }
                    //detect collission body
                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (snake[i].x == snake[j].x &&
                            snake[i].y == snake[j].y)
                        {
                            Die();
                        }
                    }
                    //detect collission with foood piece
                    if (snake[0].x == food.x && snake[0].y == food.y)
                    {
                       Eat();
                    }
                }
                else
                {
                    //move body
                    snake[i].x = snake[i - 1].x;   
                    snake[i].y = snake[i - 1].y;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            input.changeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            input.changeState(e.KeyCode, false );
        }
        private void Die()
        {
            setting.GameOver = true;
        }
        private void Eat()
        {
            //ad ircle body
            circle food = new circle();
            food.x = snake[snake.Count - 1].x;
            food.y = snake[snake.Count - 1].y;
            snake.Add(food);

            // uupdate score 
            setting.score += setting.points;
            lblscord.Text = setting.score.ToString();
            GenerateFood();
        }

      
    }
}
