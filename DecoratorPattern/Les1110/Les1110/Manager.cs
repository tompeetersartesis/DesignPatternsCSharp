using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SdlDotNet.Graphics;
using SdlDotNet.Core;
using SdlDotNet.Graphics.Sprites;


namespace Les1110
{
    public class Manager
    {
        private Surface mVideo;
        private Achtergrond mAchtergrond;
        private Hero mHero;
        private Enemy mEnemy;
        private Enemy2 mEnemy2;
        public  SpriteCollection collection;
        private Publisher p;
        private IState theState;

       
        public Manager()
        {
            mVideo = Video.SetVideoMode(800, 300); 
            p = new Publisher();

            mAchtergrond = new Achtergrond(mVideo);
            mEnemy = new Enemy(mVideo);
            mEnemy2 = new Enemy2(mVideo);
            p.AddVijand(mEnemy2);
            p.AddVijand(mEnemy);
            mHero = new Hero(mVideo, p);
            mHero = new ShootHero(mVideo, mHero);
            mHero = new FlyHero(mVideo, mHero);

            //Terug naar origine hero!
            ((FlyHero)mHero).theHero = null;
            mHero = new ShootHero(mVideo, mHero);
            collection = new SpriteCollection();
            collection.Add(mHero);
            //collection.Add(shootHero);
            collection.Add(mEnemy);
            collection.Add(mEnemy2);

            Events.KeyboardDown += Events_KeyboardDown;
            //collection.EnableTickEvent();
            //collection.EnableKeyboardEvent();


            init();

            Events.Tick += new EventHandler<TickEventArgs>(Events_Tick);
            Events.Run();

        }

       

        private void init()
        {
            theState = new Start(this);
        }

        void Events_KeyboardDown(object sender, SdlDotNet.Input.KeyboardEventArgs e)
        {
            if (e.Key == SdlDotNet.Input.Key.N)
                theState = new Game(this);
        }
       
        void Events_Tick(object sender, TickEventArgs e)
        {
            theState.Draw();
            mVideo.Update();            
        }
    }
}
