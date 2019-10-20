using HYHISAPPView.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HYHISAPPS.Entity.Dao
{
    public class HY_DAOHANG_INFO
    {
        static string sql = "select * from V_DAOHANG_INFO where 1=1";
        public static DataSetV_DAOHANG_INFO SelectHY_DAOHANGINFO(string stj)
        {
            DataSetV_DAOHANG_INFO ds = new DataSetV_DAOHANG_INFO();
            ViewEntity.GetViewEntityDataSet(sql.Replace("1=1", stj), "V_DAOHANG_INFO", ds);
            return (DataSetV_DAOHANG_INFO)ds;
        }
    }
}