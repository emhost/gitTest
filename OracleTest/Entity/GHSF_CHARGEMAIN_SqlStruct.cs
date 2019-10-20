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
	
	#region SS_GHSF_CHARGEMAIN_InsertGHSF_GHSF_CHARGEMAIN
	/// 
	/// 对于InsertGHSF_GHSF_CHARGEMAIN的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_CHARGEMAIN_InsertGHSF_GHSF_CHARGEMAIN : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_CHARGEMAIN_InsertGHSF_GHSF_CHARGEMAIN() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO GHSF.GHSF_CHARGEMAIN  (VPRESC_TYPE, DPRESC_DATE, VDEPT_CODE, VACCTID, BBAIYAO, NHOSID, VRCPTID, VPATIENTID, VREGIST_ID, VPRESC_ID, VDIAGNOSE, NCOUNT, VUSERAGE, VDOCTOR_ID, VOPERATORID, VREFUNDEDRCPTNO, VACCTNO, VPRINTEDOPERATORID, VPRINTEDDATE, VPRINTEDRCPTNO, VINVOICENO, NSETTLE, VREMARKS, DCHARGE_DATE, VDEPTID, NSTATUS)  VALUES (:VPRESC_TYPE, :DPRESC_DATE, :VDEPT_CODE, :VACCTID, :BBAIYAO, :NHOSID, :VRCPTID, :VPATIENTID, :VREGIST_ID, :VPRESC_ID, :VDIAGNOSE, :NCOUNT, :VUSERAGE, :VDOCTOR_ID, :VOPERATORID, :VREFUNDEDRCPTNO, :VACCTNO, :VPRINTEDOPERATORID, :VPRINTEDDATE, :VPRINTEDRCPTNO, :VINVOICENO, :NSETTLE, :VREMARKS, :DCHARGE_DATE, :VDEPTID, :NSTATUS)";
					
			m_Params.AddParam("VPRESC_TYPE", "VPRESC_TYPE", DataRowVersion.Current, OracleType.VarChar, 12, ParameterDirection.Input, null);		
			m_Params.AddParam("DPRESC_DATE", "DPRESC_DATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPT_CODE", "VDEPT_CODE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VACCTID", "VACCTID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("BBAIYAO", "BBAIYAO", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NHOSID", "NHOSID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VRCPTID", "VRCPTID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VPATIENTID", "VPATIENTID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VREGIST_ID", "VREGIST_ID", DataRowVersion.Current, OracleType.NVarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRESC_ID", "VPRESC_ID", DataRowVersion.Current, OracleType.VarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("VDIAGNOSE", "VDIAGNOSE", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NCOUNT", "NCOUNT", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VUSERAGE", "VUSERAGE", DataRowVersion.Current, OracleType.NVarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VDOCTOR_ID", "VDOCTOR_ID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VOPERATORID", "VOPERATORID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VREFUNDEDRCPTNO", "VREFUNDEDRCPTNO", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VACCTNO", "VACCTNO", DataRowVersion.Current, OracleType.VarChar, 6, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRINTEDOPERATORID", "VPRINTEDOPERATORID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRINTEDDATE", "VPRINTEDDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRINTEDRCPTNO", "VPRINTEDRCPTNO", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VINVOICENO", "VINVOICENO", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NSETTLE", "NSETTLE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VREMARKS", "VREMARKS", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("DCHARGE_DATE", "DCHARGE_DATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPTID", "VDEPTID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NSTATUS", "NSTATUS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);
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
				
		public System.DateTime DPRESC_DATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DPRESC_DATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DPRESC_DATE"].Value = value;
			}
		}
				
		public System.String VDEPT_CODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEPT_CODE"].Value, "System.String");
			}
			set
			{
				m_Params["VDEPT_CODE"].Value = value;
			}
		}
				
		public System.String VACCTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VACCTID"].Value, "System.String");
			}
			set
			{
				m_Params["VACCTID"].Value = value;
			}
		}
				
		public System.Decimal BBAIYAO
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["BBAIYAO"].Value, "System.Decimal");
			}
			set
			{
				m_Params["BBAIYAO"].Value = value;
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
				
		public System.String VRCPTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRCPTID"].Value, "System.String");
			}
			set
			{
				m_Params["VRCPTID"].Value = value;
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
				
		public System.String VREGIST_ID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VREGIST_ID"].Value, "System.String");
			}
			set
			{
				m_Params["VREGIST_ID"].Value = value;
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
				
		public System.String VDIAGNOSE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDIAGNOSE"].Value, "System.String");
			}
			set
			{
				m_Params["VDIAGNOSE"].Value = value;
			}
		}
				
		public System.Decimal NCOUNT
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCOUNT"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCOUNT"].Value = value;
			}
		}
				
		public System.String VUSERAGE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VUSERAGE"].Value, "System.String");
			}
			set
			{
				m_Params["VUSERAGE"].Value = value;
			}
		}
				
		public System.String VDOCTOR_ID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDOCTOR_ID"].Value, "System.String");
			}
			set
			{
				m_Params["VDOCTOR_ID"].Value = value;
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
				
		public System.String VREFUNDEDRCPTNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VREFUNDEDRCPTNO"].Value, "System.String");
			}
			set
			{
				m_Params["VREFUNDEDRCPTNO"].Value = value;
			}
		}
				
		public System.String VACCTNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VACCTNO"].Value, "System.String");
			}
			set
			{
				m_Params["VACCTNO"].Value = value;
			}
		}
				
		public System.String VPRINTEDOPERATORID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPRINTEDOPERATORID"].Value, "System.String");
			}
			set
			{
				m_Params["VPRINTEDOPERATORID"].Value = value;
			}
		}
				
		public System.DateTime VPRINTEDDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["VPRINTEDDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["VPRINTEDDATE"].Value = value;
			}
		}
				
		public System.String VPRINTEDRCPTNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPRINTEDRCPTNO"].Value, "System.String");
			}
			set
			{
				m_Params["VPRINTEDRCPTNO"].Value = value;
			}
		}
				
		public System.String VINVOICENO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VINVOICENO"].Value, "System.String");
			}
			set
			{
				m_Params["VINVOICENO"].Value = value;
			}
		}
				
		public System.Decimal NSETTLE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSETTLE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSETTLE"].Value = value;
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
				
		public System.DateTime DCHARGE_DATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DCHARGE_DATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DCHARGE_DATE"].Value = value;
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
				
		public System.Decimal NSTATUS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSTATUS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSTATUS"].Value = value;
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
	} // SS_InsertGHSF_GHSF_CHARGEMAIN
	#endregion
	
	#region SS_GHSF_CHARGEMAIN_DeleteGHSF_GHSF_CHARGEMAIN
	/// 
	/// 对于DeleteGHSF_GHSF_CHARGEMAIN的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_CHARGEMAIN_DeleteGHSF_GHSF_CHARGEMAIN : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_CHARGEMAIN_DeleteGHSF_GHSF_CHARGEMAIN() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM GHSF.GHSF_CHARGEMAIN  WHERE  VRCPTID = :VRCPTID";
					
			m_Params.AddParam("VRCPTID", "VRCPTID", DataRowVersion.Original, OracleType.VarChar, 20, ParameterDirection.Input, null);
		}
				
		public System.String VRCPTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRCPTID"].Value, "System.String");
			}
			set
			{
				m_Params["VRCPTID"].Value = value;
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
	} // SS_DeleteGHSF_GHSF_CHARGEMAIN
	#endregion
	
	#region SS_GHSF_CHARGEMAIN_UpdateGHSF_GHSF_CHARGEMAIN
	/// 
	/// 对于UpdateGHSF_GHSF_CHARGEMAIN的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_CHARGEMAIN_UpdateGHSF_GHSF_CHARGEMAIN : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_CHARGEMAIN_UpdateGHSF_GHSF_CHARGEMAIN() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE GHSF.GHSF_CHARGEMAIN  SET  VPRESC_TYPE = :VPRESC_TYPE, DPRESC_DATE = :DPRESC_DATE, VDEPT_CODE = :VDEPT_CODE, VACCTID = :VACCTID, BBAIYAO = :BBAIYAO, NHOSID = :NHOSID, VRCPTID = :VRCPTID, VPATIENTID = :VPATIENTID, VREGIST_ID = :VREGIST_ID, VPRESC_ID = :VPRESC_ID, VDIAGNOSE = :VDIAGNOSE, NCOUNT = :NCOUNT, VUSERAGE = :VUSERAGE, VDOCTOR_ID = :VDOCTOR_ID, VOPERATORID = :VOPERATORID, VREFUNDEDRCPTNO = :VREFUNDEDRCPTNO, VACCTNO = :VACCTNO, VPRINTEDOPERATORID = :VPRINTEDOPERATORID, VPRINTEDDATE = :VPRINTEDDATE, VPRINTEDRCPTNO = :VPRINTEDRCPTNO, VINVOICENO = :VINVOICENO, NSETTLE = :NSETTLE, VREMARKS = :VREMARKS, DCHARGE_DATE = :DCHARGE_DATE, VDEPTID = :VDEPTID, NSTATUS = :NSTATUS   WHERE  VRCPTID = :OLDVRCPTID";
					
			m_Params.AddParam("VPRESC_TYPE", "VPRESC_TYPE", DataRowVersion.Current, OracleType.VarChar, 12, ParameterDirection.Input, null);		
			m_Params.AddParam("DPRESC_DATE", "DPRESC_DATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPT_CODE", "VDEPT_CODE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VACCTID", "VACCTID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("BBAIYAO", "BBAIYAO", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NHOSID", "NHOSID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VRCPTID", "VRCPTID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VPATIENTID", "VPATIENTID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VREGIST_ID", "VREGIST_ID", DataRowVersion.Current, OracleType.NVarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRESC_ID", "VPRESC_ID", DataRowVersion.Current, OracleType.VarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("VDIAGNOSE", "VDIAGNOSE", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NCOUNT", "NCOUNT", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VUSERAGE", "VUSERAGE", DataRowVersion.Current, OracleType.NVarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VDOCTOR_ID", "VDOCTOR_ID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VOPERATORID", "VOPERATORID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VREFUNDEDRCPTNO", "VREFUNDEDRCPTNO", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VACCTNO", "VACCTNO", DataRowVersion.Current, OracleType.VarChar, 6, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRINTEDOPERATORID", "VPRINTEDOPERATORID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRINTEDDATE", "VPRINTEDDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRINTEDRCPTNO", "VPRINTEDRCPTNO", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VINVOICENO", "VINVOICENO", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NSETTLE", "NSETTLE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VREMARKS", "VREMARKS", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("DCHARGE_DATE", "DCHARGE_DATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPTID", "VDEPTID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NSTATUS", "NSTATUS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDVRCPTID", "VRCPTID", DataRowVersion.Original, OracleType.VarChar, 20, ParameterDirection.Input, null);
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
				
		public System.DateTime DPRESC_DATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DPRESC_DATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DPRESC_DATE"].Value = value;
			}
		}
				
		public System.String VDEPT_CODE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEPT_CODE"].Value, "System.String");
			}
			set
			{
				m_Params["VDEPT_CODE"].Value = value;
			}
		}
				
		public System.String VACCTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VACCTID"].Value, "System.String");
			}
			set
			{
				m_Params["VACCTID"].Value = value;
			}
		}
				
		public System.Decimal BBAIYAO
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["BBAIYAO"].Value, "System.Decimal");
			}
			set
			{
				m_Params["BBAIYAO"].Value = value;
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
				
		public System.String VRCPTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRCPTID"].Value, "System.String");
			}
			set
			{
				m_Params["VRCPTID"].Value = value;
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
				
		public System.String VREGIST_ID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VREGIST_ID"].Value, "System.String");
			}
			set
			{
				m_Params["VREGIST_ID"].Value = value;
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
				
		public System.String VDIAGNOSE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDIAGNOSE"].Value, "System.String");
			}
			set
			{
				m_Params["VDIAGNOSE"].Value = value;
			}
		}
				
		public System.Decimal NCOUNT
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCOUNT"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCOUNT"].Value = value;
			}
		}
				
		public System.String VUSERAGE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VUSERAGE"].Value, "System.String");
			}
			set
			{
				m_Params["VUSERAGE"].Value = value;
			}
		}
				
		public System.String VDOCTOR_ID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDOCTOR_ID"].Value, "System.String");
			}
			set
			{
				m_Params["VDOCTOR_ID"].Value = value;
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
				
		public System.String VREFUNDEDRCPTNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VREFUNDEDRCPTNO"].Value, "System.String");
			}
			set
			{
				m_Params["VREFUNDEDRCPTNO"].Value = value;
			}
		}
				
		public System.String VACCTNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VACCTNO"].Value, "System.String");
			}
			set
			{
				m_Params["VACCTNO"].Value = value;
			}
		}
				
		public System.String VPRINTEDOPERATORID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPRINTEDOPERATORID"].Value, "System.String");
			}
			set
			{
				m_Params["VPRINTEDOPERATORID"].Value = value;
			}
		}
				
		public System.DateTime VPRINTEDDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["VPRINTEDDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["VPRINTEDDATE"].Value = value;
			}
		}
				
		public System.String VPRINTEDRCPTNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPRINTEDRCPTNO"].Value, "System.String");
			}
			set
			{
				m_Params["VPRINTEDRCPTNO"].Value = value;
			}
		}
				
		public System.String VINVOICENO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VINVOICENO"].Value, "System.String");
			}
			set
			{
				m_Params["VINVOICENO"].Value = value;
			}
		}
				
		public System.Decimal NSETTLE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSETTLE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSETTLE"].Value = value;
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
				
		public System.DateTime DCHARGE_DATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DCHARGE_DATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DCHARGE_DATE"].Value = value;
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
				
		public System.Decimal NSTATUS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSTATUS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSTATUS"].Value = value;
			}
		}
				
		public System.String OLDVRCPTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["OLDVRCPTID"].Value, "System.String");
			}
			set
			{
				m_Params["OLDVRCPTID"].Value = value;
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
	} // SS_UpdateGHSF_GHSF_CHARGEMAIN
	#endregion
	
	#region SS_GHSF_CHARGEMAIN_SelectByIDGHSF_GHSF_CHARGEMAIN
	/// 
	/// 对于SelectByIDGHSF_GHSF_CHARGEMAIN的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_CHARGEMAIN_SelectByIDGHSF_GHSF_CHARGEMAIN : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_CHARGEMAIN_SelectByIDGHSF_GHSF_CHARGEMAIN() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT VPRESC_TYPE, DPRESC_DATE, VDEPT_CODE, VACCTID, BBAIYAO, NHOSID, VRCPTID, VPATIENTID, VREGIST_ID, VPRESC_ID, VDIAGNOSE, NCOUNT, VUSERAGE, VDOCTOR_ID, VOPERATORID, VREFUNDEDRCPTNO, VACCTNO, VPRINTEDOPERATORID, VPRINTEDDATE, VPRINTEDRCPTNO, VINVOICENO, NSETTLE, VREMARKS, DCHARGE_DATE, VDEPTID, NSTATUS  FROM GHSF.GHSF_CHARGEMAIN  WHERE  VRCPTID = :VRCPTID";
					
			m_Params.AddParam("VRCPTID", "VRCPTID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);
		}
				
		public System.String VRCPTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRCPTID"].Value, "System.String");
			}
			set
			{
				m_Params["VRCPTID"].Value = value;
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
	} // SS_SelectByIDGHSF_GHSF_CHARGEMAIN
	#endregion
	
	#region SS_GHSF_CHARGEMAIN_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_CHARGEMAIN_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_CHARGEMAIN_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT * FROM GHSF.GHSF_CHARGEMAIN  WHERE 1=1";
			
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
	