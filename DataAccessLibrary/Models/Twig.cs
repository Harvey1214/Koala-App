using DataAccessLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary
{
    public class Twig : ITwig
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; } = "New Twig";
        public DateTime DueDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; }
        public State State { get; set; }
        public int? ParentId { get; set; }

        public int AbsoluteLevel { get; set; }
        public int RelativeLevel { get; set; }
        public bool ShowChildren { get; set; } = true;

        public Twig Copy()
        {
            return (Twig)this.MemberwiseClone();
        }

        public void Encrypt()
        {
            Title = Security.Encrypt(Title);
            Description = Security.Encrypt(Description);
        }

        public void Decrypt()
        {
            Title = Security.Decrypt(Title);
            Description = Security.Decrypt(Description);
        }
    }
}
