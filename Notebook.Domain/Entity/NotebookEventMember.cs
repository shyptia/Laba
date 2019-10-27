using Notebook.Domain.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notebook.Domain.Entity
{
    public class NotebookEventMember : NotebookBaseEntity
    {
        /// <summary>
        /// First name event member
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name event member
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Organization name
        /// </summary>
        public string Organization { get; set; }
    }
}
