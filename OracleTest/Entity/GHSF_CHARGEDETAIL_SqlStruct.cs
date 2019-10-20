//------------------------------------------------------------------------------
//     这部分代码属于实体定义层，是由实体编辑器工具自动产生的。
//     (Runtime Version: 2.2017.3.2)
//     对此代码进行的任何修改会导致其它的行为错误，并且重新生成时所有的修改会丢失。
//------------------------------------------------------------------------------

using System;
using System.Data;

using System.Data.OracleClient;

//using Gyd.TaskInfo;
using PhoenixDataBaseOperate;

namespace HYGHSF.Entity
{
	
	#region SS_GHSF_CHARGEDETAIL_InsertGHSF_GHSF_CHARGEDETAIL
	/// 
	/// 对于InsertGHSF_GHSF_CHARGEDETAIL的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_CHARGEDETAIL_InsertGHSF_GHSF_CHARGEDETAIL : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_CHARGEDETAIL_InsertGHSF_GHSF_CHARGEDETAIL() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO GHSF.GHSF_CHARGEDETAIL  (VRCPTDETAILID, VRCPTID, VPRESC_ID, VITEM_CODE, VITEM_NAME, VITEM_SPEC, VUNITS, NACCOUNT, NDOSAGE, VDOSAGE_UNITS, VADMINISTRATION, VFREQUENCY, NDAYS, NPRICE, NCOSTS, VITEM_PRODUCT, NSALESCALE, NCHARGEFLAG, NMEDICINEFLAG, DMEDICINEDATE, NBACKDRUGFLAG, DBACKDRUGDATE, NHAVMED, VREMARKS, NACCT_MODE1, NACCT_MODE2, NACCT_MONEY1, NACCT_MONEY2, VPRINTEDRCPTNO, VDRUG_STORAGE, NTOTALCHARGES, VITEM_TYPE, NPRESC, NCOUNT, VISSELF, VDEPT_CODE, NDICTDETAIL_ID)  VALUES (:VRCPTDETAILID, :VRCPTID, :VPRESC_ID, :VITEM_CODE, :VITEM_NAME, :VITEM_SPEC, :VUNITS, :NACCOUNT, :NDOSAGE, :VDOSAGE_UNITS, :VADMINISTRATION, :VFREQUENCY, :NDAYS, :NPRICE, :NCOSTS, :VITEM_PRODUCT, :NSALESCALE, :NCHARGEFLAG, :NMEDICINEFLAG, :DMEDICINEDATE, :NBACKDRUGFLAG, :DBACKDRUGDATE, :NHAVMED, :VREMARKS, :NACCT_MODE1, :NACCT_MODE2, :NACCT_MONEY1, :NACCT_MONEY2, :VPRINTEDRCPTNO, :VDRUG_STORAGE, :NTOTALCHARGES, :VITEM_TYPE, :NPRESC, :NCOUNT, :VISSELF, :VDEPT_CODE, :NDICTDETAIL_ID)";
					
			m_Params.AddParam("VRCPTDETAILID", "VRCPTDETAILID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VRCPTID", "VRCPTID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRESC_ID", "VPRESC_ID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEM_CODE", "VITEM_CODE", DataRowVersion.Current, OracleType.VarChar, 30, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEM_NAME", "VITEM_NAME", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEM_SPEC", "VITEM_SPEC", DataRowVersion.Current, OracleType.NVarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VUNITS", "VUNITS", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NACCOUNT", "NACCOUNT", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NDOSAGE", "NDOSAGE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDOSAGE_UNITS", "VDOSAGE_UNITS", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VADMINISTRATION", "VADMINISTRATION", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VFREQUENCY", "VFREQUENCY", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NDAYS", "NDAYS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NPRICE", "NPRICE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCOSTS", "NCOSTS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEM_PRODUCT", "VITEM_PRODUCT", DataRowVersion.Current, OracleType.VarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("NSALESCALE", "NSALESCALE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCHARGEFLAG", "NCHARGEFLAG", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NMEDICINEFLAG", "NMEDICINEFLAG", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DMEDICINEDATE", "DMEDICINEDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NBACKDRUGFLAG", "NBACKDRUGFLAG", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DBACKDRUGDATE", "DBACKDRUGDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NHAVMED", "NHAVMED", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VREMARKS", "VREMARKS", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NACCT_MODE1", "NACCT_MODE1", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NACCT_MODE2", "NACCT_MODE2", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NACCT_MONEY1", "NACCT_MONEY1", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NACCT_MONEY2", "NACCT_MONEY2", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRINTEDRCPTNO", "VPRINTEDRCPTNO", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VDRUG_STORAGE", "VDRUG_STORAGE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NTOTALCHARGES", "NTOTALCHARGES", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEM_TYPE", "VITEM_TYPE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NPRESC", "NPRESC", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCOUNT", "NCOUNT", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VISSELF", "VISSELF", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPT_CODE", "VDEPT_CODE", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NDICTDETAIL_ID", "NDICTDETAIL_ID", DataRowVersion.Current, OracleType.VarChar, 30, ParameterDirection.Input, null);
		}
				
		public System.String VRCPTDETAILID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRCPTDETAILID"].Value, "System.String");
			}
			set
			{
				m_Params["VRCPTDETAILID"].Value = value;
			}
		}
				
		public System.String VRCPTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRCPTID"].Value, "System.String");
			}
			set
			{
				m_Params["VRCPTID"].Value = value;
			}
		}
				
		public System.String VPRESC_ID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPRESC_ID"].Value, "System.String");
			}
			set
			{
				m_Params["VPRESC_ID"].Value = value;
			}
		}
				
		public System.String VITEM_CODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEM_CODE"].Value, "System.String");
			}
			set
			{
				m_Params["VITEM_CODE"].Value = value;
			}
		}
				
		public System.String VITEM_NAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEM_NAME"].Value, "System.String");
			}
			set
			{
				m_Params["VITEM_NAME"].Value = value;
			}
		}
				
		public System.String VITEM_SPEC
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEM_SPEC"].Value, "System.String");
			}
			set
			{
				m_Params["VITEM_SPEC"].Value = value;
			}
		}
				
		public System.String VUNITS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VUNITS"].Value, "System.String");
			}
			set
			{
				m_Params["VUNITS"].Value = value;
			}
		}
				
		public System.Decimal NACCOUNT
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NACCOUNT"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NACCOUNT"].Value = value;
			}
		}
				
		public System.Decimal NDOSAGE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDOSAGE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDOSAGE"].Value = value;
			}
		}
				
		public System.String VDOSAGE_UNITS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDOSAGE_UNITS"].Value, "System.String");
			}
			set
			{
				m_Params["VDOSAGE_UNITS"].Value = value;
			}
		}
				
		public System.String VADMINISTRATION
		{
			get
			{
				return (System.String)ConverValue(m_Params["VADMINISTRATION"].Value, "System.String");
			}
			set
			{
				m_Params["VADMINISTRATION"].Value = value;
			}
		}
				
		public System.String VFREQUENCY
		{
			get
			{
				return (System.String)ConverValue(m_Params["VFREQUENCY"].Value, "System.String");
			}
			set
			{
				m_Params["VFREQUENCY"].Value = value;
			}
		}
				
		public System.Decimal NDAYS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDAYS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDAYS"].Value = value;
			}
		}
				
		public System.Decimal NPRICE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPRICE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPRICE"].Value = value;
			}
		}
				
		public System.Decimal NCOSTS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCOSTS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCOSTS"].Value = value;
			}
		}
				
		public System.String VITEM_PRODUCT
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEM_PRODUCT"].Value, "System.String");
			}
			set
			{
				m_Params["VITEM_PRODUCT"].Value = value;
			}
		}
				
		public System.Decimal NSALESCALE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSALESCALE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSALESCALE"].Value = value;
			}
		}
				
		public System.Decimal NCHARGEFLAG
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCHARGEFLAG"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCHARGEFLAG"].Value = value;
			}
		}
				
		public System.Decimal NMEDICINEFLAG
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NMEDICINEFLAG"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NMEDICINEFLAG"].Value = value;
			}
		}
				
		public System.DateTime DMEDICINEDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DMEDICINEDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DMEDICINEDATE"].Value = value;
			}
		}
				
		public System.Decimal NBACKDRUGFLAG
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NBACKDRUGFLAG"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NBACKDRUGFLAG"].Value = value;
			}
		}
				
		public System.DateTime DBACKDRUGDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DBACKDRUGDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DBACKDRUGDATE"].Value = value;
			}
		}
				
		public System.Decimal NHAVMED
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NHAVMED"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NHAVMED"].Value = value;
			}
		}
				
		public System.String VREMARKS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VREMARKS"].Value, "System.String");
			}
			set
			{
				m_Params["VREMARKS"].Value = value;
			}
		}
				
		public System.Decimal NACCT_MODE1
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NACCT_MODE1"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NACCT_MODE1"].Value = value;
			}
		}
				
		public System.Decimal NACCT_MODE2
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NACCT_MODE2"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NACCT_MODE2"].Value = value;
			}
		}
				
		public System.Decimal NACCT_MONEY1
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NACCT_MONEY1"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NACCT_MONEY1"].Value = value;
			}
		}
				
		public System.Decimal NACCT_MONEY2
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NACCT_MONEY2"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NACCT_MONEY2"].Value = value;
			}
		}
				
		public System.String VPRINTEDRCPTNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPRINTEDRCPTNO"].Value, "System.String");
			}
			set
			{
				m_Params["VPRINTEDRCPTNO"].Value = value;
			}
		}
				
		public System.String VDRUG_STORAGE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDRUG_STORAGE"].Value, "System.String");
			}
			set
			{
				m_Params["VDRUG_STORAGE"].Value = value;
			}
		}
				
		public System.Decimal NTOTALCHARGES
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NTOTALCHARGES"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NTOTALCHARGES"].Value = value;
			}
		}
				
		public System.String VITEM_TYPE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEM_TYPE"].Value, "System.String");
			}
			set
			{
				m_Params["VITEM_TYPE"].Value = value;
			}
		}
				
		public System.Decimal NPRESC
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPRESC"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPRESC"].Value = value;
			}
		}
				
		public System.Decimal NCOUNT
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCOUNT"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCOUNT"].Value = value;
			}
		}
				
		public System.Decimal VISSELF
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["VISSELF"].Value, "System.Decimal");
			}
			set
			{
				m_Params["VISSELF"].Value = value;
			}
		}
				
		public System.String VDEPT_CODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEPT_CODE"].Value, "System.String");
			}
			set
			{
				m_Params["VDEPT_CODE"].Value = value;
			}
		}
				
		public System.String NDICTDETAIL_ID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NDICTDETAIL_ID"].Value, "System.String");
			}
			set
			{
				m_Params["NDICTDETAIL_ID"].Value = value;
			}
		}
		
		public object ConverValue(object sourceObject, string netType)
		{

			if(sourceObject is System.DBNull)
			{
				if(netType == "System.Decimal" || netType == "System.DateTime")
					throw new Exception("System.Decimal、System.DateTime无法接收空值, 请调整数据库！");
				else
					return null;
			}
			else
			{	
				if(sourceObject is System.Data.OracleClient.OracleString)
					return ((System.Data.OracleClient.OracleString)sourceObject).Value;
				else if(sourceObject is System.Data.OracleClient.OracleNumber)
					return ((System.Data.OracleClient.OracleNumber)sourceObject).Value;
				else  if(sourceObject is System.Data.OracleClient.OracleLob)
					return ((System.Data.OracleClient.OracleLob)sourceObject).Value;
				else if(sourceObject is System.Data.OracleClient.OracleBinary)
					return ((System.Data.OracleClient.OracleBinary)sourceObject).Value;
				else if(sourceObject is System.Data.OracleClient.OracleDateTime)
					return ((System.Data.OracleClient.OracleDateTime)sourceObject).Value;
				else 
					return sourceObject;//throw new Exception(sourceObject.GetType().ToString() + "类型无法对应.Net数据类型！");
			}
      
		}
	} // SS_InsertGHSF_GHSF_CHARGEDETAIL
	#endregion
	
	#region SS_GHSF_CHARGEDETAIL_DeleteGHSF_GHSF_CHARGEDETAIL
	/// 
	/// 对于DeleteGHSF_GHSF_CHARGEDETAIL的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_CHARGEDETAIL_DeleteGHSF_GHSF_CHARGEDETAIL : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_CHARGEDETAIL_DeleteGHSF_GHSF_CHARGEDETAIL() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM GHSF.GHSF_CHARGEDETAIL  WHERE  VRCPTDETAILID = :VRCPTDETAILID";
					
			m_Params.AddParam("VRCPTDETAILID", "VRCPTDETAILID", DataRowVersion.Original, OracleType.VarChar, 10, ParameterDirection.Input, null);
		}
				
		public System.String VRCPTDETAILID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRCPTDETAILID"].Value, "System.String");
			}
			set
			{
				m_Params["VRCPTDETAILID"].Value = value;
			}
		}
		
		public object ConverValue(object sourceObject, string netType)
		{

			if(sourceObject is System.DBNull)
			{
				if(netType == "System.Decimal" || netType == "System.DateTime")
					throw new Exception("System.Decimal、System.DateTime无法接收空值, 请调整数据库！");
				else
					return null;
			}
			else
			{	
				if(sourceObject is System.Data.OracleClient.OracleString)
					return ((System.Data.OracleClient.OracleString)sourceObject).Value;
				else if(sourceObject is System.Data.OracleClient.OracleNumber)
					return ((System.Data.OracleClient.OracleNumber)sourceObject).Value;
				else  if(sourceObject is System.Data.OracleClient.OracleLob)
					return ((System.Data.OracleClient.OracleLob)sourceObject).Value;
				else if(sourceObject is System.Data.OracleClient.OracleBinary)
					return ((System.Data.OracleClient.OracleBinary)sourceObject).Value;
				else if(sourceObject is System.Data.OracleClient.OracleDateTime)
					return ((System.Data.OracleClient.OracleDateTime)sourceObject).Value;
				else 
					return sourceObject;//throw new Exception(sourceObject.GetType().ToString() + "类型无法对应.Net数据类型！");
			}
      
		}
	} // SS_DeleteGHSF_GHSF_CHARGEDETAIL
	#endregion
	
	#region SS_GHSF_CHARGEDETAIL_UpdateGHSF_GHSF_CHARGEDETAIL
	/// 
	/// 对于UpdateGHSF_GHSF_CHARGEDETAIL的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_CHARGEDETAIL_UpdateGHSF_GHSF_CHARGEDETAIL : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_CHARGEDETAIL_UpdateGHSF_GHSF_CHARGEDETAIL() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE GHSF.GHSF_CHARGEDETAIL  SET  VRCPTDETAILID = :VRCPTDETAILID, VRCPTID = :VRCPTID, VPRESC_ID = :VPRESC_ID, VITEM_CODE = :VITEM_CODE, VITEM_NAME = :VITEM_NAME, VITEM_SPEC = :VITEM_SPEC, VUNITS = :VUNITS, NACCOUNT = :NACCOUNT, NDOSAGE = :NDOSAGE, VDOSAGE_UNITS = :VDOSAGE_UNITS, VADMINISTRATION = :VADMINISTRATION, VFREQUENCY = :VFREQUENCY, NDAYS = :NDAYS, NPRICE = :NPRICE, NCOSTS = :NCOSTS, VITEM_PRODUCT = :VITEM_PRODUCT, NSALESCALE = :NSALESCALE, NCHARGEFLAG = :NCHARGEFLAG, NMEDICINEFLAG = :NMEDICINEFLAG, DMEDICINEDATE = :DMEDICINEDATE, NBACKDRUGFLAG = :NBACKDRUGFLAG, DBACKDRUGDATE = :DBACKDRUGDATE, NHAVMED = :NHAVMED, VREMARKS = :VREMARKS, NACCT_MODE1 = :NACCT_MODE1, NACCT_MODE2 = :NACCT_MODE2, NACCT_MONEY1 = :NACCT_MONEY1, NACCT_MONEY2 = :NACCT_MONEY2, VPRINTEDRCPTNO = :VPRINTEDRCPTNO, VDRUG_STORAGE = :VDRUG_STORAGE, NTOTALCHARGES = :NTOTALCHARGES, VITEM_TYPE = :VITEM_TYPE, NPRESC = :NPRESC, NCOUNT = :NCOUNT, VISSELF = :VISSELF, VDEPT_CODE = :VDEPT_CODE, NDICTDETAIL_ID = :NDICTDETAIL_ID   WHERE  VRCPTDETAILID = :OLDVRCPTDETAILID";
					
			m_Params.AddParam("VRCPTDETAILID", "VRCPTDETAILID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VRCPTID", "VRCPTID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRESC_ID", "VPRESC_ID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEM_CODE", "VITEM_CODE", DataRowVersion.Current, OracleType.VarChar, 30, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEM_NAME", "VITEM_NAME", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEM_SPEC", "VITEM_SPEC", DataRowVersion.Current, OracleType.NVarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VUNITS", "VUNITS", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NACCOUNT", "NACCOUNT", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NDOSAGE", "NDOSAGE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDOSAGE_UNITS", "VDOSAGE_UNITS", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VADMINISTRATION", "VADMINISTRATION", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VFREQUENCY", "VFREQUENCY", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NDAYS", "NDAYS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NPRICE", "NPRICE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCOSTS", "NCOSTS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEM_PRODUCT", "VITEM_PRODUCT", DataRowVersion.Current, OracleType.VarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("NSALESCALE", "NSALESCALE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCHARGEFLAG", "NCHARGEFLAG", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NMEDICINEFLAG", "NMEDICINEFLAG", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DMEDICINEDATE", "DMEDICINEDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NBACKDRUGFLAG", "NBACKDRUGFLAG", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DBACKDRUGDATE", "DBACKDRUGDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NHAVMED", "NHAVMED", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VREMARKS", "VREMARKS", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NACCT_MODE1", "NACCT_MODE1", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NACCT_MODE2", "NACCT_MODE2", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NACCT_MONEY1", "NACCT_MONEY1", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NACCT_MONEY2", "NACCT_MONEY2", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRINTEDRCPTNO", "VPRINTEDRCPTNO", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VDRUG_STORAGE", "VDRUG_STORAGE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NTOTALCHARGES", "NTOTALCHARGES", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEM_TYPE", "VITEM_TYPE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NPRESC", "NPRESC", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCOUNT", "NCOUNT", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VISSELF", "VISSELF", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPT_CODE", "VDEPT_CODE", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NDICTDETAIL_ID", "NDICTDETAIL_ID", DataRowVersion.Current, OracleType.VarChar, 30, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDVRCPTDETAILID", "VRCPTDETAILID", DataRowVersion.Original, OracleType.VarChar, 10, ParameterDirection.Input, null);
		}
				
		public System.String VRCPTDETAILID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRCPTDETAILID"].Value, "System.String");
			}
			set
			{
				m_Params["VRCPTDETAILID"].Value = value;
			}
		}
				
		public System.String VRCPTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRCPTID"].Value, "System.String");
			}
			set
			{
				m_Params["VRCPTID"].Value = value;
			}
		}
				
		public System.String VPRESC_ID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPRESC_ID"].Value, "System.String");
			}
			set
			{
				m_Params["VPRESC_ID"].Value = value;
			}
		}
				
		public System.String VITEM_CODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEM_CODE"].Value, "System.String");
			}
			set
			{
				m_Params["VITEM_CODE"].Value = value;
			}
		}
				
		public System.String VITEM_NAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEM_NAME"].Value, "System.String");
			}
			set
			{
				m_Params["VITEM_NAME"].Value = value;
			}
		}
				
		public System.String VITEM_SPEC
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEM_SPEC"].Value, "System.String");
			}
			set
			{
				m_Params["VITEM_SPEC"].Value = value;
			}
		}
				
		public System.String VUNITS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VUNITS"].Value, "System.String");
			}
			set
			{
				m_Params["VUNITS"].Value = value;
			}
		}
				
		public System.Decimal NACCOUNT
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NACCOUNT"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NACCOUNT"].Value = value;
			}
		}
				
		public System.Decimal NDOSAGE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDOSAGE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDOSAGE"].Value = value;
			}
		}
				
		public System.String VDOSAGE_UNITS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDOSAGE_UNITS"].Value, "System.String");
			}
			set
			{
				m_Params["VDOSAGE_UNITS"].Value = value;
			}
		}
				
		public System.String VADMINISTRATION
		{
			get
			{
				return (System.String)ConverValue(m_Params["VADMINISTRATION"].Value, "System.String");
			}
			set
			{
				m_Params["VADMINISTRATION"].Value = value;
			}
		}
				
		public System.String VFREQUENCY
		{
			get
			{
				return (System.String)ConverValue(m_Params["VFREQUENCY"].Value, "System.String");
			}
			set
			{
				m_Params["VFREQUENCY"].Value = value;
			}
		}
				
		public System.Decimal NDAYS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDAYS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDAYS"].Value = value;
			}
		}
				
		public System.Decimal NPRICE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPRICE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPRICE"].Value = value;
			}
		}
				
		public System.Decimal NCOSTS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCOSTS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCOSTS"].Value = value;
			}
		}
				
		public System.String VITEM_PRODUCT
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEM_PRODUCT"].Value, "System.String");
			}
			set
			{
				m_Params["VITEM_PRODUCT"].Value = value;
			}
		}
				
		public System.Decimal NSALESCALE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSALESCALE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSALESCALE"].Value = value;
			}
		}
				
		public System.Decimal NCHARGEFLAG
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCHARGEFLAG"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCHARGEFLAG"].Value = value;
			}
		}
				
		public System.Decimal NMEDICINEFLAG
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NMEDICINEFLAG"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NMEDICINEFLAG"].Value = value;
			}
		}
				
		public System.DateTime DMEDICINEDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DMEDICINEDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DMEDICINEDATE"].Value = value;
			}
		}
				
		public System.Decimal NBACKDRUGFLAG
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NBACKDRUGFLAG"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NBACKDRUGFLAG"].Value = value;
			}
		}
				
		public System.DateTime DBACKDRUGDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DBACKDRUGDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DBACKDRUGDATE"].Value = value;
			}
		}
				
		public System.Decimal NHAVMED
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NHAVMED"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NHAVMED"].Value = value;
			}
		}
				
		public System.String VREMARKS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VREMARKS"].Value, "System.String");
			}
			set
			{
				m_Params["VREMARKS"].Value = value;
			}
		}
				
		public System.Decimal NACCT_MODE1
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NACCT_MODE1"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NACCT_MODE1"].Value = value;
			}
		}
				
		public System.Decimal NACCT_MODE2
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NACCT_MODE2"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NACCT_MODE2"].Value = value;
			}
		}
				
		public System.Decimal NACCT_MONEY1
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NACCT_MONEY1"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NACCT_MONEY1"].Value = value;
			}
		}
				
		public System.Decimal NACCT_MONEY2
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NACCT_MONEY2"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NACCT_MONEY2"].Value = value;
			}
		}
				
		public System.String VPRINTEDRCPTNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPRINTEDRCPTNO"].Value, "System.String");
			}
			set
			{
				m_Params["VPRINTEDRCPTNO"].Value = value;
			}
		}
				
		public System.String VDRUG_STORAGE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDRUG_STORAGE"].Value, "System.String");
			}
			set
			{
				m_Params["VDRUG_STORAGE"].Value = value;
			}
		}
				
		public System.Decimal NTOTALCHARGES
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NTOTALCHARGES"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NTOTALCHARGES"].Value = value;
			}
		}
				
		public System.String VITEM_TYPE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEM_TYPE"].Value, "System.String");
			}
			set
			{
				m_Params["VITEM_TYPE"].Value = value;
			}
		}
				
		public System.Decimal NPRESC
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPRESC"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPRESC"].Value = value;
			}
		}
				
		public System.Decimal NCOUNT
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCOUNT"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCOUNT"].Value = value;
			}
		}
				
		public System.Decimal VISSELF
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["VISSELF"].Value, "System.Decimal");
			}
			set
			{
				m_Params["VISSELF"].Value = value;
			}
		}
				
		public System.String VDEPT_CODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEPT_CODE"].Value, "System.String");
			}
			set
			{
				m_Params["VDEPT_CODE"].Value = value;
			}
		}
				
		public System.String NDICTDETAIL_ID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NDICTDETAIL_ID"].Value, "System.String");
			}
			set
			{
				m_Params["NDICTDETAIL_ID"].Value = value;
			}
		}
				
		public System.String OLDVRCPTDETAILID
		{
			get
			{
				return (System.String)ConverValue(m_Params["OLDVRCPTDETAILID"].Value, "System.String");
			}
			set
			{
				m_Params["OLDVRCPTDETAILID"].Value = value;
			}
		}
		
		public object ConverValue(object sourceObject, string netType)
		{

			if(sourceObject is System.DBNull)
			{
				if(netType == "System.Decimal" || netType == "System.DateTime")
					throw new Exception("System.Decimal、System.DateTime无法接收空值, 请调整数据库！");
				else
					return null;
			}
			else
			{	
				if(sourceObject is System.Data.OracleClient.OracleString)
					return ((System.Data.OracleClient.OracleString)sourceObject).Value;
				else if(sourceObject is System.Data.OracleClient.OracleNumber)
					return ((System.Data.OracleClient.OracleNumber)sourceObject).Value;
				else  if(sourceObject is System.Data.OracleClient.OracleLob)
					return ((System.Data.OracleClient.OracleLob)sourceObject).Value;
				else if(sourceObject is System.Data.OracleClient.OracleBinary)
					return ((System.Data.OracleClient.OracleBinary)sourceObject).Value;
				else if(sourceObject is System.Data.OracleClient.OracleDateTime)
					return ((System.Data.OracleClient.OracleDateTime)sourceObject).Value;
				else 
					return sourceObject;//throw new Exception(sourceObject.GetType().ToString() + "类型无法对应.Net数据类型！");
			}
      
		}
	} // SS_UpdateGHSF_GHSF_CHARGEDETAIL
	#endregion
	
	#region SS_GHSF_CHARGEDETAIL_SelectByIDGHSF_GHSF_CHARGEDETAIL
	/// 
	/// 对于SelectByIDGHSF_GHSF_CHARGEDETAIL的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_CHARGEDETAIL_SelectByIDGHSF_GHSF_CHARGEDETAIL : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_CHARGEDETAIL_SelectByIDGHSF_GHSF_CHARGEDETAIL() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT VRCPTDETAILID, VRCPTID, VPRESC_ID, VITEM_CODE, VITEM_NAME, VITEM_SPEC, VUNITS, NACCOUNT, NDOSAGE, VDOSAGE_UNITS, VADMINISTRATION, VFREQUENCY, NDAYS, NPRICE, NCOSTS, VITEM_PRODUCT, NSALESCALE, NCHARGEFLAG, NMEDICINEFLAG, DMEDICINEDATE, NBACKDRUGFLAG, DBACKDRUGDATE, NHAVMED, VREMARKS, NACCT_MODE1, NACCT_MODE2, NACCT_MONEY1, NACCT_MONEY2, VPRINTEDRCPTNO, VDRUG_STORAGE, NTOTALCHARGES, VITEM_TYPE, NPRESC, NCOUNT, VISSELF, VDEPT_CODE, NDICTDETAIL_ID  FROM GHSF.GHSF_CHARGEDETAIL  WHERE  VRCPTDETAILID = :VRCPTDETAILID";
					
			m_Params.AddParam("VRCPTDETAILID", "VRCPTDETAILID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);
		}
				
		public System.String VRCPTDETAILID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRCPTDETAILID"].Value, "System.String");
			}
			set
			{
				m_Params["VRCPTDETAILID"].Value = value;
			}
		}
		
		public object ConverValue(object sourceObject, string netType)
		{

			if(sourceObject is System.DBNull)
			{
				if(netType == "System.Decimal" || netType == "System.DateTime")
					throw new Exception("System.Decimal、System.DateTime无法接收空值, 请调整数据库！");
				else
					return null;
			}
			else
			{	
				if(sourceObject is System.Data.OracleClient.OracleString)
					return ((System.Data.OracleClient.OracleString)sourceObject).Value;
				else if(sourceObject is System.Data.OracleClient.OracleNumber)
					return ((System.Data.OracleClient.OracleNumber)sourceObject).Value;
				else  if(sourceObject is System.Data.OracleClient.OracleLob)
					return ((System.Data.OracleClient.OracleLob)sourceObject).Value;
				else if(sourceObject is System.Data.OracleClient.OracleBinary)
					return ((System.Data.OracleClient.OracleBinary)sourceObject).Value;
				else if(sourceObject is System.Data.OracleClient.OracleDateTime)
					return ((System.Data.OracleClient.OracleDateTime)sourceObject).Value;
				else 
					return sourceObject;//throw new Exception(sourceObject.GetType().ToString() + "类型无法对应.Net数据类型！");
			}
      
		}
	} // SS_SelectByIDGHSF_GHSF_CHARGEDETAIL
	#endregion
	
	#region SS_GHSF_CHARGEDETAIL_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_CHARGEDETAIL_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_CHARGEDETAIL_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT * FROM GHSF.GHSF_CHARGEDETAIL  WHERE 1=1";
			
		}
		
		public object ConverValue(object sourceObject, string netType)
		{

			if(sourceObject is System.DBNull)
			{
				if(netType == "System.Decimal" || netType == "System.DateTime")
					throw new Exception("System.Decimal、System.DateTime无法接收空值, 请调整数据库！");
				else
					return null;
			}
			else
			{	
				if(sourceObject is System.Data.OracleClient.OracleString)
					return ((System.Data.OracleClient.OracleString)sourceObject).Value;
				else if(sourceObject is System.Data.OracleClient.OracleNumber)
					return ((System.Data.OracleClient.OracleNumber)sourceObject).Value;
				else  if(sourceObject is System.Data.OracleClient.OracleLob)
					return ((System.Data.OracleClient.OracleLob)sourceObject).Value;
				else if(sourceObject is System.Data.OracleClient.OracleBinary)
					return ((System.Data.OracleClient.OracleBinary)sourceObject).Value;
				else if(sourceObject is System.Data.OracleClient.OracleDateTime)
					return ((System.Data.OracleClient.OracleDateTime)sourceObject).Value;
				else 
					return sourceObject;//throw new Exception(sourceObject.GetType().ToString() + "类型无法对应.Net数据类型！");
			}
      
		}
	} // SS_SelectAll
	#endregion
	
	
}
	