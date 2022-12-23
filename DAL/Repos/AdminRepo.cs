using DAL.EFs;
using DAL.EFs.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminRepo : Repo, IRepo<Admin, string, Admin>
    {
        public Admin Add(Admin obj)
        {
            db.Admins.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var dbobj = Get(id);
            db.Admins.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Admin> Get()
        {
            return db.Admins.ToList();
        }

        public Admin Get(string id)
        {
            return db.Admins.Find(id);
        }

        public Admin Update(Admin obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}