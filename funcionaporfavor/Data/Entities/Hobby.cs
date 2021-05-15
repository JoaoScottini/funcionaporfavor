using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace funcionaporfavor.Data.Entities
{
    public class Hobby
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
       
    }
}
