using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DateSome.Models
{
    public class City
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Miasto")]
        public string Name { get; set; }
        public virtual ICollection<UserProfile> UserProfiles { get; set; } 
    }
}
