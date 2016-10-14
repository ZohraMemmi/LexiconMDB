using LexiconMDB.DAL;//we who added this

namespace LexiconMDB.Migrations
{
    using Models;//we who added this
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;


    internal sealed class Configuration : DbMigrationsConfiguration<LexiconMDB.DAL.MovieDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LexiconMDB.DAL.MovieDbContext context)
        {
                context.Movies.AddOrUpdate(
                m=>m.Title,
            new Movie
            {
                Title = "Return the killing Tomateos",
                Genre = Genre.Horror,
                AgeLimit = 15,
                Length = 90,
                Metascore = 7
            },
             new Movie
             {
                 Title = "Programmers Academy",
                 Genre = Genre.Comedy,
                 AgeLimit = 12,
                 Length = 110,
                 Metascore = 16
             },
              new Movie
              {
                  Title = "Finalize 7",
                  Genre = Genre.Action,
                  AgeLimit = 15,
                  Length = 95,
                  Metascore = 57
              },
               new Movie
               {
                   Title = "The lord of the earings",
                   Genre = Genre.Drama,
                   AgeLimit = 11,
                   Length = 205,
                   Metascore = 91
               }
              );
        }
    }
}
