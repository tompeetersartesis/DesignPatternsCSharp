using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Les1110
{
    public class Game: IState
    {
        private Manager theManager;

        public Game(Manager m)
        {
            theManager = m;
            theManager.collection.EnableTickEvent();
            theManager.collection.EnableKeyboardEvent();
        }

        public void Draw()
        {
           
        }


        public void CreateWorld()
        {
            
        }
    }
}
