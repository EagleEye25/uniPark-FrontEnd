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
    }
}
