namespace EQRSWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPhoneToLog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewEmergencyEventArgs", "Request_MobileNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NewEmergencyEventArgs", "Request_MobileNumber");
        }
    }
}
