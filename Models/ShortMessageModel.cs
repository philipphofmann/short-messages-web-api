using System;

namespace simplewebapi.Models
{
    public class ShortMessageModel {
        
        public String Key { get; set; }

        public DateTime Created { get; set; }

        public String Text { get; set; }
    }
}