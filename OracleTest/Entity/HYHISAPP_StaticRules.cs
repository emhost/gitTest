
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
    using HYHISAPP.Entity;
    using HYHISAPP.DAO;
    using System.Collections;
    using PhoenixDataBaseOperate;
    using PhoenixDataBaseConnect;
    namespace HYHISAPP.Rules
    {
    /// 
      /// 对于HYHISAPPBaseRules 的类的实现（基础业务规则部分）。
      /// 对于扩展部分的Rules的实现可以从这个类继承。
      ///
    
    public class HYHISAPPStaticRules 
    {
  
    
      #region The base rules of JZHZ.
      /*实体JZHZ的基本规则*/
      /// 
        /// 插入JZHZ实体。
        ///
      
      /// JZHZ实体
      
      public static void InsertJZHZ(DataSetJZHZ entity,IDataBaseOperate cdb =null)
      {
          if(cdb==null)
          { 
            using( var cbd = GenerateFactory.GenerateConnect())
            {
              using(JZHZBaseDAO dao = new JZHZBaseDAO(cbd))
      {
      dao.InsertEntity(entity);
      }
      }
      }
      else
      {
      using(JZHZBaseDAO dao = new JZHZBaseDAO(cdb))
            {
            dao.InsertEntity(entity);
            }
        }
      }

      /// 
        /// 删除JZHZ实体。
        ///
      
      /// JZHZ实体
      
      public static void DeleteJZHZ(DataSetJZHZ entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(JZHZBaseDAO dao = new JZHZBaseDAO(cbd))
      {
      dao.DeleteEntity(entity);
      }
      }
      }
      else
      {
      using(JZHZBaseDAO dao = new JZHZBaseDAO(cdb))
      {
      dao.DeleteEntity(entity);
      }
      }
      }

      /// 
        /// 更新JZHZ实体。
        ///
      
      /// JZHZ实体
      
      public static void UpdateJZHZ(DataSetJZHZ entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(JZHZBaseDAO dao = new JZHZBaseDAO(cbd))
      {
      dao.UpdateEntity(entity);
      }
      }
      }
      else
      {
      using(JZHZBaseDAO dao = new JZHZBaseDAO(cdb))
      {
      dao.UpdateEntity(entity);
      }
      }
      }

      
      /// 
        /// 通过给定的主键值查询JZHZ实体。
        ///
      
      /// 主键id的值
      public static DataSetJZHZ GetJZHZByID(System.String id,IDataBaseOperate cdb =null)
      {
      DataSetJZHZ entity;
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(JZHZBaseDAO dao = new JZHZBaseDAO(cbd))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      }
      else
      {
      using(JZHZBaseDAO dao = new JZHZBaseDAO(cdb))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitJZHZChanges(DataSetJZHZ entity, DataRowState drs,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(JZHZBaseDAO dao = new JZHZBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }
      else
      {
      using(JZHZBaseDAO dao = new JZHZBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitJZHZChanges(DataSetJZHZ entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(JZHZBaseDAO dao = new JZHZBaseDAO(cbd))
      {
      dao.CommitChanges(entity);
      }
      }
      }
      else
      {
      using(JZHZBaseDAO dao = new JZHZBaseDAO(cdb))
      {
      dao.CommitChanges(entity);
      }
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitJZHZChanges(DataSetJZHZ entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(JZHZBaseDAO dao = new JZHZBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(JZHZBaseDAO dao = new JZHZBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitJZHZChanges(DataSetJZHZ entity,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(JZHZBaseDAO dao = new JZHZBaseDAO(cbd))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(JZHZBaseDAO dao = new JZHZBaseDAO(cdb))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }

      ///生成查询静态函数
      ///
      
        public static DataSetJZHZ GetJZHZ_SelectByIDJZHZ(System.String ID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(JZHZBaseDAO dao = new JZHZBaseDAO(cbd))
        {
        return dao.Data_JZHZ_SelectByIDJZHZ(ID );
        }
        }
        }
        else
        {
        using(JZHZBaseDAO dao = new JZHZBaseDAO(cdb))
        {
        return dao.Data_JZHZ_SelectByIDJZHZ(ID );
        }
        }
        }
      
        public static DataSetJZHZ GetJZHZ_SelectAll(
          string sTj ,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(JZHZBaseDAO dao = new JZHZBaseDAO(cbd))
        {
        return dao.Data_JZHZ_SelectAll(
          sTj  );
        }
        }
        }
        else
        {
        using(JZHZBaseDAO dao = new JZHZBaseDAO(cdb))
        {
        return dao.Data_JZHZ_SelectAll(
          sTj  );
        }
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public static int UpdateJZHZ_DeleteJZHZ(System.String ID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(JZHZBaseDAO dao = new JZHZBaseDAO(cbd))
        {
        return dao.Data_JZHZ_DeleteJZHZ(ID);
        }
        }
        }
        else
        {
        using(JZHZBaseDAO dao = new JZHZBaseDAO(cdb))
        {
        return dao.Data_JZHZ_DeleteJZHZ(ID);
        }
        }
        }
      
        public static int UpdateJZHZ_UpdateJZHZ(System.String ID , System.Decimal NPHONE , System.String VNAME , System.String NSEX , System.String VSFZH , System.String VCARD , System.String VPWD , System.String VPYM , System.DateTime DBIRTHDAY , System.Decimal NSTOP , System.String VPATIENTID , System.DateTime DCREATE , System.String OLDID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(JZHZBaseDAO dao = new JZHZBaseDAO(cbd))
        {
        return dao.Data_JZHZ_UpdateJZHZ(ID , NPHONE , VNAME , NSEX , VSFZH , VCARD , VPWD , VPYM , DBIRTHDAY , NSTOP , VPATIENTID , DCREATE , OLDID);
        }
        }
        }
        else
        {
        using(JZHZBaseDAO dao = new JZHZBaseDAO(cdb))
        {
        return dao.Data_JZHZ_UpdateJZHZ(ID , NPHONE , VNAME , NSEX , VSFZH , VCARD , VPWD , VPYM , DBIRTHDAY , NSTOP , VPATIENTID , DCREATE , OLDID);
        }
        }
        }
      
      #endregion
    
      #region The base rules of JZHZ_RELATION.
      /*实体JZHZ_RELATION的基本规则*/
      /// 
        /// 插入JZHZ_RELATION实体。
        ///
      
      /// JZHZ_RELATION实体
      
      public static void InsertJZHZ_RELATION(DataSetJZHZ_RELATION entity,IDataBaseOperate cdb =null)
      {
          if(cdb==null)
          { 
            using( var cbd = GenerateFactory.GenerateConnect())
            {
              using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cbd))
      {
      dao.InsertEntity(entity);
      }
      }
      }
      else
      {
      using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cdb))
            {
            dao.InsertEntity(entity);
            }
        }
      }

      /// 
        /// 删除JZHZ_RELATION实体。
        ///
      
      /// JZHZ_RELATION实体
      
      public static void DeleteJZHZ_RELATION(DataSetJZHZ_RELATION entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cbd))
      {
      dao.DeleteEntity(entity);
      }
      }
      }
      else
      {
      using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cdb))
      {
      dao.DeleteEntity(entity);
      }
      }
      }

      /// 
        /// 更新JZHZ_RELATION实体。
        ///
      
      /// JZHZ_RELATION实体
      
      public static void UpdateJZHZ_RELATION(DataSetJZHZ_RELATION entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cbd))
      {
      dao.UpdateEntity(entity);
      }
      }
      }
      else
      {
      using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cdb))
      {
      dao.UpdateEntity(entity);
      }
      }
      }

      
      /// 
        /// 通过给定的主键值查询JZHZ_RELATION实体。
        ///
      
      /// 主键id的值
      public static DataSetJZHZ_RELATION GetJZHZ_RELATIONByID(System.String id,IDataBaseOperate cdb =null)
      {
      DataSetJZHZ_RELATION entity;
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cbd))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      }
      else
      {
      using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cdb))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitJZHZ_RELATIONChanges(DataSetJZHZ_RELATION entity, DataRowState drs,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }
      else
      {
      using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitJZHZ_RELATIONChanges(DataSetJZHZ_RELATION entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cbd))
      {
      dao.CommitChanges(entity);
      }
      }
      }
      else
      {
      using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cdb))
      {
      dao.CommitChanges(entity);
      }
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitJZHZ_RELATIONChanges(DataSetJZHZ_RELATION entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitJZHZ_RELATIONChanges(DataSetJZHZ_RELATION entity,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cbd))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cdb))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }

      ///生成查询静态函数
      ///
      
        public static DataSetJZHZ_RELATION GetJZHZ_RELATION_SelectByIDJZHZ_RELATION(System.String ID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cbd))
        {
        return dao.Data_JZHZ_RELATION_SelectByIDJZHZ_RELATION(ID );
        }
        }
        }
        else
        {
        using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cdb))
        {
        return dao.Data_JZHZ_RELATION_SelectByIDJZHZ_RELATION(ID );
        }
        }
        }
      
        public static DataSetJZHZ_RELATION GetJZHZ_RELATION_SelectAll(
          string sTj ,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cbd))
        {
        return dao.Data_JZHZ_RELATION_SelectAll(
          sTj  );
        }
        }
        }
        else
        {
        using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cdb))
        {
        return dao.Data_JZHZ_RELATION_SelectAll(
          sTj  );
        }
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public static int UpdateJZHZ_RELATION_DeleteJZHZ_RELATION(System.String ID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cbd))
        {
        return dao.Data_JZHZ_RELATION_DeleteJZHZ_RELATION(ID);
        }
        }
        }
        else
        {
        using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cdb))
        {
        return dao.Data_JZHZ_RELATION_DeleteJZHZ_RELATION(ID);
        }
        }
        }
      
        public static int UpdateJZHZ_RELATION_UpdateJZHZ_RELATION(System.Decimal NISDEF , System.String ID , System.Decimal NPHONE , System.String VNAME , System.String VSFZH , System.String VCARD , System.String VGX , System.String VGLID , System.String VPYM , System.String NSEX , System.DateTime DBIRTHDAY , System.String VPATIENTID , System.DateTime DCREATE , System.String OLDID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cbd))
        {
        return dao.Data_JZHZ_RELATION_UpdateJZHZ_RELATION(NISDEF , ID , NPHONE , VNAME , VSFZH , VCARD , VGX , VGLID , VPYM , NSEX , DBIRTHDAY , VPATIENTID , DCREATE , OLDID);
        }
        }
        }
        else
        {
        using(JZHZ_RELATIONBaseDAO dao = new JZHZ_RELATIONBaseDAO(cdb))
        {
        return dao.Data_JZHZ_RELATION_UpdateJZHZ_RELATION(NISDEF , ID , NPHONE , VNAME , VSFZH , VCARD , VGX , VGLID , VPYM , NSEX , DBIRTHDAY , VPATIENTID , DCREATE , OLDID);
        }
        }
        }
      
      #endregion
    
      #region The base rules of PAYMENT.
      /*实体PAYMENT的基本规则*/
      /// 
        /// 插入PAYMENT实体。
        ///
      
      /// PAYMENT实体
      
      public static void InsertPAYMENT(DataSetPAYMENT entity,IDataBaseOperate cdb =null)
      {
          if(cdb==null)
          { 
            using( var cbd = GenerateFactory.GenerateConnect())
            {
              using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cbd))
      {
      dao.InsertEntity(entity);
      }
      }
      }
      else
      {
      using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cdb))
            {
            dao.InsertEntity(entity);
            }
        }
      }

      /// 
        /// 删除PAYMENT实体。
        ///
      
      /// PAYMENT实体
      
      public static void DeletePAYMENT(DataSetPAYMENT entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cbd))
      {
      dao.DeleteEntity(entity);
      }
      }
      }
      else
      {
      using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cdb))
      {
      dao.DeleteEntity(entity);
      }
      }
      }

      /// 
        /// 更新PAYMENT实体。
        ///
      
      /// PAYMENT实体
      
      public static void UpdatePAYMENT(DataSetPAYMENT entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cbd))
      {
      dao.UpdateEntity(entity);
      }
      }
      }
      else
      {
      using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cdb))
      {
      dao.UpdateEntity(entity);
      }
      }
      }

      
      /// 
        /// 通过给定的主键值查询PAYMENT实体。
        ///
      
      /// 主键id的值
      public static DataSetPAYMENT GetPAYMENTByID(System.String id,IDataBaseOperate cdb =null)
      {
      DataSetPAYMENT entity;
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cbd))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      }
      else
      {
      using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cdb))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitPAYMENTChanges(DataSetPAYMENT entity, DataRowState drs,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }
      else
      {
      using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitPAYMENTChanges(DataSetPAYMENT entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cbd))
      {
      dao.CommitChanges(entity);
      }
      }
      }
      else
      {
      using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cdb))
      {
      dao.CommitChanges(entity);
      }
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitPAYMENTChanges(DataSetPAYMENT entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitPAYMENTChanges(DataSetPAYMENT entity,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cbd))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cdb))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }

      ///生成查询静态函数
      ///
      
        public static DataSetPAYMENT GetPAYMENT_SelectByIDPAYMENT(System.String VDDLSH,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cbd))
        {
        return dao.Data_PAYMENT_SelectByIDPAYMENT(VDDLSH );
        }
        }
        }
        else
        {
        using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cdb))
        {
        return dao.Data_PAYMENT_SelectByIDPAYMENT(VDDLSH );
        }
        }
        }
      
        public static DataSetPAYMENT GetPAYMENT_SelectAll(
          string sTj ,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cbd))
        {
        return dao.Data_PAYMENT_SelectAll(
          sTj  );
        }
        }
        }
        else
        {
        using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cdb))
        {
        return dao.Data_PAYMENT_SelectAll(
          sTj  );
        }
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public static int UpdatePAYMENT_DeletePAYMENT(System.String VDDLSH,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cbd))
        {
        return dao.Data_PAYMENT_DeletePAYMENT(VDDLSH);
        }
        }
        }
        else
        {
        using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cdb))
        {
        return dao.Data_PAYMENT_DeletePAYMENT(VDDLSH);
        }
        }
        }
      
        public static int UpdatePAYMENT_UpdatePAYMENT(System.Decimal NGHF , System.Decimal NZLF , System.String VSPMC , System.String VPHONE , System.DateTime DZFRQ , System.String VHAOBIE , System.String VDDLSH , System.String VNAME , System.String VCLINICNO , System.String VCARD , System.String VSFZH , System.String VDEPT , System.String VDOCTOR , System.DateTime DDDRQ , System.Decimal NCOSTS , System.Decimal NDDLX , System.String VREMARKS , System.Decimal NSTATE , System.DateTime DJZRQ , System.Decimal NDEL , System.String VAPPTIME , System.String VHZID , System.Decimal NPAYTYPE , System.String OLDVDDLSH,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cbd))
        {
        return dao.Data_PAYMENT_UpdatePAYMENT(NGHF , NZLF , VSPMC , VPHONE , DZFRQ , VHAOBIE , VDDLSH , VNAME , VCLINICNO , VCARD , VSFZH , VDEPT , VDOCTOR , DDDRQ , NCOSTS , NDDLX , VREMARKS , NSTATE , DJZRQ , NDEL , VAPPTIME , VHZID , NPAYTYPE , OLDVDDLSH);
        }
        }
        }
        else
        {
        using(PAYMENTBaseDAO dao = new PAYMENTBaseDAO(cdb))
        {
        return dao.Data_PAYMENT_UpdatePAYMENT(NGHF , NZLF , VSPMC , VPHONE , DZFRQ , VHAOBIE , VDDLSH , VNAME , VCLINICNO , VCARD , VSFZH , VDEPT , VDOCTOR , DDDRQ , NCOSTS , NDDLX , VREMARKS , NSTATE , DJZRQ , NDEL , VAPPTIME , VHZID , NPAYTYPE , OLDVDDLSH);
        }
        }
        }
      
      #endregion
    
      #region The base rules of PAYMENT_DETAIL.
      /*实体PAYMENT_DETAIL的基本规则*/
      /// 
        /// 插入PAYMENT_DETAIL实体。
        ///
      
      /// PAYMENT_DETAIL实体
      
      public static void InsertPAYMENT_DETAIL(DataSetPAYMENT_DETAIL entity,IDataBaseOperate cdb =null)
      {
          if(cdb==null)
          { 
            using( var cbd = GenerateFactory.GenerateConnect())
            {
              using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cbd))
      {
      dao.InsertEntity(entity);
      }
      }
      }
      else
      {
      using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cdb))
            {
            dao.InsertEntity(entity);
            }
        }
      }

      /// 
        /// 删除PAYMENT_DETAIL实体。
        ///
      
      /// PAYMENT_DETAIL实体
      
      public static void DeletePAYMENT_DETAIL(DataSetPAYMENT_DETAIL entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cbd))
      {
      dao.DeleteEntity(entity);
      }
      }
      }
      else
      {
      using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cdb))
      {
      dao.DeleteEntity(entity);
      }
      }
      }

      /// 
        /// 更新PAYMENT_DETAIL实体。
        ///
      
      /// PAYMENT_DETAIL实体
      
      public static void UpdatePAYMENT_DETAIL(DataSetPAYMENT_DETAIL entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cbd))
      {
      dao.UpdateEntity(entity);
      }
      }
      }
      else
      {
      using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cdb))
      {
      dao.UpdateEntity(entity);
      }
      }
      }

      
      /// 
        /// 通过给定的主键值查询PAYMENT_DETAIL实体。
        ///
      
      /// 主键id的值
      public static DataSetPAYMENT_DETAIL GetPAYMENT_DETAILByID(System.String id,IDataBaseOperate cdb =null)
      {
      DataSetPAYMENT_DETAIL entity;
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cbd))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      }
      else
      {
      using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cdb))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitPAYMENT_DETAILChanges(DataSetPAYMENT_DETAIL entity, DataRowState drs,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }
      else
      {
      using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitPAYMENT_DETAILChanges(DataSetPAYMENT_DETAIL entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cbd))
      {
      dao.CommitChanges(entity);
      }
      }
      }
      else
      {
      using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cdb))
      {
      dao.CommitChanges(entity);
      }
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitPAYMENT_DETAILChanges(DataSetPAYMENT_DETAIL entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitPAYMENT_DETAILChanges(DataSetPAYMENT_DETAIL entity,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cbd))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cdb))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }

      ///生成查询静态函数
      ///
      
        public static DataSetPAYMENT_DETAIL GetPAYMENT_DETAIL_SelectByIDPAYMENT_DETAIL(System.String VID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cbd))
        {
        return dao.Data_PAYMENT_DETAIL_SelectByIDPAYMENT_DETAIL(VID );
        }
        }
        }
        else
        {
        using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cdb))
        {
        return dao.Data_PAYMENT_DETAIL_SelectByIDPAYMENT_DETAIL(VID );
        }
        }
        }
      
        public static DataSetPAYMENT_DETAIL GetPAYMENT_DETAIL_SelectAll(
          string sTj ,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cbd))
        {
        return dao.Data_PAYMENT_DETAIL_SelectAll(
          sTj  );
        }
        }
        }
        else
        {
        using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cdb))
        {
        return dao.Data_PAYMENT_DETAIL_SelectAll(
          sTj  );
        }
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public static int UpdatePAYMENT_DETAIL_DeletePAYMENT_DETAIL(System.String VID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cbd))
        {
        return dao.Data_PAYMENT_DETAIL_DeletePAYMENT_DETAIL(VID);
        }
        }
        }
        else
        {
        using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cdb))
        {
        return dao.Data_PAYMENT_DETAIL_DeletePAYMENT_DETAIL(VID);
        }
        }
        }
      
        public static int UpdatePAYMENT_DETAIL_UpdatePAYMENT_DETAIL(System.String VID , System.String VPRESC_ID , System.String VPRESC_TYPE , System.String VITEM_CODE , System.String VITEM_NAME , System.Decimal NPRICE , System.Decimal NSL , System.String VPRESC_DETAIL_ID , System.String VCLINICNO , System.String VITEM_TYPE , System.String VDDLSH , System.String OLDVID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cbd))
        {
        return dao.Data_PAYMENT_DETAIL_UpdatePAYMENT_DETAIL(VID , VPRESC_ID , VPRESC_TYPE , VITEM_CODE , VITEM_NAME , NPRICE , NSL , VPRESC_DETAIL_ID , VCLINICNO , VITEM_TYPE , VDDLSH , OLDVID);
        }
        }
        }
        else
        {
        using(PAYMENT_DETAILBaseDAO dao = new PAYMENT_DETAILBaseDAO(cdb))
        {
        return dao.Data_PAYMENT_DETAIL_UpdatePAYMENT_DETAIL(VID , VPRESC_ID , VPRESC_TYPE , VITEM_CODE , VITEM_NAME , NPRICE , NSL , VPRESC_DETAIL_ID , VCLINICNO , VITEM_TYPE , VDDLSH , OLDVID);
        }
        }
        }
      
      #endregion
    
      #region The base rules of SIGNIN.
      /*实体SIGNIN的基本规则*/
      /// 
        /// 插入SIGNIN实体。
        ///
      
      /// SIGNIN实体
      
      public static void InsertSIGNIN(DataSetSIGNIN entity,IDataBaseOperate cdb =null)
      {
          if(cdb==null)
          { 
            using( var cbd = GenerateFactory.GenerateConnect())
            {
              using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cbd))
      {
      dao.InsertEntity(entity);
      }
      }
      }
      else
      {
      using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cdb))
            {
            dao.InsertEntity(entity);
            }
        }
      }

      /// 
        /// 删除SIGNIN实体。
        ///
      
      /// SIGNIN实体
      
      public static void DeleteSIGNIN(DataSetSIGNIN entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cbd))
      {
      dao.DeleteEntity(entity);
      }
      }
      }
      else
      {
      using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cdb))
      {
      dao.DeleteEntity(entity);
      }
      }
      }

      /// 
        /// 更新SIGNIN实体。
        ///
      
      /// SIGNIN实体
      
      public static void UpdateSIGNIN(DataSetSIGNIN entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cbd))
      {
      dao.UpdateEntity(entity);
      }
      }
      }
      else
      {
      using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cdb))
      {
      dao.UpdateEntity(entity);
      }
      }
      }

      
      /// 
        /// 通过给定的主键值查询SIGNIN实体。
        ///
      
      /// 主键id的值
      public static DataSetSIGNIN GetSIGNINByID(System.String id,IDataBaseOperate cdb =null)
      {
      DataSetSIGNIN entity;
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cbd))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      }
      else
      {
      using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cdb))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitSIGNINChanges(DataSetSIGNIN entity, DataRowState drs,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }
      else
      {
      using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitSIGNINChanges(DataSetSIGNIN entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cbd))
      {
      dao.CommitChanges(entity);
      }
      }
      }
      else
      {
      using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cdb))
      {
      dao.CommitChanges(entity);
      }
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitSIGNINChanges(DataSetSIGNIN entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitSIGNINChanges(DataSetSIGNIN entity,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cbd))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cdb))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }

      ///生成查询静态函数
      ///
      
        public static DataSetSIGNIN GetSIGNIN_SelectByIDSIGNIN(System.String VCLINICNO,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cbd))
        {
        return dao.Data_SIGNIN_SelectByIDSIGNIN(VCLINICNO );
        }
        }
        }
        else
        {
        using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cdb))
        {
        return dao.Data_SIGNIN_SelectByIDSIGNIN(VCLINICNO );
        }
        }
        }
      
        public static DataSetSIGNIN GetSIGNIN_SelectAll(
          string sTj ,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cbd))
        {
        return dao.Data_SIGNIN_SelectAll(
          sTj  );
        }
        }
        }
        else
        {
        using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cdb))
        {
        return dao.Data_SIGNIN_SelectAll(
          sTj  );
        }
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public static int UpdateSIGNIN_DeleteSIGNIN(System.String VCLINICNO,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cbd))
        {
        return dao.Data_SIGNIN_DeleteSIGNIN(VCLINICNO);
        }
        }
        }
        else
        {
        using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cdb))
        {
        return dao.Data_SIGNIN_DeleteSIGNIN(VCLINICNO);
        }
        }
        }
      
        public static int UpdateSIGNIN_UpdateSIGNIN(System.String VCLINICNO , System.DateTime DCREATE , System.Decimal NNUM , System.String OLDVCLINICNO,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cbd))
        {
        return dao.Data_SIGNIN_UpdateSIGNIN(VCLINICNO , DCREATE , NNUM , OLDVCLINICNO);
        }
        }
        }
        else
        {
        using(SIGNINBaseDAO dao = new SIGNINBaseDAO(cdb))
        {
        return dao.Data_SIGNIN_UpdateSIGNIN(VCLINICNO , DCREATE , NNUM , OLDVCLINICNO);
        }
        }
        }
      
      #endregion
    
      #region The base rules of TJ_PACKAGE.
      /*实体TJ_PACKAGE的基本规则*/
      /// 
        /// 插入TJ_PACKAGE实体。
        ///
      
      /// TJ_PACKAGE实体
      
      public static void InsertTJ_PACKAGE(DataSetTJ_PACKAGE entity,IDataBaseOperate cdb =null)
      {
          if(cdb==null)
          { 
            using( var cbd = GenerateFactory.GenerateConnect())
            {
              using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cbd))
      {
      dao.InsertEntity(entity);
      }
      }
      }
      else
      {
      using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cdb))
            {
            dao.InsertEntity(entity);
            }
        }
      }

      /// 
        /// 删除TJ_PACKAGE实体。
        ///
      
      /// TJ_PACKAGE实体
      
      public static void DeleteTJ_PACKAGE(DataSetTJ_PACKAGE entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cbd))
      {
      dao.DeleteEntity(entity);
      }
      }
      }
      else
      {
      using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cdb))
      {
      dao.DeleteEntity(entity);
      }
      }
      }

      /// 
        /// 更新TJ_PACKAGE实体。
        ///
      
      /// TJ_PACKAGE实体
      
      public static void UpdateTJ_PACKAGE(DataSetTJ_PACKAGE entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cbd))
      {
      dao.UpdateEntity(entity);
      }
      }
      }
      else
      {
      using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cdb))
      {
      dao.UpdateEntity(entity);
      }
      }
      }

      
      /// 
        /// 通过给定的主键值查询TJ_PACKAGE实体。
        ///
      
      /// 主键id的值
      public static DataSetTJ_PACKAGE GetTJ_PACKAGEByID(System.String id,IDataBaseOperate cdb =null)
      {
      DataSetTJ_PACKAGE entity;
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cbd))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      }
      else
      {
      using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cdb))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitTJ_PACKAGEChanges(DataSetTJ_PACKAGE entity, DataRowState drs,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }
      else
      {
      using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitTJ_PACKAGEChanges(DataSetTJ_PACKAGE entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cbd))
      {
      dao.CommitChanges(entity);
      }
      }
      }
      else
      {
      using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cdb))
      {
      dao.CommitChanges(entity);
      }
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitTJ_PACKAGEChanges(DataSetTJ_PACKAGE entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitTJ_PACKAGEChanges(DataSetTJ_PACKAGE entity,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cbd))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cdb))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }

      ///生成查询静态函数
      ///
      
        public static DataSetTJ_PACKAGE GetTJ_PACKAGE_SelectByIDTJ_TJ_PACKAGE(System.String NPACKAGEID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cbd))
        {
        return dao.Data_TJ_PACKAGE_SelectByIDTJ_TJ_PACKAGE(NPACKAGEID );
        }
        }
        }
        else
        {
        using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cdb))
        {
        return dao.Data_TJ_PACKAGE_SelectByIDTJ_TJ_PACKAGE(NPACKAGEID );
        }
        }
        }
      
        public static DataSetTJ_PACKAGE GetTJ_PACKAGE_SelectAll(
          string sTj ,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cbd))
        {
        return dao.Data_TJ_PACKAGE_SelectAll(
          sTj  );
        }
        }
        }
        else
        {
        using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cdb))
        {
        return dao.Data_TJ_PACKAGE_SelectAll(
          sTj  );
        }
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public static int UpdateTJ_PACKAGE_DeleteTJ_TJ_PACKAGE(System.String NPACKAGEID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cbd))
        {
        return dao.Data_TJ_PACKAGE_DeleteTJ_TJ_PACKAGE(NPACKAGEID);
        }
        }
        }
        else
        {
        using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cdb))
        {
        return dao.Data_TJ_PACKAGE_DeleteTJ_TJ_PACKAGE(NPACKAGEID);
        }
        }
        }
      
        public static int UpdateTJ_PACKAGE_UpdateTJ_TJ_PACKAGE(System.String NPACKAGEID , System.String VPEGROUPNAME , System.String WUBIMA , System.String PINYINMA , System.Decimal NVPRICE , System.Decimal NISDISCOUNTS , System.Decimal NDISCOUNTS , System.Decimal NMONEY , System.Decimal NENABLE , System.String VDESCRIPTION , System.Decimal NHOSID , System.Decimal NPACKAGETYPE , System.DateTime CREATE_DATE , System.String CREATE_DEPT , System.String CREATE_DOCT , System.DateTime LAST_DATE , System.String LAST_DOCT , System.String NORGAID , System.String OLDNPACKAGEID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cbd))
        {
        return dao.Data_TJ_PACKAGE_UpdateTJ_TJ_PACKAGE(NPACKAGEID , VPEGROUPNAME , WUBIMA , PINYINMA , NVPRICE , NISDISCOUNTS , NDISCOUNTS , NMONEY , NENABLE , VDESCRIPTION , NHOSID , NPACKAGETYPE , CREATE_DATE , CREATE_DEPT , CREATE_DOCT , LAST_DATE , LAST_DOCT , NORGAID , OLDNPACKAGEID);
        }
        }
        }
        else
        {
        using(TJ_PACKAGEBaseDAO dao = new TJ_PACKAGEBaseDAO(cdb))
        {
        return dao.Data_TJ_PACKAGE_UpdateTJ_TJ_PACKAGE(NPACKAGEID , VPEGROUPNAME , WUBIMA , PINYINMA , NVPRICE , NISDISCOUNTS , NDISCOUNTS , NMONEY , NENABLE , VDESCRIPTION , NHOSID , NPACKAGETYPE , CREATE_DATE , CREATE_DEPT , CREATE_DOCT , LAST_DATE , LAST_DOCT , NORGAID , OLDNPACKAGEID);
        }
        }
        }
      
      #endregion
    
      #region The base rules of TJ_DICNODRUGITEM.
      /*实体TJ_DICNODRUGITEM的基本规则*/
      /// 
        /// 插入TJ_DICNODRUGITEM实体。
        ///
      
      /// TJ_DICNODRUGITEM实体
      
      public static void InsertTJ_DICNODRUGITEM(DataSetTJ_DICNODRUGITEM entity,IDataBaseOperate cdb =null)
      {
          if(cdb==null)
          { 
            using( var cbd = GenerateFactory.GenerateConnect())
            {
              using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cbd))
      {
      dao.InsertEntity(entity);
      }
      }
      }
      else
      {
      using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cdb))
            {
            dao.InsertEntity(entity);
            }
        }
      }

      /// 
        /// 删除TJ_DICNODRUGITEM实体。
        ///
      
      /// TJ_DICNODRUGITEM实体
      
      public static void DeleteTJ_DICNODRUGITEM(DataSetTJ_DICNODRUGITEM entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cbd))
      {
      dao.DeleteEntity(entity);
      }
      }
      }
      else
      {
      using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cdb))
      {
      dao.DeleteEntity(entity);
      }
      }
      }

      /// 
        /// 更新TJ_DICNODRUGITEM实体。
        ///
      
      /// TJ_DICNODRUGITEM实体
      
      public static void UpdateTJ_DICNODRUGITEM(DataSetTJ_DICNODRUGITEM entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cbd))
      {
      dao.UpdateEntity(entity);
      }
      }
      }
      else
      {
      using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cdb))
      {
      dao.UpdateEntity(entity);
      }
      }
      }

      
      /// 
        /// 通过给定的主键值查询TJ_DICNODRUGITEM实体。
        ///
      
      /// 主键id的值
      public static DataSetTJ_DICNODRUGITEM GetTJ_DICNODRUGITEMByID(System.String id,IDataBaseOperate cdb =null)
      {
      DataSetTJ_DICNODRUGITEM entity;
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cbd))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      }
      else
      {
      using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cdb))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitTJ_DICNODRUGITEMChanges(DataSetTJ_DICNODRUGITEM entity, DataRowState drs,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }
      else
      {
      using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitTJ_DICNODRUGITEMChanges(DataSetTJ_DICNODRUGITEM entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cbd))
      {
      dao.CommitChanges(entity);
      }
      }
      }
      else
      {
      using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cdb))
      {
      dao.CommitChanges(entity);
      }
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitTJ_DICNODRUGITEMChanges(DataSetTJ_DICNODRUGITEM entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitTJ_DICNODRUGITEMChanges(DataSetTJ_DICNODRUGITEM entity,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cbd))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cdb))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }

      ///生成查询静态函数
      ///
      
        public static DataSetTJ_DICNODRUGITEM GetTJ_DICNODRUGITEM_SelectByIDTJ_TJ_DICNODRUGITEM(System.String NITEMID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cbd))
        {
        return dao.Data_TJ_DICNODRUGITEM_SelectByIDTJ_TJ_DICNODRUGITEM(NITEMID );
        }
        }
        }
        else
        {
        using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cdb))
        {
        return dao.Data_TJ_DICNODRUGITEM_SelectByIDTJ_TJ_DICNODRUGITEM(NITEMID );
        }
        }
        }
      
        public static DataSetTJ_DICNODRUGITEM GetTJ_DICNODRUGITEM_SelectAll(
          string sTj ,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cbd))
        {
        return dao.Data_TJ_DICNODRUGITEM_SelectAll(
          sTj  );
        }
        }
        }
        else
        {
        using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cdb))
        {
        return dao.Data_TJ_DICNODRUGITEM_SelectAll(
          sTj  );
        }
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public static int UpdateTJ_DICNODRUGITEM_DeleteTJ_TJ_DICNODRUGITEM(System.String NITEMID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cbd))
        {
        return dao.Data_TJ_DICNODRUGITEM_DeleteTJ_TJ_DICNODRUGITEM(NITEMID);
        }
        }
        }
        else
        {
        using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cdb))
        {
        return dao.Data_TJ_DICNODRUGITEM_DeleteTJ_TJ_DICNODRUGITEM(NITEMID);
        }
        }
        }
      
        public static int UpdateTJ_DICNODRUGITEM_UpdateTJ_TJ_DICNODRUGITEM(System.String EVITEMNAME , System.Decimal HISNITEMTYPE , System.String LISUNIT , System.DateTime CREATE_DATE , System.String CREATE_DEPT , System.String CREATE_DOCT , System.DateTime LAST_DATE , System.String LAST_DOCT , System.String NITEMID , System.Decimal NNODRUGITEMPRICE , System.Decimal NNODRUGITEMUNIT , System.String VDEPARTID , System.Decimal NISSTOP , System.Decimal NISPACK , System.String VITEMDES , System.String PINYINMA , System.String WUBIMA , System.Decimal NCHARGETYPEID , System.String VITEMNAME , System.Decimal DZHEKOU , System.Decimal NPFP , System.Decimal NJGLX , System.Decimal NCKSX , System.Decimal NCKXX , System.String VPDTS , System.String VPGTS , System.String VZCTS , System.String VYCTS , System.String NCKZ , System.String VNEGTS , System.String VPOSTS , System.Decimal NHOSID , System.String HISNITEMID , System.String VITEMADDRESS , System.String OLDNITEMID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cbd))
        {
        return dao.Data_TJ_DICNODRUGITEM_UpdateTJ_TJ_DICNODRUGITEM(EVITEMNAME , HISNITEMTYPE , LISUNIT , CREATE_DATE , CREATE_DEPT , CREATE_DOCT , LAST_DATE , LAST_DOCT , NITEMID , NNODRUGITEMPRICE , NNODRUGITEMUNIT , VDEPARTID , NISSTOP , NISPACK , VITEMDES , PINYINMA , WUBIMA , NCHARGETYPEID , VITEMNAME , DZHEKOU , NPFP , NJGLX , NCKSX , NCKXX , VPDTS , VPGTS , VZCTS , VYCTS , NCKZ , VNEGTS , VPOSTS , NHOSID , HISNITEMID , VITEMADDRESS , OLDNITEMID);
        }
        }
        }
        else
        {
        using(TJ_DICNODRUGITEMBaseDAO dao = new TJ_DICNODRUGITEMBaseDAO(cdb))
        {
        return dao.Data_TJ_DICNODRUGITEM_UpdateTJ_TJ_DICNODRUGITEM(EVITEMNAME , HISNITEMTYPE , LISUNIT , CREATE_DATE , CREATE_DEPT , CREATE_DOCT , LAST_DATE , LAST_DOCT , NITEMID , NNODRUGITEMPRICE , NNODRUGITEMUNIT , VDEPARTID , NISSTOP , NISPACK , VITEMDES , PINYINMA , WUBIMA , NCHARGETYPEID , VITEMNAME , DZHEKOU , NPFP , NJGLX , NCKSX , NCKXX , VPDTS , VPGTS , VZCTS , VYCTS , NCKZ , VNEGTS , VPOSTS , NHOSID , HISNITEMID , VITEMADDRESS , OLDNITEMID);
        }
        }
        }
      
      #endregion
    
      #region The base rules of TJ_PACKAGESECON.
      /*实体TJ_PACKAGESECON的基本规则*/
      /// 
        /// 插入TJ_PACKAGESECON实体。
        ///
      
      /// TJ_PACKAGESECON实体
      
      public static void InsertTJ_PACKAGESECON(DataSetTJ_PACKAGESECON entity,IDataBaseOperate cdb =null)
      {
          if(cdb==null)
          { 
            using( var cbd = GenerateFactory.GenerateConnect())
            {
              using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cbd))
      {
      dao.InsertEntity(entity);
      }
      }
      }
      else
      {
      using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cdb))
            {
            dao.InsertEntity(entity);
            }
        }
      }

      /// 
        /// 删除TJ_PACKAGESECON实体。
        ///
      
      /// TJ_PACKAGESECON实体
      
      public static void DeleteTJ_PACKAGESECON(DataSetTJ_PACKAGESECON entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cbd))
      {
      dao.DeleteEntity(entity);
      }
      }
      }
      else
      {
      using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cdb))
      {
      dao.DeleteEntity(entity);
      }
      }
      }

      /// 
        /// 更新TJ_PACKAGESECON实体。
        ///
      
      /// TJ_PACKAGESECON实体
      
      public static void UpdateTJ_PACKAGESECON(DataSetTJ_PACKAGESECON entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cbd))
      {
      dao.UpdateEntity(entity);
      }
      }
      }
      else
      {
      using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cdb))
      {
      dao.UpdateEntity(entity);
      }
      }
      }

      
      /// 
        /// 通过给定的主键值查询TJ_PACKAGESECON实体。
        ///
      
      /// 主键id的值
      public static DataSetTJ_PACKAGESECON GetTJ_PACKAGESECONByID(System.String id,IDataBaseOperate cdb =null)
      {
      DataSetTJ_PACKAGESECON entity;
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cbd))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      }
      else
      {
      using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cdb))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitTJ_PACKAGESECONChanges(DataSetTJ_PACKAGESECON entity, DataRowState drs,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }
      else
      {
      using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitTJ_PACKAGESECONChanges(DataSetTJ_PACKAGESECON entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cbd))
      {
      dao.CommitChanges(entity);
      }
      }
      }
      else
      {
      using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cdb))
      {
      dao.CommitChanges(entity);
      }
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitTJ_PACKAGESECONChanges(DataSetTJ_PACKAGESECON entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitTJ_PACKAGESECONChanges(DataSetTJ_PACKAGESECON entity,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cbd))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cdb))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }

      ///生成查询静态函数
      ///
      
        public static DataSetTJ_PACKAGESECON GetTJ_PACKAGESECON_SelectByIDTJ_TJ_PACKAGESECON(System.String NSECID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cbd))
        {
        return dao.Data_TJ_PACKAGESECON_SelectByIDTJ_TJ_PACKAGESECON(NSECID );
        }
        }
        }
        else
        {
        using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cdb))
        {
        return dao.Data_TJ_PACKAGESECON_SelectByIDTJ_TJ_PACKAGESECON(NSECID );
        }
        }
        }
      
        public static DataSetTJ_PACKAGESECON GetTJ_PACKAGESECON_SelectAll(
          string sTj ,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cbd))
        {
        return dao.Data_TJ_PACKAGESECON_SelectAll(
          sTj  );
        }
        }
        }
        else
        {
        using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cdb))
        {
        return dao.Data_TJ_PACKAGESECON_SelectAll(
          sTj  );
        }
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public static int UpdateTJ_PACKAGESECON_DeleteTJ_TJ_PACKAGESECON(System.String NSECID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cbd))
        {
        return dao.Data_TJ_PACKAGESECON_DeleteTJ_TJ_PACKAGESECON(NSECID);
        }
        }
        }
        else
        {
        using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cdb))
        {
        return dao.Data_TJ_PACKAGESECON_DeleteTJ_TJ_PACKAGESECON(NSECID);
        }
        }
        }
      
        public static int UpdateTJ_PACKAGESECON_UpdateTJ_TJ_PACKAGESECON(System.String CREATEDEPARTID , System.String CREATEDEPARTNAME , System.String NSECID , System.String NPACKAGEID , System.String NITEMID , System.String VITEMNAME , System.Decimal NVPRICE , System.Decimal NISDISCOUNTS , System.Decimal NDISCOUNTS , System.Decimal NMONEY , System.DateTime CREATEDATE , System.String CREATESTAFFCODE , System.String CREATESTAFFNAME , System.String OLDNSECID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cbd))
        {
        return dao.Data_TJ_PACKAGESECON_UpdateTJ_TJ_PACKAGESECON(CREATEDEPARTID , CREATEDEPARTNAME , NSECID , NPACKAGEID , NITEMID , VITEMNAME , NVPRICE , NISDISCOUNTS , NDISCOUNTS , NMONEY , CREATEDATE , CREATESTAFFCODE , CREATESTAFFNAME , OLDNSECID);
        }
        }
        }
        else
        {
        using(TJ_PACKAGESECONBaseDAO dao = new TJ_PACKAGESECONBaseDAO(cdb))
        {
        return dao.Data_TJ_PACKAGESECON_UpdateTJ_TJ_PACKAGESECON(CREATEDEPARTID , CREATEDEPARTNAME , NSECID , NPACKAGEID , NITEMID , VITEMNAME , NVPRICE , NISDISCOUNTS , NDISCOUNTS , NMONEY , CREATEDATE , CREATESTAFFCODE , CREATESTAFFNAME , OLDNSECID);
        }
        }
        }
      
      #endregion
    
      #region The base rules of WJ_DICTITLE.
      /*实体WJ_DICTITLE的基本规则*/
      /// 
        /// 插入WJ_DICTITLE实体。
        ///
      
      /// WJ_DICTITLE实体
      
      public static void InsertWJ_DICTITLE(DataSetWJ_DICTITLE entity,IDataBaseOperate cdb =null)
      {
          if(cdb==null)
          { 
            using( var cbd = GenerateFactory.GenerateConnect())
            {
              using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cbd))
      {
      dao.InsertEntity(entity);
      }
      }
      }
      else
      {
      using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cdb))
            {
            dao.InsertEntity(entity);
            }
        }
      }

      /// 
        /// 删除WJ_DICTITLE实体。
        ///
      
      /// WJ_DICTITLE实体
      
      public static void DeleteWJ_DICTITLE(DataSetWJ_DICTITLE entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cbd))
      {
      dao.DeleteEntity(entity);
      }
      }
      }
      else
      {
      using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cdb))
      {
      dao.DeleteEntity(entity);
      }
      }
      }

      /// 
        /// 更新WJ_DICTITLE实体。
        ///
      
      /// WJ_DICTITLE实体
      
      public static void UpdateWJ_DICTITLE(DataSetWJ_DICTITLE entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cbd))
      {
      dao.UpdateEntity(entity);
      }
      }
      }
      else
      {
      using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cdb))
      {
      dao.UpdateEntity(entity);
      }
      }
      }

      
      /// 
        /// 通过给定的主键值查询WJ_DICTITLE实体。
        ///
      
      /// 主键id的值
      public static DataSetWJ_DICTITLE GetWJ_DICTITLEByID(System.String id,IDataBaseOperate cdb =null)
      {
      DataSetWJ_DICTITLE entity;
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cbd))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      }
      else
      {
      using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cdb))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitWJ_DICTITLEChanges(DataSetWJ_DICTITLE entity, DataRowState drs,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }
      else
      {
      using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitWJ_DICTITLEChanges(DataSetWJ_DICTITLE entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cbd))
      {
      dao.CommitChanges(entity);
      }
      }
      }
      else
      {
      using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cdb))
      {
      dao.CommitChanges(entity);
      }
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitWJ_DICTITLEChanges(DataSetWJ_DICTITLE entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitWJ_DICTITLEChanges(DataSetWJ_DICTITLE entity,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cbd))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cdb))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }

      ///生成查询静态函数
      ///
      
        public static DataSetWJ_DICTITLE GetWJ_DICTITLE_SelectByIDWJ_DICTITLE(System.String VID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cbd))
        {
        return dao.Data_WJ_DICTITLE_SelectByIDWJ_DICTITLE(VID );
        }
        }
        }
        else
        {
        using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cdb))
        {
        return dao.Data_WJ_DICTITLE_SelectByIDWJ_DICTITLE(VID );
        }
        }
        }
      
        public static DataSetWJ_DICTITLE GetWJ_DICTITLE_SelectAll(
          string sTj ,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cbd))
        {
        return dao.Data_WJ_DICTITLE_SelectAll(
          sTj  );
        }
        }
        }
        else
        {
        using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cdb))
        {
        return dao.Data_WJ_DICTITLE_SelectAll(
          sTj  );
        }
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public static int UpdateWJ_DICTITLE_DeleteWJ_DICTITLE(System.String VID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cbd))
        {
        return dao.Data_WJ_DICTITLE_DeleteWJ_DICTITLE(VID);
        }
        }
        }
        else
        {
        using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cdb))
        {
        return dao.Data_WJ_DICTITLE_DeleteWJ_DICTITLE(VID);
        }
        }
        }
      
        public static int UpdateWJ_DICTITLE_UpdateWJ_DICTITLE(System.String VID , System.String VNAME , System.String VREMARKS , System.DateTime DCREATE , System.String VINPUTID , System.Decimal NSTOP , System.Decimal NSORT , System.String OLDVID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cbd))
        {
        return dao.Data_WJ_DICTITLE_UpdateWJ_DICTITLE(VID , VNAME , VREMARKS , DCREATE , VINPUTID , NSTOP , NSORT , OLDVID);
        }
        }
        }
        else
        {
        using(WJ_DICTITLEBaseDAO dao = new WJ_DICTITLEBaseDAO(cdb))
        {
        return dao.Data_WJ_DICTITLE_UpdateWJ_DICTITLE(VID , VNAME , VREMARKS , DCREATE , VINPUTID , NSTOP , NSORT , OLDVID);
        }
        }
        }
      
      #endregion
    
      #region The base rules of WJ_DICQUESTION.
      /*实体WJ_DICQUESTION的基本规则*/
      /// 
        /// 插入WJ_DICQUESTION实体。
        ///
      
      /// WJ_DICQUESTION实体
      
      public static void InsertWJ_DICQUESTION(DataSetWJ_DICQUESTION entity,IDataBaseOperate cdb =null)
      {
          if(cdb==null)
          { 
            using( var cbd = GenerateFactory.GenerateConnect())
            {
              using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cbd))
      {
      dao.InsertEntity(entity);
      }
      }
      }
      else
      {
      using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cdb))
            {
            dao.InsertEntity(entity);
            }
        }
      }

      /// 
        /// 删除WJ_DICQUESTION实体。
        ///
      
      /// WJ_DICQUESTION实体
      
      public static void DeleteWJ_DICQUESTION(DataSetWJ_DICQUESTION entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cbd))
      {
      dao.DeleteEntity(entity);
      }
      }
      }
      else
      {
      using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cdb))
      {
      dao.DeleteEntity(entity);
      }
      }
      }

      /// 
        /// 更新WJ_DICQUESTION实体。
        ///
      
      /// WJ_DICQUESTION实体
      
      public static void UpdateWJ_DICQUESTION(DataSetWJ_DICQUESTION entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cbd))
      {
      dao.UpdateEntity(entity);
      }
      }
      }
      else
      {
      using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cdb))
      {
      dao.UpdateEntity(entity);
      }
      }
      }

      
      /// 
        /// 通过给定的主键值查询WJ_DICQUESTION实体。
        ///
      
      /// 主键id的值
      public static DataSetWJ_DICQUESTION GetWJ_DICQUESTIONByID(System.String id,IDataBaseOperate cdb =null)
      {
      DataSetWJ_DICQUESTION entity;
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cbd))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      }
      else
      {
      using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cdb))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitWJ_DICQUESTIONChanges(DataSetWJ_DICQUESTION entity, DataRowState drs,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }
      else
      {
      using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitWJ_DICQUESTIONChanges(DataSetWJ_DICQUESTION entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cbd))
      {
      dao.CommitChanges(entity);
      }
      }
      }
      else
      {
      using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cdb))
      {
      dao.CommitChanges(entity);
      }
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitWJ_DICQUESTIONChanges(DataSetWJ_DICQUESTION entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitWJ_DICQUESTIONChanges(DataSetWJ_DICQUESTION entity,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cbd))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cdb))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }

      ///生成查询静态函数
      ///
      
        public static DataSetWJ_DICQUESTION GetWJ_DICQUESTION_SelectByIDWJ_DICQUESTION(System.String VID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cbd))
        {
        return dao.Data_WJ_DICQUESTION_SelectByIDWJ_DICQUESTION(VID );
        }
        }
        }
        else
        {
        using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cdb))
        {
        return dao.Data_WJ_DICQUESTION_SelectByIDWJ_DICQUESTION(VID );
        }
        }
        }
      
        public static DataSetWJ_DICQUESTION GetWJ_DICQUESTION_SelectAll(
          string sTj ,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cbd))
        {
        return dao.Data_WJ_DICQUESTION_SelectAll(
          sTj  );
        }
        }
        }
        else
        {
        using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cdb))
        {
        return dao.Data_WJ_DICQUESTION_SelectAll(
          sTj  );
        }
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public static int UpdateWJ_DICQUESTION_DeleteWJ_DICQUESTION(System.String VID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cbd))
        {
        return dao.Data_WJ_DICQUESTION_DeleteWJ_DICQUESTION(VID);
        }
        }
        }
        else
        {
        using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cdb))
        {
        return dao.Data_WJ_DICQUESTION_DeleteWJ_DICQUESTION(VID);
        }
        }
        }
      
        public static int UpdateWJ_DICQUESTION_UpdateWJ_DICQUESTION(System.String VID , System.String VNAME , System.Decimal NSTOP , System.Decimal NLX , System.String VPID , System.DateTime DCREATE , System.Decimal NSORT , System.Decimal NBIXUAN , System.String OLDVID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cbd))
        {
        return dao.Data_WJ_DICQUESTION_UpdateWJ_DICQUESTION(VID , VNAME , NSTOP , NLX , VPID , DCREATE , NSORT , NBIXUAN , OLDVID);
        }
        }
        }
        else
        {
        using(WJ_DICQUESTIONBaseDAO dao = new WJ_DICQUESTIONBaseDAO(cdb))
        {
        return dao.Data_WJ_DICQUESTION_UpdateWJ_DICQUESTION(VID , VNAME , NSTOP , NLX , VPID , DCREATE , NSORT , NBIXUAN , OLDVID);
        }
        }
        }
      
      #endregion
    
      #region The base rules of WJ_DICANSWER.
      /*实体WJ_DICANSWER的基本规则*/
      /// 
        /// 插入WJ_DICANSWER实体。
        ///
      
      /// WJ_DICANSWER实体
      
      public static void InsertWJ_DICANSWER(DataSetWJ_DICANSWER entity,IDataBaseOperate cdb =null)
      {
          if(cdb==null)
          { 
            using( var cbd = GenerateFactory.GenerateConnect())
            {
              using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cbd))
      {
      dao.InsertEntity(entity);
      }
      }
      }
      else
      {
      using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cdb))
            {
            dao.InsertEntity(entity);
            }
        }
      }

      /// 
        /// 删除WJ_DICANSWER实体。
        ///
      
      /// WJ_DICANSWER实体
      
      public static void DeleteWJ_DICANSWER(DataSetWJ_DICANSWER entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cbd))
      {
      dao.DeleteEntity(entity);
      }
      }
      }
      else
      {
      using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cdb))
      {
      dao.DeleteEntity(entity);
      }
      }
      }

      /// 
        /// 更新WJ_DICANSWER实体。
        ///
      
      /// WJ_DICANSWER实体
      
      public static void UpdateWJ_DICANSWER(DataSetWJ_DICANSWER entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cbd))
      {
      dao.UpdateEntity(entity);
      }
      }
      }
      else
      {
      using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cdb))
      {
      dao.UpdateEntity(entity);
      }
      }
      }

      
      /// 
        /// 通过给定的主键值查询WJ_DICANSWER实体。
        ///
      
      /// 主键id的值
      public static DataSetWJ_DICANSWER GetWJ_DICANSWERByID(System.String id,IDataBaseOperate cdb =null)
      {
      DataSetWJ_DICANSWER entity;
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cbd))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      }
      else
      {
      using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cdb))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitWJ_DICANSWERChanges(DataSetWJ_DICANSWER entity, DataRowState drs,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }
      else
      {
      using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitWJ_DICANSWERChanges(DataSetWJ_DICANSWER entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cbd))
      {
      dao.CommitChanges(entity);
      }
      }
      }
      else
      {
      using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cdb))
      {
      dao.CommitChanges(entity);
      }
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitWJ_DICANSWERChanges(DataSetWJ_DICANSWER entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitWJ_DICANSWERChanges(DataSetWJ_DICANSWER entity,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cbd))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cdb))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }

      ///生成查询静态函数
      ///
      
        public static DataSetWJ_DICANSWER GetWJ_DICANSWER_SelectByIDWJ_DICANSWER(System.String VID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cbd))
        {
        return dao.Data_WJ_DICANSWER_SelectByIDWJ_DICANSWER(VID );
        }
        }
        }
        else
        {
        using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cdb))
        {
        return dao.Data_WJ_DICANSWER_SelectByIDWJ_DICANSWER(VID );
        }
        }
        }
      
        public static DataSetWJ_DICANSWER GetWJ_DICANSWER_SelectAll(
          string sTj ,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cbd))
        {
        return dao.Data_WJ_DICANSWER_SelectAll(
          sTj  );
        }
        }
        }
        else
        {
        using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cdb))
        {
        return dao.Data_WJ_DICANSWER_SelectAll(
          sTj  );
        }
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public static int UpdateWJ_DICANSWER_DeleteWJ_DICANSWER(System.String VID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cbd))
        {
        return dao.Data_WJ_DICANSWER_DeleteWJ_DICANSWER(VID);
        }
        }
        }
        else
        {
        using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cdb))
        {
        return dao.Data_WJ_DICANSWER_DeleteWJ_DICANSWER(VID);
        }
        }
        }
      
        public static int UpdateWJ_DICANSWER_UpdateWJ_DICANSWER(System.String VID , System.String VNAME , System.String VPID , System.Decimal NSTOP , System.DateTime DCREATE , System.Decimal NSORT , System.String OLDVID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cbd))
        {
        return dao.Data_WJ_DICANSWER_UpdateWJ_DICANSWER(VID , VNAME , VPID , NSTOP , DCREATE , NSORT , OLDVID);
        }
        }
        }
        else
        {
        using(WJ_DICANSWERBaseDAO dao = new WJ_DICANSWERBaseDAO(cdb))
        {
        return dao.Data_WJ_DICANSWER_UpdateWJ_DICANSWER(VID , VNAME , VPID , NSTOP , DCREATE , NSORT , OLDVID);
        }
        }
        }
      
      #endregion
    
      #region The base rules of WJ_RECORD.
      /*实体WJ_RECORD的基本规则*/
      /// 
        /// 插入WJ_RECORD实体。
        ///
      
      /// WJ_RECORD实体
      
      public static void InsertWJ_RECORD(DataSetWJ_RECORD entity,IDataBaseOperate cdb =null)
      {
          if(cdb==null)
          { 
            using( var cbd = GenerateFactory.GenerateConnect())
            {
              using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cbd))
      {
      dao.InsertEntity(entity);
      }
      }
      }
      else
      {
      using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cdb))
            {
            dao.InsertEntity(entity);
            }
        }
      }

      /// 
        /// 删除WJ_RECORD实体。
        ///
      
      /// WJ_RECORD实体
      
      public static void DeleteWJ_RECORD(DataSetWJ_RECORD entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cbd))
      {
      dao.DeleteEntity(entity);
      }
      }
      }
      else
      {
      using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cdb))
      {
      dao.DeleteEntity(entity);
      }
      }
      }

      /// 
        /// 更新WJ_RECORD实体。
        ///
      
      /// WJ_RECORD实体
      
      public static void UpdateWJ_RECORD(DataSetWJ_RECORD entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cbd))
      {
      dao.UpdateEntity(entity);
      }
      }
      }
      else
      {
      using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cdb))
      {
      dao.UpdateEntity(entity);
      }
      }
      }

      
      /// 
        /// 通过给定的主键值查询WJ_RECORD实体。
        ///
      
      /// 主键id的值
      public static DataSetWJ_RECORD GetWJ_RECORDByID(System.String id,IDataBaseOperate cdb =null)
      {
      DataSetWJ_RECORD entity;
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cbd))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      }
      else
      {
      using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cdb))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitWJ_RECORDChanges(DataSetWJ_RECORD entity, DataRowState drs,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }
      else
      {
      using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitWJ_RECORDChanges(DataSetWJ_RECORD entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cbd))
      {
      dao.CommitChanges(entity);
      }
      }
      }
      else
      {
      using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cdb))
      {
      dao.CommitChanges(entity);
      }
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitWJ_RECORDChanges(DataSetWJ_RECORD entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitWJ_RECORDChanges(DataSetWJ_RECORD entity,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cbd))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cdb))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }

      ///生成查询静态函数
      ///
      
        public static DataSetWJ_RECORD GetWJ_RECORD_SelectByIDWJ_RECORD(System.String VID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cbd))
        {
        return dao.Data_WJ_RECORD_SelectByIDWJ_RECORD(VID );
        }
        }
        }
        else
        {
        using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cdb))
        {
        return dao.Data_WJ_RECORD_SelectByIDWJ_RECORD(VID );
        }
        }
        }
      
        public static DataSetWJ_RECORD GetWJ_RECORD_SelectAll(
          string sTj ,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cbd))
        {
        return dao.Data_WJ_RECORD_SelectAll(
          sTj  );
        }
        }
        }
        else
        {
        using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cdb))
        {
        return dao.Data_WJ_RECORD_SelectAll(
          sTj  );
        }
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public static int UpdateWJ_RECORD_DeleteWJ_RECORD(System.String VID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cbd))
        {
        return dao.Data_WJ_RECORD_DeleteWJ_RECORD(VID);
        }
        }
        }
        else
        {
        using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cdb))
        {
        return dao.Data_WJ_RECORD_DeleteWJ_RECORD(VID);
        }
        }
        }
      
        public static int UpdateWJ_RECORD_UpdateWJ_RECORD(System.String VID , System.String VWJID , System.String VWJMC , System.String VQUESID , System.String VINPUTID , System.DateTime DCREATE , System.String VQUESNAME , System.String VANSID , System.String VANSNAME , System.String VDJH , System.String OLDVID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cbd))
        {
        return dao.Data_WJ_RECORD_UpdateWJ_RECORD(VID , VWJID , VWJMC , VQUESID , VINPUTID , DCREATE , VQUESNAME , VANSID , VANSNAME , VDJH , OLDVID);
        }
        }
        }
        else
        {
        using(WJ_RECORDBaseDAO dao = new WJ_RECORDBaseDAO(cdb))
        {
        return dao.Data_WJ_RECORD_UpdateWJ_RECORD(VID , VWJID , VWJMC , VQUESID , VINPUTID , DCREATE , VQUESNAME , VANSID , VANSNAME , VDJH , OLDVID);
        }
        }
        }
      
      #endregion
    
      #region The base rules of TW_QUESTION.
      /*实体TW_QUESTION的基本规则*/
      /// 
        /// 插入TW_QUESTION实体。
        ///
      
      /// TW_QUESTION实体
      
      public static void InsertTW_QUESTION(DataSetTW_QUESTION entity,IDataBaseOperate cdb =null)
      {
          if(cdb==null)
          { 
            using( var cbd = GenerateFactory.GenerateConnect())
            {
              using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cbd))
      {
      dao.InsertEntity(entity);
      }
      }
      }
      else
      {
      using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cdb))
            {
            dao.InsertEntity(entity);
            }
        }
      }

      /// 
        /// 删除TW_QUESTION实体。
        ///
      
      /// TW_QUESTION实体
      
      public static void DeleteTW_QUESTION(DataSetTW_QUESTION entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cbd))
      {
      dao.DeleteEntity(entity);
      }
      }
      }
      else
      {
      using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cdb))
      {
      dao.DeleteEntity(entity);
      }
      }
      }

      /// 
        /// 更新TW_QUESTION实体。
        ///
      
      /// TW_QUESTION实体
      
      public static void UpdateTW_QUESTION(DataSetTW_QUESTION entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cbd))
      {
      dao.UpdateEntity(entity);
      }
      }
      }
      else
      {
      using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cdb))
      {
      dao.UpdateEntity(entity);
      }
      }
      }

      
      /// 
        /// 通过给定的主键值查询TW_QUESTION实体。
        ///
      
      /// 主键id的值
      public static DataSetTW_QUESTION GetTW_QUESTIONByID(System.String id,IDataBaseOperate cdb =null)
      {
      DataSetTW_QUESTION entity;
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cbd))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      }
      else
      {
      using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cdb))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitTW_QUESTIONChanges(DataSetTW_QUESTION entity, DataRowState drs,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }
      else
      {
      using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitTW_QUESTIONChanges(DataSetTW_QUESTION entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cbd))
      {
      dao.CommitChanges(entity);
      }
      }
      }
      else
      {
      using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cdb))
      {
      dao.CommitChanges(entity);
      }
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitTW_QUESTIONChanges(DataSetTW_QUESTION entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitTW_QUESTIONChanges(DataSetTW_QUESTION entity,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cbd))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cdb))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }

      ///生成查询静态函数
      ///
      
        public static DataSetTW_QUESTION GetTW_QUESTION_SelectByIDTW_QUESTION(System.String VID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cbd))
        {
        return dao.Data_TW_QUESTION_SelectByIDTW_QUESTION(VID );
        }
        }
        }
        else
        {
        using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cdb))
        {
        return dao.Data_TW_QUESTION_SelectByIDTW_QUESTION(VID );
        }
        }
        }
      
        public static DataSetTW_QUESTION GetTW_QUESTION_selectAll(
          string sTj ,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cbd))
        {
        return dao.Data_TW_QUESTION_selectAll(
          sTj  );
        }
        }
        }
        else
        {
        using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cdb))
        {
        return dao.Data_TW_QUESTION_selectAll(
          sTj  );
        }
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public static int UpdateTW_QUESTION_DeleteTW_QUESTION(System.String VID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cbd))
        {
        return dao.Data_TW_QUESTION_DeleteTW_QUESTION(VID);
        }
        }
        }
        else
        {
        using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cdb))
        {
        return dao.Data_TW_QUESTION_DeleteTW_QUESTION(VID);
        }
        }
        }
      
        public static int UpdateTW_QUESTION_UpdateTW_QUESTION(System.String VID , System.String VTITLE , System.String VDETAIL , System.DateTime DCREATE , System.String VINPUTID , System.Byte[] IMG , System.Decimal NSTATUS , System.Decimal NDEL , System.String OLDVID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cbd))
        {
        return dao.Data_TW_QUESTION_UpdateTW_QUESTION(VID , VTITLE , VDETAIL , DCREATE , VINPUTID , IMG , NSTATUS , NDEL , OLDVID);
        }
        }
        }
        else
        {
        using(TW_QUESTIONBaseDAO dao = new TW_QUESTIONBaseDAO(cdb))
        {
        return dao.Data_TW_QUESTION_UpdateTW_QUESTION(VID , VTITLE , VDETAIL , DCREATE , VINPUTID , IMG , NSTATUS , NDEL , OLDVID);
        }
        }
        }
      
      #endregion
    
      #region The base rules of TW_ANSWER.
      /*实体TW_ANSWER的基本规则*/
      /// 
        /// 插入TW_ANSWER实体。
        ///
      
      /// TW_ANSWER实体
      
      public static void InsertTW_ANSWER(DataSetTW_ANSWER entity,IDataBaseOperate cdb =null)
      {
          if(cdb==null)
          { 
            using( var cbd = GenerateFactory.GenerateConnect())
            {
              using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cbd))
      {
      dao.InsertEntity(entity);
      }
      }
      }
      else
      {
      using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cdb))
            {
            dao.InsertEntity(entity);
            }
        }
      }

      /// 
        /// 删除TW_ANSWER实体。
        ///
      
      /// TW_ANSWER实体
      
      public static void DeleteTW_ANSWER(DataSetTW_ANSWER entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cbd))
      {
      dao.DeleteEntity(entity);
      }
      }
      }
      else
      {
      using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cdb))
      {
      dao.DeleteEntity(entity);
      }
      }
      }

      /// 
        /// 更新TW_ANSWER实体。
        ///
      
      /// TW_ANSWER实体
      
      public static void UpdateTW_ANSWER(DataSetTW_ANSWER entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cbd))
      {
      dao.UpdateEntity(entity);
      }
      }
      }
      else
      {
      using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cdb))
      {
      dao.UpdateEntity(entity);
      }
      }
      }

      
      /// 
        /// 通过给定的主键值查询TW_ANSWER实体。
        ///
      
      /// 主键id的值
      public static DataSetTW_ANSWER GetTW_ANSWERByID(System.String id,IDataBaseOperate cdb =null)
      {
      DataSetTW_ANSWER entity;
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cbd))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      }
      else
      {
      using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cdb))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitTW_ANSWERChanges(DataSetTW_ANSWER entity, DataRowState drs,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }
      else
      {
      using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitTW_ANSWERChanges(DataSetTW_ANSWER entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cbd))
      {
      dao.CommitChanges(entity);
      }
      }
      }
      else
      {
      using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cdb))
      {
      dao.CommitChanges(entity);
      }
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitTW_ANSWERChanges(DataSetTW_ANSWER entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitTW_ANSWERChanges(DataSetTW_ANSWER entity,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cbd))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cdb))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }

      ///生成查询静态函数
      ///
      
        public static DataSetTW_ANSWER GetTW_ANSWER_SelectByIDTW_ANSWER(System.String VID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cbd))
        {
        return dao.Data_TW_ANSWER_SelectByIDTW_ANSWER(VID );
        }
        }
        }
        else
        {
        using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cdb))
        {
        return dao.Data_TW_ANSWER_SelectByIDTW_ANSWER(VID );
        }
        }
        }
      
        public static DataSetTW_ANSWER GetTW_ANSWER_selectAll(
          string sTj ,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cbd))
        {
        return dao.Data_TW_ANSWER_selectAll(
          sTj  );
        }
        }
        }
        else
        {
        using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cdb))
        {
        return dao.Data_TW_ANSWER_selectAll(
          sTj  );
        }
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public static int UpdateTW_ANSWER_DeleteTW_ANSWER(System.String VID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cbd))
        {
        return dao.Data_TW_ANSWER_DeleteTW_ANSWER(VID);
        }
        }
        }
        else
        {
        using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cdb))
        {
        return dao.Data_TW_ANSWER_DeleteTW_ANSWER(VID);
        }
        }
        }
      
        public static int UpdateTW_ANSWER_UpdateTW_ANSWER(System.Byte[] IMG , System.Decimal NDEL , System.DateTime DMODIFY , System.String VHUIFUID , System.String VID , System.String VQUESID , System.String VCONTENT , System.DateTime DCREATE , System.String VINPUTID , System.String OLDVID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cbd))
        {
        return dao.Data_TW_ANSWER_UpdateTW_ANSWER(IMG , NDEL , DMODIFY , VHUIFUID , VID , VQUESID , VCONTENT , DCREATE , VINPUTID , OLDVID);
        }
        }
        }
        else
        {
        using(TW_ANSWERBaseDAO dao = new TW_ANSWERBaseDAO(cdb))
        {
        return dao.Data_TW_ANSWER_UpdateTW_ANSWER(IMG , NDEL , DMODIFY , VHUIFUID , VID , VQUESID , VCONTENT , DCREATE , VINPUTID , OLDVID);
        }
        }
        }
      
      #endregion
    
      #region The base rules of CHAT_RECORD.
      /*实体CHAT_RECORD的基本规则*/
      /// 
        /// 插入CHAT_RECORD实体。
        ///
      
      /// CHAT_RECORD实体
      
      public static void InsertCHAT_RECORD(DataSetCHAT_RECORD entity,IDataBaseOperate cdb =null)
      {
          if(cdb==null)
          { 
            using( var cbd = GenerateFactory.GenerateConnect())
            {
              using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cbd))
      {
      dao.InsertEntity(entity);
      }
      }
      }
      else
      {
      using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cdb))
            {
            dao.InsertEntity(entity);
            }
        }
      }

      /// 
        /// 删除CHAT_RECORD实体。
        ///
      
      /// CHAT_RECORD实体
      
      public static void DeleteCHAT_RECORD(DataSetCHAT_RECORD entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cbd))
      {
      dao.DeleteEntity(entity);
      }
      }
      }
      else
      {
      using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cdb))
      {
      dao.DeleteEntity(entity);
      }
      }
      }

      /// 
        /// 更新CHAT_RECORD实体。
        ///
      
      /// CHAT_RECORD实体
      
      public static void UpdateCHAT_RECORD(DataSetCHAT_RECORD entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cbd))
      {
      dao.UpdateEntity(entity);
      }
      }
      }
      else
      {
      using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cdb))
      {
      dao.UpdateEntity(entity);
      }
      }
      }

      
      /// 
        /// 通过给定的主键值查询CHAT_RECORD实体。
        ///
      
      /// 主键id的值
      public static DataSetCHAT_RECORD GetCHAT_RECORDByID(System.String id,IDataBaseOperate cdb =null)
      {
      DataSetCHAT_RECORD entity;
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cbd))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      }
      else
      {
      using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cdb))
      {
      entity = dao.FindByPrimaryKey(id);
      }
      }
      return entity;
      }

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitCHAT_RECORDChanges(DataSetCHAT_RECORD entity, DataRowState drs,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }
      else
      {
      using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitCHAT_RECORDChanges(DataSetCHAT_RECORD entity,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cbd))
      {
      dao.CommitChanges(entity);
      }
      }
      }
      else
      {
      using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cdb))
      {
      dao.CommitChanges(entity);
      }
      }
      }

      //// 新增带控制参数函数

      /// 
        /// 检查给定的实体是否有给定状态的更改，如果有把更改的行提交到数据库。
        ///
      
      /// 要检验的实体
      /// 要检查更改的状态
      public static void CommitCHAT_RECORDChanges(DataSetCHAT_RECORD entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cbd))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cdb))
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public static void CommitCHAT_RECORDChanges(DataSetCHAT_RECORD entity,ArrayList alUpdateColumn,ArrayList alUpdateControl,IDataBaseOperate cdb =null)
      {
      if(cdb==null)
      {
      using( var cbd = GenerateFactory.GenerateConnect())
      {
      using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cbd))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }
      else
      {
      using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cdb))
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }
      }

      ///生成查询静态函数
      ///
      
        public static DataSetCHAT_RECORD GetCHAT_RECORD_SelectByIDCHAT_RECORD(System.String VID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cbd))
        {
        return dao.Data_CHAT_RECORD_SelectByIDCHAT_RECORD(VID );
        }
        }
        }
        else
        {
        using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cdb))
        {
        return dao.Data_CHAT_RECORD_SelectByIDCHAT_RECORD(VID );
        }
        }
        }
      
        public static DataSetCHAT_RECORD GetCHAT_RECORD_SelectAll(
          string sTj ,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cbd))
        {
        return dao.Data_CHAT_RECORD_SelectAll(
          sTj  );
        }
        }
        }
        else
        {
        using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cdb))
        {
        return dao.Data_CHAT_RECORD_SelectAll(
          sTj  );
        }
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public static int UpdateCHAT_RECORD_DeleteCHAT_RECORD(System.String VID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cbd))
        {
        return dao.Data_CHAT_RECORD_DeleteCHAT_RECORD(VID);
        }
        }
        }
        else
        {
        using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cdb))
        {
        return dao.Data_CHAT_RECORD_DeleteCHAT_RECORD(VID);
        }
        }
        }
      
        public static int UpdateCHAT_RECORD_UpdateCHAT_RECORD(System.DateTime DREAD , System.String VID , System.String VSID , System.String VRID , System.String VSNAME , System.String VRNAME , System.DateTime DCREATE , System.Byte[] CONTENT , System.String TYPE , System.Decimal NREAD , System.String OLDVID,IDataBaseOperate cdb =null)
        {
        if(cdb==null)
        {
        using( var cbd = GenerateFactory.GenerateConnect())
        {
        using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cbd))
        {
        return dao.Data_CHAT_RECORD_UpdateCHAT_RECORD(DREAD , VID , VSID , VRID , VSNAME , VRNAME , DCREATE , CONTENT , TYPE , NREAD , OLDVID);
        }
        }
        }
        else
        {
        using(CHAT_RECORDBaseDAO dao = new CHAT_RECORDBaseDAO(cdb))
        {
        return dao.Data_CHAT_RECORD_UpdateCHAT_RECORD(DREAD , VID , VSID , VRID , VSNAME , VRNAME , DCREATE , CONTENT , TYPE , NREAD , OLDVID);
        }
        }
        }
      
      #endregion
    
    }
    }
  