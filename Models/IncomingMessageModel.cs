using System;

namespace simplewebapi.Models
{
    public class IncomingMessageModel {
        public String ConsumerKey { get; set;}
        public String ConsumerSecret { get; set;}
        public String Text { get; set; }
    }
}