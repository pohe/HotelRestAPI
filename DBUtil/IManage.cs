using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRestAPI.DBUtil
{
    interface IManage<T>
    {
        IEnumerable<T> Get();
        T Get(int id);
        bool Post(T guest);
        bool Put(int id, T guest);
        bool Delete(int id);
    }
}
