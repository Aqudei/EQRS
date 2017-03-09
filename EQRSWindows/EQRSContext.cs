namespace EQRSWin
{
    using Entities;
    using EQRSWin;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EQRSContext : DbContext
    {
        // Your context has been configured to use a 'EQRSContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EQRSWin.EQRSContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EQRSContext' 
        // connection string in the application configuration file.
        public EQRSContext()
            : base("EQRSContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Responder>().HasKey(k => k.ResponderId);
            modelBuilder.Entity<NewEmergencyEventArg>().HasKey(k => k.NewEmergencyEventArgId);
            modelBuilder.Entity<Responder>().Property(p => p.ResponderId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

        }

        public virtual DbSet<Responder> Responders { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<NewEmergencyEventArg> NewEmergencyEventArgs { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}