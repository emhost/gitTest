using System;
using System.Collections.Generic;
using System.Data;
using System.Linq; 
using System.Text;
using System.Web; 

namespace HYHISAPPS.Models.Util
{
    public class Common
    {
        

        internal static DataTable SelectTable(string sql)
        {
            PhoenixDataBaseOperate.IDataBaseOperate operate = PhoenixDataBaseConnect.GenerateFactory.GenerateConnect();
            DataTable dt = operate.ExecDataSql(sql);
            operate.Dispose();

            return dt;
        }


        internal static void WriteErrLog(string msg)
        {
            string id = Guid.NewGuid().ToString();
            string txt = msg;
            string date = "to_date('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-mm-dd hh24:mi:ss')";
            string sql = "insert into ywapp.errorlog values('{0}','{1}',{2})";
            sql = string.Format(sql, id, txt, date);
            PhoenixDataBaseOperate.IDataBaseOperate operate = PhoenixDataBaseConnect.GenerateFactory.GenerateConnect();
            operate.ExecSingleSql(sql, true);
            operate.Dispose();
        }

        public void test()
        { 
        
        }
       


    }
}