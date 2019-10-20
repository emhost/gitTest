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
	
	#region SS_TW_QUESTION_InsertTW_QUESTION
	/// 
	/// 对于InsertTW_QUESTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TW_QUESTION_InsertTW_QUESTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TW_QUESTION_InsertTW_QUESTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO TW_QUESTION  (VID, VTITLE, VDETAIL, DCREATE, VINPUTID, IMG, NSTATUS, NDEL)  VALUES (:VID, :VTITLE, :VDETAIL, :DCREATE, :VINPUTID, :IMG, :NSTATUS, :NDEL)";
					
			m_Params.AddParam("VID", "VID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VTITLE", "VTITLE", DataRowVersion.Current, OracleType.NVarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VDETAIL", "VDETAIL", DataRowVersion.Current, OracleType.NVarChar, 255, ParameterDirection.Input, null);		
			m_Params.AddParam("DCREATE", "DCREATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VINPUTID", "VINPUTID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("IMG", "IMG", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NSTATUS", "NSTATUS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NDEL", "NDEL", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);
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
				
		public System.String VTITLE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VTITLE"].Value, "System.String");
			}
			set
			{
				m_Params["VTITLE"].Value = value;
			}
		}
				
		public System.String VDETAIL
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDETAIL"].Value, "System.String");
			}
			set
			{
				m_Params["VDETAIL"].Value = value;
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
				
		public System.Decimal NSTATUS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSTATUS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSTATUS"].Value = value;
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
	} // SS_InsertTW_QUESTION
	#endregion
	
	#region SS_TW_QUESTION_DeleteTW_QUESTION
	/// 
	/// 对于DeleteTW_QUESTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TW_QUESTION_DeleteTW_QUESTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TW_QUESTION_DeleteTW_QUESTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM TW_QUESTION  WHERE  VID = :VID";
					
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
	} // SS_DeleteTW_QUESTION
	#endregion
	
	#region SS_TW_QUESTION_UpdateTW_QUESTION
	/// 
	/// 对于UpdateTW_QUESTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TW_QUESTION_UpdateTW_QUESTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TW_QUESTION_UpdateTW_QUESTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE TW_QUESTION  SET  VID = :VID, VTITLE = :VTITLE, VDETAIL = :VDETAIL, DCREATE = :DCREATE, VINPUTID = :VINPUTID, IMG = :IMG, NSTATUS = :NSTATUS, NDEL = :NDEL   WHERE  VID = :OLDVID";
					
			m_Params.AddParam("VID", "VID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VTITLE", "VTITLE", DataRowVersion.Current, OracleType.NVarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VDETAIL", "VDETAIL", DataRowVersion.Current, OracleType.NVarChar, 255, ParameterDirection.Input, null);		
			m_Params.AddParam("DCREATE", "DCREATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VINPUTID", "VINPUTID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("IMG", "IMG", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NSTATUS", "NSTATUS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NDEL", "NDEL", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
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
				
		public System.String VTITLE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VTITLE"].Value, "System.String");
			}
			set
			{
				m_Params["VTITLE"].Value = value;
			}
		}
				
		public System.String VDETAIL
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDETAIL"].Value, "System.String");
			}
			set
			{
				m_Params["VDETAIL"].Value = value;
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
				
		public System.Decimal NSTATUS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSTATUS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSTATUS"].Value = value;
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
	} // SS_UpdateTW_QUESTION
	#endregion
	
	#region SS_TW_QUESTION_SelectByIDTW_QUESTION
	/// 
	/// 对于SelectByIDTW_QUESTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TW_QUESTION_SelectByIDTW_QUESTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TW_QUESTION_SelectByIDTW_QUESTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT VID, VTITLE, VDETAIL, DCREATE, VINPUTID, IMG, NSTATUS, NDEL  FROM TW_QUESTION  WHERE  VID = :VID";
					
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
	} // SS_SelectByIDTW_QUESTION
	#endregion
	
	#region SS_TW_QUESTION_selectAll
	/// 
	/// 对于selectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TW_QUESTION_selectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TW_QUESTION_selectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "select * from TW_QUESTION where 1=1";
			
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
	