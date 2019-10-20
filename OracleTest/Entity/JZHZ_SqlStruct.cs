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
	
	#region SS_JZHZ_InsertJZHZ
	/// 
	/// 对于InsertJZHZ的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_JZHZ_InsertJZHZ : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_JZHZ_InsertJZHZ() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO JZHZ  (ID, NPHONE, VNAME, NSEX, VSFZH, VCARD, VPWD, VPYM, DBIRTHDAY, NSTOP, VPATIENTID, DCREATE)  VALUES (:ID, :NPHONE, :VNAME, :NSEX, :VSFZH, :VCARD, :VPWD, :VPYM, :DBIRTHDAY, :NSTOP, :VPATIENTID, :DCREATE)";
					
			m_Params.AddParam("ID", "ID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("NPHONE", "NPHONE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VNAME", "VNAME", DataRowVersion.Current, OracleType.NVarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NSEX", "NSEX", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VSFZH", "VSFZH", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VCARD", "VCARD", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VPWD", "VPWD", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VPYM", "VPYM", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("DBIRTHDAY", "DBIRTHDAY", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NSTOP", "NSTOP", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VPATIENTID", "VPATIENTID", DataRowVersion.Current, OracleType.VarChar, 30, ParameterDirection.Input, null);		
			m_Params.AddParam("DCREATE", "DCREATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);
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
				
		public System.Decimal NPHONE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPHONE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPHONE"].Value = value;
			}
		}
				
		public System.String VNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VNAME"].Value = value;
			}
		}
				
		public System.String NSEX
		{
			get
			{
				return (System.String)ConverValue(m_Params["NSEX"].Value, "System.String");
			}
			set
			{
				m_Params["NSEX"].Value = value;
			}
		}
				
		public System.String VSFZH
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSFZH"].Value, "System.String");
			}
			set
			{
				m_Params["VSFZH"].Value = value;
			}
		}
				
		public System.String VCARD
		{
			get
			{
				return (System.String)ConverValue(m_Params["VCARD"].Value, "System.String");
			}
			set
			{
				m_Params["VCARD"].Value = value;
			}
		}
				
		public System.String VPWD
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPWD"].Value, "System.String");
			}
			set
			{
				m_Params["VPWD"].Value = value;
			}
		}
				
		public System.String VPYM
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPYM"].Value, "System.String");
			}
			set
			{
				m_Params["VPYM"].Value = value;
			}
		}
				
		public System.DateTime DBIRTHDAY
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DBIRTHDAY"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DBIRTHDAY"].Value = value;
			}
		}
				
		public System.Decimal NSTOP
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSTOP"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSTOP"].Value = value;
			}
		}
				
		public System.String VPATIENTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPATIENTID"].Value, "System.String");
			}
			set
			{
				m_Params["VPATIENTID"].Value = value;
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
	} // SS_InsertJZHZ
	#endregion
	
	#region SS_JZHZ_DeleteJZHZ
	/// 
	/// 对于DeleteJZHZ的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_JZHZ_DeleteJZHZ : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_JZHZ_DeleteJZHZ() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM JZHZ  WHERE  ID = :ID";
					
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
	} // SS_DeleteJZHZ
	#endregion
	
	#region SS_JZHZ_UpdateJZHZ
	/// 
	/// 对于UpdateJZHZ的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_JZHZ_UpdateJZHZ : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_JZHZ_UpdateJZHZ() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE JZHZ  SET  ID = :ID, NPHONE = :NPHONE, VNAME = :VNAME, NSEX = :NSEX, VSFZH = :VSFZH, VCARD = :VCARD, VPWD = :VPWD, VPYM = :VPYM, DBIRTHDAY = :DBIRTHDAY, NSTOP = :NSTOP, VPATIENTID = :VPATIENTID, DCREATE = :DCREATE   WHERE  ID = :OLDID";
					
			m_Params.AddParam("ID", "ID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("NPHONE", "NPHONE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VNAME", "VNAME", DataRowVersion.Current, OracleType.NVarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NSEX", "NSEX", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VSFZH", "VSFZH", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VCARD", "VCARD", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VPWD", "VPWD", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VPYM", "VPYM", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("DBIRTHDAY", "DBIRTHDAY", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NSTOP", "NSTOP", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VPATIENTID", "VPATIENTID", DataRowVersion.Current, OracleType.VarChar, 30, ParameterDirection.Input, null);		
			m_Params.AddParam("DCREATE", "DCREATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
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
				
		public System.Decimal NPHONE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPHONE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPHONE"].Value = value;
			}
		}
				
		public System.String VNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VNAME"].Value = value;
			}
		}
				
		public System.String NSEX
		{
			get
			{
				return (System.String)ConverValue(m_Params["NSEX"].Value, "System.String");
			}
			set
			{
				m_Params["NSEX"].Value = value;
			}
		}
				
		public System.String VSFZH
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSFZH"].Value, "System.String");
			}
			set
			{
				m_Params["VSFZH"].Value = value;
			}
		}
				
		public System.String VCARD
		{
			get
			{
				return (System.String)ConverValue(m_Params["VCARD"].Value, "System.String");
			}
			set
			{
				m_Params["VCARD"].Value = value;
			}
		}
				
		public System.String VPWD
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPWD"].Value, "System.String");
			}
			set
			{
				m_Params["VPWD"].Value = value;
			}
		}
				
		public System.String VPYM
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPYM"].Value, "System.String");
			}
			set
			{
				m_Params["VPYM"].Value = value;
			}
		}
				
		public System.DateTime DBIRTHDAY
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DBIRTHDAY"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DBIRTHDAY"].Value = value;
			}
		}
				
		public System.Decimal NSTOP
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSTOP"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSTOP"].Value = value;
			}
		}
				
		public System.String VPATIENTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPATIENTID"].Value, "System.String");
			}
			set
			{
				m_Params["VPATIENTID"].Value = value;
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
	} // SS_UpdateJZHZ
	#endregion
	
	#region SS_JZHZ_SelectByIDJZHZ
	/// 
	/// 对于SelectByIDJZHZ的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_JZHZ_SelectByIDJZHZ : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_JZHZ_SelectByIDJZHZ() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT ID, NPHONE, VNAME, NSEX, VSFZH, VCARD, VPWD, VPYM, DBIRTHDAY, NSTOP, VPATIENTID, DCREATE  FROM JZHZ  WHERE  ID = :ID";
					
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
	} // SS_SelectByIDJZHZ
	#endregion
	
	#region SS_JZHZ_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_JZHZ_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_JZHZ_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "select * from jzhz where 1=1";
			
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
	