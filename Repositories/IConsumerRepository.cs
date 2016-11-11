using System;
using System.Collections.Generic;
using simplewebapi.Models;

namespace simplewebapi.Repositories {

    public interface IConsumerRepository {
        
        void Update(ConsumerModel consumer);

        ConsumerModel Get(String consumerKey);

        List<ShortMessageModel> GetAll(String consumerKey);
    }
}