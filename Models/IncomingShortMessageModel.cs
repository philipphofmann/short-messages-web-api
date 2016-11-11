using System;

namespace simplewebapi.Models
{
    public class IncomingShortMessageModel {
        public String ConsumerKey { get; set;}
        public String ConsumerSecret { get; set;}
        public String Text { get; set; }
    }
}