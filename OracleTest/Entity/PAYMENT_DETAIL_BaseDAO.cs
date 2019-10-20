//------------------------------------------------------------------------------
//     这部分代码属于实体控制层，是由实体编辑器工具自动产生的。
//     (Runtime Version: 2.2017.3.2)
//     对此代码进行的任何修改会导致其它的行为错误，并且重新生成时所有的修改会丢失。
//------------------------------------------------------------------------------

using System;
using System.Data;
using HYHISAPP.Entity;
//using Gyd.TaskInfo;
using System.Collections;
using PhoenixDataBaseConnect;
using PhoenixDataBaseOperate;

namespace HYHISAPP.DAO
{
	/// 
	/// 对于PAYMENT_DETAILBaseDAO的类的实现（基础控制部分）。
	/// 对于扩展的DAO的实现可以从这个类继承。
	/// 
	public class PAYMENT_DETAILBaseDAO : MarshalByRefObject , IDisposable
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
		public PAYMENT_DETAILBaseDAO()
		{
			//db = DataAccessFactory.Create();
			db = GenerateFactory.GenerateConnect(0);
			//db.Open();
		}
		
		/// 
		/// 结构化一个BaseDAO。
		/// 
		/// 给定的数据库连接。
		
		//public PAYMENT_DETAILBaseDAO(IDataAccess cdb)
		public PAYMENT_DETAILBaseDAO(IDataBaseOperate cdb)
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
		/// 插入一个PAYMENT_DETAIL实体到数据库。
		/// 
		/// 将要插入的实体
		public int InsertEntity(DataSetPAYMENT_DETAIL entity)
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
				
				foreach(DataRow row in entity.Tables["PAYMENT_DETAIL"].Rows)
				{	
					int j= db.exeSql(new SS_PAYMENT_DETAIL_InsertPAYMENT_DETAIL(), row);
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
		/// 更新PAYMENT_DETAIL实体到数据库。
		/// 
		/// 将要更新的实体
		public int UpdateEntity(DataSetPAYMENT_DETAIL entity)
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
				
				foreach(DataRow row in entity.Tables["PAYMENT_DETAIL"].Rows)
        {
          int j =	db.exeSql(new SS_PAYMENT_DETAIL_UpdatePAYMENT_DETAIL(), row);
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
		/// 从数据库中删除PAYMENT_DETAIL实体。
		/// 
		/// 将要删除的实体
		public int DeleteEntity(DataSetPAYMENT_DETAIL entity)
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
				
				foreach(DataRow row in entity.Tables["PAYMENT_DETAIL"].Rows)
				{
					int j = db.exeSql(new SS_PAYMENT_DETAIL_DeletePAYMENT_DETAIL(), row);
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
		/// 按照PAYMENT_DETAIL实体的主表的主键查询数据。
		/// 
		/// 主键的值
		public DataSetPAYMENT_DETAIL FindByPrimaryKey(object KeyValue)
		{
			DataSetPAYMENT_DETAIL entity = new DataSetPAYMENT_DETAIL();
			SS_PAYMENT_DETAIL_SelectByIDPAYMENT_DETAIL ss = new SS_PAYMENT_DETAIL_SelectByIDPAYMENT_DETAIL();
			ss.Params[0].Value = KeyValue;
			db.FillDataSet(ss, entity, "PAYMENT_DETAIL");
					
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
		public int CommitChanges(DataSetPAYMENT_DETAIL entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			db.SetUpdateControl(alUpdateControl);
			db.SetUpdateColumn(alUpdateColumn);
		  int iRet =	CommitChanges(entity, drs);
      db.SetUpdateControl(null);
			db.SetUpdateColumn(null);
      return iRet;
		}
		///////////////// 
		
				
		public int CommitChanges(DataSetPAYMENT_DETAIL entity, DataRowState drs)
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



    public int CommitChanges(DataSetPAYMENT_DETAIL entity)
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

		public int CommitChanges(DataSetPAYMENT_DETAIL entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			this.alUpdateColumn = alUpdateColumn;
			this.alUpdateControl = alUpdateControl;
		  return	CommitChanges(entity);
		}
		/////////////				
		#endregion

		//// 2006-09-11
		public DataSetPAYMENT_DETAIL GetDataSet(SqlClass sC,string sTableName)
		{
			DataSetPAYMENT_DETAIL ds = new  DataSetPAYMENT_DETAIL();
			db.FillDataSet(sC,ds,sTableName);
			return ds;
		}
		
		#region CheckData		
		/// 
		/// 校验数据输入的有效性。
		/// 
		/// 要检验的实体
		protected void CheckData(DataSetPAYMENT_DETAIL entity)
		{
			//在这里可以加入操作之前所需要对实体检验的代码
		}
		#endregion
		
		//wuqb modify 2007-03-27

		
		
		//强名DataSet
		
		#region Data_PAYMENT_DETAIL_SelectByIDPAYMENT_DETAIL
		/// 
		/// 对于SelectByIDPAYMENT_DETAIL的类的实现（数据库操作）。
		/// 
		public DataSetPAYMENT_DETAIL  Data_PAYMENT_DETAIL_SelectByIDPAYMENT_DETAIL (System.String VID)
		{
			DataSetPAYMENT_DETAIL ds = new DataSetPAYMENT_DETAIL();
			SS_PAYMENT_DETAIL_SelectByIDPAYMENT_DETAIL ss = new SS_PAYMENT_DETAIL_SelectByIDPAYMENT_DETAIL();
				
			ss.VID = VID;
			
			db.FillDataSet(ss,ds,"PAYMENT_DETAIL");
			return ds;

		} // Data_SelectByIDPAYMENT_DETAIL
		#endregion
		
		#region Data_PAYMENT_DETAIL_SelectAll
		/// 
		/// 对于SelectAll的类的实现（数据库操作）。
		/// 
		public DataSetPAYMENT_DETAIL  Data_PAYMENT_DETAIL_SelectAll ( string sTj )
		{
			DataSetPAYMENT_DETAIL ds = new DataSetPAYMENT_DETAIL();
			SS_PAYMENT_DETAIL_SelectAll ss = new SS_PAYMENT_DETAIL_SelectAll();
			
			ss.SqlString = ss.SqlString.Replace("1=1",sTj);
			
			db.FillDataSet(ss,ds,"PAYMENT_DETAIL");
			return ds;

		} // Data_SelectAll
		#endregion
		
				
		//存储过程
		
			
		
		///update更新
		
		#region Data_PAYMENT_DETAIL_DeletePAYMENT_DETAIL
		/// 
		/// 对于DeletePAYMENT_DETAIL的类的实现（数据库操作）。
		/// 
		public int Data_PAYMENT_DETAIL_DeletePAYMENT_DETAIL ( System.String VID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_PAYMENT_DETAIL_DeletePAYMENT_DETAIL ss = new SS_PAYMENT_DETAIL_DeletePAYMENT_DETAIL();
				
			ss.VID = VID;
			
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
		} // Data_DeletePAYMENT_DETAIL
		#endregion	
		
		#region Data_PAYMENT_DETAIL_UpdatePAYMENT_DETAIL
		/// 
		/// 对于UpdatePAYMENT_DETAIL的类的实现（数据库操作）。
		/// 
		public int Data_PAYMENT_DETAIL_UpdatePAYMENT_DETAIL ( System.String VID , System.String VPRESC_ID , System.String VPRESC_TYPE , System.String VITEM_CODE , System.String VITEM_NAME , System.Decimal NPRICE , System.Decimal NSL , System.String VPRESC_DETAIL_ID , System.String VCLINICNO , System.String VITEM_TYPE , System.String VDDLSH , System.String OLDVID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_PAYMENT_DETAIL_UpdatePAYMENT_DETAIL ss = new SS_PAYMENT_DETAIL_UpdatePAYMENT_DETAIL();
				
			ss.VID = VID;
				
			ss.VPRESC_ID = VPRESC_ID;
				
			ss.VPRESC_TYPE = VPRESC_TYPE;
				
			ss.VITEM_CODE = VITEM_CODE;
				
			ss.VITEM_NAME = VITEM_NAME;
				
			ss.NPRICE = NPRICE;
				
			ss.NSL = NSL;
				
			ss.VPRESC_DETAIL_ID = VPRESC_DETAIL_ID;
				
			ss.VCLINICNO = VCLINICNO;
				
			ss.VITEM_TYPE = VITEM_TYPE;
				
			ss.VDDLSH = VDDLSH;
				
			ss.OLDVID = OLDVID;
			
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
		} // Data_UpdatePAYMENT_DETAIL
		#endregion	
			
				
		//end modify
	}
}
	