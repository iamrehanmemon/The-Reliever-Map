namespace TheRelieverMap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAddToiletTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddToilets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        City = c.String(nullable: false),
                        Address = c.String(nullable: false, maxLength: 150),
                        Compatibility_Id = c.Byte(nullable: false),
                        Provider_Id = c.String(nullable: false, maxLength: 128),
                        State_Id = c.Byte(nullable: false),
                        Type_Id = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Compatibles", t => t.Compatibility_Id, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.Provider_Id, cascadeDelete: true)
                .ForeignKey("dbo.States", t => t.State_Id, cascadeDelete: true)
                .ForeignKey("dbo.ToiletTypes", t => t.Type_Id, cascadeDelete: true)
                .Index(t => t.Compatibility_Id)
                .Index(t => t.Provider_Id)
                .Index(t => t.State_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.Compatibles",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ToiletTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AddToilets", "Type_Id", "dbo.ToiletTypes");
            DropForeignKey("dbo.AddToilets", "State_Id", "dbo.States");
            DropForeignKey("dbo.AddToilets", "Provider_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AddToilets", "Compatibility_Id", "dbo.Compatibles");
            DropIndex("dbo.AddToilets", new[] { "Type_Id" });
            DropIndex("dbo.AddToilets", new[] { "State_Id" });
            DropIndex("dbo.AddToilets", new[] { "Provider_Id" });
            DropIndex("dbo.AddToilets", new[] { "Compatibility_Id" });
            DropTable("dbo.ToiletTypes");
            DropTable("dbo.States");
            DropTable("dbo.Compatibles");
            DropTable("dbo.AddToilets");
        }
    }
}
