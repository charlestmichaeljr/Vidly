namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMovieDB : DbMigration
    {
        public override void Up()
        {
            Sql("insert into movies (name,dateadded,genreid,numberinstock) values('Shrek',getdate(),1,2)");
            Sql("insert into movies (name,dateadded,genreid,numberinstock) values('It''s a Wonderful Life',getdate(),2,0)");
            Sql("insert into movies (name,dateadded,genreid,numberinstock) values('The 40 Year Old Virgin',getdate(),3,7)");
            Sql("insert into movies (name,dateadded,genreid,numberinstock) values('Ted',getdate(),2,1)");
            Sql("insert into movies (name,dateadded,genreid,numberinstock) values('The Sisterhood of the Traveling Pants',getdate(),4,15)");
        }
        
        public override void Down()
        {
        }
    }
}
