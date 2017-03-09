namespace EQRSWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reqToDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewEmergencyEventArgs",
                c => new
                    {
                        NewEmergencyEventArgId = c.Long(nullable: false, identity: true),
                        Request_EmergencyDetail = c.String(),
                        Request_Latitude = c.Double(nullable: false),
                        Request_Longitude = c.Double(nullable: false),
                        Request_ResponderCode = c.String(),
                        Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.NewEmergencyEventArgId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewEmergencyEventArgs");
        }
    }
}
