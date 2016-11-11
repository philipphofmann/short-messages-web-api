using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using simplewebapi.Models;
using System.Linq;
using simplewebapi.Repositories;

namespace simplewebapi.Controllers
{
    [Route("api/[controller]")]
    public class ShortMessagesController : Controller
    {
        private IConsumerRepository valueRepository;

        public ShortMessagesController(IConsumerRepository valueRepository) {
            this.valueRepository = valueRepository;
        }
        
        // GET api/ShortMessages/{consumerkey}
        [HttpGet("{consumerkey}")]
        public ShortMessages Get(String consumerkey)
        {
            var shortMessages = new ShortMessages();
            
            if(string.IsNullOrEmpty(consumerkey)) {
                return shortMessages;
            }
            
            var allShortMessages = valueRepository.GetAll(consumerkey);
        
            if(allShortMessages != null) {
                shortMessages.Messages = allShortMessages
                    .OrderByDescending(value => value.Created).ToList();
            }
            
            return shortMessages;
        }

        // POST api/ShortMessages
        [HttpPost]
        public ShortMessageModel Post([FromBody]IncomingShortMessageModel incomingMessage)
        {
            if(incomingMessage == null) {
                return new ShortMessageModel();
            }
                
            ShortMessageModel shortMessageModel = new ShortMessageModel() {
                Created = DateTime.Now,
                Text = incomingMessage.Text
            };

            var consumer = valueRepository.Get(incomingMessage.ConsumerKey);

            //Consumer does not exist
            if(consumer == null) {
                consumer = new ConsumerModel();
                consumer.Key = incomingMessage.ConsumerKey;
                consumer.Secret = incomingMessage.ConsumerSecret;

                consumer.ShortMessages.Add(shortMessageModel);
                valueRepository.Update(consumer);
            } else {
                //Consumer already exists, check secret
                if(consumer.Secret == incomingMessage.ConsumerSecret) {
                    consumer.ShortMessages.Add(shortMessageModel);
                    valueRepository.Update(consumer);
                }
            }

            return shortMessageModel;
        }
    }
}
