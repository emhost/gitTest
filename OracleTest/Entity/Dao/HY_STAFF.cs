using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HYHISAPPS.Entity.Dao;
using HYHISAPPView.Entity;

namespace HYHISAPPS.Entity.Dao
{
    public sealed class HY_STAFF
    {
        #region strsql
        static string sql =
            @"SELECT T.VSTAFFCODE AS VSTAFFCODE,
       T.VSTAFFNAME AS VSTAFFNAME,
       T.NSEX,
       DECODE(T.NSEX, 1, '男', 2, '女') AS SEXNAME,
       to_char(T.NBIRTHDAY,'yyyy-mm-dd') as NBIRTHDAY,
       T.VLOGINUSERNAME AS VLOGINUSERNAME,
       T.VLOGINPASSWORD AS VLOGINPASSWORD,
       T.NSTAFFSTATUS,
       DECODE(T.NSTAFFSTATUS, 0, '是', 1, '否') ISSTOP,
       T.NJOBID,
       DECODE(T.NJOBID,0,'医生',1,'护士') AS JOBNAME,
       T.VDEPARTCODE,
       D.VDEPARTNAME,
       T.NROLEID,
       R.VROLENAME,
       T.NPROFESSIONID,
       F.VPROFESSIONNAME
  FROM XT.XT_STAFF T
  LEFT JOIN xt.XT_DICDEPART D
    ON T.VDEPARTCODE = D.VDEPARTCODE
  LEFT JOIN xt.XT_DICROLE R
    ON T.NROLEID = R.NROLEID
  LEFT JOIN xt.XT_DICPROFESSION F
    ON T.NPROFESSIONID = F.NPROFESSIONID
    WHERE 1=1";
        #endregion

        public static DataSetHY_STAFF SelectHY_STAFF(string stj)
        {
            DataSetHY_STAFF ds = new DataSetHY_STAFF();
            ViewEntity.GetViewEntityDataSet(sql.Replace("1=1", stj), "HY_STAFF", ds);
            return (DataSetHY_STAFF)ds;
        }
    }
}