using QuotesAPI2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuotesAPI2.Data
{
    public class QuotesDbContext :DbContext
    {
        public DbSet<Quote> Quotes { get; set; }
    }
}