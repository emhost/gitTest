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
	
	#region SS_IN_NAVIGATION_DETAILS_InsertYWAPP_INHOSPITAL_NAVIGATION_DETAIL
	/// 
	/// 对于InsertYWAPP_INHOSPITAL_NAVIGATION_DETAIL的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_IN_NAVIGATION_DETAILS_InsertYWAPP_INHOSPITAL_NAVIGATION_DETAIL : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_IN_NAVIGATION_DETAILS_InsertYWAPP_INHOSPITAL_NAVIGATION_DETAIL() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO YWAPP.INHOSPITAL_NAVIGATION_DETAIL  (INID, ID, FLOORNUM, DEPARTCODE, DEPARTNAME, FLOORNUMMAP)  VALUES (:INID, :ID, :FLOORNUM, :DEPARTCODE, :DEPARTNAME, :FLOORNUMMAP)";
					
			m_Params.AddParam("INID", "INID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("ID", "ID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("FLOORNUM", "FLOORNUM", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("DEPARTCODE", "DEPARTCODE", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("DEPARTNAME", "DEPARTNAME", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("FLOORNUMMAP", "FLOORNUMMAP", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);
		}
				
		public System.String INID
		{
			get
			{
				return (System.String)ConverValue(m_Params["INID"].Value, "System.String");
			}
			set
			{
				m_Params["INID"].Value = value;
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
				
		public System.String FLOORNUM
		{
			get
			{
				return (System.String)ConverValue(m_Params["FLOORNUM"].Value, "System.String");
			}
			set
			{
				m_Params["FLOORNUM"].Value = value;
			}
		}
				
		public System.String DEPARTCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["DEPARTCODE"].Value, "System.String");
			}
			set
			{
				m_Params["DEPARTCODE"].Value = value;
			}
		}
				
		public System.String DEPARTNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["DEPARTNAME"].Value, "System.String");
			}
			set
			{
				m_Params["DEPARTNAME"].Value = value;
			}
		}
				
		public System.Byte[] FLOORNUMMAP
		{
			get
			{
				return (System.Byte[])ConverValue(m_Params["FLOORNUMMAP"].Value, "System.Byte[]");
			}
			set
			{
				m_Params["FLOORNUMMAP"].Value = value;
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
	} // SS_InsertYWAPP_INHOSPITAL_NAVIGATION_DETAIL
	#endregion
	
	#region SS_IN_NAVIGATION_DETAILS_DeleteYWAPP_INHOSPITAL_NAVIGATION_DETAIL
	/// 
	/// 对于DeleteYWAPP_INHOSPITAL_NAVIGATION_DETAIL的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_IN_NAVIGATION_DETAILS_DeleteYWAPP_INHOSPITAL_NAVIGATION_DETAIL : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_IN_NAVIGATION_DETAILS_DeleteYWAPP_INHOSPITAL_NAVIGATION_DETAIL() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM YWAPP.INHOSPITAL_NAVIGATION_DETAIL  WHERE  ID = :ID";
					
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
	} // SS_DeleteYWAPP_INHOSPITAL_NAVIGATION_DETAIL
	#endregion
	
	#region SS_IN_NAVIGATION_DETAILS_UpdateYWAPP_INHOSPITAL_NAVIGATION_DETAIL
	/// 
	/// 对于UpdateYWAPP_INHOSPITAL_NAVIGATION_DETAIL的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_IN_NAVIGATION_DETAILS_UpdateYWAPP_INHOSPITAL_NAVIGATION_DETAIL : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_IN_NAVIGATION_DETAILS_UpdateYWAPP_INHOSPITAL_NAVIGATION_DETAIL() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE YWAPP.INHOSPITAL_NAVIGATION_DETAIL  SET  INID = :INID, ID = :ID, FLOORNUM = :FLOORNUM, DEPARTCODE = :DEPARTCODE, DEPARTNAME = :DEPARTNAME, FLOORNUMMAP = :FLOORNUMMAP   WHERE  ID = :OLDID";
					
			m_Params.AddParam("INID", "INID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("ID", "ID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("FLOORNUM", "FLOORNUM", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("DEPARTCODE", "DEPARTCODE", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("DEPARTNAME", "DEPARTNAME", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("FLOORNUMMAP", "FLOORNUMMAP", DataRowVersion.Current, OracleType.Blob, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDID", "ID", DataRowVersion.Original, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.String INID
		{
			get
			{
				return (System.String)ConverValue(m_Params["INID"].Value, "System.String");
			}
			set
			{
				m_Params["INID"].Value = value;
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
				
		public System.String FLOORNUM
		{
			get
			{
				return (System.String)ConverValue(m_Params["FLOORNUM"].Value, "System.String");
			}
			set
			{
				m_Params["FLOORNUM"].Value = value;
			}
		}
				
		public System.String DEPARTCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["DEPARTCODE"].Value, "System.String");
			}
			set
			{
				m_Params["DEPARTCODE"].Value = value;
			}
		}
				
		public System.String DEPARTNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["DEPARTNAME"].Value, "System.String");
			}
			set
			{
				m_Params["DEPARTNAME"].Value = value;
			}
		}
				
		public System.Byte[] FLOORNUMMAP
		{
			get
			{
				return (System.Byte[])ConverValue(m_Params["FLOORNUMMAP"].Value, "System.Byte[]");
			}
			set
			{
				m_Params["FLOORNUMMAP"].Value = value;
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
	} // SS_UpdateYWAPP_INHOSPITAL_NAVIGATION_DETAIL
	#endregion
	
	#region SS_IN_NAVIGATION_DETAILS_SelectByIDYWAPP_INHOSPITAL_NAVIGATION_DETAIL
	/// 
	/// 对于SelectByIDYWAPP_INHOSPITAL_NAVIGATION_DETAIL的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_IN_NAVIGATION_DETAILS_SelectByIDYWAPP_INHOSPITAL_NAVIGATION_DETAIL : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_IN_NAVIGATION_DETAILS_SelectByIDYWAPP_INHOSPITAL_NAVIGATION_DETAIL() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT INID, ID, FLOORNUM, DEPARTCODE, DEPARTNAME, FLOORNUMMAP  FROM YWAPP.INHOSPITAL_NAVIGATION_DETAIL  WHERE  ID = :ID";
					
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
	} // SS_SelectByIDYWAPP_INHOSPITAL_NAVIGATION_DETAIL
	#endregion
	
	#region SS_IN_NAVIGATION_DETAILS_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_IN_NAVIGATION_DETAILS_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_IN_NAVIGATION_DETAILS_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT INID, ID, FLOORNUM, DEPARTCODE, DEPARTNAME, FLOORNUMMAP  FROM YWAPP.INHOSPITAL_NAVIGATION_DETAIL  WHERE 1=1 ";
			
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
	