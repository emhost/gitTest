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
	
	#region SS_GHSF_NOTEMANAGE_InsertGHSF_GHSF_NOTEMANAGE
	/// 
	/// 对于InsertGHSF_GHSF_NOTEMANAGE的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_NOTEMANAGE_InsertGHSF_GHSF_NOTEMANAGE : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_NOTEMANAGE_InsertGHSF_GHSF_NOTEMANAGE() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO GHSF.GHSF_NOTEMANAGE  (VNOTEMANAGEID, NPIAOJVLB, NQISHIH, NZHONGZHIH, NYISHIYH, VLINGYONGR, VJINGBANR, DLINGYONGRQ, VREMARKS, VOPERATORID, DOPERATORDATE)  VALUES (:VNOTEMANAGEID, :NPIAOJVLB, :NQISHIH, :NZHONGZHIH, :NYISHIYH, :VLINGYONGR, :VJINGBANR, :DLINGYONGRQ, :VREMARKS, :VOPERATORID, :DOPERATORDATE)";
					
			m_Params.AddParam("VNOTEMANAGEID", "VNOTEMANAGEID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NPIAOJVLB", "NPIAOJVLB", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NQISHIH", "NQISHIH", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NZHONGZHIH", "NZHONGZHIH", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NYISHIYH", "NYISHIYH", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VLINGYONGR", "VLINGYONGR", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VJINGBANR", "VJINGBANR", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("DLINGYONGRQ", "DLINGYONGRQ", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VREMARKS", "VREMARKS", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VOPERATORID", "VOPERATORID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("DOPERATORDATE", "DOPERATORDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);
		}
				
		public System.String VNOTEMANAGEID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNOTEMANAGEID"].Value, "System.String");
			}
			set
			{
				m_Params["VNOTEMANAGEID"].Value = value;
			}
		}
				
		public System.Decimal NPIAOJVLB
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPIAOJVLB"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPIAOJVLB"].Value = value;
			}
		}
				
		public System.Decimal NQISHIH
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NQISHIH"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NQISHIH"].Value = value;
			}
		}
				
		public System.Decimal NZHONGZHIH
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NZHONGZHIH"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NZHONGZHIH"].Value = value;
			}
		}
				
		public System.Decimal NYISHIYH
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NYISHIYH"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NYISHIYH"].Value = value;
			}
		}
				
		public System.String VLINGYONGR
		{
			get
			{
				return (System.String)ConverValue(m_Params["VLINGYONGR"].Value, "System.String");
			}
			set
			{
				m_Params["VLINGYONGR"].Value = value;
			}
		}
				
		public System.String VJINGBANR
		{
			get
			{
				return (System.String)ConverValue(m_Params["VJINGBANR"].Value, "System.String");
			}
			set
			{
				m_Params["VJINGBANR"].Value = value;
			}
		}
				
		public System.DateTime DLINGYONGRQ
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DLINGYONGRQ"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DLINGYONGRQ"].Value = value;
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
				
		public System.DateTime DOPERATORDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DOPERATORDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DOPERATORDATE"].Value = value;
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
	} // SS_InsertGHSF_GHSF_NOTEMANAGE
	#endregion
	
	#region SS_GHSF_NOTEMANAGE_DeleteGHSF_GHSF_NOTEMANAGE
	/// 
	/// 对于DeleteGHSF_GHSF_NOTEMANAGE的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_NOTEMANAGE_DeleteGHSF_GHSF_NOTEMANAGE : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_NOTEMANAGE_DeleteGHSF_GHSF_NOTEMANAGE() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM GHSF.GHSF_NOTEMANAGE  WHERE  VNOTEMANAGEID = :VNOTEMANAGEID";
					
			m_Params.AddParam("VNOTEMANAGEID", "VNOTEMANAGEID", DataRowVersion.Original, OracleType.VarChar, 10, ParameterDirection.Input, null);
		}
				
		public System.String VNOTEMANAGEID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNOTEMANAGEID"].Value, "System.String");
			}
			set
			{
				m_Params["VNOTEMANAGEID"].Value = value;
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
	} // SS_DeleteGHSF_GHSF_NOTEMANAGE
	#endregion
	
	#region SS_GHSF_NOTEMANAGE_UpdateGHSF_GHSF_NOTEMANAGE
	/// 
	/// 对于UpdateGHSF_GHSF_NOTEMANAGE的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_NOTEMANAGE_UpdateGHSF_GHSF_NOTEMANAGE : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_NOTEMANAGE_UpdateGHSF_GHSF_NOTEMANAGE() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE GHSF.GHSF_NOTEMANAGE  SET  VNOTEMANAGEID = :VNOTEMANAGEID, NPIAOJVLB = :NPIAOJVLB, NQISHIH = :NQISHIH, NZHONGZHIH = :NZHONGZHIH, NYISHIYH = :NYISHIYH, VLINGYONGR = :VLINGYONGR, VJINGBANR = :VJINGBANR, DLINGYONGRQ = :DLINGYONGRQ, VREMARKS = :VREMARKS, VOPERATORID = :VOPERATORID, DOPERATORDATE = :DOPERATORDATE   WHERE  VNOTEMANAGEID = :OLDVNOTEMANAGEID";
					
			m_Params.AddParam("VNOTEMANAGEID", "VNOTEMANAGEID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NPIAOJVLB", "NPIAOJVLB", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NQISHIH", "NQISHIH", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NZHONGZHIH", "NZHONGZHIH", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NYISHIYH", "NYISHIYH", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VLINGYONGR", "VLINGYONGR", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VJINGBANR", "VJINGBANR", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("DLINGYONGRQ", "DLINGYONGRQ", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VREMARKS", "VREMARKS", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VOPERATORID", "VOPERATORID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("DOPERATORDATE", "DOPERATORDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDVNOTEMANAGEID", "VNOTEMANAGEID", DataRowVersion.Original, OracleType.VarChar, 10, ParameterDirection.Input, null);
		}
				
		public System.String VNOTEMANAGEID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNOTEMANAGEID"].Value, "System.String");
			}
			set
			{
				m_Params["VNOTEMANAGEID"].Value = value;
			}
		}
				
		public System.Decimal NPIAOJVLB
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPIAOJVLB"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPIAOJVLB"].Value = value;
			}
		}
				
		public System.Decimal NQISHIH
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NQISHIH"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NQISHIH"].Value = value;
			}
		}
				
		public System.Decimal NZHONGZHIH
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NZHONGZHIH"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NZHONGZHIH"].Value = value;
			}
		}
				
		public System.Decimal NYISHIYH
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NYISHIYH"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NYISHIYH"].Value = value;
			}
		}
				
		public System.String VLINGYONGR
		{
			get
			{
				return (System.String)ConverValue(m_Params["VLINGYONGR"].Value, "System.String");
			}
			set
			{
				m_Params["VLINGYONGR"].Value = value;
			}
		}
				
		public System.String VJINGBANR
		{
			get
			{
				return (System.String)ConverValue(m_Params["VJINGBANR"].Value, "System.String");
			}
			set
			{
				m_Params["VJINGBANR"].Value = value;
			}
		}
				
		public System.DateTime DLINGYONGRQ
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DLINGYONGRQ"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DLINGYONGRQ"].Value = value;
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
				
		public System.DateTime DOPERATORDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DOPERATORDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DOPERATORDATE"].Value = value;
			}
		}
				
		public System.String OLDVNOTEMANAGEID
		{
			get
			{
				return (System.String)ConverValue(m_Params["OLDVNOTEMANAGEID"].Value, "System.String");
			}
			set
			{
				m_Params["OLDVNOTEMANAGEID"].Value = value;
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
	} // SS_UpdateGHSF_GHSF_NOTEMANAGE
	#endregion
	
	#region SS_GHSF_NOTEMANAGE_SelectByIDGHSF_GHSF_NOTEMANAGE
	/// 
	/// 对于SelectByIDGHSF_GHSF_NOTEMANAGE的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_NOTEMANAGE_SelectByIDGHSF_GHSF_NOTEMANAGE : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_NOTEMANAGE_SelectByIDGHSF_GHSF_NOTEMANAGE() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT VNOTEMANAGEID, NPIAOJVLB, NQISHIH, NZHONGZHIH, NYISHIYH, VLINGYONGR, VJINGBANR, DLINGYONGRQ, VREMARKS, VOPERATORID, DOPERATORDATE  FROM GHSF.GHSF_NOTEMANAGE  WHERE  VNOTEMANAGEID = :VNOTEMANAGEID";
					
			m_Params.AddParam("VNOTEMANAGEID", "VNOTEMANAGEID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);
		}
				
		public System.String VNOTEMANAGEID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNOTEMANAGEID"].Value, "System.String");
			}
			set
			{
				m_Params["VNOTEMANAGEID"].Value = value;
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
	} // SS_SelectByIDGHSF_GHSF_NOTEMANAGE
	#endregion
	
	#region SS_GHSF_NOTEMANAGE_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_NOTEMANAGE_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_NOTEMANAGE_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT * FROM GHSF.GHSF_NOTEMANAGE  WHERE 1=1";
			
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
	