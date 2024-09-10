using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAssignmentBarak.Model
{
    internal class Courses
    {
        public Guid Id { get; set; }
        public string CourseName { get; set; }      // Intro to Organic Chem
        public string CourseCode { get; set; }      // CHEM108
        public int CourseLevel { get; set; }
        public int CourseUnit { get; set; }      
        public string CourseDescription { get; set; }
        public string CourseCreditUnit { get; set; }
        public string CourseLectureHours { get; set; }
        public string CoursePrerequisite { get; set; }
        public string CourseDepartment { get; set; }
        public string CourseFaculty { get; set; }
        public int SemesterOfferingCourse { get; set; }
        public string CourseAssessmentMethod { get; set; }      // Project,Exams,  
    }
}
