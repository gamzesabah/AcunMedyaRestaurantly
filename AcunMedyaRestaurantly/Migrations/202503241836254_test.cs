namespace AcunMedyaRestaurantly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
  
        }
        
        public override void Down()
        {
            AddColumn("dbo.Features", "İmageUrl", c => c.String());
            AddColumn("dbo.Addresses", "AdressId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Addresses");
            DropColumn("dbo.Features", "ImageUrl");
            DropColumn("dbo.Addresses", "AddressId");
            AddPrimaryKey("dbo.Addresses", "AdressId");
        }
    }
}
