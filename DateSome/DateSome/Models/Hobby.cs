using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DateSome.Models
{
    public class Hobby
    {
        public int Id { get; set; }
        [Display(Name = "Hobby")]
        [Required]
        public string Name { get; set; }
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
