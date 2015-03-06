namespace Michaels_Stuff
{
    using System;
    using System.Data.Entity;
    using System.Linq; 
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using Michaels_Stuff.Models;

    public class KendallsoftEntity : DbContext
    {
        // Your context has been configured to use a 'KendallsoftEntity' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Michaels_Stuff.KendallsoftEntity' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'KendallsoftEntity' 
        // connection string in the application configuration file.
        public KendallsoftEntity()
            : base("name=KendallsoftEntity")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

      


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Artist> MyArtists { get; set; }
        public virtual DbSet<MediaRelease> MyMediaReleases { get; set; }
        public virtual DbSet<Publication> MyPublications { get; set; }

    }

  
}