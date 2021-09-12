using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TaskList.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DateCreated { get; set; }
        [ScaffoldColumn(false)]
        public DateTime LastModified { get; set; }
        [ScaffoldColumn(false)]
        [StringLength(255)]
        public string CreatedById { get; set; }
        [ScaffoldColumn(false)]
        [StringLength(255)]
        public string ModifiedById { get; set; }
        [ScaffoldColumn(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
