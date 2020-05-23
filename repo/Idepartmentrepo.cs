using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dropdowndata.repo
{
    public interface Idepartmentrepo
    {
        public List<Mod.commen.TblDepartment> GetDepartment();
    }
}
