namespace EntityClasses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialized1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommentsDetails = c.String(),
                        CommentsUserName = c.String(),
                        CommentsTaskName = c.String(),
                        CommentsProjectName = c.String(),
                        CommentsDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(),
                        ProjectShortName = c.String(),
                        ProjectDescription = c.String(),
                        ProjectPsd = c.DateTime(nullable: false),
                        ProjectPed = c.DateTime(nullable: false),
                        ProjectDuration = c.Int(nullable: false),
                        ProjectFilePath = c.String(),
                        ProjectStatus = c.Boolean(nullable: false),
                        ProjectPriority = c.String(),
                        ProjectManager = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ResourcePersons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ResourcePersonName = c.String(),
                        ResourcePersonProjectName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TasksName = c.String(),
                        TasksProjectName = c.String(),
                        TasksAssignedUser = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserEmail = c.String(),
                        UserPassword = c.String(),
                        UserStatus = c.Boolean(nullable: false),
                        UserDesignation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Tasks");
            DropTable("dbo.ResourcePersons");
            DropTable("dbo.Projects");
            DropTable("dbo.Comments");
        }
    }
}
