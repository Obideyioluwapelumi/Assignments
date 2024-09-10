


using ClassesAssignmentBarak.Model;

class Prgram
{
    static void Main(string[] args)
    {
        var Faculty = new List<Faculty>()
        {
            new Faculty
            {
                Id = Guid.NewGuid(),
                FacultyId = "FG-IB-SCI-101",           // Starting with the University ID code FGIB
                FacultyName = "Faculty of Sciences",
                DeanOfFaculty = "Professor S.K Mosafejo"
            }

            {
                Id = Guid.NewGuid(),
                FacultyId = "FG-IB-ENG-102",
                FacultyName = "Faculty of Engineering",
                DeanOfFaculty = "Professor L.S Konibaje"
            }

            {
                Id = Guid.NewGuid(),
                FacultyId = "FG-IB-ART-103",
                FacultyName = "Faculty of Art",
                DeanOfFaculty = "Professor M.O Enioriyo"
            }
        }


        var Department = new List<Department>()
        {
            new Department
            {
                Id = Guid.NewGuid(),
            }
        }

        var Lecturer = new List<Lecturer>()
        {
            new Lecturer
            {
                Id = Guid.NewGuid(),
            }
        }

        var Courses = new List<Courses>()
        {
            new Courses
            {
                Id = Guid.NewGuid(),
            }
        }

        var Student = new List<Student>()
        {
            new Courses
            {
                Id = Guid.NewGuid(),

            }
        }


    }

    
        Console.WriteLine();
    }
}