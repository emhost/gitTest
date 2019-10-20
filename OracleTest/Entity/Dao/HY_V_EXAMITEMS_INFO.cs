using System; 
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HYHISAPPView.Entity;

namespace HYHISAPPS.Entity.Dao
{
    public sealed class HY_V_EXAMITEMS_INFO
    {
        #region strsql
        static string sql =
            @"SELECT * FROM V_EXAMITEMS_INFO WHERE 1=1";
        #endregion

        public static DataSetV_EXAMITEMS_INFO SelectHY_EXAMITEMS(string stj)
        {
            DataSetV_EXAMITEMS_INFO ds = new DataSetV_EXAMITEMS_INFO();
            ViewEntity.GetViewEntityDataSet(sql.Replace("1=1", stj), "V_EXAMITEMS_INFO", ds);
            return (DataSetV_EXAMITEMS_INFO)ds;
        }
    }
}