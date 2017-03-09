namespace EQRSWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class addedAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewEmergencyEventArgs", "Request_Address", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.NewEmergencyEventArgs", "Request_Address");
        }
    }
}
