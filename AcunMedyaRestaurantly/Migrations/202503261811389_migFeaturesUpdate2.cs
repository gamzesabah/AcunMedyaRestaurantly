﻿namespace AcunMedyaRestaurantly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migFeaturesUpdate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Features", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Features", "ImageUrl");
        }
    }
}
