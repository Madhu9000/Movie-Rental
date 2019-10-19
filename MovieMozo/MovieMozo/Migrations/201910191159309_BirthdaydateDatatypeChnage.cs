namespace MovieMozo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BirthdaydateDatatypeChnage : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Birthdaydate", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Birthdaydate", c => c.DateTime());
        }
    }
}
