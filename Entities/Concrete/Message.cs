﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        [StringLength(50)]
        public string Sender { get; set; }
        [StringLength(50)]
        public string Receiver { get; set; }
        [StringLength(100)]
        public string Subject { get; set; }
      
        public string MessageContent { get; set; }
       
        public DateTime MessageDate { get; set; }
    }
}
