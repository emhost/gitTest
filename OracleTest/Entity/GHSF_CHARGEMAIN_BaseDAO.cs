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
	/// 对于GHSF_CHARGEMAINBaseDAO的类的实现（基础控制部分）。
	/// 对于扩展的DAO的实现可以从这个类继承。
	/// 
	public class GHSF_CHARGEMAINBaseDAO : MarshalByRefObject , IDisposable
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
		public GHSF_CHARGEMAINBaseDAO()
		{
			//db = DataAccessFactory.Create();
			db = GenerateFactory.GenerateConnect(0);
			//db.Open();
		}
		
		/// 
		/// 结构化一个BaseDAO。
		/// 
		/// 给定的数据库连接。
		
		//public GHSF_CHARGEMAINBaseDAO(IDataAccess cdb)
		public GHSF_CHARGEMAINBaseDAO(IDataBaseOperate cdb)
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
		/// 插入一个GHSF_CHARGEMAIN实体到数据库。
		/// 
		/// 将要插入的实体
		public int InsertEntity(DataSetGHSF_CHARGEMAIN entity)
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
				
				foreach(DataRow row in entity.Tables["GHSF_GHSF_CHARGEMAIN"].Rows)
				{	
					int j= db.exeSql(new SS_GHSF_CHARGEMAIN_InsertGHSF_GHSF_CHARGEMAIN(), row);
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
		/// 更新GHSF_CHARGEMAIN实体到数据库。
		/// 
		/// 将要更新的实体
		public int UpdateEntity(DataSetGHSF_CHARGEMAIN entity)
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
				
				foreach(DataRow row in entity.Tables["GHSF_GHSF_CHARGEMAIN"].Rows)
        {
          int j =	db.exeSql(new SS_GHSF_CHARGEMAIN_UpdateGHSF_GHSF_CHARGEMAIN(), row);
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
		/// 从数据库中删除GHSF_CHARGEMAIN实体。
		/// 
		/// 将要删除的实体
		public int DeleteEntity(DataSetGHSF_CHARGEMAIN entity)
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
				
				foreach(DataRow row in entity.Tables["GHSF_GHSF_CHARGEMAIN"].Rows)
				{
					int j = db.exeSql(new SS_GHSF_CHARGEMAIN_DeleteGHSF_GHSF_CHARGEMAIN(), row);
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
		/// 按照GHSF_CHARGEMAIN实体的主表的主键查询数据。
		/// 
		/// 主键的值
		public DataSetGHSF_CHARGEMAIN FindByPrimaryKey(object KeyValue)
		{
			DataSetGHSF_CHARGEMAIN entity = new DataSetGHSF_CHARGEMAIN();
			SS_GHSF_CHARGEMAIN_SelectByIDGHSF_GHSF_CHARGEMAIN ss = new SS_GHSF_CHARGEMAIN_SelectByIDGHSF_GHSF_CHARGEMAIN();
			ss.Params[0].Value = KeyValue;
			db.FillDataSet(ss, entity, "GHSF_GHSF_CHARGEMAIN");
					
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
		public int CommitChanges(DataSetGHSF_CHARGEMAIN entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			db.SetUpdateControl(alUpdateControl);
			db.SetUpdateColumn(alUpdateColumn);
		  int iRet =	CommitChanges(entity, drs);
      db.SetUpdateControl(null);
			db.SetUpdateColumn(null);
      return iRet;
		}
		///////////////// 
		
				
		public int CommitChanges(DataSetGHSF_CHARGEMAIN entity, DataRowState drs)
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



    public int CommitChanges(DataSetGHSF_CHARGEMAIN entity)
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

		public int CommitChanges(DataSetGHSF_CHARGEMAIN entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			this.alUpdateColumn = alUpdateColumn;
			this.alUpdateControl = alUpdateControl;
		  return	CommitChanges(entity);
		}
		/////////////				
		#endregion

		//// 2006-09-11
		public DataSetGHSF_CHARGEMAIN GetDataSet(SqlClass sC,string sTableName)
		{
			DataSetGHSF_CHARGEMAIN ds = new  DataSetGHSF_CHARGEMAIN();
			db.FillDataSet(sC,ds,sTableName);
			return ds;
		}
		
		#region CheckData		
		/// 
		/// 校验数据输入的有效性。
		/// 
		/// 要检验的实体
		protected void CheckData(DataSetGHSF_CHARGEMAIN entity)
		{
			//在这里可以加入操作之前所需要对实体检验的代码
		}
		#endregion
		
		//wuqb modify 2007-03-27

		
		
		//强名DataSet
		
		#region Data_GHSF_CHARGEMAIN_SelectByIDGHSF_GHSF_CHARGEMAIN
		/// 
		/// 对于SelectByIDGHSF_GHSF_CHARGEMAIN的类的实现（数据库操作）。
		/// 
		public DataSetGHSF_CHARGEMAIN  Data_GHSF_CHARGEMAIN_SelectByIDGHSF_GHSF_CHARGEMAIN (System.String VRCPTID)
		{
			DataSetGHSF_CHARGEMAIN ds = new DataSetGHSF_CHARGEMAIN();
			SS_GHSF_CHARGEMAIN_SelectByIDGHSF_GHSF_CHARGEMAIN ss = new SS_GHSF_CHARGEMAIN_SelectByIDGHSF_GHSF_CHARGEMAIN();
				
			ss.VRCPTID = VRCPTID;
			
			db.FillDataSet(ss,ds,"GHSF_GHSF_CHARGEMAIN");
			return ds;

		} // Data_SelectByIDGHSF_GHSF_CHARGEMAIN
		#endregion
		
		#region Data_GHSF_CHARGEMAIN_SelectAll
		/// 
		/// 对于SelectAll的类的实现（数据库操作）。
		/// 
		public DataSetGHSF_CHARGEMAIN  Data_GHSF_CHARGEMAIN_SelectAll ( string sTj )
		{
			DataSetGHSF_CHARGEMAIN ds = new DataSetGHSF_CHARGEMAIN();
			SS_GHSF_CHARGEMAIN_SelectAll ss = new SS_GHSF_CHARGEMAIN_SelectAll();
			
			ss.SqlString = ss.SqlString.Replace("1=1",sTj);
			
			db.FillDataSet(ss,ds,"GHSF_GHSF_CHARGEMAIN");
			return ds;

		} // Data_SelectAll
		#endregion
		
				
		//存储过程
		
			
		
		///update更新
		
		#region Data_GHSF_CHARGEMAIN_DeleteGHSF_GHSF_CHARGEMAIN
		/// 
		/// 对于DeleteGHSF_GHSF_CHARGEMAIN的类的实现（数据库操作）。
		/// 
		public int Data_GHSF_CHARGEMAIN_DeleteGHSF_GHSF_CHARGEMAIN ( System.String VRCPTID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_GHSF_CHARGEMAIN_DeleteGHSF_GHSF_CHARGEMAIN ss = new SS_GHSF_CHARGEMAIN_DeleteGHSF_GHSF_CHARGEMAIN();
				
			ss.VRCPTID = VRCPTID;
			
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
		} // Data_DeleteGHSF_GHSF_CHARGEMAIN
		#endregion	
		
		#region Data_GHSF_CHARGEMAIN_UpdateGHSF_GHSF_CHARGEMAIN
		/// 
		/// 对于UpdateGHSF_GHSF_CHARGEMAIN的类的实现（数据库操作）。
		/// 
		public int Data_GHSF_CHARGEMAIN_UpdateGHSF_GHSF_CHARGEMAIN ( System.String VPRESC_TYPE , System.DateTime DPRESC_DATE , System.String VDEPT_CODE , System.String VACCTID , System.Decimal BBAIYAO , System.Decimal NHOSID , System.String VRCPTID , System.String VPATIENTID , System.String VREGIST_ID , System.String VPRESC_ID , System.String VDIAGNOSE , System.Decimal NCOUNT , System.String VUSERAGE , System.String VDOCTOR_ID , System.String VOPERATORID , System.String VREFUNDEDRCPTNO , System.String VACCTNO , System.String VPRINTEDOPERATORID , System.DateTime VPRINTEDDATE , System.String VPRINTEDRCPTNO , System.String VINVOICENO , System.Decimal NSETTLE , System.String VREMARKS , System.DateTime DCHARGE_DATE , System.String VDEPTID , System.Decimal NSTATUS , System.String OLDVRCPTID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_GHSF_CHARGEMAIN_UpdateGHSF_GHSF_CHARGEMAIN ss = new SS_GHSF_CHARGEMAIN_UpdateGHSF_GHSF_CHARGEMAIN();
				
			ss.VPRESC_TYPE = VPRESC_TYPE;
				
			ss.DPRESC_DATE = DPRESC_DATE;
				
			ss.VDEPT_CODE = VDEPT_CODE;
				
			ss.VACCTID = VACCTID;
				
			ss.BBAIYAO = BBAIYAO;
				
			ss.NHOSID = NHOSID;
				
			ss.VRCPTID = VRCPTID;
				
			ss.VPATIENTID = VPATIENTID;
				
			ss.VREGIST_ID = VREGIST_ID;
				
			ss.VPRESC_ID = VPRESC_ID;
				
			ss.VDIAGNOSE = VDIAGNOSE;
				
			ss.NCOUNT = NCOUNT;
				
			ss.VUSERAGE = VUSERAGE;
				
			ss.VDOCTOR_ID = VDOCTOR_ID;
				
			ss.VOPERATORID = VOPERATORID;
				
			ss.VREFUNDEDRCPTNO = VREFUNDEDRCPTNO;
				
			ss.VACCTNO = VACCTNO;
				
			ss.VPRINTEDOPERATORID = VPRINTEDOPERATORID;
				
			ss.VPRINTEDDATE = VPRINTEDDATE;
				
			ss.VPRINTEDRCPTNO = VPRINTEDRCPTNO;
				
			ss.VINVOICENO = VINVOICENO;
				
			ss.NSETTLE = NSETTLE;
				
			ss.VREMARKS = VREMARKS;
				
			ss.DCHARGE_DATE = DCHARGE_DATE;
				
			ss.VDEPTID = VDEPTID;
				
			ss.NSTATUS = NSTATUS;
				
			ss.OLDVRCPTID = OLDVRCPTID;
			
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
		} // Data_UpdateGHSF_GHSF_CHARGEMAIN
		#endregion	
			
				
		//end modify
	}
}
	