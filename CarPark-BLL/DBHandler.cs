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
        public uspGetPersonnelID BLL_PersonnelID(string tag)
        {
            return db.PersonnelID(tag);
        }
        public bool BLL_AddPersonnelLog(string ID, string Plat, DateTime Time, int Gate)
        {
            return db.AddPersonnelLog(ID, Plat, Time, Gate);
        }
        public bool BLL_UpdatePersonnelLog(string ID, string Plat, DateTime Time)
        {
            return db.UpdatePersonnelLog(ID, Plat, Time);
        }
        public bool BLL_AddParkingLog(string AreaID, int LogID, DateTime Time)
        {
            return db.AddParkingLog(AreaID, LogID, Time);
        }
        public bool BLL_UpdateParkingLog(int LogID, DateTime Time)
        {
            return db.UpdateParkingLog(LogID, Time);
        }
        public uspGetAccessLevel BLL_GetAccessLevel(string AreaID)
        {
            return db.GetAccessLevel(AreaID);
        }
        public uspGetUserAccessLevel BLL_GetUserAccessLevel(string id)
        {
            return db.GetUserAccessLevel(id);
        }
        public uspGetLogID BLL_GetLogID(string id)
        {
            return db.GetLogID(id);
        }
        public uspGetPlate BLL_GetPlate(string id)
        {
            return db.GetPlate(id);
        }
        public uspCheckGuest BLL_CheckGuest(string guest)
        {
            return db.CheckGuest(guest);
        }
    }
}
