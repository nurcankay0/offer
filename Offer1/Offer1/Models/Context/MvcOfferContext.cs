using Offer1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Offer1.Models.Context
{
    public class MvcOfferContext:DbContext
    {
        public MvcOfferContext() : base("Server=.;Database=MvcOfferDb;Trusted_Connection=true")
        {

        }

        public DbSet<User> Users { get; set; }


    }
}