using HYHISAPPView.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HYHISAPPS.Entity.Dao
{
    public class HY_V_COST_INFO
    {
        static string sql = "select * from v_cost_info where 1=1";
        public static DataSetV_COST_INFO SelectHY_COSTINFO(string stj)
        {
            DataSetV_COST_INFO ds = new DataSetV_COST_INFO();
            ViewEntity.GetViewEntityDataSet(sql.Replace("1=1", stj), "v_cost_info", ds);
            return (DataSetV_COST_INFO)ds;
        }
    }
}