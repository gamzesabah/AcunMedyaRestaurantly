﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaRestaurantly.Entities
{
    public class Chef
    {
        public int ChefId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
    }
}