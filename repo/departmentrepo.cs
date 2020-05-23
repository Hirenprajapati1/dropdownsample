using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dropdowndata.Mod;
using dropdowndata.Mod.Ent;

namespace dropdowndata.repo
{
    public class departmentrepo
    {

        public List<Mod.commen.TblDepartment> GetDepartment()
        {
            List<Mod.commen.TblDepartment> departments = new List<Mod.commen.TblDepartment>();
            try
            {
                using (var dBContext = new database1Context())
                {
                    Mod.commen.TblDepartment department1;
                    foreach (var dept in dBContext.TblDepartment)
                    {
                        department1 = new Mod.commen.TblDepartment();
                        department1.DepartmentId = dept.DepartmentId;
                        department1.DepartmentName = dept.DepartmentName;
                        departments.Add(department1);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
            return departments;

        }
    }
}
