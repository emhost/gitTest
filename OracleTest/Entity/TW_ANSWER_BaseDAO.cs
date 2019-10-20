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
	/// 对于TW_ANSWERBaseDAO的类的实现（基础控制部分）。
	/// 对于扩展的DAO的实现可以从这个类继承。
	/// 
	public class TW_ANSWERBaseDAO : MarshalByRefObject , IDisposable
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
		public TW_ANSWERBaseDAO()
		{
			//db = DataAccessFactory.Create();
			db = GenerateFactory.GenerateConnect(0);
			//db.Open();
		}
		
		/// 
		/// 结构化一个BaseDAO。
		/// 
		/// 给定的数据库连接。
		
		//public TW_ANSWERBaseDAO(IDataAccess cdb)
		public TW_ANSWERBaseDAO(IDataBaseOperate cdb)
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
		/// 插入一个TW_ANSWER实体到数据库。
		/// 
		/// 将要插入的实体
		public int InsertEntity(DataSetTW_ANSWER entity)
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
				
				foreach(DataRow row in entity.Tables["TW_ANSWER"].Rows)
				{	
					int j= db.exeSql(new SS_TW_ANSWER_InsertTW_ANSWER(), row);
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
		/// 更新TW_ANSWER实体到数据库。
		/// 
		/// 将要更新的实体
		public int UpdateEntity(DataSetTW_ANSWER entity)
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
				
				foreach(DataRow row in entity.Tables["TW_ANSWER"].Rows)
        {
          int j =	db.exeSql(new SS_TW_ANSWER_UpdateTW_ANSWER(), row);
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
		/// 从数据库中删除TW_ANSWER实体。
		/// 
		/// 将要删除的实体
		public int DeleteEntity(DataSetTW_ANSWER entity)
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
				
				foreach(DataRow row in entity.Tables["TW_ANSWER"].Rows)
				{
					int j = db.exeSql(new SS_TW_ANSWER_DeleteTW_ANSWER(), row);
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
		/// 按照TW_ANSWER实体的主表的主键查询数据。
		/// 
		/// 主键的值
		public DataSetTW_ANSWER FindByPrimaryKey(object KeyValue)
		{
			DataSetTW_ANSWER entity = new DataSetTW_ANSWER();
			SS_TW_ANSWER_SelectByIDTW_ANSWER ss = new SS_TW_ANSWER_SelectByIDTW_ANSWER();
			ss.Params[0].Value = KeyValue;
			db.FillDataSet(ss, entity, "TW_ANSWER");
					
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
		public int CommitChanges(DataSetTW_ANSWER entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			db.SetUpdateControl(alUpdateControl);
			db.SetUpdateColumn(alUpdateColumn);
		  int iRet =	CommitChanges(entity, drs);
      db.SetUpdateControl(null);
			db.SetUpdateColumn(null);
      return iRet;
		}
		///////////////// 
		
				
		public int CommitChanges(DataSetTW_ANSWER entity, DataRowState drs)
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



    public int CommitChanges(DataSetTW_ANSWER entity)
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

		public int CommitChanges(DataSetTW_ANSWER entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			this.alUpdateColumn = alUpdateColumn;
			this.alUpdateControl = alUpdateControl;
		  return	CommitChanges(entity);
		}
		/////////////				
		#endregion

		//// 2006-09-11
		public DataSetTW_ANSWER GetDataSet(SqlClass sC,string sTableName)
		{
			DataSetTW_ANSWER ds = new  DataSetTW_ANSWER();
			db.FillDataSet(sC,ds,sTableName);
			return ds;
		}
		
		#region CheckData		
		/// 
		/// 校验数据输入的有效性。
		/// 
		/// 要检验的实体
		protected void CheckData(DataSetTW_ANSWER entity)
		{
			//在这里可以加入操作之前所需要对实体检验的代码
		}
		#endregion
		
		//wuqb modify 2007-03-27

		
		
		//强名DataSet
		
		#region Data_TW_ANSWER_SelectByIDTW_ANSWER
		/// 
		/// 对于SelectByIDTW_ANSWER的类的实现（数据库操作）。
		/// 
		public DataSetTW_ANSWER  Data_TW_ANSWER_SelectByIDTW_ANSWER (System.String VID)
		{
			DataSetTW_ANSWER ds = new DataSetTW_ANSWER();
			SS_TW_ANSWER_SelectByIDTW_ANSWER ss = new SS_TW_ANSWER_SelectByIDTW_ANSWER();
				
			ss.VID = VID;
			
			db.FillDataSet(ss,ds,"TW_ANSWER");
			return ds;

		} // Data_SelectByIDTW_ANSWER
		#endregion
		
		#region Data_TW_ANSWER_selectAll
		/// 
		/// 对于selectAll的类的实现（数据库操作）。
		/// 
		public DataSetTW_ANSWER  Data_TW_ANSWER_selectAll ( string sTj )
		{
			DataSetTW_ANSWER ds = new DataSetTW_ANSWER();
			SS_TW_ANSWER_selectAll ss = new SS_TW_ANSWER_selectAll();
			
			ss.SqlString = ss.SqlString.Replace("1=1",sTj);
			
			db.FillDataSet(ss,ds,"TW_ANSWER");
			return ds;

		} // Data_selectAll
		#endregion
		
				
		//存储过程
		
			
		
		///update更新
		
		#region Data_TW_ANSWER_DeleteTW_ANSWER
		/// 
		/// 对于DeleteTW_ANSWER的类的实现（数据库操作）。
		/// 
		public int Data_TW_ANSWER_DeleteTW_ANSWER ( System.String VID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_TW_ANSWER_DeleteTW_ANSWER ss = new SS_TW_ANSWER_DeleteTW_ANSWER();
				
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
		} // Data_DeleteTW_ANSWER
		#endregion	
		
		#region Data_TW_ANSWER_UpdateTW_ANSWER
		/// 
		/// 对于UpdateTW_ANSWER的类的实现（数据库操作）。
		/// 
		public int Data_TW_ANSWER_UpdateTW_ANSWER ( System.Byte[] IMG , System.Decimal NDEL , System.DateTime DMODIFY , System.String VHUIFUID , System.String VID , System.String VQUESID , System.String VCONTENT , System.DateTime DCREATE , System.String VINPUTID , System.String OLDVID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_TW_ANSWER_UpdateTW_ANSWER ss = new SS_TW_ANSWER_UpdateTW_ANSWER();
				
			ss.IMG = IMG;
				
			ss.NDEL = NDEL;
				
			ss.DMODIFY = DMODIFY;
				
			ss.VHUIFUID = VHUIFUID;
				
			ss.VID = VID;
				
			ss.VQUESID = VQUESID;
				
			ss.VCONTENT = VCONTENT;
				
			ss.DCREATE = DCREATE;
				
			ss.VINPUTID = VINPUTID;
				
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
		} // Data_UpdateTW_ANSWER
		#endregion	
			
				
		//end modify
	}
}
	