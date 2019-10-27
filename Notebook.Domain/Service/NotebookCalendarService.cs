using Notebook.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notebook.Domain.Service
{
    public class NotebookCalendarService
    {
        private readonly List<NotebookEvent> events = new List<NotebookEvent>();
        public List<NotebookEventMember> allMember = new List<NotebookEventMember>();

        public NotebookCalendarService()
        {
            GenerateDefaultMembers();
        }

        public NotebookCalendarService(List<NotebookEventMember> members)
        {
            allMember = members;
        }

        private void GenerateDefaultMembers()
        {
            var fnames = new string[] { "Ivan", "Andrew", "Daniel", "Anton", "Serhii", "Owen", "Sophia", "Ira", "Anna" };
            var lnames = new string[] { "Smith", "Jones", "Taylor", "Brown", "Williams", "Oliynyk", "Moroz" };
            var organizations = new string[] { "UNICEF", "UNESCO" };
            var rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                var phone = new StringBuilder(12);
                phone = phone.Append("380-");
                phone = phone.Append(String.Format("{0:D3}", rnd.Next(0, 743)));
                phone = phone.Append("-");
                phone = phone.Append(String.Format("{0:D4}", rnd.Next(0, 10000)));
                allMember.Add(new NotebookEventMember
                {
                    ID = i,
                    FirstName = fnames[rnd.Next(0, fnames.Length)],
                    LastName = lnames[rnd.Next(0, lnames.Length)],
                    Organization = organizations[rnd.Next(0, organizations.Length)],
                    Phone = phone.ToString()
                });
            }
        }

        /// <summary>
        /// Add new event into calendar
        /// </summary>
        /// <param name="notebookEvent"></param>
        public void AddEvent(NotebookEvent notebookEvent)
        {
            ValidateEvent(notebookEvent);
            events.Add(notebookEvent);
        }

        /// <summary>
        /// Add list of events into calendar
        /// </summary>
        /// <param name="notebookEvent"></param>
        public void AddEvents(List<NotebookEvent> notebookEvents)
        {
            foreach (var item in notebookEvents)
                AddEvent(item);
        }

        /// <summary>
        /// Validate event model
        /// </summary>
        /// <returns>true if not valid, false if valid</returns>
        private void ValidateEvent(NotebookEvent notebookEvent)
        {
            if (string.IsNullOrEmpty(notebookEvent.Name) && string.IsNullOrEmpty(notebookEvent.Description) && notebookEvent.Date == null)
                throw new ArgumentException($"Event not valid: {notebookEvent}. Name, description, priority, event type, day and time are required, please check.");

            if(notebookEvent.EventType == Enum.NotebookEventType.WithMembers && notebookEvent.Members.Count == 0)
                throw new ArgumentException($"Event not valid: {notebookEvent}. If you choose event type with members, please add members.");
        }
    }
}
