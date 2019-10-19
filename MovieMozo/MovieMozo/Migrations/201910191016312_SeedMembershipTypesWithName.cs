namespace MovieMozo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMembershipTypesWithName : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set MembershipTypeName='Pay As You Go' where id=1");
            Sql("update MembershipTypes set MembershipTypeName='Quarter' where id=2");
            Sql("update MembershipTypes set MembershipTypeName='Half-Year' where id=3");
            Sql("update MembershipTypes set MembershipTypeName='Year' where id=4");
        }
        
        public override void Down()
        {
        }
    }
}
