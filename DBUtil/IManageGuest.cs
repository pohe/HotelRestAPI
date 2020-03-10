using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary;

namespace HotelRestAPI.DBUtil
{
    public interface IManageGuest
    {
        IEnumerable<Guest> Get();
        Guest Get(int id);
        bool Post(Guest guest);
        bool Put(int id, Guest guest);
        bool Delete(int id);
    }
}
