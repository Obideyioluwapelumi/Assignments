using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAssignmentBarak.Model
{
    internal class Student
    {
        public Guid Id { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentOtherName { get; set; }
        public string StudentAdmissionNumber { get; set; }
        public int StudentYearOfAdmission { get; set; }
        public int StudentYearOfGraduation { get; set; }
        public string StudentEnollmentStatus { get; set; }      // Active, deferred, graduated, withdrawn
        public int StudentMatricNumber { get; set; }
        public int StudentAcademicLevel { get; set; }
        public string StudentDepartment { get; set; }
        public string StudentFaculty { get; set; }
        public bool StudentStayOnCampus { get; set; }
        public bool FinancialAidOrLoan { get; set; }
        public string Gender { get; set; }
        public DateTime StudentDateOfBirth { get; set; }
        public string Nationality { get; set; }
        public int StudentContactLine { get; set; }
        public int StudentEmergencyContact { get; set; }
        public string StudentEmail { get; set; }
    }
}
