//------------------------------------------------------------------------------
//     这部分代码属于实体定义层，是由实体编辑器工具自动产生的。
//     (Runtime Version: 2.2017.3.2)
//     对此代码进行的任何修改会导致其它的行为错误，并且重新生成时所有的修改会丢失。
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Xml;
using System.Runtime.Serialization;

namespace HYGHSF.Entity
{
	#region DataSetGHSF_REGHIS
	/// 
	/// 对于GHSF_REGHIS的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetGHSF_REGHIS : DataSet
    {
		
		private DataTableGHSF_GHSF_REGHIS tableGHSF_GHSF_REGHIS;
		
        public DataSetGHSF_REGHIS() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetGHSF_REGHIS实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetGHSF_REGHIS GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetGHSF_REGHIS dataSet = (DataSetGHSF_REGHIS)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetGHSF_REGHIS entity = new DataSetGHSF_REGHIS();
			entity.Relations.Clear();
			
			DataSet dataSet = this.GetChanges();
			foreach(DataTable dt in dataSet.Tables)
			{
				foreach(DataRow dr in dt.Rows)
				{
					if(dr.RowState == ds)
					{
						if(dr.RowState == DataRowState.Deleted)
							dr.RejectChanges();
						entity.Tables[dt.TableName].Rows.Add(dr.ItemArray);
						if(ds == DataRowState.Deleted)
							dr.Delete();
					}
				}
			}
			entity.AcceptChanges();
			return entity;
*/
			
			/*foreach(DataTable dt in this.Tables)
			{
				DataTable changeTable = dt.GetChanges(ds);
				if(changeTable != null)
				{
					entity.Tables.Remove(changeTable.TableName);
					entity.Tables.Add(changeTable.Copy());
				}
			}
			return entity;*/
		}
        
        protected DataSetGHSF_REGHIS(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["GHSF_GHSF_REGHIS"] != null)) 
                {
                    this.Tables.Add(new DataTableGHSF_GHSF_REGHIS(ds.Tables["GHSF_GHSF_REGHIS"]));
                }
				
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else
            {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		
		/// 
		/// 对于数据表GHSF_GHSF_REGHIS的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableGHSF_GHSF_REGHIS GHSF_GHSF_REGHIS 
		{
			get
			{
				return this.tableGHSF_GHSF_REGHIS;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetGHSF_REGHIS cln = ((DataSetGHSF_REGHIS)(base.Clone()));
			cln.InitVars();
			return cln;
		}
	    
		protected override bool ShouldSerializeTables() 
		{
			return false;
		}
	    
		protected override bool ShouldSerializeRelations() 
		{
			return false;
		}
	            
		protected override void ReadXmlSerializable(XmlReader reader) 
		{
			this.Reset();
			DataSet ds = new DataSet();
			ds.ReadXml(reader);
			
			if ((ds.Tables["GHSF_GHSF_REGHIS"] != null)) 
			{
				this.Tables.Add(new DataTableGHSF_GHSF_REGHIS(ds.Tables["GHSF_GHSF_REGHIS"]));
			}
			
			this.DataSetName = ds.DataSetName;
			this.Prefix = ds.Prefix;
			this.Namespace = ds.Namespace;
			this.Locale = ds.Locale;
			this.CaseSensitive = ds.CaseSensitive;
			this.EnforceConstraints = ds.EnforceConstraints;
			this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
			this.InitVars();
		}
	            
		protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() 
		{
			System.IO.MemoryStream stream = new System.IO.MemoryStream();
			this.WriteXmlSchema(new XmlTextWriter(stream, null));
			stream.Position = 0;
			return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
		}
	        
		internal void InitVars() 
		{
			
			this.tableGHSF_GHSF_REGHIS = ((DataTableGHSF_GHSF_REGHIS)(this.Tables["GHSF_GHSF_REGHIS"]));
			if ((this.tableGHSF_GHSF_REGHIS != null)) {
				this.tableGHSF_GHSF_REGHIS.InitVars();
			}
			
		}        
	    
		private void InitClass() 
		{
			this.DataSetName = "DeptDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.tempuri.org/DeptDataSet.xsd";
			this.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.CaseSensitive = false;
			this.EnforceConstraints = true;
			
			this.tableGHSF_GHSF_REGHIS = new DataTableGHSF_GHSF_REGHIS();
			this.Tables.Add(this.tableGHSF_GHSF_REGHIS);
			
		}
		
		private bool ShouldSerializeGHSF_GHSF_REGHIS() 
		{
			return false;
		}
		
		private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
			if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
				this.InitVars();
			}
		}
    }
	#endregion
	
	#region DataTable, DataRow Classes
	
    public delegate void RowChangeEventHandlerGHSF_GHSF_REGHIS(object sender, RowChangeEventGHSF_GHSF_REGHIS e);
	
	#region DataTableGHSF_GHSF_REGHIS
	/// 
	/// 对于数据表GHSF_GHSF_REGHIS的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableGHSF_GHSF_REGHIS : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVCLINICNO;
		
        private DataColumn columnDVISITDATE;
		
        private DataColumn columnNVISITNO;
		
        private DataColumn columnVAPPTIME;
		
        private DataColumn columnVPATIENTID;
		
        private DataColumn columnVNAME;
		
        private DataColumn columnPINYINMA;
		
        private DataColumn columnWUBIMA;
		
        private DataColumn columnNSEX;
		
        private DataColumn columnNAGE;
		
        private DataColumn columnDBIRTHDATE;
		
        private DataColumn columnNIDENTITY;
		
        private DataColumn columnNCHARGETYPE;
		
        private DataColumn columnVINSURANCETY;
		
        private DataColumn columnVINSURANCEN;
		
        private DataColumn columnVUNITINCONTRACT;
		
        private DataColumn columnNCLINICTYPE;
		
        private DataColumn columnNCFIRSTVISITIND;
		
        private DataColumn columnVVISITDEPT;
		
        private DataColumn columnVDOCTOR;
		
        private DataColumn columnNMRPROVIDEINDICATOR;
		
        private DataColumn columnNREGSTATUS;
		
        private DataColumn columnVOPERATORID;
		
        private DataColumn columnDREGDATE;
		
        private DataColumn columnVSYMPTOM;
		
        private DataColumn columnNREGISTFEE;
		
        private DataColumn columnNCLINICFEE;
		
        private DataColumn columnNOTHERFEE;
		
        private DataColumn columnNCLINICCHARG;
		
        private DataColumn columnDRETURNDATE;
		
        private DataColumn columnVIDTYPE;
		
        private DataColumn columnVIDNO;
		
        private DataColumn columnVRETURNID;
		
        private DataColumn columnNMODEID;
		
        private DataColumn columnVCARDNO;
		
        private DataColumn columnDACCTDATETI;
		
        private DataColumn columnDACCTNO;
		
        private DataColumn columnNMRPROVIDEDINDICATOR;
		
        private DataColumn columnVAPPOINTSID;
		
        private DataColumn columnVREMARKS;
		
        private DataColumn columnVNATION;
		
        private DataColumn columnVNATIVEPLACE;
		
        private DataColumn columnVPRESENTADDRESS;
		
        private DataColumn columnVLINKMAN;
		
        private DataColumn columnVPHONE;
		
        private DataColumn columnNKA;
		
        private DataColumn columnNPROFESSIONID;
		
        private DataColumn columnNDICGHTYPE;
		
        private DataColumn columnVBSETCARD;
		
        private DataColumn columnPERSONACCOUNTINFO;
		
        private DataColumn columnYBGRBH;
		
        private DataColumn columnNCHARGE;
		
        private DataColumn columnNHOSID;
		
        private DataColumn columnPURCHASINGPERSONNAME;
		
        private DataColumn columnPURCHASINGPERSONVIDNO;
		
        private DataColumn columnPURCHASINGPERSONVPHONE;
		
        private DataColumn columnRELATIONSHIPWITHPATIENTS;
		
        private DataColumn columnYBLX;
		
        private DataColumn columnNDICAREAID;
		
        private DataColumn columnNHREGNO;
		
        private DataColumn columnBCJSFF;
		
        private DataColumn columnNHLYZT;
		
        private DataColumn columnJSDISEASE;
		
        private DataColumn columnVFIRST_VISITDEPT;
		
        private DataColumn columnVFIRST_DOCTOR;
		
        internal DataTableGHSF_GHSF_REGHIS() : base("GHSF_GHSF_REGHIS") 
        {
            this.InitClass();
        }
        
        internal DataTableGHSF_GHSF_REGHIS(DataTable table) : base(table.TableName) 
        {
            if ((table.CaseSensitive != table.DataSet.CaseSensitive)) 
            {
                this.CaseSensitive = table.CaseSensitive;
            }
            if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) 
            {
                this.Locale = table.Locale;
            }
            if ((table.Namespace != table.DataSet.Namespace)) 
            {
                this.Namespace = table.Namespace;
            }
            this.Prefix = table.Prefix;
            this.MinimumCapacity = table.MinimumCapacity;
            this.DisplayExpression = table.DisplayExpression;
        }
        
		/// 
		/// 数据表包含的记录总数。
		/// 
        [System.ComponentModel.Browsable(false)]
        public int Count 
        {
            get 
            {
                return this.Rows.Count;
            }
        }
		
        public DataColumn ColumnVCLINICNO 
        {
            get 
            {
                return this.columnVCLINICNO;
            }
        }
		
        public DataColumn ColumnDVISITDATE 
        {
            get 
            {
                return this.columnDVISITDATE;
            }
        }
		
        public DataColumn ColumnNVISITNO 
        {
            get 
            {
                return this.columnNVISITNO;
            }
        }
		
        public DataColumn ColumnVAPPTIME 
        {
            get 
            {
                return this.columnVAPPTIME;
            }
        }
		
        public DataColumn ColumnVPATIENTID 
        {
            get 
            {
                return this.columnVPATIENTID;
            }
        }
		
        public DataColumn ColumnVNAME 
        {
            get 
            {
                return this.columnVNAME;
            }
        }
		
        public DataColumn ColumnPINYINMA 
        {
            get 
            {
                return this.columnPINYINMA;
            }
        }
		
        public DataColumn ColumnWUBIMA 
        {
            get 
            {
                return this.columnWUBIMA;
            }
        }
		
        public DataColumn ColumnNSEX 
        {
            get 
            {
                return this.columnNSEX;
            }
        }
		
        public DataColumn ColumnNAGE 
        {
            get 
            {
                return this.columnNAGE;
            }
        }
		
        public DataColumn ColumnDBIRTHDATE 
        {
            get 
            {
                return this.columnDBIRTHDATE;
            }
        }
		
        public DataColumn ColumnNIDENTITY 
        {
            get 
            {
                return this.columnNIDENTITY;
            }
        }
		
        public DataColumn ColumnNCHARGETYPE 
        {
            get 
            {
                return this.columnNCHARGETYPE;
            }
        }
		
        public DataColumn ColumnVINSURANCETY 
        {
            get 
            {
                return this.columnVINSURANCETY;
            }
        }
		
        public DataColumn ColumnVINSURANCEN 
        {
            get 
            {
                return this.columnVINSURANCEN;
            }
        }
		
        public DataColumn ColumnVUNITINCONTRACT 
        {
            get 
            {
                return this.columnVUNITINCONTRACT;
            }
        }
		
        public DataColumn ColumnNCLINICTYPE 
        {
            get 
            {
                return this.columnNCLINICTYPE;
            }
        }
		
        public DataColumn ColumnNCFIRSTVISITIND 
        {
            get 
            {
                return this.columnNCFIRSTVISITIND;
            }
        }
		
        public DataColumn ColumnVVISITDEPT 
        {
            get 
            {
                return this.columnVVISITDEPT;
            }
        }
		
        public DataColumn ColumnVDOCTOR 
        {
            get 
            {
                return this.columnVDOCTOR;
            }
        }
		
        public DataColumn ColumnNMRPROVIDEINDICATOR 
        {
            get 
            {
                return this.columnNMRPROVIDEINDICATOR;
            }
        }
		
        public DataColumn ColumnNREGSTATUS 
        {
            get 
            {
                return this.columnNREGSTATUS;
            }
        }
		
        public DataColumn ColumnVOPERATORID 
        {
            get 
            {
                return this.columnVOPERATORID;
            }
        }
		
        public DataColumn ColumnDREGDATE 
        {
            get 
            {
                return this.columnDREGDATE;
            }
        }
		
        public DataColumn ColumnVSYMPTOM 
        {
            get 
            {
                return this.columnVSYMPTOM;
            }
        }
		
        public DataColumn ColumnNREGISTFEE 
        {
            get 
            {
                return this.columnNREGISTFEE;
            }
        }
		
        public DataColumn ColumnNCLINICFEE 
        {
            get 
            {
                return this.columnNCLINICFEE;
            }
        }
		
        public DataColumn ColumnNOTHERFEE 
        {
            get 
            {
                return this.columnNOTHERFEE;
            }
        }
		
        public DataColumn ColumnNCLINICCHARG 
        {
            get 
            {
                return this.columnNCLINICCHARG;
            }
        }
		
        public DataColumn ColumnDRETURNDATE 
        {
            get 
            {
                return this.columnDRETURNDATE;
            }
        }
		
        public DataColumn ColumnVIDTYPE 
        {
            get 
            {
                return this.columnVIDTYPE;
            }
        }
		
        public DataColumn ColumnVIDNO 
        {
            get 
            {
                return this.columnVIDNO;
            }
        }
		
        public DataColumn ColumnVRETURNID 
        {
            get 
            {
                return this.columnVRETURNID;
            }
        }
		
        public DataColumn ColumnNMODEID 
        {
            get 
            {
                return this.columnNMODEID;
            }
        }
		
        public DataColumn ColumnVCARDNO 
        {
            get 
            {
                return this.columnVCARDNO;
            }
        }
		
        public DataColumn ColumnDACCTDATETI 
        {
            get 
            {
                return this.columnDACCTDATETI;
            }
        }
		
        public DataColumn ColumnDACCTNO 
        {
            get 
            {
                return this.columnDACCTNO;
            }
        }
		
        public DataColumn ColumnNMRPROVIDEDINDICATOR 
        {
            get 
            {
                return this.columnNMRPROVIDEDINDICATOR;
            }
        }
		
        public DataColumn ColumnVAPPOINTSID 
        {
            get 
            {
                return this.columnVAPPOINTSID;
            }
        }
		
        public DataColumn ColumnVREMARKS 
        {
            get 
            {
                return this.columnVREMARKS;
            }
        }
		
        public DataColumn ColumnVNATION 
        {
            get 
            {
                return this.columnVNATION;
            }
        }
		
        public DataColumn ColumnVNATIVEPLACE 
        {
            get 
            {
                return this.columnVNATIVEPLACE;
            }
        }
		
        public DataColumn ColumnVPRESENTADDRESS 
        {
            get 
            {
                return this.columnVPRESENTADDRESS;
            }
        }
		
        public DataColumn ColumnVLINKMAN 
        {
            get 
            {
                return this.columnVLINKMAN;
            }
        }
		
        public DataColumn ColumnVPHONE 
        {
            get 
            {
                return this.columnVPHONE;
            }
        }
		
        public DataColumn ColumnNKA 
        {
            get 
            {
                return this.columnNKA;
            }
        }
		
        public DataColumn ColumnNPROFESSIONID 
        {
            get 
            {
                return this.columnNPROFESSIONID;
            }
        }
		
        public DataColumn ColumnNDICGHTYPE 
        {
            get 
            {
                return this.columnNDICGHTYPE;
            }
        }
		
        public DataColumn ColumnVBSETCARD 
        {
            get 
            {
                return this.columnVBSETCARD;
            }
        }
		
        public DataColumn ColumnPERSONACCOUNTINFO 
        {
            get 
            {
                return this.columnPERSONACCOUNTINFO;
            }
        }
		
        public DataColumn ColumnYBGRBH 
        {
            get 
            {
                return this.columnYBGRBH;
            }
        }
		
        public DataColumn ColumnNCHARGE 
        {
            get 
            {
                return this.columnNCHARGE;
            }
        }
		
        public DataColumn ColumnNHOSID 
        {
            get 
            {
                return this.columnNHOSID;
            }
        }
		
        public DataColumn ColumnPURCHASINGPERSONNAME 
        {
            get 
            {
                return this.columnPURCHASINGPERSONNAME;
            }
        }
		
        public DataColumn ColumnPURCHASINGPERSONVIDNO 
        {
            get 
            {
                return this.columnPURCHASINGPERSONVIDNO;
            }
        }
		
        public DataColumn ColumnPURCHASINGPERSONVPHONE 
        {
            get 
            {
                return this.columnPURCHASINGPERSONVPHONE;
            }
        }
		
        public DataColumn ColumnRELATIONSHIPWITHPATIENTS 
        {
            get 
            {
                return this.columnRELATIONSHIPWITHPATIENTS;
            }
        }
		
        public DataColumn ColumnYBLX 
        {
            get 
            {
                return this.columnYBLX;
            }
        }
		
        public DataColumn ColumnNDICAREAID 
        {
            get 
            {
                return this.columnNDICAREAID;
            }
        }
		
        public DataColumn ColumnNHREGNO 
        {
            get 
            {
                return this.columnNHREGNO;
            }
        }
		
        public DataColumn ColumnBCJSFF 
        {
            get 
            {
                return this.columnBCJSFF;
            }
        }
		
        public DataColumn ColumnNHLYZT 
        {
            get 
            {
                return this.columnNHLYZT;
            }
        }
		
        public DataColumn ColumnJSDISEASE 
        {
            get 
            {
                return this.columnJSDISEASE;
            }
        }
		
        public DataColumn ColumnVFIRST_VISITDEPT 
        {
            get 
            {
                return this.columnVFIRST_VISITDEPT;
            }
        }
		
        public DataColumn ColumnVFIRST_DOCTOR 
        {
            get 
            {
                return this.columnVFIRST_DOCTOR;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowGHSF_GHSF_REGHIS this[int index] 
        {
            get 
            {
                return ((RowGHSF_GHSF_REGHIS)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerGHSF_GHSF_REGHIS RowChangedGHSF_GHSF_REGHIS;
        
        public event RowChangeEventHandlerGHSF_GHSF_REGHIS RowChangingGHSF_GHSF_REGHIS;
        
        public event RowChangeEventHandlerGHSF_GHSF_REGHIS RowDeletedGHSF_GHSF_REGHIS;
        
        public event RowChangeEventHandlerGHSF_GHSF_REGHIS RowDeletingGHSF_GHSF_REGHIS;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowGHSF_GHSF_REGHIS(RowGHSF_GHSF_REGHIS row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowGHSF_GHSF_REGHIS AddRowGHSF_GHSF_REGHIS(System.String VCLINICNO,System.DateTime DVISITDATE,System.Int32 NVISITNO,System.String VAPPTIME,System.String VPATIENTID,System.String VNAME,System.String PINYINMA,System.String WUBIMA,System.Int16 NSEX,System.String NAGE,System.DateTime DBIRTHDATE,System.String NIDENTITY,System.Int32 NCHARGETYPE,System.String VINSURANCETY,System.String VINSURANCEN,System.String VUNITINCONTRACT,System.Int32 NCLINICTYPE,System.Int16 NCFIRSTVISITIND,System.String VVISITDEPT,System.String VDOCTOR,System.Int16 NMRPROVIDEINDICATOR,System.Int16 NREGSTATUS,System.String VOPERATORID,System.DateTime DREGDATE,System.String VSYMPTOM,System.Decimal NREGISTFEE,System.Decimal NCLINICFEE,System.Decimal NOTHERFEE,System.Decimal NCLINICCHARG,System.DateTime DRETURNDATE,System.String VIDTYPE,System.String VIDNO,System.String VRETURNID,System.Int16 NMODEID,System.String VCARDNO,System.DateTime DACCTDATETI,System.String DACCTNO,System.Int16 NMRPROVIDEDINDICATOR,System.String VAPPOINTSID,System.String VREMARKS,System.String VNATION,System.String VNATIVEPLACE,System.String VPRESENTADDRESS,System.String VLINKMAN,System.String VPHONE,System.Decimal NKA,System.Int32 NPROFESSIONID,System.Int32 NDICGHTYPE,System.String VBSETCARD,System.String PERSONACCOUNTINFO,System.String YBGRBH,System.Int16 NCHARGE,System.Int32 NHOSID,System.String PURCHASINGPERSONNAME,System.String PURCHASINGPERSONVIDNO,System.String PURCHASINGPERSONVPHONE,System.String RELATIONSHIPWITHPATIENTS,System.String YBLX,System.Decimal NDICAREAID,System.String NHREGNO,System.String BCJSFF,System.String NHLYZT,System.Int32 JSDISEASE,System.String VFIRST_VISITDEPT,System.String VFIRST_DOCTOR) 
        {
            RowGHSF_GHSF_REGHIS row = ((RowGHSF_GHSF_REGHIS)(this.NewRow()));
            row.ItemArray = new object[] {VCLINICNO,DVISITDATE,NVISITNO,VAPPTIME,VPATIENTID,VNAME,PINYINMA,WUBIMA,NSEX,NAGE,DBIRTHDATE,NIDENTITY,NCHARGETYPE,VINSURANCETY,VINSURANCEN,VUNITINCONTRACT,NCLINICTYPE,NCFIRSTVISITIND,VVISITDEPT,VDOCTOR,NMRPROVIDEINDICATOR,NREGSTATUS,VOPERATORID,DREGDATE,VSYMPTOM,NREGISTFEE,NCLINICFEE,NOTHERFEE,NCLINICCHARG,DRETURNDATE,VIDTYPE,VIDNO,VRETURNID,NMODEID,VCARDNO,DACCTDATETI,DACCTNO,NMRPROVIDEDINDICATOR,VAPPOINTSID,VREMARKS,VNATION,VNATIVEPLACE,VPRESENTADDRESS,VLINKMAN,VPHONE,NKA,NPROFESSIONID,NDICGHTYPE,VBSETCARD,PERSONACCOUNTINFO,YBGRBH,NCHARGE,NHOSID,PURCHASINGPERSONNAME,PURCHASINGPERSONVIDNO,PURCHASINGPERSONVPHONE,RELATIONSHIPWITHPATIENTS,YBLX,NDICAREAID,NHREGNO,BCJSFF,NHLYZT,JSDISEASE,VFIRST_VISITDEPT,VFIRST_DOCTOR};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowGHSF_GHSF_REGHIS FindByVCLINICNO(System.String VCLINICNO) {
            return ((RowGHSF_GHSF_REGHIS)(this.Rows.Find(new object[] {
                        VCLINICNO})));
        }
		
		/// 
		/// 得到DataSet的列举器。
		/// 
        public System.Collections.IEnumerator GetEnumerator() {
            return this.Rows.GetEnumerator();
        }
        
		/// 
		/// Clone新的DataTable。
		/// 
        public override DataTable Clone() {
            DataTableGHSF_GHSF_REGHIS cln = ((DataTableGHSF_GHSF_REGHIS)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableGHSF_GHSF_REGHIS();
        }
        
        internal void InitVars() 
        {	
            this.columnVCLINICNO = this.Columns["VCLINICNO"];
            this.columnDVISITDATE = this.Columns["DVISITDATE"];
            this.columnNVISITNO = this.Columns["NVISITNO"];
            this.columnVAPPTIME = this.Columns["VAPPTIME"];
            this.columnVPATIENTID = this.Columns["VPATIENTID"];
            this.columnVNAME = this.Columns["VNAME"];
            this.columnPINYINMA = this.Columns["PINYINMA"];
            this.columnWUBIMA = this.Columns["WUBIMA"];
            this.columnNSEX = this.Columns["NSEX"];
            this.columnNAGE = this.Columns["NAGE"];
            this.columnDBIRTHDATE = this.Columns["DBIRTHDATE"];
            this.columnNIDENTITY = this.Columns["NIDENTITY"];
            this.columnNCHARGETYPE = this.Columns["NCHARGETYPE"];
            this.columnVINSURANCETY = this.Columns["VINSURANCETY"];
            this.columnVINSURANCEN = this.Columns["VINSURANCEN"];
            this.columnVUNITINCONTRACT = this.Columns["VUNITINCONTRACT"];
            this.columnNCLINICTYPE = this.Columns["NCLINICTYPE"];
            this.columnNCFIRSTVISITIND = this.Columns["NCFIRSTVISITIND"];
            this.columnVVISITDEPT = this.Columns["VVISITDEPT"];
            this.columnVDOCTOR = this.Columns["VDOCTOR"];
            this.columnNMRPROVIDEINDICATOR = this.Columns["NMRPROVIDEINDICATOR"];
            this.columnNREGSTATUS = this.Columns["NREGSTATUS"];
            this.columnVOPERATORID = this.Columns["VOPERATORID"];
            this.columnDREGDATE = this.Columns["DREGDATE"];
            this.columnVSYMPTOM = this.Columns["VSYMPTOM"];
            this.columnNREGISTFEE = this.Columns["NREGISTFEE"];
            this.columnNCLINICFEE = this.Columns["NCLINICFEE"];
            this.columnNOTHERFEE = this.Columns["NOTHERFEE"];
            this.columnNCLINICCHARG = this.Columns["NCLINICCHARG"];
            this.columnDRETURNDATE = this.Columns["DRETURNDATE"];
            this.columnVIDTYPE = this.Columns["VIDTYPE"];
            this.columnVIDNO = this.Columns["VIDNO"];
            this.columnVRETURNID = this.Columns["VRETURNID"];
            this.columnNMODEID = this.Columns["NMODEID"];
            this.columnVCARDNO = this.Columns["VCARDNO"];
            this.columnDACCTDATETI = this.Columns["DACCTDATETI"];
            this.columnDACCTNO = this.Columns["DACCTNO"];
            this.columnNMRPROVIDEDINDICATOR = this.Columns["NMRPROVIDEDINDICATOR"];
            this.columnVAPPOINTSID = this.Columns["VAPPOINTSID"];
            this.columnVREMARKS = this.Columns["VREMARKS"];
            this.columnVNATION = this.Columns["VNATION"];
            this.columnVNATIVEPLACE = this.Columns["VNATIVEPLACE"];
            this.columnVPRESENTADDRESS = this.Columns["VPRESENTADDRESS"];
            this.columnVLINKMAN = this.Columns["VLINKMAN"];
            this.columnVPHONE = this.Columns["VPHONE"];
            this.columnNKA = this.Columns["NKA"];
            this.columnNPROFESSIONID = this.Columns["NPROFESSIONID"];
            this.columnNDICGHTYPE = this.Columns["NDICGHTYPE"];
            this.columnVBSETCARD = this.Columns["VBSETCARD"];
            this.columnPERSONACCOUNTINFO = this.Columns["PERSONACCOUNTINFO"];
            this.columnYBGRBH = this.Columns["YBGRBH"];
            this.columnNCHARGE = this.Columns["NCHARGE"];
            this.columnNHOSID = this.Columns["NHOSID"];
            this.columnPURCHASINGPERSONNAME = this.Columns["PURCHASINGPERSONNAME"];
            this.columnPURCHASINGPERSONVIDNO = this.Columns["PURCHASINGPERSONVIDNO"];
            this.columnPURCHASINGPERSONVPHONE = this.Columns["PURCHASINGPERSONVPHONE"];
            this.columnRELATIONSHIPWITHPATIENTS = this.Columns["RELATIONSHIPWITHPATIENTS"];
            this.columnYBLX = this.Columns["YBLX"];
            this.columnNDICAREAID = this.Columns["NDICAREAID"];
            this.columnNHREGNO = this.Columns["NHREGNO"];
            this.columnBCJSFF = this.Columns["BCJSFF"];
            this.columnNHLYZT = this.Columns["NHLYZT"];
            this.columnJSDISEASE = this.Columns["JSDISEASE"];
            this.columnVFIRST_VISITDEPT = this.Columns["VFIRST_VISITDEPT"];
            this.columnVFIRST_DOCTOR = this.Columns["VFIRST_DOCTOR"];
        }
        
        private void InitClass() 
        {	
            this.columnVCLINICNO = new DataColumn("VCLINICNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCLINICNO.MaxLength = 10;
            this.columnVCLINICNO.AllowDBNull = false;
            this.columnVCLINICNO.Unique = true;
            
            this.Columns.Add(this.columnVCLINICNO);
			
            this.columnDVISITDATE = new DataColumn("DVISITDATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDVISITDATE.AllowDBNull = false;
            this.Columns.Add(this.columnDVISITDATE);
			
            this.columnNVISITNO = new DataColumn("NVISITNO", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNVISITNO.AllowDBNull = true;
            this.Columns.Add(this.columnNVISITNO);
			
            this.columnVAPPTIME = new DataColumn("VAPPTIME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVAPPTIME.MaxLength = 8;
            this.columnVAPPTIME.AllowDBNull = true;
            this.Columns.Add(this.columnVAPPTIME);
			
            this.columnVPATIENTID = new DataColumn("VPATIENTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPATIENTID.MaxLength = 20;
            this.columnVPATIENTID.AllowDBNull = true;
            this.Columns.Add(this.columnVPATIENTID);
			
            this.columnVNAME = new DataColumn("VNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNAME.MaxLength = 20;
            this.columnVNAME.AllowDBNull = false;
            this.Columns.Add(this.columnVNAME);
			
            this.columnPINYINMA = new DataColumn("PINYINMA", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnPINYINMA.MaxLength = 60;
            this.columnPINYINMA.AllowDBNull = false;
            this.Columns.Add(this.columnPINYINMA);
			
            this.columnWUBIMA = new DataColumn("WUBIMA", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnWUBIMA.MaxLength = 20;
            this.columnWUBIMA.AllowDBNull = false;
            this.Columns.Add(this.columnWUBIMA);
			
            this.columnNSEX = new DataColumn("NSEX", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNSEX.AllowDBNull = false;
            this.Columns.Add(this.columnNSEX);
			
            this.columnNAGE = new DataColumn("NAGE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNAGE.MaxLength = 10;
            this.columnNAGE.AllowDBNull = true;
            this.Columns.Add(this.columnNAGE);
			
            this.columnDBIRTHDATE = new DataColumn("DBIRTHDATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDBIRTHDATE.AllowDBNull = false;
            this.Columns.Add(this.columnDBIRTHDATE);
			
            this.columnNIDENTITY = new DataColumn("NIDENTITY", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNIDENTITY.MaxLength = 10;
            this.columnNIDENTITY.AllowDBNull = true;
            this.Columns.Add(this.columnNIDENTITY);
			
            this.columnNCHARGETYPE = new DataColumn("NCHARGETYPE", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNCHARGETYPE.AllowDBNull = true;
            this.Columns.Add(this.columnNCHARGETYPE);
			
            this.columnVINSURANCETY = new DataColumn("VINSURANCETY", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVINSURANCETY.MaxLength = 50;
            this.columnVINSURANCETY.AllowDBNull = true;
            this.Columns.Add(this.columnVINSURANCETY);
			
            this.columnVINSURANCEN = new DataColumn("VINSURANCEN", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVINSURANCEN.MaxLength = 8;
            this.columnVINSURANCEN.AllowDBNull = true;
            this.Columns.Add(this.columnVINSURANCEN);
			
            this.columnVUNITINCONTRACT = new DataColumn("VUNITINCONTRACT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVUNITINCONTRACT.MaxLength = 11;
            this.columnVUNITINCONTRACT.AllowDBNull = true;
            this.Columns.Add(this.columnVUNITINCONTRACT);
			
            this.columnNCLINICTYPE = new DataColumn("NCLINICTYPE", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNCLINICTYPE.AllowDBNull = true;
            this.Columns.Add(this.columnNCLINICTYPE);
			
            this.columnNCFIRSTVISITIND = new DataColumn("NCFIRSTVISITIND", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNCFIRSTVISITIND.AllowDBNull = true;
            this.Columns.Add(this.columnNCFIRSTVISITIND);
			
            this.columnVVISITDEPT = new DataColumn("VVISITDEPT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVVISITDEPT.MaxLength = 20;
            this.columnVVISITDEPT.AllowDBNull = false;
            this.Columns.Add(this.columnVVISITDEPT);
			
            this.columnVDOCTOR = new DataColumn("VDOCTOR", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDOCTOR.MaxLength = 20;
            this.columnVDOCTOR.AllowDBNull = true;
            this.Columns.Add(this.columnVDOCTOR);
			
            this.columnNMRPROVIDEINDICATOR = new DataColumn("NMRPROVIDEINDICATOR", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNMRPROVIDEINDICATOR.AllowDBNull = true;
            this.Columns.Add(this.columnNMRPROVIDEINDICATOR);
			
            this.columnNREGSTATUS = new DataColumn("NREGSTATUS", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNREGSTATUS.DefaultValue = "0";
            this.columnNREGSTATUS.AllowDBNull = true;
            this.Columns.Add(this.columnNREGSTATUS);
			
            this.columnVOPERATORID = new DataColumn("VOPERATORID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVOPERATORID.MaxLength = 20;
            this.columnVOPERATORID.AllowDBNull = true;
            this.Columns.Add(this.columnVOPERATORID);
			
            this.columnDREGDATE = new DataColumn("DREGDATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDREGDATE.AllowDBNull = true;
            this.Columns.Add(this.columnDREGDATE);
			
            this.columnVSYMPTOM = new DataColumn("VSYMPTOM", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVSYMPTOM.MaxLength = 40;
            this.columnVSYMPTOM.AllowDBNull = true;
            this.Columns.Add(this.columnVSYMPTOM);
			
            this.columnNREGISTFEE = new DataColumn("NREGISTFEE", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNREGISTFEE.AllowDBNull = true;
            this.Columns.Add(this.columnNREGISTFEE);
			
            this.columnNCLINICFEE = new DataColumn("NCLINICFEE", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNCLINICFEE.AllowDBNull = true;
            this.Columns.Add(this.columnNCLINICFEE);
			
            this.columnNOTHERFEE = new DataColumn("NOTHERFEE", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNOTHERFEE.AllowDBNull = true;
            this.Columns.Add(this.columnNOTHERFEE);
			
            this.columnNCLINICCHARG = new DataColumn("NCLINICCHARG", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNCLINICCHARG.AllowDBNull = true;
            this.Columns.Add(this.columnNCLINICCHARG);
			
            this.columnDRETURNDATE = new DataColumn("DRETURNDATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDRETURNDATE.AllowDBNull = true;
            this.Columns.Add(this.columnDRETURNDATE);
			
            this.columnVIDTYPE = new DataColumn("VIDTYPE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVIDTYPE.MaxLength = 10;
            this.columnVIDTYPE.AllowDBNull = true;
            this.Columns.Add(this.columnVIDTYPE);
			
            this.columnVIDNO = new DataColumn("VIDNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVIDNO.MaxLength = 18;
            this.columnVIDNO.AllowDBNull = true;
            this.Columns.Add(this.columnVIDNO);
			
            this.columnVRETURNID = new DataColumn("VRETURNID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVRETURNID.MaxLength = 8;
            this.columnVRETURNID.AllowDBNull = true;
            this.Columns.Add(this.columnVRETURNID);
			
            this.columnNMODEID = new DataColumn("NMODEID", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNMODEID.AllowDBNull = true;
            this.Columns.Add(this.columnNMODEID);
			
            this.columnVCARDNO = new DataColumn("VCARDNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCARDNO.MaxLength = 10;
            this.columnVCARDNO.AllowDBNull = true;
            this.Columns.Add(this.columnVCARDNO);
			
            this.columnDACCTDATETI = new DataColumn("DACCTDATETI", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDACCTDATETI.AllowDBNull = true;
            this.Columns.Add(this.columnDACCTDATETI);
			
            this.columnDACCTNO = new DataColumn("DACCTNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnDACCTNO.MaxLength = 6;
            this.columnDACCTNO.AllowDBNull = true;
            this.Columns.Add(this.columnDACCTNO);
			
            this.columnNMRPROVIDEDINDICATOR = new DataColumn("NMRPROVIDEDINDICATOR", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNMRPROVIDEDINDICATOR.AllowDBNull = true;
            this.Columns.Add(this.columnNMRPROVIDEDINDICATOR);
			
            this.columnVAPPOINTSID = new DataColumn("VAPPOINTSID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVAPPOINTSID.MaxLength = 10;
            this.columnVAPPOINTSID.AllowDBNull = true;
            this.Columns.Add(this.columnVAPPOINTSID);
			
            this.columnVREMARKS = new DataColumn("VREMARKS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVREMARKS.MaxLength = 50;
            this.columnVREMARKS.AllowDBNull = true;
            this.Columns.Add(this.columnVREMARKS);
			
            this.columnVNATION = new DataColumn("VNATION", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNATION.MaxLength = 10;
            this.columnVNATION.AllowDBNull = true;
            this.Columns.Add(this.columnVNATION);
			
            this.columnVNATIVEPLACE = new DataColumn("VNATIVEPLACE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNATIVEPLACE.MaxLength = 10;
            this.columnVNATIVEPLACE.AllowDBNull = true;
            this.Columns.Add(this.columnVNATIVEPLACE);
			
            this.columnVPRESENTADDRESS = new DataColumn("VPRESENTADDRESS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPRESENTADDRESS.MaxLength = 20;
            this.columnVPRESENTADDRESS.AllowDBNull = true;
            this.Columns.Add(this.columnVPRESENTADDRESS);
			
            this.columnVLINKMAN = new DataColumn("VLINKMAN", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVLINKMAN.MaxLength = 20;
            this.columnVLINKMAN.AllowDBNull = true;
            this.Columns.Add(this.columnVLINKMAN);
			
            this.columnVPHONE = new DataColumn("VPHONE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPHONE.MaxLength = 20;
            this.columnVPHONE.AllowDBNull = true;
            this.Columns.Add(this.columnVPHONE);
			
            this.columnNKA = new DataColumn("NKA", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNKA.AllowDBNull = true;
            this.Columns.Add(this.columnNKA);
			
            this.columnNPROFESSIONID = new DataColumn("NPROFESSIONID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNPROFESSIONID.AllowDBNull = true;
            this.Columns.Add(this.columnNPROFESSIONID);
			
            this.columnNDICGHTYPE = new DataColumn("NDICGHTYPE", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNDICGHTYPE.AllowDBNull = true;
            this.Columns.Add(this.columnNDICGHTYPE);
			
            this.columnVBSETCARD = new DataColumn("VBSETCARD", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVBSETCARD.MaxLength = 20;
            this.columnVBSETCARD.AllowDBNull = true;
            this.Columns.Add(this.columnVBSETCARD);
			
            this.columnPERSONACCOUNTINFO = new DataColumn("PERSONACCOUNTINFO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnPERSONACCOUNTINFO.MaxLength = 1000;
            this.columnPERSONACCOUNTINFO.AllowDBNull = true;
            this.Columns.Add(this.columnPERSONACCOUNTINFO);
			
            this.columnYBGRBH = new DataColumn("YBGRBH", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnYBGRBH.MaxLength = 50;
            this.columnYBGRBH.AllowDBNull = true;
            this.Columns.Add(this.columnYBGRBH);
			
            this.columnNCHARGE = new DataColumn("NCHARGE", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNCHARGE.AllowDBNull = true;
            this.Columns.Add(this.columnNCHARGE);
			
            this.columnNHOSID = new DataColumn("NHOSID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNHOSID.AllowDBNull = true;
            this.Columns.Add(this.columnNHOSID);
			
            this.columnPURCHASINGPERSONNAME = new DataColumn("PURCHASINGPERSONNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnPURCHASINGPERSONNAME.MaxLength = 20;
            this.columnPURCHASINGPERSONNAME.AllowDBNull = true;
            this.Columns.Add(this.columnPURCHASINGPERSONNAME);
			
            this.columnPURCHASINGPERSONVIDNO = new DataColumn("PURCHASINGPERSONVIDNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnPURCHASINGPERSONVIDNO.MaxLength = 18;
            this.columnPURCHASINGPERSONVIDNO.AllowDBNull = true;
            this.Columns.Add(this.columnPURCHASINGPERSONVIDNO);
			
            this.columnPURCHASINGPERSONVPHONE = new DataColumn("PURCHASINGPERSONVPHONE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnPURCHASINGPERSONVPHONE.MaxLength = 20;
            this.columnPURCHASINGPERSONVPHONE.AllowDBNull = true;
            this.Columns.Add(this.columnPURCHASINGPERSONVPHONE);
			
            this.columnRELATIONSHIPWITHPATIENTS = new DataColumn("RELATIONSHIPWITHPATIENTS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnRELATIONSHIPWITHPATIENTS.MaxLength = 10;
            this.columnRELATIONSHIPWITHPATIENTS.AllowDBNull = true;
            this.Columns.Add(this.columnRELATIONSHIPWITHPATIENTS);
			
            this.columnYBLX = new DataColumn("YBLX", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnYBLX.MaxLength = 50;
            this.columnYBLX.AllowDBNull = true;
            this.Columns.Add(this.columnYBLX);
			
            this.columnNDICAREAID = new DataColumn("NDICAREAID", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNDICAREAID.AllowDBNull = true;
            this.Columns.Add(this.columnNDICAREAID);
			
            this.columnNHREGNO = new DataColumn("NHREGNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNHREGNO.MaxLength = 100;
            this.columnNHREGNO.AllowDBNull = true;
            this.Columns.Add(this.columnNHREGNO);
			
            this.columnBCJSFF = new DataColumn("BCJSFF", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnBCJSFF.MaxLength = 10;
            this.columnBCJSFF.AllowDBNull = true;
            this.Columns.Add(this.columnBCJSFF);
			
            this.columnNHLYZT = new DataColumn("NHLYZT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNHLYZT.MaxLength = 2;
            this.columnNHLYZT.AllowDBNull = true;
            this.Columns.Add(this.columnNHLYZT);
			
            this.columnJSDISEASE = new DataColumn("JSDISEASE", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnJSDISEASE.AllowDBNull = true;
            this.Columns.Add(this.columnJSDISEASE);
			
            this.columnVFIRST_VISITDEPT = new DataColumn("VFIRST_VISITDEPT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVFIRST_VISITDEPT.MaxLength = 20;
            this.columnVFIRST_VISITDEPT.AllowDBNull = true;
            this.Columns.Add(this.columnVFIRST_VISITDEPT);
			
            this.columnVFIRST_DOCTOR = new DataColumn("VFIRST_DOCTOR", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVFIRST_DOCTOR.MaxLength = 20;
            this.columnVFIRST_DOCTOR.AllowDBNull = true;
            this.Columns.Add(this.columnVFIRST_DOCTOR);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowGHSF_GHSF_REGHIS NewRowGHSF_GHSF_REGHIS() {
            return ((RowGHSF_GHSF_REGHIS)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowGHSF_GHSF_REGHIS(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowGHSF_GHSF_REGHIS);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedGHSF_GHSF_REGHIS != null)) {
                this.RowChangedGHSF_GHSF_REGHIS(this, new RowChangeEventGHSF_GHSF_REGHIS(((RowGHSF_GHSF_REGHIS)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingGHSF_GHSF_REGHIS != null)) {
                this.RowChangingGHSF_GHSF_REGHIS(this, new RowChangeEventGHSF_GHSF_REGHIS(((RowGHSF_GHSF_REGHIS)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedGHSF_GHSF_REGHIS != null)) {
                this.RowDeletedGHSF_GHSF_REGHIS(this, new RowChangeEventGHSF_GHSF_REGHIS(((RowGHSF_GHSF_REGHIS)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingGHSF_GHSF_REGHIS != null)) {
                this.RowDeletingGHSF_GHSF_REGHIS(this, new RowChangeEventGHSF_GHSF_REGHIS(((RowGHSF_GHSF_REGHIS)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowGHSF_GHSF_REGHIS(RowGHSF_GHSF_REGHIS row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowGHSF_GHSF_REGHIS
	/// 
	/// 数据表GHSF_GHSF_REGHIS行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowGHSF_GHSF_REGHIS : DataRow 
    {
        
        private DataTableGHSF_GHSF_REGHIS tableGHSF_GHSF_REGHIS;
        
        internal RowGHSF_GHSF_REGHIS(DataRowBuilder rb) : base(rb) 
        {
            this.tableGHSF_GHSF_REGHIS = ((DataTableGHSF_GHSF_REGHIS)(this.Table));
        }        
		
		/// 
		/// 字段VCLINICNO所映射的属性。
		/// 
        public System.String VCLINICNO
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVCLINICNO])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVCLINICNO] = value;
            }
        }
        
		/// 
		/// 字段DVISITDATE所映射的属性。
		/// 
        public System.DateTime DVISITDATE
        {
            get 
            {	
                return ((System.DateTime)(this[this.tableGHSF_GHSF_REGHIS.ColumnDVISITDATE])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnDVISITDATE] = value;
            }
        }
        
		/// 
		/// 字段NVISITNO所映射的属性。
		/// 
        public System.Int32 NVISITNO
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_REGHIS.ColumnNVISITNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNVISITNO] = value;
            }
        }
        
		/// 
		/// 字段VAPPTIME所映射的属性。
		/// 
        public System.String VAPPTIME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVAPPTIME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVAPPTIME] = value;
            }
        }
        
		/// 
		/// 字段VPATIENTID所映射的属性。
		/// 
        public System.String VPATIENTID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVPATIENTID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVPATIENTID] = value;
            }
        }
        
		/// 
		/// 字段VNAME所映射的属性。
		/// 
        public System.String VNAME
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVNAME])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVNAME] = value;
            }
        }
        
		/// 
		/// 字段PINYINMA所映射的属性。
		/// 
        public System.String PINYINMA
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnPINYINMA])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnPINYINMA] = value;
            }
        }
        
		/// 
		/// 字段WUBIMA所映射的属性。
		/// 
        public System.String WUBIMA
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnWUBIMA])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnWUBIMA] = value;
            }
        }
        
		/// 
		/// 字段NSEX所映射的属性。
		/// 
        public System.Int16 NSEX
        {
            get 
            {	
                return ((System.Int16)(this[this.tableGHSF_GHSF_REGHIS.ColumnNSEX])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNSEX] = value;
            }
        }
        
		/// 
		/// 字段NAGE所映射的属性。
		/// 
        public System.String NAGE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnNAGE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNAGE] = value;
            }
        }
        
		/// 
		/// 字段DBIRTHDATE所映射的属性。
		/// 
        public System.DateTime DBIRTHDATE
        {
            get 
            {	
                return ((System.DateTime)(this[this.tableGHSF_GHSF_REGHIS.ColumnDBIRTHDATE])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnDBIRTHDATE] = value;
            }
        }
        
		/// 
		/// 字段NIDENTITY所映射的属性。
		/// 
        public System.String NIDENTITY
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnNIDENTITY])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNIDENTITY] = value;
            }
        }
        
		/// 
		/// 字段NCHARGETYPE所映射的属性。
		/// 
        public System.Int32 NCHARGETYPE
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_REGHIS.ColumnNCHARGETYPE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNCHARGETYPE] = value;
            }
        }
        
		/// 
		/// 字段VINSURANCETY所映射的属性。
		/// 
        public System.String VINSURANCETY
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVINSURANCETY])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVINSURANCETY] = value;
            }
        }
        
		/// 
		/// 字段VINSURANCEN所映射的属性。
		/// 
        public System.String VINSURANCEN
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVINSURANCEN])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVINSURANCEN] = value;
            }
        }
        
		/// 
		/// 字段VUNITINCONTRACT所映射的属性。
		/// 
        public System.String VUNITINCONTRACT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVUNITINCONTRACT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVUNITINCONTRACT] = value;
            }
        }
        
		/// 
		/// 字段NCLINICTYPE所映射的属性。
		/// 
        public System.Int32 NCLINICTYPE
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_REGHIS.ColumnNCLINICTYPE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNCLINICTYPE] = value;
            }
        }
        
		/// 
		/// 字段NCFIRSTVISITIND所映射的属性。
		/// 
        public System.Int16 NCFIRSTVISITIND
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_REGHIS.ColumnNCFIRSTVISITIND])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNCFIRSTVISITIND] = value;
            }
        }
        
		/// 
		/// 字段VVISITDEPT所映射的属性。
		/// 
        public System.String VVISITDEPT
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVVISITDEPT])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVVISITDEPT] = value;
            }
        }
        
		/// 
		/// 字段VDOCTOR所映射的属性。
		/// 
        public System.String VDOCTOR
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVDOCTOR])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVDOCTOR] = value;
            }
        }
        
		/// 
		/// 字段NMRPROVIDEINDICATOR所映射的属性。
		/// 
        public System.Int16 NMRPROVIDEINDICATOR
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_REGHIS.ColumnNMRPROVIDEINDICATOR])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNMRPROVIDEINDICATOR] = value;
            }
        }
        
		/// 
		/// 字段NREGSTATUS所映射的属性。
		/// 
        public System.Int16 NREGSTATUS
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_REGHIS.ColumnNREGSTATUS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNREGSTATUS] = value;
            }
        }
        
		/// 
		/// 字段VOPERATORID所映射的属性。
		/// 
        public System.String VOPERATORID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVOPERATORID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVOPERATORID] = value;
            }
        }
        
		/// 
		/// 字段DREGDATE所映射的属性。
		/// 
        public System.DateTime DREGDATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableGHSF_GHSF_REGHIS.ColumnDREGDATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnDREGDATE] = value;
            }
        }
        
		/// 
		/// 字段VSYMPTOM所映射的属性。
		/// 
        public System.String VSYMPTOM
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVSYMPTOM])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVSYMPTOM] = value;
            }
        }
        
		/// 
		/// 字段NREGISTFEE所映射的属性。
		/// 
        public System.Decimal NREGISTFEE
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableGHSF_GHSF_REGHIS.ColumnNREGISTFEE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNREGISTFEE] = value;
            }
        }
        
		/// 
		/// 字段NCLINICFEE所映射的属性。
		/// 
        public System.Decimal NCLINICFEE
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableGHSF_GHSF_REGHIS.ColumnNCLINICFEE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNCLINICFEE] = value;
            }
        }
        
		/// 
		/// 字段NOTHERFEE所映射的属性。
		/// 
        public System.Decimal NOTHERFEE
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableGHSF_GHSF_REGHIS.ColumnNOTHERFEE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNOTHERFEE] = value;
            }
        }
        
		/// 
		/// 字段NCLINICCHARG所映射的属性。
		/// 
        public System.Decimal NCLINICCHARG
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableGHSF_GHSF_REGHIS.ColumnNCLINICCHARG])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNCLINICCHARG] = value;
            }
        }
        
		/// 
		/// 字段DRETURNDATE所映射的属性。
		/// 
        public System.DateTime DRETURNDATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableGHSF_GHSF_REGHIS.ColumnDRETURNDATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnDRETURNDATE] = value;
            }
        }
        
		/// 
		/// 字段VIDTYPE所映射的属性。
		/// 
        public System.String VIDTYPE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVIDTYPE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVIDTYPE] = value;
            }
        }
        
		/// 
		/// 字段VIDNO所映射的属性。
		/// 
        public System.String VIDNO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVIDNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVIDNO] = value;
            }
        }
        
		/// 
		/// 字段VRETURNID所映射的属性。
		/// 
        public System.String VRETURNID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVRETURNID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVRETURNID] = value;
            }
        }
        
		/// 
		/// 字段NMODEID所映射的属性。
		/// 
        public System.Int16 NMODEID
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_REGHIS.ColumnNMODEID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNMODEID] = value;
            }
        }
        
		/// 
		/// 字段VCARDNO所映射的属性。
		/// 
        public System.String VCARDNO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVCARDNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVCARDNO] = value;
            }
        }
        
		/// 
		/// 字段DACCTDATETI所映射的属性。
		/// 
        public System.DateTime DACCTDATETI
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableGHSF_GHSF_REGHIS.ColumnDACCTDATETI])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnDACCTDATETI] = value;
            }
        }
        
		/// 
		/// 字段DACCTNO所映射的属性。
		/// 
        public System.String DACCTNO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnDACCTNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnDACCTNO] = value;
            }
        }
        
		/// 
		/// 字段NMRPROVIDEDINDICATOR所映射的属性。
		/// 
        public System.Int16 NMRPROVIDEDINDICATOR
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_REGHIS.ColumnNMRPROVIDEDINDICATOR])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNMRPROVIDEDINDICATOR] = value;
            }
        }
        
		/// 
		/// 字段VAPPOINTSID所映射的属性。
		/// 
        public System.String VAPPOINTSID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVAPPOINTSID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVAPPOINTSID] = value;
            }
        }
        
		/// 
		/// 字段VREMARKS所映射的属性。
		/// 
        public System.String VREMARKS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVREMARKS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVREMARKS] = value;
            }
        }
        
		/// 
		/// 字段VNATION所映射的属性。
		/// 
        public System.String VNATION
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVNATION])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVNATION] = value;
            }
        }
        
		/// 
		/// 字段VNATIVEPLACE所映射的属性。
		/// 
        public System.String VNATIVEPLACE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVNATIVEPLACE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVNATIVEPLACE] = value;
            }
        }
        
		/// 
		/// 字段VPRESENTADDRESS所映射的属性。
		/// 
        public System.String VPRESENTADDRESS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVPRESENTADDRESS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVPRESENTADDRESS] = value;
            }
        }
        
		/// 
		/// 字段VLINKMAN所映射的属性。
		/// 
        public System.String VLINKMAN
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVLINKMAN])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVLINKMAN] = value;
            }
        }
        
		/// 
		/// 字段VPHONE所映射的属性。
		/// 
        public System.String VPHONE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVPHONE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVPHONE] = value;
            }
        }
        
		/// 
		/// 字段NKA所映射的属性。
		/// 
        public System.Decimal NKA
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableGHSF_GHSF_REGHIS.ColumnNKA])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNKA] = value;
            }
        }
        
		/// 
		/// 字段NPROFESSIONID所映射的属性。
		/// 
        public System.Int32 NPROFESSIONID
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_REGHIS.ColumnNPROFESSIONID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNPROFESSIONID] = value;
            }
        }
        
		/// 
		/// 字段NDICGHTYPE所映射的属性。
		/// 
        public System.Int32 NDICGHTYPE
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_REGHIS.ColumnNDICGHTYPE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNDICGHTYPE] = value;
            }
        }
        
		/// 
		/// 字段VBSETCARD所映射的属性。
		/// 
        public System.String VBSETCARD
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVBSETCARD])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVBSETCARD] = value;
            }
        }
        
		/// 
		/// 字段PERSONACCOUNTINFO所映射的属性。
		/// 
        public System.String PERSONACCOUNTINFO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnPERSONACCOUNTINFO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnPERSONACCOUNTINFO] = value;
            }
        }
        
		/// 
		/// 字段YBGRBH所映射的属性。
		/// 
        public System.String YBGRBH
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnYBGRBH])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnYBGRBH] = value;
            }
        }
        
		/// 
		/// 字段NCHARGE所映射的属性。
		/// 
        public System.Int16 NCHARGE
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_REGHIS.ColumnNCHARGE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNCHARGE] = value;
            }
        }
        
		/// 
		/// 字段NHOSID所映射的属性。
		/// 
        public System.Int32 NHOSID
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_REGHIS.ColumnNHOSID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNHOSID] = value;
            }
        }
        
		/// 
		/// 字段PURCHASINGPERSONNAME所映射的属性。
		/// 
        public System.String PURCHASINGPERSONNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnPURCHASINGPERSONNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnPURCHASINGPERSONNAME] = value;
            }
        }
        
		/// 
		/// 字段PURCHASINGPERSONVIDNO所映射的属性。
		/// 
        public System.String PURCHASINGPERSONVIDNO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnPURCHASINGPERSONVIDNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnPURCHASINGPERSONVIDNO] = value;
            }
        }
        
		/// 
		/// 字段PURCHASINGPERSONVPHONE所映射的属性。
		/// 
        public System.String PURCHASINGPERSONVPHONE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnPURCHASINGPERSONVPHONE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnPURCHASINGPERSONVPHONE] = value;
            }
        }
        
		/// 
		/// 字段RELATIONSHIPWITHPATIENTS所映射的属性。
		/// 
        public System.String RELATIONSHIPWITHPATIENTS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnRELATIONSHIPWITHPATIENTS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnRELATIONSHIPWITHPATIENTS] = value;
            }
        }
        
		/// 
		/// 字段YBLX所映射的属性。
		/// 
        public System.String YBLX
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnYBLX])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnYBLX] = value;
            }
        }
        
		/// 
		/// 字段NDICAREAID所映射的属性。
		/// 
        public System.Decimal NDICAREAID
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableGHSF_GHSF_REGHIS.ColumnNDICAREAID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNDICAREAID] = value;
            }
        }
        
		/// 
		/// 字段NHREGNO所映射的属性。
		/// 
        public System.String NHREGNO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnNHREGNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNHREGNO] = value;
            }
        }
        
		/// 
		/// 字段BCJSFF所映射的属性。
		/// 
        public System.String BCJSFF
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnBCJSFF])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnBCJSFF] = value;
            }
        }
        
		/// 
		/// 字段NHLYZT所映射的属性。
		/// 
        public System.String NHLYZT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnNHLYZT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnNHLYZT] = value;
            }
        }
        
		/// 
		/// 字段JSDISEASE所映射的属性。
		/// 
        public System.Int32 JSDISEASE
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_REGHIS.ColumnJSDISEASE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnJSDISEASE] = value;
            }
        }
        
		/// 
		/// 字段VFIRST_VISITDEPT所映射的属性。
		/// 
        public System.String VFIRST_VISITDEPT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVFIRST_VISITDEPT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVFIRST_VISITDEPT] = value;
            }
        }
        
		/// 
		/// 字段VFIRST_DOCTOR所映射的属性。
		/// 
        public System.String VFIRST_DOCTOR
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGHIS.ColumnVFIRST_DOCTOR])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGHIS.ColumnVFIRST_DOCTOR] = value;
            }
        }
        
		/// 
		/// 判断字段NVISITNO是否为空。
		/// 
        public bool IsNVISITNONull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNVISITNO);
        }

		/// 
		/// 设置字段NVISITNO为空值。
		/// 
        public void SetNVISITNONull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNVISITNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VAPPTIME是否为空。
		/// 
        public bool IsVAPPTIMENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVAPPTIME);
        }

		/// 
		/// 设置字段VAPPTIME为空值。
		/// 
        public void SetVAPPTIMENull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVAPPTIME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPATIENTID是否为空。
		/// 
        public bool IsVPATIENTIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVPATIENTID);
        }

		/// 
		/// 设置字段VPATIENTID为空值。
		/// 
        public void SetVPATIENTIDNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVPATIENTID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NAGE是否为空。
		/// 
        public bool IsNAGENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNAGE);
        }

		/// 
		/// 设置字段NAGE为空值。
		/// 
        public void SetNAGENull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNAGE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NIDENTITY是否为空。
		/// 
        public bool IsNIDENTITYNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNIDENTITY);
        }

		/// 
		/// 设置字段NIDENTITY为空值。
		/// 
        public void SetNIDENTITYNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNIDENTITY] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCHARGETYPE是否为空。
		/// 
        public bool IsNCHARGETYPENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNCHARGETYPE);
        }

		/// 
		/// 设置字段NCHARGETYPE为空值。
		/// 
        public void SetNCHARGETYPENull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNCHARGETYPE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VINSURANCETY是否为空。
		/// 
        public bool IsVINSURANCETYNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVINSURANCETY);
        }

		/// 
		/// 设置字段VINSURANCETY为空值。
		/// 
        public void SetVINSURANCETYNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVINSURANCETY] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VINSURANCEN是否为空。
		/// 
        public bool IsVINSURANCENNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVINSURANCEN);
        }

		/// 
		/// 设置字段VINSURANCEN为空值。
		/// 
        public void SetVINSURANCENNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVINSURANCEN] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VUNITINCONTRACT是否为空。
		/// 
        public bool IsVUNITINCONTRACTNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVUNITINCONTRACT);
        }

		/// 
		/// 设置字段VUNITINCONTRACT为空值。
		/// 
        public void SetVUNITINCONTRACTNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVUNITINCONTRACT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCLINICTYPE是否为空。
		/// 
        public bool IsNCLINICTYPENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNCLINICTYPE);
        }

		/// 
		/// 设置字段NCLINICTYPE为空值。
		/// 
        public void SetNCLINICTYPENull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNCLINICTYPE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCFIRSTVISITIND是否为空。
		/// 
        public bool IsNCFIRSTVISITINDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNCFIRSTVISITIND);
        }

		/// 
		/// 设置字段NCFIRSTVISITIND为空值。
		/// 
        public void SetNCFIRSTVISITINDNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNCFIRSTVISITIND] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDOCTOR是否为空。
		/// 
        public bool IsVDOCTORNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVDOCTOR);
        }

		/// 
		/// 设置字段VDOCTOR为空值。
		/// 
        public void SetVDOCTORNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVDOCTOR] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NMRPROVIDEINDICATOR是否为空。
		/// 
        public bool IsNMRPROVIDEINDICATORNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNMRPROVIDEINDICATOR);
        }

		/// 
		/// 设置字段NMRPROVIDEINDICATOR为空值。
		/// 
        public void SetNMRPROVIDEINDICATORNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNMRPROVIDEINDICATOR] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NREGSTATUS是否为空。
		/// 
        public bool IsNREGSTATUSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNREGSTATUS);
        }

		/// 
		/// 设置字段NREGSTATUS为空值。
		/// 
        public void SetNREGSTATUSNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNREGSTATUS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VOPERATORID是否为空。
		/// 
        public bool IsVOPERATORIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVOPERATORID);
        }

		/// 
		/// 设置字段VOPERATORID为空值。
		/// 
        public void SetVOPERATORIDNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVOPERATORID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DREGDATE是否为空。
		/// 
        public bool IsDREGDATENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnDREGDATE);
        }

		/// 
		/// 设置字段DREGDATE为空值。
		/// 
        public void SetDREGDATENull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnDREGDATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VSYMPTOM是否为空。
		/// 
        public bool IsVSYMPTOMNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVSYMPTOM);
        }

		/// 
		/// 设置字段VSYMPTOM为空值。
		/// 
        public void SetVSYMPTOMNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVSYMPTOM] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NREGISTFEE是否为空。
		/// 
        public bool IsNREGISTFEENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNREGISTFEE);
        }

		/// 
		/// 设置字段NREGISTFEE为空值。
		/// 
        public void SetNREGISTFEENull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNREGISTFEE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCLINICFEE是否为空。
		/// 
        public bool IsNCLINICFEENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNCLINICFEE);
        }

		/// 
		/// 设置字段NCLINICFEE为空值。
		/// 
        public void SetNCLINICFEENull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNCLINICFEE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NOTHERFEE是否为空。
		/// 
        public bool IsNOTHERFEENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNOTHERFEE);
        }

		/// 
		/// 设置字段NOTHERFEE为空值。
		/// 
        public void SetNOTHERFEENull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNOTHERFEE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCLINICCHARG是否为空。
		/// 
        public bool IsNCLINICCHARGNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNCLINICCHARG);
        }

		/// 
		/// 设置字段NCLINICCHARG为空值。
		/// 
        public void SetNCLINICCHARGNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNCLINICCHARG] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DRETURNDATE是否为空。
		/// 
        public bool IsDRETURNDATENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnDRETURNDATE);
        }

		/// 
		/// 设置字段DRETURNDATE为空值。
		/// 
        public void SetDRETURNDATENull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnDRETURNDATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VIDTYPE是否为空。
		/// 
        public bool IsVIDTYPENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVIDTYPE);
        }

		/// 
		/// 设置字段VIDTYPE为空值。
		/// 
        public void SetVIDTYPENull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVIDTYPE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VIDNO是否为空。
		/// 
        public bool IsVIDNONull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVIDNO);
        }

		/// 
		/// 设置字段VIDNO为空值。
		/// 
        public void SetVIDNONull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVIDNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VRETURNID是否为空。
		/// 
        public bool IsVRETURNIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVRETURNID);
        }

		/// 
		/// 设置字段VRETURNID为空值。
		/// 
        public void SetVRETURNIDNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVRETURNID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NMODEID是否为空。
		/// 
        public bool IsNMODEIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNMODEID);
        }

		/// 
		/// 设置字段NMODEID为空值。
		/// 
        public void SetNMODEIDNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNMODEID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VCARDNO是否为空。
		/// 
        public bool IsVCARDNONull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVCARDNO);
        }

		/// 
		/// 设置字段VCARDNO为空值。
		/// 
        public void SetVCARDNONull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVCARDNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DACCTDATETI是否为空。
		/// 
        public bool IsDACCTDATETINull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnDACCTDATETI);
        }

		/// 
		/// 设置字段DACCTDATETI为空值。
		/// 
        public void SetDACCTDATETINull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnDACCTDATETI] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DACCTNO是否为空。
		/// 
        public bool IsDACCTNONull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnDACCTNO);
        }

		/// 
		/// 设置字段DACCTNO为空值。
		/// 
        public void SetDACCTNONull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnDACCTNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NMRPROVIDEDINDICATOR是否为空。
		/// 
        public bool IsNMRPROVIDEDINDICATORNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNMRPROVIDEDINDICATOR);
        }

		/// 
		/// 设置字段NMRPROVIDEDINDICATOR为空值。
		/// 
        public void SetNMRPROVIDEDINDICATORNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNMRPROVIDEDINDICATOR] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VAPPOINTSID是否为空。
		/// 
        public bool IsVAPPOINTSIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVAPPOINTSID);
        }

		/// 
		/// 设置字段VAPPOINTSID为空值。
		/// 
        public void SetVAPPOINTSIDNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVAPPOINTSID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VREMARKS是否为空。
		/// 
        public bool IsVREMARKSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVREMARKS);
        }

		/// 
		/// 设置字段VREMARKS为空值。
		/// 
        public void SetVREMARKSNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVREMARKS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VNATION是否为空。
		/// 
        public bool IsVNATIONNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVNATION);
        }

		/// 
		/// 设置字段VNATION为空值。
		/// 
        public void SetVNATIONNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVNATION] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VNATIVEPLACE是否为空。
		/// 
        public bool IsVNATIVEPLACENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVNATIVEPLACE);
        }

		/// 
		/// 设置字段VNATIVEPLACE为空值。
		/// 
        public void SetVNATIVEPLACENull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVNATIVEPLACE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPRESENTADDRESS是否为空。
		/// 
        public bool IsVPRESENTADDRESSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVPRESENTADDRESS);
        }

		/// 
		/// 设置字段VPRESENTADDRESS为空值。
		/// 
        public void SetVPRESENTADDRESSNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVPRESENTADDRESS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VLINKMAN是否为空。
		/// 
        public bool IsVLINKMANNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVLINKMAN);
        }

		/// 
		/// 设置字段VLINKMAN为空值。
		/// 
        public void SetVLINKMANNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVLINKMAN] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPHONE是否为空。
		/// 
        public bool IsVPHONENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVPHONE);
        }

		/// 
		/// 设置字段VPHONE为空值。
		/// 
        public void SetVPHONENull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVPHONE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NKA是否为空。
		/// 
        public bool IsNKANull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNKA);
        }

		/// 
		/// 设置字段NKA为空值。
		/// 
        public void SetNKANull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNKA] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NPROFESSIONID是否为空。
		/// 
        public bool IsNPROFESSIONIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNPROFESSIONID);
        }

		/// 
		/// 设置字段NPROFESSIONID为空值。
		/// 
        public void SetNPROFESSIONIDNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNPROFESSIONID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NDICGHTYPE是否为空。
		/// 
        public bool IsNDICGHTYPENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNDICGHTYPE);
        }

		/// 
		/// 设置字段NDICGHTYPE为空值。
		/// 
        public void SetNDICGHTYPENull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNDICGHTYPE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VBSETCARD是否为空。
		/// 
        public bool IsVBSETCARDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVBSETCARD);
        }

		/// 
		/// 设置字段VBSETCARD为空值。
		/// 
        public void SetVBSETCARDNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVBSETCARD] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段PERSONACCOUNTINFO是否为空。
		/// 
        public bool IsPERSONACCOUNTINFONull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnPERSONACCOUNTINFO);
        }

		/// 
		/// 设置字段PERSONACCOUNTINFO为空值。
		/// 
        public void SetPERSONACCOUNTINFONull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnPERSONACCOUNTINFO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段YBGRBH是否为空。
		/// 
        public bool IsYBGRBHNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnYBGRBH);
        }

		/// 
		/// 设置字段YBGRBH为空值。
		/// 
        public void SetYBGRBHNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnYBGRBH] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCHARGE是否为空。
		/// 
        public bool IsNCHARGENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNCHARGE);
        }

		/// 
		/// 设置字段NCHARGE为空值。
		/// 
        public void SetNCHARGENull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNCHARGE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NHOSID是否为空。
		/// 
        public bool IsNHOSIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNHOSID);
        }

		/// 
		/// 设置字段NHOSID为空值。
		/// 
        public void SetNHOSIDNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNHOSID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段PURCHASINGPERSONNAME是否为空。
		/// 
        public bool IsPURCHASINGPERSONNAMENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnPURCHASINGPERSONNAME);
        }

		/// 
		/// 设置字段PURCHASINGPERSONNAME为空值。
		/// 
        public void SetPURCHASINGPERSONNAMENull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnPURCHASINGPERSONNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段PURCHASINGPERSONVIDNO是否为空。
		/// 
        public bool IsPURCHASINGPERSONVIDNONull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnPURCHASINGPERSONVIDNO);
        }

		/// 
		/// 设置字段PURCHASINGPERSONVIDNO为空值。
		/// 
        public void SetPURCHASINGPERSONVIDNONull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnPURCHASINGPERSONVIDNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段PURCHASINGPERSONVPHONE是否为空。
		/// 
        public bool IsPURCHASINGPERSONVPHONENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnPURCHASINGPERSONVPHONE);
        }

		/// 
		/// 设置字段PURCHASINGPERSONVPHONE为空值。
		/// 
        public void SetPURCHASINGPERSONVPHONENull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnPURCHASINGPERSONVPHONE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段RELATIONSHIPWITHPATIENTS是否为空。
		/// 
        public bool IsRELATIONSHIPWITHPATIENTSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnRELATIONSHIPWITHPATIENTS);
        }

		/// 
		/// 设置字段RELATIONSHIPWITHPATIENTS为空值。
		/// 
        public void SetRELATIONSHIPWITHPATIENTSNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnRELATIONSHIPWITHPATIENTS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段YBLX是否为空。
		/// 
        public bool IsYBLXNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnYBLX);
        }

		/// 
		/// 设置字段YBLX为空值。
		/// 
        public void SetYBLXNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnYBLX] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NDICAREAID是否为空。
		/// 
        public bool IsNDICAREAIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNDICAREAID);
        }

		/// 
		/// 设置字段NDICAREAID为空值。
		/// 
        public void SetNDICAREAIDNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNDICAREAID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NHREGNO是否为空。
		/// 
        public bool IsNHREGNONull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNHREGNO);
        }

		/// 
		/// 设置字段NHREGNO为空值。
		/// 
        public void SetNHREGNONull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNHREGNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段BCJSFF是否为空。
		/// 
        public bool IsBCJSFFNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnBCJSFF);
        }

		/// 
		/// 设置字段BCJSFF为空值。
		/// 
        public void SetBCJSFFNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnBCJSFF] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NHLYZT是否为空。
		/// 
        public bool IsNHLYZTNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnNHLYZT);
        }

		/// 
		/// 设置字段NHLYZT为空值。
		/// 
        public void SetNHLYZTNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnNHLYZT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段JSDISEASE是否为空。
		/// 
        public bool IsJSDISEASENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnJSDISEASE);
        }

		/// 
		/// 设置字段JSDISEASE为空值。
		/// 
        public void SetJSDISEASENull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnJSDISEASE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VFIRST_VISITDEPT是否为空。
		/// 
        public bool IsVFIRST_VISITDEPTNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVFIRST_VISITDEPT);
        }

		/// 
		/// 设置字段VFIRST_VISITDEPT为空值。
		/// 
        public void SetVFIRST_VISITDEPTNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVFIRST_VISITDEPT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VFIRST_DOCTOR是否为空。
		/// 
        public bool IsVFIRST_DOCTORNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGHIS.ColumnVFIRST_DOCTOR);
        }

		/// 
		/// 设置字段VFIRST_DOCTOR为空值。
		/// 
        public void SetVFIRST_DOCTORNull() 
        {
            this[this.tableGHSF_GHSF_REGHIS.ColumnVFIRST_DOCTOR] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventGHSF_GHSF_REGHIS : EventArgs {
        
        private RowGHSF_GHSF_REGHIS eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventGHSF_GHSF_REGHIS(RowGHSF_GHSF_REGHIS row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowGHSF_GHSF_REGHIS Row {
            get {
                return this.eventRow;
            }
        }
        
        public DataRowAction Action {
            get {
                return this.eventAction;
            }
        }
    }
	#endregion
    
	#endregion
}	
	