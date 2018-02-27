namespace RecrutTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DataModelEntities",
                c => new
                    {
                        TextId = c.Int(nullable: false, identity: true),
                        InputString = c.String(nullable: false),
                        TranslatedString = c.String(),
                    })
                .PrimaryKey(t => t.TextId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DataModelEntities");
        }
    }
}
