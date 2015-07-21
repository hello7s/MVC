namespace DoubleR.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DoubleR.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DoubleR.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DoubleR.Models.ApplicationDbContext context)
        {
            context.TuneRummies.AddOrUpdate(p => p.ScreenName,
               new TuneRummy
               {
                   ScreenName = "Luke",
                   Email = "strugglemonkey@gmail.com",
               },
               new TuneRummy
               {
                   ScreenName = "Paul",
                   Email = "pdonoho914@gmail.com",
               },
               new TuneRummy
               {
                   ScreenName = "Chad",
                   Email = "duncanmcleod400@gmail.com",
               },
               new TuneRummy
               {
                   ScreenName = "Matt",
                   Email = "mattdonoho@gmail.com",
               },
               new TuneRummy
               {
                   ScreenName = "Jesi",
                   Email = "jesi622@gmail.com",
               },
               new TuneRummy 
               { 
                   ScreenName = "Kendra",
                   Email = "kendradonoho@gmail.com"
               },
               new TuneRummy
               {
                   ScreenName = "Sarah",
                   Email = "ssprehe76@gmail.com"
                }

                );
        }
    }
}
