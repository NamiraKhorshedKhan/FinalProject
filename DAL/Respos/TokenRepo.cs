using DAL.EFs.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respos
{
    internal class TokenRepo : Repo, IRepo<Token, string, Token>
    {
        public Token Add(Token obj)
        {
            db.Tokens.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var dbobj = Get(id);
            db.Tokens.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Token> Get()
        {
            return db.Tokens.ToList();
        }

        public Token Get(string id)
        {
            return db.Tokens.Find(id);
        }

        public Token Update(Token obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
