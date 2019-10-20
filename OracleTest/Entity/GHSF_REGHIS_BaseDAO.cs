//------------------------------------------------------------------------------
//     这部分代码属于实体控制层，是由实体编辑器工具自动产生的。
//     (Runtime Version: 2.2017.3.2)
//     对此代码进行的任何修改会导致其它的行为错误，并且重新生成时所有的修改会丢失。
//------------------------------------------------------------------------------

using System;
using System.Data;
using HYGHSF.Entity;
//using Gyd.TaskInfo;
using System.Collections;
using PhoenixDataBaseConnect;
using PhoenixDataBaseOperate;

namespace HYGHSF.DAO
{
	/// 
	/// 对于GHSF_REGHISBaseDAO的类的实现（基础控制部分）。
	/// 对于扩展的DAO的实现可以从这个类继承。
	/// 
	public class GHSF_REGHISBaseDAO : MarshalByRefObject , IDisposable
	{
		#region variable
		//protected IDataAccess db;
		protected IDataBaseOperate db;
	  //protected bool m_isNeedClose = true;
		private ArrayList alUpdateColumn = null;
		private ArrayList alUpdateControl = null;
				
		#endregion

		#region construct and dispose
		/// 
		/// 结构化一个BaseDAO。 
		/// 
		public GHSF_REGHISBaseDAO()
		{
			//db = DataAccessFactory.Create();
			db = GenerateFactory.GenerateConnect(0);
			//db.Open();
		}
		
		/// 
		/// 结构化一个BaseDAO。
		/// 
		/// 给定的数据库连接。
		
		//public GHSF_REGHISBaseDAO(IDataAccess cdb)
		public GHSF_REGHISBaseDAO(IDataBaseOperate cdb)
		{
			db = cdb;
			//if(db.State == ConnectionState.Closed)
			//{
			//	db.Open();
			//}
			//else
			//{
			//	m_isNeedClose = false;
			//}
		}
		
		////////new 返回接口类，用于传递到其它实体
		public IDataBaseOperate GetIDataBaseOperate
		{
			get{
				return db;
			}
		}
		
				
		public void Dispose()
		{
			//if(m_isNeedClose)
			//{
			//	db.Close();
			//}
			//GC.SuppressFinalize(true);
		}

		#endregion
		
		#region InsertEntity		
		
		/// 
		/// 插入一个GHSF_REGHIS实体到数据库。
		/// 
		/// 将要插入的实体
		public int InsertEntity(DataSetGHSF_REGHIS entity)
		{
			CheckData(entity);
			int iRtn=0;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			
			try
			{
				
				foreach(DataRow row in entity.Tables["GHSF_GHSF_REGHIS"].Rows)
				{	
					int j= db.exeSql(new SS_GHSF_REGHIS_InsertGHSF_GHSF_REGHIS(), row);
          iRtn=iRtn+j;
          }
        
				if(!isExistTrans)
				{
					db.CommitTrans();
				}
        return iRtn;
			}
			catch(Exception e)
			{
				if(!isExistTrans)
				{
					db.RollbackTrans();
				}
				throw e;
			}
		}		
	
		#endregion
		
		#region UpdateEntity		
		
		/// 
		/// 更新GHSF_REGHIS实体到数据库。
		/// 
		/// 将要更新的实体
		public int UpdateEntity(DataSetGHSF_REGHIS entity)
		{
			CheckData(entity);
			int iRtn=0;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			
			try
			{
				
				foreach(DataRow row in entity.Tables["GHSF_GHSF_REGHIS"].Rows)
        {
          int j =	db.exeSql(new SS_GHSF_REGHIS_UpdateGHSF_GHSF_REGHIS(), row);
          iRtn = iRtn+j;
          }
          
        if(!isExistTrans)
        {
        db.CommitTrans();
        }
        return iRtn;
      }
    catch(Exception e)
    {
    if(!isExistTrans)
    {
    db.RollbackTrans();
    }
    throw e;
    }
    }
  
		#endregion
		
		#region DeleteEntity		
		
		/// 
		/// 从数据库中删除GHSF_REGHIS实体。
		/// 
		/// 将要删除的实体
		public int DeleteEntity(DataSetGHSF_REGHIS entity)
		{
			CheckData(entity);
      int iRtn=0;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}

			try
			{
				
				foreach(DataRow row in entity.Tables["GHSF_GHSF_REGHIS"].Rows)
				{
					int j = db.exeSql(new SS_GHSF_REGHIS_DeleteGHSF_GHSF_REGHIS(), row);
          iRtn = iRtn+j;
         }
        
				if(!isExistTrans)
				{
					db.CommitTrans();
				}
        return iRtn;
			}
			catch(Exception e)
			{
				if(!isExistTrans)
				{
					db.RollbackTrans();
				}
				throw e;
			}
		}		
	
		#endregion
		
		#region FindByPrimaryKey		
		
		/// 
		/// 按照GHSF_REGHIS实体的主表的主键查询数据。
		/// 
		/// 主键的值
		public DataSetGHSF_REGHIS FindByPrimaryKey(object KeyValue)
		{
			DataSetGHSF_REGHIS entity = new DataSetGHSF_REGHIS();
			SS_GHSF_REGHIS_SelectByIDGHSF_GHSF_REGHIS ss = new SS_GHSF_REGHIS_SelectByIDGHSF_GHSF_REGHIS();
			ss.Params[0].Value = KeyValue;
			db.FillDataSet(ss, entity, "GHSF_GHSF_REGHIS");
					
			return entity;
		}
	
		#endregion

		#region CommitChanges
		/// 
		/// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
		/// 
		/// 要检验的实体
		/// 要检查更改的状态
		
		/// 2006-05-21
		public int CommitChanges(DataSetGHSF_REGHIS entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			db.SetUpdateControl(alUpdateControl);
			db.SetUpdateColumn(alUpdateColumn);
		  int iRet =	CommitChanges(entity, drs);
      db.SetUpdateControl(null);
			db.SetUpdateColumn(null);
      return iRet;
		}
		///////////////// 
		
				
		public int CommitChanges(DataSetGHSF_REGHIS entity, DataRowState drs)
		{
      int iRtn=0;
			if(!entity.HasChanges(drs)) return iRtn;
			CheckData(entity);
			
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
				
			try
			{		
				if(drs == DataRowState.Deleted)
					iRtn += DeleteEntity(entity.GetChangesEntity(drs));
				else if(drs == DataRowState.Modified)
					iRtn += UpdateEntity(entity.GetChangesEntity(drs));
				else if(drs == DataRowState.Added)
					iRtn += InsertEntity(entity.GetChangesEntity(drs));
				if(!isExistTrans)
				{
					db.CommitTrans();
				}
        return iRtn;
			}
			catch(Exception e)
			{
				if(isExistTrans)
				{
					db.RollbackTrans();
				}
				throw e;
			}				
		}
		
		/// 
		/// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。
		/// 
		/// 要检验的实体



    public int CommitChanges(DataSetGHSF_REGHIS entity)
		{
      int iRtn=0;
			if(!entity.HasChanges()) return iRtn;
			CheckData(entity);
		
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
				
			try
			{	
				//CommitChanges(entity, DataRowState.Deleted);
				//CommitChanges(entity, DataRowState.Modified);
				//CommitChanges(entity, DataRowState.Added);

				////////// 2006-05-21
			  iRtn +=	CommitChanges(entity, DataRowState.Deleted,null,null);
				iRtn += CommitChanges(entity, DataRowState.Modified,alUpdateColumn,alUpdateControl);
				iRtn += CommitChanges(entity, DataRowState.Added,null,null);
				/////////////
				
				if(!isExistTrans)
				{
					db.CommitTrans();
				}
        return iRtn;
			}
			catch(Exception e)
			{
				if(isExistTrans)
				{
					db.RollbackTrans();
				}
				throw e;
			}				
		}

		/// 2006-05-21
		/// 

		public int CommitChanges(DataSetGHSF_REGHIS entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			this.alUpdateColumn = alUpdateColumn;
			this.alUpdateControl = alUpdateControl;
		  return	CommitChanges(entity);
		}
		/////////////				
		#endregion

		//// 2006-09-11
		public DataSetGHSF_REGHIS GetDataSet(SqlClass sC,string sTableName)
		{
			DataSetGHSF_REGHIS ds = new  DataSetGHSF_REGHIS();
			db.FillDataSet(sC,ds,sTableName);
			return ds;
		}
		
		#region CheckData		
		/// 
		/// 校验数据输入的有效性。
		/// 
		/// 要检验的实体
		protected void CheckData(DataSetGHSF_REGHIS entity)
		{
			//在这里可以加入操作之前所需要对实体检验的代码
		}
		#endregion
		
		//wuqb modify 2007-03-27

		
		
		//强名DataSet
		
		#region Data_GHSF_REGHIS_SelectByIDGHSF_GHSF_REGHIS
		/// 
		/// 对于SelectByIDGHSF_GHSF_REGHIS的类的实现（数据库操作）。
		/// 
		public DataSetGHSF_REGHIS  Data_GHSF_REGHIS_SelectByIDGHSF_GHSF_REGHIS (System.String VCLINICNO)
		{
			DataSetGHSF_REGHIS ds = new DataSetGHSF_REGHIS();
			SS_GHSF_REGHIS_SelectByIDGHSF_GHSF_REGHIS ss = new SS_GHSF_REGHIS_SelectByIDGHSF_GHSF_REGHIS();
				
			ss.VCLINICNO = VCLINICNO;
			
			db.FillDataSet(ss,ds,"GHSF_GHSF_REGHIS");
			return ds;

		} // Data_SelectByIDGHSF_GHSF_REGHIS
		#endregion
		
		#region Data_GHSF_REGHIS_SelectAll
		/// 
		/// 对于SelectAll的类的实现（数据库操作）。
		/// 
		public DataSetGHSF_REGHIS  Data_GHSF_REGHIS_SelectAll ( string sTj )
		{
			DataSetGHSF_REGHIS ds = new DataSetGHSF_REGHIS();
			SS_GHSF_REGHIS_SelectAll ss = new SS_GHSF_REGHIS_SelectAll();
			
			ss.SqlString = ss.SqlString.Replace("1=1",sTj);
			
			db.FillDataSet(ss,ds,"GHSF_GHSF_REGHIS");
			return ds;

		} // Data_SelectAll
		#endregion
		
				
		//存储过程
		
		
		#region Data_GHSF_REGHIS_GHSF_FUN_GETVCLINICNOMZ
		/// 
		/// 对于GHSF_FUN_GETVCLINICNOMZ的类的实现（数据库操作）。
		/// 
		public System.String Data_GHSF_REGHIS_GHSF_FUN_GETVCLINICNOMZ ( System.String MPREFIX)
		{
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}		
			SS_GHSF_REGHIS_GHSF_FUN_GETVCLINICNOMZ ss = new SS_GHSF_REGHIS_GHSF_FUN_GETVCLINICNOMZ();
			
			ss.MPREFIX = MPREFIX;
			
			try
			{	
			  db.exeSql(ss);
			  if(!isExistTrans)
			  {
			    db.CommitTrans();
			  }
			}
			catch(Exception e)
			{
				if(isExistTrans)
				{
					db.RollbackTrans();
				}
				throw e;
			}			
			return (System.String) ss.RETURNVALUE; 
			
		} // Data_GHSF_FUN_GETVCLINICNOMZ
		#endregion	
			
		
		///update更新
		
		#region Data_GHSF_REGHIS_DeleteGHSF_GHSF_REGHIS
		/// 
		/// 对于DeleteGHSF_GHSF_REGHIS的类的实现（数据库操作）。
		/// 
		public int Data_GHSF_REGHIS_DeleteGHSF_GHSF_REGHIS ( System.String VCLINICNO)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_GHSF_REGHIS_DeleteGHSF_GHSF_REGHIS ss = new SS_GHSF_REGHIS_DeleteGHSF_GHSF_REGHIS();
				
			ss.VCLINICNO = VCLINICNO;
			
			try
			{	
			  iRtn = db.exeSql(ss);
			  if(!isExistTrans)
			  {
			    db.CommitTrans();
			  }
			}
			catch(Exception e)
			{
				if(isExistTrans)
				{
					db.RollbackTrans();
				}
				throw e;
			}				
			return iRtn;
		} // Data_DeleteGHSF_GHSF_REGHIS
		#endregion	
		
		#region Data_GHSF_REGHIS_UpdateGHSF_GHSF_REGHIS
		/// 
		/// 对于UpdateGHSF_GHSF_REGHIS的类的实现（数据库操作）。
		/// 
		public int Data_GHSF_REGHIS_UpdateGHSF_GHSF_REGHIS ( System.String VCLINICNO , System.DateTime DVISITDATE , System.Decimal NVISITNO , System.String VAPPTIME , System.String VPATIENTID , System.String VNAME , System.String PINYINMA , System.String WUBIMA , System.Decimal NSEX , System.String NAGE , System.DateTime DBIRTHDATE , System.String NIDENTITY , System.Decimal NCHARGETYPE , System.String VINSURANCETY , System.String VINSURANCEN , System.String VUNITINCONTRACT , System.Decimal NCLINICTYPE , System.Decimal NCFIRSTVISITIND , System.String VVISITDEPT , System.String VDOCTOR , System.Decimal NMRPROVIDEINDICATOR , System.Decimal NREGSTATUS , System.String VOPERATORID , System.DateTime DREGDATE , System.String VSYMPTOM , System.Decimal NREGISTFEE , System.Decimal NCLINICFEE , System.Decimal NOTHERFEE , System.Decimal NCLINICCHARG , System.DateTime DRETURNDATE , System.String VIDTYPE , System.String VIDNO , System.String VRETURNID , System.Decimal NMODEID , System.String VCARDNO , System.DateTime DACCTDATETI , System.String DACCTNO , System.Decimal NMRPROVIDEDINDICATOR , System.String VAPPOINTSID , System.String VREMARKS , System.String VNATION , System.String VNATIVEPLACE , System.String VPRESENTADDRESS , System.String VLINKMAN , System.String VPHONE , System.Decimal NKA , System.Decimal NPROFESSIONID , System.Decimal NDICGHTYPE , System.String VBSETCARD , System.String PERSONACCOUNTINFO , System.String YBGRBH , System.Decimal NCHARGE , System.Decimal NHOSID , System.String PURCHASINGPERSONNAME , System.String PURCHASINGPERSONVIDNO , System.String PURCHASINGPERSONVPHONE , System.String RELATIONSHIPWITHPATIENTS , System.String YBLX , System.Decimal NDICAREAID , System.String NHREGNO , System.String BCJSFF , System.String NHLYZT , System.Decimal JSDISEASE , System.String VFIRST_VISITDEPT , System.String VFIRST_DOCTOR , System.String OLDVCLINICNO)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_GHSF_REGHIS_UpdateGHSF_GHSF_REGHIS ss = new SS_GHSF_REGHIS_UpdateGHSF_GHSF_REGHIS();
				
			ss.VCLINICNO = VCLINICNO;
				
			ss.DVISITDATE = DVISITDATE;
				
			ss.NVISITNO = NVISITNO;
				
			ss.VAPPTIME = VAPPTIME;
				
			ss.VPATIENTID = VPATIENTID;
				
			ss.VNAME = VNAME;
				
			ss.PINYINMA = PINYINMA;
				
			ss.WUBIMA = WUBIMA;
				
			ss.NSEX = NSEX;
				
			ss.NAGE = NAGE;
				
			ss.DBIRTHDATE = DBIRTHDATE;
				
			ss.NIDENTITY = NIDENTITY;
				
			ss.NCHARGETYPE = NCHARGETYPE;
				
			ss.VINSURANCETY = VINSURANCETY;
				
			ss.VINSURANCEN = VINSURANCEN;
				
			ss.VUNITINCONTRACT = VUNITINCONTRACT;
				
			ss.NCLINICTYPE = NCLINICTYPE;
				
			ss.NCFIRSTVISITIND = NCFIRSTVISITIND;
				
			ss.VVISITDEPT = VVISITDEPT;
				
			ss.VDOCTOR = VDOCTOR;
				
			ss.NMRPROVIDEINDICATOR = NMRPROVIDEINDICATOR;
				
			ss.NREGSTATUS = NREGSTATUS;
				
			ss.VOPERATORID = VOPERATORID;
				
			ss.DREGDATE = DREGDATE;
				
			ss.VSYMPTOM = VSYMPTOM;
				
			ss.NREGISTFEE = NREGISTFEE;
				
			ss.NCLINICFEE = NCLINICFEE;
				
			ss.NOTHERFEE = NOTHERFEE;
				
			ss.NCLINICCHARG = NCLINICCHARG;
				
			ss.DRETURNDATE = DRETURNDATE;
				
			ss.VIDTYPE = VIDTYPE;
				
			ss.VIDNO = VIDNO;
				
			ss.VRETURNID = VRETURNID;
				
			ss.NMODEID = NMODEID;
				
			ss.VCARDNO = VCARDNO;
				
			ss.DACCTDATETI = DACCTDATETI;
				
			ss.DACCTNO = DACCTNO;
				
			ss.NMRPROVIDEDINDICATOR = NMRPROVIDEDINDICATOR;
				
			ss.VAPPOINTSID = VAPPOINTSID;
				
			ss.VREMARKS = VREMARKS;
				
			ss.VNATION = VNATION;
				
			ss.VNATIVEPLACE = VNATIVEPLACE;
				
			ss.VPRESENTADDRESS = VPRESENTADDRESS;
				
			ss.VLINKMAN = VLINKMAN;
				
			ss.VPHONE = VPHONE;
				
			ss.NKA = NKA;
				
			ss.NPROFESSIONID = NPROFESSIONID;
				
			ss.NDICGHTYPE = NDICGHTYPE;
				
			ss.VBSETCARD = VBSETCARD;
				
			ss.PERSONACCOUNTINFO = PERSONACCOUNTINFO;
				
			ss.YBGRBH = YBGRBH;
				
			ss.NCHARGE = NCHARGE;
				
			ss.NHOSID = NHOSID;
				
			ss.PURCHASINGPERSONNAME = PURCHASINGPERSONNAME;
				
			ss.PURCHASINGPERSONVIDNO = PURCHASINGPERSONVIDNO;
				
			ss.PURCHASINGPERSONVPHONE = PURCHASINGPERSONVPHONE;
				
			ss.RELATIONSHIPWITHPATIENTS = RELATIONSHIPWITHPATIENTS;
				
			ss.YBLX = YBLX;
				
			ss.NDICAREAID = NDICAREAID;
				
			ss.NHREGNO = NHREGNO;
				
			ss.BCJSFF = BCJSFF;
				
			ss.NHLYZT = NHLYZT;
				
			ss.JSDISEASE = JSDISEASE;
				
			ss.VFIRST_VISITDEPT = VFIRST_VISITDEPT;
				
			ss.VFIRST_DOCTOR = VFIRST_DOCTOR;
				
			ss.OLDVCLINICNO = OLDVCLINICNO;
			
			try
			{	
			  iRtn = db.exeSql(ss);
			  if(!isExistTrans)
			  {
			    db.CommitTrans();
			  }
			}
			catch(Exception e)
			{
				if(isExistTrans)
				{
					db.RollbackTrans();
				}
				throw e;
			}				
			return iRtn;
		} // Data_UpdateGHSF_GHSF_REGHIS
		#endregion	
			
				
		//end modify
	}
}
	