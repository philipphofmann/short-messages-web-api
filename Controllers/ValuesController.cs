using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using simplewebapi.Models;
using simplewebapi.Repositories;

namespace simplewebapi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IShortMessageRepository valueRepository;
        private static readonly String CONSUMER_KEY = "key";
        private static readonly String CONSUMER_SECRET = "secret";

        public ValuesController(IShortMessageRepository valueRepository) {
            this.valueRepository = valueRepository;
        }
        
        // GET api/values
        [HttpGet]
        public IEnumerable<ShortMessageModel> Get()
        {
            return valueRepository.GetAll();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]IncomingMessageModel incomingMessage)
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
