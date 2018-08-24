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

    }
}
