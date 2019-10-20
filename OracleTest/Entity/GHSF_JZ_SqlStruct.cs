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
	
	#region SS_GHSF_JZ_InsertGHSF_GHSF_JZ
	/// 
	/// 对于InsertGHSF_GHSF_JZ的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_JZ_InsertGHSF_GHSF_JZ : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_JZ_InsertGHSF_GHSF_JZ() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO GHSF.GHSF_JZ  (VACCOUNTSID, VRCPTID, VPRESCNO, VITEMID, VITEMNAME, NPRICE, NCOSTS, NACCOUNTSCOSTS, NCHARGEFLAG, DMEDICINEDATE, VOPERATORID, NSETTLE, DSETTLEDATE, VSETTLEID, VCARDNO, NACCOUNT, VINVOICENO, NFLAG, VVISITDEPT, VREMARKS, VPATIENTID, NACCT_MODE, VCOUNTDEPT, VDOCTOR_ID, VACCTID, NACCOUNTTF, VACCOUNTSIDTF, NOPHZID, VCLINICNO, NHOSID)  VALUES (:VACCOUNTSID, :VRCPTID, :VPRESCNO, :VITEMID, :VITEMNAME, :NPRICE, :NCOSTS, :NACCOUNTSCOSTS, :NCHARGEFLAG, :DMEDICINEDATE, :VOPERATORID, :NSETTLE, :DSETTLEDATE, :VSETTLEID, :VCARDNO, :NACCOUNT, :VINVOICENO, :NFLAG, :VVISITDEPT, :VREMARKS, :VPATIENTID, :NACCT_MODE, :VCOUNTDEPT, :VDOCTOR_ID, :VACCTID, :NACCOUNTTF, :VACCOUNTSIDTF, :NOPHZID, :VCLINICNO, :NHOSID)";
					
			m_Params.AddParam("VACCOUNTSID", "VACCOUNTSID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VRCPTID", "VRCPTID", DataRowVersion.Current, OracleType.VarChar, 2, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRESCNO", "VPRESCNO", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEMID", "VITEMID", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEMNAME", "VITEMNAME", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NPRICE", "NPRICE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCOSTS", "NCOSTS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NACCOUNTSCOSTS", "NACCOUNTSCOSTS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCHARGEFLAG", "NCHARGEFLAG", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DMEDICINEDATE", "DMEDICINEDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VOPERATORID", "VOPERATORID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NSETTLE", "NSETTLE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DSETTLEDATE", "DSETTLEDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VSETTLEID", "VSETTLEID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VCARDNO", "VCARDNO", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NACCOUNT", "NACCOUNT", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VINVOICENO", "VINVOICENO", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NFLAG", "NFLAG", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VVISITDEPT", "VVISITDEPT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VREMARKS", "VREMARKS", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VPATIENTID", "VPATIENTID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NACCT_MODE", "NACCT_MODE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VCOUNTDEPT", "VCOUNTDEPT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VDOCTOR_ID", "VDOCTOR_ID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VACCTID", "VACCTID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NACCOUNTTF", "NACCOUNTTF", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VACCOUNTSIDTF", "VACCOUNTSIDTF", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NOPHZID", "NOPHZID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VCLINICNO", "VCLINICNO", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NHOSID", "NHOSID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);
		}
				
		public System.String VACCOUNTSID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VACCOUNTSID"].Value, "System.String");
			}
			set
			{
				m_Params["VACCOUNTSID"].Value = value;
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
				
		public System.String VPRESCNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPRESCNO"].Value, "System.String");
			}
			set
			{
				m_Params["VPRESCNO"].Value = value;
			}
		}
				
		public System.String VITEMID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEMID"].Value, "System.String");
			}
			set
			{
				m_Params["VITEMID"].Value = value;
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
				
		public System.Decimal NCOSTS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCOSTS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCOSTS"].Value = value;
			}
		}
				
		public System.Decimal NACCOUNTSCOSTS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NACCOUNTSCOSTS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NACCOUNTSCOSTS"].Value = value;
			}
		}
				
		public System.Decimal NCHARGEFLAG
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCHARGEFLAG"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCHARGEFLAG"].Value = value;
			}
		}
				
		public System.DateTime DMEDICINEDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DMEDICINEDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DMEDICINEDATE"].Value = value;
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
				
		public System.DateTime DSETTLEDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DSETTLEDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DSETTLEDATE"].Value = value;
			}
		}
				
		public System.String VSETTLEID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSETTLEID"].Value, "System.String");
			}
			set
			{
				m_Params["VSETTLEID"].Value = value;
			}
		}
				
		public System.String VCARDNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VCARDNO"].Value, "System.String");
			}
			set
			{
				m_Params["VCARDNO"].Value = value;
			}
		}
				
		public System.Decimal NACCOUNT
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NACCOUNT"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NACCOUNT"].Value = value;
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
				
		public System.String NFLAG
		{
			get
			{
				return (System.String)ConverValue(m_Params["NFLAG"].Value, "System.String");
			}
			set
			{
				m_Params["NFLAG"].Value = value;
			}
		}
				
		public System.String VVISITDEPT
		{
			get
			{
				return (System.String)ConverValue(m_Params["VVISITDEPT"].Value, "System.String");
			}
			set
			{
				m_Params["VVISITDEPT"].Value = value;
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
				
		public System.Decimal NACCT_MODE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NACCT_MODE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NACCT_MODE"].Value = value;
			}
		}
				
		public System.String VCOUNTDEPT
		{
			get
			{
				return (System.String)ConverValue(m_Params["VCOUNTDEPT"].Value, "System.String");
			}
			set
			{
				m_Params["VCOUNTDEPT"].Value = value;
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
				
		public System.Decimal NACCOUNTTF
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NACCOUNTTF"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NACCOUNTTF"].Value = value;
			}
		}
				
		public System.String VACCOUNTSIDTF
		{
			get
			{
				return (System.String)ConverValue(m_Params["VACCOUNTSIDTF"].Value, "System.String");
			}
			set
			{
				m_Params["VACCOUNTSIDTF"].Value = value;
			}
		}
				
		public System.Decimal NOPHZID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NOPHZID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NOPHZID"].Value = value;
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
	} // SS_InsertGHSF_GHSF_JZ
	#endregion
	
	#region SS_GHSF_JZ_DeleteGHSF_GHSF_JZ
	/// 
	/// 对于DeleteGHSF_GHSF_JZ的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_JZ_DeleteGHSF_GHSF_JZ : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_JZ_DeleteGHSF_GHSF_JZ() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM GHSF.GHSF_JZ  WHERE  VACCOUNTSID = :VACCOUNTSID";
					
			m_Params.AddParam("VACCOUNTSID", "VACCOUNTSID", DataRowVersion.Original, OracleType.VarChar, 10, ParameterDirection.Input, null);
		}
				
		public System.String VACCOUNTSID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VACCOUNTSID"].Value, "System.String");
			}
			set
			{
				m_Params["VACCOUNTSID"].Value = value;
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
	} // SS_DeleteGHSF_GHSF_JZ
	#endregion
	
	#region SS_GHSF_JZ_UpdateGHSF_GHSF_JZ
	/// 
	/// 对于UpdateGHSF_GHSF_JZ的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_JZ_UpdateGHSF_GHSF_JZ : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_JZ_UpdateGHSF_GHSF_JZ() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE GHSF.GHSF_JZ  SET  VACCOUNTSID = :VACCOUNTSID, VRCPTID = :VRCPTID, VPRESCNO = :VPRESCNO, VITEMID = :VITEMID, VITEMNAME = :VITEMNAME, NPRICE = :NPRICE, NCOSTS = :NCOSTS, NACCOUNTSCOSTS = :NACCOUNTSCOSTS, NCHARGEFLAG = :NCHARGEFLAG, DMEDICINEDATE = :DMEDICINEDATE, VOPERATORID = :VOPERATORID, NSETTLE = :NSETTLE, DSETTLEDATE = :DSETTLEDATE, VSETTLEID = :VSETTLEID, VCARDNO = :VCARDNO, NACCOUNT = :NACCOUNT, VINVOICENO = :VINVOICENO, NFLAG = :NFLAG, VVISITDEPT = :VVISITDEPT, VREMARKS = :VREMARKS, VPATIENTID = :VPATIENTID, NACCT_MODE = :NACCT_MODE, VCOUNTDEPT = :VCOUNTDEPT, VDOCTOR_ID = :VDOCTOR_ID, VACCTID = :VACCTID, NACCOUNTTF = :NACCOUNTTF, VACCOUNTSIDTF = :VACCOUNTSIDTF, NOPHZID = :NOPHZID, VCLINICNO = :VCLINICNO, NHOSID = :NHOSID   WHERE  VACCOUNTSID = :OLDVACCOUNTSID";
					
			m_Params.AddParam("VACCOUNTSID", "VACCOUNTSID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VRCPTID", "VRCPTID", DataRowVersion.Current, OracleType.VarChar, 2, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRESCNO", "VPRESCNO", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEMID", "VITEMID", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VITEMNAME", "VITEMNAME", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NPRICE", "NPRICE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCOSTS", "NCOSTS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NACCOUNTSCOSTS", "NACCOUNTSCOSTS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCHARGEFLAG", "NCHARGEFLAG", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DMEDICINEDATE", "DMEDICINEDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VOPERATORID", "VOPERATORID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NSETTLE", "NSETTLE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DSETTLEDATE", "DSETTLEDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VSETTLEID", "VSETTLEID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VCARDNO", "VCARDNO", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NACCOUNT", "NACCOUNT", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VINVOICENO", "VINVOICENO", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NFLAG", "NFLAG", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VVISITDEPT", "VVISITDEPT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VREMARKS", "VREMARKS", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VPATIENTID", "VPATIENTID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NACCT_MODE", "NACCT_MODE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VCOUNTDEPT", "VCOUNTDEPT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VDOCTOR_ID", "VDOCTOR_ID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VACCTID", "VACCTID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NACCOUNTTF", "NACCOUNTTF", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VACCOUNTSIDTF", "VACCOUNTSIDTF", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NOPHZID", "NOPHZID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VCLINICNO", "VCLINICNO", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NHOSID", "NHOSID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDVACCOUNTSID", "VACCOUNTSID", DataRowVersion.Original, OracleType.VarChar, 10, ParameterDirection.Input, null);
		}
				
		public System.String VACCOUNTSID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VACCOUNTSID"].Value, "System.String");
			}
			set
			{
				m_Params["VACCOUNTSID"].Value = value;
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
				
		public System.String VPRESCNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPRESCNO"].Value, "System.String");
			}
			set
			{
				m_Params["VPRESCNO"].Value = value;
			}
		}
				
		public System.String VITEMID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VITEMID"].Value, "System.String");
			}
			set
			{
				m_Params["VITEMID"].Value = value;
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
				
		public System.Decimal NCOSTS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCOSTS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCOSTS"].Value = value;
			}
		}
				
		public System.Decimal NACCOUNTSCOSTS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NACCOUNTSCOSTS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NACCOUNTSCOSTS"].Value = value;
			}
		}
				
		public System.Decimal NCHARGEFLAG
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCHARGEFLAG"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCHARGEFLAG"].Value = value;
			}
		}
				
		public System.DateTime DMEDICINEDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DMEDICINEDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DMEDICINEDATE"].Value = value;
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
				
		public System.DateTime DSETTLEDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DSETTLEDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DSETTLEDATE"].Value = value;
			}
		}
				
		public System.String VSETTLEID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSETTLEID"].Value, "System.String");
			}
			set
			{
				m_Params["VSETTLEID"].Value = value;
			}
		}
				
		public System.String VCARDNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VCARDNO"].Value, "System.String");
			}
			set
			{
				m_Params["VCARDNO"].Value = value;
			}
		}
				
		public System.Decimal NACCOUNT
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NACCOUNT"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NACCOUNT"].Value = value;
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
				
		public System.String NFLAG
		{
			get
			{
				return (System.String)ConverValue(m_Params["NFLAG"].Value, "System.String");
			}
			set
			{
				m_Params["NFLAG"].Value = value;
			}
		}
				
		public System.String VVISITDEPT
		{
			get
			{
				return (System.String)ConverValue(m_Params["VVISITDEPT"].Value, "System.String");
			}
			set
			{
				m_Params["VVISITDEPT"].Value = value;
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
				
		public System.Decimal NACCT_MODE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NACCT_MODE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NACCT_MODE"].Value = value;
			}
		}
				
		public System.String VCOUNTDEPT
		{
			get
			{
				return (System.String)ConverValue(m_Params["VCOUNTDEPT"].Value, "System.String");
			}
			set
			{
				m_Params["VCOUNTDEPT"].Value = value;
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
				
		public System.Decimal NACCOUNTTF
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NACCOUNTTF"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NACCOUNTTF"].Value = value;
			}
		}
				
		public System.String VACCOUNTSIDTF
		{
			get
			{
				return (System.String)ConverValue(m_Params["VACCOUNTSIDTF"].Value, "System.String");
			}
			set
			{
				m_Params["VACCOUNTSIDTF"].Value = value;
			}
		}
				
		public System.Decimal NOPHZID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NOPHZID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NOPHZID"].Value = value;
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
				
		public System.String OLDVACCOUNTSID
		{
			get
			{
				return (System.String)ConverValue(m_Params["OLDVACCOUNTSID"].Value, "System.String");
			}
			set
			{
				m_Params["OLDVACCOUNTSID"].Value = value;
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
	} // SS_UpdateGHSF_GHSF_JZ
	#endregion
	
	#region SS_GHSF_JZ_SelectByIDGHSF_GHSF_JZ
	/// 
	/// 对于SelectByIDGHSF_GHSF_JZ的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_JZ_SelectByIDGHSF_GHSF_JZ : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_JZ_SelectByIDGHSF_GHSF_JZ() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT VACCOUNTSID, VRCPTID, VPRESCNO, VITEMID, VITEMNAME, NPRICE, NCOSTS, NACCOUNTSCOSTS, NCHARGEFLAG, DMEDICINEDATE, VOPERATORID, NSETTLE, DSETTLEDATE, VSETTLEID, VCARDNO, NACCOUNT, VINVOICENO, NFLAG, VVISITDEPT, VREMARKS, VPATIENTID, NACCT_MODE, VCOUNTDEPT, VDOCTOR_ID, VACCTID, NACCOUNTTF, VACCOUNTSIDTF, NOPHZID, VCLINICNO, NHOSID  FROM GHSF.GHSF_JZ  WHERE  VACCOUNTSID = :VACCOUNTSID";
					
			m_Params.AddParam("VACCOUNTSID", "VACCOUNTSID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);
		}
				
		public System.String VACCOUNTSID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VACCOUNTSID"].Value, "System.String");
			}
			set
			{
				m_Params["VACCOUNTSID"].Value = value;
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
	} // SS_SelectByIDGHSF_GHSF_JZ
	#endregion
	
	#region SS_GHSF_JZ_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_JZ_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_JZ_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT * FROM GHSF.GHSF_JZ  WHERE 1=1";
			
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
	