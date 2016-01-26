using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace RateApp.Models
{
    public class ThingContext : DbContext
    {
        public ThingContext()
        {
            Database.SetInitializer<ThingContext>(new ThingDbInitialier());
        }

        public DbSet<Thing> Things { get; set; }
        public DbSet<Review> TReviews { get; set; }

    }


    public class ThingDbInitialier : DropCreateDatabaseAlways<ThingContext>
    {
        protected override void Seed(ThingContext context)
        {
            IList<Thing> defaultStandards = new List<Thing>();

            defaultStandards.Add(new Thing() {  Id = 1, Name="Abhishek", Type="Developer", City="Pune", Country="India", Location="Wakad", State="Maharastra", Zipcode=411057, Reviews = new List<Review> { new Review() { Id = 1, ThingId = 1, Rating="5", Comment="Super", Reviewer="Some Body" } } });
            

            foreach (Thing std in defaultStandards)
                context.Things.Add(std);

            base.Seed(context);
        }
    }
}
    
