using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace S00015918Clubs.Models.ClubsModel
{
    public class ClubsContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Club> Club { get; set; }
        public DbSet<ClubEvent> ClubEvents { get; set; }
        public ClubsContext() : base("DefaultConnection")
        {

        }

        public static ClubsContext Create()
        {
            return new ClubsContext();
        }
    }
}