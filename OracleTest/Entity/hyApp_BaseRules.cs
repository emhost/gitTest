
    //------------------------------------------------------------------------------
    //     这部分代码属于业务规则层，是由实体编辑器工具自动产生的。
    //     (Runtime Version: 2.2017.3.2)
    //     对此代码进行的任何修改会导致其它的行为错误，并且重新生成时所有的修改会丢失。
    //
    //		对于业务规则层要实现事务（Transaction）控制，请参考如下说明：
    //		1. 利用MTS（Microsoft Transaction Services）
    //           是利用微软的COM＋服务提供事务处理。要求业务规则类要从System.EnterpriseServices.
    //         ServicedComponent继承，并且要标明TransactionAttribute。在函数（非静态）中可利用
    //         ContextUtil来进行事务控制。详细说明请参考MSDN文档。但注意：如果使用SqlServer 数
    //         据库，Windows已经内置了，MTS服务程序；如果使用Oracle或者其它数据库，需要安装相应
    //         的支持MTS的服务组件。
    //      2. 利用数据库本身的事务控制
    //           如果利用数据本身所支持的事务控制功能，应该保证所有的处理过程被包含在事务之内。
    //         在数据控制层中所有的增、删、改的操作都内建了一个事务，要把这些操作包括在业务规则
    //         层的事务处理中时，在实例化实体控制类时要使用带有IDataAccess参数的构造函数。
    //
    //------------------------------------------------------------------------------

    using System;
    using System.Data;
    //using Gyd.TaskInfo;
    using hyApp.Entity;
    using hyApp.DAO;
    using System.Collections;

    namespace hyApp.Rules
    {
    /// 
      /// 对于hyAppBaseRules 的类的实现（基础业务规则部分）。
      /// 对于扩展部分的Rules的实现可以从这个类继承。
      ///
    
    public class hyAppBaseRules : MarshalByRefObject,IDisposable
    {
    public void Dispose()
    {
    GC.Collect();
    }

    
      #region The base rules of DEPARTINTRODUCTION.
      /*实体DEPARTINTRODUCTION的基本规则*/
      /// 
        /// 插入DEPARTINTRODUCTION实体。
        ///
      
      /// DEPARTINTRODUCTION实体
      
      public void InsertDEPARTINTRODUCTION(DataSetDEPARTINTRODUCTION entity)
      {
      using(DEPARTINTRODUCTIONBaseDAO dao = new DEPARTINTRODUCTIONBaseDAO())
      {
      dao.InsertEntity(entity);
      }
      }

      /// 
        /// 删除DEPARTINTRODUCTION实体。
        ///
      
      /// DEPARTINTRODUCTION实体
      
      public void DeleteDEPARTINTRODUCTION(DataSetDEPARTINTRODUCTION entity)
      {
      using(DEPARTINTRODUCTIONBaseDAO dao = new DEPARTINTRODUCTIONBaseDAO())
      {
      dao.DeleteEntity(entity);
      }
      }

      /// 
        /// 更新DEPARTINTRODUCTION实体。
        ///
      
      /// DEPARTINTRODUCTION实体
      
      public void UpdateDEPARTINTRODUCTION(DataSetDEPARTINTRODUCTION entity)
      {
      using(DEPARTINTRODUCTIONBaseDAO dao = new DEPARTINTRODUCTIONBaseDAO())
      {
      dao.UpdateEntity(entity);
      }
      }

      
      /// 
        /// 通过给定的主键值查询DEPARTINTRODUCTION实体。
        ///
      
      /// 主键id的值
      public DataSetDEPARTINTRODUCTION GetDEPARTINTRODUCTIONByID(System.String id)
      {
      DataSetDEPARTINTRODUCTION entity;
      using(DEPARTINTRODUCTIONBaseDAO dao = new DEPARTINTRODUCTIONBaseDAO())
      {
      entity = dao.FindByPrimaryKey(id);
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public void CommitDEPARTINTRODUCTIONChanges(DataSetDEPARTINTRODUCTION entity, DataRowState drs)
      {
      using(DEPARTINTRODUCTIONBaseDAO dao = new DEPARTINTRODUCTIONBaseDAO())
      {
      dao.CommitChanges(entity, drs);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitDEPARTINTRODUCTIONChanges(DataSetDEPARTINTRODUCTION entity)
      {
      using(DEPARTINTRODUCTIONBaseDAO dao = new DEPARTINTRODUCTIONBaseDAO())
      {
      dao.CommitChanges(entity);
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public void CommitDEPARTINTRODUCTIONChanges(DataSetDEPARTINTRODUCTION entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(DEPARTINTRODUCTIONBaseDAO dao = new DEPARTINTRODUCTIONBaseDAO())
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitDEPARTINTRODUCTIONChanges(DataSetDEPARTINTRODUCTION entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(DEPARTINTRODUCTIONBaseDAO dao = new DEPARTINTRODUCTIONBaseDAO())
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }

      ///生成查询静态函数
      ///
      
        public DataSetDEPARTINTRODUCTION GetDEPARTINTRODUCTION_SelectByIDYWAPP_DEPART_INTRODUCTION(System.String ID)
        {
        using(DEPARTINTRODUCTIONBaseDAO dao = new DEPARTINTRODUCTIONBaseDAO())
        {
        return dao.Data_DEPARTINTRODUCTION_SelectByIDYWAPP_DEPART_INTRODUCTION(ID );
        }
        }
      
        public DataSetDEPARTINTRODUCTION GetDEPARTINTRODUCTION_SelectAll(
          string sTj )
        {
        using(DEPARTINTRODUCTIONBaseDAO dao = new DEPARTINTRODUCTIONBaseDAO())
        {
        return dao.Data_DEPARTINTRODUCTION_SelectAll(
          sTj  );
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public int UpdateDEPARTINTRODUCTION_DeleteYWAPP_DEPART_INTRODUCTION(System.String ID)
        {
        using(DEPARTINTRODUCTIONBaseDAO dao = new DEPARTINTRODUCTIONBaseDAO())
        {
        return dao.Data_DEPARTINTRODUCTION_DeleteYWAPP_DEPART_INTRODUCTION(ID);
        }
        }
      
        public int UpdateDEPARTINTRODUCTION_UpdateYWAPP_DEPART_INTRODUCTION(System.String ID , System.String VDEPARTMENTCODE , System.String INTRODUCTION , System.String REMARKS , System.Decimal ISENABLE , System.Byte[] PHOTO , System.String OLDID)
        {
        using(DEPARTINTRODUCTIONBaseDAO dao = new DEPARTINTRODUCTIONBaseDAO())
        {
        return dao.Data_DEPARTINTRODUCTION_UpdateYWAPP_DEPART_INTRODUCTION(ID , VDEPARTMENTCODE , INTRODUCTION , REMARKS , ISENABLE , PHOTO , OLDID);
        }
        }
      
      #endregion
    
      #region The base rules of DOCTORINTRODUCTION.
      /*实体DOCTORINTRODUCTION的基本规则*/
      /// 
        /// 插入DOCTORINTRODUCTION实体。
        ///
      
      /// DOCTORINTRODUCTION实体
      
      public void InsertDOCTORINTRODUCTION(DataSetDOCTORINTRODUCTION entity)
      {
      using(DOCTORINTRODUCTIONBaseDAO dao = new DOCTORINTRODUCTIONBaseDAO())
      {
      dao.InsertEntity(entity);
      }
      }

      /// 
        /// 删除DOCTORINTRODUCTION实体。
        ///
      
      /// DOCTORINTRODUCTION实体
      
      public void DeleteDOCTORINTRODUCTION(DataSetDOCTORINTRODUCTION entity)
      {
      using(DOCTORINTRODUCTIONBaseDAO dao = new DOCTORINTRODUCTIONBaseDAO())
      {
      dao.DeleteEntity(entity);
      }
      }

      /// 
        /// 更新DOCTORINTRODUCTION实体。
        ///
      
      /// DOCTORINTRODUCTION实体
      
      public void UpdateDOCTORINTRODUCTION(DataSetDOCTORINTRODUCTION entity)
      {
      using(DOCTORINTRODUCTIONBaseDAO dao = new DOCTORINTRODUCTIONBaseDAO())
      {
      dao.UpdateEntity(entity);
      }
      }

      
      /// 
        /// 通过给定的主键值查询DOCTORINTRODUCTION实体。
        ///
      
      /// 主键id的值
      public DataSetDOCTORINTRODUCTION GetDOCTORINTRODUCTIONByID(System.String id)
      {
      DataSetDOCTORINTRODUCTION entity;
      using(DOCTORINTRODUCTIONBaseDAO dao = new DOCTORINTRODUCTIONBaseDAO())
      {
      entity = dao.FindByPrimaryKey(id);
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public void CommitDOCTORINTRODUCTIONChanges(DataSetDOCTORINTRODUCTION entity, DataRowState drs)
      {
      using(DOCTORINTRODUCTIONBaseDAO dao = new DOCTORINTRODUCTIONBaseDAO())
      {
      dao.CommitChanges(entity, drs);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitDOCTORINTRODUCTIONChanges(DataSetDOCTORINTRODUCTION entity)
      {
      using(DOCTORINTRODUCTIONBaseDAO dao = new DOCTORINTRODUCTIONBaseDAO())
      {
      dao.CommitChanges(entity);
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public void CommitDOCTORINTRODUCTIONChanges(DataSetDOCTORINTRODUCTION entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(DOCTORINTRODUCTIONBaseDAO dao = new DOCTORINTRODUCTIONBaseDAO())
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitDOCTORINTRODUCTIONChanges(DataSetDOCTORINTRODUCTION entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(DOCTORINTRODUCTIONBaseDAO dao = new DOCTORINTRODUCTIONBaseDAO())
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }

      ///生成查询静态函数
      ///
      
        public DataSetDOCTORINTRODUCTION GetDOCTORINTRODUCTION_SelectByIDYWAPP_DOCTOR_INTRODUCTION(System.String ID)
        {
        using(DOCTORINTRODUCTIONBaseDAO dao = new DOCTORINTRODUCTIONBaseDAO())
        {
        return dao.Data_DOCTORINTRODUCTION_SelectByIDYWAPP_DOCTOR_INTRODUCTION(ID );
        }
        }
      
        public DataSetDOCTORINTRODUCTION GetDOCTORINTRODUCTION_SelectALl(
          string sTj )
        {
        using(DOCTORINTRODUCTIONBaseDAO dao = new DOCTORINTRODUCTIONBaseDAO())
        {
        return dao.Data_DOCTORINTRODUCTION_SelectALl(
          sTj  );
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public int UpdateDOCTORINTRODUCTION_DeleteYWAPP_DOCTOR_INTRODUCTION(System.String ID)
        {
        using(DOCTORINTRODUCTIONBaseDAO dao = new DOCTORINTRODUCTIONBaseDAO())
        {
        return dao.Data_DOCTORINTRODUCTION_DeleteYWAPP_DOCTOR_INTRODUCTION(ID);
        }
        }
      
        public int UpdateDOCTORINTRODUCTION_UpdateYWAPP_DOCTOR_INTRODUCTION(System.String VGOODAT , System.String ID , System.String VSTAFFCODE , System.String DOCTORINTRODUCTION , System.String REMARKS , System.Decimal ISENABLE , System.String SPECIALTY , System.String POSITION , System.Byte[] PHOTO , System.String VDEPARTCODE , System.String OLDID)
        {
        using(DOCTORINTRODUCTIONBaseDAO dao = new DOCTORINTRODUCTIONBaseDAO())
        {
        return dao.Data_DOCTORINTRODUCTION_UpdateYWAPP_DOCTOR_INTRODUCTION(VGOODAT , ID , VSTAFFCODE , DOCTORINTRODUCTION , REMARKS , ISENABLE , SPECIALTY , POSITION , PHOTO , VDEPARTCODE , OLDID);
        }
        }
      
      #endregion
    
      #region The base rules of HOSPITALINTRODUCTION.
      /*实体HOSPITALINTRODUCTION的基本规则*/
      /// 
        /// 插入HOSPITALINTRODUCTION实体。
        ///
      
      /// HOSPITALINTRODUCTION实体
      
      public void InsertHOSPITALINTRODUCTION(DataSetHOSPITALINTRODUCTION entity)
      {
      using(HOSPITALINTRODUCTIONBaseDAO dao = new HOSPITALINTRODUCTIONBaseDAO())
      {
      dao.InsertEntity(entity);
      }
      }

      /// 
        /// 删除HOSPITALINTRODUCTION实体。
        ///
      
      /// HOSPITALINTRODUCTION实体
      
      public void DeleteHOSPITALINTRODUCTION(DataSetHOSPITALINTRODUCTION entity)
      {
      using(HOSPITALINTRODUCTIONBaseDAO dao = new HOSPITALINTRODUCTIONBaseDAO())
      {
      dao.DeleteEntity(entity);
      }
      }

      /// 
        /// 更新HOSPITALINTRODUCTION实体。
        ///
      
      /// HOSPITALINTRODUCTION实体
      
      public void UpdateHOSPITALINTRODUCTION(DataSetHOSPITALINTRODUCTION entity)
      {
      using(HOSPITALINTRODUCTIONBaseDAO dao = new HOSPITALINTRODUCTIONBaseDAO())
      {
      dao.UpdateEntity(entity);
      }
      }

      
      /// 
        /// 通过给定的主键值查询HOSPITALINTRODUCTION实体。
        ///
      
      /// 主键id的值
      public DataSetHOSPITALINTRODUCTION GetHOSPITALINTRODUCTIONByID(System.String id)
      {
      DataSetHOSPITALINTRODUCTION entity;
      using(HOSPITALINTRODUCTIONBaseDAO dao = new HOSPITALINTRODUCTIONBaseDAO())
      {
      entity = dao.FindByPrimaryKey(id);
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public void CommitHOSPITALINTRODUCTIONChanges(DataSetHOSPITALINTRODUCTION entity, DataRowState drs)
      {
      using(HOSPITALINTRODUCTIONBaseDAO dao = new HOSPITALINTRODUCTIONBaseDAO())
      {
      dao.CommitChanges(entity, drs);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitHOSPITALINTRODUCTIONChanges(DataSetHOSPITALINTRODUCTION entity)
      {
      using(HOSPITALINTRODUCTIONBaseDAO dao = new HOSPITALINTRODUCTIONBaseDAO())
      {
      dao.CommitChanges(entity);
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public void CommitHOSPITALINTRODUCTIONChanges(DataSetHOSPITALINTRODUCTION entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(HOSPITALINTRODUCTIONBaseDAO dao = new HOSPITALINTRODUCTIONBaseDAO())
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitHOSPITALINTRODUCTIONChanges(DataSetHOSPITALINTRODUCTION entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(HOSPITALINTRODUCTIONBaseDAO dao = new HOSPITALINTRODUCTIONBaseDAO())
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }

      ///生成查询静态函数
      ///
      
        public DataSetHOSPITALINTRODUCTION GetHOSPITALINTRODUCTION_SelectByIDYWAPP_HOSPITAL_INTRODUCTION(System.String ID)
        {
        using(HOSPITALINTRODUCTIONBaseDAO dao = new HOSPITALINTRODUCTIONBaseDAO())
        {
        return dao.Data_HOSPITALINTRODUCTION_SelectByIDYWAPP_HOSPITAL_INTRODUCTION(ID );
        }
        }
      
        public DataSetHOSPITALINTRODUCTION GetHOSPITALINTRODUCTION_SelectAll(
          string sTj )
        {
        using(HOSPITALINTRODUCTIONBaseDAO dao = new HOSPITALINTRODUCTIONBaseDAO())
        {
        return dao.Data_HOSPITALINTRODUCTION_SelectAll(
          sTj  );
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public int UpdateHOSPITALINTRODUCTION_DeleteYWAPP_HOSPITAL_INTRODUCTION(System.String ID)
        {
        using(HOSPITALINTRODUCTIONBaseDAO dao = new HOSPITALINTRODUCTIONBaseDAO())
        {
        return dao.Data_HOSPITALINTRODUCTION_DeleteYWAPP_HOSPITAL_INTRODUCTION(ID);
        }
        }
      
        public int UpdateHOSPITALINTRODUCTION_UpdateYWAPP_HOSPITAL_INTRODUCTION(System.String ID , System.String HOSPITALNAME , System.String HOSPITALADDRESS , System.String HOSPITALTEL , System.String HOSPITALINTRODUCTION , System.String REMARKS , System.Decimal ISENABLE , System.Byte[] PHOTO , System.Byte[] PHOTO1 , System.Byte[] PHOTO2 , System.String HOSPITALID , System.String OLDID)
        {
        using(HOSPITALINTRODUCTIONBaseDAO dao = new HOSPITALINTRODUCTIONBaseDAO())
        {
        return dao.Data_HOSPITALINTRODUCTION_UpdateYWAPP_HOSPITAL_INTRODUCTION(ID , HOSPITALNAME , HOSPITALADDRESS , HOSPITALTEL , HOSPITALINTRODUCTION , REMARKS , ISENABLE , PHOTO , PHOTO1 , PHOTO2 , HOSPITALID , OLDID);
        }
        }
      
      #endregion
    
      #region The base rules of IN_NAVIGATION.
      /*实体IN_NAVIGATION的基本规则*/
      /// 
        /// 插入IN_NAVIGATION实体。
        ///
      
      /// IN_NAVIGATION实体
      
      public void InsertIN_NAVIGATION(DataSetIN_NAVIGATION entity)
      {
      using(IN_NAVIGATIONBaseDAO dao = new IN_NAVIGATIONBaseDAO())
      {
      dao.InsertEntity(entity);
      }
      }

      /// 
        /// 删除IN_NAVIGATION实体。
        ///
      
      /// IN_NAVIGATION实体
      
      public void DeleteIN_NAVIGATION(DataSetIN_NAVIGATION entity)
      {
      using(IN_NAVIGATIONBaseDAO dao = new IN_NAVIGATIONBaseDAO())
      {
      dao.DeleteEntity(entity);
      }
      }

      /// 
        /// 更新IN_NAVIGATION实体。
        ///
      
      /// IN_NAVIGATION实体
      
      public void UpdateIN_NAVIGATION(DataSetIN_NAVIGATION entity)
      {
      using(IN_NAVIGATIONBaseDAO dao = new IN_NAVIGATIONBaseDAO())
      {
      dao.UpdateEntity(entity);
      }
      }

      
      /// 
        /// 通过给定的主键值查询IN_NAVIGATION实体。
        ///
      
      /// 主键id的值
      public DataSetIN_NAVIGATION GetIN_NAVIGATIONByID(System.String id)
      {
      DataSetIN_NAVIGATION entity;
      using(IN_NAVIGATIONBaseDAO dao = new IN_NAVIGATIONBaseDAO())
      {
      entity = dao.FindByPrimaryKey(id);
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public void CommitIN_NAVIGATIONChanges(DataSetIN_NAVIGATION entity, DataRowState drs)
      {
      using(IN_NAVIGATIONBaseDAO dao = new IN_NAVIGATIONBaseDAO())
      {
      dao.CommitChanges(entity, drs);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitIN_NAVIGATIONChanges(DataSetIN_NAVIGATION entity)
      {
      using(IN_NAVIGATIONBaseDAO dao = new IN_NAVIGATIONBaseDAO())
      {
      dao.CommitChanges(entity);
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public void CommitIN_NAVIGATIONChanges(DataSetIN_NAVIGATION entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(IN_NAVIGATIONBaseDAO dao = new IN_NAVIGATIONBaseDAO())
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitIN_NAVIGATIONChanges(DataSetIN_NAVIGATION entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(IN_NAVIGATIONBaseDAO dao = new IN_NAVIGATIONBaseDAO())
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }

      ///生成查询静态函数
      ///
      
        public DataSetIN_NAVIGATION GetIN_NAVIGATION_SelectByIDYWAPP_INHOSPITAL_NAVIGATION(System.String ID)
        {
        using(IN_NAVIGATIONBaseDAO dao = new IN_NAVIGATIONBaseDAO())
        {
        return dao.Data_IN_NAVIGATION_SelectByIDYWAPP_INHOSPITAL_NAVIGATION(ID );
        }
        }
      
        public DataSetIN_NAVIGATION GetIN_NAVIGATION_SelectAll(
          string sTj )
        {
        using(IN_NAVIGATIONBaseDAO dao = new IN_NAVIGATIONBaseDAO())
        {
        return dao.Data_IN_NAVIGATION_SelectAll(
          sTj  );
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public int UpdateIN_NAVIGATION_DeleteYWAPP_INHOSPITAL_NAVIGATION(System.String ID)
        {
        using(IN_NAVIGATIONBaseDAO dao = new IN_NAVIGATIONBaseDAO())
        {
        return dao.Data_IN_NAVIGATION_DeleteYWAPP_INHOSPITAL_NAVIGATION(ID);
        }
        }
      
        public int UpdateIN_NAVIGATION_UpdateYWAPP_INHOSPITAL_NAVIGATION(System.String HOSPITALID , System.String ID , System.String FLOORNAME , System.Byte[] FLOORMAP , System.String OLDID)
        {
        using(IN_NAVIGATIONBaseDAO dao = new IN_NAVIGATIONBaseDAO())
        {
        return dao.Data_IN_NAVIGATION_UpdateYWAPP_INHOSPITAL_NAVIGATION(HOSPITALID , ID , FLOORNAME , FLOORMAP , OLDID);
        }
        }
      
      #endregion
    
      #region The base rules of IN_NAVIGATION_DETAILS.
      /*实体IN_NAVIGATION_DETAILS的基本规则*/
      /// 
        /// 插入IN_NAVIGATION_DETAILS实体。
        ///
      
      /// IN_NAVIGATION_DETAILS实体
      
      public void InsertIN_NAVIGATION_DETAILS(DataSetIN_NAVIGATION_DETAILS entity)
      {
      using(IN_NAVIGATION_DETAILSBaseDAO dao = new IN_NAVIGATION_DETAILSBaseDAO())
      {
      dao.InsertEntity(entity);
      }
      }

      /// 
        /// 删除IN_NAVIGATION_DETAILS实体。
        ///
      
      /// IN_NAVIGATION_DETAILS实体
      
      public void DeleteIN_NAVIGATION_DETAILS(DataSetIN_NAVIGATION_DETAILS entity)
      {
      using(IN_NAVIGATION_DETAILSBaseDAO dao = new IN_NAVIGATION_DETAILSBaseDAO())
      {
      dao.DeleteEntity(entity);
      }
      }

      /// 
        /// 更新IN_NAVIGATION_DETAILS实体。
        ///
      
      /// IN_NAVIGATION_DETAILS实体
      
      public void UpdateIN_NAVIGATION_DETAILS(DataSetIN_NAVIGATION_DETAILS entity)
      {
      using(IN_NAVIGATION_DETAILSBaseDAO dao = new IN_NAVIGATION_DETAILSBaseDAO())
      {
      dao.UpdateEntity(entity);
      }
      }

      
      /// 
        /// 通过给定的主键值查询IN_NAVIGATION_DETAILS实体。
        ///
      
      /// 主键id的值
      public DataSetIN_NAVIGATION_DETAILS GetIN_NAVIGATION_DETAILSByID(System.String id)
      {
      DataSetIN_NAVIGATION_DETAILS entity;
      using(IN_NAVIGATION_DETAILSBaseDAO dao = new IN_NAVIGATION_DETAILSBaseDAO())
      {
      entity = dao.FindByPrimaryKey(id);
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public void CommitIN_NAVIGATION_DETAILSChanges(DataSetIN_NAVIGATION_DETAILS entity, DataRowState drs)
      {
      using(IN_NAVIGATION_DETAILSBaseDAO dao = new IN_NAVIGATION_DETAILSBaseDAO())
      {
      dao.CommitChanges(entity, drs);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitIN_NAVIGATION_DETAILSChanges(DataSetIN_NAVIGATION_DETAILS entity)
      {
      using(IN_NAVIGATION_DETAILSBaseDAO dao = new IN_NAVIGATION_DETAILSBaseDAO())
      {
      dao.CommitChanges(entity);
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public void CommitIN_NAVIGATION_DETAILSChanges(DataSetIN_NAVIGATION_DETAILS entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(IN_NAVIGATION_DETAILSBaseDAO dao = new IN_NAVIGATION_DETAILSBaseDAO())
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitIN_NAVIGATION_DETAILSChanges(DataSetIN_NAVIGATION_DETAILS entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(IN_NAVIGATION_DETAILSBaseDAO dao = new IN_NAVIGATION_DETAILSBaseDAO())
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }

      ///生成查询静态函数
      ///
      
        public DataSetIN_NAVIGATION_DETAILS GetIN_NAVIGATION_DETAILS_SelectByIDYWAPP_INHOSPITAL_NAVIGATION_DETAIL(System.String ID)
        {
        using(IN_NAVIGATION_DETAILSBaseDAO dao = new IN_NAVIGATION_DETAILSBaseDAO())
        {
        return dao.Data_IN_NAVIGATION_DETAILS_SelectByIDYWAPP_INHOSPITAL_NAVIGATION_DETAIL(ID );
        }
        }
      
        public DataSetIN_NAVIGATION_DETAILS GetIN_NAVIGATION_DETAILS_SelectAll(
          string sTj )
        {
        using(IN_NAVIGATION_DETAILSBaseDAO dao = new IN_NAVIGATION_DETAILSBaseDAO())
        {
        return dao.Data_IN_NAVIGATION_DETAILS_SelectAll(
          sTj  );
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public int UpdateIN_NAVIGATION_DETAILS_DeleteYWAPP_INHOSPITAL_NAVIGATION_DETAIL(System.String ID)
        {
        using(IN_NAVIGATION_DETAILSBaseDAO dao = new IN_NAVIGATION_DETAILSBaseDAO())
        {
        return dao.Data_IN_NAVIGATION_DETAILS_DeleteYWAPP_INHOSPITAL_NAVIGATION_DETAIL(ID);
        }
        }
      
        public int UpdateIN_NAVIGATION_DETAILS_UpdateYWAPP_INHOSPITAL_NAVIGATION_DETAIL(System.String INID , System.String ID , System.String FLOORNUM , System.String DEPARTCODE , System.String DEPARTNAME , System.Byte[] FLOORNUMMAP , System.String OLDID)
        {
        using(IN_NAVIGATION_DETAILSBaseDAO dao = new IN_NAVIGATION_DETAILSBaseDAO())
        {
        return dao.Data_IN_NAVIGATION_DETAILS_UpdateYWAPP_INHOSPITAL_NAVIGATION_DETAIL(INID , ID , FLOORNUM , DEPARTCODE , DEPARTNAME , FLOORNUMMAP , OLDID);
        }
        }
      
      #endregion
    
    }
    }
  