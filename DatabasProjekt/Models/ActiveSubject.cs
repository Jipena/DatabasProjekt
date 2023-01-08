using System;
using System.Collections.Generic;

namespace DatabasProjekt.Models
{
    public partial class ActiveSubject
    {
        public int? FkSubjectId { get; set; }
        public int? FkClassId { get; set; }
        public int? FkPersonnelId { get; set; }

        public virtual Class? FkClass { get; set; }
        public virtual Personnel? FkPersonnel { get; set; }
        public virtual Subject? FkSubject { get; set; }
    }
}
