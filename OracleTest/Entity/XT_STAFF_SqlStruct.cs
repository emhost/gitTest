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
	
	#region SS_XT_STAFF_InsertXT_XT_STAFF
	/// 
	/// 对于InsertXT_XT_STAFF的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_XT_STAFF_InsertXT_XT_STAFF : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_XT_STAFF_InsertXT_XT_STAFF() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO XT.XT_STAFF  (VSTAFFCODE, VSTAFFNAME, PINYINMA, WUBIMA, VLOGINUSERNAME, VLOGINPASSWORD, NSTAFFSTATUS, NROLEID, VDEPARTCODE, NJOBID, NPROFESSIONID, NOPHZID, NISDUMA, DFHTIME, DTHTIME, VTMETHOD, VSCHOOL, NSEX, NBIRTHDAY, VMINZU, VJIGUAN, VXUELI, NISKSS, NSENDMSG, NHOSID, VYBNO, VSXYS, VSEALCODE, INVOICE_KEY)  VALUES (:VSTAFFCODE, :VSTAFFNAME, :PINYINMA, :WUBIMA, :VLOGINUSERNAME, :VLOGINPASSWORD, :NSTAFFSTATUS, :NROLEID, :VDEPARTCODE, :NJOBID, :NPROFESSIONID, :NOPHZID, :NISDUMA, :DFHTIME, :DTHTIME, :VTMETHOD, :VSCHOOL, :NSEX, :NBIRTHDAY, :VMINZU, :VJIGUAN, :VXUELI, :NISKSS, :NSENDMSG, :NHOSID, :VYBNO, :VSXYS, :VSEALCODE, :INVOICE_KEY)";
					
			m_Params.AddParam("VSTAFFCODE", "VSTAFFCODE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VSTAFFNAME", "VSTAFFNAME", DataRowVersion.Current, OracleType.NVarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("PINYINMA", "PINYINMA", DataRowVersion.Current, OracleType.VarChar, 120, ParameterDirection.Input, null);		
			m_Params.AddParam("WUBIMA", "WUBIMA", DataRowVersion.Current, OracleType.VarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("VLOGINUSERNAME", "VLOGINUSERNAME", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VLOGINPASSWORD", "VLOGINPASSWORD", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("NSTAFFSTATUS", "NSTAFFSTATUS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NROLEID", "NROLEID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPARTCODE", "VDEPARTCODE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NJOBID", "NJOBID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NPROFESSIONID", "NPROFESSIONID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NOPHZID", "NOPHZID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NISDUMA", "NISDUMA", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DFHTIME", "DFHTIME", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DTHTIME", "DTHTIME", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VTMETHOD", "VTMETHOD", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("VSCHOOL", "VSCHOOL", DataRowVersion.Current, OracleType.VarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("NSEX", "NSEX", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NBIRTHDAY", "NBIRTHDAY", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VMINZU", "VMINZU", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VJIGUAN", "VJIGUAN", DataRowVersion.Current, OracleType.VarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("VXUELI", "VXUELI", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NISKSS", "NISKSS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NSENDMSG", "NSENDMSG", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NHOSID", "NHOSID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VYBNO", "VYBNO", DataRowVersion.Current, OracleType.VarChar, 32, ParameterDirection.Input, null);		
			m_Params.AddParam("VSXYS", "VSXYS", DataRowVersion.Current, OracleType.NVarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("VSEALCODE", "VSEALCODE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("INVOICE_KEY", "INVOICE_KEY", DataRowVersion.Current, OracleType.VarChar, 200, ParameterDirection.Input, null);
		}
				
		public System.String VSTAFFCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSTAFFCODE"].Value, "System.String");
			}
			set
			{
				m_Params["VSTAFFCODE"].Value = value;
			}
		}
				
		public System.String VSTAFFNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSTAFFNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VSTAFFNAME"].Value = value;
			}
		}
				
		public System.String PINYINMA
		{
			get
			{
				return (System.String)ConverValue(m_Params["PINYINMA"].Value, "System.String");
			}
			set
			{
				m_Params["PINYINMA"].Value = value;
			}
		}
				
		public System.String WUBIMA
		{
			get
			{
				return (System.String)ConverValue(m_Params["WUBIMA"].Value, "System.String");
			}
			set
			{
				m_Params["WUBIMA"].Value = value;
			}
		}
				
		public System.String VLOGINUSERNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VLOGINUSERNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VLOGINUSERNAME"].Value = value;
			}
		}
				
		public System.String VLOGINPASSWORD
		{
			get
			{
				return (System.String)ConverValue(m_Params["VLOGINPASSWORD"].Value, "System.String");
			}
			set
			{
				m_Params["VLOGINPASSWORD"].Value = value;
			}
		}
				
		public System.Decimal NSTAFFSTATUS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSTAFFSTATUS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSTAFFSTATUS"].Value = value;
			}
		}
				
		public System.Decimal NROLEID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NROLEID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NROLEID"].Value = value;
			}
		}
				
		public System.String VDEPARTCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEPARTCODE"].Value, "System.String");
			}
			set
			{
				m_Params["VDEPARTCODE"].Value = value;
			}
		}
				
		public System.Decimal NJOBID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NJOBID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NJOBID"].Value = value;
			}
		}
				
		public System.Decimal NPROFESSIONID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPROFESSIONID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPROFESSIONID"].Value = value;
			}
		}
				
		public System.Decimal NOPHZID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NOPHZID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NOPHZID"].Value = value;
			}
		}
				
		public System.Decimal NISDUMA
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NISDUMA"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NISDUMA"].Value = value;
			}
		}
				
		public System.DateTime DFHTIME
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DFHTIME"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DFHTIME"].Value = value;
			}
		}
				
		public System.DateTime DTHTIME
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DTHTIME"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DTHTIME"].Value = value;
			}
		}
				
		public System.String VTMETHOD
		{
			get
			{
				return (System.String)ConverValue(m_Params["VTMETHOD"].Value, "System.String");
			}
			set
			{
				m_Params["VTMETHOD"].Value = value;
			}
		}
				
		public System.String VSCHOOL
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSCHOOL"].Value, "System.String");
			}
			set
			{
				m_Params["VSCHOOL"].Value = value;
			}
		}
				
		public System.Decimal NSEX
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSEX"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSEX"].Value = value;
			}
		}
				
		public System.DateTime NBIRTHDAY
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["NBIRTHDAY"].Value, "System.DateTime");
			}
			set
			{
				m_Params["NBIRTHDAY"].Value = value;
			}
		}
				
		public System.String VMINZU
		{
			get
			{
				return (System.String)ConverValue(m_Params["VMINZU"].Value, "System.String");
			}
			set
			{
				m_Params["VMINZU"].Value = value;
			}
		}
				
		public System.String VJIGUAN
		{
			get
			{
				return (System.String)ConverValue(m_Params["VJIGUAN"].Value, "System.String");
			}
			set
			{
				m_Params["VJIGUAN"].Value = value;
			}
		}
				
		public System.String VXUELI
		{
			get
			{
				return (System.String)ConverValue(m_Params["VXUELI"].Value, "System.String");
			}
			set
			{
				m_Params["VXUELI"].Value = value;
			}
		}
				
		public System.Decimal NISKSS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NISKSS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NISKSS"].Value = value;
			}
		}
				
		public System.Decimal NSENDMSG
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSENDMSG"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSENDMSG"].Value = value;
			}
		}
				
		public System.Decimal NHOSID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NHOSID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NHOSID"].Value = value;
			}
		}
				
		public System.String VYBNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VYBNO"].Value, "System.String");
			}
			set
			{
				m_Params["VYBNO"].Value = value;
			}
		}
				
		public System.String VSXYS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSXYS"].Value, "System.String");
			}
			set
			{
				m_Params["VSXYS"].Value = value;
			}
		}
				
		public System.String VSEALCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSEALCODE"].Value, "System.String");
			}
			set
			{
				m_Params["VSEALCODE"].Value = value;
			}
		}
				
		public System.String INVOICE_KEY
		{
			get
			{
				return (System.String)ConverValue(m_Params["INVOICE_KEY"].Value, "System.String");
			}
			set
			{
				m_Params["INVOICE_KEY"].Value = value;
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
	} // SS_InsertXT_XT_STAFF
	#endregion
	
	#region SS_XT_STAFF_DeleteXT_XT_STAFF
	/// 
	/// 对于DeleteXT_XT_STAFF的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_XT_STAFF_DeleteXT_XT_STAFF : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_XT_STAFF_DeleteXT_XT_STAFF() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM XT.XT_STAFF  WHERE  VSTAFFCODE = :VSTAFFCODE";
					
			m_Params.AddParam("VSTAFFCODE", "VSTAFFCODE", DataRowVersion.Original, OracleType.VarChar, 20, ParameterDirection.Input, null);
		}
				
		public System.String VSTAFFCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSTAFFCODE"].Value, "System.String");
			}
			set
			{
				m_Params["VSTAFFCODE"].Value = value;
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
	} // SS_DeleteXT_XT_STAFF
	#endregion
	
	#region SS_XT_STAFF_UpdateXT_XT_STAFF
	/// 
	/// 对于UpdateXT_XT_STAFF的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_XT_STAFF_UpdateXT_XT_STAFF : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_XT_STAFF_UpdateXT_XT_STAFF() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE XT.XT_STAFF  SET  VSTAFFCODE = :VSTAFFCODE, VSTAFFNAME = :VSTAFFNAME, PINYINMA = :PINYINMA, WUBIMA = :WUBIMA, VLOGINUSERNAME = :VLOGINUSERNAME, VLOGINPASSWORD = :VLOGINPASSWORD, NSTAFFSTATUS = :NSTAFFSTATUS, NROLEID = :NROLEID, VDEPARTCODE = :VDEPARTCODE, NJOBID = :NJOBID, NPROFESSIONID = :NPROFESSIONID, NOPHZID = :NOPHZID, NISDUMA = :NISDUMA, DFHTIME = :DFHTIME, DTHTIME = :DTHTIME, VTMETHOD = :VTMETHOD, VSCHOOL = :VSCHOOL, NSEX = :NSEX, NBIRTHDAY = :NBIRTHDAY, VMINZU = :VMINZU, VJIGUAN = :VJIGUAN, VXUELI = :VXUELI, NISKSS = :NISKSS, NSENDMSG = :NSENDMSG, NHOSID = :NHOSID, VYBNO = :VYBNO, VSXYS = :VSXYS, VSEALCODE = :VSEALCODE, INVOICE_KEY = :INVOICE_KEY   WHERE  VSTAFFCODE = :OLDVSTAFFCODE";
					
			m_Params.AddParam("VSTAFFCODE", "VSTAFFCODE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VSTAFFNAME", "VSTAFFNAME", DataRowVersion.Current, OracleType.NVarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("PINYINMA", "PINYINMA", DataRowVersion.Current, OracleType.VarChar, 120, ParameterDirection.Input, null);		
			m_Params.AddParam("WUBIMA", "WUBIMA", DataRowVersion.Current, OracleType.VarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("VLOGINUSERNAME", "VLOGINUSERNAME", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VLOGINPASSWORD", "VLOGINPASSWORD", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("NSTAFFSTATUS", "NSTAFFSTATUS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NROLEID", "NROLEID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPARTCODE", "VDEPARTCODE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NJOBID", "NJOBID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NPROFESSIONID", "NPROFESSIONID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NOPHZID", "NOPHZID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NISDUMA", "NISDUMA", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DFHTIME", "DFHTIME", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DTHTIME", "DTHTIME", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VTMETHOD", "VTMETHOD", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("VSCHOOL", "VSCHOOL", DataRowVersion.Current, OracleType.VarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("NSEX", "NSEX", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NBIRTHDAY", "NBIRTHDAY", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VMINZU", "VMINZU", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VJIGUAN", "VJIGUAN", DataRowVersion.Current, OracleType.VarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("VXUELI", "VXUELI", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NISKSS", "NISKSS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NSENDMSG", "NSENDMSG", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NHOSID", "NHOSID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VYBNO", "VYBNO", DataRowVersion.Current, OracleType.VarChar, 32, ParameterDirection.Input, null);		
			m_Params.AddParam("VSXYS", "VSXYS", DataRowVersion.Current, OracleType.NVarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("VSEALCODE", "VSEALCODE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("INVOICE_KEY", "INVOICE_KEY", DataRowVersion.Current, OracleType.VarChar, 200, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDVSTAFFCODE", "VSTAFFCODE", DataRowVersion.Original, OracleType.VarChar, 20, ParameterDirection.Input, null);
		}
				
		public System.String VSTAFFCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSTAFFCODE"].Value, "System.String");
			}
			set
			{
				m_Params["VSTAFFCODE"].Value = value;
			}
		}
				
		public System.String VSTAFFNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSTAFFNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VSTAFFNAME"].Value = value;
			}
		}
				
		public System.String PINYINMA
		{
			get
			{
				return (System.String)ConverValue(m_Params["PINYINMA"].Value, "System.String");
			}
			set
			{
				m_Params["PINYINMA"].Value = value;
			}
		}
				
		public System.String WUBIMA
		{
			get
			{
				return (System.String)ConverValue(m_Params["WUBIMA"].Value, "System.String");
			}
			set
			{
				m_Params["WUBIMA"].Value = value;
			}
		}
				
		public System.String VLOGINUSERNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VLOGINUSERNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VLOGINUSERNAME"].Value = value;
			}
		}
				
		public System.String VLOGINPASSWORD
		{
			get
			{
				return (System.String)ConverValue(m_Params["VLOGINPASSWORD"].Value, "System.String");
			}
			set
			{
				m_Params["VLOGINPASSWORD"].Value = value;
			}
		}
				
		public System.Decimal NSTAFFSTATUS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSTAFFSTATUS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSTAFFSTATUS"].Value = value;
			}
		}
				
		public System.Decimal NROLEID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NROLEID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NROLEID"].Value = value;
			}
		}
				
		public System.String VDEPARTCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEPARTCODE"].Value, "System.String");
			}
			set
			{
				m_Params["VDEPARTCODE"].Value = value;
			}
		}
				
		public System.Decimal NJOBID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NJOBID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NJOBID"].Value = value;
			}
		}
				
		public System.Decimal NPROFESSIONID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPROFESSIONID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPROFESSIONID"].Value = value;
			}
		}
				
		public System.Decimal NOPHZID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NOPHZID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NOPHZID"].Value = value;
			}
		}
				
		public System.Decimal NISDUMA
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NISDUMA"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NISDUMA"].Value = value;
			}
		}
				
		public System.DateTime DFHTIME
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DFHTIME"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DFHTIME"].Value = value;
			}
		}
				
		public System.DateTime DTHTIME
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DTHTIME"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DTHTIME"].Value = value;
			}
		}
				
		public System.String VTMETHOD
		{
			get
			{
				return (System.String)ConverValue(m_Params["VTMETHOD"].Value, "System.String");
			}
			set
			{
				m_Params["VTMETHOD"].Value = value;
			}
		}
				
		public System.String VSCHOOL
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSCHOOL"].Value, "System.String");
			}
			set
			{
				m_Params["VSCHOOL"].Value = value;
			}
		}
				
		public System.Decimal NSEX
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSEX"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSEX"].Value = value;
			}
		}
				
		public System.DateTime NBIRTHDAY
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["NBIRTHDAY"].Value, "System.DateTime");
			}
			set
			{
				m_Params["NBIRTHDAY"].Value = value;
			}
		}
				
		public System.String VMINZU
		{
			get
			{
				return (System.String)ConverValue(m_Params["VMINZU"].Value, "System.String");
			}
			set
			{
				m_Params["VMINZU"].Value = value;
			}
		}
				
		public System.String VJIGUAN
		{
			get
			{
				return (System.String)ConverValue(m_Params["VJIGUAN"].Value, "System.String");
			}
			set
			{
				m_Params["VJIGUAN"].Value = value;
			}
		}
				
		public System.String VXUELI
		{
			get
			{
				return (System.String)ConverValue(m_Params["VXUELI"].Value, "System.String");
			}
			set
			{
				m_Params["VXUELI"].Value = value;
			}
		}
				
		public System.Decimal NISKSS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NISKSS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NISKSS"].Value = value;
			}
		}
				
		public System.Decimal NSENDMSG
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSENDMSG"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSENDMSG"].Value = value;
			}
		}
				
		public System.Decimal NHOSID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NHOSID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NHOSID"].Value = value;
			}
		}
				
		public System.String VYBNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VYBNO"].Value, "System.String");
			}
			set
			{
				m_Params["VYBNO"].Value = value;
			}
		}
				
		public System.String VSXYS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSXYS"].Value, "System.String");
			}
			set
			{
				m_Params["VSXYS"].Value = value;
			}
		}
				
		public System.String VSEALCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSEALCODE"].Value, "System.String");
			}
			set
			{
				m_Params["VSEALCODE"].Value = value;
			}
		}
				
		public System.String INVOICE_KEY
		{
			get
			{
				return (System.String)ConverValue(m_Params["INVOICE_KEY"].Value, "System.String");
			}
			set
			{
				m_Params["INVOICE_KEY"].Value = value;
			}
		}
				
		public System.String OLDVSTAFFCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["OLDVSTAFFCODE"].Value, "System.String");
			}
			set
			{
				m_Params["OLDVSTAFFCODE"].Value = value;
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
	} // SS_UpdateXT_XT_STAFF
	#endregion
	
	#region SS_XT_STAFF_SelectByIDXT_XT_STAFF
	/// 
	/// 对于SelectByIDXT_XT_STAFF的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_XT_STAFF_SelectByIDXT_XT_STAFF : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_XT_STAFF_SelectByIDXT_XT_STAFF() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT VSTAFFCODE, VSTAFFNAME, PINYINMA, WUBIMA, VLOGINUSERNAME, VLOGINPASSWORD, NSTAFFSTATUS, NROLEID, VDEPARTCODE, NJOBID, NPROFESSIONID, NOPHZID, NISDUMA, DFHTIME, DTHTIME, VTMETHOD, VSCHOOL, NSEX, NBIRTHDAY, VMINZU, VJIGUAN, VXUELI, NISKSS, NSENDMSG, NHOSID, VYBNO, VSXYS, VSEALCODE, INVOICE_KEY  FROM XT.XT_STAFF  WHERE  VSTAFFCODE = :VSTAFFCODE";
					
			m_Params.AddParam("VSTAFFCODE", "VSTAFFCODE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);
		}
				
		public System.String VSTAFFCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSTAFFCODE"].Value, "System.String");
			}
			set
			{
				m_Params["VSTAFFCODE"].Value = value;
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
	} // SS_SelectByIDXT_XT_STAFF
	#endregion
	
	#region SS_XT_STAFF_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_XT_STAFF_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_XT_STAFF_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT * FROM XT.XT_STAFF  WHERE 1=1";
			
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
	