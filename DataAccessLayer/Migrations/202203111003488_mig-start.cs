namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migstart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutId = c.Int(nullable: false, identity: true),
                        AboutTitle = c.String(),
                        AboutDesc = c.String(),
                    })
                .PrimaryKey(t => t.AboutId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ConID = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Email = c.String(),
                        Subject = c.String(),
                        Phone = c.String(),
                        Message = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ConID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        ProjectTitle = c.String(),
                        ProjectDesc = c.String(),
                        ProjectImg = c.String(),
                        isIOS = c.Boolean(nullable: false),
                        ProjectIOSLink = c.String(),
                        ProjectAndroidLink = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectID);
            
            CreateTable(
                "dbo.Referances",
                c => new
                    {
                        RefID = c.Int(nullable: false, identity: true),
                        RefImage = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RefID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServicesId = c.Int(nullable: false, identity: true),
                        Icon = c.String(),
                        ServicesTitle = c.String(),
                        ServicesDesc = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ServicesId);
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        SliderId = c.Int(nullable: false, identity: true),
                        SliderImage = c.String(maxLength: 150),
                        SliderTitle = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.SliderId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Image = c.String(),
                        Job = c.String(),
                        Desc = c.String(),
                        Instagram = c.String(),
                        Linkedin = c.String(),
                        Github = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Sliders");
            DropTable("dbo.Services");
            DropTable("dbo.Referances");
            DropTable("dbo.Projects");
            DropTable("dbo.Contacts");
            DropTable("dbo.Abouts");
        }
    }
}
