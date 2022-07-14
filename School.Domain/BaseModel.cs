using System;
using System.ComponentModel.DataAnnotations;

namespace School.Domain
{
    public abstract class BaseModel<TKey>
    {
        [Required]
        public TKey ID { get; set; }
    }
}
