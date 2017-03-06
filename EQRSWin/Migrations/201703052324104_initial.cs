namespace EQRSWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Responders",
                c => new
                    {
                        ResponderId = c.Long(nullable: false, identity: true),
                        ResponderName = c.String(),
                        ResponderCode = c.String(),
                        MobileNumber = c.String(),
                    })
                .PrimaryKey(t => t.ResponderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Responders");
        }
    }
}
