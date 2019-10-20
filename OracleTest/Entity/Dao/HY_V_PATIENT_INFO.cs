using HYHISAPPView.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HYHISAPPS.Entity.Dao
{
    public class HY_V_PATIENT_INFO
    {
        static string sql = "select * from V_PATIENT_BASIC_INFO where 1=1";
        public static DataSetV_PATIENT_BASIC_INFO SelectHY_PATIENTINFO(string stj)
        {
            DataSetV_PATIENT_BASIC_INFO ds = new DataSetV_PATIENT_BASIC_INFO();
            ViewEntity.GetViewEntityDataSet(sql.Replace("1=1", stj), "V_PATIENT_BASIC_INFO", ds);
            return (DataSetV_PATIENT_BASIC_INFO)ds;
        }
    }
}