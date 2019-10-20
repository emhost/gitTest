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
	/// 对于TJ_DICNODRUGITEMBaseDAO的类的实现（基础控制部分）。
	/// 对于扩展的DAO的实现可以从这个类继承。
	/// 
	public class TJ_DICNODRUGITEMBaseDAO : MarshalByRefObject , IDisposable
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
		public TJ_DICNODRUGITEMBaseDAO()
		{
			//db = DataAccessFactory.Create();
			db = GenerateFactory.GenerateConnect(0);
			//db.Open();
		}
		
		/// 
		/// 结构化一个BaseDAO。
		/// 
		/// 给定的数据库连接。
		
		//public TJ_DICNODRUGITEMBaseDAO(IDataAccess cdb)
		public TJ_DICNODRUGITEMBaseDAO(IDataBaseOperate cdb)
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
		/// 插入一个TJ_DICNODRUGITEM实体到数据库。
		/// 
		/// 将要插入的实体
		public int InsertEntity(DataSetTJ_DICNODRUGITEM entity)
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
				
				foreach(DataRow row in entity.Tables["TJ_TJ_DICNODRUGITEM"].Rows)
				{	
					int j= db.exeSql(new SS_TJ_DICNODRUGITEM_InsertTJ_TJ_DICNODRUGITEM(), row);
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
		/// 更新TJ_DICNODRUGITEM实体到数据库。
		/// 
		/// 将要更新的实体
		public int UpdateEntity(DataSetTJ_DICNODRUGITEM entity)
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
				
				foreach(DataRow row in entity.Tables["TJ_TJ_DICNODRUGITEM"].Rows)
        {
          int j =	db.exeSql(new SS_TJ_DICNODRUGITEM_UpdateTJ_TJ_DICNODRUGITEM(), row);
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
		/// 从数据库中删除TJ_DICNODRUGITEM实体。
		/// 
		/// 将要删除的实体
		public int DeleteEntity(DataSetTJ_DICNODRUGITEM entity)
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
				
				foreach(DataRow row in entity.Tables["TJ_TJ_DICNODRUGITEM"].Rows)
				{
					int j = db.exeSql(new SS_TJ_DICNODRUGITEM_DeleteTJ_TJ_DICNODRUGITEM(), row);
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
		/// 按照TJ_DICNODRUGITEM实体的主表的主键查询数据。
		/// 
		/// 主键的值
		public DataSetTJ_DICNODRUGITEM FindByPrimaryKey(object KeyValue)
		{
			DataSetTJ_DICNODRUGITEM entity = new DataSetTJ_DICNODRUGITEM();
			SS_TJ_DICNODRUGITEM_SelectByIDTJ_TJ_DICNODRUGITEM ss = new SS_TJ_DICNODRUGITEM_SelectByIDTJ_TJ_DICNODRUGITEM();
			ss.Params[0].Value = KeyValue;
			db.FillDataSet(ss, entity, "TJ_TJ_DICNODRUGITEM");
					
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
		public int CommitChanges(DataSetTJ_DICNODRUGITEM entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			db.SetUpdateControl(alUpdateControl);
			db.SetUpdateColumn(alUpdateColumn);
		  int iRet =	CommitChanges(entity, drs);
      db.SetUpdateControl(null);
			db.SetUpdateColumn(null);
      return iRet;
		}
		///////////////// 
		
				
		public int CommitChanges(DataSetTJ_DICNODRUGITEM entity, DataRowState drs)
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



    public int CommitChanges(DataSetTJ_DICNODRUGITEM entity)
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

		public int CommitChanges(DataSetTJ_DICNODRUGITEM entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			this.alUpdateColumn = alUpdateColumn;
			this.alUpdateControl = alUpdateControl;
		  return	CommitChanges(entity);
		}
		/////////////				
		#endregion

		//// 2006-09-11
		public DataSetTJ_DICNODRUGITEM GetDataSet(SqlClass sC,string sTableName)
		{
			DataSetTJ_DICNODRUGITEM ds = new  DataSetTJ_DICNODRUGITEM();
			db.FillDataSet(sC,ds,sTableName);
			return ds;
		}
		
		#region CheckData		
		/// 
		/// 校验数据输入的有效性。
		/// 
		/// 要检验的实体
		protected void CheckData(DataSetTJ_DICNODRUGITEM entity)
		{
			//在这里可以加入操作之前所需要对实体检验的代码
		}
		#endregion
		
		//wuqb modify 2007-03-27

		
		
		//强名DataSet
		
		#region Data_TJ_DICNODRUGITEM_SelectByIDTJ_TJ_DICNODRUGITEM
		/// 
		/// 对于SelectByIDTJ_TJ_DICNODRUGITEM的类的实现（数据库操作）。
		/// 
		public DataSetTJ_DICNODRUGITEM  Data_TJ_DICNODRUGITEM_SelectByIDTJ_TJ_DICNODRUGITEM (System.String NITEMID)
		{
			DataSetTJ_DICNODRUGITEM ds = new DataSetTJ_DICNODRUGITEM();
			SS_TJ_DICNODRUGITEM_SelectByIDTJ_TJ_DICNODRUGITEM ss = new SS_TJ_DICNODRUGITEM_SelectByIDTJ_TJ_DICNODRUGITEM();
				
			ss.NITEMID = NITEMID;
			
			db.FillDataSet(ss,ds,"TJ_TJ_DICNODRUGITEM");
			return ds;

		} // Data_SelectByIDTJ_TJ_DICNODRUGITEM
		#endregion
		
		#region Data_TJ_DICNODRUGITEM_SelectAll
		/// 
		/// 对于SelectAll的类的实现（数据库操作）。
		/// 
		public DataSetTJ_DICNODRUGITEM  Data_TJ_DICNODRUGITEM_SelectAll ( string sTj )
		{
			DataSetTJ_DICNODRUGITEM ds = new DataSetTJ_DICNODRUGITEM();
			SS_TJ_DICNODRUGITEM_SelectAll ss = new SS_TJ_DICNODRUGITEM_SelectAll();
			
			ss.SqlString = ss.SqlString.Replace("1=1",sTj);
			
			db.FillDataSet(ss,ds,"TJ_TJ_DICNODRUGITEM");
			return ds;

		} // Data_SelectAll
		#endregion
		
				
		//存储过程
		
			
		
		///update更新
		
		#region Data_TJ_DICNODRUGITEM_DeleteTJ_TJ_DICNODRUGITEM
		/// 
		/// 对于DeleteTJ_TJ_DICNODRUGITEM的类的实现（数据库操作）。
		/// 
		public int Data_TJ_DICNODRUGITEM_DeleteTJ_TJ_DICNODRUGITEM ( System.String NITEMID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_TJ_DICNODRUGITEM_DeleteTJ_TJ_DICNODRUGITEM ss = new SS_TJ_DICNODRUGITEM_DeleteTJ_TJ_DICNODRUGITEM();
				
			ss.NITEMID = NITEMID;
			
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
		} // Data_DeleteTJ_TJ_DICNODRUGITEM
		#endregion	
		
		#region Data_TJ_DICNODRUGITEM_UpdateTJ_TJ_DICNODRUGITEM
		/// 
		/// 对于UpdateTJ_TJ_DICNODRUGITEM的类的实现（数据库操作）。
		/// 
		public int Data_TJ_DICNODRUGITEM_UpdateTJ_TJ_DICNODRUGITEM ( System.String EVITEMNAME , System.Decimal HISNITEMTYPE , System.String LISUNIT , System.DateTime CREATE_DATE , System.String CREATE_DEPT , System.String CREATE_DOCT , System.DateTime LAST_DATE , System.String LAST_DOCT , System.String NITEMID , System.Decimal NNODRUGITEMPRICE , System.Decimal NNODRUGITEMUNIT , System.String VDEPARTID , System.Decimal NISSTOP , System.Decimal NISPACK , System.String VITEMDES , System.String PINYINMA , System.String WUBIMA , System.Decimal NCHARGETYPEID , System.String VITEMNAME , System.Decimal DZHEKOU , System.Decimal NPFP , System.Decimal NJGLX , System.Decimal NCKSX , System.Decimal NCKXX , System.String VPDTS , System.String VPGTS , System.String VZCTS , System.String VYCTS , System.String NCKZ , System.String VNEGTS , System.String VPOSTS , System.Decimal NHOSID , System.String HISNITEMID , System.String VITEMADDRESS , System.String OLDNITEMID)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_TJ_DICNODRUGITEM_UpdateTJ_TJ_DICNODRUGITEM ss = new SS_TJ_DICNODRUGITEM_UpdateTJ_TJ_DICNODRUGITEM();
				
			ss.EVITEMNAME = EVITEMNAME;
				
			ss.HISNITEMTYPE = HISNITEMTYPE;
				
			ss.LISUNIT = LISUNIT;
				
			ss.CREATE_DATE = CREATE_DATE;
				
			ss.CREATE_DEPT = CREATE_DEPT;
				
			ss.CREATE_DOCT = CREATE_DOCT;
				
			ss.LAST_DATE = LAST_DATE;
				
			ss.LAST_DOCT = LAST_DOCT;
				
			ss.NITEMID = NITEMID;
				
			ss.NNODRUGITEMPRICE = NNODRUGITEMPRICE;
				
			ss.NNODRUGITEMUNIT = NNODRUGITEMUNIT;
				
			ss.VDEPARTID = VDEPARTID;
				
			ss.NISSTOP = NISSTOP;
				
			ss.NISPACK = NISPACK;
				
			ss.VITEMDES = VITEMDES;
				
			ss.PINYINMA = PINYINMA;
				
			ss.WUBIMA = WUBIMA;
				
			ss.NCHARGETYPEID = NCHARGETYPEID;
				
			ss.VITEMNAME = VITEMNAME;
				
			ss.DZHEKOU = DZHEKOU;
				
			ss.NPFP = NPFP;
				
			ss.NJGLX = NJGLX;
				
			ss.NCKSX = NCKSX;
				
			ss.NCKXX = NCKXX;
				
			ss.VPDTS = VPDTS;
				
			ss.VPGTS = VPGTS;
				
			ss.VZCTS = VZCTS;
				
			ss.VYCTS = VYCTS;
				
			ss.NCKZ = NCKZ;
				
			ss.VNEGTS = VNEGTS;
				
			ss.VPOSTS = VPOSTS;
				
			ss.NHOSID = NHOSID;
				
			ss.HISNITEMID = HISNITEMID;
				
			ss.VITEMADDRESS = VITEMADDRESS;
				
			ss.OLDNITEMID = OLDNITEMID;
			
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
		} // Data_UpdateTJ_TJ_DICNODRUGITEM
		#endregion	
			
				
		//end modify
	}
}
	