using System;
using System.Collections.Generic;

namespace dropdowndata.Mod.Ent
{
    public partial class TblEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string EmployeeCode { get; set; }
        public string Gender { get; set; }
        public int? Designation { get; set; }
        public int? Department { get; set; }
        public DateTime? Dob { get; set; }
        public int? Salary { get; set; }

        public virtual TblDepartment DepartmentNavigation { get; set; }
        public virtual TblDesignation DesignationNavigation { get; set; }
    }
}
