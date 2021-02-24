namespace TheRelieverMap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateToiletTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ToiletTypes (Id, Name) VALUES (1, 'Private')");
            Sql("INSERT INTO ToiletTypes (Id, Name) VALUES (2, 'Public')");
        }

        public override void Down()
        {
            Sql("DELETE FROM ToiletTypes WHERE Id IN (1,2)");
        }
    }
}
