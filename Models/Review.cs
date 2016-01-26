using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RateApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int ThingId { get; set; }
        public string Rating { get; set; }
        public string Comment { get; set; }
        public string Reviewer { get; set; }
    }
}