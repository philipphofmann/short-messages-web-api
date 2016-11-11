using System;
using System.Collections.Generic;

namespace simplewebapi.Models
{
    public class ConsumerModel {
        public String Key { get; set;}
        public String Secret { get; set;}
        public List<ShortMessageModel> ShortMessages { get; set; }

        public ConsumerModel() {
            ShortMessages = new List<ShortMessageModel>();
        }
    }
}