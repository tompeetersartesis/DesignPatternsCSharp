using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SdlDotNet.Graphics;
using SdlDotNet.Core;
using System.Drawing;
using SdlDotNet.Graphics.Sprites;

namespace Les1110
{
    public class Hero : Sprite
    {
        private bool left, right, up, down = false;
        private Surface mVideo;
        protected Surface mAfbeeldingLeft;
        protected Surface mAfbeeldingRight;
        protected Surface mAfbeeldingActive;
        public int xCoord, yCoord = 0;
        private int xShow = 0;

        public Hero(Surface vid)
        {
            Init(vid);
            //Events.KeyboardDown += new EventHandler<SdlDotNet.Input.KeyboardEventArgs>(Events_KeyboardDown);
            //Events.KeyboardUp += new EventHandler<SdlDotNet.Input.KeyboardEventArgs>(Events_KeyboardUp);
        }
        private Publisher p;

        public Hero(Surface vid, Publisher pub)
        {
            p = pub;
            Init(vid);
        }

        private void Init(Surface vid)
        {
            mVideo = vid;
            mAfbeeldingLeft = new Surface("WalkLeft.jpg");
            mAfbeeldingRight = new Surface("WalkRight.jpg");
            mAfbeeldingActive = mAfbeeldingLeft;
        }


        public void UpdateData(int xData)
        { 
        }

        public virtual void power(SdlDotNet.Input.KeyboardEventArgs args)
        {
            //Original hero has no power..
        }

        public override void Update(SdlDotNet.Input.KeyboardEventArgs args)
        {
            if (args.Down)
            {
                if (args.Key == SdlDotNet.Input.Key.LeftArrow)
                {
                    left = true;
                    mAfbeeldingActive = mAfbeeldingLeft;
                }

                if (args.Key == SdlDotNet.Input.Key.RightArrow)
                {
                    right = true;
                    mAfbeeldingActive = mAfbeeldingRight;
                }
            }
            else 
            {
                left = right = false;
            }

            power(args);
        }

        public override void Update(TickEventArgs args)
        {
            //base.Update(args);
            if (right)
            {
                xCoord+=4;

                if (xShow >= 192)
                    xShow = 0;
                xShow += 64;
            }

            if (left)
                xCoord-=4;
            
           // p.UpdateEnemy(xCoord);

            Draw();
        }

        protected void Draw()
        {       

            mVideo.Blit(mAfbeeldingActive, new Point(xCoord, 0), new Rectangle(xShow, 0, 64, 205));

           
        }

        void Events_KeyboardUp(object sender, SdlDotNet.Input.KeyboardEventArgs e)
        {
            left = right = down = up = false;
        }

        void Events_KeyboardDown(object sender, SdlDotNet.Input.KeyboardEventArgs e)
        {
            if (e.Key == SdlDotNet.Input.Key.RightArrow)
            {
                right = true;
                mAfbeeldingActive = mAfbeeldingRight;
            }
            if (e.Key == SdlDotNet.Input.Key.LeftArrow)
            {
                left = true;
                mAfbeeldingActive = mAfbeeldingLeft;
            }

            if (e.Key == SdlDotNet.Input.Key.DownArrow)
                down = true;

            if (e.Key == SdlDotNet.Input.Key.UpArrow)
                up = true;
        }




    }
}
