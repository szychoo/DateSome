using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DateSome.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Nickname")]
        public string Nickname { get; set; }
        [Required]
        [Display(Name = "Wiek")]
        public int Age { get; set; }
        [ForeignKey("CityId")]
        public virtual City City { get; set; }
        public int CityId { get; set; }
        [Display(Name = "Opis")]
        public string Description { get; set; }
        [Display(Name = "Opis wymarzonego partnera")]
        public string PartnerDescription { get; set; }
        [Display(Name="Hobby")]
        public virtual ICollection<Hobby> Hobbies { get; set; }
        public virtual ICollection<Message> ReceivedMessages { get; set; }
        public virtual ICollection<Message> SentMessages { get; set; }
        public byte[] Picture { get; set; }
    }
}