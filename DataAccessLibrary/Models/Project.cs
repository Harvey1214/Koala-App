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
    }
}
