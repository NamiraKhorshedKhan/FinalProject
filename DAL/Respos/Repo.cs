using DAL.EFs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respos
{
    internal class Repo
    {
        protected Context db;
        protected Repo()
        {
            db = new Context();
        }
    }
}
