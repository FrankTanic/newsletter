using System;
using System.ComponentModel.DataAnnotations;

namespace Newsletter.Models
{
    public class Subscriptions
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Interval Interval { get; set; }

        [Timestamp]
        public byte[] Created { get; set; }
    }

    public enum Interval
    {
        Daily = 0,
        Weekly = 1,
        Monthly = 2
    }
}