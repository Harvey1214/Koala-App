using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary;
using KoalaApp.Data.Common;
using KoalaApp.Shared;

namespace KoalaApp.Data
{
    public class TwigsTempStorage
    {
        /// <summary>
        /// Twigs ordered for the nested structure
        /// </summary>
        public List<Twig> Twigs { get; set; }
        public List<Twig> OrderedTwigs { get; set; } = new List<Twig>();

        public Twig CopiedTwig { get; set; }

        public NestedStructure NestedStructure { get; set; }

        /// <summary>
        /// Twigs sorted for the search window
        /// </summary>
        public List<Twig> SortedTwigs { get; set; } = new List<Twig>();
        public SortBy SortBy { get; set; } = SortBy.DUEDATE_LOWTOHIGH;

        private void Sort()
        {
            SortedTwigs = new List<Twig>(Twigs);

            switch (SortBy)
            {
                case SortBy.DUEDATE_LOWTOHIGH:
                    SortedTwigs.OrderBy(o => o.DueDate);
                    break;
                case SortBy.DUEDATE_HIGHTOLOW:
                    SortedTwigs.OrderByDescending(o => o.DueDate);
                    break;
                case SortBy.PRIORITY_HIGHTOLOW:
                    SortedTwigs.OrderByDescending(o => o.Priority);
                    break;
                case SortBy.PRIORITY_LOWTOHIGH:
                    SortedTwigs.OrderBy(o => o.Priority);
                    break;
            }
        }

        public void Order()
        {
            OrderedTwigs.Clear();

            var rootTwigs = Twigs.Where(o => o.ParentId == null);
            foreach (var twig in rootTwigs)
            {
                Assign(twig, 0, 0);
            }

            Sort();

            UpdateNestedStructure();
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

        public void UpdateNestedStructure()
        {
            if (NestedStructure != null)
            {
                NestedStructure.Update();
            }
        }
    }
}
