using School.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repository
{
    public class TeacherRepository : BaseRepository<Teacher, int>
    {
        public Teacher[] GetAllTeachersByStudent(string studentName)
        {
            Teacher[] array;
            using (SchoolDbContext dbContext = new SchoolDbContext())
            {
                var tempTeachers = from p in dbContext.Pupils
                           join pc in dbContext.TeachersPupils on p.ID equals pc.PupilID
                           join t in dbContext.Teachers on pc.TeacherID equals t.ID
                           where pc.PupilID == p.ID && p.FirstName == studentName
                           select t;
                int i = 0;
                var teachers = tempTeachers.Distinct();
                array = new Teacher[teachers.Count()];
                foreach (var teacher in teachers)
                {
                    array[i] = teacher;
                    i++;
                }
                dbContext.SaveChanges();
            }
            return array;
        }
    }
}
