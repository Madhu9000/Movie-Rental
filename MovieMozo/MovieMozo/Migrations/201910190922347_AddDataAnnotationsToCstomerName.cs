namespace MovieMozo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotationsToCstomerName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Customername", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Customername", c => c.String());
        }
    }
}
