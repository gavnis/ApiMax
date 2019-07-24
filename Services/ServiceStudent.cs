using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaApi
{
    public class ServiceStudent : IServiceStudent
    {

        private static List<Student> list;
        public ServiceStudent()
        {
            list = new List<Student>();
            list.Add(new Student()
            {
                ID = 1,
                Name = "Marcelo",
                Surname = "Rojas",
                Age = 18,
                Especialidad = "IT"

            }
            );
        }
        public List<Student> GetAll()
        {
            return list;
        }
        public Student Get(int id)
        {
            return list.FirstOrDefault(b => b.ID == id);
        }
        public void Save(Student student)
        {
            this.Delete(student.ID);
            list.Add(student);
        }
        public void Delete(int id)
        {
            var student = this.Get(id);
            if (student != null)
            {
                list.Remove(student);
            }
        }
    }
}