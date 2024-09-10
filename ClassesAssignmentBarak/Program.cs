


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

            }
        }

        var Courses = new List<Courses>()
        {
            new Courses
            {

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




    static void Guid GenerateRandomId()
            Guid.NewGuid();
        
        Console.WriteLine(
    }
}