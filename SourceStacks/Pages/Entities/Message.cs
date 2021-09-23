﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStacks.Entities
{
    public class Message : Entity
    {
        public bool Selected { get; set; }
        public DateTime CreateTime { get; set; }
        public string Content { get; set; }
    }
}
