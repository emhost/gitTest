//------------------------------------------------------------------------------
//     这部分代码属于实体控制层，是由实体编辑器工具自动产生的。
//     (Runtime Version: 2.2017.3.2)
//     对此代码进行的任何修改会导致其它的行为错误，并且重新生成时所有的修改会丢失。
//------------------------------------------------------------------------------

using System;
using System.Data;
using HYGHSF.Entity;
//using Gyd.TaskInfo;
using System.Collections;
using PhoenixDataBaseConnect;
using PhoenixDataBaseOperate;

namespace HYGHSF.DAO
{
	/// 
	/// 对于GHSF_REGPLANBaseDAO的类的实现（基础控制部分）。
	/// 对于扩展的DAO的实现可以从这个类继承。
	/// 
	public class GHSF_REGPLANBaseDAO : MarshalByRefObject , IDisposable
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
		public GHSF_REGPLANBaseDAO()
		{
			//db = DataAccessFactory.Create();
			db = GenerateFactory.GenerateConnect(0);
			//db.Open();
		}
		
		/// 
		/// 结构化一个BaseDAO。
		/// 
		/// 给定的数据库连接。
		
		//public GHSF_REGPLANBaseDAO(IDataAccess cdb)
		public GHSF_REGPLANBaseDAO(IDataBaseOperate cdb)
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
		/// 插入一个GHSF_REGPLAN实体到数据库。
		/// 
		/// 将要插入的实体
		public int InsertEntity(DataSetGHSF_REGPLAN entity)
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
				
				foreach(DataRow row in entity.Tables["GHSF_GHSF_REGPLAN"].Rows)
				{	
					int j= db.exeSql(new SS_GHSF_REGPLAN_InsertGHSF_GHSF_REGPLAN(), row);
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
		/// 更新GHSF_REGPLAN实体到数据库。
		/// 
		/// 将要更新的实体
		public int UpdateEntity(DataSetGHSF_REGPLAN entity)
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
				
				foreach(DataRow row in entity.Tables["GHSF_GHSF_REGPLAN"].Rows)
        {
          int j =	db.exeSql(new SS_GHSF_REGPLAN_UpdateGHSF_GHSF_REGPLAN(), row);
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
		/// 从数据库中删除GHSF_REGPLAN实体。
		/// 
		/// 将要删除的实体
		public int DeleteEntity(DataSetGHSF_REGPLAN entity)
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
				
				foreach(DataRow row in entity.Tables["GHSF_GHSF_REGPLAN"].Rows)
				{
					int j = db.exeSql(new SS_GHSF_REGPLAN_DeleteGHSF_GHSF_REGPLAN(), row);
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
		/// 按照GHSF_REGPLAN实体的主表的主键查询数据。
		/// 
		/// 主键的值
		public DataSetGHSF_REGPLAN FindByPrimaryKey(object KeyValue)
		{
			DataSetGHSF_REGPLAN entity = new DataSetGHSF_REGPLAN();
			SS_GHSF_REGPLAN_SelectByIDGHSF_GHSF_REGPLAN ss = new SS_GHSF_REGPLAN_SelectByIDGHSF_GHSF_REGPLAN();
			ss.Params[0].Value = KeyValue;
			db.FillDataSet(ss, entity, "GHSF_GHSF_REGPLAN");
					
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
		public int CommitChanges(DataSetGHSF_REGPLAN entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			db.SetUpdateControl(alUpdateControl);
			db.SetUpdateColumn(alUpdateColumn);
		  int iRet =	CommitChanges(entity, drs);
      db.SetUpdateControl(null);
			db.SetUpdateColumn(null);
      return iRet;
		}
		///////////////// 
		
				
		public int CommitChanges(DataSetGHSF_REGPLAN entity, DataRowState drs)
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



    public int CommitChanges(DataSetGHSF_REGPLAN entity)
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

		public int CommitChanges(DataSetGHSF_REGPLAN entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			this.alUpdateColumn = alUpdateColumn;
			this.alUpdateControl = alUpdateControl;
		  return	CommitChanges(entity);
		}
		/////////////				
		#endregion

		//// 2006-09-11
		public DataSetGHSF_REGPLAN GetDataSet(SqlClass sC,string sTableName)
		{
			DataSetGHSF_REGPLAN ds = new  DataSetGHSF_REGPLAN();
			db.FillDataSet(sC,ds,sTableName);
			return ds;
		}
		
		#region CheckData		
		/// 
		/// 校验数据输入的有效性。
		/// 
		/// 要检验的实体
		protected void CheckData(DataSetGHSF_REGPLAN entity)
		{
			//在这里可以加入操作之前所需要对实体检验的代码
		}
		#endregion
		
		//wuqb modify 2007-03-27

		
		
		//强名DataSet
		
		#region Data_GHSF_REGPLAN_SelectByIDGHSF_GHSF_REGPLAN
		/// 
		/// 对于SelectByIDGHSF_GHSF_REGPLAN的类的实现（数据库操作）。
		/// 
		public DataSetGHSF_REGPLAN  Data_GHSF_REGPLAN_SelectByIDGHSF_GHSF_REGPLAN (System.String VPLANID)
		{
			DataSetGHSF_REGPLAN ds = new DataSetGHSF_REGPLAN();
			SS_GHSF_REGPLAN_SelectByIDGHSF_GHSF_REGPLAN ss = new SS_GHSF_REGPLAN_SelectByIDGHSF_GHSF_REGPLAN();
				
			ss.VPLANID = VPLANID;
			
			db.FillDataSet(ss,ds,"GHSF_GHSF_REGPLAN");
			return ds;

		} // Data_SelectByIDGHSF_GHSF_REGPLAN
		#endregion
		
		#region Data_GHSF_REGPLAN_SelectAll
		/// 
		/// 对于SelectAll的类的实现（数据库操作）。
		/// 
		public DataSetGHSF_REGPLAN  Data_GHSF_REGPLAN_SelectAll ( string sTj )
		{
			DataSetGHSF_REGPLAN ds = new DataSetGHSF_REGPLAN();
			SS_GHSF_REGPLAN_SelectAll ss = new SS_GHSF_REGPLAN_SelectAll();
			
			ss.SqlString = ss.SqlString.Replace("1=1",sTj);
			
			db.FillDataSet(ss,ds,"GHSF_GHSF_REGPLAN");
			return ds;

		} // Data_SelectAll
		#endregion
		
				
		//存储过程
		
			
		
		///update更新
		
		#region Data_GHSF_REGPLAN_DeleteGHSF_GHSF_REGPLAN
		/// 
		/// 对于DeleteGHSF_GHSF_REGPLAN的类的实现（数据库操作）。
		/// 
		public int Data_GHSF_REGPLAN_DeleteGHSF_GHSF_REGPLAN ( System.String VPLANID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_GHSF_REGPLAN_DeleteGHSF_GHSF_REGPLAN ss = new SS_GHSF_REGPLAN_DeleteGHSF_GHSF_REGPLAN();
				
			ss.VPLANID = VPLANID;
			
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
		} // Data_DeleteGHSF_GHSF_REGPLAN
		#endregion	
		
		#region Data_GHSF_REGPLAN_UpdateGHSF_GHSF_REGPLAN
		/// 
		/// 对于UpdateGHSF_GHSF_REGPLAN的类的实现（数据库操作）。
		/// 
		public int Data_GHSF_REGPLAN_UpdateGHSF_GHSF_REGPLAN ( System.String VPLANID , System.String VDOCTORID , System.Decimal NTIMEDESC , System.Decimal NREGLIMITS , System.Decimal NAPPLIMITS , System.Decimal NREGNUMBER , System.Decimal NAPPNUMBER , System.Decimal NREGPRICE , System.String VOPERATORID , System.DateTime DCREATEDATE , System.String VREMARKS , System.DateTime DCLINICDATE , System.String VDEPTID , System.Decimal NHOSID , System.String OLDVPLANID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_GHSF_REGPLAN_UpdateGHSF_GHSF_REGPLAN ss = new SS_GHSF_REGPLAN_UpdateGHSF_GHSF_REGPLAN();
				
			ss.VPLANID = VPLANID;
				
			ss.VDOCTORID = VDOCTORID;
				
			ss.NTIMEDESC = NTIMEDESC;
				
			ss.NREGLIMITS = NREGLIMITS;
				
			ss.NAPPLIMITS = NAPPLIMITS;
				
			ss.NREGNUMBER = NREGNUMBER;
				
			ss.NAPPNUMBER = NAPPNUMBER;
				
			ss.NREGPRICE = NREGPRICE;
				
			ss.VOPERATORID = VOPERATORID;
				
			ss.DCREATEDATE = DCREATEDATE;
				
			ss.VREMARKS = VREMARKS;
				
			ss.DCLINICDATE = DCLINICDATE;
				
			ss.VDEPTID = VDEPTID;
				
			ss.NHOSID = NHOSID;
				
			ss.OLDVPLANID = OLDVPLANID;
			
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
		} // Data_UpdateGHSF_GHSF_REGPLAN
		#endregion	
			
				
		//end modify
	}
}
	