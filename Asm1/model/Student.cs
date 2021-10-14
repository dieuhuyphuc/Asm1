using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm1.model
{
    public class Student
    {
        public string name { get; set; }
        public string year { get; set; }
        public string image { get; set; }
    }
    public class StudentListMangager
    {
        public static List<Student> getbooks()
        {
            var student = new List<Student>();
            student.Add(new Student { name = "Dieu Huy Phuc", year = "2002", image = "Assets/Con-meo.jpg" });
            student.Add(new Student { name = "Dieu Huy Phuc", year = "2002", image = "Assets/Con-meo.jpg" });
            student.Add(new Student { name = "Dieu Huy Phuc", year = "2002", image = "Assets/Con-meo.jpg" });
            student.Add(new Student { name = "Dieu Huy Phuc", year = "2002", image = "Assets/Con-meo.jpg" });
            return student;
        }
    }
}
