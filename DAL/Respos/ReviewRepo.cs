using DAL.EFs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respos
{
    internal class ReviewRepo: Repo, IRepo<Review, string, Review>
    {
        public Review Add(Review obj)
        {
            db.Reviews.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Review Add(ReviewRepo obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            var dbobj = Get(id);
            db.Reviews.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Review> Get()
        {
            return db.Reviews.ToList();
        }

        public Review Get(string id)
        {
            return db.Reviews.Find(id);
        }

        public Review Update(Review obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
