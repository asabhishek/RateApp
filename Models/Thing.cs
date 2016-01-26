using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace RateApp.Models
{
    public class Thing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Zipcode { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
    }
}