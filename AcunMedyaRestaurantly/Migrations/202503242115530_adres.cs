namespace AcunMedyaRestaurantly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class adres : DbMigration
    {
        public override void Up()
        {
            // Yeni Adres tablosunun oluşturulması
            CreateTable(
                "dbo.Adres",
                c => new
                {
                    AdresId = c.Int(nullable: false, identity: true),
                    Location = c.String(),
                    OpenHours = c.String(),
                    Email = c.String(),
                    Call = c.String(),
                })
                .PrimaryKey(t => t.AdresId);
        }

        public override void Down()
        {
            // Eğer migration geri alınırsa, Adres tablosunu sil
            DropTable("dbo.Adres");
        }
    }
}
