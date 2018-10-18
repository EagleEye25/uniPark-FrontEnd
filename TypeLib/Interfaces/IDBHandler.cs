using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TypeLib.Models;
using TypeLib.ViewModels;
using System.Data;

namespace TypeLib.Interfaces
{
    public interface IDBHandler
    {

        List<uspCheckTag> BLL_checktag(string tag);
        DataTable BLL_GetAllAreas();
        DataTable BLL_GetMainGate();
        uspGetPersonnelID BLL_PersonnelID(string tag);
        bool BLL_AddPersonnelLog(string ID, string Plat, DateTime Time, int Gate);
        bool BLL_UpdatePersonnelLog(string ID, string Plat, DateTime Time);
        bool BLL_AddParkingLog(string AreaID, int LogID, DateTime Time);
        bool BLL_UpdateParkingLog(int LogID, DateTime Time);
        uspGetAccessLevel BLL_GetAccessLevel(string AreaID);
        uspGetUserAccessLevel BLL_GetUserAccessLevel(string id);
        uspGetLogID BLL_GetLogID(string id);
        uspGetPlate BLL_GetPlate(string id);
        uspCheckGuest BLL_CheckGuest(string guest);
    }
}
