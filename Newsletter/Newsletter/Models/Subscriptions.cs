using System;
using System.ComponentModel.DataAnnotations;

namespace Newsletter.Models
{
    public class Subscriptions
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Interval Interval { get; set; }

    }
}