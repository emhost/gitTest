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

namespace HYHISAPP.Entity
{
	
	#region SS_TJ_PACKAGE_InsertTJ_TJ_PACKAGE
	/// 
	/// 对于InsertTJ_TJ_PACKAGE的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TJ_PACKAGE_InsertTJ_TJ_PACKAGE : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TJ_PACKAGE_InsertTJ_TJ_PACKAGE() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO TJ.TJ_PACKAGE  (NPACKAGEID, VPEGROUPNAME, WUBIMA, PINYINMA, NVPRICE, NISDISCOUNTS, NDISCOUNTS, NMONEY, NENABLE, VDESCRIPTION, NHOSID, NPACKAGETYPE, CREATE_DATE, CREATE_DEPT, CREATE_DOCT, LAST_DATE, LAST_DOCT, NORGAID)  VALUES (:NPACKAGEID, :VPEGROUPNAME, :WUBIMA, :PINYINMA, :NVPRICE, :NISDISCOUNTS, :NDISCOUNTS, :NMONEY, :NENABLE, :VDESCRIPTION, :NHOSID, :NPACKAGETYPE, :CREATE_DATE, :CREATE_DEPT, :CREATE_DOCT, :LAST_DATE, :LAST_DOCT, :NORGAID)";
					
			m_Params.AddParam("NPACKAGEID", "NPACKAGEID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VPEGROUPNAME", "VPEGROUPNAME", DataRowVersion.Current, OracleType.NVarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("WUBIMA", "WUBIMA", DataRowVersion.Current, OracleType.VarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("PINYINMA", "PINYINMA", DataRowVersion.Current, OracleType.VarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("NVPRICE", "NVPRICE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NISDISCOUNTS", "NISDISCOUNTS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NDISCOUNTS", "NDISCOUNTS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NMONEY", "NMONEY", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NENABLE", "NENABLE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDESCRIPTION", "VDESCRIPTION", DataRowVersion.Current, OracleType.NVarChar, 255, ParameterDirection.Input, null);		
			m_Params.AddParam("NHOSID", "NHOSID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NPACKAGETYPE", "NPACKAGETYPE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATE_DATE", "CREATE_DATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATE_DEPT", "CREATE_DEPT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATE_DOCT", "CREATE_DOCT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("LAST_DATE", "LAST_DATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("LAST_DOCT", "LAST_DOCT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NORGAID", "NORGAID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.String NPACKAGEID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NPACKAGEID"].Value, "System.String");
			}
			set
			{
				m_Params["NPACKAGEID"].Value = value;
			}
		}
				
		public System.String VPEGROUPNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPEGROUPNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VPEGROUPNAME"].Value = value;
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
				
		public System.Decimal NVPRICE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NVPRICE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NVPRICE"].Value = value;
			}
		}
				
		public System.Decimal NISDISCOUNTS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NISDISCOUNTS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NISDISCOUNTS"].Value = value;
			}
		}
				
		public System.Decimal NDISCOUNTS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDISCOUNTS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDISCOUNTS"].Value = value;
			}
		}
				
		public System.Decimal NMONEY
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NMONEY"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NMONEY"].Value = value;
			}
		}
				
		public System.Decimal NENABLE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NENABLE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NENABLE"].Value = value;
			}
		}
				
		public System.String VDESCRIPTION
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDESCRIPTION"].Value, "System.String");
			}
			set
			{
				m_Params["VDESCRIPTION"].Value = value;
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
				
		public System.Decimal NPACKAGETYPE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPACKAGETYPE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPACKAGETYPE"].Value = value;
			}
		}
				
		public System.DateTime CREATE_DATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["CREATE_DATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["CREATE_DATE"].Value = value;
			}
		}
				
		public System.String CREATE_DEPT
		{
			get
			{
				return (System.String)ConverValue(m_Params["CREATE_DEPT"].Value, "System.String");
			}
			set
			{
				m_Params["CREATE_DEPT"].Value = value;
			}
		}
				
		public System.String CREATE_DOCT
		{
			get
			{
				return (System.String)ConverValue(m_Params["CREATE_DOCT"].Value, "System.String");
			}
			set
			{
				m_Params["CREATE_DOCT"].Value = value;
			}
		}
				
		public System.DateTime LAST_DATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["LAST_DATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["LAST_DATE"].Value = value;
			}
		}
				
		public System.String LAST_DOCT
		{
			get
			{
				return (System.String)ConverValue(m_Params["LAST_DOCT"].Value, "System.String");
			}
			set
			{
				m_Params["LAST_DOCT"].Value = value;
			}
		}
				
		public System.String NORGAID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NORGAID"].Value, "System.String");
			}
			set
			{
				m_Params["NORGAID"].Value = value;
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
	} // SS_InsertTJ_TJ_PACKAGE
	#endregion
	
	#region SS_TJ_PACKAGE_DeleteTJ_TJ_PACKAGE
	/// 
	/// 对于DeleteTJ_TJ_PACKAGE的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TJ_PACKAGE_DeleteTJ_TJ_PACKAGE : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TJ_PACKAGE_DeleteTJ_TJ_PACKAGE() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM TJ.TJ_PACKAGE  WHERE  NPACKAGEID = :NPACKAGEID";
					
			m_Params.AddParam("NPACKAGEID", "NPACKAGEID", DataRowVersion.Original, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.String NPACKAGEID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NPACKAGEID"].Value, "System.String");
			}
			set
			{
				m_Params["NPACKAGEID"].Value = value;
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
	} // SS_DeleteTJ_TJ_PACKAGE
	#endregion
	
	#region SS_TJ_PACKAGE_UpdateTJ_TJ_PACKAGE
	/// 
	/// 对于UpdateTJ_TJ_PACKAGE的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TJ_PACKAGE_UpdateTJ_TJ_PACKAGE : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TJ_PACKAGE_UpdateTJ_TJ_PACKAGE() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE TJ.TJ_PACKAGE  SET  NPACKAGEID = :NPACKAGEID, VPEGROUPNAME = :VPEGROUPNAME, WUBIMA = :WUBIMA, PINYINMA = :PINYINMA, NVPRICE = :NVPRICE, NISDISCOUNTS = :NISDISCOUNTS, NDISCOUNTS = :NDISCOUNTS, NMONEY = :NMONEY, NENABLE = :NENABLE, VDESCRIPTION = :VDESCRIPTION, NHOSID = :NHOSID, NPACKAGETYPE = :NPACKAGETYPE, CREATE_DATE = :CREATE_DATE, CREATE_DEPT = :CREATE_DEPT, CREATE_DOCT = :CREATE_DOCT, LAST_DATE = :LAST_DATE, LAST_DOCT = :LAST_DOCT, NORGAID = :NORGAID   WHERE  NPACKAGEID = :OLDNPACKAGEID";
					
			m_Params.AddParam("NPACKAGEID", "NPACKAGEID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VPEGROUPNAME", "VPEGROUPNAME", DataRowVersion.Current, OracleType.NVarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("WUBIMA", "WUBIMA", DataRowVersion.Current, OracleType.VarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("PINYINMA", "PINYINMA", DataRowVersion.Current, OracleType.VarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("NVPRICE", "NVPRICE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NISDISCOUNTS", "NISDISCOUNTS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NDISCOUNTS", "NDISCOUNTS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NMONEY", "NMONEY", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NENABLE", "NENABLE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDESCRIPTION", "VDESCRIPTION", DataRowVersion.Current, OracleType.NVarChar, 255, ParameterDirection.Input, null);		
			m_Params.AddParam("NHOSID", "NHOSID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NPACKAGETYPE", "NPACKAGETYPE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATE_DATE", "CREATE_DATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATE_DEPT", "CREATE_DEPT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATE_DOCT", "CREATE_DOCT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("LAST_DATE", "LAST_DATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("LAST_DOCT", "LAST_DOCT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NORGAID", "NORGAID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDNPACKAGEID", "NPACKAGEID", DataRowVersion.Original, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.String NPACKAGEID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NPACKAGEID"].Value, "System.String");
			}
			set
			{
				m_Params["NPACKAGEID"].Value = value;
			}
		}
				
		public System.String VPEGROUPNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPEGROUPNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VPEGROUPNAME"].Value = value;
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
				
		public System.Decimal NVPRICE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NVPRICE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NVPRICE"].Value = value;
			}
		}
				
		public System.Decimal NISDISCOUNTS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NISDISCOUNTS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NISDISCOUNTS"].Value = value;
			}
		}
				
		public System.Decimal NDISCOUNTS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDISCOUNTS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDISCOUNTS"].Value = value;
			}
		}
				
		public System.Decimal NMONEY
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NMONEY"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NMONEY"].Value = value;
			}
		}
				
		public System.Decimal NENABLE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NENABLE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NENABLE"].Value = value;
			}
		}
				
		public System.String VDESCRIPTION
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDESCRIPTION"].Value, "System.String");
			}
			set
			{
				m_Params["VDESCRIPTION"].Value = value;
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
				
		public System.Decimal NPACKAGETYPE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPACKAGETYPE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPACKAGETYPE"].Value = value;
			}
		}
				
		public System.DateTime CREATE_DATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["CREATE_DATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["CREATE_DATE"].Value = value;
			}
		}
				
		public System.String CREATE_DEPT
		{
			get
			{
				return (System.String)ConverValue(m_Params["CREATE_DEPT"].Value, "System.String");
			}
			set
			{
				m_Params["CREATE_DEPT"].Value = value;
			}
		}
				
		public System.String CREATE_DOCT
		{
			get
			{
				return (System.String)ConverValue(m_Params["CREATE_DOCT"].Value, "System.String");
			}
			set
			{
				m_Params["CREATE_DOCT"].Value = value;
			}
		}
				
		public System.DateTime LAST_DATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["LAST_DATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["LAST_DATE"].Value = value;
			}
		}
				
		public System.String LAST_DOCT
		{
			get
			{
				return (System.String)ConverValue(m_Params["LAST_DOCT"].Value, "System.String");
			}
			set
			{
				m_Params["LAST_DOCT"].Value = value;
			}
		}
				
		public System.String NORGAID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NORGAID"].Value, "System.String");
			}
			set
			{
				m_Params["NORGAID"].Value = value;
			}
		}
				
		public System.String OLDNPACKAGEID
		{
			get
			{
				return (System.String)ConverValue(m_Params["OLDNPACKAGEID"].Value, "System.String");
			}
			set
			{
				m_Params["OLDNPACKAGEID"].Value = value;
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
	} // SS_UpdateTJ_TJ_PACKAGE
	#endregion
	
	#region SS_TJ_PACKAGE_SelectByIDTJ_TJ_PACKAGE
	/// 
	/// 对于SelectByIDTJ_TJ_PACKAGE的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TJ_PACKAGE_SelectByIDTJ_TJ_PACKAGE : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TJ_PACKAGE_SelectByIDTJ_TJ_PACKAGE() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT NPACKAGEID, VPEGROUPNAME, WUBIMA, PINYINMA, NVPRICE, NISDISCOUNTS, NDISCOUNTS, NMONEY, NENABLE, VDESCRIPTION, NHOSID, NPACKAGETYPE, CREATE_DATE, CREATE_DEPT, CREATE_DOCT, LAST_DATE, LAST_DOCT, NORGAID  FROM TJ.TJ_PACKAGE  WHERE  NPACKAGEID = :NPACKAGEID";
					
			m_Params.AddParam("NPACKAGEID", "NPACKAGEID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.String NPACKAGEID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NPACKAGEID"].Value, "System.String");
			}
			set
			{
				m_Params["NPACKAGEID"].Value = value;
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
	} // SS_SelectByIDTJ_TJ_PACKAGE
	#endregion
	
	#region SS_TJ_PACKAGE_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TJ_PACKAGE_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TJ_PACKAGE_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "select * from tj.TJ_PACKAGE where 1=1";
			
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
	