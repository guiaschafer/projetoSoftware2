using ConsoleApp1.Entity.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entity
{
    public class ContextoInicializador : MigrateDatabaseToLatestVersion<DataBaseContext, Configuration>
    {
        public override void InitializeDatabase(DataBaseContext context)
        {
            var databaseExists = context.Database.Exists();
            base.InitializeDatabase(context);
        }
    }
}
