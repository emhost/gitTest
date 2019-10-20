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
	/// 对于TJ_PACKAGESECONBaseDAO的类的实现（基础控制部分）。
	/// 对于扩展的DAO的实现可以从这个类继承。
	/// 
	public class TJ_PACKAGESECONBaseDAO : MarshalByRefObject , IDisposable
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
		public TJ_PACKAGESECONBaseDAO()
		{
			//db = DataAccessFactory.Create();
			db = GenerateFactory.GenerateConnect(0);
			//db.Open();
		}
		
		/// 
		/// 结构化一个BaseDAO。
		/// 
		/// 给定的数据库连接。
		
		//public TJ_PACKAGESECONBaseDAO(IDataAccess cdb)
		public TJ_PACKAGESECONBaseDAO(IDataBaseOperate cdb)
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
		/// 插入一个TJ_PACKAGESECON实体到数据库。
		/// 
		/// 将要插入的实体
		public int InsertEntity(DataSetTJ_PACKAGESECON entity)
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
				
				foreach(DataRow row in entity.Tables["TJ_TJ_PACKAGESECON"].Rows)
				{	
					int j= db.exeSql(new SS_TJ_PACKAGESECON_InsertTJ_TJ_PACKAGESECON(), row);
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
		/// 更新TJ_PACKAGESECON实体到数据库。
		/// 
		/// 将要更新的实体
		public int UpdateEntity(DataSetTJ_PACKAGESECON entity)
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
				
				foreach(DataRow row in entity.Tables["TJ_TJ_PACKAGESECON"].Rows)
        {
          int j =	db.exeSql(new SS_TJ_PACKAGESECON_UpdateTJ_TJ_PACKAGESECON(), row);
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
		/// 从数据库中删除TJ_PACKAGESECON实体。
		/// 
		/// 将要删除的实体
		public int DeleteEntity(DataSetTJ_PACKAGESECON entity)
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
				
				foreach(DataRow row in entity.Tables["TJ_TJ_PACKAGESECON"].Rows)
				{
					int j = db.exeSql(new SS_TJ_PACKAGESECON_DeleteTJ_TJ_PACKAGESECON(), row);
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
		/// 按照TJ_PACKAGESECON实体的主表的主键查询数据。
		/// 
		/// 主键的值
		public DataSetTJ_PACKAGESECON FindByPrimaryKey(object KeyValue)
		{
			DataSetTJ_PACKAGESECON entity = new DataSetTJ_PACKAGESECON();
			SS_TJ_PACKAGESECON_SelectByIDTJ_TJ_PACKAGESECON ss = new SS_TJ_PACKAGESECON_SelectByIDTJ_TJ_PACKAGESECON();
			ss.Params[0].Value = KeyValue;
			db.FillDataSet(ss, entity, "TJ_TJ_PACKAGESECON");
					
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
		public int CommitChanges(DataSetTJ_PACKAGESECON entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			db.SetUpdateControl(alUpdateControl);
			db.SetUpdateColumn(alUpdateColumn);
		  int iRet =	CommitChanges(entity, drs);
      db.SetUpdateControl(null);
			db.SetUpdateColumn(null);
      return iRet;
		}
		///////////////// 
		
				
		public int CommitChanges(DataSetTJ_PACKAGESECON entity, DataRowState drs)
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



    public int CommitChanges(DataSetTJ_PACKAGESECON entity)
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

		public int CommitChanges(DataSetTJ_PACKAGESECON entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			this.alUpdateColumn = alUpdateColumn;
			this.alUpdateControl = alUpdateControl;
		  return	CommitChanges(entity);
		}
		/////////////				
		#endregion

		//// 2006-09-11
		public DataSetTJ_PACKAGESECON GetDataSet(SqlClass sC,string sTableName)
		{
			DataSetTJ_PACKAGESECON ds = new  DataSetTJ_PACKAGESECON();
			db.FillDataSet(sC,ds,sTableName);
			return ds;
		}
		
		#region CheckData		
		/// 
		/// 校验数据输入的有效性。
		/// 
		/// 要检验的实体
		protected void CheckData(DataSetTJ_PACKAGESECON entity)
		{
			//在这里可以加入操作之前所需要对实体检验的代码
		}
		#endregion
		
		//wuqb modify 2007-03-27

		
		
		//强名DataSet
		
		#region Data_TJ_PACKAGESECON_SelectByIDTJ_TJ_PACKAGESECON
		/// 
		/// 对于SelectByIDTJ_TJ_PACKAGESECON的类的实现（数据库操作）。
		/// 
		public DataSetTJ_PACKAGESECON  Data_TJ_PACKAGESECON_SelectByIDTJ_TJ_PACKAGESECON (System.String NSECID)
		{
			DataSetTJ_PACKAGESECON ds = new DataSetTJ_PACKAGESECON();
			SS_TJ_PACKAGESECON_SelectByIDTJ_TJ_PACKAGESECON ss = new SS_TJ_PACKAGESECON_SelectByIDTJ_TJ_PACKAGESECON();
				
			ss.NSECID = NSECID;
			
			db.FillDataSet(ss,ds,"TJ_TJ_PACKAGESECON");
			return ds;

		} // Data_SelectByIDTJ_TJ_PACKAGESECON
		#endregion
		
		#region Data_TJ_PACKAGESECON_SelectAll
		/// 
		/// 对于SelectAll的类的实现（数据库操作）。
		/// 
		public DataSetTJ_PACKAGESECON  Data_TJ_PACKAGESECON_SelectAll ( string sTj )
		{
			DataSetTJ_PACKAGESECON ds = new DataSetTJ_PACKAGESECON();
			SS_TJ_PACKAGESECON_SelectAll ss = new SS_TJ_PACKAGESECON_SelectAll();
			
			ss.SqlString = ss.SqlString.Replace("1=1",sTj);
			
			db.FillDataSet(ss,ds,"TJ_TJ_PACKAGESECON");
			return ds;

		} // Data_SelectAll
		#endregion
		
				
		//存储过程
		
			
		
		///update更新
		
		#region Data_TJ_PACKAGESECON_DeleteTJ_TJ_PACKAGESECON
		/// 
		/// 对于DeleteTJ_TJ_PACKAGESECON的类的实现（数据库操作）。
		/// 
		public int Data_TJ_PACKAGESECON_DeleteTJ_TJ_PACKAGESECON ( System.String NSECID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_TJ_PACKAGESECON_DeleteTJ_TJ_PACKAGESECON ss = new SS_TJ_PACKAGESECON_DeleteTJ_TJ_PACKAGESECON();
				
			ss.NSECID = NSECID;
			
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
		} // Data_DeleteTJ_TJ_PACKAGESECON
		#endregion	
		
		#region Data_TJ_PACKAGESECON_UpdateTJ_TJ_PACKAGESECON
		/// 
		/// 对于UpdateTJ_TJ_PACKAGESECON的类的实现（数据库操作）。
		/// 
		public int Data_TJ_PACKAGESECON_UpdateTJ_TJ_PACKAGESECON ( System.String CREATEDEPARTID , System.String CREATEDEPARTNAME , System.String NSECID , System.String NPACKAGEID , System.String NITEMID , System.String VITEMNAME , System.Decimal NVPRICE , System.Decimal NISDISCOUNTS , System.Decimal NDISCOUNTS , System.Decimal NMONEY , System.DateTime CREATEDATE , System.String CREATESTAFFCODE , System.String CREATESTAFFNAME , System.String OLDNSECID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_TJ_PACKAGESECON_UpdateTJ_TJ_PACKAGESECON ss = new SS_TJ_PACKAGESECON_UpdateTJ_TJ_PACKAGESECON();
				
			ss.CREATEDEPARTID = CREATEDEPARTID;
				
			ss.CREATEDEPARTNAME = CREATEDEPARTNAME;
				
			ss.NSECID = NSECID;
				
			ss.NPACKAGEID = NPACKAGEID;
				
			ss.NITEMID = NITEMID;
				
			ss.VITEMNAME = VITEMNAME;
				
			ss.NVPRICE = NVPRICE;
				
			ss.NISDISCOUNTS = NISDISCOUNTS;
				
			ss.NDISCOUNTS = NDISCOUNTS;
				
			ss.NMONEY = NMONEY;
				
			ss.CREATEDATE = CREATEDATE;
				
			ss.CREATESTAFFCODE = CREATESTAFFCODE;
				
			ss.CREATESTAFFNAME = CREATESTAFFNAME;
				
			ss.OLDNSECID = OLDNSECID;
			
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
		} // Data_UpdateTJ_TJ_PACKAGESECON
		#endregion	
			
				
		//end modify
	}
}
	