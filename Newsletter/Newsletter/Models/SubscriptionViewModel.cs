using System;
using System.ComponentModel.DataAnnotations;

namespace Newsletter.Models
{
    public class SubscriptionViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please, fill in a name, so we know how to call you")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Without an emailaddress, we wont be able to send you anything")]
        [EmailAddress(ErrorMessage = "This is not a valid emailaddress")]
        public string Email { get; set; }

        [Required]
        public Interval Interval { get; set; }
    }

    public enum Interval
    {
        Daily = 0,
        Weekly = 1,
        Monthly = 2
    }
}