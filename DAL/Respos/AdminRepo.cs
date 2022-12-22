using DAL.EFs;
using DAL.EFs.Models;
using DAL.Interfaces;
using DAL.Respos;
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
            throw new NotImplementedException();
        }

        public List<Admin> Get()
        {
            throw new NotImplementedException();
        }

        public Admin Get(string id)
        {
            throw new NotImplementedException();
        }

        public Admin Update(Admin obj)
        {
            throw new NotImplementedException();
        }
    }
}