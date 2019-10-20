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

namespace HYGHSF.Entity
{
	
	#region SS_GHSF_REGPLAN_InsertGHSF_GHSF_REGPLAN
	/// 
	/// 对于InsertGHSF_GHSF_REGPLAN的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_REGPLAN_InsertGHSF_GHSF_REGPLAN : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_REGPLAN_InsertGHSF_GHSF_REGPLAN() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO GHSF.GHSF_REGPLAN  (VPLANID, VDOCTORID, NTIMEDESC, NREGLIMITS, NAPPLIMITS, NREGNUMBER, NAPPNUMBER, NREGPRICE, VOPERATORID, DCREATEDATE, VREMARKS, DCLINICDATE, VDEPTID, NHOSID)  VALUES (:VPLANID, :VDOCTORID, :NTIMEDESC, :NREGLIMITS, :NAPPLIMITS, :NREGNUMBER, :NAPPNUMBER, :NREGPRICE, :VOPERATORID, :DCREATEDATE, :VREMARKS, :DCLINICDATE, :VDEPTID, :NHOSID)";
					
			m_Params.AddParam("VPLANID", "VPLANID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VDOCTORID", "VDOCTORID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NTIMEDESC", "NTIMEDESC", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NREGLIMITS", "NREGLIMITS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NAPPLIMITS", "NAPPLIMITS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NREGNUMBER", "NREGNUMBER", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NAPPNUMBER", "NAPPNUMBER", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NREGPRICE", "NREGPRICE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VOPERATORID", "VOPERATORID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("DCREATEDATE", "DCREATEDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VREMARKS", "VREMARKS", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("DCLINICDATE", "DCLINICDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPTID", "VDEPTID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NHOSID", "NHOSID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);
		}
				
		public System.String VPLANID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPLANID"].Value, "System.String");
			}
			set
			{
				m_Params["VPLANID"].Value = value;
			}
		}
				
		public System.String VDOCTORID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDOCTORID"].Value, "System.String");
			}
			set
			{
				m_Params["VDOCTORID"].Value = value;
			}
		}
				
		public System.Decimal NTIMEDESC
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NTIMEDESC"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NTIMEDESC"].Value = value;
			}
		}
				
		public System.Decimal NREGLIMITS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NREGLIMITS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NREGLIMITS"].Value = value;
			}
		}
				
		public System.Decimal NAPPLIMITS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NAPPLIMITS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NAPPLIMITS"].Value = value;
			}
		}
				
		public System.Decimal NREGNUMBER
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NREGNUMBER"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NREGNUMBER"].Value = value;
			}
		}
				
		public System.Decimal NAPPNUMBER
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NAPPNUMBER"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NAPPNUMBER"].Value = value;
			}
		}
				
		public System.Decimal NREGPRICE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NREGPRICE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NREGPRICE"].Value = value;
			}
		}
				
		public System.String VOPERATORID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VOPERATORID"].Value, "System.String");
			}
			set
			{
				m_Params["VOPERATORID"].Value = value;
			}
		}
				
		public System.DateTime DCREATEDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DCREATEDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DCREATEDATE"].Value = value;
			}
		}
				
		public System.String VREMARKS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VREMARKS"].Value, "System.String");
			}
			set
			{
				m_Params["VREMARKS"].Value = value;
			}
		}
				
		public System.DateTime DCLINICDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DCLINICDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DCLINICDATE"].Value = value;
			}
		}
				
		public System.String VDEPTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEPTID"].Value, "System.String");
			}
			set
			{
				m_Params["VDEPTID"].Value = value;
			}
		}
				
		public System.Decimal NHOSID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NHOSID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NHOSID"].Value = value;
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
	} // SS_InsertGHSF_GHSF_REGPLAN
	#endregion
	
	#region SS_GHSF_REGPLAN_DeleteGHSF_GHSF_REGPLAN
	/// 
	/// 对于DeleteGHSF_GHSF_REGPLAN的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_REGPLAN_DeleteGHSF_GHSF_REGPLAN : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_REGPLAN_DeleteGHSF_GHSF_REGPLAN() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM GHSF.GHSF_REGPLAN  WHERE  VPLANID = :VPLANID";
					
			m_Params.AddParam("VPLANID", "VPLANID", DataRowVersion.Original, OracleType.VarChar, 10, ParameterDirection.Input, null);
		}
				
		public System.String VPLANID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPLANID"].Value, "System.String");
			}
			set
			{
				m_Params["VPLANID"].Value = value;
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
	} // SS_DeleteGHSF_GHSF_REGPLAN
	#endregion
	
	#region SS_GHSF_REGPLAN_UpdateGHSF_GHSF_REGPLAN
	/// 
	/// 对于UpdateGHSF_GHSF_REGPLAN的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_REGPLAN_UpdateGHSF_GHSF_REGPLAN : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_REGPLAN_UpdateGHSF_GHSF_REGPLAN() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE GHSF.GHSF_REGPLAN  SET  VPLANID = :VPLANID, VDOCTORID = :VDOCTORID, NTIMEDESC = :NTIMEDESC, NREGLIMITS = :NREGLIMITS, NAPPLIMITS = :NAPPLIMITS, NREGNUMBER = :NREGNUMBER, NAPPNUMBER = :NAPPNUMBER, NREGPRICE = :NREGPRICE, VOPERATORID = :VOPERATORID, DCREATEDATE = :DCREATEDATE, VREMARKS = :VREMARKS, DCLINICDATE = :DCLINICDATE, VDEPTID = :VDEPTID, NHOSID = :NHOSID   WHERE  VPLANID = :OLDVPLANID";
					
			m_Params.AddParam("VPLANID", "VPLANID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VDOCTORID", "VDOCTORID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NTIMEDESC", "NTIMEDESC", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NREGLIMITS", "NREGLIMITS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NAPPLIMITS", "NAPPLIMITS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NREGNUMBER", "NREGNUMBER", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NAPPNUMBER", "NAPPNUMBER", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NREGPRICE", "NREGPRICE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VOPERATORID", "VOPERATORID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("DCREATEDATE", "DCREATEDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VREMARKS", "VREMARKS", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("DCLINICDATE", "DCLINICDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPTID", "VDEPTID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NHOSID", "NHOSID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDVPLANID", "VPLANID", DataRowVersion.Original, OracleType.VarChar, 10, ParameterDirection.Input, null);
		}
				
		public System.String VPLANID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPLANID"].Value, "System.String");
			}
			set
			{
				m_Params["VPLANID"].Value = value;
			}
		}
				
		public System.String VDOCTORID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDOCTORID"].Value, "System.String");
			}
			set
			{
				m_Params["VDOCTORID"].Value = value;
			}
		}
				
		public System.Decimal NTIMEDESC
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NTIMEDESC"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NTIMEDESC"].Value = value;
			}
		}
				
		public System.Decimal NREGLIMITS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NREGLIMITS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NREGLIMITS"].Value = value;
			}
		}
				
		public System.Decimal NAPPLIMITS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NAPPLIMITS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NAPPLIMITS"].Value = value;
			}
		}
				
		public System.Decimal NREGNUMBER
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NREGNUMBER"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NREGNUMBER"].Value = value;
			}
		}
				
		public System.Decimal NAPPNUMBER
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NAPPNUMBER"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NAPPNUMBER"].Value = value;
			}
		}
				
		public System.Decimal NREGPRICE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NREGPRICE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NREGPRICE"].Value = value;
			}
		}
				
		public System.String VOPERATORID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VOPERATORID"].Value, "System.String");
			}
			set
			{
				m_Params["VOPERATORID"].Value = value;
			}
		}
				
		public System.DateTime DCREATEDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DCREATEDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DCREATEDATE"].Value = value;
			}
		}
				
		public System.String VREMARKS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VREMARKS"].Value, "System.String");
			}
			set
			{
				m_Params["VREMARKS"].Value = value;
			}
		}
				
		public System.DateTime DCLINICDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DCLINICDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DCLINICDATE"].Value = value;
			}
		}
				
		public System.String VDEPTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEPTID"].Value, "System.String");
			}
			set
			{
				m_Params["VDEPTID"].Value = value;
			}
		}
				
		public System.Decimal NHOSID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NHOSID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NHOSID"].Value = value;
			}
		}
				
		public System.String OLDVPLANID
		{
			get
			{
				return (System.String)ConverValue(m_Params["OLDVPLANID"].Value, "System.String");
			}
			set
			{
				m_Params["OLDVPLANID"].Value = value;
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
	} // SS_UpdateGHSF_GHSF_REGPLAN
	#endregion
	
	#region SS_GHSF_REGPLAN_SelectByIDGHSF_GHSF_REGPLAN
	/// 
	/// 对于SelectByIDGHSF_GHSF_REGPLAN的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_REGPLAN_SelectByIDGHSF_GHSF_REGPLAN : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_REGPLAN_SelectByIDGHSF_GHSF_REGPLAN() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT VPLANID, VDOCTORID, NTIMEDESC, NREGLIMITS, NAPPLIMITS, NREGNUMBER, NAPPNUMBER, NREGPRICE, VOPERATORID, DCREATEDATE, VREMARKS, DCLINICDATE, VDEPTID, NHOSID  FROM GHSF.GHSF_REGPLAN  WHERE  VPLANID = :VPLANID";
					
			m_Params.AddParam("VPLANID", "VPLANID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);
		}
				
		public System.String VPLANID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPLANID"].Value, "System.String");
			}
			set
			{
				m_Params["VPLANID"].Value = value;
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
	} // SS_SelectByIDGHSF_GHSF_REGPLAN
	#endregion
	
	#region SS_GHSF_REGPLAN_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_REGPLAN_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_REGPLAN_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT * FROM GHSF.GHSF_REGPLAN  WHERE 1=1";
			
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
	