using DAL.EFs.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respos
{
    internal class LoginRepo : Repo, IRepo<Login, string, Login>
    {
        public Login Add(Login obj)
        {
            db.Logins.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Login Add(LoginRepo obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            var dbobj = Get(id);
            db.Logins.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Login> Get()
        {
            return db.Logins.ToList();
        }

        public Login Get(string id)
        {
            return db.Logins.Find(id);
        }

        public Login Update(Login obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
