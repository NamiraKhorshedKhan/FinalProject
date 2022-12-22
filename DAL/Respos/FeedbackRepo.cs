using DAL.EFs.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respos
{
    internal class FeedbackRepo : Repo, IRepo<Feedback, string, Feedback>
    {
        public Feedback Add(Feedback obj)
        {
            db.Feedbacks.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Feedback Add(FeedbackRepo obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            var dbobj = Get(id);
            db.Feedbacks.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Feedback> Get()
        {
            return db.Feedbacks.ToList();
        }

        public Feedback Get(string id)
        {
            return db.Feedbacks.Find(id);
        }

        public Feedback Update(Feedback obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
