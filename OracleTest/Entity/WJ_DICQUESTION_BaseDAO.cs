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
	/// 对于WJ_DICQUESTIONBaseDAO的类的实现（基础控制部分）。
	/// 对于扩展的DAO的实现可以从这个类继承。
	/// 
	public class WJ_DICQUESTIONBaseDAO : MarshalByRefObject , IDisposable
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
		public WJ_DICQUESTIONBaseDAO()
		{
			//db = DataAccessFactory.Create();
			db = GenerateFactory.GenerateConnect(0);
			//db.Open();
		}
		
		/// 
		/// 结构化一个BaseDAO。
		/// 
		/// 给定的数据库连接。
		
		//public WJ_DICQUESTIONBaseDAO(IDataAccess cdb)
		public WJ_DICQUESTIONBaseDAO(IDataBaseOperate cdb)
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
		/// 插入一个WJ_DICQUESTION实体到数据库。
		/// 
		/// 将要插入的实体
		public int InsertEntity(DataSetWJ_DICQUESTION entity)
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
				
				foreach(DataRow row in entity.Tables["WJ_DICQUESTION"].Rows)
				{	
					int j= db.exeSql(new SS_WJ_DICQUESTION_InsertWJ_DICQUESTION(), row);
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
		/// 更新WJ_DICQUESTION实体到数据库。
		/// 
		/// 将要更新的实体
		public int UpdateEntity(DataSetWJ_DICQUESTION entity)
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
				
				foreach(DataRow row in entity.Tables["WJ_DICQUESTION"].Rows)
        {
          int j =	db.exeSql(new SS_WJ_DICQUESTION_UpdateWJ_DICQUESTION(), row);
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
		/// 从数据库中删除WJ_DICQUESTION实体。
		/// 
		/// 将要删除的实体
		public int DeleteEntity(DataSetWJ_DICQUESTION entity)
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
				
				foreach(DataRow row in entity.Tables["WJ_DICQUESTION"].Rows)
				{
					int j = db.exeSql(new SS_WJ_DICQUESTION_DeleteWJ_DICQUESTION(), row);
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
		/// 按照WJ_DICQUESTION实体的主表的主键查询数据。
		/// 
		/// 主键的值
		public DataSetWJ_DICQUESTION FindByPrimaryKey(object KeyValue)
		{
			DataSetWJ_DICQUESTION entity = new DataSetWJ_DICQUESTION();
			SS_WJ_DICQUESTION_SelectByIDWJ_DICQUESTION ss = new SS_WJ_DICQUESTION_SelectByIDWJ_DICQUESTION();
			ss.Params[0].Value = KeyValue;
			db.FillDataSet(ss, entity, "WJ_DICQUESTION");
					
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
		public int CommitChanges(DataSetWJ_DICQUESTION entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			db.SetUpdateControl(alUpdateControl);
			db.SetUpdateColumn(alUpdateColumn);
		  int iRet =	CommitChanges(entity, drs);
      db.SetUpdateControl(null);
			db.SetUpdateColumn(null);
      return iRet;
		}
		///////////////// 
		
				
		public int CommitChanges(DataSetWJ_DICQUESTION entity, DataRowState drs)
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



    public int CommitChanges(DataSetWJ_DICQUESTION entity)
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

		public int CommitChanges(DataSetWJ_DICQUESTION entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			this.alUpdateColumn = alUpdateColumn;
			this.alUpdateControl = alUpdateControl;
		  return	CommitChanges(entity);
		}
		/////////////				
		#endregion

		//// 2006-09-11
		public DataSetWJ_DICQUESTION GetDataSet(SqlClass sC,string sTableName)
		{
			DataSetWJ_DICQUESTION ds = new  DataSetWJ_DICQUESTION();
			db.FillDataSet(sC,ds,sTableName);
			return ds;
		}
		
		#region CheckData		
		/// 
		/// 校验数据输入的有效性。
		/// 
		/// 要检验的实体
		protected void CheckData(DataSetWJ_DICQUESTION entity)
		{
			//在这里可以加入操作之前所需要对实体检验的代码
		}
		#endregion
		
		//wuqb modify 2007-03-27

		
		
		//强名DataSet
		
		#region Data_WJ_DICQUESTION_SelectByIDWJ_DICQUESTION
		/// 
		/// 对于SelectByIDWJ_DICQUESTION的类的实现（数据库操作）。
		/// 
		public DataSetWJ_DICQUESTION  Data_WJ_DICQUESTION_SelectByIDWJ_DICQUESTION (System.String VID)
		{
			DataSetWJ_DICQUESTION ds = new DataSetWJ_DICQUESTION();
			SS_WJ_DICQUESTION_SelectByIDWJ_DICQUESTION ss = new SS_WJ_DICQUESTION_SelectByIDWJ_DICQUESTION();
				
			ss.VID = VID;
			
			db.FillDataSet(ss,ds,"WJ_DICQUESTION");
			return ds;

		} // Data_SelectByIDWJ_DICQUESTION
		#endregion
		
		#region Data_WJ_DICQUESTION_SelectAll
		/// 
		/// 对于SelectAll的类的实现（数据库操作）。
		/// 
		public DataSetWJ_DICQUESTION  Data_WJ_DICQUESTION_SelectAll ( string sTj )
		{
			DataSetWJ_DICQUESTION ds = new DataSetWJ_DICQUESTION();
			SS_WJ_DICQUESTION_SelectAll ss = new SS_WJ_DICQUESTION_SelectAll();
			
			ss.SqlString = ss.SqlString.Replace("1=1",sTj);
			
			db.FillDataSet(ss,ds,"WJ_DICQUESTION");
			return ds;

		} // Data_SelectAll
		#endregion
		
				
		//存储过程
		
			
		
		///update更新
		
		#region Data_WJ_DICQUESTION_DeleteWJ_DICQUESTION
		/// 
		/// 对于DeleteWJ_DICQUESTION的类的实现（数据库操作）。
		/// 
		public int Data_WJ_DICQUESTION_DeleteWJ_DICQUESTION ( System.String VID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_WJ_DICQUESTION_DeleteWJ_DICQUESTION ss = new SS_WJ_DICQUESTION_DeleteWJ_DICQUESTION();
				
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
		} // Data_DeleteWJ_DICQUESTION
		#endregion	
		
		#region Data_WJ_DICQUESTION_UpdateWJ_DICQUESTION
		/// 
		/// 对于UpdateWJ_DICQUESTION的类的实现（数据库操作）。
		/// 
		public int Data_WJ_DICQUESTION_UpdateWJ_DICQUESTION ( System.String VID , System.String VNAME , System.Decimal NSTOP , System.Decimal NLX , System.String VPID , System.DateTime DCREATE , System.Decimal NSORT , System.Decimal NBIXUAN , System.String OLDVID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_WJ_DICQUESTION_UpdateWJ_DICQUESTION ss = new SS_WJ_DICQUESTION_UpdateWJ_DICQUESTION();
				
			ss.VID = VID;
				
			ss.VNAME = VNAME;
				
			ss.NSTOP = NSTOP;
				
			ss.NLX = NLX;
				
			ss.VPID = VPID;
				
			ss.DCREATE = DCREATE;
				
			ss.NSORT = NSORT;
				
			ss.NBIXUAN = NBIXUAN;
				
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
		} // Data_UpdateWJ_DICQUESTION
		#endregion	
			
				
		//end modify
	}
}
	