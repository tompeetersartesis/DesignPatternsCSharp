using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Les1110
{
    public class Start : IState
    {
        Manager theManager;
        public Start(Manager m)
        {
            theManager = m;

            theManager.collection.DisableTickEvent();
            
           
        }
        public void Draw()
        {
            Console.WriteLine("Start screen");
            //Teken game achtergrond
        }

        public void CreateWorld()
        {
            throw new NotImplementedException();
        }
    }
}
