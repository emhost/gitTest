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

namespace hyApp.Entity
{
	
	#region SS_DOCTORINTRODUCTION_InsertYWAPP_DOCTOR_INTRODUCTION
	/// 
	/// 对于InsertYWAPP_DOCTOR_INTRODUCTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_DOCTORINTRODUCTION_InsertYWAPP_DOCTOR_INTRODUCTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_DOCTORINTRODUCTION_InsertYWAPP_DOCTOR_INTRODUCTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO YWAPP.DOCTOR_INTRODUCTION  (VGOODAT, ID, VSTAFFCODE, DOCTORINTRODUCTION, REMARKS, ISENABLE, SPECIALTY, POSITION, PHOTO, VDEPARTCODE)  VALUES (:VGOODAT, :ID, :VSTAFFCODE, :DOCTORINTRODUCTION, :REMARKS, :ISENABLE, :SPECIALTY, :POSITION, :PHOTO, :VDEPARTCODE)";
					
			m_Params.AddParam("VGOODAT", "VGOODAT", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("ID", "ID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VSTAFFCODE", "VSTAFFCODE", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("DOCTORINTRODUCTION", "DOCTORINTRODUCTION", DataRowVersion.Current, OracleType.VarChar, 500, ParameterDirection.Input, null);		
			m_Params.AddParam("REMARKS", "REMARKS", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("ISENABLE", "ISENABLE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("SPECIALTY", "SPECIALTY", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("POSITION", "POSITION", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("PHOTO", "PHOTO", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPARTCODE", "VDEPARTCODE", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.String VGOODAT
		{
			get
			{
				return (System.String)ConverValue(m_Params["VGOODAT"].Value, "System.String");
			}
			set
			{
				m_Params["VGOODAT"].Value = value;
			}
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
				
		public System.String DOCTORINTRODUCTION
		{
			get
			{
				return (System.String)ConverValue(m_Params["DOCTORINTRODUCTION"].Value, "System.String");
			}
			set
			{
				m_Params["DOCTORINTRODUCTION"].Value = value;
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
				
		public System.String SPECIALTY
		{
			get
			{
				return (System.String)ConverValue(m_Params["SPECIALTY"].Value, "System.String");
			}
			set
			{
				m_Params["SPECIALTY"].Value = value;
			}
		}
				
		public System.String POSITION
		{
			get
			{
				return (System.String)ConverValue(m_Params["POSITION"].Value, "System.String");
			}
			set
			{
				m_Params["POSITION"].Value = value;
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
	} // SS_InsertYWAPP_DOCTOR_INTRODUCTION
	#endregion
	
	#region SS_DOCTORINTRODUCTION_DeleteYWAPP_DOCTOR_INTRODUCTION
	/// 
	/// 对于DeleteYWAPP_DOCTOR_INTRODUCTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_DOCTORINTRODUCTION_DeleteYWAPP_DOCTOR_INTRODUCTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_DOCTORINTRODUCTION_DeleteYWAPP_DOCTOR_INTRODUCTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM YWAPP.DOCTOR_INTRODUCTION  WHERE  ID = :ID";
					
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
	} // SS_DeleteYWAPP_DOCTOR_INTRODUCTION
	#endregion
	
	#region SS_DOCTORINTRODUCTION_UpdateYWAPP_DOCTOR_INTRODUCTION
	/// 
	/// 对于UpdateYWAPP_DOCTOR_INTRODUCTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_DOCTORINTRODUCTION_UpdateYWAPP_DOCTOR_INTRODUCTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_DOCTORINTRODUCTION_UpdateYWAPP_DOCTOR_INTRODUCTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE YWAPP.DOCTOR_INTRODUCTION  SET  VGOODAT = :VGOODAT, ID = :ID, VSTAFFCODE = :VSTAFFCODE, DOCTORINTRODUCTION = :DOCTORINTRODUCTION, REMARKS = :REMARKS, ISENABLE = :ISENABLE, SPECIALTY = :SPECIALTY, POSITION = :POSITION, PHOTO = :PHOTO, VDEPARTCODE = :VDEPARTCODE   WHERE  ID = :OLDID";
					
			m_Params.AddParam("VGOODAT", "VGOODAT", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("ID", "ID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VSTAFFCODE", "VSTAFFCODE", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("DOCTORINTRODUCTION", "DOCTORINTRODUCTION", DataRowVersion.Current, OracleType.VarChar, 500, ParameterDirection.Input, null);		
			m_Params.AddParam("REMARKS", "REMARKS", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("ISENABLE", "ISENABLE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("SPECIALTY", "SPECIALTY", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("POSITION", "POSITION", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("PHOTO", "PHOTO", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPARTCODE", "VDEPARTCODE", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDID", "ID", DataRowVersion.Original, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.String VGOODAT
		{
			get
			{
				return (System.String)ConverValue(m_Params["VGOODAT"].Value, "System.String");
			}
			set
			{
				m_Params["VGOODAT"].Value = value;
			}
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
				
		public System.String DOCTORINTRODUCTION
		{
			get
			{
				return (System.String)ConverValue(m_Params["DOCTORINTRODUCTION"].Value, "System.String");
			}
			set
			{
				m_Params["DOCTORINTRODUCTION"].Value = value;
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
				
		public System.String SPECIALTY
		{
			get
			{
				return (System.String)ConverValue(m_Params["SPECIALTY"].Value, "System.String");
			}
			set
			{
				m_Params["SPECIALTY"].Value = value;
			}
		}
				
		public System.String POSITION
		{
			get
			{
				return (System.String)ConverValue(m_Params["POSITION"].Value, "System.String");
			}
			set
			{
				m_Params["POSITION"].Value = value;
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
	} // SS_UpdateYWAPP_DOCTOR_INTRODUCTION
	#endregion
	
	#region SS_DOCTORINTRODUCTION_SelectByIDYWAPP_DOCTOR_INTRODUCTION
	/// 
	/// 对于SelectByIDYWAPP_DOCTOR_INTRODUCTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_DOCTORINTRODUCTION_SelectByIDYWAPP_DOCTOR_INTRODUCTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_DOCTORINTRODUCTION_SelectByIDYWAPP_DOCTOR_INTRODUCTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT VGOODAT, ID, VSTAFFCODE, DOCTORINTRODUCTION, REMARKS, ISENABLE, SPECIALTY, POSITION, PHOTO, VDEPARTCODE  FROM YWAPP.DOCTOR_INTRODUCTION  WHERE  ID = :ID";
					
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
	} // SS_SelectByIDYWAPP_DOCTOR_INTRODUCTION
	#endregion
	
	#region SS_DOCTORINTRODUCTION_SelectALl
	/// 
	/// 对于SelectALl的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_DOCTORINTRODUCTION_SelectALl : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_DOCTORINTRODUCTION_SelectALl() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT ID, VSTAFFCODE, DOCTORINTRODUCTION, REMARKS, ISENABLE, SPECIALTY, POSITION, PHOTO, VDEPARTCODE  FROM YWAPP.DOCTOR_INTRODUCTION  WHERE 1=1 ";
			
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
	} // SS_SelectALl
	#endregion
	
	
}
	