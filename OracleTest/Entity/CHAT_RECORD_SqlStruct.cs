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
	
	#region SS_CHAT_RECORD_InsertCHAT_RECORD
	/// 
	/// 对于InsertCHAT_RECORD的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_CHAT_RECORD_InsertCHAT_RECORD : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_CHAT_RECORD_InsertCHAT_RECORD() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO CHAT_RECORD  (DREAD, VID, VSID, VRID, VSNAME, VRNAME, DCREATE, CONTENT, TYPE, NREAD)  VALUES (:DREAD, :VID, :VSID, :VRID, :VSNAME, :VRNAME, :DCREATE, :CONTENT, :TYPE, :NREAD)";
					
			m_Params.AddParam("DREAD", "DREAD", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VID", "VID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VSID", "VSID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VRID", "VRID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VSNAME", "VSNAME", DataRowVersion.Current, OracleType.NVarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VRNAME", "VRNAME", DataRowVersion.Current, OracleType.NVarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("DCREATE", "DCREATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("CONTENT", "CONTENT", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("TYPE", "TYPE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NREAD", "NREAD", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);
		}
				
		public System.DateTime DREAD
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DREAD"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DREAD"].Value = value;
			}
		}
				
		public System.String VID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VID"].Value, "System.String");
			}
			set
			{
				m_Params["VID"].Value = value;
			}
		}
				
		public System.String VSID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSID"].Value, "System.String");
			}
			set
			{
				m_Params["VSID"].Value = value;
			}
		}
				
		public System.String VRID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRID"].Value, "System.String");
			}
			set
			{
				m_Params["VRID"].Value = value;
			}
		}
				
		public System.String VSNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VSNAME"].Value = value;
			}
		}
				
		public System.String VRNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VRNAME"].Value = value;
			}
		}
				
		public System.DateTime DCREATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DCREATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DCREATE"].Value = value;
			}
		}
				
		public System.Byte[] CONTENT
		{
			get
			{
				return (System.Byte[])ConverValue(m_Params["CONTENT"].Value, "System.Byte[]");
			}
			set
			{
				m_Params["CONTENT"].Value = value;
			}
		}
				
		public System.String TYPE
		{
			get
			{
				return (System.String)ConverValue(m_Params["TYPE"].Value, "System.String");
			}
			set
			{
				m_Params["TYPE"].Value = value;
			}
		}
				
		public System.Decimal NREAD
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NREAD"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NREAD"].Value = value;
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
	} // SS_InsertCHAT_RECORD
	#endregion
	
	#region SS_CHAT_RECORD_DeleteCHAT_RECORD
	/// 
	/// 对于DeleteCHAT_RECORD的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_CHAT_RECORD_DeleteCHAT_RECORD : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_CHAT_RECORD_DeleteCHAT_RECORD() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM CHAT_RECORD  WHERE  VID = :VID";
					
			m_Params.AddParam("VID", "VID", DataRowVersion.Original, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.String VID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VID"].Value, "System.String");
			}
			set
			{
				m_Params["VID"].Value = value;
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
	} // SS_DeleteCHAT_RECORD
	#endregion
	
	#region SS_CHAT_RECORD_UpdateCHAT_RECORD
	/// 
	/// 对于UpdateCHAT_RECORD的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_CHAT_RECORD_UpdateCHAT_RECORD : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_CHAT_RECORD_UpdateCHAT_RECORD() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE CHAT_RECORD  SET  DREAD = :DREAD, VID = :VID, VSID = :VSID, VRID = :VRID, VSNAME = :VSNAME, VRNAME = :VRNAME, DCREATE = :DCREATE, CONTENT = :CONTENT, TYPE = :TYPE, NREAD = :NREAD   WHERE  VID = :OLDVID";
					
			m_Params.AddParam("DREAD", "DREAD", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VID", "VID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VSID", "VSID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VRID", "VRID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VSNAME", "VSNAME", DataRowVersion.Current, OracleType.NVarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VRNAME", "VRNAME", DataRowVersion.Current, OracleType.NVarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("DCREATE", "DCREATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("CONTENT", "CONTENT", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("TYPE", "TYPE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NREAD", "NREAD", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDVID", "VID", DataRowVersion.Original, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.DateTime DREAD
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DREAD"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DREAD"].Value = value;
			}
		}
				
		public System.String VID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VID"].Value, "System.String");
			}
			set
			{
				m_Params["VID"].Value = value;
			}
		}
				
		public System.String VSID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSID"].Value, "System.String");
			}
			set
			{
				m_Params["VSID"].Value = value;
			}
		}
				
		public System.String VRID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRID"].Value, "System.String");
			}
			set
			{
				m_Params["VRID"].Value = value;
			}
		}
				
		public System.String VSNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VSNAME"].Value = value;
			}
		}
				
		public System.String VRNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VRNAME"].Value = value;
			}
		}
				
		public System.DateTime DCREATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DCREATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DCREATE"].Value = value;
			}
		}
				
		public System.Byte[] CONTENT
		{
			get
			{
				return (System.Byte[])ConverValue(m_Params["CONTENT"].Value, "System.Byte[]");
			}
			set
			{
				m_Params["CONTENT"].Value = value;
			}
		}
				
		public System.String TYPE
		{
			get
			{
				return (System.String)ConverValue(m_Params["TYPE"].Value, "System.String");
			}
			set
			{
				m_Params["TYPE"].Value = value;
			}
		}
				
		public System.Decimal NREAD
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NREAD"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NREAD"].Value = value;
			}
		}
				
		public System.String OLDVID
		{
			get
			{
				return (System.String)ConverValue(m_Params["OLDVID"].Value, "System.String");
			}
			set
			{
				m_Params["OLDVID"].Value = value;
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
	} // SS_UpdateCHAT_RECORD
	#endregion
	
	#region SS_CHAT_RECORD_SelectByIDCHAT_RECORD
	/// 
	/// 对于SelectByIDCHAT_RECORD的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_CHAT_RECORD_SelectByIDCHAT_RECORD : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_CHAT_RECORD_SelectByIDCHAT_RECORD() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT DREAD, VID, VSID, VRID, VSNAME, VRNAME, DCREATE, CONTENT, TYPE, NREAD  FROM CHAT_RECORD  WHERE  VID = :VID";
					
			m_Params.AddParam("VID", "VID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.String VID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VID"].Value, "System.String");
			}
			set
			{
				m_Params["VID"].Value = value;
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
	} // SS_SelectByIDCHAT_RECORD
	#endregion
	
	#region SS_CHAT_RECORD_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_CHAT_RECORD_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_CHAT_RECORD_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "select * from CHAT_RECORD where 1=1";
			
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
	