using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TypeLib.Interfaces;
using TypeLib.ViewModels;

namespace CarPark_DAL
{
    public class DBAccess : IDBAccess
    {
        // Check if User tag number exists
        public List<uspCheckTag> checktag (string tag)
        {
            List<uspCheckTag> list = new List<uspCheckTag>();
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@tag", tag)
            };
            using (DataTable dt = DBHelper.ParamSelect("uspCheckTag", CommandType.StoredProcedure, pars))
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        uspCheckTag ct = new uspCheckTag
                        {
                            PersonnelTagNumber = Convert.ToString(row["PersonnelTagNumber"])
                        };
                        list.Add(ct);
                    }

                }
                else { list = null; }
            }
            return list;
        }
        
        // Gets all parking areas
        public DataTable GetAllAreas()
        {
            DataTable dt = DBHelper.Select("uspGetAllAreas", CommandType.StoredProcedure);
            return dt;
        }
        
        // Get all main gates
        public DataTable GetMainGate()
        {
            DataTable dt = DBHelper.Select("uspGetMainGate", CommandType.StoredProcedure);
            return dt;
        }

        // Gets user ID
        public uspGetPersonnelID PersonnelID(string tag)
        {
            uspGetPersonnelID pl = null;
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@tag",tag)
            };

            using (DataTable table = DBHelper.ParamSelect("uspGetPersonnelID",
            CommandType.StoredProcedure, pars))
            {
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    pl = new uspGetPersonnelID
                    {
                        PersonnelID = Convert.ToString(row["PersonnelID"])
                    };
                }
            }
            return pl;
        }

        // Add personnel log
        public bool AddPersonnelLog(string ID, string Plat, DateTime Time, int Gate)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@personnelID",ID),
                new SqlParameter("@plate",Plat),
                new SqlParameter("@time",Time),
                new SqlParameter("@gate",Gate)
            };
            return DBHelper.NonQuery("uspAddPersonnelLog", CommandType.StoredProcedure, pars);
        }

        // Update personnel log
        public bool UpdatePersonnelLog(string ID, string Plat, DateTime Time)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@personnelID",ID),
                new SqlParameter("@plate",Plat),
                new SqlParameter("@time",Time)
            };
            return DBHelper.NonQuery("uspUpdatePersonnelLog", CommandType.StoredProcedure, pars);
        }

        // Add parking log
        public bool AddParkingLog(string AreaID, int LogID, DateTime Time)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@time",Time),
                new SqlParameter("@logID", LogID),
                new SqlParameter("@areaID",AreaID)
            };
            return DBHelper.NonQuery("uspAddParkingLog", CommandType.StoredProcedure, pars);
        }

        // Update parking log
        public bool UpdateParkingLog(int LogID, DateTime Time)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@time",Time),
                new SqlParameter("@personelLog",LogID)
            };
            return DBHelper.NonQuery("uspUpdateParkingLog", CommandType.StoredProcedure, pars);
        }

        // Get area access level
        public uspGetAccessLevel GetAccessLevel(string AreaID)
        {
            uspGetAccessLevel al = null;
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@areaID",AreaID)
            };
            using (DataTable table = DBHelper.ParamSelect("uspGetAccessLevel",
            CommandType.StoredProcedure, pars))
            {
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    al = new uspGetAccessLevel
                    {
                        ParkingAreaAccessLevel = Convert.ToInt32((row["ParkingAreaAccessLevel"]))
                    };
                }
            }
            return al;

        }

        // Get personnel level
        public uspGetUserAccessLevel GetUserAccessLevel(string id)
        {
            uspGetUserAccessLevel ua = null;
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@id",id)
            };
            using (DataTable table = DBHelper.ParamSelect("uspGetUserAccessLevel",
            CommandType.StoredProcedure, pars))
            {
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    ua = new uspGetUserAccessLevel
                    {
                        PersonnelLevelID = Convert.ToInt32((row["PersonnelLevelID"]))
                    };
                }
            }
            return ua;
        }

        // Get log ID
        public uspGetLogID GetLogID(string id)
        {
            uspGetLogID li = null;
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@id",id)
            };
            using (DataTable table = DBHelper.ParamSelect("uspGetLogID",
            CommandType.StoredProcedure, pars))
            {
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    li = new uspGetLogID
                    {
                        PersonnelLogID = Convert.ToInt32((row["PersonnelLogID"]))
                    };
                }
            }
            return li;
        }

        //Get Plate
        public uspGetPlate GetPlate(string id)
        {
            uspGetPlate gp = null;
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@id",id)
            };
            using (DataTable table = DBHelper.ParamSelect("uspGetPlate",
           CommandType.StoredProcedure, pars))
            {
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    gp = new uspGetPlate
                    {
                        LicenseIn = Convert.ToString(row["LicenseIn"])
                    };
                }
            }
            return gp;
        }

        // Get Guest
        public uspCheckGuest CheckGuest(string guest)
        {
            uspCheckGuest cg = null;
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@guest",guest)
            };
            using (DataTable table = DBHelper.ParamSelect("uspCheckGuest",
          CommandType.StoredProcedure, pars))
            {
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    cg = new uspCheckGuest
                    {
                        PersonnelID = Convert.ToString(row["PersonnelID"])
                    };
                }
            }
            return cg;
        }

    }
}
