namespace AcunMedyaRestaurantly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migFeaturesUpdate1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Features", "İmageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Features", "ImageUrl", c => c.String());
        }
    }
}
