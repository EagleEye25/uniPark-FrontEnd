using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using TypeLib.Models;
using TypeLib.ViewModels;
using TypeLib.Interfaces;
using CarPark_DAL;


namespace CarPark_BLL
{
    public class DBHandler : IDBHandler
    {
        private IDBAccess db;
        public DBHandler()
        {
            db = new DBAccess();
        }
        public List<uspCheckTag> BLL_checktag(string tag)
        {
            return db.checktag(tag);
        }
        public DataTable BLL_GetAllAreas()
        {
            return db.GetAllAreas();
        }
        public DataTable BLL_GetMainGate()
        {
            return db.GetMainGate();
        }
    }
}
