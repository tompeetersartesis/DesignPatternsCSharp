using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SdlDotNet.Graphics;

namespace Les1110
{
    public class Enemy : Hero, IUpdater
    {
        private int vX = 0;

        public Enemy(Surface vid)
            : base(vid)
        {                      
            xCoord = 200;

            mAfbeeldingActive = new Surface("enemy.jpg");
            mAfbeeldingLeft = new Surface("enemy.jpg");
            mAfbeeldingRight = new Surface("enemy.jpg");
        }       


        public override void Update(SdlDotNet.Core.TickEventArgs args)
        {
            xCoord+= vX;
            Draw();
        }

        void IUpdater.UpdateData(int x)
        {
            if (x > xCoord)
                vX = 1;
            else
                vX = -1;

           
        }
    }
}
