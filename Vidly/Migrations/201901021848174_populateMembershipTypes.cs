namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into MembershipTypes (SignupFee, DurationInMonths, DiscountRate) Values(0,0,0)");
            Sql("Insert into MembershipTypes (SignupFee, DurationInMonths, DiscountRate) Values(30,1,10)");
            Sql("Insert into MembershipTypes (SignupFee, DurationInMonths, DiscountRate) Values(90,3,15)");
            Sql("Insert into MembershipTypes (SignupFee, DurationInMonths, DiscountRate) Values(300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
