using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary;
using KoalaApp.Data.Common;
using KoalaApp.Shared;
using KoalaApp.Pages;

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

        public Tree Tree { get; set; }
        public NestedStructure NestedStructure { get; set; }
        public SearchSort SearchSort { get; set; }

        /// <summary>
        /// Twigs sorted for the search window
        /// </summary>
        public List<Twig> SortedTwigs { get; set; } = new List<Twig>();
        public SortBy SortBy { get; set; } = SortBy.DUEDATE_LOWTOHIGH;

        private void Sort()
        {
            SortedTwigs.Clear();

            var rootTwigs = Twigs.Where(o => o.ParentId == null);
            foreach (var twig in rootTwigs)
            {
                AssignForSort(twig);
            }

            switch (SortBy)
            {
                case SortBy.DUEDATE_LOWTOHIGH:
                    SortedTwigs = SortedTwigs.OrderBy(o => o.DueDate).ToList();
                    break;
                case SortBy.DUEDATE_HIGHTOLOW:
                    SortedTwigs = SortedTwigs.OrderByDescending(o => o.DueDate).ToList();
                    break;
                case SortBy.COMPLETEDDATE_LOWTOHIGH:
                    SortedTwigs = SortedTwigs.OrderBy(o => o.CompletedDate).ToList();
                    break;
                case SortBy.COMPLETEDDATE_HIGHTOLOW:
                    SortedTwigs = SortedTwigs.OrderByDescending(o => o.CompletedDate).ToList();
                    break;
                case SortBy.PRIORITY_HIGHTOLOW:
                    SortedTwigs = SortedTwigs.OrderByDescending(o => o.Priority).ToList();
                    break;
                case SortBy.PRIORITY_LOWTOHIGH:
                    SortedTwigs = SortedTwigs.OrderBy(o => o.Priority).ToList();
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
            UpdateSearchSort();
        }

        private void Assign(Twig twig, int relativeLevel, int absoluteLevel)
        {
            if (NestedStructure.Project.ShowCompleted == false && twig.State == State.COMPLETED)
            {
                return;
            }

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

        private void AssignForSort(Twig twig)
        {
            if (NestedStructure.Project.ShowCompleted == false && twig.State == State.COMPLETED)
            {
                return;
            }

            SortedTwigs.Add(twig);

            var children = Twigs.Where(o => o.ParentId == twig.Id);
            foreach (var child in children)
            {
                AssignForSort(child);
            }
        }

        public void UpdateSearchSort()
        {
            if (SearchSort != null)
            {
                SearchSort.Update();
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
