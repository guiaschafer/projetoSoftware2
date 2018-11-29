
using CompareRemedios.Dominio.Entity.Migrations;
using System.Data.Entity;

namespace CompareRemedios.Dominio.Entity
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
