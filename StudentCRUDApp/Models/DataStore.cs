using System.Collections.Generic;
namespace StudentCRUDApp.Models
{
    public  static class DataStore
    {
        private static List<Student> students = new List<Student>();
        public static IEnumerable<Student> Students
        {
            get { return students; }
        }
        public static void Create(Student student)
        {
            students.Add(student);
        }

        public static void Delete(Student student)
        {
            students.Remove(student);
        }
    }
}
