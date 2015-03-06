using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Michaels_Stuff.Models;
using System.Data.Entity; 

namespace Michaels_Stuff.Dal
{
    public class kendallsoftInitializer : System.Data.Entity.
DropCreateDatabaseIfModelChanges<KendallsoftEntity> 

    {
        protected override void Seed(KendallsoftEntity context)
        {
                            //public string LastName { get; set; }
                            //public string FirstName { get; set; }
                            //public String BandName { get; set; }
                            //public DateTime FirstOnSeen { get; set; }

            

              var Artists = new List<Artist> {new Artist{LastName ="Kendall",FirstName="Mark", BandName="The Mark Kendall Band",FirstOnSeen=DateTime.Parse("2008-09-01")}} ;
              Artists.ForEach(s => context.MyArtists.Add(s)); 
              context.SaveChanges();             

              
        }

    }
}