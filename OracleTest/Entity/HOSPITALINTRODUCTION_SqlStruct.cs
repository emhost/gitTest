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
	
	#region SS_HOSPITALINTRODUCTION_InsertYWAPP_HOSPITAL_INTRODUCTION
	/// 
	/// 对于InsertYWAPP_HOSPITAL_INTRODUCTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_HOSPITALINTRODUCTION_InsertYWAPP_HOSPITAL_INTRODUCTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_HOSPITALINTRODUCTION_InsertYWAPP_HOSPITAL_INTRODUCTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO YWAPP.HOSPITAL_INTRODUCTION  (ID, HOSPITALNAME, HOSPITALADDRESS, HOSPITALTEL, HOSPITALINTRODUCTION, REMARKS, ISENABLE, PHOTO, PHOTO1, PHOTO2, HOSPITALID)  VALUES (:ID, :HOSPITALNAME, :HOSPITALADDRESS, :HOSPITALTEL, :HOSPITALINTRODUCTION, :REMARKS, :ISENABLE, :PHOTO, :PHOTO1, :PHOTO2, :HOSPITALID)";
					
			m_Params.AddParam("ID", "ID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("HOSPITALNAME", "HOSPITALNAME", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("HOSPITALADDRESS", "HOSPITALADDRESS", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("HOSPITALTEL", "HOSPITALTEL", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("HOSPITALINTRODUCTION", "HOSPITALINTRODUCTION", DataRowVersion.Current, OracleType.NVarChar, 1500, ParameterDirection.Input, null);		
			m_Params.AddParam("REMARKS", "REMARKS", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("ISENABLE", "ISENABLE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("PHOTO", "PHOTO", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("PHOTO1", "PHOTO1", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("PHOTO2", "PHOTO2", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("HOSPITALID", "HOSPITALID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);
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
				
		public System.String HOSPITALNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["HOSPITALNAME"].Value, "System.String");
			}
			set
			{
				m_Params["HOSPITALNAME"].Value = value;
			}
		}
				
		public System.String HOSPITALADDRESS
		{
			get
			{
				return (System.String)ConverValue(m_Params["HOSPITALADDRESS"].Value, "System.String");
			}
			set
			{
				m_Params["HOSPITALADDRESS"].Value = value;
			}
		}
				
		public System.String HOSPITALTEL
		{
			get
			{
				return (System.String)ConverValue(m_Params["HOSPITALTEL"].Value, "System.String");
			}
			set
			{
				m_Params["HOSPITALTEL"].Value = value;
			}
		}
				
		public System.String HOSPITALINTRODUCTION
		{
			get
			{
				return (System.String)ConverValue(m_Params["HOSPITALINTRODUCTION"].Value, "System.String");
			}
			set
			{
				m_Params["HOSPITALINTRODUCTION"].Value = value;
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
				
		public System.Byte[] PHOTO1
		{
			get
			{
				return (System.Byte[])ConverValue(m_Params["PHOTO1"].Value, "System.Byte[]");
			}
			set
			{
				m_Params["PHOTO1"].Value = value;
			}
		}
				
		public System.Byte[] PHOTO2
		{
			get
			{
				return (System.Byte[])ConverValue(m_Params["PHOTO2"].Value, "System.Byte[]");
			}
			set
			{
				m_Params["PHOTO2"].Value = value;
			}
		}
				
		public System.String HOSPITALID
		{
			get
			{
				return (System.String)ConverValue(m_Params["HOSPITALID"].Value, "System.String");
			}
			set
			{
				m_Params["HOSPITALID"].Value = value;
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
	} // SS_InsertYWAPP_HOSPITAL_INTRODUCTION
	#endregion
	
	#region SS_HOSPITALINTRODUCTION_DeleteYWAPP_HOSPITAL_INTRODUCTION
	/// 
	/// 对于DeleteYWAPP_HOSPITAL_INTRODUCTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_HOSPITALINTRODUCTION_DeleteYWAPP_HOSPITAL_INTRODUCTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_HOSPITALINTRODUCTION_DeleteYWAPP_HOSPITAL_INTRODUCTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM YWAPP.HOSPITAL_INTRODUCTION  WHERE  ID = :ID";
					
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
	} // SS_DeleteYWAPP_HOSPITAL_INTRODUCTION
	#endregion
	
	#region SS_HOSPITALINTRODUCTION_UpdateYWAPP_HOSPITAL_INTRODUCTION
	/// 
	/// 对于UpdateYWAPP_HOSPITAL_INTRODUCTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_HOSPITALINTRODUCTION_UpdateYWAPP_HOSPITAL_INTRODUCTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_HOSPITALINTRODUCTION_UpdateYWAPP_HOSPITAL_INTRODUCTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE YWAPP.HOSPITAL_INTRODUCTION  SET  ID = :ID, HOSPITALNAME = :HOSPITALNAME, HOSPITALADDRESS = :HOSPITALADDRESS, HOSPITALTEL = :HOSPITALTEL, HOSPITALINTRODUCTION = :HOSPITALINTRODUCTION, REMARKS = :REMARKS, ISENABLE = :ISENABLE, PHOTO = :PHOTO, PHOTO1 = :PHOTO1, PHOTO2 = :PHOTO2, HOSPITALID = :HOSPITALID   WHERE  ID = :OLDID";
					
			m_Params.AddParam("ID", "ID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("HOSPITALNAME", "HOSPITALNAME", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("HOSPITALADDRESS", "HOSPITALADDRESS", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("HOSPITALTEL", "HOSPITALTEL", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("HOSPITALINTRODUCTION", "HOSPITALINTRODUCTION", DataRowVersion.Current, OracleType.NVarChar, 1500, ParameterDirection.Input, null);		
			m_Params.AddParam("REMARKS", "REMARKS", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("ISENABLE", "ISENABLE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("PHOTO", "PHOTO", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("PHOTO1", "PHOTO1", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("PHOTO2", "PHOTO2", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("HOSPITALID", "HOSPITALID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
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
				
		public System.String HOSPITALNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["HOSPITALNAME"].Value, "System.String");
			}
			set
			{
				m_Params["HOSPITALNAME"].Value = value;
			}
		}
				
		public System.String HOSPITALADDRESS
		{
			get
			{
				return (System.String)ConverValue(m_Params["HOSPITALADDRESS"].Value, "System.String");
			}
			set
			{
				m_Params["HOSPITALADDRESS"].Value = value;
			}
		}
				
		public System.String HOSPITALTEL
		{
			get
			{
				return (System.String)ConverValue(m_Params["HOSPITALTEL"].Value, "System.String");
			}
			set
			{
				m_Params["HOSPITALTEL"].Value = value;
			}
		}
				
		public System.String HOSPITALINTRODUCTION
		{
			get
			{
				return (System.String)ConverValue(m_Params["HOSPITALINTRODUCTION"].Value, "System.String");
			}
			set
			{
				m_Params["HOSPITALINTRODUCTION"].Value = value;
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
				
		public System.Byte[] PHOTO1
		{
			get
			{
				return (System.Byte[])ConverValue(m_Params["PHOTO1"].Value, "System.Byte[]");
			}
			set
			{
				m_Params["PHOTO1"].Value = value;
			}
		}
				
		public System.Byte[] PHOTO2
		{
			get
			{
				return (System.Byte[])ConverValue(m_Params["PHOTO2"].Value, "System.Byte[]");
			}
			set
			{
				m_Params["PHOTO2"].Value = value;
			}
		}
				
		public System.String HOSPITALID
		{
			get
			{
				return (System.String)ConverValue(m_Params["HOSPITALID"].Value, "System.String");
			}
			set
			{
				m_Params["HOSPITALID"].Value = value;
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
	} // SS_UpdateYWAPP_HOSPITAL_INTRODUCTION
	#endregion
	
	#region SS_HOSPITALINTRODUCTION_SelectByIDYWAPP_HOSPITAL_INTRODUCTION
	/// 
	/// 对于SelectByIDYWAPP_HOSPITAL_INTRODUCTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_HOSPITALINTRODUCTION_SelectByIDYWAPP_HOSPITAL_INTRODUCTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_HOSPITALINTRODUCTION_SelectByIDYWAPP_HOSPITAL_INTRODUCTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT ID, HOSPITALNAME, HOSPITALADDRESS, HOSPITALTEL, HOSPITALINTRODUCTION, REMARKS, ISENABLE, PHOTO, PHOTO1, PHOTO2, HOSPITALID  FROM YWAPP.HOSPITAL_INTRODUCTION  WHERE  ID = :ID";
					
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
	} // SS_SelectByIDYWAPP_HOSPITAL_INTRODUCTION
	#endregion
	
	#region SS_HOSPITALINTRODUCTION_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_HOSPITALINTRODUCTION_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_HOSPITALINTRODUCTION_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT ID, HOSPITALNAME, HOSPITALADDRESS, HOSPITALTEL, HOSPITALINTRODUCTION, REMARKS, ISENABLE, PHOTO, PHOTO1, PHOTO2, HOSPITALID  FROM YWAPP.HOSPITAL_INTRODUCTION  WHERE 1=1 ";
			
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
	