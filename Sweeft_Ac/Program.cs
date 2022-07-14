using School.Repository;
using System;

namespace Sweeft_Ac
{
    class Program
    {
        static void Main(string[] args)
        {
            TeacherRepository teacher = new TeacherRepository();
            var temp = teacher.GetAllTeachersByStudent("Giorgi");
            foreach (var item in temp)
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }
}
