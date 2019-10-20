using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PhoenixDataBaseOperate;
using System.Data;

namespace HYHISAPPS.Entity.Dao
{
    /// <summary>
    /// 查询视图数据
    /// </summary>
    public static class ViewEntity
    {
        /// <summary>
        /// 查询视图
        /// </summary>
        /// <param name="sql">视图sql</param>
        /// <param name="viewName">视图名称</param>
        /// <param name="ds"></param>
        /// <param name="idb"></param>
        /// <returns></returns>
        public static DataSet GetViewEntityDataSet(string sql, string viewName, DataSet ds, PhoenixDataBaseOperate.IDataBaseOperate idb = null)
        {
            if (idb == null)
            {
                using (idb = PhoenixDataBaseConnect.GenerateFactory.GenerateConnect())
                {
                    ViewSqlClass vsc = new ViewSqlClass();
                    vsc.SqlString = sql;

                    idb.FillDataSet(vsc, ds, viewName);
                }
            }
            else
            {
                ViewSqlClass vsc = new ViewSqlClass();
                vsc.SqlString = sql;

                idb.FillDataSet(vsc, ds, viewName);
            }
            return ds;
        }
    }

    public class ViewSqlClass : SqlClass
    {
        public ViewSqlClass()
            : base()
        {
        }
    }
}
