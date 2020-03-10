using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModelLibrary;

namespace HotelRestAPI.DBUtil
{
    public class ManageGuest:IManageGuest
    {
        public IEnumerable<Guest> Get()
        {
            throw new NotImplementedException();
        }

        public Guest Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Post(Guest guest)
        {
            throw new NotImplementedException();
        }

        public bool Put(int id, Guest guest)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}