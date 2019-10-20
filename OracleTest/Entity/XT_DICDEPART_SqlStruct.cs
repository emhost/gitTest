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
	
	#region SS_XT_DICDEPART_InsertXT_XT_DICDEPART
	/// 
	/// 对于InsertXT_XT_DICDEPART的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_XT_DICDEPART_InsertXT_XT_DICDEPART : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_XT_DICDEPART_InsertXT_XT_DICDEPART() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO XT.XT_DICDEPART  (VHOSDISTRICTID, VDEPARTCODE, VDEPARTNAME, VPARENTCODE, NDEPARTORDER, PINYINMA, WUBIMA, VDEPARTADDRESS, NISDISABLED, NMESSAGE, NBEDNUM, NHOSID, NALLOWARREARS, ISZJKS, VYBCODE, VNHCODE, NOPHZID, VSTORAGEID)  VALUES (:VHOSDISTRICTID, :VDEPARTCODE, :VDEPARTNAME, :VPARENTCODE, :NDEPARTORDER, :PINYINMA, :WUBIMA, :VDEPARTADDRESS, :NISDISABLED, :NMESSAGE, :NBEDNUM, :NHOSID, :NALLOWARREARS, :ISZJKS, :VYBCODE, :VNHCODE, :NOPHZID, :VSTORAGEID)";
					
			m_Params.AddParam("VHOSDISTRICTID", "VHOSDISTRICTID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPARTCODE", "VDEPARTCODE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPARTNAME", "VDEPARTNAME", DataRowVersion.Current, OracleType.NVarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("VPARENTCODE", "VPARENTCODE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NDEPARTORDER", "NDEPARTORDER", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("PINYINMA", "PINYINMA", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("WUBIMA", "WUBIMA", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPARTADDRESS", "VDEPARTADDRESS", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NISDISABLED", "NISDISABLED", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NMESSAGE", "NMESSAGE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NBEDNUM", "NBEDNUM", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NHOSID", "NHOSID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NALLOWARREARS", "NALLOWARREARS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("ISZJKS", "ISZJKS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VYBCODE", "VYBCODE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VNHCODE", "VNHCODE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NOPHZID", "NOPHZID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VSTORAGEID", "VSTORAGEID", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);
		}
				
		public System.Decimal VHOSDISTRICTID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["VHOSDISTRICTID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["VHOSDISTRICTID"].Value = value;
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
				
		public System.String VDEPARTNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEPARTNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VDEPARTNAME"].Value = value;
			}
		}
				
		public System.String VPARENTCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPARENTCODE"].Value, "System.String");
			}
			set
			{
				m_Params["VPARENTCODE"].Value = value;
			}
		}
				
		public System.Decimal NDEPARTORDER
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDEPARTORDER"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDEPARTORDER"].Value = value;
			}
		}
				
		public System.String PINYINMA
		{
			get
			{
				return (System.String)ConverValue(m_Params["PINYINMA"].Value, "System.String");
			}
			set
			{
				m_Params["PINYINMA"].Value = value;
			}
		}
				
		public System.String WUBIMA
		{
			get
			{
				return (System.String)ConverValue(m_Params["WUBIMA"].Value, "System.String");
			}
			set
			{
				m_Params["WUBIMA"].Value = value;
			}
		}
				
		public System.String VDEPARTADDRESS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEPARTADDRESS"].Value, "System.String");
			}
			set
			{
				m_Params["VDEPARTADDRESS"].Value = value;
			}
		}
				
		public System.Decimal NISDISABLED
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NISDISABLED"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NISDISABLED"].Value = value;
			}
		}
				
		public System.Decimal NMESSAGE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NMESSAGE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NMESSAGE"].Value = value;
			}
		}
				
		public System.Decimal NBEDNUM
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NBEDNUM"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NBEDNUM"].Value = value;
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
				
		public System.Decimal NALLOWARREARS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NALLOWARREARS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NALLOWARREARS"].Value = value;
			}
		}
				
		public System.Decimal ISZJKS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["ISZJKS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["ISZJKS"].Value = value;
			}
		}
				
		public System.String VYBCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VYBCODE"].Value, "System.String");
			}
			set
			{
				m_Params["VYBCODE"].Value = value;
			}
		}
				
		public System.String VNHCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNHCODE"].Value, "System.String");
			}
			set
			{
				m_Params["VNHCODE"].Value = value;
			}
		}
				
		public System.String NOPHZID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NOPHZID"].Value, "System.String");
			}
			set
			{
				m_Params["NOPHZID"].Value = value;
			}
		}
				
		public System.String VSTORAGEID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSTORAGEID"].Value, "System.String");
			}
			set
			{
				m_Params["VSTORAGEID"].Value = value;
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
	} // SS_InsertXT_XT_DICDEPART
	#endregion
	
	#region SS_XT_DICDEPART_DeleteXT_XT_DICDEPART
	/// 
	/// 对于DeleteXT_XT_DICDEPART的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_XT_DICDEPART_DeleteXT_XT_DICDEPART : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_XT_DICDEPART_DeleteXT_XT_DICDEPART() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM XT.XT_DICDEPART  WHERE  VDEPARTCODE = :VDEPARTCODE";
					
			m_Params.AddParam("VDEPARTCODE", "VDEPARTCODE", DataRowVersion.Original, OracleType.VarChar, 20, ParameterDirection.Input, null);
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
	} // SS_DeleteXT_XT_DICDEPART
	#endregion
	
	#region SS_XT_DICDEPART_UpdateXT_XT_DICDEPART
	/// 
	/// 对于UpdateXT_XT_DICDEPART的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_XT_DICDEPART_UpdateXT_XT_DICDEPART : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_XT_DICDEPART_UpdateXT_XT_DICDEPART() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE XT.XT_DICDEPART  SET  VHOSDISTRICTID = :VHOSDISTRICTID, VDEPARTCODE = :VDEPARTCODE, VDEPARTNAME = :VDEPARTNAME, VPARENTCODE = :VPARENTCODE, NDEPARTORDER = :NDEPARTORDER, PINYINMA = :PINYINMA, WUBIMA = :WUBIMA, VDEPARTADDRESS = :VDEPARTADDRESS, NISDISABLED = :NISDISABLED, NMESSAGE = :NMESSAGE, NBEDNUM = :NBEDNUM, NHOSID = :NHOSID, NALLOWARREARS = :NALLOWARREARS, ISZJKS = :ISZJKS, VYBCODE = :VYBCODE, VNHCODE = :VNHCODE, NOPHZID = :NOPHZID, VSTORAGEID = :VSTORAGEID   WHERE  VDEPARTCODE = :OLDVDEPARTCODE";
					
			m_Params.AddParam("VHOSDISTRICTID", "VHOSDISTRICTID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPARTCODE", "VDEPARTCODE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPARTNAME", "VDEPARTNAME", DataRowVersion.Current, OracleType.NVarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("VPARENTCODE", "VPARENTCODE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NDEPARTORDER", "NDEPARTORDER", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("PINYINMA", "PINYINMA", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("WUBIMA", "WUBIMA", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPARTADDRESS", "VDEPARTADDRESS", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NISDISABLED", "NISDISABLED", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NMESSAGE", "NMESSAGE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NBEDNUM", "NBEDNUM", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NHOSID", "NHOSID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NALLOWARREARS", "NALLOWARREARS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("ISZJKS", "ISZJKS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VYBCODE", "VYBCODE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VNHCODE", "VNHCODE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NOPHZID", "NOPHZID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VSTORAGEID", "VSTORAGEID", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDVDEPARTCODE", "VDEPARTCODE", DataRowVersion.Original, OracleType.VarChar, 20, ParameterDirection.Input, null);
		}
				
		public System.Decimal VHOSDISTRICTID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["VHOSDISTRICTID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["VHOSDISTRICTID"].Value = value;
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
				
		public System.String VDEPARTNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEPARTNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VDEPARTNAME"].Value = value;
			}
		}
				
		public System.String VPARENTCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPARENTCODE"].Value, "System.String");
			}
			set
			{
				m_Params["VPARENTCODE"].Value = value;
			}
		}
				
		public System.Decimal NDEPARTORDER
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDEPARTORDER"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDEPARTORDER"].Value = value;
			}
		}
				
		public System.String PINYINMA
		{
			get
			{
				return (System.String)ConverValue(m_Params["PINYINMA"].Value, "System.String");
			}
			set
			{
				m_Params["PINYINMA"].Value = value;
			}
		}
				
		public System.String WUBIMA
		{
			get
			{
				return (System.String)ConverValue(m_Params["WUBIMA"].Value, "System.String");
			}
			set
			{
				m_Params["WUBIMA"].Value = value;
			}
		}
				
		public System.String VDEPARTADDRESS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEPARTADDRESS"].Value, "System.String");
			}
			set
			{
				m_Params["VDEPARTADDRESS"].Value = value;
			}
		}
				
		public System.Decimal NISDISABLED
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NISDISABLED"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NISDISABLED"].Value = value;
			}
		}
				
		public System.Decimal NMESSAGE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NMESSAGE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NMESSAGE"].Value = value;
			}
		}
				
		public System.Decimal NBEDNUM
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NBEDNUM"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NBEDNUM"].Value = value;
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
				
		public System.Decimal NALLOWARREARS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NALLOWARREARS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NALLOWARREARS"].Value = value;
			}
		}
				
		public System.Decimal ISZJKS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["ISZJKS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["ISZJKS"].Value = value;
			}
		}
				
		public System.String VYBCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VYBCODE"].Value, "System.String");
			}
			set
			{
				m_Params["VYBCODE"].Value = value;
			}
		}
				
		public System.String VNHCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNHCODE"].Value, "System.String");
			}
			set
			{
				m_Params["VNHCODE"].Value = value;
			}
		}
				
		public System.String NOPHZID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NOPHZID"].Value, "System.String");
			}
			set
			{
				m_Params["NOPHZID"].Value = value;
			}
		}
				
		public System.String VSTORAGEID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSTORAGEID"].Value, "System.String");
			}
			set
			{
				m_Params["VSTORAGEID"].Value = value;
			}
		}
				
		public System.String OLDVDEPARTCODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["OLDVDEPARTCODE"].Value, "System.String");
			}
			set
			{
				m_Params["OLDVDEPARTCODE"].Value = value;
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
	} // SS_UpdateXT_XT_DICDEPART
	#endregion
	
	#region SS_XT_DICDEPART_SelectByIDXT_XT_DICDEPART
	/// 
	/// 对于SelectByIDXT_XT_DICDEPART的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_XT_DICDEPART_SelectByIDXT_XT_DICDEPART : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_XT_DICDEPART_SelectByIDXT_XT_DICDEPART() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT VHOSDISTRICTID, VDEPARTCODE, VDEPARTNAME, VPARENTCODE, NDEPARTORDER, PINYINMA, WUBIMA, VDEPARTADDRESS, NISDISABLED, NMESSAGE, NBEDNUM, NHOSID, NALLOWARREARS, ISZJKS, VYBCODE, VNHCODE, NOPHZID, VSTORAGEID  FROM XT.XT_DICDEPART  WHERE  VDEPARTCODE = :VDEPARTCODE";
					
			m_Params.AddParam("VDEPARTCODE", "VDEPARTCODE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);
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
	} // SS_SelectByIDXT_XT_DICDEPART
	#endregion
	
	#region SS_XT_DICDEPART_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_XT_DICDEPART_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_XT_DICDEPART_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT * FROM XT.XT_DICDEPART  WHERE 1=1";
			
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
	