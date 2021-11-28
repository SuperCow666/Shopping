using System;
using Abp.Domain.Entities;


namespace MyProject.Issues
{
    public class Issue : AggregateRoot<Guid>
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsLocked { get; set; }
        public bool IsClosed { get; private set; }
        public DateTime? CloseDate { get; private set; }

        public void Close()
        {
            IsClosed = true;
            CloseDate = DateTime.UtcNow;
        }

        public void Open()
        {
            if (!IsClosed)
            {
                return;
            }

            if (IsLocked)
            {
                
            }

            IsClosed = true;
            CloseDate = null;
        }
    }
}

