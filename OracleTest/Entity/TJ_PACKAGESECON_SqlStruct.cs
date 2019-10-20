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
	
	#region SS_TJ_PACKAGESECON_InsertTJ_TJ_PACKAGESECON
	/// 
	/// 对于InsertTJ_TJ_PACKAGESECON的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TJ_PACKAGESECON_InsertTJ_TJ_PACKAGESECON : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TJ_PACKAGESECON_InsertTJ_TJ_PACKAGESECON() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO TJ.TJ_PACKAGESECON  (CREATEDEPARTID, CREATEDEPARTNAME, NSECID, NPACKAGEID, NITEMID, VITEMNAME, NVPRICE, NISDISCOUNTS, NDISCOUNTS, NMONEY, CREATEDATE, CREATESTAFFCODE, CREATESTAFFNAME)  VALUES (:CREATEDEPARTID, :CREATEDEPARTNAME, :NSECID, :NPACKAGEID, :NITEMID, :VITEMNAME, :NVPRICE, :NISDISCOUNTS, :NDISCOUNTS, :NMONEY, :CREATEDATE, :CREATESTAFFCODE, :CREATESTAFFNAME)";
					
			m_Params.AddParam("CREATEDEPARTID", "CREATEDEPARTID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATEDEPARTNAME", "CREATEDEPARTNAME", DataRowVersion.Current, OracleType.NVarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("NSECID", "NSECID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("NPACKAGEID", "NPACKAGEID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("NITEMID", "NITEMID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEMNAME", "VITEMNAME", DataRowVersion.Current, OracleType.NVarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("NVPRICE", "NVPRICE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NISDISCOUNTS", "NISDISCOUNTS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NDISCOUNTS", "NDISCOUNTS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NMONEY", "NMONEY", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATEDATE", "CREATEDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATESTAFFCODE", "CREATESTAFFCODE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATESTAFFNAME", "CREATESTAFFNAME", DataRowVersion.Current, OracleType.NVarChar, 60, ParameterDirection.Input, null);
		}
				
		public System.String CREATEDEPARTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["CREATEDEPARTID"].Value, "System.String");
			}
			set
			{
				m_Params["CREATEDEPARTID"].Value = value;
			}
		}
				
		public System.String CREATEDEPARTNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["CREATEDEPARTNAME"].Value, "System.String");
			}
			set
			{
				m_Params["CREATEDEPARTNAME"].Value = value;
			}
		}
				
		public System.String NSECID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NSECID"].Value, "System.String");
			}
			set
			{
				m_Params["NSECID"].Value = value;
			}
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
				
		public System.String NITEMID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NITEMID"].Value, "System.String");
			}
			set
			{
				m_Params["NITEMID"].Value = value;
			}
		}
				
		public System.String VITEMNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEMNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VITEMNAME"].Value = value;
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
				
		public System.DateTime CREATEDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["CREATEDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["CREATEDATE"].Value = value;
			}
		}
				
		public System.String CREATESTAFFCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["CREATESTAFFCODE"].Value, "System.String");
			}
			set
			{
				m_Params["CREATESTAFFCODE"].Value = value;
			}
		}
				
		public System.String CREATESTAFFNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["CREATESTAFFNAME"].Value, "System.String");
			}
			set
			{
				m_Params["CREATESTAFFNAME"].Value = value;
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
	} // SS_InsertTJ_TJ_PACKAGESECON
	#endregion
	
	#region SS_TJ_PACKAGESECON_DeleteTJ_TJ_PACKAGESECON
	/// 
	/// 对于DeleteTJ_TJ_PACKAGESECON的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TJ_PACKAGESECON_DeleteTJ_TJ_PACKAGESECON : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TJ_PACKAGESECON_DeleteTJ_TJ_PACKAGESECON() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM TJ.TJ_PACKAGESECON  WHERE  NSECID = :NSECID";
					
			m_Params.AddParam("NSECID", "NSECID", DataRowVersion.Original, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.String NSECID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NSECID"].Value, "System.String");
			}
			set
			{
				m_Params["NSECID"].Value = value;
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
	} // SS_DeleteTJ_TJ_PACKAGESECON
	#endregion
	
	#region SS_TJ_PACKAGESECON_UpdateTJ_TJ_PACKAGESECON
	/// 
	/// 对于UpdateTJ_TJ_PACKAGESECON的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TJ_PACKAGESECON_UpdateTJ_TJ_PACKAGESECON : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TJ_PACKAGESECON_UpdateTJ_TJ_PACKAGESECON() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE TJ.TJ_PACKAGESECON  SET  CREATEDEPARTID = :CREATEDEPARTID, CREATEDEPARTNAME = :CREATEDEPARTNAME, NSECID = :NSECID, NPACKAGEID = :NPACKAGEID, NITEMID = :NITEMID, VITEMNAME = :VITEMNAME, NVPRICE = :NVPRICE, NISDISCOUNTS = :NISDISCOUNTS, NDISCOUNTS = :NDISCOUNTS, NMONEY = :NMONEY, CREATEDATE = :CREATEDATE, CREATESTAFFCODE = :CREATESTAFFCODE, CREATESTAFFNAME = :CREATESTAFFNAME   WHERE  NSECID = :OLDNSECID";
					
			m_Params.AddParam("CREATEDEPARTID", "CREATEDEPARTID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATEDEPARTNAME", "CREATEDEPARTNAME", DataRowVersion.Current, OracleType.NVarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("NSECID", "NSECID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("NPACKAGEID", "NPACKAGEID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("NITEMID", "NITEMID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEMNAME", "VITEMNAME", DataRowVersion.Current, OracleType.NVarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("NVPRICE", "NVPRICE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NISDISCOUNTS", "NISDISCOUNTS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NDISCOUNTS", "NDISCOUNTS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NMONEY", "NMONEY", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATEDATE", "CREATEDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATESTAFFCODE", "CREATESTAFFCODE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATESTAFFNAME", "CREATESTAFFNAME", DataRowVersion.Current, OracleType.NVarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDNSECID", "NSECID", DataRowVersion.Original, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.String CREATEDEPARTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["CREATEDEPARTID"].Value, "System.String");
			}
			set
			{
				m_Params["CREATEDEPARTID"].Value = value;
			}
		}
				
		public System.String CREATEDEPARTNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["CREATEDEPARTNAME"].Value, "System.String");
			}
			set
			{
				m_Params["CREATEDEPARTNAME"].Value = value;
			}
		}
				
		public System.String NSECID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NSECID"].Value, "System.String");
			}
			set
			{
				m_Params["NSECID"].Value = value;
			}
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
				
		public System.String NITEMID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NITEMID"].Value, "System.String");
			}
			set
			{
				m_Params["NITEMID"].Value = value;
			}
		}
				
		public System.String VITEMNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEMNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VITEMNAME"].Value = value;
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
				
		public System.DateTime CREATEDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["CREATEDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["CREATEDATE"].Value = value;
			}
		}
				
		public System.String CREATESTAFFCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["CREATESTAFFCODE"].Value, "System.String");
			}
			set
			{
				m_Params["CREATESTAFFCODE"].Value = value;
			}
		}
				
		public System.String CREATESTAFFNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["CREATESTAFFNAME"].Value, "System.String");
			}
			set
			{
				m_Params["CREATESTAFFNAME"].Value = value;
			}
		}
				
		public System.String OLDNSECID
		{
			get
			{
				return (System.String)ConverValue(m_Params["OLDNSECID"].Value, "System.String");
			}
			set
			{
				m_Params["OLDNSECID"].Value = value;
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
	} // SS_UpdateTJ_TJ_PACKAGESECON
	#endregion
	
	#region SS_TJ_PACKAGESECON_SelectByIDTJ_TJ_PACKAGESECON
	/// 
	/// 对于SelectByIDTJ_TJ_PACKAGESECON的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TJ_PACKAGESECON_SelectByIDTJ_TJ_PACKAGESECON : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TJ_PACKAGESECON_SelectByIDTJ_TJ_PACKAGESECON() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT CREATEDEPARTID, CREATEDEPARTNAME, NSECID, NPACKAGEID, NITEMID, VITEMNAME, NVPRICE, NISDISCOUNTS, NDISCOUNTS, NMONEY, CREATEDATE, CREATESTAFFCODE, CREATESTAFFNAME  FROM TJ.TJ_PACKAGESECON  WHERE  NSECID = :NSECID";
					
			m_Params.AddParam("NSECID", "NSECID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.String NSECID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NSECID"].Value, "System.String");
			}
			set
			{
				m_Params["NSECID"].Value = value;
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
	} // SS_SelectByIDTJ_TJ_PACKAGESECON
	#endregion
	
	#region SS_TJ_PACKAGESECON_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TJ_PACKAGESECON_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TJ_PACKAGESECON_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "select * from tj.TJ_PACKAGESECON where 1=1";
			
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
	