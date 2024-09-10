using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAssignmentBarak.Model
{
    internal class Department
    {
        public Guid Id { get; set; }

        public string DepartmentName { get; set; }

        public string DepartmentCode { get; set; }  // CSC, AGP

        public string DepertmentFaculty { get; set; }

        public string HeadOfDepartment { get; set; }

        public bool DepartmentalBus { get; set; }

        public string DepartmentalEmail { get; set; }

        public string DepartmentalContactLine { get; set; }

        public string DepartmentWebsite { get; set; }

        public int NumberOfGraduate { get; set; }

    }
}
