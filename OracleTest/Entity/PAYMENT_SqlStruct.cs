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
	
	#region SS_PAYMENT_InsertPAYMENT
	/// 
	/// 对于InsertPAYMENT的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_PAYMENT_InsertPAYMENT : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_PAYMENT_InsertPAYMENT() : base()
		{  
			m_SqlName = "";

			m_SqlString = "INSERT INTO PAYMENT  (NGHF, NZLF, VSPMC, VPHONE, DZFRQ, VHAOBIE, VDDLSH, VNAME, VCLINICNO, VCARD, VSFZH, VDEPT, VDOCTOR, DDDRQ, NCOSTS, NDDLX, VREMARKS, NSTATE, DJZRQ, NDEL, VAPPTIME, VHZID, NPAYTYPE)  VALUES (:NGHF, :NZLF, :VSPMC, :VPHONE, :DZFRQ, :VHAOBIE, :VDDLSH, :VNAME, :VCLINICNO, :VCARD, :VSFZH, :VDEPT, :VDOCTOR, :DDDRQ, :NCOSTS, :NDDLX, :VREMARKS, :NSTATE, :DJZRQ, :NDEL, :VAPPTIME, :VHZID, :NPAYTYPE)";
					
			m_Params.AddParam("NGHF", "NGHF", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NZLF", "NZLF", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VSPMC", "VSPMC", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VPHONE", "VPHONE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("DZFRQ", "DZFRQ", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VHAOBIE", "VHAOBIE", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VDDLSH", "VDDLSH", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VNAME", "VNAME", DataRowVersion.Current, OracleType.NVarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VCLINICNO", "VCLINICNO", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VCARD", "VCARD", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VSFZH", "VSFZH", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPT", "VDEPT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VDOCTOR", "VDOCTOR", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("DDDRQ", "DDDRQ", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCOSTS", "NCOSTS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NDDLX", "NDDLX", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VREMARKS", "VREMARKS", DataRowVersion.Current, OracleType.VarChar, 200, ParameterDirection.Input, null);		
			m_Params.AddParam("NSTATE", "NSTATE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DJZRQ", "DJZRQ", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NDEL", "NDEL", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VAPPTIME", "VAPPTIME", DataRowVersion.Current, OracleType.VarChar, 8, ParameterDirection.Input, null);		
			m_Params.AddParam("VHZID", "VHZID", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NPAYTYPE", "NPAYTYPE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);
		}
				
		public System.Decimal NGHF
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NGHF"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NGHF"].Value = value;
			}
		}
				
		public System.Decimal NZLF
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NZLF"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NZLF"].Value = value;
			}
		}
				
		public System.String VSPMC
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSPMC"].Value, "System.String");
			}
			set
			{
				m_Params["VSPMC"].Value = value;
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
				
		public System.DateTime DZFRQ
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DZFRQ"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DZFRQ"].Value = value;
			}
		}
				
		public System.String VHAOBIE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VHAOBIE"].Value, "System.String");
			}
			set
			{
				m_Params["VHAOBIE"].Value = value;
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
				
		public System.String VCARD
		{
			get
			{
				return (System.String)ConverValue(m_Params["VCARD"].Value, "System.String");
			}
			set
			{
				m_Params["VCARD"].Value = value;
			}
		}
				
		public System.String VSFZH
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSFZH"].Value, "System.String");
			}
			set
			{
				m_Params["VSFZH"].Value = value;
			}
		}
				
		public System.String VDEPT
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEPT"].Value, "System.String");
			}
			set
			{
				m_Params["VDEPT"].Value = value;
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
				
		public System.DateTime DDDRQ
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DDDRQ"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DDDRQ"].Value = value;
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
				
		public System.Decimal NDDLX
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDDLX"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDDLX"].Value = value;
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
				
		public System.Decimal NSTATE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSTATE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSTATE"].Value = value;
			}
		}
				
		public System.DateTime DJZRQ
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DJZRQ"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DJZRQ"].Value = value;
			}
		}
				
		public System.Decimal NDEL
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDEL"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDEL"].Value = value;
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
				
		public System.String VHZID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VHZID"].Value, "System.String");
			}
			set
			{
				m_Params["VHZID"].Value = value;
			}
		}
				
		public System.Decimal NPAYTYPE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPAYTYPE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPAYTYPE"].Value = value;
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
	} // SS_InsertPAYMENT
	#endregion
	
	#region SS_PAYMENT_DeletePAYMENT
	/// 
	/// 对于DeletePAYMENT的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_PAYMENT_DeletePAYMENT : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_PAYMENT_DeletePAYMENT() : base()
		{  
			m_SqlName = "";

			m_SqlString = "DELETE FROM PAYMENT  WHERE  VDDLSH = :VDDLSH";
					
			m_Params.AddParam("VDDLSH", "VDDLSH", DataRowVersion.Original, OracleType.VarChar, 50, ParameterDirection.Input, null);
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
	} // SS_DeletePAYMENT
	#endregion
	
	#region SS_PAYMENT_UpdatePAYMENT
	/// 
	/// 对于UpdatePAYMENT的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_PAYMENT_UpdatePAYMENT : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_PAYMENT_UpdatePAYMENT() : base()
		{  
			m_SqlName = "";

			m_SqlString = "UPDATE PAYMENT  SET  NGHF = :NGHF, NZLF = :NZLF, VSPMC = :VSPMC, VPHONE = :VPHONE, DZFRQ = :DZFRQ, VHAOBIE = :VHAOBIE, VDDLSH = :VDDLSH, VNAME = :VNAME, VCLINICNO = :VCLINICNO, VCARD = :VCARD, VSFZH = :VSFZH, VDEPT = :VDEPT, VDOCTOR = :VDOCTOR, DDDRQ = :DDDRQ, NCOSTS = :NCOSTS, NDDLX = :NDDLX, VREMARKS = :VREMARKS, NSTATE = :NSTATE, DJZRQ = :DJZRQ, NDEL = :NDEL, VAPPTIME = :VAPPTIME, VHZID = :VHZID, NPAYTYPE = :NPAYTYPE   WHERE  VDDLSH = :OLDVDDLSH";
					
			m_Params.AddParam("NGHF", "NGHF", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NZLF", "NZLF", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VSPMC", "VSPMC", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VPHONE", "VPHONE", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("DZFRQ", "DZFRQ", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VHAOBIE", "VHAOBIE", DataRowVersion.Current, OracleType.NVarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VDDLSH", "VDDLSH", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("VNAME", "VNAME", DataRowVersion.Current, OracleType.NVarChar, 10, ParameterDirection.Input, null);		
			m_Params.AddParam("VCLINICNO", "VCLINICNO", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VCARD", "VCARD", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VSFZH", "VSFZH", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VDEPT", "VDEPT", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("VDOCTOR", "VDOCTOR", DataRowVersion.Current, OracleType.VarChar, 20, ParameterDirection.Input, null);		
			m_Params.AddParam("DDDRQ", "DDDRQ", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NCOSTS", "NCOSTS", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NDDLX", "NDDLX", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VREMARKS", "VREMARKS", DataRowVersion.Current, OracleType.VarChar, 200, ParameterDirection.Input, null);		
			m_Params.AddParam("NSTATE", "NSTATE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("DJZRQ", "DJZRQ", DataRowVersion.Current, OracleType.DateTime, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("NDEL", "NDEL", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("VAPPTIME", "VAPPTIME", DataRowVersion.Current, OracleType.VarChar, 8, ParameterDirection.Input, null);		
			m_Params.AddParam("VHZID", "VHZID", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);		
			m_Params.AddParam("NPAYTYPE", "NPAYTYPE", DataRowVersion.Current, OracleType.Number, -1, ParameterDirection.Input, null);		
			m_Params.AddParam("OLDVDDLSH", "VDDLSH", DataRowVersion.Original, OracleType.VarChar, 50, ParameterDirection.Input, null);
		}
				
		public System.Decimal NGHF
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NGHF"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NGHF"].Value = value;
			}
		}
				
		public System.Decimal NZLF
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NZLF"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NZLF"].Value = value;
			}
		}
				
		public System.String VSPMC
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSPMC"].Value, "System.String");
			}
			set
			{
				m_Params["VSPMC"].Value = value;
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
				
		public System.DateTime DZFRQ
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DZFRQ"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DZFRQ"].Value = value;
			}
		}
				
		public System.String VHAOBIE
		{
			get
			{
				return (System.String)ConverValue(m_Params["VHAOBIE"].Value, "System.String");
			}
			set
			{
				m_Params["VHAOBIE"].Value = value;
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
				
		public System.String VCARD
		{
			get
			{
				return (System.String)ConverValue(m_Params["VCARD"].Value, "System.String");
			}
			set
			{
				m_Params["VCARD"].Value = value;
			}
		}
				
		public System.String VSFZH
		{
			get
			{
				return (System.String)ConverValue(m_Params["VSFZH"].Value, "System.String");
			}
			set
			{
				m_Params["VSFZH"].Value = value;
			}
		}
				
		public System.String VDEPT
		{
			get
			{
				return (System.String)ConverValue(m_Params["VDEPT"].Value, "System.String");
			}
			set
			{
				m_Params["VDEPT"].Value = value;
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
				
		public System.DateTime DDDRQ
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DDDRQ"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DDDRQ"].Value = value;
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
				
		public System.Decimal NDDLX
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDDLX"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDDLX"].Value = value;
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
				
		public System.Decimal NSTATE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NSTATE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NSTATE"].Value = value;
			}
		}
				
		public System.DateTime DJZRQ
		{
			get
			{
				return (System.DateTime)ConverValue(m_Params["DJZRQ"].Value, "System.DateTime");
			}
			set
			{
				m_Params["DJZRQ"].Value = value;
			}
		}
				
		public System.Decimal NDEL
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NDEL"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NDEL"].Value = value;
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
				
		public System.String VHZID
		{
			get
			{
				return (System.String)ConverValue(m_Params["VHZID"].Value, "System.String");
			}
			set
			{
				m_Params["VHZID"].Value = value;
			}
		}
				
		public System.Decimal NPAYTYPE
		{
			get
			{
				return (System.Decimal)ConverValue(m_Params["NPAYTYPE"].Value, "System.Decimal");
			}
			set
			{
				m_Params["NPAYTYPE"].Value = value;
			}
		}
				
		public System.String OLDVDDLSH
		{
			get
			{
				return (System.String)ConverValue(m_Params["OLDVDDLSH"].Value, "System.String");
			}
			set
			{
				m_Params["OLDVDDLSH"].Value = value;
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
	} // SS_UpdatePAYMENT
	#endregion
	
	#region SS_PAYMENT_SelectByIDPAYMENT
	/// 
	/// 对于SelectByIDPAYMENT的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_PAYMENT_SelectByIDPAYMENT : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_PAYMENT_SelectByIDPAYMENT() : base()
		{  
			m_SqlName = "";

			m_SqlString = "SELECT NGHF, NZLF, VSPMC, VPHONE, DZFRQ, VHAOBIE, VDDLSH, VNAME, VCLINICNO, VCARD, VSFZH, VDEPT, VDOCTOR, DDDRQ, NCOSTS, NDDLX, VREMARKS, NSTATE, DJZRQ, NDEL, VAPPTIME, VHZID, NPAYTYPE  FROM PAYMENT  WHERE  VDDLSH = :VDDLSH";
					
			m_Params.AddParam("VDDLSH", "VDDLSH", DataRowVersion.Current, OracleType.VarChar, 50, ParameterDirection.Input, null);
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
	} // SS_SelectByIDPAYMENT
	#endregion
	
	#region SS_PAYMENT_SelectAll
	/// 
	/// 对于SelectAll的类的实现（数据库操作）。
	/// 
	[Serializable] 
	public class SS_PAYMENT_SelectAll : SqlClass
	{
		///数据库操作结构的构造函数。
		public SS_PAYMENT_SelectAll() : base()
		{  
			m_SqlName = "";

			m_SqlString = "select * from payment where 1=1";
			
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
	