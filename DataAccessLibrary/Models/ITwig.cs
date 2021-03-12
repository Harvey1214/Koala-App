using System;

namespace DataAccessLibrary
{
    interface ITwig
    {
        DateTime CompletedDate { get; set; }
        string Description { get; set; }
        DateTime DueDate { get; set; }
        int Id { get; set; }
        int Priority { get; set; }
        int ProjectId { get; set; }
        State State { get; set; }
        string Title { get; set; }
        int? ParentId { get; set; }
    }
}