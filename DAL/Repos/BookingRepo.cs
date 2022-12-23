using DAL.EFs.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BookingRepo : Repo, IRepo<Booking, string, Booking>
    {
        public Booking Add(Booking obj)
        {
            db.Bookings.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var dbobj = Get(id);
            db.Bookings.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Booking> Get()
        {
            return db.Bookings.ToList();
        }

        public Booking Get(string id)
        {
            return db.Bookings.Find(id);
        }

        public Booking Update(Booking obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
