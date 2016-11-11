using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using simplewebapi.Models;
using System.Linq;
using simplewebapi.Repositories;

namespace simplewebapi.Controllers
{
    [Route("api/[controller]")]
    public class ShortMessageController : Controller
    {
        private IShortMessageRepository valueRepository;
        private static readonly String CONSUMER_KEY = "key";
        private static readonly String CONSUMER_SECRET = "secret";

        public ShortMessageController(IShortMessageRepository valueRepository) {
            this.valueRepository = valueRepository;
        }
        
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var allShortMessages = valueRepository.GetAll();
            
            var shortMessages = new ShortMessages();
            if(allShortMessages != null) {
                shortMessages.Messages = allShortMessages.ToList();
            }
            
            return Json(shortMessages);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]IncomingShortMessageModel incomingMessage)
        {
            if(incomingMessage != null && incomingMessage.ConsumerKey == CONSUMER_KEY
                    && incomingMessage.ConsumerSecret == CONSUMER_SECRET) {

                ShortMessageModel shortMessageModel = new ShortMessageModel() {
                    Created = DateTime.Now,
                    Text = incomingMessage.Text
                };
                
                valueRepository.Add(shortMessageModel);
            }  
        }
    }
}
