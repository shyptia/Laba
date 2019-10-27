using Notebook.Domain.Entity.Base;
using System;

namespace Notebook.Domain.Entity
{
    public class NotebookUser : NotebookBaseEntity
    {
        /// <summary>
        /// User name who run application (usually windows owner name)
        /// </summary>
        public string Name { get; set; } = Environment.UserName;
    }
}
