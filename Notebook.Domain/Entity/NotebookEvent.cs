using Notebook.Domain.Entity.Base;
using Notebook.Domain.Enum;
using System;
using System.Collections.Generic;

namespace Notebook.Domain.Entity
{
    public class NotebookEvent : NotebookBaseEntity
    {
        /// <summary>
        /// Describe event goal
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Event name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Priority event (low, medium, high)
        /// </summary>
        public NotebookEventPriority Priority { get; set; }

        /// <summary>
        /// Event type (with members or just reminder)
        /// </summary>
        public NotebookEventType EventType { get; set; }

        /// <summary>
        /// Date and time of event
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// List of event member
        /// </summary>
        public List<NotebookEventMember> Members { get; set; } = new List<NotebookEventMember>();

        public override string ToString()
        {
            return $"Event: {Name}, Description: {Description}, Priority: {Priority}, Day: {Date.ToShortDateString()},Time: {Date.ToShortTimeString()} , Count of members: {Members.Count}";
        }
    }
}
