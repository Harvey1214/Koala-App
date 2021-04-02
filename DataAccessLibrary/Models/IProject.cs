using System;

namespace DataAccessLibrary
{
    interface IProject
    {
        DateTime DateCreated { get; set; }
        int Id { get; set; }
        DateTime LastOpened { get; set; }
        string Name { get; set; }
        int UserId { get; set; }
        bool ShowCompleted { get; set; }
    }
}