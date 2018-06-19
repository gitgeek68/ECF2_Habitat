using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MulhouseHabitat.Models
{
    public class Dal : IDisposable
    {
        private BdddContext dbContext;

        public Dal()
        {
            dbContext = new BdddContext();
        }

        public void Dispose()
        {
            dbContext.Dispose();
           
        }
        #region CRU
        public void GetLogement(int _id)
        {
            dbContext.Logements.FirstOrDefault(x => (x.Id == _id));
        }

        public void AddLogement(MHLogements _logement)
        {
            dbContext.Logements.Add(_logement);

            dbContext.SaveChanges();
        }

        public void UpdateLogement(MHLogements _logement)
        {

            MHLogements exist = dbContext.Logements.FirstOrDefault(x => (x.Id == _logement.Id));

            if (exist != default(MHLogements))
            {
                exist.Id = _logement.Id;
                exist.Type = _logement.Type;
                exist.StreetNumber = _logement.StreetNumber;
                exist.StreetName = _logement.StreetName;
                exist.PostalCode = _logement.PostalCode;
                exist.City = _logement.City;
                exist.NumberOfPieces = _logement.NumberOfPieces;
                exist.Size = _logement.Size;
                exist.Rented = _logement.Rented;

                dbContext.SaveChanges();
            }

               List<MHLogements> GetLogements()
            {
                return dbContext.Logements.ToList();
            }

            //public List<MHLogements> GetLogements(Predicate<MHLogements> predicate)
            //{

            //    List<MHLogements> result = new List<MHLogements>();
            //    //cree une liste de resultats
            //    foreach (MHLogements l in dbContext.Logements)
            //    //pour chaque client dans la base de donnée Client
            //    {
            //        if (predicate(l))
            //        //si le predicat correspond au Client demandé(p)
            //        {
            //            result.Add(l);
            //            //la liste ajoute le Client a result
            //            dbContext.SaveChanges();
            //        }
            //    }
            //    return result;
            //    //retourne la liste result
            //}

        }



        #endregion 



    }
}