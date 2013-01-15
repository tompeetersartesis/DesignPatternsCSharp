using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Les1110
{
    public class Publisher
    {
        List<IUpdater> enemies;

        public Publisher()
        {
            enemies = new List<IUpdater>();
        }

        public void AddVijand(IUpdater e)
        {
            enemies.Add(e);
        }

        public void UpdateEnemy(int heroX)
        {
            for(int i= 0;i<enemies.Count; i++)
            {
                enemies[i].UpdateData(heroX);
            }
        }
    }
}
