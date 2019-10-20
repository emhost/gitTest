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
	/// 对于GHSF_CHARGEDETAILBaseDAO的类的实现（基础控制部分）。
	/// 对于扩展的DAO的实现可以从这个类继承。
	/// 
	public class GHSF_CHARGEDETAILBaseDAO : MarshalByRefObject , IDisposable
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
		public GHSF_CHARGEDETAILBaseDAO()
		{
			//db = DataAccessFactory.Create();
			db = GenerateFactory.GenerateConnect(0);
			//db.Open();
		}
		
		/// 
		/// 结构化一个BaseDAO。
		/// 
		/// 给定的数据库连接。
		
		//public GHSF_CHARGEDETAILBaseDAO(IDataAccess cdb)
		public GHSF_CHARGEDETAILBaseDAO(IDataBaseOperate cdb)
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
		/// 插入一个GHSF_CHARGEDETAIL实体到数据库。
		/// 
		/// 将要插入的实体
		public int InsertEntity(DataSetGHSF_CHARGEDETAIL entity)
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
				
				foreach(DataRow row in entity.Tables["GHSF_GHSF_CHARGEDETAIL"].Rows)
				{	
					int j= db.exeSql(new SS_GHSF_CHARGEDETAIL_InsertGHSF_GHSF_CHARGEDETAIL(), row);
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
		/// 更新GHSF_CHARGEDETAIL实体到数据库。
		/// 
		/// 将要更新的实体
		public int UpdateEntity(DataSetGHSF_CHARGEDETAIL entity)
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
				
				foreach(DataRow row in entity.Tables["GHSF_GHSF_CHARGEDETAIL"].Rows)
        {
          int j =	db.exeSql(new SS_GHSF_CHARGEDETAIL_UpdateGHSF_GHSF_CHARGEDETAIL(), row);
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
		/// 从数据库中删除GHSF_CHARGEDETAIL实体。
		/// 
		/// 将要删除的实体
		public int DeleteEntity(DataSetGHSF_CHARGEDETAIL entity)
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
				
				foreach(DataRow row in entity.Tables["GHSF_GHSF_CHARGEDETAIL"].Rows)
				{
					int j = db.exeSql(new SS_GHSF_CHARGEDETAIL_DeleteGHSF_GHSF_CHARGEDETAIL(), row);
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
		/// 按照GHSF_CHARGEDETAIL实体的主表的主键查询数据。
		/// 
		/// 主键的值
		public DataSetGHSF_CHARGEDETAIL FindByPrimaryKey(object KeyValue)
		{
			DataSetGHSF_CHARGEDETAIL entity = new DataSetGHSF_CHARGEDETAIL();
			SS_GHSF_CHARGEDETAIL_SelectByIDGHSF_GHSF_CHARGEDETAIL ss = new SS_GHSF_CHARGEDETAIL_SelectByIDGHSF_GHSF_CHARGEDETAIL();
			ss.Params[0].Value = KeyValue;
			db.FillDataSet(ss, entity, "GHSF_GHSF_CHARGEDETAIL");
					
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
		public int CommitChanges(DataSetGHSF_CHARGEDETAIL entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			db.SetUpdateControl(alUpdateControl);
			db.SetUpdateColumn(alUpdateColumn);
		  int iRet =	CommitChanges(entity, drs);
      db.SetUpdateControl(null);
			db.SetUpdateColumn(null);
      return iRet;
		}
		///////////////// 
		
				
		public int CommitChanges(DataSetGHSF_CHARGEDETAIL entity, DataRowState drs)
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



    public int CommitChanges(DataSetGHSF_CHARGEDETAIL entity)
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

		public int CommitChanges(DataSetGHSF_CHARGEDETAIL entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			this.alUpdateColumn = alUpdateColumn;
			this.alUpdateControl = alUpdateControl;
		  return	CommitChanges(entity);
		}
		/////////////				
		#endregion

		//// 2006-09-11
		public DataSetGHSF_CHARGEDETAIL GetDataSet(SqlClass sC,string sTableName)
		{
			DataSetGHSF_CHARGEDETAIL ds = new  DataSetGHSF_CHARGEDETAIL();
			db.FillDataSet(sC,ds,sTableName);
			return ds;
		}
		
		#region CheckData		
		/// 
		/// 校验数据输入的有效性。
		/// 
		/// 要检验的实体
		protected void CheckData(DataSetGHSF_CHARGEDETAIL entity)
		{
			//在这里可以加入操作之前所需要对实体检验的代码
		}
		#endregion
		
		//wuqb modify 2007-03-27

		
		
		//强名DataSet
		
		#region Data_GHSF_CHARGEDETAIL_SelectByIDGHSF_GHSF_CHARGEDETAIL
		/// 
		/// 对于SelectByIDGHSF_GHSF_CHARGEDETAIL的类的实现（数据库操作）。
		/// 
		public DataSetGHSF_CHARGEDETAIL  Data_GHSF_CHARGEDETAIL_SelectByIDGHSF_GHSF_CHARGEDETAIL (System.String VRCPTDETAILID)
		{
			DataSetGHSF_CHARGEDETAIL ds = new DataSetGHSF_CHARGEDETAIL();
			SS_GHSF_CHARGEDETAIL_SelectByIDGHSF_GHSF_CHARGEDETAIL ss = new SS_GHSF_CHARGEDETAIL_SelectByIDGHSF_GHSF_CHARGEDETAIL();
				
			ss.VRCPTDETAILID = VRCPTDETAILID;
			
			db.FillDataSet(ss,ds,"GHSF_GHSF_CHARGEDETAIL");
			return ds;

		} // Data_SelectByIDGHSF_GHSF_CHARGEDETAIL
		#endregion
		
		#region Data_GHSF_CHARGEDETAIL_SelectAll
		/// 
		/// 对于SelectAll的类的实现（数据库操作）。
		/// 
		public DataSetGHSF_CHARGEDETAIL  Data_GHSF_CHARGEDETAIL_SelectAll ( string sTj )
		{
			DataSetGHSF_CHARGEDETAIL ds = new DataSetGHSF_CHARGEDETAIL();
			SS_GHSF_CHARGEDETAIL_SelectAll ss = new SS_GHSF_CHARGEDETAIL_SelectAll();
			
			ss.SqlString = ss.SqlString.Replace("1=1",sTj);
			
			db.FillDataSet(ss,ds,"GHSF_GHSF_CHARGEDETAIL");
			return ds;

		} // Data_SelectAll
		#endregion
		
				
		//存储过程
		
			
		
		///update更新
		
		#region Data_GHSF_CHARGEDETAIL_DeleteGHSF_GHSF_CHARGEDETAIL
		/// 
		/// 对于DeleteGHSF_GHSF_CHARGEDETAIL的类的实现（数据库操作）。
		/// 
		public int Data_GHSF_CHARGEDETAIL_DeleteGHSF_GHSF_CHARGEDETAIL ( System.String VRCPTDETAILID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_GHSF_CHARGEDETAIL_DeleteGHSF_GHSF_CHARGEDETAIL ss = new SS_GHSF_CHARGEDETAIL_DeleteGHSF_GHSF_CHARGEDETAIL();
				
			ss.VRCPTDETAILID = VRCPTDETAILID;
			
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
		} // Data_DeleteGHSF_GHSF_CHARGEDETAIL
		#endregion	
		
		#region Data_GHSF_CHARGEDETAIL_UpdateGHSF_GHSF_CHARGEDETAIL
		/// 
		/// 对于UpdateGHSF_GHSF_CHARGEDETAIL的类的实现（数据库操作）。
		/// 
		public int Data_GHSF_CHARGEDETAIL_UpdateGHSF_GHSF_CHARGEDETAIL ( System.String VRCPTDETAILID , System.String VRCPTID , System.String VPRESC_ID , System.String VITEM_CODE , System.String VITEM_NAME , System.String VITEM_SPEC , System.String VUNITS , System.Decimal NACCOUNT , System.Decimal NDOSAGE , System.String VDOSAGE_UNITS , System.String VADMINISTRATION , System.String VFREQUENCY , System.Decimal NDAYS , System.Decimal NPRICE , System.Decimal NCOSTS , System.String VITEM_PRODUCT , System.Decimal NSALESCALE , System.Decimal NCHARGEFLAG , System.Decimal NMEDICINEFLAG , System.DateTime DMEDICINEDATE , System.Decimal NBACKDRUGFLAG , System.DateTime DBACKDRUGDATE , System.Decimal NHAVMED , System.String VREMARKS , System.Decimal NACCT_MODE1 , System.Decimal NACCT_MODE2 , System.Decimal NACCT_MONEY1 , System.Decimal NACCT_MONEY2 , System.String VPRINTEDRCPTNO , System.String VDRUG_STORAGE , System.Decimal NTOTALCHARGES , System.String VITEM_TYPE , System.Decimal NPRESC , System.Decimal NCOUNT , System.Decimal VISSELF , System.String VDEPT_CODE , System.String NDICTDETAIL_ID , System.String OLDVRCPTDETAILID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_GHSF_CHARGEDETAIL_UpdateGHSF_GHSF_CHARGEDETAIL ss = new SS_GHSF_CHARGEDETAIL_UpdateGHSF_GHSF_CHARGEDETAIL();
				
			ss.VRCPTDETAILID = VRCPTDETAILID;
				
			ss.VRCPTID = VRCPTID;
				
			ss.VPRESC_ID = VPRESC_ID;
				
			ss.VITEM_CODE = VITEM_CODE;
				
			ss.VITEM_NAME = VITEM_NAME;
				
			ss.VITEM_SPEC = VITEM_SPEC;
				
			ss.VUNITS = VUNITS;
				
			ss.NACCOUNT = NACCOUNT;
				
			ss.NDOSAGE = NDOSAGE;
				
			ss.VDOSAGE_UNITS = VDOSAGE_UNITS;
				
			ss.VADMINISTRATION = VADMINISTRATION;
				
			ss.VFREQUENCY = VFREQUENCY;
				
			ss.NDAYS = NDAYS;
				
			ss.NPRICE = NPRICE;
				
			ss.NCOSTS = NCOSTS;
				
			ss.VITEM_PRODUCT = VITEM_PRODUCT;
				
			ss.NSALESCALE = NSALESCALE;
				
			ss.NCHARGEFLAG = NCHARGEFLAG;
				
			ss.NMEDICINEFLAG = NMEDICINEFLAG;
				
			ss.DMEDICINEDATE = DMEDICINEDATE;
				
			ss.NBACKDRUGFLAG = NBACKDRUGFLAG;
				
			ss.DBACKDRUGDATE = DBACKDRUGDATE;
				
			ss.NHAVMED = NHAVMED;
				
			ss.VREMARKS = VREMARKS;
				
			ss.NACCT_MODE1 = NACCT_MODE1;
				
			ss.NACCT_MODE2 = NACCT_MODE2;
				
			ss.NACCT_MONEY1 = NACCT_MONEY1;
				
			ss.NACCT_MONEY2 = NACCT_MONEY2;
				
			ss.VPRINTEDRCPTNO = VPRINTEDRCPTNO;
				
			ss.VDRUG_STORAGE = VDRUG_STORAGE;
				
			ss.NTOTALCHARGES = NTOTALCHARGES;
				
			ss.VITEM_TYPE = VITEM_TYPE;
				
			ss.NPRESC = NPRESC;
				
			ss.NCOUNT = NCOUNT;
				
			ss.VISSELF = VISSELF;
				
			ss.VDEPT_CODE = VDEPT_CODE;
				
			ss.NDICTDETAIL_ID = NDICTDETAIL_ID;
				
			ss.OLDVRCPTDETAILID = OLDVRCPTDETAILID;
			
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
		} // Data_UpdateGHSF_GHSF_CHARGEDETAIL
		#endregion	
			
				
		//end modify
	}
}
	