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
	/// 对于HOSPITALINTRODUCTIONBaseDAO的类的实现（基础控制部分）。
	/// 对于扩展的DAO的实现可以从这个类继承。
	/// 
	public class HOSPITALINTRODUCTIONBaseDAO : MarshalByRefObject , IDisposable
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
		public HOSPITALINTRODUCTIONBaseDAO()
		{
			//db = DataAccessFactory.Create();
			db = GenerateFactory.GenerateConnect(0);
			//db.Open();
		}
		
		/// 
		/// 结构化一个BaseDAO。
		/// 
		/// 给定的数据库连接。
		
		//public HOSPITALINTRODUCTIONBaseDAO(IDataAccess cdb)
		public HOSPITALINTRODUCTIONBaseDAO(IDataBaseOperate cdb)
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
		/// 插入一个HOSPITALINTRODUCTION实体到数据库。
		/// 
		/// 将要插入的实体
		public int InsertEntity(DataSetHOSPITALINTRODUCTION entity)
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
				
				foreach(DataRow row in entity.Tables["YWAPP_HOSPITAL_INTRODUCTION"].Rows)
				{	
					int j= db.exeSql(new SS_HOSPITALINTRODUCTION_InsertYWAPP_HOSPITAL_INTRODUCTION(), row);
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
		/// 更新HOSPITALINTRODUCTION实体到数据库。
		/// 
		/// 将要更新的实体
		public int UpdateEntity(DataSetHOSPITALINTRODUCTION entity)
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
				
				foreach(DataRow row in entity.Tables["YWAPP_HOSPITAL_INTRODUCTION"].Rows)
        {
          int j =	db.exeSql(new SS_HOSPITALINTRODUCTION_UpdateYWAPP_HOSPITAL_INTRODUCTION(), row);
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
		/// 从数据库中删除HOSPITALINTRODUCTION实体。
		/// 
		/// 将要删除的实体
		public int DeleteEntity(DataSetHOSPITALINTRODUCTION entity)
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
				
				foreach(DataRow row in entity.Tables["YWAPP_HOSPITAL_INTRODUCTION"].Rows)
				{
					int j = db.exeSql(new SS_HOSPITALINTRODUCTION_DeleteYWAPP_HOSPITAL_INTRODUCTION(), row);
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
		/// 按照HOSPITALINTRODUCTION实体的主表的主键查询数据。
		/// 
		/// 主键的值
		public DataSetHOSPITALINTRODUCTION FindByPrimaryKey(object KeyValue)
		{
			DataSetHOSPITALINTRODUCTION entity = new DataSetHOSPITALINTRODUCTION();
			SS_HOSPITALINTRODUCTION_SelectByIDYWAPP_HOSPITAL_INTRODUCTION ss = new SS_HOSPITALINTRODUCTION_SelectByIDYWAPP_HOSPITAL_INTRODUCTION();
			ss.Params[0].Value = KeyValue;
			db.FillDataSet(ss, entity, "YWAPP_HOSPITAL_INTRODUCTION");
					
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
		public int CommitChanges(DataSetHOSPITALINTRODUCTION entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			db.SetUpdateControl(alUpdateControl);
			db.SetUpdateColumn(alUpdateColumn);
		  int iRet =	CommitChanges(entity, drs);
      db.SetUpdateControl(null);
			db.SetUpdateColumn(null);
      return iRet;
		}
		///////////////// 
		
				
		public int CommitChanges(DataSetHOSPITALINTRODUCTION entity, DataRowState drs)
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



    public int CommitChanges(DataSetHOSPITALINTRODUCTION entity)
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

		public int CommitChanges(DataSetHOSPITALINTRODUCTION entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			this.alUpdateColumn = alUpdateColumn;
			this.alUpdateControl = alUpdateControl;
		  return	CommitChanges(entity);
		}
		/////////////				
		#endregion

		//// 2006-09-11
		public DataSetHOSPITALINTRODUCTION GetDataSet(SqlClass sC,string sTableName)
		{
			DataSetHOSPITALINTRODUCTION ds = new  DataSetHOSPITALINTRODUCTION();
			db.FillDataSet(sC,ds,sTableName);
			return ds;
		}
		
		#region CheckData		
		/// 
		/// 校验数据输入的有效性。
		/// 
		/// 要检验的实体
		protected void CheckData(DataSetHOSPITALINTRODUCTION entity)
		{
			//在这里可以加入操作之前所需要对实体检验的代码
		}
		#endregion
		
		//wuqb modify 2007-03-27

		
		
		//强名DataSet
		
		#region Data_HOSPITALINTRODUCTION_SelectByIDYWAPP_HOSPITAL_INTRODUCTION
		/// 
		/// 对于SelectByIDYWAPP_HOSPITAL_INTRODUCTION的类的实现（数据库操作）。
		/// 
		public DataSetHOSPITALINTRODUCTION  Data_HOSPITALINTRODUCTION_SelectByIDYWAPP_HOSPITAL_INTRODUCTION (System.String ID)
		{
			DataSetHOSPITALINTRODUCTION ds = new DataSetHOSPITALINTRODUCTION();
			SS_HOSPITALINTRODUCTION_SelectByIDYWAPP_HOSPITAL_INTRODUCTION ss = new SS_HOSPITALINTRODUCTION_SelectByIDYWAPP_HOSPITAL_INTRODUCTION();
				
			ss.ID = ID;
			
			db.FillDataSet(ss,ds,"YWAPP_HOSPITAL_INTRODUCTION");
			return ds;

		} // Data_SelectByIDYWAPP_HOSPITAL_INTRODUCTION
		#endregion
		
		#region Data_HOSPITALINTRODUCTION_SelectAll
		/// 
		/// 对于SelectAll的类的实现（数据库操作）。
		/// 
		public DataSetHOSPITALINTRODUCTION  Data_HOSPITALINTRODUCTION_SelectAll ( string sTj )
		{
			DataSetHOSPITALINTRODUCTION ds = new DataSetHOSPITALINTRODUCTION();
			SS_HOSPITALINTRODUCTION_SelectAll ss = new SS_HOSPITALINTRODUCTION_SelectAll();
			
			ss.SqlString = ss.SqlString.Replace("1=1",sTj);
			
			db.FillDataSet(ss,ds,"YWAPP_HOSPITAL_INTRODUCTION");
			return ds;

		} // Data_SelectAll
		#endregion
		
				
		//存储过程
		
			
		
		///update更新
		
		#region Data_HOSPITALINTRODUCTION_DeleteYWAPP_HOSPITAL_INTRODUCTION
		/// 
		/// 对于DeleteYWAPP_HOSPITAL_INTRODUCTION的类的实现（数据库操作）。
		/// 
		public int Data_HOSPITALINTRODUCTION_DeleteYWAPP_HOSPITAL_INTRODUCTION ( System.String ID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_HOSPITALINTRODUCTION_DeleteYWAPP_HOSPITAL_INTRODUCTION ss = new SS_HOSPITALINTRODUCTION_DeleteYWAPP_HOSPITAL_INTRODUCTION();
				
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
		} // Data_DeleteYWAPP_HOSPITAL_INTRODUCTION
		#endregion	
		
		#region Data_HOSPITALINTRODUCTION_UpdateYWAPP_HOSPITAL_INTRODUCTION
		/// 
		/// 对于UpdateYWAPP_HOSPITAL_INTRODUCTION的类的实现（数据库操作）。
		/// 
		public int Data_HOSPITALINTRODUCTION_UpdateYWAPP_HOSPITAL_INTRODUCTION ( System.String ID , System.String HOSPITALNAME , System.String HOSPITALADDRESS , System.String HOSPITALTEL , System.String HOSPITALINTRODUCTION , System.String REMARKS , System.Decimal ISENABLE , System.Byte[] PHOTO , System.Byte[] PHOTO1 , System.Byte[] PHOTO2 , System.String HOSPITALID , System.String OLDID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_HOSPITALINTRODUCTION_UpdateYWAPP_HOSPITAL_INTRODUCTION ss = new SS_HOSPITALINTRODUCTION_UpdateYWAPP_HOSPITAL_INTRODUCTION();
				
			ss.ID = ID;
				
			ss.HOSPITALNAME = HOSPITALNAME;
				
			ss.HOSPITALADDRESS = HOSPITALADDRESS;
				
			ss.HOSPITALTEL = HOSPITALTEL;
				
			ss.HOSPITALINTRODUCTION = HOSPITALINTRODUCTION;
				
			ss.REMARKS = REMARKS;
				
			ss.ISENABLE = ISENABLE;
				
			ss.PHOTO = PHOTO;
				
			ss.PHOTO1 = PHOTO1;
				
			ss.PHOTO2 = PHOTO2;
				
			ss.HOSPITALID = HOSPITALID;
				
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
		} // Data_UpdateYWAPP_HOSPITAL_INTRODUCTION
		#endregion	
			
				
		//end modify
	}
}
	