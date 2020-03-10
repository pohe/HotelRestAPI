using System.Collections.Generic;
using ModelLibrary;

namespace HotelRestAPI.DBUtil
{
    public interface IManageHotel
    {
        IEnumerable<Hotel> Get();
        Hotel Get(int id);
        bool Post(Hotel hotel);
        bool Put(int id, Hotel hotel);
        bool Delete(int id);
    }
}