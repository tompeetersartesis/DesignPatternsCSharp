using SdlDotNet.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Les1110
{
    class FlyHero: HeroDecorator
    {
        public Hero theHero;

        public FlyHero(Surface vid, Hero h)
            : base(vid)
        {
            theHero = h;
        }


        public override void power(SdlDotNet.Input.KeyboardEventArgs args)
        {

            if (theHero != null)
            {
                if (args.Key == SdlDotNet.Input.Key.F)
                    Console.WriteLine("I can fly .. ");


                theHero.power(args);
            }
        }


    }
}
