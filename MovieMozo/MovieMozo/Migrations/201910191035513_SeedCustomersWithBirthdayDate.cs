namespace MovieMozo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCustomersWithBirthdayDate : DbMigration
    {
        public override void Up()
        {
            Sql("update Customers set Birthdaydate = DateAdd(year,-22, getdate()) where id =2");
        }
        
        public override void Down()
        {
        }
    }
}
