using System;
using System.Data.Entity;

namespace Newsletter.Models
{
    public class NewsletterDbContext : DbContext
    {
        public NewsletterDbContext() 
            : base("NewsletterContext")
        {
        }

        public DbSet<Subscriptions> Subscriptions { get; set; }
    }
}