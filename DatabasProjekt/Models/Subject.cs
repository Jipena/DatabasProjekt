using System;
using System.Collections.Generic;

namespace DatabasProjekt.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Grades = new HashSet<Grade>();
        }

        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
    }
}
