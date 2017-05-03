namespace F04L02___ProductsApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using F04L02___ProductsApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<F04L02___ProductsApp.Models.ProductEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(F04L02___ProductsApp.Models.ProductEntities context)
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

            using (var ctx = new ProductEntities())
            {
                var cat1 = new Category
                {
                    Name = "Cyklar"
                };

                var cat2 = new Category
                {
                    Name = "Verktyg"
                };

                var cat3 = new Category
                {
                    Name = "Bilar"
                };

                ctx.Categorys.AddOrUpdate(cat1);
                ctx.Categorys.AddOrUpdate(cat2);
                ctx.Categorys.AddOrUpdate(cat3);
                ctx.SaveChanges();

                var prod1 = new Product
                {
                    Category = cat1,
                    Name = "Crescent",
                    Price = 9000M
                };
                var prod2 = new Product
                {
                    Category = cat2,
                    Name = "Hammare",
                    Price = 250M
                };

                var prod3 = new Product
                {
                    Category = cat3,
                    Name = "Volvo",
                    Price = 400000M
                };


                ctx.Products.AddOrUpdate(prod1);
                ctx.Products.AddOrUpdate(prod2);
                ctx.Products.AddOrUpdate(prod3);
                ctx.SaveChanges();

            }


        }
    }
}
