namespace S00015918Clubs.Migration.ClubsMigrations
{
    using Models.ClubsModel;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<S00015918Clubs.Models.ClubsModel.ClubsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migration\ClubsMigrations";
        }

        protected override void Seed(S00015918Clubs.Models.ClubsModel.ClubsContext context)
        {
            context.Club.AddOrUpdate(c => c.ClubName, new Club
            {
                ClubName = "Tiddly Winks Club",
                CreationDate = DateTime.Now
            });
            context.Club.AddOrUpdate(c => c.ClubName, new Club
            {
                ClubName = "The Chess Club",
                CreationDate = DateTime.Now
            });
        }
    }
}
