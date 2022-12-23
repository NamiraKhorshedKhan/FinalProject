using DAL.EFs.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class MenuRepo : Repo, IRepo<Menu, string, Menu>
    {
        public Menu Add(Menu obj)
        {
            db.Menus.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Menu Add(MenuRepo obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            var dbobj = Get(id);
            db.Menus.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Menu> Get()
        {
            return db.Menus.ToList();
        }

        public Menu Get(string id)
        {
            return db.Menus.Find(id);
        }

        public Menu Update(Menu obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
