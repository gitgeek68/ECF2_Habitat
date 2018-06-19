using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MulhouseHabitat.Models
{
    public class BdddContext:DbContext
    {
        public DbSet<MHLogements> Logements { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer<BddContext>(null);
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BdddContext>());
            base.OnModelCreating(modelBuilder);
            //si la base de donnée change le modele change automatiquement en ajoutant ou enlevant les champs
        }
    }
}