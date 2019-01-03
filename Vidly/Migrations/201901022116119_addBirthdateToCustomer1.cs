namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBirthdateToCustomer1 : DbMigration
    {
        public override void Up()
        {
            Sql("update customers set birthdate = '3/24/1961' where id = 2");
            Sql("update customers set birthdate = '4/7/1967' where id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
