namespace MovieMozo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMembershipTypestable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into MembershipTypes(Id, SignupFee, DurationInMonths, DiscountRate) values(1,0,0,0)");
            Sql("insert into MembershipTypes(Id, SignupFee, DurationInMonths, DiscountRate) values(2,30,3,10)");
            Sql("insert into MembershipTypes(Id, SignupFee, DurationInMonths, DiscountRate) values(3,60,6,15)");
            Sql("insert into MembershipTypes(Id, SignupFee, DurationInMonths, DiscountRate) values(4,150,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
