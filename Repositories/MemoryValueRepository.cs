using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using simplewebapi.Models;

namespace simplewebapi.Repositories {
    public class MemoryShortMessageRepository : IShortMessageRepository
    {
        private ConcurrentDictionary<string, ShortMessageModel> values;

        public MemoryShortMessageRepository()
        {
             values = new ConcurrentDictionary<string, ShortMessageModel>();
        }

        public void Add(ShortMessageModel item)
        {
            item.Key = Guid.NewGuid().ToString();
            values[item.Key] = item;
        }

        public IEnumerable<ShortMessageModel> GetAll()
        {
            return values.Values;
        }
    }
}