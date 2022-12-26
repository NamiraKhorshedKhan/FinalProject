using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICount<CLASS, ID, RET>
    {
        RET Count();
        RET Count(ID id);
    }
}
