namespace EQRSWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedSettingDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        SettingId = c.Int(nullable: false, identity: true),
                        PortNumber = c.String(),
                        BaudRate = c.String(),
                    })
                .PrimaryKey(t => t.SettingId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Settings");
        }
    }
}
