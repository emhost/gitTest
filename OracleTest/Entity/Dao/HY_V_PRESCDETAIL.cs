using HYHISAPPView.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HYHISAPPS.Entity.Dao
{
    public class HY_V_PRESCDETAIL
    {
        static string sql = "select * from V_MZ_PRESCDETAIL where 1=1";
        public static DataSetV_MZ_PRESCDETAIL SelectHY_PRESCDETAIL(string stj)
        {
            DataSetV_MZ_PRESCDETAIL ds = new DataSetV_MZ_PRESCDETAIL();
            ViewEntity.GetViewEntityDataSet(sql.Replace("1=1", stj), "V_MZ_PRESCDETAIL", ds);
            return (DataSetV_MZ_PRESCDETAIL)ds;
        }
    }
}