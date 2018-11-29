using CompareRemedios.Dominio.Entity;
using System.Data.Entity.Migrations;

namespace CompareRemedios.Dominio.Entity.Migrations
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
