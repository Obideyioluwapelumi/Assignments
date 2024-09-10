using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAssignmentBarak.Model
{
    internal class Lecturer
    {
        public Guid Id { get; set; }

        public int LecturerEmployeeID { get; set; }

        public string LecturerFirstName { get; set; }

        public string LecturerLastName { get; set; }

        public string LecturerAcademicTitle { get; set; }   //Dr., Prof

        public int LecturerYearOfExperience { get; set; }

        public string LecturerAreaOfExpertise { get; set; }

        public int LecturerNumberOfPublication { get; set; }

        public int LecturerNumberOfCitation { get; set; }

        public string LecturerDepartment { get; set; }

        public string LecturerFaculty { get; set; }

        public string LecturerCourseTaken { get; set; }

        public string LecturerEmploymentStatus { get; set; }

        public DateTime LecturerDateOfHire { get; set; }

        public string LecturerGender { get; set; }

        public DateTime LecturerDateOfBirth { get; set; }

        public string LecturerNationality { get; set; }

        public string LecturerResidentialAddress { get; set; }
    }
}
