using DAL.EFs.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RestaurantRepo : Repo, IRepo<Restaurant, string, Restaurant>
    {
        public Restaurant Add(Restaurant obj)
        {
            db.Restaurants.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Restaurant Add(RestaurantRepo obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            var dbobj = Get(id);
            db.Restaurants.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Restaurant> Get()
        {
            return db.Restaurants.ToList();
        }

        public Restaurant Get(string id)
        {
            return db.Restaurants.Find(id);
        }

        public Restaurant Update(Restaurant obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
