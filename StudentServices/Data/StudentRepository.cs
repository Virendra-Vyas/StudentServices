using StudentServices.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentServices.Data
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentContext _ctx;

        public StudentRepository(StudentContext ctx)
        {
            _ctx = ctx;
        }

        public void addStudent(object model)
        {
            _ctx.Add(model);
        }

        public IEnumerable<Students> GetStudents()
        {
            return _ctx.students
                    .ToList();
        }

        public IEnumerable<Students> GetStudentsbyID(int id)
        {
            return _ctx.students
                  .Where(s => s.Id == id)
                  .OrderBy(s => s.Id)
                  .ToList();
        }

        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }
    }
}
