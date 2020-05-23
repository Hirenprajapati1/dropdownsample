using System;
using System.Collections.Generic;

namespace dropdowndata.Mod.Ent
{
    public partial class TblDepartment
    {
        public TblDepartment()
        {
            TblEmployee = new HashSet<TblEmployee>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<TblEmployee> TblEmployee { get; set; }
    }
}
