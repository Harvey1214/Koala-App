using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary
{
    public class Project : IProject
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastOpened { get; set; }
        public bool ShowCompleted { get; set; }
        public SortBy SortBy { get; set; }

        public Dimensions EditWindowDimensions { get; set; }
        public string EditWindow 
        { 
            set 
            {
                EditWindowDimensions = new Dimensions(value);
            } 
        }
        public Dimensions RightContainerDimensions { get; set; }
        public string RightContainer
        {
            set
            {
                RightContainerDimensions = new Dimensions(value);
            }
        }

        public int DescriptionFieldWidth { get; set; }
        public int SearchSortWindowWidth { get; set; }
    }
}
