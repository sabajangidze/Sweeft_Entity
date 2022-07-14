using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain
{
    public class Teacher : BaseModel<int>
    {
        [Required]
        [MaxLength(10)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(15)]
        public string Gender { get; set; }

        [Required]
        [MaxLength(20)]
        public string Subject { get; set; }

        public virtual ICollection<TeachersPupils> TeachersPupils { get; set; }

        //public virtual ICollection<Pupil> Pupils { get; set; }
    }
}
