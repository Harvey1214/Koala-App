using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary;
using KoalaApp.Data.Common;

namespace KoalaApp.Data
{
    public class TwigsTempStorage
    {
        public List<Twig> Twigs { get; set; }
        private List<Twig> OrderedTwigs = new List<Twig>();

        public void Order()
        {
            OrderedTwigs.Clear();

            var rootTwigs = Twigs.Where(o => o.ParentId == null);
            foreach (var twig in rootTwigs)
            {
                Assign(twig, 0, 0);
            }

            Twigs = new List<Twig>(OrderedTwigs);
        }

        private void Assign(Twig twig, int relativeLevel, int absoluteLevel)
        {
            twig.AbsoluteLevel = absoluteLevel;
            twig.RelativeLevel = relativeLevel;
            OrderedTwigs.Add(twig);

            absoluteLevel++;
            relativeLevel++;

            if (relativeLevel >= UISettings.LevelStyles.Length)
            {
                relativeLevel = 0;
            }

            if (twig.ShowChildren)
            {
                var children = Twigs.Where(o => o.ParentId == twig.Id);
                foreach (var child in children)
                {
                    Assign(child, relativeLevel, absoluteLevel);
                }
            }
        }
    }
}
