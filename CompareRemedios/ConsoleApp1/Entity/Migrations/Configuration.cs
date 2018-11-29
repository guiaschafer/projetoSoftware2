using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entity.Migrations
{
    public class Configuration : DbMigrationsConfiguration<DataBaseContext>
    {
        public Configuration()
        {
            CommandTimeout = int.MaxValue;
            AutomaticMigrationsEnabled = false;
            ContextKey = typeof(DataBaseContext).FullName;
            MigrationsDirectory = "Entity\\Migrations";
        }
    }
}
