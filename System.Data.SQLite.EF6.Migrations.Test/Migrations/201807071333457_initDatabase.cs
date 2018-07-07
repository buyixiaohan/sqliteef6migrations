namespace System.Data.SQLite.EF6.Migrations.Test.Model01
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dependants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50),
                        MainEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Entities", t => t.MainEntity_Id)
                .Index(t => t.MainEntity_Id);
            
            CreateTable(
                "dbo.Entities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dependants", "MainEntity_Id", "dbo.Entities");
            DropIndex("dbo.Dependants", new[] { "MainEntity_Id" });
            DropTable("dbo.Entities");
            DropTable("dbo.Dependants");
        }
    }
}
