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
	
	#region SS_IN_NAVIGATION_InsertYWAPP_INHOSPITAL_NAVIGATION
	/// 
	/// 对于InsertYWAPP_INHOSPITAL_NAVIGATION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_IN_NAVIGATION_InsertYWAPP_INHOSPITAL_NAVIGATION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_IN_NAVIGATION_InsertYWAPP_INHOSPITAL_NAVIGATION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO YWAPP.INHOSPITAL_NAVIGATION  (HOSPITALID, ID, FLOORNAME, FLOORMAP)  VALUES (:HOSPITALID, :ID, :FLOORNAME, :FLOORMAP)";
					
			m_Params.AddParam("HOSPITALID", "HOSPITALID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("ID", "ID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("FLOORNAME", "FLOORNAME", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("FLOORMAP", "FLOORMAP", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);
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
				
		public System.String FLOORNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["FLOORNAME"].Value, "System.String");
			}
			set
			{
				m_Params["FLOORNAME"].Value = value;
			}
		}
				
		public System.Byte[] FLOORMAP
		{
			get
			{
				return (System.Byte[])ConverValue(m_Params["FLOORMAP"].Value, "System.Byte[]");
			}
			set
			{
				m_Params["FLOORMAP"].Value = value;
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
	} // SS_InsertYWAPP_INHOSPITAL_NAVIGATION
	#endregion
	
	#region SS_IN_NAVIGATION_DeleteYWAPP_INHOSPITAL_NAVIGATION
	/// 
	/// 对于DeleteYWAPP_INHOSPITAL_NAVIGATION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_IN_NAVIGATION_DeleteYWAPP_INHOSPITAL_NAVIGATION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_IN_NAVIGATION_DeleteYWAPP_INHOSPITAL_NAVIGATION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM YWAPP.INHOSPITAL_NAVIGATION  WHERE  ID = :ID";
					
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
	} // SS_DeleteYWAPP_INHOSPITAL_NAVIGATION
	#endregion
	
	#region SS_IN_NAVIGATION_UpdateYWAPP_INHOSPITAL_NAVIGATION
	/// 
	/// 对于UpdateYWAPP_INHOSPITAL_NAVIGATION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_IN_NAVIGATION_UpdateYWAPP_INHOSPITAL_NAVIGATION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_IN_NAVIGATION_UpdateYWAPP_INHOSPITAL_NAVIGATION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE YWAPP.INHOSPITAL_NAVIGATION  SET  HOSPITALID = :HOSPITALID, ID = :ID, FLOORNAME = :FLOORNAME, FLOORMAP = :FLOORMAP   WHERE  ID = :OLDID";
					
			m_Params.AddParam("HOSPITALID", "HOSPITALID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("ID", "ID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("FLOORNAME", "FLOORNAME", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("FLOORMAP", "FLOORMAP", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDID", "ID", DataRowVersion.Original, OracleType.VarChar, 36, ParameterDirection.Input, null);
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
				
		public System.String FLOORNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["FLOORNAME"].Value, "System.String");
			}
			set
			{
				m_Params["FLOORNAME"].Value = value;
			}
		}
				
		public System.Byte[] FLOORMAP
		{
			get
			{
				return (System.Byte[])ConverValue(m_Params["FLOORMAP"].Value, "System.Byte[]");
			}
			set
			{
				m_Params["FLOORMAP"].Value = value;
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
	} // SS_UpdateYWAPP_INHOSPITAL_NAVIGATION
	#endregion
	
	#region SS_IN_NAVIGATION_SelectByIDYWAPP_INHOSPITAL_NAVIGATION
	/// 
	/// 对于SelectByIDYWAPP_INHOSPITAL_NAVIGATION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_IN_NAVIGATION_SelectByIDYWAPP_INHOSPITAL_NAVIGATION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_IN_NAVIGATION_SelectByIDYWAPP_INHOSPITAL_NAVIGATION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT HOSPITALID, ID, FLOORNAME, FLOORMAP  FROM YWAPP.INHOSPITAL_NAVIGATION  WHERE  ID = :ID";
					
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
	} // SS_SelectByIDYWAPP_INHOSPITAL_NAVIGATION
	#endregion
	
	#region SS_IN_NAVIGATION_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_IN_NAVIGATION_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_IN_NAVIGATION_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT HOSPITALID, ID, FLOORNAME, FLOORMAP  FROM YWAPP.INHOSPITAL_NAVIGATION  WHERE 1=1";
			
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
	