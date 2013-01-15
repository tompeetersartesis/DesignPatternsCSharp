using SdlDotNet.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Les1110
{
    class HeroDecorator : Hero
    {
        public HeroDecorator(Surface vid): base(vid)
        {

        }

        public override void power(SdlDotNet.Input.KeyboardEventArgs args)
        {
            base.power(args);
        }
    }
}
