﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Author { get; set; }
    }
}