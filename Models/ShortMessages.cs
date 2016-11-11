using System;
using System.Collections.Generic;

namespace simplewebapi.Models
{
    public class ShortMessages {
        public ShortMessages() {
            Messages = new List<ShortMessageModel>();
        }
        
        public List<ShortMessageModel> Messages { get; set; }
    }
}