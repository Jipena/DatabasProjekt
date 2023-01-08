using System;
using System.Collections.Generic;

namespace DatabasProjekt.Models
{
    public partial class Personnel
    {
        public Personnel()
        {
            Grades = new HashSet<Grade>();
        }

        public int PersonnelId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? City { get; set; }
        public string? Position { get; set; }
        public DateTime? HiredDate { get; set; }
        public int? Salary { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
    }
}
