using System.Collections.Generic;
using simplewebapi.Models;

namespace simplewebapi.Repositories {

    public interface IShortMessageRepository {
        void Add(ShortMessageModel value);

        IEnumerable<ShortMessageModel> GetAll();
    }
}