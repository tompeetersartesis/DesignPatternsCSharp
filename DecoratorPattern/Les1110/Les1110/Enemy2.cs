using SdlDotNet.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Les1110
{
    public class Enemy2 : Hero, IUpdater
    {
        private int vX = 0;

        public Enemy2(Surface vid)
            : base(vid)
        {                      
            xCoord = 600;
            mAfbeeldingActive = new Surface("enemy.jpg");
            mAfbeeldingLeft = new Surface("enemy.jpg");
            mAfbeeldingRight = new Surface("enemy.jpg");
        }

        public override void Update(SdlDotNet.Core.TickEventArgs args)
        {
            xCoord += vX;
            Draw();
        }

        void IUpdater.UpdateData(int x)
        {
            if (x > xCoord)
                vX = 2;
            else
                vX = -2;


        }

    }
}
