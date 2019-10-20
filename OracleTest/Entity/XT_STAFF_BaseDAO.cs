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
	/// 对于XT_STAFFBaseDAO的类的实现（基础控制部分）。
	/// 对于扩展的DAO的实现可以从这个类继承。
	/// 
	public class XT_STAFFBaseDAO : MarshalByRefObject , IDisposable
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
		public XT_STAFFBaseDAO()
		{
			//db = DataAccessFactory.Create();
			db = GenerateFactory.GenerateConnect(0);
			//db.Open();
		}
		
		/// 
		/// 结构化一个BaseDAO。
		/// 
		/// 给定的数据库连接。
		
		//public XT_STAFFBaseDAO(IDataAccess cdb)
		public XT_STAFFBaseDAO(IDataBaseOperate cdb)
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
		/// 插入一个XT_STAFF实体到数据库。
		/// 
		/// 将要插入的实体
		public int InsertEntity(DataSetXT_STAFF entity)
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
				
				foreach(DataRow row in entity.Tables["XT_XT_STAFF"].Rows)
				{	
					int j= db.exeSql(new SS_XT_STAFF_InsertXT_XT_STAFF(), row);
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
		/// 更新XT_STAFF实体到数据库。
		/// 
		/// 将要更新的实体
		public int UpdateEntity(DataSetXT_STAFF entity)
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
				
				foreach(DataRow row in entity.Tables["XT_XT_STAFF"].Rows)
        {
          int j =	db.exeSql(new SS_XT_STAFF_UpdateXT_XT_STAFF(), row);
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
		/// 从数据库中删除XT_STAFF实体。
		/// 
		/// 将要删除的实体
		public int DeleteEntity(DataSetXT_STAFF entity)
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
				
				foreach(DataRow row in entity.Tables["XT_XT_STAFF"].Rows)
				{
					int j = db.exeSql(new SS_XT_STAFF_DeleteXT_XT_STAFF(), row);
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
		/// 按照XT_STAFF实体的主表的主键查询数据。
		/// 
		/// 主键的值
		public DataSetXT_STAFF FindByPrimaryKey(object KeyValue)
		{
			DataSetXT_STAFF entity = new DataSetXT_STAFF();
			SS_XT_STAFF_SelectByIDXT_XT_STAFF ss = new SS_XT_STAFF_SelectByIDXT_XT_STAFF();
			ss.Params[0].Value = KeyValue;
			db.FillDataSet(ss, entity, "XT_XT_STAFF");
					
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
		public int CommitChanges(DataSetXT_STAFF entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			db.SetUpdateControl(alUpdateControl);
			db.SetUpdateColumn(alUpdateColumn);
		  int iRet =	CommitChanges(entity, drs);
      db.SetUpdateControl(null);
			db.SetUpdateColumn(null);
      return iRet;
		}
		///////////////// 
		
				
		public int CommitChanges(DataSetXT_STAFF entity, DataRowState drs)
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



    public int CommitChanges(DataSetXT_STAFF entity)
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

		public int CommitChanges(DataSetXT_STAFF entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			this.alUpdateColumn = alUpdateColumn;
			this.alUpdateControl = alUpdateControl;
		  return	CommitChanges(entity);
		}
		/////////////				
		#endregion

		//// 2006-09-11
		public DataSetXT_STAFF GetDataSet(SqlClass sC,string sTableName)
		{
			DataSetXT_STAFF ds = new  DataSetXT_STAFF();
			db.FillDataSet(sC,ds,sTableName);
			return ds;
		}
		
		#region CheckData		
		/// 
		/// 校验数据输入的有效性。
		/// 
		/// 要检验的实体
		protected void CheckData(DataSetXT_STAFF entity)
		{
			//在这里可以加入操作之前所需要对实体检验的代码
		}
		#endregion
		
		//wuqb modify 2007-03-27

		
		
		//强名DataSet
		
		#region Data_XT_STAFF_SelectByIDXT_XT_STAFF
		/// 
		/// 对于SelectByIDXT_XT_STAFF的类的实现（数据库操作）。
		/// 
		public DataSetXT_STAFF  Data_XT_STAFF_SelectByIDXT_XT_STAFF (System.String VSTAFFCODE)
		{
			DataSetXT_STAFF ds = new DataSetXT_STAFF();
			SS_XT_STAFF_SelectByIDXT_XT_STAFF ss = new SS_XT_STAFF_SelectByIDXT_XT_STAFF();
				
			ss.VSTAFFCODE = VSTAFFCODE;
			
			db.FillDataSet(ss,ds,"XT_XT_STAFF");
			return ds;

		} // Data_SelectByIDXT_XT_STAFF
		#endregion
		
		#region Data_XT_STAFF_SelectAll
		/// 
		/// 对于SelectAll的类的实现（数据库操作）。
		/// 
		public DataSetXT_STAFF  Data_XT_STAFF_SelectAll ( string sTj )
		{
			DataSetXT_STAFF ds = new DataSetXT_STAFF();
			SS_XT_STAFF_SelectAll ss = new SS_XT_STAFF_SelectAll();
			
			ss.SqlString = ss.SqlString.Replace("1=1",sTj);
			
			db.FillDataSet(ss,ds,"XT_XT_STAFF");
			return ds;

		} // Data_SelectAll
		#endregion
		
				
		//存储过程
		
			
		
		///update更新
		
		#region Data_XT_STAFF_DeleteXT_XT_STAFF
		/// 
		/// 对于DeleteXT_XT_STAFF的类的实现（数据库操作）。
		/// 
		public int Data_XT_STAFF_DeleteXT_XT_STAFF ( System.String VSTAFFCODE)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_XT_STAFF_DeleteXT_XT_STAFF ss = new SS_XT_STAFF_DeleteXT_XT_STAFF();
				
			ss.VSTAFFCODE = VSTAFFCODE;
			
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
		} // Data_DeleteXT_XT_STAFF
		#endregion	
		
		#region Data_XT_STAFF_UpdateXT_XT_STAFF
		/// 
		/// 对于UpdateXT_XT_STAFF的类的实现（数据库操作）。
		/// 
		public int Data_XT_STAFF_UpdateXT_XT_STAFF ( System.String VSTAFFCODE , System.String VSTAFFNAME , System.String PINYINMA , System.String WUBIMA , System.String VLOGINUSERNAME , System.String VLOGINPASSWORD , System.Decimal NSTAFFSTATUS , System.Decimal NROLEID , System.String VDEPARTCODE , System.Decimal NJOBID , System.Decimal NPROFESSIONID , System.Decimal NOPHZID , System.Decimal NISDUMA , System.DateTime DFHTIME , System.DateTime DTHTIME , System.String VTMETHOD , System.String VSCHOOL , System.Decimal NSEX , System.DateTime NBIRTHDAY , System.String VMINZU , System.String VJIGUAN , System.String VXUELI , System.Decimal NISKSS , System.Decimal NSENDMSG , System.Decimal NHOSID , System.String VYBNO , System.String VSXYS , System.String VSEALCODE , System.String INVOICE_KEY , System.String OLDVSTAFFCODE)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_XT_STAFF_UpdateXT_XT_STAFF ss = new SS_XT_STAFF_UpdateXT_XT_STAFF();
				
			ss.VSTAFFCODE = VSTAFFCODE;
				
			ss.VSTAFFNAME = VSTAFFNAME;
				
			ss.PINYINMA = PINYINMA;
				
			ss.WUBIMA = WUBIMA;
				
			ss.VLOGINUSERNAME = VLOGINUSERNAME;
				
			ss.VLOGINPASSWORD = VLOGINPASSWORD;
				
			ss.NSTAFFSTATUS = NSTAFFSTATUS;
				
			ss.NROLEID = NROLEID;
				
			ss.VDEPARTCODE = VDEPARTCODE;
				
			ss.NJOBID = NJOBID;
				
			ss.NPROFESSIONID = NPROFESSIONID;
				
			ss.NOPHZID = NOPHZID;
				
			ss.NISDUMA = NISDUMA;
				
			ss.DFHTIME = DFHTIME;
				
			ss.DTHTIME = DTHTIME;
				
			ss.VTMETHOD = VTMETHOD;
				
			ss.VSCHOOL = VSCHOOL;
				
			ss.NSEX = NSEX;
				
			ss.NBIRTHDAY = NBIRTHDAY;
				
			ss.VMINZU = VMINZU;
				
			ss.VJIGUAN = VJIGUAN;
				
			ss.VXUELI = VXUELI;
				
			ss.NISKSS = NISKSS;
				
			ss.NSENDMSG = NSENDMSG;
				
			ss.NHOSID = NHOSID;
				
			ss.VYBNO = VYBNO;
				
			ss.VSXYS = VSXYS;
				
			ss.VSEALCODE = VSEALCODE;
				
			ss.INVOICE_KEY = INVOICE_KEY;
				
			ss.OLDVSTAFFCODE = OLDVSTAFFCODE;
			
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
		} // Data_UpdateXT_XT_STAFF
		#endregion	
			
				
		//end modify
	}
}
	