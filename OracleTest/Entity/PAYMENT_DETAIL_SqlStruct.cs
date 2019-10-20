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
	
	#region SS_PAYMENT_DETAIL_InsertPAYMENT_DETAIL
	/// 
	/// 对于InsertPAYMENT_DETAIL的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_PAYMENT_DETAIL_InsertPAYMENT_DETAIL : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_PAYMENT_DETAIL_InsertPAYMENT_DETAIL() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO PAYMENT_DETAIL  (VID, VPRESC_ID, VPRESC_TYPE, VITEM_CODE, VITEM_NAME, NPRICE, NSL, VPRESC_DETAIL_ID, VCLINICNO, VITEM_TYPE, VDDLSH)  VALUES (:VID, :VPRESC_ID, :VPRESC_TYPE, :VITEM_CODE, :VITEM_NAME, :NPRICE, :NSL, :VPRESC_DETAIL_ID, :VCLINICNO, :VITEM_TYPE, :VDDLSH)";
					
			m_Params.AddParam("VID", "VID", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRESC_ID", "VPRESC_ID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRESC_TYPE", "VPRESC_TYPE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEM_CODE", "VITEM_CODE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEM_NAME", "VITEM_NAME", DataRowVersion.Current, OracleType.NVarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NPRICE", "NPRICE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NSL", "NSL", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRESC_DETAIL_ID", "VPRESC_DETAIL_ID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VCLINICNO", "VCLINICNO", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEM_TYPE", "VITEM_TYPE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VDDLSH", "VDDLSH", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);
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
				
		public System.String VPRESC_ID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPRESC_ID"].Value, "System.String");
			}
			set
			{
				m_Params["VPRESC_ID"].Value = value;
			}
		}
				
		public System.String VPRESC_TYPE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPRESC_TYPE"].Value, "System.String");
			}
			set
			{
				m_Params["VPRESC_TYPE"].Value = value;
			}
		}
				
		public System.String VITEM_CODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEM_CODE"].Value, "System.String");
			}
			set
			{
				m_Params["VITEM_CODE"].Value = value;
			}
		}
				
		public System.String VITEM_NAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEM_NAME"].Value, "System.String");
			}
			set
			{
				m_Params["VITEM_NAME"].Value = value;
			}
		}
				
		public System.Decimal NPRICE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPRICE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPRICE"].Value = value;
			}
		}
				
		public System.Decimal NSL
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSL"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSL"].Value = value;
			}
		}
				
		public System.String VPRESC_DETAIL_ID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPRESC_DETAIL_ID"].Value, "System.String");
			}
			set
			{
				m_Params["VPRESC_DETAIL_ID"].Value = value;
			}
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
				
		public System.String VITEM_TYPE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEM_TYPE"].Value, "System.String");
			}
			set
			{
				m_Params["VITEM_TYPE"].Value = value;
			}
		}
				
		public System.String VDDLSH
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDDLSH"].Value, "System.String");
			}
			set
			{
				m_Params["VDDLSH"].Value = value;
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
	} // SS_InsertPAYMENT_DETAIL
	#endregion
	
	#region SS_PAYMENT_DETAIL_DeletePAYMENT_DETAIL
	/// 
	/// 对于DeletePAYMENT_DETAIL的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_PAYMENT_DETAIL_DeletePAYMENT_DETAIL : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_PAYMENT_DETAIL_DeletePAYMENT_DETAIL() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM PAYMENT_DETAIL  WHERE  VID = :VID";
					
			m_Params.AddParam("VID", "VID", DataRowVersion.Original, OracleType.VarChar, 50, ParameterDirection.Input, null);
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
	} // SS_DeletePAYMENT_DETAIL
	#endregion
	
	#region SS_PAYMENT_DETAIL_UpdatePAYMENT_DETAIL
	/// 
	/// 对于UpdatePAYMENT_DETAIL的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_PAYMENT_DETAIL_UpdatePAYMENT_DETAIL : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_PAYMENT_DETAIL_UpdatePAYMENT_DETAIL() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE PAYMENT_DETAIL  SET  VID = :VID, VPRESC_ID = :VPRESC_ID, VPRESC_TYPE = :VPRESC_TYPE, VITEM_CODE = :VITEM_CODE, VITEM_NAME = :VITEM_NAME, NPRICE = :NPRICE, NSL = :NSL, VPRESC_DETAIL_ID = :VPRESC_DETAIL_ID, VCLINICNO = :VCLINICNO, VITEM_TYPE = :VITEM_TYPE, VDDLSH = :VDDLSH   WHERE  VID = :OLDVID";
					
			m_Params.AddParam("VID", "VID", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRESC_ID", "VPRESC_ID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRESC_TYPE", "VPRESC_TYPE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEM_CODE", "VITEM_CODE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEM_NAME", "VITEM_NAME", DataRowVersion.Current, OracleType.NVarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NPRICE", "NPRICE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NSL", "NSL", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRESC_DETAIL_ID", "VPRESC_DETAIL_ID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VCLINICNO", "VCLINICNO", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEM_TYPE", "VITEM_TYPE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VDDLSH", "VDDLSH", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDVID", "VID", DataRowVersion.Original, OracleType.VarChar, 50, ParameterDirection.Input, null);
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
				
		public System.String VPRESC_ID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPRESC_ID"].Value, "System.String");
			}
			set
			{
				m_Params["VPRESC_ID"].Value = value;
			}
		}
				
		public System.String VPRESC_TYPE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPRESC_TYPE"].Value, "System.String");
			}
			set
			{
				m_Params["VPRESC_TYPE"].Value = value;
			}
		}
				
		public System.String VITEM_CODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEM_CODE"].Value, "System.String");
			}
			set
			{
				m_Params["VITEM_CODE"].Value = value;
			}
		}
				
		public System.String VITEM_NAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEM_NAME"].Value, "System.String");
			}
			set
			{
				m_Params["VITEM_NAME"].Value = value;
			}
		}
				
		public System.Decimal NPRICE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPRICE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPRICE"].Value = value;
			}
		}
				
		public System.Decimal NSL
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSL"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSL"].Value = value;
			}
		}
				
		public System.String VPRESC_DETAIL_ID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPRESC_DETAIL_ID"].Value, "System.String");
			}
			set
			{
				m_Params["VPRESC_DETAIL_ID"].Value = value;
			}
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
				
		public System.String VITEM_TYPE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEM_TYPE"].Value, "System.String");
			}
			set
			{
				m_Params["VITEM_TYPE"].Value = value;
			}
		}
				
		public System.String VDDLSH
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDDLSH"].Value, "System.String");
			}
			set
			{
				m_Params["VDDLSH"].Value = value;
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
	} // SS_UpdatePAYMENT_DETAIL
	#endregion
	
	#region SS_PAYMENT_DETAIL_SelectByIDPAYMENT_DETAIL
	/// 
	/// 对于SelectByIDPAYMENT_DETAIL的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_PAYMENT_DETAIL_SelectByIDPAYMENT_DETAIL : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_PAYMENT_DETAIL_SelectByIDPAYMENT_DETAIL() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT VID, VPRESC_ID, VPRESC_TYPE, VITEM_CODE, VITEM_NAME, NPRICE, NSL, VPRESC_DETAIL_ID, VCLINICNO, VITEM_TYPE, VDDLSH  FROM PAYMENT_DETAIL  WHERE  VID = :VID";
					
			m_Params.AddParam("VID", "VID", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);
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
	} // SS_SelectByIDPAYMENT_DETAIL
	#endregion
	
	#region SS_PAYMENT_DETAIL_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_PAYMENT_DETAIL_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_PAYMENT_DETAIL_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "select * from PAYMENT_DETAIL where 1=1";
			
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
	