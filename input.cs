using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows .Forms ;
namespace game1
{
    class input
    {
        //load list of avaible keybord buttons
        private static Hashtable keytable = new Hashtable();
        //perform a check to see if a particule buttons is pressed
        public static bool keyPressed(Keys key)
        {
            if (keytable[key] == null)
            {
                return false;
            }
            return (bool)keytable [key];
        }
        // detect if a keyboard button is pressed
        public static void changeState(Keys key, bool state)
        {
            keytable[key] = state;
        }
    }
}
