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
	/// 对于PAYMENTBaseDAO的类的实现（基础控制部分）。
	/// 对于扩展的DAO的实现可以从这个类继承。
	/// 
	public class PAYMENTBaseDAO : MarshalByRefObject , IDisposable
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
		public PAYMENTBaseDAO()
		{
			//db = DataAccessFactory.Create();
			db = GenerateFactory.GenerateConnect(0);
			//db.Open();
		}
		
		/// 
		/// 结构化一个BaseDAO。
		/// 
		/// 给定的数据库连接。
		
		//public PAYMENTBaseDAO(IDataAccess cdb)
		public PAYMENTBaseDAO(IDataBaseOperate cdb)
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
		/// 插入一个PAYMENT实体到数据库。
		/// 
		/// 将要插入的实体
		public int InsertEntity(DataSetPAYMENT entity)
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
				
				foreach(DataRow row in entity.Tables["PAYMENT"].Rows)
				{	
					int j= db.exeSql(new SS_PAYMENT_InsertPAYMENT(), row);
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
		/// 更新PAYMENT实体到数据库。
		/// 
		/// 将要更新的实体
		public int UpdateEntity(DataSetPAYMENT entity)
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
				
				foreach(DataRow row in entity.Tables["PAYMENT"].Rows)
        {
          int j =	db.exeSql(new SS_PAYMENT_UpdatePAYMENT(), row);
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
		/// 从数据库中删除PAYMENT实体。
		/// 
		/// 将要删除的实体
		public int DeleteEntity(DataSetPAYMENT entity)
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
				
				foreach(DataRow row in entity.Tables["PAYMENT"].Rows)
				{
					int j = db.exeSql(new SS_PAYMENT_DeletePAYMENT(), row);
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
		/// 按照PAYMENT实体的主表的主键查询数据。
		/// 
		/// 主键的值
		public DataSetPAYMENT FindByPrimaryKey(object KeyValue)
		{
			DataSetPAYMENT entity = new DataSetPAYMENT();
			SS_PAYMENT_SelectByIDPAYMENT ss = new SS_PAYMENT_SelectByIDPAYMENT();
			ss.Params[0].Value = KeyValue;
			db.FillDataSet(ss, entity, "PAYMENT");
					
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
		public int CommitChanges(DataSetPAYMENT entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			db.SetUpdateControl(alUpdateControl);
			db.SetUpdateColumn(alUpdateColumn);
		  int iRet =	CommitChanges(entity, drs);
      db.SetUpdateControl(null);
			db.SetUpdateColumn(null);
      return iRet;
		}
		///////////////// 
		
				
		public int CommitChanges(DataSetPAYMENT entity, DataRowState drs)
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



    public int CommitChanges(DataSetPAYMENT entity)
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

		public int CommitChanges(DataSetPAYMENT entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
		{
			this.alUpdateColumn = alUpdateColumn;
			this.alUpdateControl = alUpdateControl;
		  return	CommitChanges(entity);
		}
		/////////////				
		#endregion

		//// 2006-09-11
		public DataSetPAYMENT GetDataSet(SqlClass sC,string sTableName)
		{
			DataSetPAYMENT ds = new  DataSetPAYMENT();
			db.FillDataSet(sC,ds,sTableName);
			return ds;
		}
		
		#region CheckData		
		/// 
		/// 校验数据输入的有效性。
		/// 
		/// 要检验的实体
		protected void CheckData(DataSetPAYMENT entity)
		{
			//在这里可以加入操作之前所需要对实体检验的代码
		}
		#endregion
		
		//wuqb modify 2007-03-27

		
		
		//强名DataSet
		
		#region Data_PAYMENT_SelectByIDPAYMENT
		/// 
		/// 对于SelectByIDPAYMENT的类的实现（数据库操作）。
		/// 
		public DataSetPAYMENT  Data_PAYMENT_SelectByIDPAYMENT (System.String VDDLSH)
		{
			DataSetPAYMENT ds = new DataSetPAYMENT();
			SS_PAYMENT_SelectByIDPAYMENT ss = new SS_PAYMENT_SelectByIDPAYMENT();
				
			ss.VDDLSH = VDDLSH;
			
			db.FillDataSet(ss,ds,"PAYMENT");
			return ds;

		} // Data_SelectByIDPAYMENT
		#endregion
		
		#region Data_PAYMENT_SelectAll
		/// 
		/// 对于SelectAll的类的实现（数据库操作）。
		/// 
		public DataSetPAYMENT  Data_PAYMENT_SelectAll ( string sTj )
		{
			DataSetPAYMENT ds = new DataSetPAYMENT();
			SS_PAYMENT_SelectAll ss = new SS_PAYMENT_SelectAll();
			
			ss.SqlString = ss.SqlString.Replace("1=1",sTj);
			
			db.FillDataSet(ss,ds,"PAYMENT");
			return ds;

		} // Data_SelectAll
		#endregion
		
				
		//存储过程
		
			
		
		///update更新
		
		#region Data_PAYMENT_DeletePAYMENT
		/// 
		/// 对于DeletePAYMENT的类的实现（数据库操作）。
		/// 
		public int Data_PAYMENT_DeletePAYMENT ( System.String VDDLSH)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_PAYMENT_DeletePAYMENT ss = new SS_PAYMENT_DeletePAYMENT();
				
			ss.VDDLSH = VDDLSH;
			
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
		} // Data_DeletePAYMENT
		#endregion	
		
		#region Data_PAYMENT_UpdatePAYMENT
		/// 
		/// 对于UpdatePAYMENT的类的实现（数据库操作）。
		/// 
		public int Data_PAYMENT_UpdatePAYMENT ( System.Decimal NGHF , System.Decimal NZLF , System.String VSPMC , System.String VPHONE , System.DateTime DZFRQ , System.String VHAOBIE , System.String VDDLSH , System.String VNAME , System.String VCLINICNO , System.String VCARD , System.String VSFZH , System.String VDEPT , System.String VDOCTOR , System.DateTime DDDRQ , System.Decimal NCOSTS , System.Decimal NDDLX , System.String VREMARKS , System.Decimal NSTATE , System.DateTime DJZRQ , System.Decimal NDEL , System.String VAPPTIME , System.String VHZID , System.Decimal NPAYTYPE , System.String OLDVDDLSH)
		{
		    int iRtn;
			bool isExistTrans = db.IsInTransaction();
			if(!isExistTrans)
			{
				db.BeginTrans();
			}
			SS_PAYMENT_UpdatePAYMENT ss = new SS_PAYMENT_UpdatePAYMENT();
				
			ss.NGHF = NGHF;
				
			ss.NZLF = NZLF;
				
			ss.VSPMC = VSPMC;
				
			ss.VPHONE = VPHONE;
				
			ss.DZFRQ = DZFRQ;
				
			ss.VHAOBIE = VHAOBIE;
				
			ss.VDDLSH = VDDLSH;
				
			ss.VNAME = VNAME;
				
			ss.VCLINICNO = VCLINICNO;
				
			ss.VCARD = VCARD;
				
			ss.VSFZH = VSFZH;
				
			ss.VDEPT = VDEPT;
				
			ss.VDOCTOR = VDOCTOR;
				
			ss.DDDRQ = DDDRQ;
				
			ss.NCOSTS = NCOSTS;
				
			ss.NDDLX = NDDLX;
				
			ss.VREMARKS = VREMARKS;
				
			ss.NSTATE = NSTATE;
				
			ss.DJZRQ = DJZRQ;
				
			ss.NDEL = NDEL;
				
			ss.VAPPTIME = VAPPTIME;
				
			ss.VHZID = VHZID;
				
			ss.NPAYTYPE = NPAYTYPE;
				
			ss.OLDVDDLSH = OLDVDDLSH;
			
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
		} // Data_UpdatePAYMENT
		#endregion	
			
				
		//end modify
	}
}
	