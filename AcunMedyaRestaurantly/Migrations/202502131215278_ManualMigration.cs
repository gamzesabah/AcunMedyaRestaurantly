namespace AcunMedyaRestaurantly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManualMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "IsRead", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "IsRead", c => c.Int(nullable: false));
        }
    }
}
