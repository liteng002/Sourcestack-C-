using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStacks.Entities
{
    public class Keyword : Entity
    {
        public string Name { get; set; }

        public static implicit operator Keyword(List<Keyword> v)
        {
            throw new NotImplementedException();
        }
    }
}
