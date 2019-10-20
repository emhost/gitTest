//------------------------------------------------------------------------------
//     这部分代码属于实体定义层，是由实体编辑器工具自动产生的。
//     (Runtime Version: 2.2017.9.9)
//     对此代码进行的任何修改会导致其它的行为错误，并且重新生成时所有的修改会丢失。
//------------------------------------------------------------------------------

using System;
using System.Data;

using System.Data.OracleClient;

//using Gyd.TaskInfo;
using PhoenixDataBaseOperate;

namespace hyApp.Entity
{
	
	#region SS_DEPARTINTRODUCTION_InsertYWAPP_DEPART_INTRODUCTION
	/// 
	/// 对于InsertYWAPP_DEPART_INTRODUCTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_DEPARTINTRODUCTION_InsertYWAPP_DEPART_INTRODUCTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_DEPARTINTRODUCTION_InsertYWAPP_DEPART_INTRODUCTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO YWAPP.DEPART_INTRODUCTION  (ID, VDEPARTMENTCODE, INTRODUCTION, REMARKS, ISENABLE, PHOTO)  VALUES (:ID, :VDEPARTMENTCODE, :INTRODUCTION, :REMARKS, :ISENABLE, :PHOTO)";
					
			m_Params.AddParam("ID", "ID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPARTMENTCODE", "VDEPARTMENTCODE", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("INTRODUCTION", "INTRODUCTION", DataRowVersion.Current, OracleType.VarChar, 200, ParameterDirection.Input, null);		
			m_Params.AddParam("REMARKS", "REMARKS", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("ISENABLE", "ISENABLE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("PHOTO", "PHOTO", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);
		}
				
		public System.String ID
		{
			get
			{
				return (System.String)ConverValue(m_Params["ID"].Value, "System.String");
			}
			set
			{
				m_Params["ID"].Value = value;
			}
		}
				
		public System.String VDEPARTMENTCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEPARTMENTCODE"].Value, "System.String");
			}
			set
			{
				m_Params["VDEPARTMENTCODE"].Value = value;
			}
		}
				
		public System.String INTRODUCTION
		{
			get
			{
				return (System.String)ConverValue(m_Params["INTRODUCTION"].Value, "System.String");
			}
			set
			{
				m_Params["INTRODUCTION"].Value = value;
			}
		}
				
		public System.String REMARKS
		{
			get
			{
				return (System.String)ConverValue(m_Params["REMARKS"].Value, "System.String");
			}
			set
			{
				m_Params["REMARKS"].Value = value;
			}
		}
				
		public System.Decimal ISENABLE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["ISENABLE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["ISENABLE"].Value = value;
			}
		}
				
		public System.Byte[] PHOTO
		{
			get
			{
				return (System.Byte[])ConverValue(m_Params["PHOTO"].Value, "System.Byte[]");
			}
			set
			{
				m_Params["PHOTO"].Value = value;
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
	} // SS_InsertYWAPP_DEPART_INTRODUCTION
	#endregion
	
	#region SS_DEPARTINTRODUCTION_DeleteYWAPP_DEPART_INTRODUCTION
	/// 
	/// 对于DeleteYWAPP_DEPART_INTRODUCTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_DEPARTINTRODUCTION_DeleteYWAPP_DEPART_INTRODUCTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_DEPARTINTRODUCTION_DeleteYWAPP_DEPART_INTRODUCTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM YWAPP.DEPART_INTRODUCTION  WHERE  ID = :ID";
					
			m_Params.AddParam("ID", "ID", DataRowVersion.Original, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.String ID
		{
			get
			{
				return (System.String)ConverValue(m_Params["ID"].Value, "System.String");
			}
			set
			{
				m_Params["ID"].Value = value;
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
	} // SS_DeleteYWAPP_DEPART_INTRODUCTION
	#endregion
	
	#region SS_DEPARTINTRODUCTION_UpdateYWAPP_DEPART_INTRODUCTION
	/// 
	/// 对于UpdateYWAPP_DEPART_INTRODUCTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_DEPARTINTRODUCTION_UpdateYWAPP_DEPART_INTRODUCTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_DEPARTINTRODUCTION_UpdateYWAPP_DEPART_INTRODUCTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE YWAPP.DEPART_INTRODUCTION  SET  ID = :ID, VDEPARTMENTCODE = :VDEPARTMENTCODE, INTRODUCTION = :INTRODUCTION, REMARKS = :REMARKS, ISENABLE = :ISENABLE, PHOTO = :PHOTO   WHERE  ID = :OLDID";
					
			m_Params.AddParam("ID", "ID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPARTMENTCODE", "VDEPARTMENTCODE", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("INTRODUCTION", "INTRODUCTION", DataRowVersion.Current, OracleType.VarChar, 200, ParameterDirection.Input, null);		
			m_Params.AddParam("REMARKS", "REMARKS", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("ISENABLE", "ISENABLE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("PHOTO", "PHOTO", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDID", "ID", DataRowVersion.Original, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.String ID
		{
			get
			{
				return (System.String)ConverValue(m_Params["ID"].Value, "System.String");
			}
			set
			{
				m_Params["ID"].Value = value;
			}
		}
				
		public System.String VDEPARTMENTCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEPARTMENTCODE"].Value, "System.String");
			}
			set
			{
				m_Params["VDEPARTMENTCODE"].Value = value;
			}
		}
				
		public System.String INTRODUCTION
		{
			get
			{
				return (System.String)ConverValue(m_Params["INTRODUCTION"].Value, "System.String");
			}
			set
			{
				m_Params["INTRODUCTION"].Value = value;
			}
		}
				
		public System.String REMARKS
		{
			get
			{
				return (System.String)ConverValue(m_Params["REMARKS"].Value, "System.String");
			}
			set
			{
				m_Params["REMARKS"].Value = value;
			}
		}
				
		public System.Decimal ISENABLE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["ISENABLE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["ISENABLE"].Value = value;
			}
		}
				
		public System.Byte[] PHOTO
		{
			get
			{
				return (System.Byte[])ConverValue(m_Params["PHOTO"].Value, "System.Byte[]");
			}
			set
			{
				m_Params["PHOTO"].Value = value;
			}
		}
				
		public System.String OLDID
		{
			get
			{
				return (System.String)ConverValue(m_Params["OLDID"].Value, "System.String");
			}
			set
			{
				m_Params["OLDID"].Value = value;
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
	} // SS_UpdateYWAPP_DEPART_INTRODUCTION
	#endregion
	
	#region SS_DEPARTINTRODUCTION_SelectByIDYWAPP_DEPART_INTRODUCTION
	/// 
	/// 对于SelectByIDYWAPP_DEPART_INTRODUCTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_DEPARTINTRODUCTION_SelectByIDYWAPP_DEPART_INTRODUCTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_DEPARTINTRODUCTION_SelectByIDYWAPP_DEPART_INTRODUCTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT ID, VDEPARTMENTCODE, INTRODUCTION, REMARKS, ISENABLE, PHOTO  FROM YWAPP.DEPART_INTRODUCTION  WHERE  ID = :ID";
					
			m_Params.AddParam("ID", "ID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.String ID
		{
			get
			{
				return (System.String)ConverValue(m_Params["ID"].Value, "System.String");
			}
			set
			{
				m_Params["ID"].Value = value;
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
	} // SS_SelectByIDYWAPP_DEPART_INTRODUCTION
	#endregion
	
	#region SS_DEPARTINTRODUCTION_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_DEPARTINTRODUCTION_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_DEPARTINTRODUCTION_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT ID, VDEPARTMENTCODE, INTRODUCTION, REMARKS, ISENABLE, PHOTO  FROM YWAPP.DEPART_INTRODUCTION  WHERE 1=1 ";
			
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
	