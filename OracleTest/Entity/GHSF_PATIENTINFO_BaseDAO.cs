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
	/// 对于GHSF_PATIENTINFOBaseDAO的类的实现（基础控制部分）。
	/// 对于扩展的DAO的实现可以从这个类继承。
	/// 
	public class GHSF_PATIENTINFOBaseDAO : MarshalByRefObject , IDisposable
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
		public GHSF_PATIENTINFOBaseDAO()
		{
			//db = DataAccessFactory.Create();
			db = GenerateFactory.GenerateConnect(0);
			//db.Open();
		}
		
		/// 
		/// 结构化一个BaseDAO。
		/// 
		/// 给定的数据库连接。
		
		//public GHSF_PATIENTINFOBaseDAO(IDataAccess cdb)
		public GHSF_PATIENTINFOBaseDAO(IDataBaseOperate cdb)
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
		/// 插入一个GHSF_PATIENTINFO实体到数据库。
		/// 
		/// 将要插入的实体
		public int InsertEntity(DataSetGHSF_PATIENTINFO entity)
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
				
				foreach(DataRow row in entity.Tables["GHSF_GHSF_PATIENTINFO"].Rows)
				{	
					int j= db.exeSql(new SS_GHSF_PATIENTINFO_InsertGHSF_GHSF_PATIENTINFO(), row);
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
		/// 更新GHSF_PATIENTINFO实体到数据库。
		/// 
		/// 将要更新的实体
		public int UpdateEntity(DataSetGHSF_PATIENTINFO entity)
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
				
				foreach(DataRow row in entity.Tables["GHSF_GHSF_PATIENTINFO"].Rows)
        {
          int j =	db.exeSql(new SS_GHSF_PATIENTINFO_UpdateGHSF_GHSF_PATIENTINFO(), row);
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
		/// 从数据库中删除GHSF_PATIENTINFO实体。
		/// 
		/// 将要删除的实体
		public int DeleteEntity(DataSetGHSF_PATIENTINFO entity)
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
				
				foreach(DataRow row in entity.Tables["GHSF_GHSF_PATIENTINFO"].Rows)
				{
					int j = db.exeSql(new SS_GHSF_PATIENTINFO_DeleteGHSF_GHSF_PATIENTINFO(), row);
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
		/// 按照GHSF_PATIENTINFO实体的主表的主键查询数据。
		/// 
		/// 主键的值
		public DataSetGHSF_PATIENTINFO FindByPrimaryKey(object KeyValue)
		{
			DataSetGHSF_PATIENTINFO entity = new DataSetGHSF_PATIENTINFO();
			SS_GHSF_PATIENTINFO_SelectByIDGHSF_GHSF_PATIENTINFO ss = new SS_GHSF_PATIENTINFO_SelectByIDGHSF_GHSF_PATIENTINFO();
			ss.Params[0].Value = KeyValue;
			db.FillDataSet(ss, entity, "GHSF_GHSF_PATIENTINFO");
					
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
		public int CommitChanges(DataSetGHSF_PATIENTINFO entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			db.SetUpdateControl(alUpdateControl);
			db.SetUpdateColumn(alUpdateColumn);
		  int iRet =	CommitChanges(entity, drs);
      db.SetUpdateControl(null);
			db.SetUpdateColumn(null);
      return iRet;
		}
		///////////////// 
		
				
		public int CommitChanges(DataSetGHSF_PATIENTINFO entity, DataRowState drs)
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



    public int CommitChanges(DataSetGHSF_PATIENTINFO entity)
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

		public int CommitChanges(DataSetGHSF_PATIENTINFO entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			this.alUpdateColumn = alUpdateColumn;
			this.alUpdateControl = alUpdateControl;
		  return	CommitChanges(entity);
		}
		/////////////				
		#endregion

		//// 2006-09-11
		public DataSetGHSF_PATIENTINFO GetDataSet(SqlClass sC,string sTableName)
		{
			DataSetGHSF_PATIENTINFO ds = new  DataSetGHSF_PATIENTINFO();
			db.FillDataSet(sC,ds,sTableName);
			return ds;
		}
		
		#region CheckData		
		/// 
		/// 校验数据输入的有效性。
		/// 
		/// 要检验的实体
		protected void CheckData(DataSetGHSF_PATIENTINFO entity)
		{
			//在这里可以加入操作之前所需要对实体检验的代码
		}
		#endregion
		
		//wuqb modify 2007-03-27

		
		
		//强名DataSet
		
		#region Data_GHSF_PATIENTINFO_SelectByIDGHSF_GHSF_PATIENTINFO
		/// 
		/// 对于SelectByIDGHSF_GHSF_PATIENTINFO的类的实现（数据库操作）。
		/// 
		public DataSetGHSF_PATIENTINFO  Data_GHSF_PATIENTINFO_SelectByIDGHSF_GHSF_PATIENTINFO (System.String VPATIENTID)
		{
			DataSetGHSF_PATIENTINFO ds = new DataSetGHSF_PATIENTINFO();
			SS_GHSF_PATIENTINFO_SelectByIDGHSF_GHSF_PATIENTINFO ss = new SS_GHSF_PATIENTINFO_SelectByIDGHSF_GHSF_PATIENTINFO();
				
			ss.VPATIENTID = VPATIENTID;
			
			db.FillDataSet(ss,ds,"GHSF_GHSF_PATIENTINFO");
			return ds;

		} // Data_SelectByIDGHSF_GHSF_PATIENTINFO
		#endregion
		
		#region Data_GHSF_PATIENTINFO_SelectAll
		/// 
		/// 对于SelectAll的类的实现（数据库操作）。
		/// 
		public DataSetGHSF_PATIENTINFO  Data_GHSF_PATIENTINFO_SelectAll ( string sTj )
		{
			DataSetGHSF_PATIENTINFO ds = new DataSetGHSF_PATIENTINFO();
			SS_GHSF_PATIENTINFO_SelectAll ss = new SS_GHSF_PATIENTINFO_SelectAll();
			
			ss.SqlString = ss.SqlString.Replace("1=1",sTj);
			
			db.FillDataSet(ss,ds,"GHSF_GHSF_PATIENTINFO");
			return ds;

		} // Data_SelectAll
		#endregion
		
				
		//存储过程
		
			
		
		///update更新
		
		#region Data_GHSF_PATIENTINFO_DeleteGHSF_GHSF_PATIENTINFO
		/// 
		/// 对于DeleteGHSF_GHSF_PATIENTINFO的类的实现（数据库操作）。
		/// 
		public int Data_GHSF_PATIENTINFO_DeleteGHSF_GHSF_PATIENTINFO ( System.String VPATIENTID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_GHSF_PATIENTINFO_DeleteGHSF_GHSF_PATIENTINFO ss = new SS_GHSF_PATIENTINFO_DeleteGHSF_GHSF_PATIENTINFO();
				
			ss.VPATIENTID = VPATIENTID;
			
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
		} // Data_DeleteGHSF_GHSF_PATIENTINFO
		#endregion	
		
		#region Data_GHSF_PATIENTINFO_UpdateGHSF_GHSF_PATIENTINFO
		/// 
		/// 对于UpdateGHSF_GHSF_PATIENTINFO的类的实现（数据库操作）。
		/// 
		public int Data_GHSF_PATIENTINFO_UpdateGHSF_GHSF_PATIENTINFO ( System.String VPATIENTID , System.DateTime DCREATEDATE , System.String VNAME , System.String PINYINMA , System.String WUBIMA , System.Decimal NSEX , System.DateTime DBIRTHDATE , System.String VBIRTHPLACE , System.String VBIRTHPLACEDETAIL , System.String VNATION , System.String VNATIONNAME , System.String VIDTYPE , System.String VIDNO , System.String VUNITINCONTRACT , System.String VUNITINCONTRACTNAME , System.String VMAILINGADDRESS , System.String VZIPID , System.String VPHONENUMBERHOME , System.String VPHONENUMBERBUSINESS , System.String VLINKMAN , System.String VRELATIONSHIP , System.String VNEXTOFKINADDR , System.String VNEXTOFKINZIPID , System.String VPHONE , System.DateTime DLASTVISITDATE , System.Decimal NVIPINDICATOR , System.String VOPERATORID , System.String VDEGREE , System.String VRACE , System.String VRELIGION , System.String VMOTHERLANGUAGE , System.String VFOREIGNLANGUAGE , System.String VVIPNO , System.String VENGLISHNAME , System.String VREMARKS , System.Decimal NCOUNTRY , System.Decimal NPROVINCES , System.Decimal NCITY , System.Decimal NSTREET , System.Decimal NPROFESSIONID , System.String NIDENTITY , System.String VPRESENTADDRESS , System.String VISITNO , System.Decimal NMARRY , System.String VORGAN , System.Decimal NDICAREAID , System.String VDIAGNOSE , System.Decimal NDISEASEID , System.Decimal NZYZEXZ , System.Decimal NZYYPXZ , System.String OLDVPATIENTID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_GHSF_PATIENTINFO_UpdateGHSF_GHSF_PATIENTINFO ss = new SS_GHSF_PATIENTINFO_UpdateGHSF_GHSF_PATIENTINFO();
				
			ss.VPATIENTID = VPATIENTID;
				
			ss.DCREATEDATE = DCREATEDATE;
				
			ss.VNAME = VNAME;
				
			ss.PINYINMA = PINYINMA;
				
			ss.WUBIMA = WUBIMA;
				
			ss.NSEX = NSEX;
				
			ss.DBIRTHDATE = DBIRTHDATE;
				
			ss.VBIRTHPLACE = VBIRTHPLACE;
				
			ss.VBIRTHPLACEDETAIL = VBIRTHPLACEDETAIL;
				
			ss.VNATION = VNATION;
				
			ss.VNATIONNAME = VNATIONNAME;
				
			ss.VIDTYPE = VIDTYPE;
				
			ss.VIDNO = VIDNO;
				
			ss.VUNITINCONTRACT = VUNITINCONTRACT;
				
			ss.VUNITINCONTRACTNAME = VUNITINCONTRACTNAME;
				
			ss.VMAILINGADDRESS = VMAILINGADDRESS;
				
			ss.VZIPID = VZIPID;
				
			ss.VPHONENUMBERHOME = VPHONENUMBERHOME;
				
			ss.VPHONENUMBERBUSINESS = VPHONENUMBERBUSINESS;
				
			ss.VLINKMAN = VLINKMAN;
				
			ss.VRELATIONSHIP = VRELATIONSHIP;
				
			ss.VNEXTOFKINADDR = VNEXTOFKINADDR;
				
			ss.VNEXTOFKINZIPID = VNEXTOFKINZIPID;
				
			ss.VPHONE = VPHONE;
				
			ss.DLASTVISITDATE = DLASTVISITDATE;
				
			ss.NVIPINDICATOR = NVIPINDICATOR;
				
			ss.VOPERATORID = VOPERATORID;
				
			ss.VDEGREE = VDEGREE;
				
			ss.VRACE = VRACE;
				
			ss.VRELIGION = VRELIGION;
				
			ss.VMOTHERLANGUAGE = VMOTHERLANGUAGE;
				
			ss.VFOREIGNLANGUAGE = VFOREIGNLANGUAGE;
				
			ss.VVIPNO = VVIPNO;
				
			ss.VENGLISHNAME = VENGLISHNAME;
				
			ss.VREMARKS = VREMARKS;
				
			ss.NCOUNTRY = NCOUNTRY;
				
			ss.NPROVINCES = NPROVINCES;
				
			ss.NCITY = NCITY;
				
			ss.NSTREET = NSTREET;
				
			ss.NPROFESSIONID = NPROFESSIONID;
				
			ss.NIDENTITY = NIDENTITY;
				
			ss.VPRESENTADDRESS = VPRESENTADDRESS;
				
			ss.VISITNO = VISITNO;
				
			ss.NMARRY = NMARRY;
				
			ss.VORGAN = VORGAN;
				
			ss.NDICAREAID = NDICAREAID;
				
			ss.VDIAGNOSE = VDIAGNOSE;
				
			ss.NDISEASEID = NDISEASEID;
				
			ss.NZYZEXZ = NZYZEXZ;
				
			ss.NZYYPXZ = NZYYPXZ;
				
			ss.OLDVPATIENTID = OLDVPATIENTID;
			
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
		} // Data_UpdateGHSF_GHSF_PATIENTINFO
		#endregion	
			
				
		//end modify
	}
}
	