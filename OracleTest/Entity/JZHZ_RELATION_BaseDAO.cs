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
	/// 对于JZHZ_RELATIONBaseDAO的类的实现（基础控制部分）。
	/// 对于扩展的DAO的实现可以从这个类继承。
	/// 
	public class JZHZ_RELATIONBaseDAO : MarshalByRefObject , IDisposable
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
		public JZHZ_RELATIONBaseDAO()
		{
			//db = DataAccessFactory.Create();
			db = GenerateFactory.GenerateConnect(0);
			//db.Open();
		}
		
		/// 
		/// 结构化一个BaseDAO。
		/// 
		/// 给定的数据库连接。
		
		//public JZHZ_RELATIONBaseDAO(IDataAccess cdb)
		public JZHZ_RELATIONBaseDAO(IDataBaseOperate cdb)
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
		/// 插入一个JZHZ_RELATION实体到数据库。
		/// 
		/// 将要插入的实体
		public int InsertEntity(DataSetJZHZ_RELATION entity)
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
				
				foreach(DataRow row in entity.Tables["JZHZ_RELATION"].Rows)
				{	
					int j= db.exeSql(new SS_JZHZ_RELATION_InsertJZHZ_RELATION(), row);
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
		/// 更新JZHZ_RELATION实体到数据库。
		/// 
		/// 将要更新的实体
		public int UpdateEntity(DataSetJZHZ_RELATION entity)
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
				
				foreach(DataRow row in entity.Tables["JZHZ_RELATION"].Rows)
        {
          int j =	db.exeSql(new SS_JZHZ_RELATION_UpdateJZHZ_RELATION(), row);
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
		/// 从数据库中删除JZHZ_RELATION实体。
		/// 
		/// 将要删除的实体
		public int DeleteEntity(DataSetJZHZ_RELATION entity)
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
				
				foreach(DataRow row in entity.Tables["JZHZ_RELATION"].Rows)
				{
					int j = db.exeSql(new SS_JZHZ_RELATION_DeleteJZHZ_RELATION(), row);
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
		/// 按照JZHZ_RELATION实体的主表的主键查询数据。
		/// 
		/// 主键的值
		public DataSetJZHZ_RELATION FindByPrimaryKey(object KeyValue)
		{
			DataSetJZHZ_RELATION entity = new DataSetJZHZ_RELATION();
			SS_JZHZ_RELATION_SelectByIDJZHZ_RELATION ss = new SS_JZHZ_RELATION_SelectByIDJZHZ_RELATION();
			ss.Params[0].Value = KeyValue;
			db.FillDataSet(ss, entity, "JZHZ_RELATION");
					
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
		public int CommitChanges(DataSetJZHZ_RELATION entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			db.SetUpdateControl(alUpdateControl);
			db.SetUpdateColumn(alUpdateColumn);
		  int iRet =	CommitChanges(entity, drs);
      db.SetUpdateControl(null);
			db.SetUpdateColumn(null);
      return iRet;
		}
		///////////////// 
		
				
		public int CommitChanges(DataSetJZHZ_RELATION entity, DataRowState drs)
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



    public int CommitChanges(DataSetJZHZ_RELATION entity)
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

		public int CommitChanges(DataSetJZHZ_RELATION entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			this.alUpdateColumn = alUpdateColumn;
			this.alUpdateControl = alUpdateControl;
		  return	CommitChanges(entity);
		}
		/////////////				
		#endregion

		//// 2006-09-11
		public DataSetJZHZ_RELATION GetDataSet(SqlClass sC,string sTableName)
		{
			DataSetJZHZ_RELATION ds = new  DataSetJZHZ_RELATION();
			db.FillDataSet(sC,ds,sTableName);
			return ds;
		}
		
		#region CheckData		
		/// 
		/// 校验数据输入的有效性。
		/// 
		/// 要检验的实体
		protected void CheckData(DataSetJZHZ_RELATION entity)
		{
			//在这里可以加入操作之前所需要对实体检验的代码
		}
		#endregion
		
		//wuqb modify 2007-03-27

		
		
		//强名DataSet
		
		#region Data_JZHZ_RELATION_SelectByIDJZHZ_RELATION
		/// 
		/// 对于SelectByIDJZHZ_RELATION的类的实现（数据库操作）。
		/// 
		public DataSetJZHZ_RELATION  Data_JZHZ_RELATION_SelectByIDJZHZ_RELATION (System.String ID)
		{
			DataSetJZHZ_RELATION ds = new DataSetJZHZ_RELATION();
			SS_JZHZ_RELATION_SelectByIDJZHZ_RELATION ss = new SS_JZHZ_RELATION_SelectByIDJZHZ_RELATION();
				
			ss.ID = ID;
			
			db.FillDataSet(ss,ds,"JZHZ_RELATION");
			return ds;

		} // Data_SelectByIDJZHZ_RELATION
		#endregion
		
		#region Data_JZHZ_RELATION_SelectAll
		/// 
		/// 对于SelectAll的类的实现（数据库操作）。
		/// 
		public DataSetJZHZ_RELATION  Data_JZHZ_RELATION_SelectAll ( string sTj )
		{
			DataSetJZHZ_RELATION ds = new DataSetJZHZ_RELATION();
			SS_JZHZ_RELATION_SelectAll ss = new SS_JZHZ_RELATION_SelectAll();
			
			ss.SqlString = ss.SqlString.Replace("1=1",sTj);
			
			db.FillDataSet(ss,ds,"JZHZ_RELATION");
			return ds;

		} // Data_SelectAll
		#endregion
		
				
		//存储过程
		
			
		
		///update更新
		
		#region Data_JZHZ_RELATION_DeleteJZHZ_RELATION
		/// 
		/// 对于DeleteJZHZ_RELATION的类的实现（数据库操作）。
		/// 
		public int Data_JZHZ_RELATION_DeleteJZHZ_RELATION ( System.String ID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_JZHZ_RELATION_DeleteJZHZ_RELATION ss = new SS_JZHZ_RELATION_DeleteJZHZ_RELATION();
				
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
		} // Data_DeleteJZHZ_RELATION
		#endregion	
		
		#region Data_JZHZ_RELATION_UpdateJZHZ_RELATION
		/// 
		/// 对于UpdateJZHZ_RELATION的类的实现（数据库操作）。
		/// 
		public int Data_JZHZ_RELATION_UpdateJZHZ_RELATION ( System.Decimal NISDEF , System.String ID , System.Decimal NPHONE , System.String VNAME , System.String VSFZH , System.String VCARD , System.String VGX , System.String VGLID , System.String VPYM , System.String NSEX , System.DateTime DBIRTHDAY , System.String VPATIENTID , System.DateTime DCREATE , System.String OLDID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_JZHZ_RELATION_UpdateJZHZ_RELATION ss = new SS_JZHZ_RELATION_UpdateJZHZ_RELATION();
				
			ss.NISDEF = NISDEF;
				
			ss.ID = ID;
				
			ss.NPHONE = NPHONE;
				
			ss.VNAME = VNAME;
				
			ss.VSFZH = VSFZH;
				
			ss.VCARD = VCARD;
				
			ss.VGX = VGX;
				
			ss.VGLID = VGLID;
				
			ss.VPYM = VPYM;
				
			ss.NSEX = NSEX;
				
			ss.DBIRTHDAY = DBIRTHDAY;
				
			ss.VPATIENTID = VPATIENTID;
				
			ss.DCREATE = DCREATE;
				
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
		} // Data_UpdateJZHZ_RELATION
		#endregion	
			
				
		//end modify
	}
}
	