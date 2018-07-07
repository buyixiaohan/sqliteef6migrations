using System.Data.Entity.Migrations;

namespace System.Data.SQLite.EF6.Migrations.Test.Model01
{
    internal sealed class ContextMigrationConfiguration : DbMigrationsConfiguration<Context>
    {
        public ContextMigrationConfiguration()
        {
            //set this "false" test  manual migration 
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }
    }
}
