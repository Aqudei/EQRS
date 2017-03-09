namespace EQRSWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeVariableType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Settings", "PortName", c => c.String());
            AlterColumn("dbo.Settings", "BaudRate", c => c.Int(nullable: false));
            DropColumn("dbo.Settings", "PortNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Settings", "PortNumber", c => c.String());
            AlterColumn("dbo.Settings", "BaudRate", c => c.String());
            DropColumn("dbo.Settings", "PortName");
        }
    }
}
