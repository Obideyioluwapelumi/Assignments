using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAssignmentBarak.Model
{
    internal class Faculty
    {
        public Guid Id { get; set; }

        public int FacultyId { get; set; }

        public string FacultyName { get; set; }

        public DateTime DateOfEstablishment { get; set; }

        public int NumberOfDepartments { get; set; }

        public string LocationOfFaculty {  get; set; }

        public string DeanOfFaculty { get; set; }

        public int FacultyContactLine { get; set; }

        public string FacultyEmail { get; set; }

        public string FacultyWebsite { get; set; }

        public int NumberOfProfessors  { get; set; }

        public bool FacultyBus { get; set; }
    }
}
