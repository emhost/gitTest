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
	/// 对于WJ_RECORDBaseDAO的类的实现（基础控制部分）。
	/// 对于扩展的DAO的实现可以从这个类继承。
	/// 
	public class WJ_RECORDBaseDAO : MarshalByRefObject , IDisposable
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
		public WJ_RECORDBaseDAO()
		{
			//db = DataAccessFactory.Create();
			db = GenerateFactory.GenerateConnect(0);
			//db.Open();
		}
		
		/// 
		/// 结构化一个BaseDAO。
		/// 
		/// 给定的数据库连接。
		
		//public WJ_RECORDBaseDAO(IDataAccess cdb)
		public WJ_RECORDBaseDAO(IDataBaseOperate cdb)
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
		/// 插入一个WJ_RECORD实体到数据库。
		/// 
		/// 将要插入的实体
		public int InsertEntity(DataSetWJ_RECORD entity)
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
				
				foreach(DataRow row in entity.Tables["WJ_RECORD"].Rows)
				{	
					int j= db.exeSql(new SS_WJ_RECORD_InsertWJ_RECORD(), row);
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
		/// 更新WJ_RECORD实体到数据库。
		/// 
		/// 将要更新的实体
		public int UpdateEntity(DataSetWJ_RECORD entity)
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
				
				foreach(DataRow row in entity.Tables["WJ_RECORD"].Rows)
        {
          int j =	db.exeSql(new SS_WJ_RECORD_UpdateWJ_RECORD(), row);
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
		/// 从数据库中删除WJ_RECORD实体。
		/// 
		/// 将要删除的实体
		public int DeleteEntity(DataSetWJ_RECORD entity)
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
				
				foreach(DataRow row in entity.Tables["WJ_RECORD"].Rows)
				{
					int j = db.exeSql(new SS_WJ_RECORD_DeleteWJ_RECORD(), row);
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
		/// 按照WJ_RECORD实体的主表的主键查询数据。
		/// 
		/// 主键的值
		public DataSetWJ_RECORD FindByPrimaryKey(object KeyValue)
		{
			DataSetWJ_RECORD entity = new DataSetWJ_RECORD();
			SS_WJ_RECORD_SelectByIDWJ_RECORD ss = new SS_WJ_RECORD_SelectByIDWJ_RECORD();
			ss.Params[0].Value = KeyValue;
			db.FillDataSet(ss, entity, "WJ_RECORD");
					
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
		public int CommitChanges(DataSetWJ_RECORD entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			db.SetUpdateControl(alUpdateControl);
			db.SetUpdateColumn(alUpdateColumn);
		  int iRet =	CommitChanges(entity, drs);
      db.SetUpdateControl(null);
			db.SetUpdateColumn(null);
      return iRet;
		}
		///////////////// 
		
				
		public int CommitChanges(DataSetWJ_RECORD entity, DataRowState drs)
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



    public int CommitChanges(DataSetWJ_RECORD entity)
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

		public int CommitChanges(DataSetWJ_RECORD entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			this.alUpdateColumn = alUpdateColumn;
			this.alUpdateControl = alUpdateControl;
		  return	CommitChanges(entity);
		}
		/////////////				
		#endregion

		//// 2006-09-11
		public DataSetWJ_RECORD GetDataSet(SqlClass sC,string sTableName)
		{
			DataSetWJ_RECORD ds = new  DataSetWJ_RECORD();
			db.FillDataSet(sC,ds,sTableName);
			return ds;
		}
		
		#region CheckData		
		/// 
		/// 校验数据输入的有效性。
		/// 
		/// 要检验的实体
		protected void CheckData(DataSetWJ_RECORD entity)
		{
			//在这里可以加入操作之前所需要对实体检验的代码
		}
		#endregion
		
		//wuqb modify 2007-03-27

		
		
		//强名DataSet
		
		#region Data_WJ_RECORD_SelectByIDWJ_RECORD
		/// 
		/// 对于SelectByIDWJ_RECORD的类的实现（数据库操作）。
		/// 
		public DataSetWJ_RECORD  Data_WJ_RECORD_SelectByIDWJ_RECORD (System.String VID)
		{
			DataSetWJ_RECORD ds = new DataSetWJ_RECORD();
			SS_WJ_RECORD_SelectByIDWJ_RECORD ss = new SS_WJ_RECORD_SelectByIDWJ_RECORD();
				
			ss.VID = VID;
			
			db.FillDataSet(ss,ds,"WJ_RECORD");
			return ds;

		} // Data_SelectByIDWJ_RECORD
		#endregion
		
		#region Data_WJ_RECORD_SelectAll
		/// 
		/// 对于SelectAll的类的实现（数据库操作）。
		/// 
		public DataSetWJ_RECORD  Data_WJ_RECORD_SelectAll ( string sTj )
		{
			DataSetWJ_RECORD ds = new DataSetWJ_RECORD();
			SS_WJ_RECORD_SelectAll ss = new SS_WJ_RECORD_SelectAll();
			
			ss.SqlString = ss.SqlString.Replace("1=1",sTj);
			
			db.FillDataSet(ss,ds,"WJ_RECORD");
			return ds;

		} // Data_SelectAll
		#endregion
		
				
		//存储过程
		
			
		
		///update更新
		
		#region Data_WJ_RECORD_DeleteWJ_RECORD
		/// 
		/// 对于DeleteWJ_RECORD的类的实现（数据库操作）。
		/// 
		public int Data_WJ_RECORD_DeleteWJ_RECORD ( System.String VID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_WJ_RECORD_DeleteWJ_RECORD ss = new SS_WJ_RECORD_DeleteWJ_RECORD();
				
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
		} // Data_DeleteWJ_RECORD
		#endregion	
		
		#region Data_WJ_RECORD_UpdateWJ_RECORD
		/// 
		/// 对于UpdateWJ_RECORD的类的实现（数据库操作）。
		/// 
		public int Data_WJ_RECORD_UpdateWJ_RECORD ( System.String VID , System.String VWJID , System.String VWJMC , System.String VQUESID , System.String VINPUTID , System.DateTime DCREATE , System.String VQUESNAME , System.String VANSID , System.String VANSNAME , System.String VDJH , System.String OLDVID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_WJ_RECORD_UpdateWJ_RECORD ss = new SS_WJ_RECORD_UpdateWJ_RECORD();
				
			ss.VID = VID;
				
			ss.VWJID = VWJID;
				
			ss.VWJMC = VWJMC;
				
			ss.VQUESID = VQUESID;
				
			ss.VINPUTID = VINPUTID;
				
			ss.DCREATE = DCREATE;
				
			ss.VQUESNAME = VQUESNAME;
				
			ss.VANSID = VANSID;
				
			ss.VANSNAME = VANSNAME;
				
			ss.VDJH = VDJH;
				
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
		} // Data_UpdateWJ_RECORD
		#endregion	
			
				
		//end modify
	}
}
	