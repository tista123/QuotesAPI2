using QuotesAPI2.Data;
using QuotesAPI2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuotesAPI2.Controllers
{
    public class QuotesController : ApiController
    {
        // GET: api/Quotes
        QuotesDbContext quotesDbcontext = new QuotesDbContext();
        public IEnumerable<Quote> Get()
        {
            return quotesDbcontext.Quotes;
        }

        // GET: api/Quotes/5
        public Quote Get(int id)
        {
            var q = quotesDbcontext.Quotes.Find(id);
            return q;
        }

        // POST: api/Quotes
        public void Post([FromBody]Quote q)
        {
            quotesDbcontext.Quotes.Add(q);
            quotesDbcontext.SaveChanges();
        }

        // PUT: api/Quotes/5
        public void Put(int id, [FromBody]Quote quote)
        {
            var entity = quotesDbcontext.Quotes.FirstOrDefault(q => q.Id == id);
            entity.Title = quote.Title;
            entity.Author = quote.Author;
            entity.Description = quote.Description;
            quotesDbcontext.SaveChanges();
        }

        // DELETE: api/Quotes/5
        public void Delete(int id)
        {
            var quote=quotesDbcontext.Quotes.Find(id);
            quotesDbcontext.Quotes.Remove(quote);
            quotesDbcontext.SaveChanges();
        }
    }
}
