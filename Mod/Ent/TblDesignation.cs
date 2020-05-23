using System;
using System.Collections.Generic;

namespace dropdowndata.Mod.Ent
{
    public partial class TblDesignation
    {
        public TblDesignation()
        {
            TblEmployee = new HashSet<TblEmployee>();
        }

        public int DesignationId { get; set; }
        public string DesignationName { get; set; }

        public virtual ICollection<TblEmployee> TblEmployee { get; set; }
    }
}
