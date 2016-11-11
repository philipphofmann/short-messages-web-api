using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using simplewebapi.Models;

namespace simplewebapi.Repositories {
    public class MemoryConsumerRepository : IConsumerRepository
    {
        private ConcurrentDictionary<string, ConsumerModel> consumers;

        public MemoryConsumerRepository()
        {
             consumers = new ConcurrentDictionary<string, ConsumerModel>();
        }

        public  void Update(ConsumerModel consumer) {
            
            if(consumer == null) {
                return;
            }
            
            consumers[consumer.Key] = consumer;
        }


        public ConsumerModel Get(String consumerKey) {
            if(consumers.ContainsKey(consumerKey)) {
                var consumer = consumers[consumerKey];
                return consumer;
            }

            return null;
        }

        public List<ShortMessageModel> GetAll(String consumerKey)
        {
            if(consumers.ContainsKey(consumerKey)) {
                var consumer = consumers[consumerKey];
                return consumer.ShortMessages;
            }

            return new List<ShortMessageModel>();
        }
    }
}