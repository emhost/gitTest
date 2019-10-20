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
	
	#region SS_GHSF_PATIENTINFO_InsertGHSF_GHSF_PATIENTINFO
	/// 
	/// 对于InsertGHSF_GHSF_PATIENTINFO的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_PATIENTINFO_InsertGHSF_GHSF_PATIENTINFO : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_PATIENTINFO_InsertGHSF_GHSF_PATIENTINFO() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO GHSF.GHSF_PATIENTINFO  (VPATIENTID, DCREATEDATE, VNAME, PINYINMA, WUBIMA, NSEX, DBIRTHDATE, VBIRTHPLACE, VBIRTHPLACEDETAIL, VNATION, VNATIONNAME, VIDTYPE, VIDNO, VUNITINCONTRACT, VUNITINCONTRACTNAME, VMAILINGADDRESS, VZIPID, VPHONENUMBERHOME, VPHONENUMBERBUSINESS, VLINKMAN, VRELATIONSHIP, VNEXTOFKINADDR, VNEXTOFKINZIPID, VPHONE, DLASTVISITDATE, NVIPINDICATOR, VOPERATORID, VDEGREE, VRACE, VRELIGION, VMOTHERLANGUAGE, VFOREIGNLANGUAGE, VVIPNO, VENGLISHNAME, VREMARKS, NCOUNTRY, NPROVINCES, NCITY, NSTREET, NPROFESSIONID, NIDENTITY, VPRESENTADDRESS, VISITNO, NMARRY, VORGAN, NDICAREAID, VDIAGNOSE, NDISEASEID, NZYZEXZ, NZYYPXZ)  VALUES (:VPATIENTID, :DCREATEDATE, :VNAME, :PINYINMA, :WUBIMA, :NSEX, :DBIRTHDATE, :VBIRTHPLACE, :VBIRTHPLACEDETAIL, :VNATION, :VNATIONNAME, :VIDTYPE, :VIDNO, :VUNITINCONTRACT, :VUNITINCONTRACTNAME, :VMAILINGADDRESS, :VZIPID, :VPHONENUMBERHOME, :VPHONENUMBERBUSINESS, :VLINKMAN, :VRELATIONSHIP, :VNEXTOFKINADDR, :VNEXTOFKINZIPID, :VPHONE, :DLASTVISITDATE, :NVIPINDICATOR, :VOPERATORID, :VDEGREE, :VRACE, :VRELIGION, :VMOTHERLANGUAGE, :VFOREIGNLANGUAGE, :VVIPNO, :VENGLISHNAME, :VREMARKS, :NCOUNTRY, :NPROVINCES, :NCITY, :NSTREET, :NPROFESSIONID, :NIDENTITY, :VPRESENTADDRESS, :VISITNO, :NMARRY, :VORGAN, :NDICAREAID, :VDIAGNOSE, :NDISEASEID, :NZYZEXZ, :NZYYPXZ)";
					
			m_Params.AddParam("VPATIENTID", "VPATIENTID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("DCREATEDATE", "DCREATEDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VNAME", "VNAME", DataRowVersion.Current, OracleType.NVarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("PINYINMA", "PINYINMA", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("WUBIMA", "WUBIMA", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NSEX", "NSEX", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DBIRTHDATE", "DBIRTHDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VBIRTHPLACE", "VBIRTHPLACE", DataRowVersion.Current, OracleType.VarChar, 6, ParameterDirection.Input, null);		
			m_Params.AddParam("VBIRTHPLACEDETAIL", "VBIRTHPLACEDETAIL", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VNATION", "VNATION", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VNATIONNAME", "VNATIONNAME", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VIDTYPE", "VIDTYPE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VIDNO", "VIDNO", DataRowVersion.Current, OracleType.VarChar, 18, ParameterDirection.Input, null);		
			m_Params.AddParam("VUNITINCONTRACT", "VUNITINCONTRACT", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VUNITINCONTRACTNAME", "VUNITINCONTRACTNAME", DataRowVersion.Current, OracleType.NVarChar, 200, ParameterDirection.Input, null);		
			m_Params.AddParam("VMAILINGADDRESS", "VMAILINGADDRESS", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VZIPID", "VZIPID", DataRowVersion.Current, OracleType.VarChar, 6, ParameterDirection.Input, null);		
			m_Params.AddParam("VPHONENUMBERHOME", "VPHONENUMBERHOME", DataRowVersion.Current, OracleType.VarChar, 16, ParameterDirection.Input, null);		
			m_Params.AddParam("VPHONENUMBERBUSINESS", "VPHONENUMBERBUSINESS", DataRowVersion.Current, OracleType.VarChar, 16, ParameterDirection.Input, null);		
			m_Params.AddParam("VLINKMAN", "VLINKMAN", DataRowVersion.Current, OracleType.NVarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VRELATIONSHIP", "VRELATIONSHIP", DataRowVersion.Current, OracleType.VarChar, 2, ParameterDirection.Input, null);		
			m_Params.AddParam("VNEXTOFKINADDR", "VNEXTOFKINADDR", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VNEXTOFKINZIPID", "VNEXTOFKINZIPID", DataRowVersion.Current, OracleType.VarChar, 6, ParameterDirection.Input, null);		
			m_Params.AddParam("VPHONE", "VPHONE", DataRowVersion.Current, OracleType.VarChar, 16, ParameterDirection.Input, null);		
			m_Params.AddParam("DLASTVISITDATE", "DLASTVISITDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NVIPINDICATOR", "NVIPINDICATOR", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VOPERATORID", "VOPERATORID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEGREE", "VDEGREE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VRACE", "VRACE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VRELIGION", "VRELIGION", DataRowVersion.Current, OracleType.VarChar, 16, ParameterDirection.Input, null);		
			m_Params.AddParam("VMOTHERLANGUAGE", "VMOTHERLANGUAGE", DataRowVersion.Current, OracleType.VarChar, 16, ParameterDirection.Input, null);		
			m_Params.AddParam("VFOREIGNLANGUAGE", "VFOREIGNLANGUAGE", DataRowVersion.Current, OracleType.VarChar, 16, ParameterDirection.Input, null);		
			m_Params.AddParam("VVIPNO", "VVIPNO", DataRowVersion.Current, OracleType.VarChar, 18, ParameterDirection.Input, null);		
			m_Params.AddParam("VENGLISHNAME", "VENGLISHNAME", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VREMARKS", "VREMARKS", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NCOUNTRY", "NCOUNTRY", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NPROVINCES", "NPROVINCES", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCITY", "NCITY", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NSTREET", "NSTREET", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NPROFESSIONID", "NPROFESSIONID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NIDENTITY", "NIDENTITY", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRESENTADDRESS", "VPRESENTADDRESS", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("VISITNO", "VISITNO", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NMARRY", "NMARRY", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VORGAN", "VORGAN", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NDICAREAID", "NDICAREAID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDIAGNOSE", "VDIAGNOSE", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("NDISEASEID", "NDISEASEID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NZYZEXZ", "NZYZEXZ", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NZYYPXZ", "NZYYPXZ", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);
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
				
		public System.String VBIRTHPLACE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VBIRTHPLACE"].Value, "System.String");
			}
			set
			{
				m_Params["VBIRTHPLACE"].Value = value;
			}
		}
				
		public System.String VBIRTHPLACEDETAIL
		{
			get
			{
				return (System.String)ConverValue(m_Params["VBIRTHPLACEDETAIL"].Value, "System.String");
			}
			set
			{
				m_Params["VBIRTHPLACEDETAIL"].Value = value;
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
				
		public System.String VNATIONNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNATIONNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VNATIONNAME"].Value = value;
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
				
		public System.String VUNITINCONTRACTNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VUNITINCONTRACTNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VUNITINCONTRACTNAME"].Value = value;
			}
		}
				
		public System.String VMAILINGADDRESS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VMAILINGADDRESS"].Value, "System.String");
			}
			set
			{
				m_Params["VMAILINGADDRESS"].Value = value;
			}
		}
				
		public System.String VZIPID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VZIPID"].Value, "System.String");
			}
			set
			{
				m_Params["VZIPID"].Value = value;
			}
		}
				
		public System.String VPHONENUMBERHOME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPHONENUMBERHOME"].Value, "System.String");
			}
			set
			{
				m_Params["VPHONENUMBERHOME"].Value = value;
			}
		}
				
		public System.String VPHONENUMBERBUSINESS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPHONENUMBERBUSINESS"].Value, "System.String");
			}
			set
			{
				m_Params["VPHONENUMBERBUSINESS"].Value = value;
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
				
		public System.String VRELATIONSHIP
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRELATIONSHIP"].Value, "System.String");
			}
			set
			{
				m_Params["VRELATIONSHIP"].Value = value;
			}
		}
				
		public System.String VNEXTOFKINADDR
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNEXTOFKINADDR"].Value, "System.String");
			}
			set
			{
				m_Params["VNEXTOFKINADDR"].Value = value;
			}
		}
				
		public System.String VNEXTOFKINZIPID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNEXTOFKINZIPID"].Value, "System.String");
			}
			set
			{
				m_Params["VNEXTOFKINZIPID"].Value = value;
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
				
		public System.DateTime DLASTVISITDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DLASTVISITDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DLASTVISITDATE"].Value = value;
			}
		}
				
		public System.Decimal NVIPINDICATOR
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NVIPINDICATOR"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NVIPINDICATOR"].Value = value;
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
				
		public System.String VDEGREE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEGREE"].Value, "System.String");
			}
			set
			{
				m_Params["VDEGREE"].Value = value;
			}
		}
				
		public System.String VRACE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRACE"].Value, "System.String");
			}
			set
			{
				m_Params["VRACE"].Value = value;
			}
		}
				
		public System.String VRELIGION
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRELIGION"].Value, "System.String");
			}
			set
			{
				m_Params["VRELIGION"].Value = value;
			}
		}
				
		public System.String VMOTHERLANGUAGE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VMOTHERLANGUAGE"].Value, "System.String");
			}
			set
			{
				m_Params["VMOTHERLANGUAGE"].Value = value;
			}
		}
				
		public System.String VFOREIGNLANGUAGE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VFOREIGNLANGUAGE"].Value, "System.String");
			}
			set
			{
				m_Params["VFOREIGNLANGUAGE"].Value = value;
			}
		}
				
		public System.String VVIPNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VVIPNO"].Value, "System.String");
			}
			set
			{
				m_Params["VVIPNO"].Value = value;
			}
		}
				
		public System.String VENGLISHNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VENGLISHNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VENGLISHNAME"].Value = value;
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
				
		public System.Decimal NCOUNTRY
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCOUNTRY"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCOUNTRY"].Value = value;
			}
		}
				
		public System.Decimal NPROVINCES
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPROVINCES"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPROVINCES"].Value = value;
			}
		}
				
		public System.Decimal NCITY
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCITY"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCITY"].Value = value;
			}
		}
				
		public System.Decimal NSTREET
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSTREET"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSTREET"].Value = value;
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
				
		public System.String VISITNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VISITNO"].Value, "System.String");
			}
			set
			{
				m_Params["VISITNO"].Value = value;
			}
		}
				
		public System.Decimal NMARRY
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NMARRY"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NMARRY"].Value = value;
			}
		}
				
		public System.String VORGAN
		{
			get
			{
				return (System.String)ConverValue(m_Params["VORGAN"].Value, "System.String");
			}
			set
			{
				m_Params["VORGAN"].Value = value;
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
				
		public System.Decimal NDISEASEID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDISEASEID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDISEASEID"].Value = value;
			}
		}
				
		public System.Decimal NZYZEXZ
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NZYZEXZ"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NZYZEXZ"].Value = value;
			}
		}
				
		public System.Decimal NZYYPXZ
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NZYYPXZ"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NZYYPXZ"].Value = value;
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
	} // SS_InsertGHSF_GHSF_PATIENTINFO
	#endregion
	
	#region SS_GHSF_PATIENTINFO_DeleteGHSF_GHSF_PATIENTINFO
	/// 
	/// 对于DeleteGHSF_GHSF_PATIENTINFO的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_PATIENTINFO_DeleteGHSF_GHSF_PATIENTINFO : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_PATIENTINFO_DeleteGHSF_GHSF_PATIENTINFO() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM GHSF.GHSF_PATIENTINFO  WHERE  VPATIENTID = :VPATIENTID";
					
			m_Params.AddParam("VPATIENTID", "VPATIENTID", DataRowVersion.Original, OracleType.VarChar, 10, ParameterDirection.Input, null);
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
	} // SS_DeleteGHSF_GHSF_PATIENTINFO
	#endregion
	
	#region SS_GHSF_PATIENTINFO_UpdateGHSF_GHSF_PATIENTINFO
	/// 
	/// 对于UpdateGHSF_GHSF_PATIENTINFO的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_PATIENTINFO_UpdateGHSF_GHSF_PATIENTINFO : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_PATIENTINFO_UpdateGHSF_GHSF_PATIENTINFO() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE GHSF.GHSF_PATIENTINFO  SET  VPATIENTID = :VPATIENTID, DCREATEDATE = :DCREATEDATE, VNAME = :VNAME, PINYINMA = :PINYINMA, WUBIMA = :WUBIMA, NSEX = :NSEX, DBIRTHDATE = :DBIRTHDATE, VBIRTHPLACE = :VBIRTHPLACE, VBIRTHPLACEDETAIL = :VBIRTHPLACEDETAIL, VNATION = :VNATION, VNATIONNAME = :VNATIONNAME, VIDTYPE = :VIDTYPE, VIDNO = :VIDNO, VUNITINCONTRACT = :VUNITINCONTRACT, VUNITINCONTRACTNAME = :VUNITINCONTRACTNAME, VMAILINGADDRESS = :VMAILINGADDRESS, VZIPID = :VZIPID, VPHONENUMBERHOME = :VPHONENUMBERHOME, VPHONENUMBERBUSINESS = :VPHONENUMBERBUSINESS, VLINKMAN = :VLINKMAN, VRELATIONSHIP = :VRELATIONSHIP, VNEXTOFKINADDR = :VNEXTOFKINADDR, VNEXTOFKINZIPID = :VNEXTOFKINZIPID, VPHONE = :VPHONE, DLASTVISITDATE = :DLASTVISITDATE, NVIPINDICATOR = :NVIPINDICATOR, VOPERATORID = :VOPERATORID, VDEGREE = :VDEGREE, VRACE = :VRACE, VRELIGION = :VRELIGION, VMOTHERLANGUAGE = :VMOTHERLANGUAGE, VFOREIGNLANGUAGE = :VFOREIGNLANGUAGE, VVIPNO = :VVIPNO, VENGLISHNAME = :VENGLISHNAME, VREMARKS = :VREMARKS, NCOUNTRY = :NCOUNTRY, NPROVINCES = :NPROVINCES, NCITY = :NCITY, NSTREET = :NSTREET, NPROFESSIONID = :NPROFESSIONID, NIDENTITY = :NIDENTITY, VPRESENTADDRESS = :VPRESENTADDRESS, VISITNO = :VISITNO, NMARRY = :NMARRY, VORGAN = :VORGAN, NDICAREAID = :NDICAREAID, VDIAGNOSE = :VDIAGNOSE, NDISEASEID = :NDISEASEID, NZYZEXZ = :NZYZEXZ, NZYYPXZ = :NZYYPXZ   WHERE  VPATIENTID = :OLDVPATIENTID";
					
			m_Params.AddParam("VPATIENTID", "VPATIENTID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("DCREATEDATE", "DCREATEDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VNAME", "VNAME", DataRowVersion.Current, OracleType.NVarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("PINYINMA", "PINYINMA", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("WUBIMA", "WUBIMA", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("NSEX", "NSEX", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DBIRTHDATE", "DBIRTHDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VBIRTHPLACE", "VBIRTHPLACE", DataRowVersion.Current, OracleType.VarChar, 6, ParameterDirection.Input, null);		
			m_Params.AddParam("VBIRTHPLACEDETAIL", "VBIRTHPLACEDETAIL", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VNATION", "VNATION", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VNATIONNAME", "VNATIONNAME", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VIDTYPE", "VIDTYPE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VIDNO", "VIDNO", DataRowVersion.Current, OracleType.VarChar, 18, ParameterDirection.Input, null);		
			m_Params.AddParam("VUNITINCONTRACT", "VUNITINCONTRACT", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VUNITINCONTRACTNAME", "VUNITINCONTRACTNAME", DataRowVersion.Current, OracleType.NVarChar, 200, ParameterDirection.Input, null);		
			m_Params.AddParam("VMAILINGADDRESS", "VMAILINGADDRESS", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VZIPID", "VZIPID", DataRowVersion.Current, OracleType.VarChar, 6, ParameterDirection.Input, null);		
			m_Params.AddParam("VPHONENUMBERHOME", "VPHONENUMBERHOME", DataRowVersion.Current, OracleType.VarChar, 16, ParameterDirection.Input, null);		
			m_Params.AddParam("VPHONENUMBERBUSINESS", "VPHONENUMBERBUSINESS", DataRowVersion.Current, OracleType.VarChar, 16, ParameterDirection.Input, null);		
			m_Params.AddParam("VLINKMAN", "VLINKMAN", DataRowVersion.Current, OracleType.NVarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VRELATIONSHIP", "VRELATIONSHIP", DataRowVersion.Current, OracleType.VarChar, 2, ParameterDirection.Input, null);		
			m_Params.AddParam("VNEXTOFKINADDR", "VNEXTOFKINADDR", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VNEXTOFKINZIPID", "VNEXTOFKINZIPID", DataRowVersion.Current, OracleType.VarChar, 6, ParameterDirection.Input, null);		
			m_Params.AddParam("VPHONE", "VPHONE", DataRowVersion.Current, OracleType.VarChar, 16, ParameterDirection.Input, null);		
			m_Params.AddParam("DLASTVISITDATE", "DLASTVISITDATE", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NVIPINDICATOR", "NVIPINDICATOR", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VOPERATORID", "VOPERATORID", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEGREE", "VDEGREE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VRACE", "VRACE", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VRELIGION", "VRELIGION", DataRowVersion.Current, OracleType.VarChar, 16, ParameterDirection.Input, null);		
			m_Params.AddParam("VMOTHERLANGUAGE", "VMOTHERLANGUAGE", DataRowVersion.Current, OracleType.VarChar, 16, ParameterDirection.Input, null);		
			m_Params.AddParam("VFOREIGNLANGUAGE", "VFOREIGNLANGUAGE", DataRowVersion.Current, OracleType.VarChar, 16, ParameterDirection.Input, null);		
			m_Params.AddParam("VVIPNO", "VVIPNO", DataRowVersion.Current, OracleType.VarChar, 18, ParameterDirection.Input, null);		
			m_Params.AddParam("VENGLISHNAME", "VENGLISHNAME", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VREMARKS", "VREMARKS", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NCOUNTRY", "NCOUNTRY", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NPROVINCES", "NPROVINCES", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCITY", "NCITY", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NSTREET", "NSTREET", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NPROFESSIONID", "NPROFESSIONID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NIDENTITY", "NIDENTITY", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VPRESENTADDRESS", "VPRESENTADDRESS", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("VISITNO", "VISITNO", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("NMARRY", "NMARRY", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VORGAN", "VORGAN", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NDICAREAID", "NDICAREAID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VDIAGNOSE", "VDIAGNOSE", DataRowVersion.Current, OracleType.VarChar, 100, ParameterDirection.Input, null);		
			m_Params.AddParam("NDISEASEID", "NDISEASEID", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NZYZEXZ", "NZYZEXZ", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NZYYPXZ", "NZYYPXZ", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDVPATIENTID", "VPATIENTID", DataRowVersion.Original, OracleType.VarChar, 10, ParameterDirection.Input, null);
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
				
		public System.String VBIRTHPLACE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VBIRTHPLACE"].Value, "System.String");
			}
			set
			{
				m_Params["VBIRTHPLACE"].Value = value;
			}
		}
				
		public System.String VBIRTHPLACEDETAIL
		{
			get
			{
				return (System.String)ConverValue(m_Params["VBIRTHPLACEDETAIL"].Value, "System.String");
			}
			set
			{
				m_Params["VBIRTHPLACEDETAIL"].Value = value;
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
				
		public System.String VNATIONNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNATIONNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VNATIONNAME"].Value = value;
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
				
		public System.String VUNITINCONTRACTNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VUNITINCONTRACTNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VUNITINCONTRACTNAME"].Value = value;
			}
		}
				
		public System.String VMAILINGADDRESS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VMAILINGADDRESS"].Value, "System.String");
			}
			set
			{
				m_Params["VMAILINGADDRESS"].Value = value;
			}
		}
				
		public System.String VZIPID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VZIPID"].Value, "System.String");
			}
			set
			{
				m_Params["VZIPID"].Value = value;
			}
		}
				
		public System.String VPHONENUMBERHOME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPHONENUMBERHOME"].Value, "System.String");
			}
			set
			{
				m_Params["VPHONENUMBERHOME"].Value = value;
			}
		}
				
		public System.String VPHONENUMBERBUSINESS
		{
			get
			{
				return (System.String)ConverValue(m_Params["VPHONENUMBERBUSINESS"].Value, "System.String");
			}
			set
			{
				m_Params["VPHONENUMBERBUSINESS"].Value = value;
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
				
		public System.String VRELATIONSHIP
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRELATIONSHIP"].Value, "System.String");
			}
			set
			{
				m_Params["VRELATIONSHIP"].Value = value;
			}
		}
				
		public System.String VNEXTOFKINADDR
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNEXTOFKINADDR"].Value, "System.String");
			}
			set
			{
				m_Params["VNEXTOFKINADDR"].Value = value;
			}
		}
				
		public System.String VNEXTOFKINZIPID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VNEXTOFKINZIPID"].Value, "System.String");
			}
			set
			{
				m_Params["VNEXTOFKINZIPID"].Value = value;
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
				
		public System.DateTime DLASTVISITDATE
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DLASTVISITDATE"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DLASTVISITDATE"].Value = value;
			}
		}
				
		public System.Decimal NVIPINDICATOR
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NVIPINDICATOR"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NVIPINDICATOR"].Value = value;
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
				
		public System.String VDEGREE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEGREE"].Value, "System.String");
			}
			set
			{
				m_Params["VDEGREE"].Value = value;
			}
		}
				
		public System.String VRACE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRACE"].Value, "System.String");
			}
			set
			{
				m_Params["VRACE"].Value = value;
			}
		}
				
		public System.String VRELIGION
		{
			get
			{
				return (System.String)ConverValue(m_Params["VRELIGION"].Value, "System.String");
			}
			set
			{
				m_Params["VRELIGION"].Value = value;
			}
		}
				
		public System.String VMOTHERLANGUAGE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VMOTHERLANGUAGE"].Value, "System.String");
			}
			set
			{
				m_Params["VMOTHERLANGUAGE"].Value = value;
			}
		}
				
		public System.String VFOREIGNLANGUAGE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VFOREIGNLANGUAGE"].Value, "System.String");
			}
			set
			{
				m_Params["VFOREIGNLANGUAGE"].Value = value;
			}
		}
				
		public System.String VVIPNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VVIPNO"].Value, "System.String");
			}
			set
			{
				m_Params["VVIPNO"].Value = value;
			}
		}
				
		public System.String VENGLISHNAME
		{
			get
			{
				return (System.String)ConverValue(m_Params["VENGLISHNAME"].Value, "System.String");
			}
			set
			{
				m_Params["VENGLISHNAME"].Value = value;
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
				
		public System.Decimal NCOUNTRY
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCOUNTRY"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCOUNTRY"].Value = value;
			}
		}
				
		public System.Decimal NPROVINCES
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPROVINCES"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPROVINCES"].Value = value;
			}
		}
				
		public System.Decimal NCITY
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NCITY"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NCITY"].Value = value;
			}
		}
				
		public System.Decimal NSTREET
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSTREET"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSTREET"].Value = value;
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
				
		public System.String VISITNO
		{
			get
			{
				return (System.String)ConverValue(m_Params["VISITNO"].Value, "System.String");
			}
			set
			{
				m_Params["VISITNO"].Value = value;
			}
		}
				
		public System.Decimal NMARRY
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NMARRY"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NMARRY"].Value = value;
			}
		}
				
		public System.String VORGAN
		{
			get
			{
				return (System.String)ConverValue(m_Params["VORGAN"].Value, "System.String");
			}
			set
			{
				m_Params["VORGAN"].Value = value;
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
				
		public System.Decimal NDISEASEID
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDISEASEID"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDISEASEID"].Value = value;
			}
		}
				
		public System.Decimal NZYZEXZ
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NZYZEXZ"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NZYZEXZ"].Value = value;
			}
		}
				
		public System.Decimal NZYYPXZ
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NZYYPXZ"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NZYYPXZ"].Value = value;
			}
		}
				
		public System.String OLDVPATIENTID
		{
			get
			{
				return (System.String)ConverValue(m_Params["OLDVPATIENTID"].Value, "System.String");
			}
			set
			{
				m_Params["OLDVPATIENTID"].Value = value;
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
	} // SS_UpdateGHSF_GHSF_PATIENTINFO
	#endregion
	
	#region SS_GHSF_PATIENTINFO_SelectByIDGHSF_GHSF_PATIENTINFO
	/// 
	/// 对于SelectByIDGHSF_GHSF_PATIENTINFO的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_PATIENTINFO_SelectByIDGHSF_GHSF_PATIENTINFO : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_PATIENTINFO_SelectByIDGHSF_GHSF_PATIENTINFO() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT VPATIENTID, DCREATEDATE, VNAME, PINYINMA, WUBIMA, NSEX, DBIRTHDATE, VBIRTHPLACE, VBIRTHPLACEDETAIL, VNATION, VNATIONNAME, VIDTYPE, VIDNO, VUNITINCONTRACT, VUNITINCONTRACTNAME, VMAILINGADDRESS, VZIPID, VPHONENUMBERHOME, VPHONENUMBERBUSINESS, VLINKMAN, VRELATIONSHIP, VNEXTOFKINADDR, VNEXTOFKINZIPID, VPHONE, DLASTVISITDATE, NVIPINDICATOR, VOPERATORID, VDEGREE, VRACE, VRELIGION, VMOTHERLANGUAGE, VFOREIGNLANGUAGE, VVIPNO, VENGLISHNAME, VREMARKS, NCOUNTRY, NPROVINCES, NCITY, NSTREET, NPROFESSIONID, NIDENTITY, VPRESENTADDRESS, VISITNO, NMARRY, VORGAN, NDICAREAID, VDIAGNOSE, NDISEASEID, NZYZEXZ, NZYYPXZ  FROM GHSF.GHSF_PATIENTINFO  WHERE  VPATIENTID = :VPATIENTID";
					
			m_Params.AddParam("VPATIENTID", "VPATIENTID", DataRowVersion.Current, OracleType.VarChar, 10, ParameterDirection.Input, null);
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
	} // SS_SelectByIDGHSF_GHSF_PATIENTINFO
	#endregion
	
	#region SS_GHSF_PATIENTINFO_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_GHSF_PATIENTINFO_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_GHSF_PATIENTINFO_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT * FROM GHSF.GHSF_PATIENTINFO  WHERE 1=1 ";
			
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
	