namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembershipType1 : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set name='Pay as you go' where id = 1");
            Sql("update MembershipTypes set name='Monthly' where id = 2");
            Sql("update MembershipTypes set name='Quarterly' where id = 3");
            Sql("update MembershipTypes set name='Annually' where id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
