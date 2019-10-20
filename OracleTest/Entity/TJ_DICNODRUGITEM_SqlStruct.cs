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
	
	#region SS_TJ_DICNODRUGITEM_InsertTJ_TJ_DICNODRUGITEM
	/// 
	/// 对于InsertTJ_TJ_DICNODRUGITEM的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TJ_DICNODRUGITEM_InsertTJ_TJ_DICNODRUGITEM : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TJ_DICNODRUGITEM_InsertTJ_TJ_DICNODRUGITEM() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO TJ.TJ_DICNODRUGITEM  (EVITEMNAME, HISNITEMTYPE, LISUNIT, CREATE_DATE, CREATE_DEPT, CREATE_DOCT, LAST_DATE, LAST_DOCT, NITEMID, NNODRUGITEMPRICE, NNODRUGITEMUNIT, VDEPARTID, NISSTOP, NISPACK, VITEMDES, PINYINMA, WUBIMA, NCHARGETYPEID, VITEMNAME, DZHEKOU, NPFP, NJGLX, NCKSX, NCKXX, VPDTS, VPGTS, VZCTS, VYCTS, NCKZ, VNEGTS, VPOSTS, NHOSID, HISNITEMID, VITEMADDRESS)  VALUES (:EVITEMNAME, :HISNITEMTYPE, :LISUNIT, :CREATE_DATE, :CREATE_DEPT, :CREATE_DOCT, :LAST_DATE, :LAST_DOCT, :NITEMID, :NNODRUGITEMPRICE, :NNODRUGITEMUNIT, :VDEPARTID, :NISSTOP, :NISPACK, :VITEMDES, :PINYINMA, :WUBIMA, :NCHARGETYPEID, :VITEMNAME, :DZHEKOU, :NPFP, :NJGLX, :NCKSX, :NCKXX, :VPDTS, :VPGTS, :VZCTS, :VYCTS, :NCKZ, :VNEGTS, :VPOSTS, :NHOSID, :HISNITEMID, :VITEMADDRESS)";
					
			m_Params.AddParam("EVITEMNAME", "EVITEMNAME", DataRowVersion.Current, OracleType.NVarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("HISNITEMTYPE", "HISNITEMTYPE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("LISUNIT", "LISUNIT", DataRowVersion.Current, OracleType.NVarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATE_DATE", "CREATE_DATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATE_DEPT", "CREATE_DEPT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATE_DOCT", "CREATE_DOCT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("LAST_DATE", "LAST_DATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("LAST_DOCT", "LAST_DOCT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NITEMID", "NITEMID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("NNODRUGITEMPRICE", "NNODRUGITEMPRICE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NNODRUGITEMUNIT", "NNODRUGITEMUNIT", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPARTID", "VDEPARTID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NISSTOP", "NISSTOP", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NISPACK", "NISPACK", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEMDES", "VITEMDES", DataRowVersion.Current, OracleType.NVarChar, 200, ParameterDirection.Input, null);		
			m_Params.AddParam("PINYINMA", "PINYINMA", DataRowVersion.Current, OracleType.VarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("WUBIMA", "WUBIMA", DataRowVersion.Current, OracleType.VarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("NCHARGETYPEID", "NCHARGETYPEID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEMNAME", "VITEMNAME", DataRowVersion.Current, OracleType.NVarChar, 200, ParameterDirection.Input, null);		
			m_Params.AddParam("DZHEKOU", "DZHEKOU", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NPFP", "NPFP", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NJGLX", "NJGLX", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCKSX", "NCKSX", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCKXX", "NCKXX", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VPDTS", "VPDTS", DataRowVersion.Current, OracleType.NVarChar, 225, ParameterDirection.Input, null);		
			m_Params.AddParam("VPGTS", "VPGTS", DataRowVersion.Current, OracleType.NVarChar, 225, ParameterDirection.Input, null);		
			m_Params.AddParam("VZCTS", "VZCTS", DataRowVersion.Current, OracleType.NVarChar, 225, ParameterDirection.Input, null);		
			m_Params.AddParam("VYCTS", "VYCTS", DataRowVersion.Current, OracleType.NVarChar, 225, ParameterDirection.Input, null);		
			m_Params.AddParam("NCKZ", "NCKZ", DataRowVersion.Current, OracleType.NVarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VNEGTS", "VNEGTS", DataRowVersion.Current, OracleType.NVarChar, 225, ParameterDirection.Input, null);		
			m_Params.AddParam("VPOSTS", "VPOSTS", DataRowVersion.Current, OracleType.NVarChar, 225, ParameterDirection.Input, null);		
			m_Params.AddParam("NHOSID", "NHOSID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("HISNITEMID", "HISNITEMID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEMADDRESS", "VITEMADDRESS", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);
		}
				
		public System.String EVITEMNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["EVITEMNAME"].Value, "System.String");
			}
			set
			{
				m_Params["EVITEMNAME"].Value = value;
			}
		}
				
		public System.Decimal HISNITEMTYPE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["HISNITEMTYPE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["HISNITEMTYPE"].Value = value;
			}
		}
				
		public System.String LISUNIT
		{
			get
			{
				return (System.String)ConverValue(m_Params["LISUNIT"].Value, "System.String");
			}
			set
			{
				m_Params["LISUNIT"].Value = value;
			}
		}
				
		public System.DateTime CREATE_DATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["CREATE_DATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["CREATE_DATE"].Value = value;
			}
		}
				
		public System.String CREATE_DEPT
		{
			get
			{
				return (System.String)ConverValue(m_Params["CREATE_DEPT"].Value, "System.String");
			}
			set
			{
				m_Params["CREATE_DEPT"].Value = value;
			}
		}
				
		public System.String CREATE_DOCT
		{
			get
			{
				return (System.String)ConverValue(m_Params["CREATE_DOCT"].Value, "System.String");
			}
			set
			{
				m_Params["CREATE_DOCT"].Value = value;
			}
		}
				
		public System.DateTime LAST_DATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["LAST_DATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["LAST_DATE"].Value = value;
			}
		}
				
		public System.String LAST_DOCT
		{
			get
			{
				return (System.String)ConverValue(m_Params["LAST_DOCT"].Value, "System.String");
			}
			set
			{
				m_Params["LAST_DOCT"].Value = value;
			}
		}
				
		public System.String NITEMID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NITEMID"].Value, "System.String");
			}
			set
			{
				m_Params["NITEMID"].Value = value;
			}
		}
				
		public System.Decimal NNODRUGITEMPRICE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NNODRUGITEMPRICE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NNODRUGITEMPRICE"].Value = value;
			}
		}
				
		public System.Decimal NNODRUGITEMUNIT
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NNODRUGITEMUNIT"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NNODRUGITEMUNIT"].Value = value;
			}
		}
				
		public System.String VDEPARTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEPARTID"].Value, "System.String");
			}
			set
			{
				m_Params["VDEPARTID"].Value = value;
			}
		}
				
		public System.Decimal NISSTOP
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NISSTOP"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NISSTOP"].Value = value;
			}
		}
				
		public System.Decimal NISPACK
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NISPACK"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NISPACK"].Value = value;
			}
		}
				
		public System.String VITEMDES
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEMDES"].Value, "System.String");
			}
			set
			{
				m_Params["VITEMDES"].Value = value;
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
				
		public System.Decimal NCHARGETYPEID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCHARGETYPEID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCHARGETYPEID"].Value = value;
			}
		}
				
		public System.String VITEMNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEMNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VITEMNAME"].Value = value;
			}
		}
				
		public System.Decimal DZHEKOU
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["DZHEKOU"].Value, "System.Decimal");
			}
			set
			{
				m_Params["DZHEKOU"].Value = value;
			}
		}
				
		public System.Decimal NPFP
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPFP"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPFP"].Value = value;
			}
		}
				
		public System.Decimal NJGLX
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NJGLX"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NJGLX"].Value = value;
			}
		}
				
		public System.Decimal NCKSX
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCKSX"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCKSX"].Value = value;
			}
		}
				
		public System.Decimal NCKXX
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCKXX"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCKXX"].Value = value;
			}
		}
				
		public System.String VPDTS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPDTS"].Value, "System.String");
			}
			set
			{
				m_Params["VPDTS"].Value = value;
			}
		}
				
		public System.String VPGTS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPGTS"].Value, "System.String");
			}
			set
			{
				m_Params["VPGTS"].Value = value;
			}
		}
				
		public System.String VZCTS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VZCTS"].Value, "System.String");
			}
			set
			{
				m_Params["VZCTS"].Value = value;
			}
		}
				
		public System.String VYCTS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VYCTS"].Value, "System.String");
			}
			set
			{
				m_Params["VYCTS"].Value = value;
			}
		}
				
		public System.String NCKZ
		{
			get
			{
				return (System.String)ConverValue(m_Params["NCKZ"].Value, "System.String");
			}
			set
			{
				m_Params["NCKZ"].Value = value;
			}
		}
				
		public System.String VNEGTS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNEGTS"].Value, "System.String");
			}
			set
			{
				m_Params["VNEGTS"].Value = value;
			}
		}
				
		public System.String VPOSTS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPOSTS"].Value, "System.String");
			}
			set
			{
				m_Params["VPOSTS"].Value = value;
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
				
		public System.String HISNITEMID
		{
			get
			{
				return (System.String)ConverValue(m_Params["HISNITEMID"].Value, "System.String");
			}
			set
			{
				m_Params["HISNITEMID"].Value = value;
			}
		}
				
		public System.String VITEMADDRESS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEMADDRESS"].Value, "System.String");
			}
			set
			{
				m_Params["VITEMADDRESS"].Value = value;
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
	} // SS_InsertTJ_TJ_DICNODRUGITEM
	#endregion
	
	#region SS_TJ_DICNODRUGITEM_DeleteTJ_TJ_DICNODRUGITEM
	/// 
	/// 对于DeleteTJ_TJ_DICNODRUGITEM的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TJ_DICNODRUGITEM_DeleteTJ_TJ_DICNODRUGITEM : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TJ_DICNODRUGITEM_DeleteTJ_TJ_DICNODRUGITEM() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM TJ.TJ_DICNODRUGITEM  WHERE  NITEMID = :NITEMID";
					
			m_Params.AddParam("NITEMID", "NITEMID", DataRowVersion.Original, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.String NITEMID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NITEMID"].Value, "System.String");
			}
			set
			{
				m_Params["NITEMID"].Value = value;
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
	} // SS_DeleteTJ_TJ_DICNODRUGITEM
	#endregion
	
	#region SS_TJ_DICNODRUGITEM_UpdateTJ_TJ_DICNODRUGITEM
	/// 
	/// 对于UpdateTJ_TJ_DICNODRUGITEM的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TJ_DICNODRUGITEM_UpdateTJ_TJ_DICNODRUGITEM : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TJ_DICNODRUGITEM_UpdateTJ_TJ_DICNODRUGITEM() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE TJ.TJ_DICNODRUGITEM  SET  EVITEMNAME = :EVITEMNAME, HISNITEMTYPE = :HISNITEMTYPE, LISUNIT = :LISUNIT, CREATE_DATE = :CREATE_DATE, CREATE_DEPT = :CREATE_DEPT, CREATE_DOCT = :CREATE_DOCT, LAST_DATE = :LAST_DATE, LAST_DOCT = :LAST_DOCT, NITEMID = :NITEMID, NNODRUGITEMPRICE = :NNODRUGITEMPRICE, NNODRUGITEMUNIT = :NNODRUGITEMUNIT, VDEPARTID = :VDEPARTID, NISSTOP = :NISSTOP, NISPACK = :NISPACK, VITEMDES = :VITEMDES, PINYINMA = :PINYINMA, WUBIMA = :WUBIMA, NCHARGETYPEID = :NCHARGETYPEID, VITEMNAME = :VITEMNAME, DZHEKOU = :DZHEKOU, NPFP = :NPFP, NJGLX = :NJGLX, NCKSX = :NCKSX, NCKXX = :NCKXX, VPDTS = :VPDTS, VPGTS = :VPGTS, VZCTS = :VZCTS, VYCTS = :VYCTS, NCKZ = :NCKZ, VNEGTS = :VNEGTS, VPOSTS = :VPOSTS, NHOSID = :NHOSID, HISNITEMID = :HISNITEMID, VITEMADDRESS = :VITEMADDRESS   WHERE  NITEMID = :OLDNITEMID";
					
			m_Params.AddParam("EVITEMNAME", "EVITEMNAME", DataRowVersion.Current, OracleType.NVarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("HISNITEMTYPE", "HISNITEMTYPE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("LISUNIT", "LISUNIT", DataRowVersion.Current, OracleType.NVarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATE_DATE", "CREATE_DATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATE_DEPT", "CREATE_DEPT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("CREATE_DOCT", "CREATE_DOCT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("LAST_DATE", "LAST_DATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("LAST_DOCT", "LAST_DOCT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NITEMID", "NITEMID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);		
			m_Params.AddParam("NNODRUGITEMPRICE", "NNODRUGITEMPRICE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NNODRUGITEMUNIT", "NNODRUGITEMUNIT", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPARTID", "VDEPARTID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NISSTOP", "NISSTOP", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NISPACK", "NISPACK", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEMDES", "VITEMDES", DataRowVersion.Current, OracleType.NVarChar, 200, ParameterDirection.Input, null);		
			m_Params.AddParam("PINYINMA", "PINYINMA", DataRowVersion.Current, OracleType.VarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("WUBIMA", "WUBIMA", DataRowVersion.Current, OracleType.VarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("NCHARGETYPEID", "NCHARGETYPEID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEMNAME", "VITEMNAME", DataRowVersion.Current, OracleType.NVarChar, 200, ParameterDirection.Input, null);		
			m_Params.AddParam("DZHEKOU", "DZHEKOU", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NPFP", "NPFP", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NJGLX", "NJGLX", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCKSX", "NCKSX", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCKXX", "NCKXX", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VPDTS", "VPDTS", DataRowVersion.Current, OracleType.NVarChar, 225, ParameterDirection.Input, null);		
			m_Params.AddParam("VPGTS", "VPGTS", DataRowVersion.Current, OracleType.NVarChar, 225, ParameterDirection.Input, null);		
			m_Params.AddParam("VZCTS", "VZCTS", DataRowVersion.Current, OracleType.NVarChar, 225, ParameterDirection.Input, null);		
			m_Params.AddParam("VYCTS", "VYCTS", DataRowVersion.Current, OracleType.NVarChar, 225, ParameterDirection.Input, null);		
			m_Params.AddParam("NCKZ", "NCKZ", DataRowVersion.Current, OracleType.NVarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VNEGTS", "VNEGTS", DataRowVersion.Current, OracleType.NVarChar, 225, ParameterDirection.Input, null);		
			m_Params.AddParam("VPOSTS", "VPOSTS", DataRowVersion.Current, OracleType.NVarChar, 225, ParameterDirection.Input, null);		
			m_Params.AddParam("NHOSID", "NHOSID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("HISNITEMID", "HISNITEMID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEMADDRESS", "VITEMADDRESS", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDNITEMID", "NITEMID", DataRowVersion.Original, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.String EVITEMNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["EVITEMNAME"].Value, "System.String");
			}
			set
			{
				m_Params["EVITEMNAME"].Value = value;
			}
		}
				
		public System.Decimal HISNITEMTYPE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["HISNITEMTYPE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["HISNITEMTYPE"].Value = value;
			}
		}
				
		public System.String LISUNIT
		{
			get
			{
				return (System.String)ConverValue(m_Params["LISUNIT"].Value, "System.String");
			}
			set
			{
				m_Params["LISUNIT"].Value = value;
			}
		}
				
		public System.DateTime CREATE_DATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["CREATE_DATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["CREATE_DATE"].Value = value;
			}
		}
				
		public System.String CREATE_DEPT
		{
			get
			{
				return (System.String)ConverValue(m_Params["CREATE_DEPT"].Value, "System.String");
			}
			set
			{
				m_Params["CREATE_DEPT"].Value = value;
			}
		}
				
		public System.String CREATE_DOCT
		{
			get
			{
				return (System.String)ConverValue(m_Params["CREATE_DOCT"].Value, "System.String");
			}
			set
			{
				m_Params["CREATE_DOCT"].Value = value;
			}
		}
				
		public System.DateTime LAST_DATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["LAST_DATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["LAST_DATE"].Value = value;
			}
		}
				
		public System.String LAST_DOCT
		{
			get
			{
				return (System.String)ConverValue(m_Params["LAST_DOCT"].Value, "System.String");
			}
			set
			{
				m_Params["LAST_DOCT"].Value = value;
			}
		}
				
		public System.String NITEMID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NITEMID"].Value, "System.String");
			}
			set
			{
				m_Params["NITEMID"].Value = value;
			}
		}
				
		public System.Decimal NNODRUGITEMPRICE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NNODRUGITEMPRICE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NNODRUGITEMPRICE"].Value = value;
			}
		}
				
		public System.Decimal NNODRUGITEMUNIT
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NNODRUGITEMUNIT"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NNODRUGITEMUNIT"].Value = value;
			}
		}
				
		public System.String VDEPARTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEPARTID"].Value, "System.String");
			}
			set
			{
				m_Params["VDEPARTID"].Value = value;
			}
		}
				
		public System.Decimal NISSTOP
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NISSTOP"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NISSTOP"].Value = value;
			}
		}
				
		public System.Decimal NISPACK
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NISPACK"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NISPACK"].Value = value;
			}
		}
				
		public System.String VITEMDES
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEMDES"].Value, "System.String");
			}
			set
			{
				m_Params["VITEMDES"].Value = value;
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
				
		public System.Decimal NCHARGETYPEID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCHARGETYPEID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCHARGETYPEID"].Value = value;
			}
		}
				
		public System.String VITEMNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEMNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VITEMNAME"].Value = value;
			}
		}
				
		public System.Decimal DZHEKOU
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["DZHEKOU"].Value, "System.Decimal");
			}
			set
			{
				m_Params["DZHEKOU"].Value = value;
			}
		}
				
		public System.Decimal NPFP
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPFP"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPFP"].Value = value;
			}
		}
				
		public System.Decimal NJGLX
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NJGLX"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NJGLX"].Value = value;
			}
		}
				
		public System.Decimal NCKSX
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCKSX"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCKSX"].Value = value;
			}
		}
				
		public System.Decimal NCKXX
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCKXX"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCKXX"].Value = value;
			}
		}
				
		public System.String VPDTS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPDTS"].Value, "System.String");
			}
			set
			{
				m_Params["VPDTS"].Value = value;
			}
		}
				
		public System.String VPGTS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPGTS"].Value, "System.String");
			}
			set
			{
				m_Params["VPGTS"].Value = value;
			}
		}
				
		public System.String VZCTS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VZCTS"].Value, "System.String");
			}
			set
			{
				m_Params["VZCTS"].Value = value;
			}
		}
				
		public System.String VYCTS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VYCTS"].Value, "System.String");
			}
			set
			{
				m_Params["VYCTS"].Value = value;
			}
		}
				
		public System.String NCKZ
		{
			get
			{
				return (System.String)ConverValue(m_Params["NCKZ"].Value, "System.String");
			}
			set
			{
				m_Params["NCKZ"].Value = value;
			}
		}
				
		public System.String VNEGTS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNEGTS"].Value, "System.String");
			}
			set
			{
				m_Params["VNEGTS"].Value = value;
			}
		}
				
		public System.String VPOSTS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPOSTS"].Value, "System.String");
			}
			set
			{
				m_Params["VPOSTS"].Value = value;
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
				
		public System.String HISNITEMID
		{
			get
			{
				return (System.String)ConverValue(m_Params["HISNITEMID"].Value, "System.String");
			}
			set
			{
				m_Params["HISNITEMID"].Value = value;
			}
		}
				
		public System.String VITEMADDRESS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEMADDRESS"].Value, "System.String");
			}
			set
			{
				m_Params["VITEMADDRESS"].Value = value;
			}
		}
				
		public System.String OLDNITEMID
		{
			get
			{
				return (System.String)ConverValue(m_Params["OLDNITEMID"].Value, "System.String");
			}
			set
			{
				m_Params["OLDNITEMID"].Value = value;
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
	} // SS_UpdateTJ_TJ_DICNODRUGITEM
	#endregion
	
	#region SS_TJ_DICNODRUGITEM_SelectByIDTJ_TJ_DICNODRUGITEM
	/// 
	/// 对于SelectByIDTJ_TJ_DICNODRUGITEM的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TJ_DICNODRUGITEM_SelectByIDTJ_TJ_DICNODRUGITEM : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TJ_DICNODRUGITEM_SelectByIDTJ_TJ_DICNODRUGITEM() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT EVITEMNAME, HISNITEMTYPE, LISUNIT, CREATE_DATE, CREATE_DEPT, CREATE_DOCT, LAST_DATE, LAST_DOCT, NITEMID, NNODRUGITEMPRICE, NNODRUGITEMUNIT, VDEPARTID, NISSTOP, NISPACK, VITEMDES, PINYINMA, WUBIMA, NCHARGETYPEID, VITEMNAME, DZHEKOU, NPFP, NJGLX, NCKSX, NCKXX, VPDTS, VPGTS, VZCTS, VYCTS, NCKZ, VNEGTS, VPOSTS, NHOSID, HISNITEMID, VITEMADDRESS  FROM TJ.TJ_DICNODRUGITEM  WHERE  NITEMID = :NITEMID";
					
			m_Params.AddParam("NITEMID", "NITEMID", DataRowVersion.Current, OracleType.VarChar, 36, ParameterDirection.Input, null);
		}
				
		public System.String NITEMID
		{
			get
			{
				return (System.String)ConverValue(m_Params["NITEMID"].Value, "System.String");
			}
			set
			{
				m_Params["NITEMID"].Value = value;
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
	} // SS_SelectByIDTJ_TJ_DICNODRUGITEM
	#endregion
	
	#region SS_TJ_DICNODRUGITEM_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_TJ_DICNODRUGITEM_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_TJ_DICNODRUGITEM_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "select * from tj.TJ_DICNODRUGITEM where 1=1";
			
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
	