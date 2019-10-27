using Notebook.Domain.Entity;
using Notebook.Domain.Service;
using System;

namespace Notebook.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var notebook = new NotebookCalendarService();

            var noteEvent = new NotebookEvent
            {
                ID = 0,
                Date = DateTime.Now,
                Description = "First",
                EventType = Domain.Enum.NotebookEventType.Reminder,
                Name = "First",
                Priority = Domain.Enum.NotebookEventPriority.Low
            };

            notebook.AddEvent(noteEvent);

            noteEvent = new NotebookEvent
            {
                ID = 1,
                Date = DateTime.Now.AddDays(1),
                Description = "Second",
                EventType = Domain.Enum.NotebookEventType.WithMembers,
                Name = "Second",
                Members = new System.Collections.Generic.List<NotebookEventMember>
                {
                    notebook.allMember[0],
                    notebook.allMember[1],
                },
                Priority = Domain.Enum.NotebookEventPriority.Medium
            };

            notebook.AddEvent(noteEvent);

        }
    }
}
