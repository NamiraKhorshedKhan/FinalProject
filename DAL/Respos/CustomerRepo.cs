using DAL.EFs.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respos
{
    internal class CustomerRepo : Repo, IRepo<Customer, string, Customer>
    {
        public Customer Add(Customer obj)
        {
            db.Customers.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Customer Add(CustomerRepo obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            var dbobj = Get(id);
            db.Customers.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Customer> Get()
        {
            return db.Customers.ToList();
        }

        public Customer Get(string id)
        {
            return db.Customers.Find(id);
        }

        public Customer Update(Customer obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
