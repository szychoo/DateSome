using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DateSome.Models
{
    public class Message
    {
        public int Id { get; set; }
        [ForeignKey("SenderId")]
        public virtual UserProfile Sender { get; set; }
        public int SenderId { get; set; }
        [ForeignKey("ReceiverId")]
        public virtual UserProfile Receiver { get; set; }
        public int ReceiverId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Read { get; set; }
        public int Replied { get; set; }
    }
}
