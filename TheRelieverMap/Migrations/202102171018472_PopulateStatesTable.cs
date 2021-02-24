namespace TheRelieverMap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStatesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO States (Id, Name) VALUES (1, 'Andhra Pradesh')");
            Sql("INSERT INTO States (Id, Name) VALUES (2, 'Arunachal Pradesh')");
            Sql("INSERT INTO States (Id, Name) VALUES (3, 'Assam')");
            Sql("INSERT INTO States (Id, Name) VALUES (4, 'Bihar')");
            Sql("INSERT INTO States (Id, Name) VALUES (5, 'Chattisgarh')");
            Sql("INSERT INTO States (Id, Name) VALUES (6, 'Goa')");
            Sql("INSERT INTO States (Id, Name) VALUES (7, 'Gujarat')");
            Sql("INSERT INTO States (Id, Name) VALUES (8, 'Haryana')");
            Sql("INSERT INTO States (Id, Name) VALUES (9, 'Himachal Pradesh')");
            Sql("INSERT INTO States (Id, Name) VALUES (10, 'Jammu and Kashmir')");
            Sql("INSERT INTO States (Id, Name) VALUES (11, 'Jharkhand')");
            Sql("INSERT INTO States (Id, Name) VALUES (12, 'Karnataka')");
            Sql("INSERT INTO States (Id, Name) VALUES (13, 'Kerala')");
            Sql("INSERT INTO States (Id, Name) VALUES (14, 'Madhya Pradesh')");
            Sql("INSERT INTO States (Id, Name) VALUES (15, 'Maharashtra')");
            Sql("INSERT INTO States (Id, Name) VALUES (16, 'Manipur')");
            Sql("INSERT INTO States (Id, Name) VALUES (17, 'Meghalaya')");
            Sql("INSERT INTO States (Id, Name) VALUES (18, 'Mizoram')");
            Sql("INSERT INTO States (Id, Name) VALUES (19, 'Nagaland')");
            Sql("INSERT INTO States (Id, Name) VALUES (20, 'Odisha')");
            Sql("INSERT INTO States (Id, Name) VALUES (21, 'Punjab')");
            Sql("INSERT INTO States (Id, Name) VALUES (22, 'Rajasthan')");
            Sql("INSERT INTO States (Id, Name) VALUES (23, 'Sikkim')");
            Sql("INSERT INTO States (Id, Name) VALUES (24, 'Tamil Nadu')");
            Sql("INSERT INTO States (Id, Name) VALUES (25, 'Telangana')");
            Sql("INSERT INTO States (Id, Name) VALUES (26, 'Tripura')");
            Sql("INSERT INTO States (Id, Name) VALUES (27, 'Uttar Pradesh')");
            Sql("INSERT INTO States (Id, Name) VALUES (28, 'Uttarakhand')");
            Sql("INSERT INTO States (Id, Name) VALUES (29, 'West Bengal')");
            Sql("INSERT INTO States (Id, Name) VALUES (30, 'Andaman and Nicobar')");
            Sql("INSERT INTO States (Id, Name) VALUES (31, 'Daman and Diu')");
            Sql("INSERT INTO States (Id, Name) VALUES (32, 'Chandigarh')");
            Sql("INSERT INTO States (Id, Name) VALUES (33, 'Delhi')");
            Sql("INSERT INTO States (Id, Name) VALUES (34, 'Ladakh')");
            Sql("INSERT INTO States (Id, Name) VALUES (35, 'Lakhsdweep')");
            Sql("INSERT INTO States (Id, Name) VALUES (36, 'Puducherry')");
        }

        public override void Down()
        {
            Sql("DELETE FROM States WHERE Id IN (1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36)");
        }
    }
}
