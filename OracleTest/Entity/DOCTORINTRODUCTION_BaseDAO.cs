//------------------------------------------------------------------------------
//     这部分代码属于实体控制层，是由实体编辑器工具自动产生的。
//     (Runtime Version: 2.2017.3.2)
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
	/// 对于DOCTORINTRODUCTIONBaseDAO的类的实现（基础控制部分）。
	/// 对于扩展的DAO的实现可以从这个类继承。
	/// 
	public class DOCTORINTRODUCTIONBaseDAO : MarshalByRefObject , IDisposable
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
		public DOCTORINTRODUCTIONBaseDAO()
		{
			//db = DataAccessFactory.Create();
			db = GenerateFactory.GenerateConnect(0);
			//db.Open();
		}
		
		/// 
		/// 结构化一个BaseDAO。
		/// 
		/// 给定的数据库连接。
		
		//public DOCTORINTRODUCTIONBaseDAO(IDataAccess cdb)
		public DOCTORINTRODUCTIONBaseDAO(IDataBaseOperate cdb)
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
		/// 插入一个DOCTORINTRODUCTION实体到数据库。
		/// 
		/// 将要插入的实体
		public int InsertEntity(DataSetDOCTORINTRODUCTION entity)
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
				
				foreach(DataRow row in entity.Tables["YWAPP_DOCTOR_INTRODUCTION"].Rows)
				{	
					int j= db.exeSql(new SS_DOCTORINTRODUCTION_InsertYWAPP_DOCTOR_INTRODUCTION(), row);
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
		/// 更新DOCTORINTRODUCTION实体到数据库。
		/// 
		/// 将要更新的实体
		public int UpdateEntity(DataSetDOCTORINTRODUCTION entity)
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
				
				foreach(DataRow row in entity.Tables["YWAPP_DOCTOR_INTRODUCTION"].Rows)
        {
          int j =	db.exeSql(new SS_DOCTORINTRODUCTION_UpdateYWAPP_DOCTOR_INTRODUCTION(), row);
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
		/// 从数据库中删除DOCTORINTRODUCTION实体。
		/// 
		/// 将要删除的实体
		public int DeleteEntity(DataSetDOCTORINTRODUCTION entity)
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
				
				foreach(DataRow row in entity.Tables["YWAPP_DOCTOR_INTRODUCTION"].Rows)
				{
					int j = db.exeSql(new SS_DOCTORINTRODUCTION_DeleteYWAPP_DOCTOR_INTRODUCTION(), row);
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
		/// 按照DOCTORINTRODUCTION实体的主表的主键查询数据。
		/// 
		/// 主键的值
		public DataSetDOCTORINTRODUCTION FindByPrimaryKey(object KeyValue)
		{
			DataSetDOCTORINTRODUCTION entity = new DataSetDOCTORINTRODUCTION();
			SS_DOCTORINTRODUCTION_SelectByIDYWAPP_DOCTOR_INTRODUCTION ss = new SS_DOCTORINTRODUCTION_SelectByIDYWAPP_DOCTOR_INTRODUCTION();
			ss.Params[0].Value = KeyValue;
			db.FillDataSet(ss, entity, "YWAPP_DOCTOR_INTRODUCTION");
					
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
		public int CommitChanges(DataSetDOCTORINTRODUCTION entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			db.SetUpdateControl(alUpdateControl);
			db.SetUpdateColumn(alUpdateColumn);
		  int iRet =	CommitChanges(entity, drs);
      db.SetUpdateControl(null);
			db.SetUpdateColumn(null);
      return iRet;
		}
		///////////////// 
		
				
		public int CommitChanges(DataSetDOCTORINTRODUCTION entity, DataRowState drs)
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



    public int CommitChanges(DataSetDOCTORINTRODUCTION entity)
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

		public int CommitChanges(DataSetDOCTORINTRODUCTION entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			this.alUpdateColumn = alUpdateColumn;
			this.alUpdateControl = alUpdateControl;
		  return	CommitChanges(entity);
		}
		/////////////				
		#endregion

		//// 2006-09-11
		public DataSetDOCTORINTRODUCTION GetDataSet(SqlClass sC,string sTableName)
		{
			DataSetDOCTORINTRODUCTION ds = new  DataSetDOCTORINTRODUCTION();
			db.FillDataSet(sC,ds,sTableName);
			return ds;
		}
		
		#region CheckData		
		/// 
		/// 校验数据输入的有效性。
		/// 
		/// 要检验的实体
		protected void CheckData(DataSetDOCTORINTRODUCTION entity)
		{
			//在这里可以加入操作之前所需要对实体检验的代码
		}
		#endregion
		
		//wuqb modify 2007-03-27

		
		
		//强名DataSet
		
		#region Data_DOCTORINTRODUCTION_SelectByIDYWAPP_DOCTOR_INTRODUCTION
		/// 
		/// 对于SelectByIDYWAPP_DOCTOR_INTRODUCTION的类的实现（数据库操作）。
		/// 
		public DataSetDOCTORINTRODUCTION  Data_DOCTORINTRODUCTION_SelectByIDYWAPP_DOCTOR_INTRODUCTION (System.String ID)
		{
			DataSetDOCTORINTRODUCTION ds = new DataSetDOCTORINTRODUCTION();
			SS_DOCTORINTRODUCTION_SelectByIDYWAPP_DOCTOR_INTRODUCTION ss = new SS_DOCTORINTRODUCTION_SelectByIDYWAPP_DOCTOR_INTRODUCTION();
				
			ss.ID = ID;
			
			db.FillDataSet(ss,ds,"YWAPP_DOCTOR_INTRODUCTION");
			return ds;

		} // Data_SelectByIDYWAPP_DOCTOR_INTRODUCTION
		#endregion
		
		#region Data_DOCTORINTRODUCTION_SelectALl
		/// 
		/// 对于SelectALl的类的实现（数据库操作）。
		/// 
		public DataSetDOCTORINTRODUCTION  Data_DOCTORINTRODUCTION_SelectALl ( string sTj )
		{
			DataSetDOCTORINTRODUCTION ds = new DataSetDOCTORINTRODUCTION();
			SS_DOCTORINTRODUCTION_SelectALl ss = new SS_DOCTORINTRODUCTION_SelectALl();
			
			ss.SqlString = ss.SqlString.Replace("1=1",sTj);
			
			db.FillDataSet(ss,ds,"YWAPP_DOCTOR_INTRODUCTION");
			return ds;

		} // Data_SelectALl
		#endregion
		
				
		//存储过程
		
			
		
		///update更新
		
		#region Data_DOCTORINTRODUCTION_DeleteYWAPP_DOCTOR_INTRODUCTION
		/// 
		/// 对于DeleteYWAPP_DOCTOR_INTRODUCTION的类的实现（数据库操作）。
		/// 
		public int Data_DOCTORINTRODUCTION_DeleteYWAPP_DOCTOR_INTRODUCTION ( System.String ID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_DOCTORINTRODUCTION_DeleteYWAPP_DOCTOR_INTRODUCTION ss = new SS_DOCTORINTRODUCTION_DeleteYWAPP_DOCTOR_INTRODUCTION();
				
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
		} // Data_DeleteYWAPP_DOCTOR_INTRODUCTION
		#endregion	
		
		#region Data_DOCTORINTRODUCTION_UpdateYWAPP_DOCTOR_INTRODUCTION
		/// 
		/// 对于UpdateYWAPP_DOCTOR_INTRODUCTION的类的实现（数据库操作）。
		/// 
		public int Data_DOCTORINTRODUCTION_UpdateYWAPP_DOCTOR_INTRODUCTION ( System.String VGOODAT , System.String ID , System.String VSTAFFCODE , System.String DOCTORINTRODUCTION , System.String REMARKS , System.Decimal ISENABLE , System.String SPECIALTY , System.String POSITION , System.Byte[] PHOTO , System.String VDEPARTCODE , System.String OLDID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_DOCTORINTRODUCTION_UpdateYWAPP_DOCTOR_INTRODUCTION ss = new SS_DOCTORINTRODUCTION_UpdateYWAPP_DOCTOR_INTRODUCTION();
				
			ss.VGOODAT = VGOODAT;
				
			ss.ID = ID;
				
			ss.VSTAFFCODE = VSTAFFCODE;
				
			ss.DOCTORINTRODUCTION = DOCTORINTRODUCTION;
				
			ss.REMARKS = REMARKS;
				
			ss.ISENABLE = ISENABLE;
				
			ss.SPECIALTY = SPECIALTY;
				
			ss.POSITION = POSITION;
				
			ss.PHOTO = PHOTO;
				
			ss.VDEPARTCODE = VDEPARTCODE;
				
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
		} // Data_UpdateYWAPP_DOCTOR_INTRODUCTION
		#endregion	
			
				
		//end modify
	}
}
	