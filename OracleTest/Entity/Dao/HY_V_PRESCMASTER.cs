using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HYHISAPPView.Entity;

namespace HYHISAPPS.Entity.Dao
{
    public class HY_V_PRESCMASTER
    {
        static string sql = "select * from V_MZ_PRESCMASTER where 1=1";
        public static DataSetV_MZ_PRESCMASTER SelectHY_PRESCDETAIL(string stj)
        {
            DataSetV_MZ_PRESCMASTER ds = new DataSetV_MZ_PRESCMASTER();
            ViewEntity.GetViewEntityDataSet(sql.Replace("1=1", stj), "V_MZ_PRESCMASTER", ds);
            return (DataSetV_MZ_PRESCMASTER)ds;
        }
    }
}