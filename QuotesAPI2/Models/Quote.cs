﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuotesAPI2.Models
{
    public class Quote
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public DateTime createdAt { get; set; }

    }
}