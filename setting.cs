using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    public enum Direction 
    {
        Up,
        Down,
        Left,
        right
    };
    class setting
    {
        public static  int width { get; set; }
        public static int height { get; set; }
        public static int speed { get; set; }
        public static int score { get; set; }
        public static int points { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }

        public setting()
        {
            width = 16;
            height = 16;
            speed = 10;
            score = 0;
            points = 100;
            GameOver = false;
            direction = Direction.Down;
        }
    }
}
