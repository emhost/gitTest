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
	
	#region SS_GHSF_REGHIS_InsertGHSF_GHSF_REGHIS
	/// 
	/// 对于InsertGHSF_GHSF_REGHIS的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_REGHIS_InsertGHSF_GHSF_REGHIS : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_REGHIS_InsertGHSF_GHSF_REGHIS() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO GHSF.GHSF_REGHIS  (VCLINICNO, DVISITDATE, NVISITNO, VAPPTIME, VPATIENTID, VNAME, PINYINMA, WUBIMA, NSEX, NAGE, DBIRTHDATE, NIDENTITY, NCHARGETYPE, VINSURANCETY, VINSURANCEN, VUNITINCONTRACT, NCLINICTYPE, NCFIRSTVISITIND, VVISITDEPT, VDOCTOR, NMRPROVIDEINDICATOR, NREGSTATUS, VOPERATORID, DREGDATE, VSYMPTOM, NREGISTFEE, NCLINICFEE, NOTHERFEE, NCLINICCHARG, DRETURNDATE, VIDTYPE, VIDNO, VRETURNID, NMODEID, VCARDNO, DACCTDATETI, DACCTNO, NMRPROVIDEDINDICATOR, VAPPOINTSID, VREMARKS, VNATION, VNATIVEPLACE, VPRESENTADDRESS, VLINKMAN, VPHONE, NKA, NPROFESSIONID, NDICGHTYPE, VBSETCARD, PERSONACCOUNTINFO, YBGRBH, NCHARGE, NHOSID, PURCHASINGPERSONNAME, PURCHASINGPERSONVIDNO, PURCHASINGPERSONVPHONE, RELATIONSHIPWITHPATIENTS, YBLX, NDICAREAID, NHREGNO, BCJSFF, NHLYZT, JSDISEASE, VFIRST_VISITDEPT, VFIRST_DOCTOR)  VALUES (:VCLINICNO, :DVISITDATE, :NVISITNO, :VAPPTIME, :VPATIENTID, :VNAME, :PINYINMA, :WUBIMA, :NSEX, :NAGE, :DBIRTHDATE, :NIDENTITY, :NCHARGETYPE, :VINSURANCETY, :VINSURANCEN, :VUNITINCONTRACT, :NCLINICTYPE, :NCFIRSTVISITIND, :VVISITDEPT, :VDOCTOR, :NMRPROVIDEINDICATOR, :NREGSTATUS, :VOPERATORID, :DREGDATE, :VSYMPTOM, :NREGISTFEE, :NCLINICFEE, :NOTHERFEE, :NCLINICCHARG, :DRETURNDATE, :VIDTYPE, :VIDNO, :VRETURNID, :NMODEID, :VCARDNO, :DACCTDATETI, :DACCTNO, :NMRPROVIDEDINDICATOR, :VAPPOINTSID, :VREMARKS, :VNATION, :VNATIVEPLACE, :VPRESENTADDRESS, :VLINKMAN, :VPHONE, :NKA, :NPROFESSIONID, :NDICGHTYPE, :VBSETCARD, :PERSONACCOUNTINFO, :YBGRBH, :NCHARGE, :NHOSID, :PURCHASINGPERSONNAME, :PURCHASINGPERSONVIDNO, :PURCHASINGPERSONVPHONE, :RELATIONSHIPWITHPATIENTS, :YBLX, :NDICAREAID, :NHREGNO, :BCJSFF, :NHLYZT, :JSDISEASE, :VFIRST_VISITDEPT, :VFIRST_DOCTOR)";
					
			m_Params.AddParam("VCLINICNO", "VCLINICNO", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("DVISITDATE", "DVISITDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NVISITNO", "NVISITNO", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VAPPTIME", "VAPPTIME", DataRowVersion.Current, OracleType.VarChar, 8, ParameterDirection.Input, null);		
			m_Params.AddParam("VPATIENTID", "VPATIENTID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VNAME", "VNAME", DataRowVersion.Current, OracleType.NVarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("PINYINMA", "PINYINMA", DataRowVersion.Current, OracleType.VarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("WUBIMA", "WUBIMA", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NSEX", "NSEX", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NAGE", "NAGE", DataRowVersion.Current, OracleType.NVarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("DBIRTHDATE", "DBIRTHDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NIDENTITY", "NIDENTITY", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NCHARGETYPE", "NCHARGETYPE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VINSURANCETY", "VINSURANCETY", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VINSURANCEN", "VINSURANCEN", DataRowVersion.Current, OracleType.VarChar, 8, ParameterDirection.Input, null);		
			m_Params.AddParam("VUNITINCONTRACT", "VUNITINCONTRACT", DataRowVersion.Current, OracleType.VarChar, 11, ParameterDirection.Input, null);		
			m_Params.AddParam("NCLINICTYPE", "NCLINICTYPE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCFIRSTVISITIND", "NCFIRSTVISITIND", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VVISITDEPT", "VVISITDEPT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VDOCTOR", "VDOCTOR", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NMRPROVIDEINDICATOR", "NMRPROVIDEINDICATOR", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NREGSTATUS", "NREGSTATUS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VOPERATORID", "VOPERATORID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("DREGDATE", "DREGDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VSYMPTOM", "VSYMPTOM", DataRowVersion.Current, OracleType.NVarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("NREGISTFEE", "NREGISTFEE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCLINICFEE", "NCLINICFEE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NOTHERFEE", "NOTHERFEE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCLINICCHARG", "NCLINICCHARG", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DRETURNDATE", "DRETURNDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VIDTYPE", "VIDTYPE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VIDNO", "VIDNO", DataRowVersion.Current, OracleType.VarChar, 18, ParameterDirection.Input, null);		
			m_Params.AddParam("VRETURNID", "VRETURNID", DataRowVersion.Current, OracleType.VarChar, 8, ParameterDirection.Input, null);		
			m_Params.AddParam("NMODEID", "NMODEID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VCARDNO", "VCARDNO", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("DACCTDATETI", "DACCTDATETI", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DACCTNO", "DACCTNO", DataRowVersion.Current, OracleType.VarChar, 6, ParameterDirection.Input, null);		
			m_Params.AddParam("NMRPROVIDEDINDICATOR", "NMRPROVIDEDINDICATOR", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VAPPOINTSID", "VAPPOINTSID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VREMARKS", "VREMARKS", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VNATION", "VNATION", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VNATIVEPLACE", "VNATIVEPLACE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRESENTADDRESS", "VPRESENTADDRESS", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VLINKMAN", "VLINKMAN", DataRowVersion.Current, OracleType.NVarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VPHONE", "VPHONE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NKA", "NKA", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NPROFESSIONID", "NPROFESSIONID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NDICGHTYPE", "NDICGHTYPE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VBSETCARD", "VBSETCARD", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("PERSONACCOUNTINFO", "PERSONACCOUNTINFO", DataRowVersion.Current, OracleType.VarChar, 1000, ParameterDirection.Input, null);		
			m_Params.AddParam("YBGRBH", "YBGRBH", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NCHARGE", "NCHARGE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NHOSID", "NHOSID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("PURCHASINGPERSONNAME", "PURCHASINGPERSONNAME", DataRowVersion.Current, OracleType.NVarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("PURCHASINGPERSONVIDNO", "PURCHASINGPERSONVIDNO", DataRowVersion.Current, OracleType.VarChar, 18, ParameterDirection.Input, null);		
			m_Params.AddParam("PURCHASINGPERSONVPHONE", "PURCHASINGPERSONVPHONE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("RELATIONSHIPWITHPATIENTS", "RELATIONSHIPWITHPATIENTS", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("YBLX", "YBLX", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NDICAREAID", "NDICAREAID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NHREGNO", "NHREGNO", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("BCJSFF", "BCJSFF", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NHLYZT", "NHLYZT", DataRowVersion.Current, OracleType.VarChar, 2, ParameterDirection.Input, null);		
			m_Params.AddParam("JSDISEASE", "JSDISEASE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VFIRST_VISITDEPT", "VFIRST_VISITDEPT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VFIRST_DOCTOR", "VFIRST_DOCTOR", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);
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
				
		public System.DateTime DVISITDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DVISITDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DVISITDATE"].Value = value;
			}
		}
				
		public System.Decimal NVISITNO
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NVISITNO"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NVISITNO"].Value = value;
			}
		}
				
		public System.String VAPPTIME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VAPPTIME"].Value, "System.String");
			}
			set
			{
				m_Params["VAPPTIME"].Value = value;
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
				
		public System.Decimal NSEX
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSEX"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSEX"].Value = value;
			}
		}
				
		public System.String NAGE
		{
			get
			{
				return (System.String)ConverValue(m_Params["NAGE"].Value, "System.String");
			}
			set
			{
				m_Params["NAGE"].Value = value;
			}
		}
				
		public System.DateTime DBIRTHDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DBIRTHDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DBIRTHDATE"].Value = value;
			}
		}
				
		public System.String NIDENTITY
		{
			get
			{
				return (System.String)ConverValue(m_Params["NIDENTITY"].Value, "System.String");
			}
			set
			{
				m_Params["NIDENTITY"].Value = value;
			}
		}
				
		public System.Decimal NCHARGETYPE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCHARGETYPE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCHARGETYPE"].Value = value;
			}
		}
				
		public System.String VINSURANCETY
		{
			get
			{
				return (System.String)ConverValue(m_Params["VINSURANCETY"].Value, "System.String");
			}
			set
			{
				m_Params["VINSURANCETY"].Value = value;
			}
		}
				
		public System.String VINSURANCEN
		{
			get
			{
				return (System.String)ConverValue(m_Params["VINSURANCEN"].Value, "System.String");
			}
			set
			{
				m_Params["VINSURANCEN"].Value = value;
			}
		}
				
		public System.String VUNITINCONTRACT
		{
			get
			{
				return (System.String)ConverValue(m_Params["VUNITINCONTRACT"].Value, "System.String");
			}
			set
			{
				m_Params["VUNITINCONTRACT"].Value = value;
			}
		}
				
		public System.Decimal NCLINICTYPE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCLINICTYPE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCLINICTYPE"].Value = value;
			}
		}
				
		public System.Decimal NCFIRSTVISITIND
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCFIRSTVISITIND"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCFIRSTVISITIND"].Value = value;
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
				
		public System.String VDOCTOR
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDOCTOR"].Value, "System.String");
			}
			set
			{
				m_Params["VDOCTOR"].Value = value;
			}
		}
				
		public System.Decimal NMRPROVIDEINDICATOR
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NMRPROVIDEINDICATOR"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NMRPROVIDEINDICATOR"].Value = value;
			}
		}
				
		public System.Decimal NREGSTATUS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NREGSTATUS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NREGSTATUS"].Value = value;
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
				
		public System.DateTime DREGDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DREGDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DREGDATE"].Value = value;
			}
		}
				
		public System.String VSYMPTOM
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSYMPTOM"].Value, "System.String");
			}
			set
			{
				m_Params["VSYMPTOM"].Value = value;
			}
		}
				
		public System.Decimal NREGISTFEE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NREGISTFEE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NREGISTFEE"].Value = value;
			}
		}
				
		public System.Decimal NCLINICFEE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCLINICFEE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCLINICFEE"].Value = value;
			}
		}
				
		public System.Decimal NOTHERFEE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NOTHERFEE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NOTHERFEE"].Value = value;
			}
		}
				
		public System.Decimal NCLINICCHARG
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCLINICCHARG"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCLINICCHARG"].Value = value;
			}
		}
				
		public System.DateTime DRETURNDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DRETURNDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DRETURNDATE"].Value = value;
			}
		}
				
		public System.String VIDTYPE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VIDTYPE"].Value, "System.String");
			}
			set
			{
				m_Params["VIDTYPE"].Value = value;
			}
		}
				
		public System.String VIDNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VIDNO"].Value, "System.String");
			}
			set
			{
				m_Params["VIDNO"].Value = value;
			}
		}
				
		public System.String VRETURNID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRETURNID"].Value, "System.String");
			}
			set
			{
				m_Params["VRETURNID"].Value = value;
			}
		}
				
		public System.Decimal NMODEID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NMODEID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NMODEID"].Value = value;
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
				
		public System.DateTime DACCTDATETI
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DACCTDATETI"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DACCTDATETI"].Value = value;
			}
		}
				
		public System.String DACCTNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["DACCTNO"].Value, "System.String");
			}
			set
			{
				m_Params["DACCTNO"].Value = value;
			}
		}
				
		public System.Decimal NMRPROVIDEDINDICATOR
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NMRPROVIDEDINDICATOR"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NMRPROVIDEDINDICATOR"].Value = value;
			}
		}
				
		public System.String VAPPOINTSID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VAPPOINTSID"].Value, "System.String");
			}
			set
			{
				m_Params["VAPPOINTSID"].Value = value;
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
				
		public System.String VNATION
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNATION"].Value, "System.String");
			}
			set
			{
				m_Params["VNATION"].Value = value;
			}
		}
				
		public System.String VNATIVEPLACE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNATIVEPLACE"].Value, "System.String");
			}
			set
			{
				m_Params["VNATIVEPLACE"].Value = value;
			}
		}
				
		public System.String VPRESENTADDRESS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPRESENTADDRESS"].Value, "System.String");
			}
			set
			{
				m_Params["VPRESENTADDRESS"].Value = value;
			}
		}
				
		public System.String VLINKMAN
		{
			get
			{
				return (System.String)ConverValue(m_Params["VLINKMAN"].Value, "System.String");
			}
			set
			{
				m_Params["VLINKMAN"].Value = value;
			}
		}
				
		public System.String VPHONE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPHONE"].Value, "System.String");
			}
			set
			{
				m_Params["VPHONE"].Value = value;
			}
		}
				
		public System.Decimal NKA
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NKA"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NKA"].Value = value;
			}
		}
				
		public System.Decimal NPROFESSIONID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPROFESSIONID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPROFESSIONID"].Value = value;
			}
		}
				
		public System.Decimal NDICGHTYPE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDICGHTYPE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDICGHTYPE"].Value = value;
			}
		}
				
		public System.String VBSETCARD
		{
			get
			{
				return (System.String)ConverValue(m_Params["VBSETCARD"].Value, "System.String");
			}
			set
			{
				m_Params["VBSETCARD"].Value = value;
			}
		}
				
		public System.String PERSONACCOUNTINFO
		{
			get
			{
				return (System.String)ConverValue(m_Params["PERSONACCOUNTINFO"].Value, "System.String");
			}
			set
			{
				m_Params["PERSONACCOUNTINFO"].Value = value;
			}
		}
				
		public System.String YBGRBH
		{
			get
			{
				return (System.String)ConverValue(m_Params["YBGRBH"].Value, "System.String");
			}
			set
			{
				m_Params["YBGRBH"].Value = value;
			}
		}
				
		public System.Decimal NCHARGE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCHARGE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCHARGE"].Value = value;
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
				
		public System.String PURCHASINGPERSONNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["PURCHASINGPERSONNAME"].Value, "System.String");
			}
			set
			{
				m_Params["PURCHASINGPERSONNAME"].Value = value;
			}
		}
				
		public System.String PURCHASINGPERSONVIDNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["PURCHASINGPERSONVIDNO"].Value, "System.String");
			}
			set
			{
				m_Params["PURCHASINGPERSONVIDNO"].Value = value;
			}
		}
				
		public System.String PURCHASINGPERSONVPHONE
		{
			get
			{
				return (System.String)ConverValue(m_Params["PURCHASINGPERSONVPHONE"].Value, "System.String");
			}
			set
			{
				m_Params["PURCHASINGPERSONVPHONE"].Value = value;
			}
		}
				
		public System.String RELATIONSHIPWITHPATIENTS
		{
			get
			{
				return (System.String)ConverValue(m_Params["RELATIONSHIPWITHPATIENTS"].Value, "System.String");
			}
			set
			{
				m_Params["RELATIONSHIPWITHPATIENTS"].Value = value;
			}
		}
				
		public System.String YBLX
		{
			get
			{
				return (System.String)ConverValue(m_Params["YBLX"].Value, "System.String");
			}
			set
			{
				m_Params["YBLX"].Value = value;
			}
		}
				
		public System.Decimal NDICAREAID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDICAREAID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDICAREAID"].Value = value;
			}
		}
				
		public System.String NHREGNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["NHREGNO"].Value, "System.String");
			}
			set
			{
				m_Params["NHREGNO"].Value = value;
			}
		}
				
		public System.String BCJSFF
		{
			get
			{
				return (System.String)ConverValue(m_Params["BCJSFF"].Value, "System.String");
			}
			set
			{
				m_Params["BCJSFF"].Value = value;
			}
		}
				
		public System.String NHLYZT
		{
			get
			{
				return (System.String)ConverValue(m_Params["NHLYZT"].Value, "System.String");
			}
			set
			{
				m_Params["NHLYZT"].Value = value;
			}
		}
				
		public System.Decimal JSDISEASE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["JSDISEASE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["JSDISEASE"].Value = value;
			}
		}
				
		public System.String VFIRST_VISITDEPT
		{
			get
			{
				return (System.String)ConverValue(m_Params["VFIRST_VISITDEPT"].Value, "System.String");
			}
			set
			{
				m_Params["VFIRST_VISITDEPT"].Value = value;
			}
		}
				
		public System.String VFIRST_DOCTOR
		{
			get
			{
				return (System.String)ConverValue(m_Params["VFIRST_DOCTOR"].Value, "System.String");
			}
			set
			{
				m_Params["VFIRST_DOCTOR"].Value = value;
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
	} // SS_InsertGHSF_GHSF_REGHIS
	#endregion
	
	#region SS_GHSF_REGHIS_DeleteGHSF_GHSF_REGHIS
	/// 
	/// 对于DeleteGHSF_GHSF_REGHIS的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_REGHIS_DeleteGHSF_GHSF_REGHIS : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_REGHIS_DeleteGHSF_GHSF_REGHIS() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM GHSF.GHSF_REGHIS  WHERE  VCLINICNO = :VCLINICNO";
					
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
	} // SS_DeleteGHSF_GHSF_REGHIS
	#endregion
	
	#region SS_GHSF_REGHIS_UpdateGHSF_GHSF_REGHIS
	/// 
	/// 对于UpdateGHSF_GHSF_REGHIS的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_REGHIS_UpdateGHSF_GHSF_REGHIS : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_REGHIS_UpdateGHSF_GHSF_REGHIS() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE GHSF.GHSF_REGHIS  SET  VCLINICNO = :VCLINICNO, DVISITDATE = :DVISITDATE, NVISITNO = :NVISITNO, VAPPTIME = :VAPPTIME, VPATIENTID = :VPATIENTID, VNAME = :VNAME, PINYINMA = :PINYINMA, WUBIMA = :WUBIMA, NSEX = :NSEX, NAGE = :NAGE, DBIRTHDATE = :DBIRTHDATE, NIDENTITY = :NIDENTITY, NCHARGETYPE = :NCHARGETYPE, VINSURANCETY = :VINSURANCETY, VINSURANCEN = :VINSURANCEN, VUNITINCONTRACT = :VUNITINCONTRACT, NCLINICTYPE = :NCLINICTYPE, NCFIRSTVISITIND = :NCFIRSTVISITIND, VVISITDEPT = :VVISITDEPT, VDOCTOR = :VDOCTOR, NMRPROVIDEINDICATOR = :NMRPROVIDEINDICATOR, NREGSTATUS = :NREGSTATUS, VOPERATORID = :VOPERATORID, DREGDATE = :DREGDATE, VSYMPTOM = :VSYMPTOM, NREGISTFEE = :NREGISTFEE, NCLINICFEE = :NCLINICFEE, NOTHERFEE = :NOTHERFEE, NCLINICCHARG = :NCLINICCHARG, DRETURNDATE = :DRETURNDATE, VIDTYPE = :VIDTYPE, VIDNO = :VIDNO, VRETURNID = :VRETURNID, NMODEID = :NMODEID, VCARDNO = :VCARDNO, DACCTDATETI = :DACCTDATETI, DACCTNO = :DACCTNO, NMRPROVIDEDINDICATOR = :NMRPROVIDEDINDICATOR, VAPPOINTSID = :VAPPOINTSID, VREMARKS = :VREMARKS, VNATION = :VNATION, VNATIVEPLACE = :VNATIVEPLACE, VPRESENTADDRESS = :VPRESENTADDRESS, VLINKMAN = :VLINKMAN, VPHONE = :VPHONE, NKA = :NKA, NPROFESSIONID = :NPROFESSIONID, NDICGHTYPE = :NDICGHTYPE, VBSETCARD = :VBSETCARD, PERSONACCOUNTINFO = :PERSONACCOUNTINFO, YBGRBH = :YBGRBH, NCHARGE = :NCHARGE, NHOSID = :NHOSID, PURCHASINGPERSONNAME = :PURCHASINGPERSONNAME, PURCHASINGPERSONVIDNO = :PURCHASINGPERSONVIDNO, PURCHASINGPERSONVPHONE = :PURCHASINGPERSONVPHONE, RELATIONSHIPWITHPATIENTS = :RELATIONSHIPWITHPATIENTS, YBLX = :YBLX, NDICAREAID = :NDICAREAID, NHREGNO = :NHREGNO, BCJSFF = :BCJSFF, NHLYZT = :NHLYZT, JSDISEASE = :JSDISEASE, VFIRST_VISITDEPT = :VFIRST_VISITDEPT, VFIRST_DOCTOR = :VFIRST_DOCTOR   WHERE  VCLINICNO = :OLDVCLINICNO";
					
			m_Params.AddParam("VCLINICNO", "VCLINICNO", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("DVISITDATE", "DVISITDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NVISITNO", "NVISITNO", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VAPPTIME", "VAPPTIME", DataRowVersion.Current, OracleType.VarChar, 8, ParameterDirection.Input, null);		
			m_Params.AddParam("VPATIENTID", "VPATIENTID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VNAME", "VNAME", DataRowVersion.Current, OracleType.NVarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("PINYINMA", "PINYINMA", DataRowVersion.Current, OracleType.VarChar, 60, ParameterDirection.Input, null);		
			m_Params.AddParam("WUBIMA", "WUBIMA", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NSEX", "NSEX", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NAGE", "NAGE", DataRowVersion.Current, OracleType.NVarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("DBIRTHDATE", "DBIRTHDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NIDENTITY", "NIDENTITY", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NCHARGETYPE", "NCHARGETYPE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VINSURANCETY", "VINSURANCETY", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VINSURANCEN", "VINSURANCEN", DataRowVersion.Current, OracleType.VarChar, 8, ParameterDirection.Input, null);		
			m_Params.AddParam("VUNITINCONTRACT", "VUNITINCONTRACT", DataRowVersion.Current, OracleType.VarChar, 11, ParameterDirection.Input, null);		
			m_Params.AddParam("NCLINICTYPE", "NCLINICTYPE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCFIRSTVISITIND", "NCFIRSTVISITIND", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VVISITDEPT", "VVISITDEPT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VDOCTOR", "VDOCTOR", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NMRPROVIDEINDICATOR", "NMRPROVIDEINDICATOR", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NREGSTATUS", "NREGSTATUS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VOPERATORID", "VOPERATORID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("DREGDATE", "DREGDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VSYMPTOM", "VSYMPTOM", DataRowVersion.Current, OracleType.NVarChar, 40, ParameterDirection.Input, null);		
			m_Params.AddParam("NREGISTFEE", "NREGISTFEE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCLINICFEE", "NCLINICFEE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NOTHERFEE", "NOTHERFEE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCLINICCHARG", "NCLINICCHARG", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DRETURNDATE", "DRETURNDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VIDTYPE", "VIDTYPE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VIDNO", "VIDNO", DataRowVersion.Current, OracleType.VarChar, 18, ParameterDirection.Input, null);		
			m_Params.AddParam("VRETURNID", "VRETURNID", DataRowVersion.Current, OracleType.VarChar, 8, ParameterDirection.Input, null);		
			m_Params.AddParam("NMODEID", "NMODEID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VCARDNO", "VCARDNO", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("DACCTDATETI", "DACCTDATETI", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DACCTNO", "DACCTNO", DataRowVersion.Current, OracleType.VarChar, 6, ParameterDirection.Input, null);		
			m_Params.AddParam("NMRPROVIDEDINDICATOR", "NMRPROVIDEDINDICATOR", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VAPPOINTSID", "VAPPOINTSID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VREMARKS", "VREMARKS", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VNATION", "VNATION", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VNATIVEPLACE", "VNATIVEPLACE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRESENTADDRESS", "VPRESENTADDRESS", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VLINKMAN", "VLINKMAN", DataRowVersion.Current, OracleType.NVarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VPHONE", "VPHONE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NKA", "NKA", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NPROFESSIONID", "NPROFESSIONID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NDICGHTYPE", "NDICGHTYPE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VBSETCARD", "VBSETCARD", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("PERSONACCOUNTINFO", "PERSONACCOUNTINFO", DataRowVersion.Current, OracleType.VarChar, 1000, ParameterDirection.Input, null);		
			m_Params.AddParam("YBGRBH", "YBGRBH", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NCHARGE", "NCHARGE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NHOSID", "NHOSID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("PURCHASINGPERSONNAME", "PURCHASINGPERSONNAME", DataRowVersion.Current, OracleType.NVarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("PURCHASINGPERSONVIDNO", "PURCHASINGPERSONVIDNO", DataRowVersion.Current, OracleType.VarChar, 18, ParameterDirection.Input, null);		
			m_Params.AddParam("PURCHASINGPERSONVPHONE", "PURCHASINGPERSONVPHONE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("RELATIONSHIPWITHPATIENTS", "RELATIONSHIPWITHPATIENTS", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("YBLX", "YBLX", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NDICAREAID", "NDICAREAID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NHREGNO", "NHREGNO", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("BCJSFF", "BCJSFF", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NHLYZT", "NHLYZT", DataRowVersion.Current, OracleType.VarChar, 2, ParameterDirection.Input, null);		
			m_Params.AddParam("JSDISEASE", "JSDISEASE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VFIRST_VISITDEPT", "VFIRST_VISITDEPT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VFIRST_DOCTOR", "VFIRST_DOCTOR", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
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
				
		public System.DateTime DVISITDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DVISITDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DVISITDATE"].Value = value;
			}
		}
				
		public System.Decimal NVISITNO
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NVISITNO"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NVISITNO"].Value = value;
			}
		}
				
		public System.String VAPPTIME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VAPPTIME"].Value, "System.String");
			}
			set
			{
				m_Params["VAPPTIME"].Value = value;
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
				
		public System.Decimal NSEX
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSEX"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSEX"].Value = value;
			}
		}
				
		public System.String NAGE
		{
			get
			{
				return (System.String)ConverValue(m_Params["NAGE"].Value, "System.String");
			}
			set
			{
				m_Params["NAGE"].Value = value;
			}
		}
				
		public System.DateTime DBIRTHDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DBIRTHDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DBIRTHDATE"].Value = value;
			}
		}
				
		public System.String NIDENTITY
		{
			get
			{
				return (System.String)ConverValue(m_Params["NIDENTITY"].Value, "System.String");
			}
			set
			{
				m_Params["NIDENTITY"].Value = value;
			}
		}
				
		public System.Decimal NCHARGETYPE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCHARGETYPE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCHARGETYPE"].Value = value;
			}
		}
				
		public System.String VINSURANCETY
		{
			get
			{
				return (System.String)ConverValue(m_Params["VINSURANCETY"].Value, "System.String");
			}
			set
			{
				m_Params["VINSURANCETY"].Value = value;
			}
		}
				
		public System.String VINSURANCEN
		{
			get
			{
				return (System.String)ConverValue(m_Params["VINSURANCEN"].Value, "System.String");
			}
			set
			{
				m_Params["VINSURANCEN"].Value = value;
			}
		}
				
		public System.String VUNITINCONTRACT
		{
			get
			{
				return (System.String)ConverValue(m_Params["VUNITINCONTRACT"].Value, "System.String");
			}
			set
			{
				m_Params["VUNITINCONTRACT"].Value = value;
			}
		}
				
		public System.Decimal NCLINICTYPE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCLINICTYPE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCLINICTYPE"].Value = value;
			}
		}
				
		public System.Decimal NCFIRSTVISITIND
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCFIRSTVISITIND"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCFIRSTVISITIND"].Value = value;
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
				
		public System.String VDOCTOR
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDOCTOR"].Value, "System.String");
			}
			set
			{
				m_Params["VDOCTOR"].Value = value;
			}
		}
				
		public System.Decimal NMRPROVIDEINDICATOR
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NMRPROVIDEINDICATOR"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NMRPROVIDEINDICATOR"].Value = value;
			}
		}
				
		public System.Decimal NREGSTATUS
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NREGSTATUS"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NREGSTATUS"].Value = value;
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
				
		public System.DateTime DREGDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DREGDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DREGDATE"].Value = value;
			}
		}
				
		public System.String VSYMPTOM
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSYMPTOM"].Value, "System.String");
			}
			set
			{
				m_Params["VSYMPTOM"].Value = value;
			}
		}
				
		public System.Decimal NREGISTFEE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NREGISTFEE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NREGISTFEE"].Value = value;
			}
		}
				
		public System.Decimal NCLINICFEE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCLINICFEE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCLINICFEE"].Value = value;
			}
		}
				
		public System.Decimal NOTHERFEE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NOTHERFEE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NOTHERFEE"].Value = value;
			}
		}
				
		public System.Decimal NCLINICCHARG
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCLINICCHARG"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCLINICCHARG"].Value = value;
			}
		}
				
		public System.DateTime DRETURNDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DRETURNDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DRETURNDATE"].Value = value;
			}
		}
				
		public System.String VIDTYPE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VIDTYPE"].Value, "System.String");
			}
			set
			{
				m_Params["VIDTYPE"].Value = value;
			}
		}
				
		public System.String VIDNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VIDNO"].Value, "System.String");
			}
			set
			{
				m_Params["VIDNO"].Value = value;
			}
		}
				
		public System.String VRETURNID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRETURNID"].Value, "System.String");
			}
			set
			{
				m_Params["VRETURNID"].Value = value;
			}
		}
				
		public System.Decimal NMODEID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NMODEID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NMODEID"].Value = value;
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
				
		public System.DateTime DACCTDATETI
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DACCTDATETI"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DACCTDATETI"].Value = value;
			}
		}
				
		public System.String DACCTNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["DACCTNO"].Value, "System.String");
			}
			set
			{
				m_Params["DACCTNO"].Value = value;
			}
		}
				
		public System.Decimal NMRPROVIDEDINDICATOR
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NMRPROVIDEDINDICATOR"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NMRPROVIDEDINDICATOR"].Value = value;
			}
		}
				
		public System.String VAPPOINTSID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VAPPOINTSID"].Value, "System.String");
			}
			set
			{
				m_Params["VAPPOINTSID"].Value = value;
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
				
		public System.String VNATION
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNATION"].Value, "System.String");
			}
			set
			{
				m_Params["VNATION"].Value = value;
			}
		}
				
		public System.String VNATIVEPLACE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNATIVEPLACE"].Value, "System.String");
			}
			set
			{
				m_Params["VNATIVEPLACE"].Value = value;
			}
		}
				
		public System.String VPRESENTADDRESS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPRESENTADDRESS"].Value, "System.String");
			}
			set
			{
				m_Params["VPRESENTADDRESS"].Value = value;
			}
		}
				
		public System.String VLINKMAN
		{
			get
			{
				return (System.String)ConverValue(m_Params["VLINKMAN"].Value, "System.String");
			}
			set
			{
				m_Params["VLINKMAN"].Value = value;
			}
		}
				
		public System.String VPHONE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPHONE"].Value, "System.String");
			}
			set
			{
				m_Params["VPHONE"].Value = value;
			}
		}
				
		public System.Decimal NKA
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NKA"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NKA"].Value = value;
			}
		}
				
		public System.Decimal NPROFESSIONID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPROFESSIONID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPROFESSIONID"].Value = value;
			}
		}
				
		public System.Decimal NDICGHTYPE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDICGHTYPE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDICGHTYPE"].Value = value;
			}
		}
				
		public System.String VBSETCARD
		{
			get
			{
				return (System.String)ConverValue(m_Params["VBSETCARD"].Value, "System.String");
			}
			set
			{
				m_Params["VBSETCARD"].Value = value;
			}
		}
				
		public System.String PERSONACCOUNTINFO
		{
			get
			{
				return (System.String)ConverValue(m_Params["PERSONACCOUNTINFO"].Value, "System.String");
			}
			set
			{
				m_Params["PERSONACCOUNTINFO"].Value = value;
			}
		}
				
		public System.String YBGRBH
		{
			get
			{
				return (System.String)ConverValue(m_Params["YBGRBH"].Value, "System.String");
			}
			set
			{
				m_Params["YBGRBH"].Value = value;
			}
		}
				
		public System.Decimal NCHARGE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCHARGE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCHARGE"].Value = value;
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
				
		public System.String PURCHASINGPERSONNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["PURCHASINGPERSONNAME"].Value, "System.String");
			}
			set
			{
				m_Params["PURCHASINGPERSONNAME"].Value = value;
			}
		}
				
		public System.String PURCHASINGPERSONVIDNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["PURCHASINGPERSONVIDNO"].Value, "System.String");
			}
			set
			{
				m_Params["PURCHASINGPERSONVIDNO"].Value = value;
			}
		}
				
		public System.String PURCHASINGPERSONVPHONE
		{
			get
			{
				return (System.String)ConverValue(m_Params["PURCHASINGPERSONVPHONE"].Value, "System.String");
			}
			set
			{
				m_Params["PURCHASINGPERSONVPHONE"].Value = value;
			}
		}
				
		public System.String RELATIONSHIPWITHPATIENTS
		{
			get
			{
				return (System.String)ConverValue(m_Params["RELATIONSHIPWITHPATIENTS"].Value, "System.String");
			}
			set
			{
				m_Params["RELATIONSHIPWITHPATIENTS"].Value = value;
			}
		}
				
		public System.String YBLX
		{
			get
			{
				return (System.String)ConverValue(m_Params["YBLX"].Value, "System.String");
			}
			set
			{
				m_Params["YBLX"].Value = value;
			}
		}
				
		public System.Decimal NDICAREAID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDICAREAID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDICAREAID"].Value = value;
			}
		}
				
		public System.String NHREGNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["NHREGNO"].Value, "System.String");
			}
			set
			{
				m_Params["NHREGNO"].Value = value;
			}
		}
				
		public System.String BCJSFF
		{
			get
			{
				return (System.String)ConverValue(m_Params["BCJSFF"].Value, "System.String");
			}
			set
			{
				m_Params["BCJSFF"].Value = value;
			}
		}
				
		public System.String NHLYZT
		{
			get
			{
				return (System.String)ConverValue(m_Params["NHLYZT"].Value, "System.String");
			}
			set
			{
				m_Params["NHLYZT"].Value = value;
			}
		}
				
		public System.Decimal JSDISEASE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["JSDISEASE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["JSDISEASE"].Value = value;
			}
		}
				
		public System.String VFIRST_VISITDEPT
		{
			get
			{
				return (System.String)ConverValue(m_Params["VFIRST_VISITDEPT"].Value, "System.String");
			}
			set
			{
				m_Params["VFIRST_VISITDEPT"].Value = value;
			}
		}
				
		public System.String VFIRST_DOCTOR
		{
			get
			{
				return (System.String)ConverValue(m_Params["VFIRST_DOCTOR"].Value, "System.String");
			}
			set
			{
				m_Params["VFIRST_DOCTOR"].Value = value;
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
	} // SS_UpdateGHSF_GHSF_REGHIS
	#endregion
	
	#region SS_GHSF_REGHIS_SelectByIDGHSF_GHSF_REGHIS
	/// 
	/// 对于SelectByIDGHSF_GHSF_REGHIS的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_REGHIS_SelectByIDGHSF_GHSF_REGHIS : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_REGHIS_SelectByIDGHSF_GHSF_REGHIS() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT VCLINICNO, DVISITDATE, NVISITNO, VAPPTIME, VPATIENTID, VNAME, PINYINMA, WUBIMA, NSEX, NAGE, DBIRTHDATE, NIDENTITY, NCHARGETYPE, VINSURANCETY, VINSURANCEN, VUNITINCONTRACT, NCLINICTYPE, NCFIRSTVISITIND, VVISITDEPT, VDOCTOR, NMRPROVIDEINDICATOR, NREGSTATUS, VOPERATORID, DREGDATE, VSYMPTOM, NREGISTFEE, NCLINICFEE, NOTHERFEE, NCLINICCHARG, DRETURNDATE, VIDTYPE, VIDNO, VRETURNID, NMODEID, VCARDNO, DACCTDATETI, DACCTNO, NMRPROVIDEDINDICATOR, VAPPOINTSID, VREMARKS, VNATION, VNATIVEPLACE, VPRESENTADDRESS, VLINKMAN, VPHONE, NKA, NPROFESSIONID, NDICGHTYPE, VBSETCARD, PERSONACCOUNTINFO, YBGRBH, NCHARGE, NHOSID, PURCHASINGPERSONNAME, PURCHASINGPERSONVIDNO, PURCHASINGPERSONVPHONE, RELATIONSHIPWITHPATIENTS, YBLX, NDICAREAID, NHREGNO, BCJSFF, NHLYZT, JSDISEASE, VFIRST_VISITDEPT, VFIRST_DOCTOR  FROM GHSF.GHSF_REGHIS  WHERE  VCLINICNO = :VCLINICNO";
					
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
	} // SS_SelectByIDGHSF_GHSF_REGHIS
	#endregion
	
	#region SS_GHSF_REGHIS_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_REGHIS_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_REGHIS_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT * FROM GHSF.GHSF_REGHIS  WHERE 1=1";
			
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
	
	#region SS_GHSF_REGHIS_GHSF_FUN_GETVCLINICNOMZ
	/// 
	/// 对于GHSF_FUN_GETVCLINICNOMZ的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_REGHIS_GHSF_FUN_GETVCLINICNOMZ : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_REGHIS_GHSF_FUN_GETVCLINICNOMZ() : base()
		{  
			m_SqlName = "";

			m_SqlString = "GHSF_FUN_GETVCLINICNOMZ";
					
			m_Params.AddParam("RETURNVALUE", "RETURNVALUE", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.ReturnValue, null);		
			m_Params.AddParam("MPREFIX", "MPREFIX", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);
		}
				
		public System.String RETURNVALUE
		{
			get
			{
				return (System.String)ConverValue(m_Params["RETURNVALUE"].Value, "System.String");
			}
		}
				
		public System.String MPREFIX
		{
			get
			{
				return (System.String)ConverValue(m_Params["MPREFIX"].Value, "System.String");
			}
			set
			{
				m_Params["MPREFIX"].Value = value;
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
	} // SS_GHSF_FUN_GETVCLINICNOMZ
	#endregion
	
	
}
	