using SdlDotNet.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Les1110
{
    class ShootHero: HeroDecorator
    {
        public Hero theHero;

        public ShootHero(Surface vid, Hero h)
            : base(vid)
        {
            theHero = h;
        }

        public override void power(SdlDotNet.Input.KeyboardEventArgs args)
        {
            if (args.Key == SdlDotNet.Input.Key.Space)
                Console.WriteLine("Pang, pang ...");

            theHero.power(args);
        }

    }
}
