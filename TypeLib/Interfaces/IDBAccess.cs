using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TypeLib.ViewModels;
namespace TypeLib.Interfaces
{
    public interface IDBAccess
    {
        List<uspCheckTag> checktag(string tag);
        DataTable GetAllAreas();
        DataTable GetMainGate();
        uspGetPersonnelID PersonnelID(string tag);
        bool AddPersonnelLog(string ID, string Plat, DateTime Time, int Gate);
        bool UpdatePersonnelLog(string ID, string Plat, DateTime Time);
        bool AddParkingLog(string AreaID, int LogID, DateTime Time);
        bool UpdateParkingLog(int LogID, DateTime Time);
        uspGetAccessLevel GetAccessLevel(string AreaID);
        uspGetUserAccessLevel GetUserAccessLevel(string id);
        uspGetLogID GetLogID(string id);
        uspGetPlate GetPlate(string id);
        uspCheckGuest CheckGuest(string guest);
    }
}
