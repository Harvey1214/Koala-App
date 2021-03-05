using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary
{
    public class Twig : ITwig
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; }
        public State State { get; set; }
    }
}
