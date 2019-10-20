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
	/// 对于CHAT_RECORDBaseDAO的类的实现（基础控制部分）。
	/// 对于扩展的DAO的实现可以从这个类继承。
	/// 
	public class CHAT_RECORDBaseDAO : MarshalByRefObject , IDisposable
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
		public CHAT_RECORDBaseDAO()
		{
			//db = DataAccessFactory.Create();
			db = GenerateFactory.GenerateConnect(0);
			//db.Open();
		}
		
		/// 
		/// 结构化一个BaseDAO。
		/// 
		/// 给定的数据库连接。
		
		//public CHAT_RECORDBaseDAO(IDataAccess cdb)
		public CHAT_RECORDBaseDAO(IDataBaseOperate cdb)
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
		/// 插入一个CHAT_RECORD实体到数据库。
		/// 
		/// 将要插入的实体
		public int InsertEntity(DataSetCHAT_RECORD entity)
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
				
				foreach(DataRow row in entity.Tables["CHAT_RECORD"].Rows)
				{	
					int j= db.exeSql(new SS_CHAT_RECORD_InsertCHAT_RECORD(), row);
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
		/// 更新CHAT_RECORD实体到数据库。
		/// 
		/// 将要更新的实体
		public int UpdateEntity(DataSetCHAT_RECORD entity)
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
				
				foreach(DataRow row in entity.Tables["CHAT_RECORD"].Rows)
        {
          int j =	db.exeSql(new SS_CHAT_RECORD_UpdateCHAT_RECORD(), row);
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
		/// 从数据库中删除CHAT_RECORD实体。
		/// 
		/// 将要删除的实体
		public int DeleteEntity(DataSetCHAT_RECORD entity)
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
				
				foreach(DataRow row in entity.Tables["CHAT_RECORD"].Rows)
				{
					int j = db.exeSql(new SS_CHAT_RECORD_DeleteCHAT_RECORD(), row);
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
		/// 按照CHAT_RECORD实体的主表的主键查询数据。
		/// 
		/// 主键的值
		public DataSetCHAT_RECORD FindByPrimaryKey(object KeyValue)
		{
			DataSetCHAT_RECORD entity = new DataSetCHAT_RECORD();
			SS_CHAT_RECORD_SelectByIDCHAT_RECORD ss = new SS_CHAT_RECORD_SelectByIDCHAT_RECORD();
			ss.Params[0].Value = KeyValue;
			db.FillDataSet(ss, entity, "CHAT_RECORD");
					
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
		public int CommitChanges(DataSetCHAT_RECORD entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			db.SetUpdateControl(alUpdateControl);
			db.SetUpdateColumn(alUpdateColumn);
		  int iRet =	CommitChanges(entity, drs);
      db.SetUpdateControl(null);
			db.SetUpdateColumn(null);
      return iRet;
		}
		///////////////// 
		
				
		public int CommitChanges(DataSetCHAT_RECORD entity, DataRowState drs)
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



    public int CommitChanges(DataSetCHAT_RECORD entity)
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

		public int CommitChanges(DataSetCHAT_RECORD entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			this.alUpdateColumn = alUpdateColumn;
			this.alUpdateControl = alUpdateControl;
		  return	CommitChanges(entity);
		}
		/////////////				
		#endregion

		//// 2006-09-11
		public DataSetCHAT_RECORD GetDataSet(SqlClass sC,string sTableName)
		{
			DataSetCHAT_RECORD ds = new  DataSetCHAT_RECORD();
			db.FillDataSet(sC,ds,sTableName);
			return ds;
		}
		
		#region CheckData		
		/// 
		/// 校验数据输入的有效性。
		/// 
		/// 要检验的实体
		protected void CheckData(DataSetCHAT_RECORD entity)
		{
			//在这里可以加入操作之前所需要对实体检验的代码
		}
		#endregion
		
		//wuqb modify 2007-03-27

		
		
		//强名DataSet
		
		#region Data_CHAT_RECORD_SelectByIDCHAT_RECORD
		/// 
		/// 对于SelectByIDCHAT_RECORD的类的实现（数据库操作）。
		/// 
		public DataSetCHAT_RECORD  Data_CHAT_RECORD_SelectByIDCHAT_RECORD (System.String VID)
		{
			DataSetCHAT_RECORD ds = new DataSetCHAT_RECORD();
			SS_CHAT_RECORD_SelectByIDCHAT_RECORD ss = new SS_CHAT_RECORD_SelectByIDCHAT_RECORD();
				
			ss.VID = VID;
			
			db.FillDataSet(ss,ds,"CHAT_RECORD");
			return ds;

		} // Data_SelectByIDCHAT_RECORD
		#endregion
		
		#region Data_CHAT_RECORD_SelectAll
		/// 
		/// 对于SelectAll的类的实现（数据库操作）。
		/// 
		public DataSetCHAT_RECORD  Data_CHAT_RECORD_SelectAll ( string sTj )
		{
			DataSetCHAT_RECORD ds = new DataSetCHAT_RECORD();
			SS_CHAT_RECORD_SelectAll ss = new SS_CHAT_RECORD_SelectAll();
			
			ss.SqlString = ss.SqlString.Replace("1=1",sTj);
			
			db.FillDataSet(ss,ds,"CHAT_RECORD");
			return ds;

		} // Data_SelectAll
		#endregion
		
				
		//存储过程
		
			
		
		///update更新
		
		#region Data_CHAT_RECORD_DeleteCHAT_RECORD
		/// 
		/// 对于DeleteCHAT_RECORD的类的实现（数据库操作）。
		/// 
		public int Data_CHAT_RECORD_DeleteCHAT_RECORD ( System.String VID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_CHAT_RECORD_DeleteCHAT_RECORD ss = new SS_CHAT_RECORD_DeleteCHAT_RECORD();
				
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
		} // Data_DeleteCHAT_RECORD
		#endregion	
		
		#region Data_CHAT_RECORD_UpdateCHAT_RECORD
		/// 
		/// 对于UpdateCHAT_RECORD的类的实现（数据库操作）。
		/// 
		public int Data_CHAT_RECORD_UpdateCHAT_RECORD ( System.DateTime DREAD , System.String VID , System.String VSID , System.String VRID , System.String VSNAME , System.String VRNAME , System.DateTime DCREATE , System.Byte[] CONTENT , System.String TYPE , System.Decimal NREAD , System.String OLDVID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_CHAT_RECORD_UpdateCHAT_RECORD ss = new SS_CHAT_RECORD_UpdateCHAT_RECORD();
				
			ss.DREAD = DREAD;
				
			ss.VID = VID;
				
			ss.VSID = VSID;
				
			ss.VRID = VRID;
				
			ss.VSNAME = VSNAME;
				
			ss.VRNAME = VRNAME;
				
			ss.DCREATE = DCREATE;
				
			ss.CONTENT = CONTENT;
				
			ss.TYPE = TYPE;
				
			ss.NREAD = NREAD;
				
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
		} // Data_UpdateCHAT_RECORD
		#endregion	
			
				
		//end modify
	}
}
	