using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace funcionaporfavor.Data.Entities
{
    public class Hobby
    {

        public Guid id { get; set; }
        public string name { get; set; }
        public DateTime createdAt { get; set; }

    }
}
