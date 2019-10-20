//------------------------------------------------------------------------------
//     这部分代码属于实体控制层，是由实体编辑器工具自动产生的。
//     (Runtime Version: 2.2017.9.9)
//     对此代码进行的任何修改会导致其它的行为错误，并且重新生成时所有的修改会丢失。
//------------------------------------------------------------------------------

using System;
using System.Data;
using hyApp.Entity;
//using Gyd.TaskInfo;
using System.Collections;
using PhoenixDataBaseConnect;
using PhoenixDataBaseOperate;

namespace hyApp.DAO
{
	/// 
	/// 对于IN_NAVIGATIONBaseDAO的类的实现（基础控制部分）。
	/// 对于扩展的DAO的实现可以从这个类继承。
	/// 
	public class IN_NAVIGATIONBaseDAO : MarshalByRefObject , IDisposable
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
		public IN_NAVIGATIONBaseDAO()
		{
			//db = DataAccessFactory.Create();
			db = GenerateFactory.GenerateConnect(0);
			//db.Open();
		}
		
		/// 
		/// 结构化一个BaseDAO。
		/// 
		/// 给定的数据库连接。
		
		//public IN_NAVIGATIONBaseDAO(IDataAccess cdb)
		public IN_NAVIGATIONBaseDAO(IDataBaseOperate cdb)
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
		/// 插入一个IN_NAVIGATION实体到数据库。
		/// 
		/// 将要插入的实体
		public int InsertEntity(DataSetIN_NAVIGATION entity)
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
				
				foreach(DataRow row in entity.Tables["YWAPP_INHOSPITAL_NAVIGATION"].Rows)
				{	
					int j= db.exeSql(new SS_IN_NAVIGATION_InsertYWAPP_INHOSPITAL_NAVIGATION(), row);
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
		/// 更新IN_NAVIGATION实体到数据库。
		/// 
		/// 将要更新的实体
		public int UpdateEntity(DataSetIN_NAVIGATION entity)
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
				
				foreach(DataRow row in entity.Tables["YWAPP_INHOSPITAL_NAVIGATION"].Rows)
        {
          int j =	db.exeSql(new SS_IN_NAVIGATION_UpdateYWAPP_INHOSPITAL_NAVIGATION(), row);
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
		/// 从数据库中删除IN_NAVIGATION实体。
		/// 
		/// 将要删除的实体
		public int DeleteEntity(DataSetIN_NAVIGATION entity)
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
				
				foreach(DataRow row in entity.Tables["YWAPP_INHOSPITAL_NAVIGATION"].Rows)
				{
					int j = db.exeSql(new SS_IN_NAVIGATION_DeleteYWAPP_INHOSPITAL_NAVIGATION(), row);
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
		/// 按照IN_NAVIGATION实体的主表的主键查询数据。
		/// 
		/// 主键的值
		public DataSetIN_NAVIGATION FindByPrimaryKey(object KeyValue)
		{
			DataSetIN_NAVIGATION entity = new DataSetIN_NAVIGATION();
			SS_IN_NAVIGATION_SelectByIDYWAPP_INHOSPITAL_NAVIGATION ss = new SS_IN_NAVIGATION_SelectByIDYWAPP_INHOSPITAL_NAVIGATION();
			ss.Params[0].Value = KeyValue;
			db.FillDataSet(ss, entity, "YWAPP_INHOSPITAL_NAVIGATION");
					
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
		public int CommitChanges(DataSetIN_NAVIGATION entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			db.SetUpdateControl(alUpdateControl);
			db.SetUpdateColumn(alUpdateColumn);
		  int iRet =	CommitChanges(entity, drs);
      db.SetUpdateControl(null);
			db.SetUpdateColumn(null);
      return iRet;
		}
		///////////////// 
		
				
		public int CommitChanges(DataSetIN_NAVIGATION entity, DataRowState drs)
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



    public int CommitChanges(DataSetIN_NAVIGATION entity)
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

		public int CommitChanges(DataSetIN_NAVIGATION entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			this.alUpdateColumn = alUpdateColumn;
			this.alUpdateControl = alUpdateControl;
		  return	CommitChanges(entity);
		}
		/////////////				
		#endregion

		//// 2006-09-11
		public DataSetIN_NAVIGATION GetDataSet(SqlClass sC,string sTableName)
		{
			DataSetIN_NAVIGATION ds = new  DataSetIN_NAVIGATION();
			db.FillDataSet(sC,ds,sTableName);
			return ds;
		}
		
		#region CheckData		
		/// 
		/// 校验数据输入的有效性。
		/// 
		/// 要检验的实体
		protected void CheckData(DataSetIN_NAVIGATION entity)
		{
			//在这里可以加入操作之前所需要对实体检验的代码
		}
		#endregion
		
		//wuqb modify 2007-03-27

		
		
		//强名DataSet
		
		#region Data_IN_NAVIGATION_SelectByIDYWAPP_INHOSPITAL_NAVIGATION
		/// 
		/// 对于SelectByIDYWAPP_INHOSPITAL_NAVIGATION的类的实现（数据库操作）。
		/// 
		public DataSetIN_NAVIGATION  Data_IN_NAVIGATION_SelectByIDYWAPP_INHOSPITAL_NAVIGATION (System.String ID)
		{
			DataSetIN_NAVIGATION ds = new DataSetIN_NAVIGATION();
			SS_IN_NAVIGATION_SelectByIDYWAPP_INHOSPITAL_NAVIGATION ss = new SS_IN_NAVIGATION_SelectByIDYWAPP_INHOSPITAL_NAVIGATION();
				
			ss.ID = ID;
			
			db.FillDataSet(ss,ds,"YWAPP_INHOSPITAL_NAVIGATION");
			return ds;

		} // Data_SelectByIDYWAPP_INHOSPITAL_NAVIGATION
		#endregion
		
		#region Data_IN_NAVIGATION_SelectAll
		/// 
		/// 对于SelectAll的类的实现（数据库操作）。
		/// 
		public DataSetIN_NAVIGATION  Data_IN_NAVIGATION_SelectAll ( string sTj )
		{
			DataSetIN_NAVIGATION ds = new DataSetIN_NAVIGATION();
			SS_IN_NAVIGATION_SelectAll ss = new SS_IN_NAVIGATION_SelectAll();
			
			ss.SqlString = ss.SqlString.Replace("1=1",sTj);
			
			db.FillDataSet(ss,ds,"YWAPP_INHOSPITAL_NAVIGATION");
			return ds;

		} // Data_SelectAll
		#endregion
		
				
		//存储过程
		
			
		
		///update更新
		
		#region Data_IN_NAVIGATION_DeleteYWAPP_INHOSPITAL_NAVIGATION
		/// 
		/// 对于DeleteYWAPP_INHOSPITAL_NAVIGATION的类的实现（数据库操作）。
		/// 
		public int Data_IN_NAVIGATION_DeleteYWAPP_INHOSPITAL_NAVIGATION ( System.String ID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_IN_NAVIGATION_DeleteYWAPP_INHOSPITAL_NAVIGATION ss = new SS_IN_NAVIGATION_DeleteYWAPP_INHOSPITAL_NAVIGATION();
				
			ss.ID = ID;
			
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
		} // Data_DeleteYWAPP_INHOSPITAL_NAVIGATION
		#endregion	
		
		#region Data_IN_NAVIGATION_UpdateYWAPP_INHOSPITAL_NAVIGATION
		/// 
		/// 对于UpdateYWAPP_INHOSPITAL_NAVIGATION的类的实现（数据库操作）。
		/// 
		public int Data_IN_NAVIGATION_UpdateYWAPP_INHOSPITAL_NAVIGATION ( System.String HOSPITALID , System.String ID , System.String FLOORNAME , System.Byte[] FLOORMAP , System.String OLDID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_IN_NAVIGATION_UpdateYWAPP_INHOSPITAL_NAVIGATION ss = new SS_IN_NAVIGATION_UpdateYWAPP_INHOSPITAL_NAVIGATION();
				
			ss.HOSPITALID = HOSPITALID;
				
			ss.ID = ID;
				
			ss.FLOORNAME = FLOORNAME;
				
			ss.FLOORMAP = FLOORMAP;
				
			ss.OLDID = OLDID;
			
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
		} // Data_UpdateYWAPP_INHOSPITAL_NAVIGATION
		#endregion	
			
				
		//end modify
	}
}
	