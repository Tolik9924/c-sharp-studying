﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopics
{
    public class Book : Product
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
    }
}
