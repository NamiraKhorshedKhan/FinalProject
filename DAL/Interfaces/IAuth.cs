using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EFs.Models;

namespace DAL.Interfaces
{
    public interface IAuth
    {
        Login Authenticate(string username, string password);
    }
}
