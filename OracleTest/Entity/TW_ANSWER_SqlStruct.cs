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
	
	#region SS_TW_ANSWER_InsertTW_ANSWER
	/// 
	/// 对于InsertTW_ANSWER的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TW_ANSWER_InsertTW_ANSWER : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TW_ANSWER_InsertTW_ANSWER() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO TW_ANSWER  (IMG, NDEL, DMODIFY, VHUIFUID, VID, VQUESID, VCONTENT, DCREATE, VINPUTID)  VALUES (:IMG, :NDEL, :DMODIFY, :VHUIFUID, :VID, :VQUESID, :VCONTENT, :DCREATE, :VINPUTID)";
					
			m_Params.AddParam("IMG", "IMG", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NDEL", "NDEL", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DMODIFY", "DMODIFY", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VHUIFUID", "VHUIFUID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VID", "VID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VQUESID", "VQUESID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VCONTENT", "VCONTENT", DataRowVersion.Current, OracleType.NVarChar, 255, ParameterDirection.Input, null);		
			m_Params.AddParam("DCREATE", "DCREATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VINPUTID", "VINPUTID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.Byte[] IMG
		{
			get
			{
				return (System.Byte[])ConverValue(m_Params["IMG"].Value, "System.Byte[]");
			}
			set
			{
				m_Params["IMG"].Value = value;
			}
		}
				
		public System.Decimal NDEL
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDEL"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDEL"].Value = value;
			}
		}
				
		public System.DateTime DMODIFY
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DMODIFY"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DMODIFY"].Value = value;
			}
		}
				
		public System.String VHUIFUID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VHUIFUID"].Value, "System.String");
			}
			set
			{
				m_Params["VHUIFUID"].Value = value;
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
				
		public System.String VCONTENT
		{
			get
			{
				return (System.String)ConverValue(m_Params["VCONTENT"].Value, "System.String");
			}
			set
			{
				m_Params["VCONTENT"].Value = value;
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
	} // SS_InsertTW_ANSWER
	#endregion
	
	#region SS_TW_ANSWER_DeleteTW_ANSWER
	/// 
	/// 对于DeleteTW_ANSWER的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TW_ANSWER_DeleteTW_ANSWER : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TW_ANSWER_DeleteTW_ANSWER() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM TW_ANSWER  WHERE  VID = :VID";
					
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
	} // SS_DeleteTW_ANSWER
	#endregion
	
	#region SS_TW_ANSWER_UpdateTW_ANSWER
	/// 
	/// 对于UpdateTW_ANSWER的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TW_ANSWER_UpdateTW_ANSWER : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TW_ANSWER_UpdateTW_ANSWER() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE TW_ANSWER  SET  IMG = :IMG, NDEL = :NDEL, DMODIFY = :DMODIFY, VHUIFUID = :VHUIFUID, VID = :VID, VQUESID = :VQUESID, VCONTENT = :VCONTENT, DCREATE = :DCREATE, VINPUTID = :VINPUTID   WHERE  VID = :OLDVID";
					
			m_Params.AddParam("IMG", "IMG", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NDEL", "NDEL", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DMODIFY", "DMODIFY", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VHUIFUID", "VHUIFUID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VID", "VID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VQUESID", "VQUESID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VCONTENT", "VCONTENT", DataRowVersion.Current, OracleType.NVarChar, 255, ParameterDirection.Input, null);		
			m_Params.AddParam("DCREATE", "DCREATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VINPUTID", "VINPUTID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDVID", "VID", DataRowVersion.Original, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.Byte[] IMG
		{
			get
			{
				return (System.Byte[])ConverValue(m_Params["IMG"].Value, "System.Byte[]");
			}
			set
			{
				m_Params["IMG"].Value = value;
			}
		}
				
		public System.Decimal NDEL
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDEL"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDEL"].Value = value;
			}
		}
				
		public System.DateTime DMODIFY
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DMODIFY"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DMODIFY"].Value = value;
			}
		}
				
		public System.String VHUIFUID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VHUIFUID"].Value, "System.String");
			}
			set
			{
				m_Params["VHUIFUID"].Value = value;
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
				
		public System.String VCONTENT
		{
			get
			{
				return (System.String)ConverValue(m_Params["VCONTENT"].Value, "System.String");
			}
			set
			{
				m_Params["VCONTENT"].Value = value;
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
	} // SS_UpdateTW_ANSWER
	#endregion
	
	#region SS_TW_ANSWER_SelectByIDTW_ANSWER
	/// 
	/// 对于SelectByIDTW_ANSWER的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TW_ANSWER_SelectByIDTW_ANSWER : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TW_ANSWER_SelectByIDTW_ANSWER() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT IMG, NDEL, DMODIFY, VHUIFUID, VID, VQUESID, VCONTENT, DCREATE, VINPUTID  FROM TW_ANSWER  WHERE  VID = :VID";
					
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
	} // SS_SelectByIDTW_ANSWER
	#endregion
	
	#region SS_TW_ANSWER_selectAll
	/// 
	/// 对于selectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TW_ANSWER_selectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TW_ANSWER_selectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "select * from TW_ANSWER where 1=1";
			
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
	} // SS_selectAll
	#endregion
	
	
}
	