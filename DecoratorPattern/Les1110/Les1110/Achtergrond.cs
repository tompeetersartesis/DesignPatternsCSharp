using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SdlDotNet.Graphics;
using SdlDotNet.Core;
using System.Drawing;

namespace Les1110
{
    class Achtergrond
    {
        private Surface mVideo;
        private Surface mAfbeelding;
        private int xCoord, yCoord=0;
        private bool left, right, up, down = false;
        public Achtergrond(Surface vid)
        {
            mVideo = vid;
            mAfbeelding = new Surface("background.jpg");
            mVideo.Blit(mAfbeelding);

            //Events.Tick += new EventHandler<TickEventArgs>(Events_Tick);
            Events.KeyboardDown += new EventHandler<SdlDotNet.Input.KeyboardEventArgs>(Events_KeyboardDown);
            Events.KeyboardUp += new EventHandler<SdlDotNet.Input.KeyboardEventArgs>(Events_KeyboardUp);

        }

        public void Draw()
        {
            //if (right)
            //    xCoord++;

            //if (left)
            //    xCoord--;

            mVideo.Blit(mAfbeelding, new Point(0, 0), new Rectangle(xCoord, 0, 400, 300));
        }

        

        void Events_KeyboardUp(object sender, SdlDotNet.Input.KeyboardEventArgs e)
        {
            left = right = down = up = false;

        }

        void Events_KeyboardDown(object sender, SdlDotNet.Input.KeyboardEventArgs e)
        {
            if (e.Key == SdlDotNet.Input.Key.RightArrow)
                right = true;

            if (e.Key == SdlDotNet.Input.Key.LeftArrow)
                left = true;

            if (e.Key == SdlDotNet.Input.Key.DownArrow)
                down = true;

            if (e.Key == SdlDotNet.Input.Key.UpArrow)
                up = true;
            
            
        }
    }
}
