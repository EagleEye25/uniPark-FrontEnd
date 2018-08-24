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
    }
}
