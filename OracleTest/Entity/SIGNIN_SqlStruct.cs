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
	
	#region SS_SIGNIN_InsertSIGNIN
	/// 
	/// 对于InsertSIGNIN的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_SIGNIN_InsertSIGNIN : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_SIGNIN_InsertSIGNIN() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO SIGNIN  (VCLINICNO, DCREATE, NNUM)  VALUES (:VCLINICNO, :DCREATE, :NNUM)";
					
			m_Params.AddParam("VCLINICNO", "VCLINICNO", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("DCREATE", "DCREATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NNUM", "NNUM", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);
		}
				
		public System.String VCLINICNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VCLINICNO"].Value, "System.String");
			}
			set
			{
				m_Params["VCLINICNO"].Value = value;
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
				
		public System.Decimal NNUM
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NNUM"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NNUM"].Value = value;
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
	} // SS_InsertSIGNIN
	#endregion
	
	#region SS_SIGNIN_DeleteSIGNIN
	/// 
	/// 对于DeleteSIGNIN的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_SIGNIN_DeleteSIGNIN : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_SIGNIN_DeleteSIGNIN() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM SIGNIN  WHERE  VCLINICNO = :VCLINICNO";
					
			m_Params.AddParam("VCLINICNO", "VCLINICNO", DataRowVersion.Original, OracleType.VarChar, 10, ParameterDirection.Input, null);
		}
				
		public System.String VCLINICNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VCLINICNO"].Value, "System.String");
			}
			set
			{
				m_Params["VCLINICNO"].Value = value;
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
	} // SS_DeleteSIGNIN
	#endregion
	
	#region SS_SIGNIN_UpdateSIGNIN
	/// 
	/// 对于UpdateSIGNIN的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_SIGNIN_UpdateSIGNIN : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_SIGNIN_UpdateSIGNIN() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE SIGNIN  SET  VCLINICNO = :VCLINICNO, DCREATE = :DCREATE, NNUM = :NNUM   WHERE  VCLINICNO = :OLDVCLINICNO";
					
			m_Params.AddParam("VCLINICNO", "VCLINICNO", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("DCREATE", "DCREATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NNUM", "NNUM", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDVCLINICNO", "VCLINICNO", DataRowVersion.Original, OracleType.VarChar, 10, ParameterDirection.Input, null);
		}
				
		public System.String VCLINICNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VCLINICNO"].Value, "System.String");
			}
			set
			{
				m_Params["VCLINICNO"].Value = value;
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
				
		public System.Decimal NNUM
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NNUM"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NNUM"].Value = value;
			}
		}
				
		public System.String OLDVCLINICNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["OLDVCLINICNO"].Value, "System.String");
			}
			set
			{
				m_Params["OLDVCLINICNO"].Value = value;
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
	} // SS_UpdateSIGNIN
	#endregion
	
	#region SS_SIGNIN_SelectByIDSIGNIN
	/// 
	/// 对于SelectByIDSIGNIN的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_SIGNIN_SelectByIDSIGNIN : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_SIGNIN_SelectByIDSIGNIN() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT VCLINICNO, DCREATE, NNUM  FROM SIGNIN  WHERE  VCLINICNO = :VCLINICNO";
					
			m_Params.AddParam("VCLINICNO", "VCLINICNO", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);
		}
				
		public System.String VCLINICNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VCLINICNO"].Value, "System.String");
			}
			set
			{
				m_Params["VCLINICNO"].Value = value;
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
	} // SS_SelectByIDSIGNIN
	#endregion
	
	#region SS_SIGNIN_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_SIGNIN_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_SIGNIN_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "select * from signin where 1=1";
			
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
	