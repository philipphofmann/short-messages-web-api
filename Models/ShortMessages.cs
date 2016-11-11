using System;
using System.Collections.Generic;

namespace simplewebapi.Models
{
    public class ShortMessages {
        public List<ShortMessageModel> Messages { get; set; }

        public ShortMessages() {
            Messages = new List<ShortMessageModel>();
        }
    }
}