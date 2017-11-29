namespace EntityClasses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inialization4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "dueDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tasks", "priority", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "priority");
            DropColumn("dbo.Tasks", "dueDate");
        }
    }
}
