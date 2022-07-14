using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain
{
    public class TeachersPupils : BaseModel<int>
    {
        public int PupilID { get; set; }

        public int TeacherID { get; set; }

        public Teacher Teacher { get; set; }
        public Pupil Pupil { get; set; }
    }
}
