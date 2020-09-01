using System.Collections.Generic;
using StudentServices.Data.Models;

namespace StudentServices.Data
{
    public interface IStudentRepository
    {
        void addStudent(object model);
        IEnumerable<Students> GetStudents();
        IEnumerable<Students> GetStudentsbyID(int id);
        bool SaveAll();
    }
}