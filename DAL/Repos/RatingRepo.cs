using DAL.EFs.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RatingRepo : Repo, IRepo<Rating, string, Rating>
    {
        public Rating Add(Rating obj)
        {
            db.Ratings.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Rating Add(RatingRepo obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            var dbobj = Get(id);
            db.Ratings.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Rating> Get()
        {
            return db.Ratings.ToList();
        }

        public Rating Get(string id)
        {
            return db.Ratings.Find(id);
        }

        public Rating Update(Rating obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
