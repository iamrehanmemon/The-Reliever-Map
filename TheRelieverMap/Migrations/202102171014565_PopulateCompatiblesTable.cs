namespace TheRelieverMap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCompatiblesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Compatibles (Id, Name) VALUES (1, 'Men')");
            Sql("INSERT INTO Compatibles (Id, Name) VALUES (2, 'Women')");
            Sql("INSERT INTO Compatibles (Id, Name) VALUES (3, 'Both')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Compatibles WHERE Id IN (1,2,3)");
        }
    }
}
