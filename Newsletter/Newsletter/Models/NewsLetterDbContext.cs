using System;
using System.Data.Entity;

namespace Newsletter.Models
{
    public class NewsLetterDbContext : DbContext
    {
        DbSet<Subscriptions> Subscriptions { get; set; }
    }
}