using System.Collections.Generic;
using System.Linq;
namespace PracticaApi
{
    public interface IServiceStudent
    {
        List<Student> GetAll();
        Student Get(int id);
        void Save(Student temperatura);
        void Delete (int id);
    }
}
