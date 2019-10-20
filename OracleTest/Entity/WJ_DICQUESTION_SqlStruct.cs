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
	
	#region SS_WJ_DICQUESTION_InsertWJ_DICQUESTION
	/// 
	/// 对于InsertWJ_DICQUESTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_WJ_DICQUESTION_InsertWJ_DICQUESTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_WJ_DICQUESTION_InsertWJ_DICQUESTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO WJ_DICQUESTION  (VID, VNAME, NSTOP, NLX, VPID, DCREATE, NSORT, NBIXUAN)  VALUES (:VID, :VNAME, :NSTOP, :NLX, :VPID, :DCREATE, :NSORT, :NBIXUAN)";
					
			m_Params.AddParam("VID", "VID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VNAME", "VNAME", DataRowVersion.Current, OracleType.NVarChar, 30, ParameterDirection.Input, null);		
			m_Params.AddParam("NSTOP", "NSTOP", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NLX", "NLX", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VPID", "VPID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("DCREATE", "DCREATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NSORT", "NSORT", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NBIXUAN", "NBIXUAN", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);
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
				
		public System.Decimal NLX
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NLX"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NLX"].Value = value;
			}
		}
				
		public System.String VPID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPID"].Value, "System.String");
			}
			set
			{
				m_Params["VPID"].Value = value;
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
				
		public System.Decimal NSORT
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSORT"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSORT"].Value = value;
			}
		}
				
		public System.Decimal NBIXUAN
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NBIXUAN"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NBIXUAN"].Value = value;
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
	} // SS_InsertWJ_DICQUESTION
	#endregion
	
	#region SS_WJ_DICQUESTION_DeleteWJ_DICQUESTION
	/// 
	/// 对于DeleteWJ_DICQUESTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_WJ_DICQUESTION_DeleteWJ_DICQUESTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_WJ_DICQUESTION_DeleteWJ_DICQUESTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM WJ_DICQUESTION  WHERE  VID = :VID";
					
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
	} // SS_DeleteWJ_DICQUESTION
	#endregion
	
	#region SS_WJ_DICQUESTION_UpdateWJ_DICQUESTION
	/// 
	/// 对于UpdateWJ_DICQUESTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_WJ_DICQUESTION_UpdateWJ_DICQUESTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_WJ_DICQUESTION_UpdateWJ_DICQUESTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE WJ_DICQUESTION  SET  VID = :VID, VNAME = :VNAME, NSTOP = :NSTOP, NLX = :NLX, VPID = :VPID, DCREATE = :DCREATE, NSORT = :NSORT, NBIXUAN = :NBIXUAN   WHERE  VID = :OLDVID";
					
			m_Params.AddParam("VID", "VID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("VNAME", "VNAME", DataRowVersion.Current, OracleType.NVarChar, 30, ParameterDirection.Input, null);		
			m_Params.AddParam("NSTOP", "NSTOP", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NLX", "NLX", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VPID", "VPID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("DCREATE", "DCREATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NSORT", "NSORT", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NBIXUAN", "NBIXUAN", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
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
				
		public System.Decimal NLX
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NLX"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NLX"].Value = value;
			}
		}
				
		public System.String VPID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPID"].Value, "System.String");
			}
			set
			{
				m_Params["VPID"].Value = value;
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
				
		public System.Decimal NSORT
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSORT"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSORT"].Value = value;
			}
		}
				
		public System.Decimal NBIXUAN
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NBIXUAN"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NBIXUAN"].Value = value;
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
	} // SS_UpdateWJ_DICQUESTION
	#endregion
	
	#region SS_WJ_DICQUESTION_SelectByIDWJ_DICQUESTION
	/// 
	/// 对于SelectByIDWJ_DICQUESTION的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_WJ_DICQUESTION_SelectByIDWJ_DICQUESTION : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_WJ_DICQUESTION_SelectByIDWJ_DICQUESTION() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT VID, VNAME, NSTOP, NLX, VPID, DCREATE, NSORT, NBIXUAN  FROM WJ_DICQUESTION  WHERE  VID = :VID";
					
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
	} // SS_SelectByIDWJ_DICQUESTION
	#endregion
	
	#region SS_WJ_DICQUESTION_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_WJ_DICQUESTION_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_WJ_DICQUESTION_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "select * from WJ_DICQUESTION where 1=1";
			
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
	