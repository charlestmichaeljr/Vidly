namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres  (name) values('Horror')");
            Sql("Insert into Genres  (name) values('Comedy')");
            Sql("Insert into Genres  (name) values('Romance')");
            Sql("Insert into Genres  (name) values('Rom-Com')");
            Sql("Insert into Genres  (name) values('Documentary')");
        }
        
        public override void Down()
        {
        }
    }
}
