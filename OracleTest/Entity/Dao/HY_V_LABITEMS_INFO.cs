using HYHISAPPView.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HYHISAPPS.Entity.Dao
{
    public sealed class HY_V_LABITEMS_INFO
    {
        #region strsql
        static string sql =
            @"SELECT * FROM  V_LABITEMS_INFO WHERE 1=1";
        #endregion

        public static DataSetV_LABITEMS_INFO SelectHY_LABITEMS(string stj)
        {
            DataSetV_LABITEMS_INFO ds = new DataSetV_LABITEMS_INFO();
            ViewEntity.GetViewEntityDataSet(sql.Replace("1=1", stj), "V_LABITEMS_INFO", ds);
            return (DataSetV_LABITEMS_INFO)ds;
        }
        static string sql2 = @"select distinct VLAB_ID,vitem_name,VPATIENT_ID,DAPPLY_DATE,PATIENTNAME,NSEX,NAGE from V_LABITEMS_INFO where vpatient_id=239";
        public static DataSetV_LABITEMS_INFO SelectHY_LABITEMS_DISTINCT_VLAB_ID(string stj)
        {
            DataSetV_LABITEMS_INFO ds = new DataSetV_LABITEMS_INFO();
            ViewEntity.GetViewEntityDataSet(sql2.Replace("1=1", stj), "V_LABITEMS_INFO", ds);
            return (DataSetV_LABITEMS_INFO)ds;

        }
    }
}