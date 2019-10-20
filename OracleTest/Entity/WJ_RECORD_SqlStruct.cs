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
	
	#region SS_WJ_RECORD_InsertWJ_RECORD
	/// 
	/// 对于InsertWJ_RECORD的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_WJ_RECORD_InsertWJ_RECORD : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_WJ_RECORD_InsertWJ_RECORD() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO WJ_RECORD  (VID, VWJID, VWJMC, VQUESID, VINPUTID, DCREATE, VQUESNAME, VANSID, VANSNAME, VDJH)  VALUES (:VID, :VWJID, :VWJMC, :VQUESID, :VINPUTID, :DCREATE, :VQUESNAME, :VANSID, :VANSNAME, :VDJH)";
					
			m_Params.AddParam("VID", "VID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VWJID", "VWJID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VWJMC", "VWJMC", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VQUESID", "VQUESID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VINPUTID", "VINPUTID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("DCREATE", "DCREATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VQUESNAME", "VQUESNAME", DataRowVersion.Current, OracleType.VarChar, 80, ParameterDirection.Input, null);		
			m_Params.AddParam("VANSID", "VANSID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VANSNAME", "VANSNAME", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("VDJH", "VDJH", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);
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
				
		public System.String VWJID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VWJID"].Value, "System.String");
			}
			set
			{
				m_Params["VWJID"].Value = value;
			}
		}
				
		public System.String VWJMC
		{
			get
			{
				return (System.String)ConverValue(m_Params["VWJMC"].Value, "System.String");
			}
			set
			{
				m_Params["VWJMC"].Value = value;
			}
		}
				
		public System.String VQUESID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VQUESID"].Value, "System.String");
			}
			set
			{
				m_Params["VQUESID"].Value = value;
			}
		}
				
		public System.String VINPUTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VINPUTID"].Value, "System.String");
			}
			set
			{
				m_Params["VINPUTID"].Value = value;
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
				
		public System.String VQUESNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VQUESNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VQUESNAME"].Value = value;
			}
		}
				
		public System.String VANSID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VANSID"].Value, "System.String");
			}
			set
			{
				m_Params["VANSID"].Value = value;
			}
		}
				
		public System.String VANSNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VANSNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VANSNAME"].Value = value;
			}
		}
				
		public System.String VDJH
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDJH"].Value, "System.String");
			}
			set
			{
				m_Params["VDJH"].Value = value;
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
	} // SS_InsertWJ_RECORD
	#endregion
	
	#region SS_WJ_RECORD_DeleteWJ_RECORD
	/// 
	/// 对于DeleteWJ_RECORD的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_WJ_RECORD_DeleteWJ_RECORD : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_WJ_RECORD_DeleteWJ_RECORD() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM WJ_RECORD  WHERE  VID = :VID";
					
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
	} // SS_DeleteWJ_RECORD
	#endregion
	
	#region SS_WJ_RECORD_UpdateWJ_RECORD
	/// 
	/// 对于UpdateWJ_RECORD的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_WJ_RECORD_UpdateWJ_RECORD : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_WJ_RECORD_UpdateWJ_RECORD() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE WJ_RECORD  SET  VID = :VID, VWJID = :VWJID, VWJMC = :VWJMC, VQUESID = :VQUESID, VINPUTID = :VINPUTID, DCREATE = :DCREATE, VQUESNAME = :VQUESNAME, VANSID = :VANSID, VANSNAME = :VANSNAME, VDJH = :VDJH   WHERE  VID = :OLDVID";
					
			m_Params.AddParam("VID", "VID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VWJID", "VWJID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VWJMC", "VWJMC", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VQUESID", "VQUESID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VINPUTID", "VINPUTID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("DCREATE", "DCREATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VQUESNAME", "VQUESNAME", DataRowVersion.Current, OracleType.VarChar, 80, ParameterDirection.Input, null);		
			m_Params.AddParam("VANSID", "VANSID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VANSNAME", "VANSNAME", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("VDJH", "VDJH", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDVID", "VID", DataRowVersion.Original, OracleType.VarChar, 36, ParameterDirection.Input, null);
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
				
		public System.String VWJID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VWJID"].Value, "System.String");
			}
			set
			{
				m_Params["VWJID"].Value = value;
			}
		}
				
		public System.String VWJMC
		{
			get
			{
				return (System.String)ConverValue(m_Params["VWJMC"].Value, "System.String");
			}
			set
			{
				m_Params["VWJMC"].Value = value;
			}
		}
				
		public System.String VQUESID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VQUESID"].Value, "System.String");
			}
			set
			{
				m_Params["VQUESID"].Value = value;
			}
		}
				
		public System.String VINPUTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VINPUTID"].Value, "System.String");
			}
			set
			{
				m_Params["VINPUTID"].Value = value;
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
				
		public System.String VQUESNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VQUESNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VQUESNAME"].Value = value;
			}
		}
				
		public System.String VANSID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VANSID"].Value, "System.String");
			}
			set
			{
				m_Params["VANSID"].Value = value;
			}
		}
				
		public System.String VANSNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VANSNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VANSNAME"].Value = value;
			}
		}
				
		public System.String VDJH
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDJH"].Value, "System.String");
			}
			set
			{
				m_Params["VDJH"].Value = value;
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
	} // SS_UpdateWJ_RECORD
	#endregion
	
	#region SS_WJ_RECORD_SelectByIDWJ_RECORD
	/// 
	/// 对于SelectByIDWJ_RECORD的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_WJ_RECORD_SelectByIDWJ_RECORD : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_WJ_RECORD_SelectByIDWJ_RECORD() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT VID, VWJID, VWJMC, VQUESID, VINPUTID, DCREATE, VQUESNAME, VANSID, VANSNAME, VDJH  FROM WJ_RECORD  WHERE  VID = :VID";
					
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
	} // SS_SelectByIDWJ_RECORD
	#endregion
	
	#region SS_WJ_RECORD_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_WJ_RECORD_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_WJ_RECORD_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "select * from WJ_RECORD where 1=1";
			
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
	