namespace TestMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TestMVC.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TestMVC.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TestMVC.Models.MovieDBContext";
        }

        protected override void Seed(TestMVC.Models.MovieDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "Before Sunrise",
                    ReleaseDate = DateTime.Parse("1995-07-08"),
                    Genre = "Romance",
                    Price = 90000,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Before Sunset",
                    ReleaseDate = DateTime.Parse("2004-08-21"),
                    Genre = "Romance",
                    Price = 100000,
                    Rating = "R"
                }
                );
        }
    }
}
