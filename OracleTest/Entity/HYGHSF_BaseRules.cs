
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
    using HYGHSF.Entity;
    using HYGHSF.DAO;
    using System.Collections;

    namespace HYGHSF.Rules
    {
    /// 
      /// 对于HYGHSFBaseRules 的类的实现（基础业务规则部分）。
      /// 对于扩展部分的Rules的实现可以从这个类继承。
      ///
    
    public class HYGHSFBaseRules : MarshalByRefObject,IDisposable
    {
    public void Dispose()
    {
    GC.Collect();
    }

    
      #region The base rules of GHSF_PATIENTINFO.
      /*实体GHSF_PATIENTINFO的基本规则*/
      /// 
        /// 插入GHSF_PATIENTINFO实体。
        ///
      
      /// GHSF_PATIENTINFO实体
      
      public void InsertGHSF_PATIENTINFO(DataSetGHSF_PATIENTINFO entity)
      {
      using(GHSF_PATIENTINFOBaseDAO dao = new GHSF_PATIENTINFOBaseDAO())
      {
      dao.InsertEntity(entity);
      }
      }

      /// 
        /// 删除GHSF_PATIENTINFO实体。
        ///
      
      /// GHSF_PATIENTINFO实体
      
      public void DeleteGHSF_PATIENTINFO(DataSetGHSF_PATIENTINFO entity)
      {
      using(GHSF_PATIENTINFOBaseDAO dao = new GHSF_PATIENTINFOBaseDAO())
      {
      dao.DeleteEntity(entity);
      }
      }

      /// 
        /// 更新GHSF_PATIENTINFO实体。
        ///
      
      /// GHSF_PATIENTINFO实体
      
      public void UpdateGHSF_PATIENTINFO(DataSetGHSF_PATIENTINFO entity)
      {
      using(GHSF_PATIENTINFOBaseDAO dao = new GHSF_PATIENTINFOBaseDAO())
      {
      dao.UpdateEntity(entity);
      }
      }

      
      /// 
        /// 通过给定的主键值查询GHSF_PATIENTINFO实体。
        ///
      
      /// 主键id的值
      public DataSetGHSF_PATIENTINFO GetGHSF_PATIENTINFOByID(System.String id)
      {
      DataSetGHSF_PATIENTINFO entity;
      using(GHSF_PATIENTINFOBaseDAO dao = new GHSF_PATIENTINFOBaseDAO())
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
      public void CommitGHSF_PATIENTINFOChanges(DataSetGHSF_PATIENTINFO entity, DataRowState drs)
      {
      using(GHSF_PATIENTINFOBaseDAO dao = new GHSF_PATIENTINFOBaseDAO())
      {
      dao.CommitChanges(entity, drs);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitGHSF_PATIENTINFOChanges(DataSetGHSF_PATIENTINFO entity)
      {
      using(GHSF_PATIENTINFOBaseDAO dao = new GHSF_PATIENTINFOBaseDAO())
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
      public void CommitGHSF_PATIENTINFOChanges(DataSetGHSF_PATIENTINFO entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(GHSF_PATIENTINFOBaseDAO dao = new GHSF_PATIENTINFOBaseDAO())
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitGHSF_PATIENTINFOChanges(DataSetGHSF_PATIENTINFO entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(GHSF_PATIENTINFOBaseDAO dao = new GHSF_PATIENTINFOBaseDAO())
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }

      ///生成查询静态函数
      ///
      
        public DataSetGHSF_PATIENTINFO GetGHSF_PATIENTINFO_SelectByIDGHSF_GHSF_PATIENTINFO(System.String VPATIENTID)
        {
        using(GHSF_PATIENTINFOBaseDAO dao = new GHSF_PATIENTINFOBaseDAO())
        {
        return dao.Data_GHSF_PATIENTINFO_SelectByIDGHSF_GHSF_PATIENTINFO(VPATIENTID );
        }
        }
      
        public DataSetGHSF_PATIENTINFO GetGHSF_PATIENTINFO_SelectAll(
          string sTj )
        {
        using(GHSF_PATIENTINFOBaseDAO dao = new GHSF_PATIENTINFOBaseDAO())
        {
        return dao.Data_GHSF_PATIENTINFO_SelectAll(
          sTj  );
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public int UpdateGHSF_PATIENTINFO_DeleteGHSF_GHSF_PATIENTINFO(System.String VPATIENTID)
        {
        using(GHSF_PATIENTINFOBaseDAO dao = new GHSF_PATIENTINFOBaseDAO())
        {
        return dao.Data_GHSF_PATIENTINFO_DeleteGHSF_GHSF_PATIENTINFO(VPATIENTID);
        }
        }
      
        public int UpdateGHSF_PATIENTINFO_UpdateGHSF_GHSF_PATIENTINFO(System.String VPATIENTID , System.DateTime DCREATEDATE , System.String VNAME , System.String PINYINMA , System.String WUBIMA , System.Decimal NSEX , System.DateTime DBIRTHDATE , System.String VBIRTHPLACE , System.String VBIRTHPLACEDETAIL , System.String VNATION , System.String VNATIONNAME , System.String VIDTYPE , System.String VIDNO , System.String VUNITINCONTRACT , System.String VUNITINCONTRACTNAME , System.String VMAILINGADDRESS , System.String VZIPID , System.String VPHONENUMBERHOME , System.String VPHONENUMBERBUSINESS , System.String VLINKMAN , System.String VRELATIONSHIP , System.String VNEXTOFKINADDR , System.String VNEXTOFKINZIPID , System.String VPHONE , System.DateTime DLASTVISITDATE , System.Decimal NVIPINDICATOR , System.String VOPERATORID , System.String VDEGREE , System.String VRACE , System.String VRELIGION , System.String VMOTHERLANGUAGE , System.String VFOREIGNLANGUAGE , System.String VVIPNO , System.String VENGLISHNAME , System.String VREMARKS , System.Decimal NCOUNTRY , System.Decimal NPROVINCES , System.Decimal NCITY , System.Decimal NSTREET , System.Decimal NPROFESSIONID , System.String NIDENTITY , System.String VPRESENTADDRESS , System.String VISITNO , System.Decimal NMARRY , System.String VORGAN , System.Decimal NDICAREAID , System.String VDIAGNOSE , System.Decimal NDISEASEID , System.Decimal NZYZEXZ , System.Decimal NZYYPXZ , System.String OLDVPATIENTID)
        {
        using(GHSF_PATIENTINFOBaseDAO dao = new GHSF_PATIENTINFOBaseDAO())
        {
        return dao.Data_GHSF_PATIENTINFO_UpdateGHSF_GHSF_PATIENTINFO(VPATIENTID , DCREATEDATE , VNAME , PINYINMA , WUBIMA , NSEX , DBIRTHDATE , VBIRTHPLACE , VBIRTHPLACEDETAIL , VNATION , VNATIONNAME , VIDTYPE , VIDNO , VUNITINCONTRACT , VUNITINCONTRACTNAME , VMAILINGADDRESS , VZIPID , VPHONENUMBERHOME , VPHONENUMBERBUSINESS , VLINKMAN , VRELATIONSHIP , VNEXTOFKINADDR , VNEXTOFKINZIPID , VPHONE , DLASTVISITDATE , NVIPINDICATOR , VOPERATORID , VDEGREE , VRACE , VRELIGION , VMOTHERLANGUAGE , VFOREIGNLANGUAGE , VVIPNO , VENGLISHNAME , VREMARKS , NCOUNTRY , NPROVINCES , NCITY , NSTREET , NPROFESSIONID , NIDENTITY , VPRESENTADDRESS , VISITNO , NMARRY , VORGAN , NDICAREAID , VDIAGNOSE , NDISEASEID , NZYZEXZ , NZYYPXZ , OLDVPATIENTID);
        }
        }
      
      #endregion
    
      #region The base rules of GHSF_REGHIS.
      /*实体GHSF_REGHIS的基本规则*/
      /// 
        /// 插入GHSF_REGHIS实体。
        ///
      
      /// GHSF_REGHIS实体
      
      public void InsertGHSF_REGHIS(DataSetGHSF_REGHIS entity)
      {
      using(GHSF_REGHISBaseDAO dao = new GHSF_REGHISBaseDAO())
      {
      dao.InsertEntity(entity);
      }
      }

      /// 
        /// 删除GHSF_REGHIS实体。
        ///
      
      /// GHSF_REGHIS实体
      
      public void DeleteGHSF_REGHIS(DataSetGHSF_REGHIS entity)
      {
      using(GHSF_REGHISBaseDAO dao = new GHSF_REGHISBaseDAO())
      {
      dao.DeleteEntity(entity);
      }
      }

      /// 
        /// 更新GHSF_REGHIS实体。
        ///
      
      /// GHSF_REGHIS实体
      
      public void UpdateGHSF_REGHIS(DataSetGHSF_REGHIS entity)
      {
      using(GHSF_REGHISBaseDAO dao = new GHSF_REGHISBaseDAO())
      {
      dao.UpdateEntity(entity);
      }
      }

      
      /// 
        /// 通过给定的主键值查询GHSF_REGHIS实体。
        ///
      
      /// 主键id的值
      public DataSetGHSF_REGHIS GetGHSF_REGHISByID(System.String id)
      {
      DataSetGHSF_REGHIS entity;
      using(GHSF_REGHISBaseDAO dao = new GHSF_REGHISBaseDAO())
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
      public void CommitGHSF_REGHISChanges(DataSetGHSF_REGHIS entity, DataRowState drs)
      {
      using(GHSF_REGHISBaseDAO dao = new GHSF_REGHISBaseDAO())
      {
      dao.CommitChanges(entity, drs);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitGHSF_REGHISChanges(DataSetGHSF_REGHIS entity)
      {
      using(GHSF_REGHISBaseDAO dao = new GHSF_REGHISBaseDAO())
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
      public void CommitGHSF_REGHISChanges(DataSetGHSF_REGHIS entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(GHSF_REGHISBaseDAO dao = new GHSF_REGHISBaseDAO())
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitGHSF_REGHISChanges(DataSetGHSF_REGHIS entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(GHSF_REGHISBaseDAO dao = new GHSF_REGHISBaseDAO())
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }

      ///生成查询静态函数
      ///
      
        public DataSetGHSF_REGHIS GetGHSF_REGHIS_SelectByIDGHSF_GHSF_REGHIS(System.String VCLINICNO)
        {
        using(GHSF_REGHISBaseDAO dao = new GHSF_REGHISBaseDAO())
        {
        return dao.Data_GHSF_REGHIS_SelectByIDGHSF_GHSF_REGHIS(VCLINICNO );
        }
        }
      
        public DataSetGHSF_REGHIS GetGHSF_REGHIS_SelectAll(
          string sTj )
        {
        using(GHSF_REGHISBaseDAO dao = new GHSF_REGHISBaseDAO())
        {
        return dao.Data_GHSF_REGHIS_SelectAll(
          sTj  );
        }
        }
      

      ///生成存储过程

      
        public System.String GetGHSF_REGHIS_GHSF_FUN_GETVCLINICNOMZ(System.String MPREFIX)
        {
        using(GHSF_REGHISBaseDAO dao = new GHSF_REGHISBaseDAO())
        {
        return dao.Data_GHSF_REGHIS_GHSF_FUN_GETVCLINICNOMZ(MPREFIX);
        }
        }
      

      ///生成更新函数

      
        public int UpdateGHSF_REGHIS_DeleteGHSF_GHSF_REGHIS(System.String VCLINICNO)
        {
        using(GHSF_REGHISBaseDAO dao = new GHSF_REGHISBaseDAO())
        {
        return dao.Data_GHSF_REGHIS_DeleteGHSF_GHSF_REGHIS(VCLINICNO);
        }
        }
      
        public int UpdateGHSF_REGHIS_UpdateGHSF_GHSF_REGHIS(System.String VCLINICNO , System.DateTime DVISITDATE , System.Decimal NVISITNO , System.String VAPPTIME , System.String VPATIENTID , System.String VNAME , System.String PINYINMA , System.String WUBIMA , System.Decimal NSEX , System.String NAGE , System.DateTime DBIRTHDATE , System.String NIDENTITY , System.Decimal NCHARGETYPE , System.String VINSURANCETY , System.String VINSURANCEN , System.String VUNITINCONTRACT , System.Decimal NCLINICTYPE , System.Decimal NCFIRSTVISITIND , System.String VVISITDEPT , System.String VDOCTOR , System.Decimal NMRPROVIDEINDICATOR , System.Decimal NREGSTATUS , System.String VOPERATORID , System.DateTime DREGDATE , System.String VSYMPTOM , System.Decimal NREGISTFEE , System.Decimal NCLINICFEE , System.Decimal NOTHERFEE , System.Decimal NCLINICCHARG , System.DateTime DRETURNDATE , System.String VIDTYPE , System.String VIDNO , System.String VRETURNID , System.Decimal NMODEID , System.String VCARDNO , System.DateTime DACCTDATETI , System.String DACCTNO , System.Decimal NMRPROVIDEDINDICATOR , System.String VAPPOINTSID , System.String VREMARKS , System.String VNATION , System.String VNATIVEPLACE , System.String VPRESENTADDRESS , System.String VLINKMAN , System.String VPHONE , System.Decimal NKA , System.Decimal NPROFESSIONID , System.Decimal NDICGHTYPE , System.String VBSETCARD , System.String PERSONACCOUNTINFO , System.String YBGRBH , System.Decimal NCHARGE , System.Decimal NHOSID , System.String PURCHASINGPERSONNAME , System.String PURCHASINGPERSONVIDNO , System.String PURCHASINGPERSONVPHONE , System.String RELATIONSHIPWITHPATIENTS , System.String YBLX , System.Decimal NDICAREAID , System.String NHREGNO , System.String BCJSFF , System.String NHLYZT , System.Decimal JSDISEASE , System.String VFIRST_VISITDEPT , System.String VFIRST_DOCTOR , System.String OLDVCLINICNO)
        {
        using(GHSF_REGHISBaseDAO dao = new GHSF_REGHISBaseDAO())
        {
        return dao.Data_GHSF_REGHIS_UpdateGHSF_GHSF_REGHIS(VCLINICNO , DVISITDATE , NVISITNO , VAPPTIME , VPATIENTID , VNAME , PINYINMA , WUBIMA , NSEX , NAGE , DBIRTHDATE , NIDENTITY , NCHARGETYPE , VINSURANCETY , VINSURANCEN , VUNITINCONTRACT , NCLINICTYPE , NCFIRSTVISITIND , VVISITDEPT , VDOCTOR , NMRPROVIDEINDICATOR , NREGSTATUS , VOPERATORID , DREGDATE , VSYMPTOM , NREGISTFEE , NCLINICFEE , NOTHERFEE , NCLINICCHARG , DRETURNDATE , VIDTYPE , VIDNO , VRETURNID , NMODEID , VCARDNO , DACCTDATETI , DACCTNO , NMRPROVIDEDINDICATOR , VAPPOINTSID , VREMARKS , VNATION , VNATIVEPLACE , VPRESENTADDRESS , VLINKMAN , VPHONE , NKA , NPROFESSIONID , NDICGHTYPE , VBSETCARD , PERSONACCOUNTINFO , YBGRBH , NCHARGE , NHOSID , PURCHASINGPERSONNAME , PURCHASINGPERSONVIDNO , PURCHASINGPERSONVPHONE , RELATIONSHIPWITHPATIENTS , YBLX , NDICAREAID , NHREGNO , BCJSFF , NHLYZT , JSDISEASE , VFIRST_VISITDEPT , VFIRST_DOCTOR , OLDVCLINICNO);
        }
        }
      
      #endregion
    
      #region The base rules of GHSF_JZ.
      /*实体GHSF_JZ的基本规则*/
      /// 
        /// 插入GHSF_JZ实体。
        ///
      
      /// GHSF_JZ实体
      
      public void InsertGHSF_JZ(DataSetGHSF_JZ entity)
      {
      using(GHSF_JZBaseDAO dao = new GHSF_JZBaseDAO())
      {
      dao.InsertEntity(entity);
      }
      }

      /// 
        /// 删除GHSF_JZ实体。
        ///
      
      /// GHSF_JZ实体
      
      public void DeleteGHSF_JZ(DataSetGHSF_JZ entity)
      {
      using(GHSF_JZBaseDAO dao = new GHSF_JZBaseDAO())
      {
      dao.DeleteEntity(entity);
      }
      }

      /// 
        /// 更新GHSF_JZ实体。
        ///
      
      /// GHSF_JZ实体
      
      public void UpdateGHSF_JZ(DataSetGHSF_JZ entity)
      {
      using(GHSF_JZBaseDAO dao = new GHSF_JZBaseDAO())
      {
      dao.UpdateEntity(entity);
      }
      }

      
      /// 
        /// 通过给定的主键值查询GHSF_JZ实体。
        ///
      
      /// 主键id的值
      public DataSetGHSF_JZ GetGHSF_JZByID(System.String id)
      {
      DataSetGHSF_JZ entity;
      using(GHSF_JZBaseDAO dao = new GHSF_JZBaseDAO())
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
      public void CommitGHSF_JZChanges(DataSetGHSF_JZ entity, DataRowState drs)
      {
      using(GHSF_JZBaseDAO dao = new GHSF_JZBaseDAO())
      {
      dao.CommitChanges(entity, drs);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitGHSF_JZChanges(DataSetGHSF_JZ entity)
      {
      using(GHSF_JZBaseDAO dao = new GHSF_JZBaseDAO())
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
      public void CommitGHSF_JZChanges(DataSetGHSF_JZ entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(GHSF_JZBaseDAO dao = new GHSF_JZBaseDAO())
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitGHSF_JZChanges(DataSetGHSF_JZ entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(GHSF_JZBaseDAO dao = new GHSF_JZBaseDAO())
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }

      ///生成查询静态函数
      ///
      
        public DataSetGHSF_JZ GetGHSF_JZ_SelectByIDGHSF_GHSF_JZ(System.String VACCOUNTSID)
        {
        using(GHSF_JZBaseDAO dao = new GHSF_JZBaseDAO())
        {
        return dao.Data_GHSF_JZ_SelectByIDGHSF_GHSF_JZ(VACCOUNTSID );
        }
        }
      
        public DataSetGHSF_JZ GetGHSF_JZ_SelectAll(
          string sTj )
        {
        using(GHSF_JZBaseDAO dao = new GHSF_JZBaseDAO())
        {
        return dao.Data_GHSF_JZ_SelectAll(
          sTj  );
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public int UpdateGHSF_JZ_DeleteGHSF_GHSF_JZ(System.String VACCOUNTSID)
        {
        using(GHSF_JZBaseDAO dao = new GHSF_JZBaseDAO())
        {
        return dao.Data_GHSF_JZ_DeleteGHSF_GHSF_JZ(VACCOUNTSID);
        }
        }
      
        public int UpdateGHSF_JZ_UpdateGHSF_GHSF_JZ(System.String VACCOUNTSID , System.String VRCPTID , System.String VPRESCNO , System.String VITEMID , System.String VITEMNAME , System.Decimal NPRICE , System.Decimal NCOSTS , System.Decimal NACCOUNTSCOSTS , System.Decimal NCHARGEFLAG , System.DateTime DMEDICINEDATE , System.String VOPERATORID , System.Decimal NSETTLE , System.DateTime DSETTLEDATE , System.String VSETTLEID , System.String VCARDNO , System.Decimal NACCOUNT , System.String VINVOICENO , System.String NFLAG , System.String VVISITDEPT , System.String VREMARKS , System.String VPATIENTID , System.Decimal NACCT_MODE , System.String VCOUNTDEPT , System.String VDOCTOR_ID , System.String VACCTID , System.Decimal NACCOUNTTF , System.String VACCOUNTSIDTF , System.Decimal NOPHZID , System.String VCLINICNO , System.Decimal NHOSID , System.String OLDVACCOUNTSID)
        {
        using(GHSF_JZBaseDAO dao = new GHSF_JZBaseDAO())
        {
        return dao.Data_GHSF_JZ_UpdateGHSF_GHSF_JZ(VACCOUNTSID , VRCPTID , VPRESCNO , VITEMID , VITEMNAME , NPRICE , NCOSTS , NACCOUNTSCOSTS , NCHARGEFLAG , DMEDICINEDATE , VOPERATORID , NSETTLE , DSETTLEDATE , VSETTLEID , VCARDNO , NACCOUNT , VINVOICENO , NFLAG , VVISITDEPT , VREMARKS , VPATIENTID , NACCT_MODE , VCOUNTDEPT , VDOCTOR_ID , VACCTID , NACCOUNTTF , VACCOUNTSIDTF , NOPHZID , VCLINICNO , NHOSID , OLDVACCOUNTSID);
        }
        }
      
      #endregion
    
      #region The base rules of GHSF_REGPLAN.
      /*实体GHSF_REGPLAN的基本规则*/
      /// 
        /// 插入GHSF_REGPLAN实体。
        ///
      
      /// GHSF_REGPLAN实体
      
      public void InsertGHSF_REGPLAN(DataSetGHSF_REGPLAN entity)
      {
      using(GHSF_REGPLANBaseDAO dao = new GHSF_REGPLANBaseDAO())
      {
      dao.InsertEntity(entity);
      }
      }

      /// 
        /// 删除GHSF_REGPLAN实体。
        ///
      
      /// GHSF_REGPLAN实体
      
      public void DeleteGHSF_REGPLAN(DataSetGHSF_REGPLAN entity)
      {
      using(GHSF_REGPLANBaseDAO dao = new GHSF_REGPLANBaseDAO())
      {
      dao.DeleteEntity(entity);
      }
      }

      /// 
        /// 更新GHSF_REGPLAN实体。
        ///
      
      /// GHSF_REGPLAN实体
      
      public void UpdateGHSF_REGPLAN(DataSetGHSF_REGPLAN entity)
      {
      using(GHSF_REGPLANBaseDAO dao = new GHSF_REGPLANBaseDAO())
      {
      dao.UpdateEntity(entity);
      }
      }

      
      /// 
        /// 通过给定的主键值查询GHSF_REGPLAN实体。
        ///
      
      /// 主键id的值
      public DataSetGHSF_REGPLAN GetGHSF_REGPLANByID(System.String id)
      {
      DataSetGHSF_REGPLAN entity;
      using(GHSF_REGPLANBaseDAO dao = new GHSF_REGPLANBaseDAO())
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
      public void CommitGHSF_REGPLANChanges(DataSetGHSF_REGPLAN entity, DataRowState drs)
      {
      using(GHSF_REGPLANBaseDAO dao = new GHSF_REGPLANBaseDAO())
      {
      dao.CommitChanges(entity, drs);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitGHSF_REGPLANChanges(DataSetGHSF_REGPLAN entity)
      {
      using(GHSF_REGPLANBaseDAO dao = new GHSF_REGPLANBaseDAO())
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
      public void CommitGHSF_REGPLANChanges(DataSetGHSF_REGPLAN entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(GHSF_REGPLANBaseDAO dao = new GHSF_REGPLANBaseDAO())
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitGHSF_REGPLANChanges(DataSetGHSF_REGPLAN entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(GHSF_REGPLANBaseDAO dao = new GHSF_REGPLANBaseDAO())
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }

      ///生成查询静态函数
      ///
      
        public DataSetGHSF_REGPLAN GetGHSF_REGPLAN_SelectByIDGHSF_GHSF_REGPLAN(System.String VPLANID)
        {
        using(GHSF_REGPLANBaseDAO dao = new GHSF_REGPLANBaseDAO())
        {
        return dao.Data_GHSF_REGPLAN_SelectByIDGHSF_GHSF_REGPLAN(VPLANID );
        }
        }
      
        public DataSetGHSF_REGPLAN GetGHSF_REGPLAN_SelectAll(
          string sTj )
        {
        using(GHSF_REGPLANBaseDAO dao = new GHSF_REGPLANBaseDAO())
        {
        return dao.Data_GHSF_REGPLAN_SelectAll(
          sTj  );
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public int UpdateGHSF_REGPLAN_DeleteGHSF_GHSF_REGPLAN(System.String VPLANID)
        {
        using(GHSF_REGPLANBaseDAO dao = new GHSF_REGPLANBaseDAO())
        {
        return dao.Data_GHSF_REGPLAN_DeleteGHSF_GHSF_REGPLAN(VPLANID);
        }
        }
      
        public int UpdateGHSF_REGPLAN_UpdateGHSF_GHSF_REGPLAN(System.String VPLANID , System.String VDOCTORID , System.Decimal NTIMEDESC , System.Decimal NREGLIMITS , System.Decimal NAPPLIMITS , System.Decimal NREGNUMBER , System.Decimal NAPPNUMBER , System.Decimal NREGPRICE , System.String VOPERATORID , System.DateTime DCREATEDATE , System.String VREMARKS , System.DateTime DCLINICDATE , System.String VDEPTID , System.Decimal NHOSID , System.String OLDVPLANID)
        {
        using(GHSF_REGPLANBaseDAO dao = new GHSF_REGPLANBaseDAO())
        {
        return dao.Data_GHSF_REGPLAN_UpdateGHSF_GHSF_REGPLAN(VPLANID , VDOCTORID , NTIMEDESC , NREGLIMITS , NAPPLIMITS , NREGNUMBER , NAPPNUMBER , NREGPRICE , VOPERATORID , DCREATEDATE , VREMARKS , DCLINICDATE , VDEPTID , NHOSID , OLDVPLANID);
        }
        }
      
      #endregion
    
      #region The base rules of GHSF_CHARGEMAIN.
      /*实体GHSF_CHARGEMAIN的基本规则*/
      /// 
        /// 插入GHSF_CHARGEMAIN实体。
        ///
      
      /// GHSF_CHARGEMAIN实体
      
      public void InsertGHSF_CHARGEMAIN(DataSetGHSF_CHARGEMAIN entity)
      {
      using(GHSF_CHARGEMAINBaseDAO dao = new GHSF_CHARGEMAINBaseDAO())
      {
      dao.InsertEntity(entity);
      }
      }

      /// 
        /// 删除GHSF_CHARGEMAIN实体。
        ///
      
      /// GHSF_CHARGEMAIN实体
      
      public void DeleteGHSF_CHARGEMAIN(DataSetGHSF_CHARGEMAIN entity)
      {
      using(GHSF_CHARGEMAINBaseDAO dao = new GHSF_CHARGEMAINBaseDAO())
      {
      dao.DeleteEntity(entity);
      }
      }

      /// 
        /// 更新GHSF_CHARGEMAIN实体。
        ///
      
      /// GHSF_CHARGEMAIN实体
      
      public void UpdateGHSF_CHARGEMAIN(DataSetGHSF_CHARGEMAIN entity)
      {
      using(GHSF_CHARGEMAINBaseDAO dao = new GHSF_CHARGEMAINBaseDAO())
      {
      dao.UpdateEntity(entity);
      }
      }

      
      /// 
        /// 通过给定的主键值查询GHSF_CHARGEMAIN实体。
        ///
      
      /// 主键id的值
      public DataSetGHSF_CHARGEMAIN GetGHSF_CHARGEMAINByID(System.String id)
      {
      DataSetGHSF_CHARGEMAIN entity;
      using(GHSF_CHARGEMAINBaseDAO dao = new GHSF_CHARGEMAINBaseDAO())
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
      public void CommitGHSF_CHARGEMAINChanges(DataSetGHSF_CHARGEMAIN entity, DataRowState drs)
      {
      using(GHSF_CHARGEMAINBaseDAO dao = new GHSF_CHARGEMAINBaseDAO())
      {
      dao.CommitChanges(entity, drs);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitGHSF_CHARGEMAINChanges(DataSetGHSF_CHARGEMAIN entity)
      {
      using(GHSF_CHARGEMAINBaseDAO dao = new GHSF_CHARGEMAINBaseDAO())
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
      public void CommitGHSF_CHARGEMAINChanges(DataSetGHSF_CHARGEMAIN entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(GHSF_CHARGEMAINBaseDAO dao = new GHSF_CHARGEMAINBaseDAO())
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitGHSF_CHARGEMAINChanges(DataSetGHSF_CHARGEMAIN entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(GHSF_CHARGEMAINBaseDAO dao = new GHSF_CHARGEMAINBaseDAO())
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }

      ///生成查询静态函数
      ///
      
        public DataSetGHSF_CHARGEMAIN GetGHSF_CHARGEMAIN_SelectByIDGHSF_GHSF_CHARGEMAIN(System.String VRCPTID)
        {
        using(GHSF_CHARGEMAINBaseDAO dao = new GHSF_CHARGEMAINBaseDAO())
        {
        return dao.Data_GHSF_CHARGEMAIN_SelectByIDGHSF_GHSF_CHARGEMAIN(VRCPTID );
        }
        }
      
        public DataSetGHSF_CHARGEMAIN GetGHSF_CHARGEMAIN_SelectAll(
          string sTj )
        {
        using(GHSF_CHARGEMAINBaseDAO dao = new GHSF_CHARGEMAINBaseDAO())
        {
        return dao.Data_GHSF_CHARGEMAIN_SelectAll(
          sTj  );
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public int UpdateGHSF_CHARGEMAIN_DeleteGHSF_GHSF_CHARGEMAIN(System.String VRCPTID)
        {
        using(GHSF_CHARGEMAINBaseDAO dao = new GHSF_CHARGEMAINBaseDAO())
        {
        return dao.Data_GHSF_CHARGEMAIN_DeleteGHSF_GHSF_CHARGEMAIN(VRCPTID);
        }
        }
      
        public int UpdateGHSF_CHARGEMAIN_UpdateGHSF_GHSF_CHARGEMAIN(System.String VPRESC_TYPE , System.DateTime DPRESC_DATE , System.String VDEPT_CODE , System.String VACCTID , System.Decimal BBAIYAO , System.Decimal NHOSID , System.String VRCPTID , System.String VPATIENTID , System.String VREGIST_ID , System.String VPRESC_ID , System.String VDIAGNOSE , System.Decimal NCOUNT , System.String VUSERAGE , System.String VDOCTOR_ID , System.String VOPERATORID , System.String VREFUNDEDRCPTNO , System.String VACCTNO , System.String VPRINTEDOPERATORID , System.DateTime VPRINTEDDATE , System.String VPRINTEDRCPTNO , System.String VINVOICENO , System.Decimal NSETTLE , System.String VREMARKS , System.DateTime DCHARGE_DATE , System.String VDEPTID , System.Decimal NSTATUS , System.String OLDVRCPTID)
        {
        using(GHSF_CHARGEMAINBaseDAO dao = new GHSF_CHARGEMAINBaseDAO())
        {
        return dao.Data_GHSF_CHARGEMAIN_UpdateGHSF_GHSF_CHARGEMAIN(VPRESC_TYPE , DPRESC_DATE , VDEPT_CODE , VACCTID , BBAIYAO , NHOSID , VRCPTID , VPATIENTID , VREGIST_ID , VPRESC_ID , VDIAGNOSE , NCOUNT , VUSERAGE , VDOCTOR_ID , VOPERATORID , VREFUNDEDRCPTNO , VACCTNO , VPRINTEDOPERATORID , VPRINTEDDATE , VPRINTEDRCPTNO , VINVOICENO , NSETTLE , VREMARKS , DCHARGE_DATE , VDEPTID , NSTATUS , OLDVRCPTID);
        }
        }
      
      #endregion
    
      #region The base rules of GHSF_CHARGEDETAIL.
      /*实体GHSF_CHARGEDETAIL的基本规则*/
      /// 
        /// 插入GHSF_CHARGEDETAIL实体。
        ///
      
      /// GHSF_CHARGEDETAIL实体
      
      public void InsertGHSF_CHARGEDETAIL(DataSetGHSF_CHARGEDETAIL entity)
      {
      using(GHSF_CHARGEDETAILBaseDAO dao = new GHSF_CHARGEDETAILBaseDAO())
      {
      dao.InsertEntity(entity);
      }
      }

      /// 
        /// 删除GHSF_CHARGEDETAIL实体。
        ///
      
      /// GHSF_CHARGEDETAIL实体
      
      public void DeleteGHSF_CHARGEDETAIL(DataSetGHSF_CHARGEDETAIL entity)
      {
      using(GHSF_CHARGEDETAILBaseDAO dao = new GHSF_CHARGEDETAILBaseDAO())
      {
      dao.DeleteEntity(entity);
      }
      }

      /// 
        /// 更新GHSF_CHARGEDETAIL实体。
        ///
      
      /// GHSF_CHARGEDETAIL实体
      
      public void UpdateGHSF_CHARGEDETAIL(DataSetGHSF_CHARGEDETAIL entity)
      {
      using(GHSF_CHARGEDETAILBaseDAO dao = new GHSF_CHARGEDETAILBaseDAO())
      {
      dao.UpdateEntity(entity);
      }
      }

      
      /// 
        /// 通过给定的主键值查询GHSF_CHARGEDETAIL实体。
        ///
      
      /// 主键id的值
      public DataSetGHSF_CHARGEDETAIL GetGHSF_CHARGEDETAILByID(System.String id)
      {
      DataSetGHSF_CHARGEDETAIL entity;
      using(GHSF_CHARGEDETAILBaseDAO dao = new GHSF_CHARGEDETAILBaseDAO())
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
      public void CommitGHSF_CHARGEDETAILChanges(DataSetGHSF_CHARGEDETAIL entity, DataRowState drs)
      {
      using(GHSF_CHARGEDETAILBaseDAO dao = new GHSF_CHARGEDETAILBaseDAO())
      {
      dao.CommitChanges(entity, drs);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitGHSF_CHARGEDETAILChanges(DataSetGHSF_CHARGEDETAIL entity)
      {
      using(GHSF_CHARGEDETAILBaseDAO dao = new GHSF_CHARGEDETAILBaseDAO())
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
      public void CommitGHSF_CHARGEDETAILChanges(DataSetGHSF_CHARGEDETAIL entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(GHSF_CHARGEDETAILBaseDAO dao = new GHSF_CHARGEDETAILBaseDAO())
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitGHSF_CHARGEDETAILChanges(DataSetGHSF_CHARGEDETAIL entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(GHSF_CHARGEDETAILBaseDAO dao = new GHSF_CHARGEDETAILBaseDAO())
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }

      ///生成查询静态函数
      ///
      
        public DataSetGHSF_CHARGEDETAIL GetGHSF_CHARGEDETAIL_SelectByIDGHSF_GHSF_CHARGEDETAIL(System.String VRCPTDETAILID)
        {
        using(GHSF_CHARGEDETAILBaseDAO dao = new GHSF_CHARGEDETAILBaseDAO())
        {
        return dao.Data_GHSF_CHARGEDETAIL_SelectByIDGHSF_GHSF_CHARGEDETAIL(VRCPTDETAILID );
        }
        }
      
        public DataSetGHSF_CHARGEDETAIL GetGHSF_CHARGEDETAIL_SelectAll(
          string sTj )
        {
        using(GHSF_CHARGEDETAILBaseDAO dao = new GHSF_CHARGEDETAILBaseDAO())
        {
        return dao.Data_GHSF_CHARGEDETAIL_SelectAll(
          sTj  );
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public int UpdateGHSF_CHARGEDETAIL_DeleteGHSF_GHSF_CHARGEDETAIL(System.String VRCPTDETAILID)
        {
        using(GHSF_CHARGEDETAILBaseDAO dao = new GHSF_CHARGEDETAILBaseDAO())
        {
        return dao.Data_GHSF_CHARGEDETAIL_DeleteGHSF_GHSF_CHARGEDETAIL(VRCPTDETAILID);
        }
        }
      
        public int UpdateGHSF_CHARGEDETAIL_UpdateGHSF_GHSF_CHARGEDETAIL(System.String VRCPTDETAILID , System.String VRCPTID , System.String VPRESC_ID , System.String VITEM_CODE , System.String VITEM_NAME , System.String VITEM_SPEC , System.String VUNITS , System.Decimal NACCOUNT , System.Decimal NDOSAGE , System.String VDOSAGE_UNITS , System.String VADMINISTRATION , System.String VFREQUENCY , System.Decimal NDAYS , System.Decimal NPRICE , System.Decimal NCOSTS , System.String VITEM_PRODUCT , System.Decimal NSALESCALE , System.Decimal NCHARGEFLAG , System.Decimal NMEDICINEFLAG , System.DateTime DMEDICINEDATE , System.Decimal NBACKDRUGFLAG , System.DateTime DBACKDRUGDATE , System.Decimal NHAVMED , System.String VREMARKS , System.Decimal NACCT_MODE1 , System.Decimal NACCT_MODE2 , System.Decimal NACCT_MONEY1 , System.Decimal NACCT_MONEY2 , System.String VPRINTEDRCPTNO , System.String VDRUG_STORAGE , System.Decimal NTOTALCHARGES , System.String VITEM_TYPE , System.Decimal NPRESC , System.Decimal NCOUNT , System.Decimal VISSELF , System.String VDEPT_CODE , System.String NDICTDETAIL_ID , System.String OLDVRCPTDETAILID)
        {
        using(GHSF_CHARGEDETAILBaseDAO dao = new GHSF_CHARGEDETAILBaseDAO())
        {
        return dao.Data_GHSF_CHARGEDETAIL_UpdateGHSF_GHSF_CHARGEDETAIL(VRCPTDETAILID , VRCPTID , VPRESC_ID , VITEM_CODE , VITEM_NAME , VITEM_SPEC , VUNITS , NACCOUNT , NDOSAGE , VDOSAGE_UNITS , VADMINISTRATION , VFREQUENCY , NDAYS , NPRICE , NCOSTS , VITEM_PRODUCT , NSALESCALE , NCHARGEFLAG , NMEDICINEFLAG , DMEDICINEDATE , NBACKDRUGFLAG , DBACKDRUGDATE , NHAVMED , VREMARKS , NACCT_MODE1 , NACCT_MODE2 , NACCT_MONEY1 , NACCT_MONEY2 , VPRINTEDRCPTNO , VDRUG_STORAGE , NTOTALCHARGES , VITEM_TYPE , NPRESC , NCOUNT , VISSELF , VDEPT_CODE , NDICTDETAIL_ID , OLDVRCPTDETAILID);
        }
        }
      
      #endregion
    
      #region The base rules of GHSF_NOTEMANAGE.
      /*实体GHSF_NOTEMANAGE的基本规则*/
      /// 
        /// 插入GHSF_NOTEMANAGE实体。
        ///
      
      /// GHSF_NOTEMANAGE实体
      
      public void InsertGHSF_NOTEMANAGE(DataSetGHSF_NOTEMANAGE entity)
      {
      using(GHSF_NOTEMANAGEBaseDAO dao = new GHSF_NOTEMANAGEBaseDAO())
      {
      dao.InsertEntity(entity);
      }
      }

      /// 
        /// 删除GHSF_NOTEMANAGE实体。
        ///
      
      /// GHSF_NOTEMANAGE实体
      
      public void DeleteGHSF_NOTEMANAGE(DataSetGHSF_NOTEMANAGE entity)
      {
      using(GHSF_NOTEMANAGEBaseDAO dao = new GHSF_NOTEMANAGEBaseDAO())
      {
      dao.DeleteEntity(entity);
      }
      }

      /// 
        /// 更新GHSF_NOTEMANAGE实体。
        ///
      
      /// GHSF_NOTEMANAGE实体
      
      public void UpdateGHSF_NOTEMANAGE(DataSetGHSF_NOTEMANAGE entity)
      {
      using(GHSF_NOTEMANAGEBaseDAO dao = new GHSF_NOTEMANAGEBaseDAO())
      {
      dao.UpdateEntity(entity);
      }
      }

      
      /// 
        /// 通过给定的主键值查询GHSF_NOTEMANAGE实体。
        ///
      
      /// 主键id的值
      public DataSetGHSF_NOTEMANAGE GetGHSF_NOTEMANAGEByID(System.String id)
      {
      DataSetGHSF_NOTEMANAGE entity;
      using(GHSF_NOTEMANAGEBaseDAO dao = new GHSF_NOTEMANAGEBaseDAO())
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
      public void CommitGHSF_NOTEMANAGEChanges(DataSetGHSF_NOTEMANAGE entity, DataRowState drs)
      {
      using(GHSF_NOTEMANAGEBaseDAO dao = new GHSF_NOTEMANAGEBaseDAO())
      {
      dao.CommitChanges(entity, drs);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitGHSF_NOTEMANAGEChanges(DataSetGHSF_NOTEMANAGE entity)
      {
      using(GHSF_NOTEMANAGEBaseDAO dao = new GHSF_NOTEMANAGEBaseDAO())
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
      public void CommitGHSF_NOTEMANAGEChanges(DataSetGHSF_NOTEMANAGE entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(GHSF_NOTEMANAGEBaseDAO dao = new GHSF_NOTEMANAGEBaseDAO())
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitGHSF_NOTEMANAGEChanges(DataSetGHSF_NOTEMANAGE entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(GHSF_NOTEMANAGEBaseDAO dao = new GHSF_NOTEMANAGEBaseDAO())
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }

      ///生成查询静态函数
      ///
      
        public DataSetGHSF_NOTEMANAGE GetGHSF_NOTEMANAGE_SelectByIDGHSF_GHSF_NOTEMANAGE(System.String VNOTEMANAGEID)
        {
        using(GHSF_NOTEMANAGEBaseDAO dao = new GHSF_NOTEMANAGEBaseDAO())
        {
        return dao.Data_GHSF_NOTEMANAGE_SelectByIDGHSF_GHSF_NOTEMANAGE(VNOTEMANAGEID );
        }
        }
      
        public DataSetGHSF_NOTEMANAGE GetGHSF_NOTEMANAGE_SelectAll(
          string sTj )
        {
        using(GHSF_NOTEMANAGEBaseDAO dao = new GHSF_NOTEMANAGEBaseDAO())
        {
        return dao.Data_GHSF_NOTEMANAGE_SelectAll(
          sTj  );
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public int UpdateGHSF_NOTEMANAGE_DeleteGHSF_GHSF_NOTEMANAGE(System.String VNOTEMANAGEID)
        {
        using(GHSF_NOTEMANAGEBaseDAO dao = new GHSF_NOTEMANAGEBaseDAO())
        {
        return dao.Data_GHSF_NOTEMANAGE_DeleteGHSF_GHSF_NOTEMANAGE(VNOTEMANAGEID);
        }
        }
      
        public int UpdateGHSF_NOTEMANAGE_UpdateGHSF_GHSF_NOTEMANAGE(System.String VNOTEMANAGEID , System.Decimal NPIAOJVLB , System.Decimal NQISHIH , System.Decimal NZHONGZHIH , System.Decimal NYISHIYH , System.String VLINGYONGR , System.String VJINGBANR , System.DateTime DLINGYONGRQ , System.String VREMARKS , System.String VOPERATORID , System.DateTime DOPERATORDATE , System.String OLDVNOTEMANAGEID)
        {
        using(GHSF_NOTEMANAGEBaseDAO dao = new GHSF_NOTEMANAGEBaseDAO())
        {
        return dao.Data_GHSF_NOTEMANAGE_UpdateGHSF_GHSF_NOTEMANAGE(VNOTEMANAGEID , NPIAOJVLB , NQISHIH , NZHONGZHIH , NYISHIYH , VLINGYONGR , VJINGBANR , DLINGYONGRQ , VREMARKS , VOPERATORID , DOPERATORDATE , OLDVNOTEMANAGEID);
        }
        }
      
      #endregion
    
      #region The base rules of XT_STAFF.
      /*实体XT_STAFF的基本规则*/
      /// 
        /// 插入XT_STAFF实体。
        ///
      
      /// XT_STAFF实体
      
      public void InsertXT_STAFF(DataSetXT_STAFF entity)
      {
      using(XT_STAFFBaseDAO dao = new XT_STAFFBaseDAO())
      {
      dao.InsertEntity(entity);
      }
      }

      /// 
        /// 删除XT_STAFF实体。
        ///
      
      /// XT_STAFF实体
      
      public void DeleteXT_STAFF(DataSetXT_STAFF entity)
      {
      using(XT_STAFFBaseDAO dao = new XT_STAFFBaseDAO())
      {
      dao.DeleteEntity(entity);
      }
      }

      /// 
        /// 更新XT_STAFF实体。
        ///
      
      /// XT_STAFF实体
      
      public void UpdateXT_STAFF(DataSetXT_STAFF entity)
      {
      using(XT_STAFFBaseDAO dao = new XT_STAFFBaseDAO())
      {
      dao.UpdateEntity(entity);
      }
      }

      
      /// 
        /// 通过给定的主键值查询XT_STAFF实体。
        ///
      
      /// 主键id的值
      public DataSetXT_STAFF GetXT_STAFFByID(System.String id)
      {
      DataSetXT_STAFF entity;
      using(XT_STAFFBaseDAO dao = new XT_STAFFBaseDAO())
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
      public void CommitXT_STAFFChanges(DataSetXT_STAFF entity, DataRowState drs)
      {
      using(XT_STAFFBaseDAO dao = new XT_STAFFBaseDAO())
      {
      dao.CommitChanges(entity, drs);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitXT_STAFFChanges(DataSetXT_STAFF entity)
      {
      using(XT_STAFFBaseDAO dao = new XT_STAFFBaseDAO())
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
      public void CommitXT_STAFFChanges(DataSetXT_STAFF entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(XT_STAFFBaseDAO dao = new XT_STAFFBaseDAO())
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitXT_STAFFChanges(DataSetXT_STAFF entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(XT_STAFFBaseDAO dao = new XT_STAFFBaseDAO())
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }

      ///生成查询静态函数
      ///
      
        public DataSetXT_STAFF GetXT_STAFF_SelectByIDXT_XT_STAFF(System.String VSTAFFCODE)
        {
        using(XT_STAFFBaseDAO dao = new XT_STAFFBaseDAO())
        {
        return dao.Data_XT_STAFF_SelectByIDXT_XT_STAFF(VSTAFFCODE );
        }
        }
      
        public DataSetXT_STAFF GetXT_STAFF_SelectAll(
          string sTj )
        {
        using(XT_STAFFBaseDAO dao = new XT_STAFFBaseDAO())
        {
        return dao.Data_XT_STAFF_SelectAll(
          sTj  );
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public int UpdateXT_STAFF_DeleteXT_XT_STAFF(System.String VSTAFFCODE)
        {
        using(XT_STAFFBaseDAO dao = new XT_STAFFBaseDAO())
        {
        return dao.Data_XT_STAFF_DeleteXT_XT_STAFF(VSTAFFCODE);
        }
        }
      
        public int UpdateXT_STAFF_UpdateXT_XT_STAFF(System.String VSTAFFCODE , System.String VSTAFFNAME , System.String PINYINMA , System.String WUBIMA , System.String VLOGINUSERNAME , System.String VLOGINPASSWORD , System.Decimal NSTAFFSTATUS , System.Decimal NROLEID , System.String VDEPARTCODE , System.Decimal NJOBID , System.Decimal NPROFESSIONID , System.Decimal NOPHZID , System.Decimal NISDUMA , System.DateTime DFHTIME , System.DateTime DTHTIME , System.String VTMETHOD , System.String VSCHOOL , System.Decimal NSEX , System.DateTime NBIRTHDAY , System.String VMINZU , System.String VJIGUAN , System.String VXUELI , System.Decimal NISKSS , System.Decimal NSENDMSG , System.Decimal NHOSID , System.String VYBNO , System.String VSXYS , System.String VSEALCODE , System.String INVOICE_KEY , System.String OLDVSTAFFCODE)
        {
        using(XT_STAFFBaseDAO dao = new XT_STAFFBaseDAO())
        {
        return dao.Data_XT_STAFF_UpdateXT_XT_STAFF(VSTAFFCODE , VSTAFFNAME , PINYINMA , WUBIMA , VLOGINUSERNAME , VLOGINPASSWORD , NSTAFFSTATUS , NROLEID , VDEPARTCODE , NJOBID , NPROFESSIONID , NOPHZID , NISDUMA , DFHTIME , DTHTIME , VTMETHOD , VSCHOOL , NSEX , NBIRTHDAY , VMINZU , VJIGUAN , VXUELI , NISKSS , NSENDMSG , NHOSID , VYBNO , VSXYS , VSEALCODE , INVOICE_KEY , OLDVSTAFFCODE);
        }
        }
      
      #endregion
    
      #region The base rules of XT_DICDEPART.
      /*实体XT_DICDEPART的基本规则*/
      /// 
        /// 插入XT_DICDEPART实体。
        ///
      
      /// XT_DICDEPART实体
      
      public void InsertXT_DICDEPART(DataSetXT_DICDEPART entity)
      {
      using(XT_DICDEPARTBaseDAO dao = new XT_DICDEPARTBaseDAO())
      {
      dao.InsertEntity(entity);
      }
      }

      /// 
        /// 删除XT_DICDEPART实体。
        ///
      
      /// XT_DICDEPART实体
      
      public void DeleteXT_DICDEPART(DataSetXT_DICDEPART entity)
      {
      using(XT_DICDEPARTBaseDAO dao = new XT_DICDEPARTBaseDAO())
      {
      dao.DeleteEntity(entity);
      }
      }

      /// 
        /// 更新XT_DICDEPART实体。
        ///
      
      /// XT_DICDEPART实体
      
      public void UpdateXT_DICDEPART(DataSetXT_DICDEPART entity)
      {
      using(XT_DICDEPARTBaseDAO dao = new XT_DICDEPARTBaseDAO())
      {
      dao.UpdateEntity(entity);
      }
      }

      
      /// 
        /// 通过给定的主键值查询XT_DICDEPART实体。
        ///
      
      /// 主键id的值
      public DataSetXT_DICDEPART GetXT_DICDEPARTByID(System.String id)
      {
      DataSetXT_DICDEPART entity;
      using(XT_DICDEPARTBaseDAO dao = new XT_DICDEPARTBaseDAO())
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
      public void CommitXT_DICDEPARTChanges(DataSetXT_DICDEPART entity, DataRowState drs)
      {
      using(XT_DICDEPARTBaseDAO dao = new XT_DICDEPARTBaseDAO())
      {
      dao.CommitChanges(entity, drs);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitXT_DICDEPARTChanges(DataSetXT_DICDEPART entity)
      {
      using(XT_DICDEPARTBaseDAO dao = new XT_DICDEPARTBaseDAO())
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
      public void CommitXT_DICDEPARTChanges(DataSetXT_DICDEPART entity, DataRowState drs,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(XT_DICDEPARTBaseDAO dao = new XT_DICDEPARTBaseDAO())
      {
      dao.CommitChanges(entity, drs,alUpdateColumn,alUpdateControl);
      }
      }

      /// 
        /// 检查给定的实体是否有更改，如果有把更改的行提交到数据库。 注意：提交过程是按先提交Deleted的行，再提交Modified的行，最后提交Added的行。
        ///
      
      /// 要检验的实体
      public void CommitXT_DICDEPARTChanges(DataSetXT_DICDEPART entity,ArrayList alUpdateColumn,ArrayList alUpdateControl)
      {
      using(XT_DICDEPARTBaseDAO dao = new XT_DICDEPARTBaseDAO())
      {
      dao.CommitChanges(entity,alUpdateColumn,alUpdateControl);
      }
      }

      ///生成查询静态函数
      ///
      
        public DataSetXT_DICDEPART GetXT_DICDEPART_SelectByIDXT_XT_DICDEPART(System.String VDEPARTCODE)
        {
        using(XT_DICDEPARTBaseDAO dao = new XT_DICDEPARTBaseDAO())
        {
        return dao.Data_XT_DICDEPART_SelectByIDXT_XT_DICDEPART(VDEPARTCODE );
        }
        }
      
        public DataSetXT_DICDEPART GetXT_DICDEPART_SelectAll(
          string sTj )
        {
        using(XT_DICDEPARTBaseDAO dao = new XT_DICDEPARTBaseDAO())
        {
        return dao.Data_XT_DICDEPART_SelectAll(
          sTj  );
        }
        }
      

      ///生成存储过程

      

      ///生成更新函数

      
        public int UpdateXT_DICDEPART_DeleteXT_XT_DICDEPART(System.String VDEPARTCODE)
        {
        using(XT_DICDEPARTBaseDAO dao = new XT_DICDEPARTBaseDAO())
        {
        return dao.Data_XT_DICDEPART_DeleteXT_XT_DICDEPART(VDEPARTCODE);
        }
        }
      
        public int UpdateXT_DICDEPART_UpdateXT_XT_DICDEPART(System.Decimal VHOSDISTRICTID , System.String VDEPARTCODE , System.String VDEPARTNAME , System.String VPARENTCODE , System.Decimal NDEPARTORDER , System.String PINYINMA , System.String WUBIMA , System.String VDEPARTADDRESS , System.Decimal NISDISABLED , System.Decimal NMESSAGE , System.Decimal NBEDNUM , System.Decimal NHOSID , System.Decimal NALLOWARREARS , System.Decimal ISZJKS , System.String VYBCODE , System.String VNHCODE , System.String NOPHZID , System.String VSTORAGEID , System.String OLDVDEPARTCODE)
        {
        using(XT_DICDEPARTBaseDAO dao = new XT_DICDEPARTBaseDAO())
        {
        return dao.Data_XT_DICDEPART_UpdateXT_XT_DICDEPART(VHOSDISTRICTID , VDEPARTCODE , VDEPARTNAME , VPARENTCODE , NDEPARTORDER , PINYINMA , WUBIMA , VDEPARTADDRESS , NISDISABLED , NMESSAGE , NBEDNUM , NHOSID , NALLOWARREARS , ISZJKS , VYBCODE , VNHCODE , NOPHZID , VSTORAGEID , OLDVDEPARTCODE);
        }
        }
      
      #endregion
    
    }
    }
  