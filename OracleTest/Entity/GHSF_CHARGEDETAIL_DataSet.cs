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
	#region DataSetGHSF_CHARGEDETAIL
	/// 
	/// 对于GHSF_CHARGEDETAIL的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetGHSF_CHARGEDETAIL : DataSet
    {
		
		private DataTableGHSF_GHSF_CHARGEDETAIL tableGHSF_GHSF_CHARGEDETAIL;
		
        public DataSetGHSF_CHARGEDETAIL() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetGHSF_CHARGEDETAIL实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetGHSF_CHARGEDETAIL GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetGHSF_CHARGEDETAIL dataSet = (DataSetGHSF_CHARGEDETAIL)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetGHSF_CHARGEDETAIL entity = new DataSetGHSF_CHARGEDETAIL();
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
        
        protected DataSetGHSF_CHARGEDETAIL(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["GHSF_GHSF_CHARGEDETAIL"] != null)) 
                {
                    this.Tables.Add(new DataTableGHSF_GHSF_CHARGEDETAIL(ds.Tables["GHSF_GHSF_CHARGEDETAIL"]));
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
		/// 对于数据表GHSF_GHSF_CHARGEDETAIL的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableGHSF_GHSF_CHARGEDETAIL GHSF_GHSF_CHARGEDETAIL 
		{
			get
			{
				return this.tableGHSF_GHSF_CHARGEDETAIL;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetGHSF_CHARGEDETAIL cln = ((DataSetGHSF_CHARGEDETAIL)(base.Clone()));
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
			
			if ((ds.Tables["GHSF_GHSF_CHARGEDETAIL"] != null)) 
			{
				this.Tables.Add(new DataTableGHSF_GHSF_CHARGEDETAIL(ds.Tables["GHSF_GHSF_CHARGEDETAIL"]));
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
			
			this.tableGHSF_GHSF_CHARGEDETAIL = ((DataTableGHSF_GHSF_CHARGEDETAIL)(this.Tables["GHSF_GHSF_CHARGEDETAIL"]));
			if ((this.tableGHSF_GHSF_CHARGEDETAIL != null)) {
				this.tableGHSF_GHSF_CHARGEDETAIL.InitVars();
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
			
			this.tableGHSF_GHSF_CHARGEDETAIL = new DataTableGHSF_GHSF_CHARGEDETAIL();
			this.Tables.Add(this.tableGHSF_GHSF_CHARGEDETAIL);
			
		}
		
		private bool ShouldSerializeGHSF_GHSF_CHARGEDETAIL() 
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
	
    public delegate void RowChangeEventHandlerGHSF_GHSF_CHARGEDETAIL(object sender, RowChangeEventGHSF_GHSF_CHARGEDETAIL e);
	
	#region DataTableGHSF_GHSF_CHARGEDETAIL
	/// 
	/// 对于数据表GHSF_GHSF_CHARGEDETAIL的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableGHSF_GHSF_CHARGEDETAIL : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVRCPTDETAILID;
		
        private DataColumn columnVRCPTID;
		
        private DataColumn columnVPRESC_ID;
		
        private DataColumn columnVITEM_CODE;
		
        private DataColumn columnVITEM_NAME;
		
        private DataColumn columnVITEM_SPEC;
		
        private DataColumn columnVUNITS;
		
        private DataColumn columnNACCOUNT;
		
        private DataColumn columnNDOSAGE;
		
        private DataColumn columnVDOSAGE_UNITS;
		
        private DataColumn columnVADMINISTRATION;
		
        private DataColumn columnVFREQUENCY;
		
        private DataColumn columnNDAYS;
		
        private DataColumn columnNPRICE;
		
        private DataColumn columnNCOSTS;
		
        private DataColumn columnVITEM_PRODUCT;
		
        private DataColumn columnNSALESCALE;
		
        private DataColumn columnNCHARGEFLAG;
		
        private DataColumn columnNMEDICINEFLAG;
		
        private DataColumn columnDMEDICINEDATE;
		
        private DataColumn columnNBACKDRUGFLAG;
		
        private DataColumn columnDBACKDRUGDATE;
		
        private DataColumn columnNHAVMED;
		
        private DataColumn columnVREMARKS;
		
        private DataColumn columnNACCT_MODE1;
		
        private DataColumn columnNACCT_MODE2;
		
        private DataColumn columnNACCT_MONEY1;
		
        private DataColumn columnNACCT_MONEY2;
		
        private DataColumn columnVPRINTEDRCPTNO;
		
        private DataColumn columnVDRUG_STORAGE;
		
        private DataColumn columnNTOTALCHARGES;
		
        private DataColumn columnVITEM_TYPE;
		
        private DataColumn columnNPRESC;
		
        private DataColumn columnNCOUNT;
		
        private DataColumn columnVISSELF;
		
        private DataColumn columnVDEPT_CODE;
		
        private DataColumn columnNDICTDETAIL_ID;
		
        internal DataTableGHSF_GHSF_CHARGEDETAIL() : base("GHSF_GHSF_CHARGEDETAIL") 
        {
            this.InitClass();
        }
        
        internal DataTableGHSF_GHSF_CHARGEDETAIL(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVRCPTDETAILID 
        {
            get 
            {
                return this.columnVRCPTDETAILID;
            }
        }
		
        public DataColumn ColumnVRCPTID 
        {
            get 
            {
                return this.columnVRCPTID;
            }
        }
		
        public DataColumn ColumnVPRESC_ID 
        {
            get 
            {
                return this.columnVPRESC_ID;
            }
        }
		
        public DataColumn ColumnVITEM_CODE 
        {
            get 
            {
                return this.columnVITEM_CODE;
            }
        }
		
        public DataColumn ColumnVITEM_NAME 
        {
            get 
            {
                return this.columnVITEM_NAME;
            }
        }
		
        public DataColumn ColumnVITEM_SPEC 
        {
            get 
            {
                return this.columnVITEM_SPEC;
            }
        }
		
        public DataColumn ColumnVUNITS 
        {
            get 
            {
                return this.columnVUNITS;
            }
        }
		
        public DataColumn ColumnNACCOUNT 
        {
            get 
            {
                return this.columnNACCOUNT;
            }
        }
		
        public DataColumn ColumnNDOSAGE 
        {
            get 
            {
                return this.columnNDOSAGE;
            }
        }
		
        public DataColumn ColumnVDOSAGE_UNITS 
        {
            get 
            {
                return this.columnVDOSAGE_UNITS;
            }
        }
		
        public DataColumn ColumnVADMINISTRATION 
        {
            get 
            {
                return this.columnVADMINISTRATION;
            }
        }
		
        public DataColumn ColumnVFREQUENCY 
        {
            get 
            {
                return this.columnVFREQUENCY;
            }
        }
		
        public DataColumn ColumnNDAYS 
        {
            get 
            {
                return this.columnNDAYS;
            }
        }
		
        public DataColumn ColumnNPRICE 
        {
            get 
            {
                return this.columnNPRICE;
            }
        }
		
        public DataColumn ColumnNCOSTS 
        {
            get 
            {
                return this.columnNCOSTS;
            }
        }
		
        public DataColumn ColumnVITEM_PRODUCT 
        {
            get 
            {
                return this.columnVITEM_PRODUCT;
            }
        }
		
        public DataColumn ColumnNSALESCALE 
        {
            get 
            {
                return this.columnNSALESCALE;
            }
        }
		
        public DataColumn ColumnNCHARGEFLAG 
        {
            get 
            {
                return this.columnNCHARGEFLAG;
            }
        }
		
        public DataColumn ColumnNMEDICINEFLAG 
        {
            get 
            {
                return this.columnNMEDICINEFLAG;
            }
        }
		
        public DataColumn ColumnDMEDICINEDATE 
        {
            get 
            {
                return this.columnDMEDICINEDATE;
            }
        }
		
        public DataColumn ColumnNBACKDRUGFLAG 
        {
            get 
            {
                return this.columnNBACKDRUGFLAG;
            }
        }
		
        public DataColumn ColumnDBACKDRUGDATE 
        {
            get 
            {
                return this.columnDBACKDRUGDATE;
            }
        }
		
        public DataColumn ColumnNHAVMED 
        {
            get 
            {
                return this.columnNHAVMED;
            }
        }
		
        public DataColumn ColumnVREMARKS 
        {
            get 
            {
                return this.columnVREMARKS;
            }
        }
		
        public DataColumn ColumnNACCT_MODE1 
        {
            get 
            {
                return this.columnNACCT_MODE1;
            }
        }
		
        public DataColumn ColumnNACCT_MODE2 
        {
            get 
            {
                return this.columnNACCT_MODE2;
            }
        }
		
        public DataColumn ColumnNACCT_MONEY1 
        {
            get 
            {
                return this.columnNACCT_MONEY1;
            }
        }
		
        public DataColumn ColumnNACCT_MONEY2 
        {
            get 
            {
                return this.columnNACCT_MONEY2;
            }
        }
		
        public DataColumn ColumnVPRINTEDRCPTNO 
        {
            get 
            {
                return this.columnVPRINTEDRCPTNO;
            }
        }
		
        public DataColumn ColumnVDRUG_STORAGE 
        {
            get 
            {
                return this.columnVDRUG_STORAGE;
            }
        }
		
        public DataColumn ColumnNTOTALCHARGES 
        {
            get 
            {
                return this.columnNTOTALCHARGES;
            }
        }
		
        public DataColumn ColumnVITEM_TYPE 
        {
            get 
            {
                return this.columnVITEM_TYPE;
            }
        }
		
        public DataColumn ColumnNPRESC 
        {
            get 
            {
                return this.columnNPRESC;
            }
        }
		
        public DataColumn ColumnNCOUNT 
        {
            get 
            {
                return this.columnNCOUNT;
            }
        }
		
        public DataColumn ColumnVISSELF 
        {
            get 
            {
                return this.columnVISSELF;
            }
        }
		
        public DataColumn ColumnVDEPT_CODE 
        {
            get 
            {
                return this.columnVDEPT_CODE;
            }
        }
		
        public DataColumn ColumnNDICTDETAIL_ID 
        {
            get 
            {
                return this.columnNDICTDETAIL_ID;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowGHSF_GHSF_CHARGEDETAIL this[int index] 
        {
            get 
            {
                return ((RowGHSF_GHSF_CHARGEDETAIL)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerGHSF_GHSF_CHARGEDETAIL RowChangedGHSF_GHSF_CHARGEDETAIL;
        
        public event RowChangeEventHandlerGHSF_GHSF_CHARGEDETAIL RowChangingGHSF_GHSF_CHARGEDETAIL;
        
        public event RowChangeEventHandlerGHSF_GHSF_CHARGEDETAIL RowDeletedGHSF_GHSF_CHARGEDETAIL;
        
        public event RowChangeEventHandlerGHSF_GHSF_CHARGEDETAIL RowDeletingGHSF_GHSF_CHARGEDETAIL;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowGHSF_GHSF_CHARGEDETAIL(RowGHSF_GHSF_CHARGEDETAIL row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowGHSF_GHSF_CHARGEDETAIL AddRowGHSF_GHSF_CHARGEDETAIL(System.String VRCPTDETAILID,System.String VRCPTID,System.String VPRESC_ID,System.String VITEM_CODE,System.String VITEM_NAME,System.String VITEM_SPEC,System.String VUNITS,System.Decimal NACCOUNT,System.Decimal NDOSAGE,System.String VDOSAGE_UNITS,System.String VADMINISTRATION,System.String VFREQUENCY,System.Int16 NDAYS,System.Decimal NPRICE,System.Decimal NCOSTS,System.String VITEM_PRODUCT,System.Decimal NSALESCALE,System.Int16 NCHARGEFLAG,System.Int16 NMEDICINEFLAG,System.DateTime DMEDICINEDATE,System.Int16 NBACKDRUGFLAG,System.DateTime DBACKDRUGDATE,System.Int16 NHAVMED,System.String VREMARKS,System.Int32 NACCT_MODE1,System.Int32 NACCT_MODE2,System.Decimal NACCT_MONEY1,System.Decimal NACCT_MONEY2,System.String VPRINTEDRCPTNO,System.String VDRUG_STORAGE,System.Decimal NTOTALCHARGES,System.String VITEM_TYPE,System.Int16 NPRESC,System.Int16 NCOUNT,System.Int16 VISSELF,System.String VDEPT_CODE,System.String NDICTDETAIL_ID) 
        {
            RowGHSF_GHSF_CHARGEDETAIL row = ((RowGHSF_GHSF_CHARGEDETAIL)(this.NewRow()));
            row.ItemArray = new object[] {VRCPTDETAILID,VRCPTID,VPRESC_ID,VITEM_CODE,VITEM_NAME,VITEM_SPEC,VUNITS,NACCOUNT,NDOSAGE,VDOSAGE_UNITS,VADMINISTRATION,VFREQUENCY,NDAYS,NPRICE,NCOSTS,VITEM_PRODUCT,NSALESCALE,NCHARGEFLAG,NMEDICINEFLAG,DMEDICINEDATE,NBACKDRUGFLAG,DBACKDRUGDATE,NHAVMED,VREMARKS,NACCT_MODE1,NACCT_MODE2,NACCT_MONEY1,NACCT_MONEY2,VPRINTEDRCPTNO,VDRUG_STORAGE,NTOTALCHARGES,VITEM_TYPE,NPRESC,NCOUNT,VISSELF,VDEPT_CODE,NDICTDETAIL_ID};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowGHSF_GHSF_CHARGEDETAIL FindByVRCPTDETAILID(System.String VRCPTDETAILID) {
            return ((RowGHSF_GHSF_CHARGEDETAIL)(this.Rows.Find(new object[] {
                        VRCPTDETAILID})));
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
            DataTableGHSF_GHSF_CHARGEDETAIL cln = ((DataTableGHSF_GHSF_CHARGEDETAIL)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableGHSF_GHSF_CHARGEDETAIL();
        }
        
        internal void InitVars() 
        {	
            this.columnVRCPTDETAILID = this.Columns["VRCPTDETAILID"];
            this.columnVRCPTID = this.Columns["VRCPTID"];
            this.columnVPRESC_ID = this.Columns["VPRESC_ID"];
            this.columnVITEM_CODE = this.Columns["VITEM_CODE"];
            this.columnVITEM_NAME = this.Columns["VITEM_NAME"];
            this.columnVITEM_SPEC = this.Columns["VITEM_SPEC"];
            this.columnVUNITS = this.Columns["VUNITS"];
            this.columnNACCOUNT = this.Columns["NACCOUNT"];
            this.columnNDOSAGE = this.Columns["NDOSAGE"];
            this.columnVDOSAGE_UNITS = this.Columns["VDOSAGE_UNITS"];
            this.columnVADMINISTRATION = this.Columns["VADMINISTRATION"];
            this.columnVFREQUENCY = this.Columns["VFREQUENCY"];
            this.columnNDAYS = this.Columns["NDAYS"];
            this.columnNPRICE = this.Columns["NPRICE"];
            this.columnNCOSTS = this.Columns["NCOSTS"];
            this.columnVITEM_PRODUCT = this.Columns["VITEM_PRODUCT"];
            this.columnNSALESCALE = this.Columns["NSALESCALE"];
            this.columnNCHARGEFLAG = this.Columns["NCHARGEFLAG"];
            this.columnNMEDICINEFLAG = this.Columns["NMEDICINEFLAG"];
            this.columnDMEDICINEDATE = this.Columns["DMEDICINEDATE"];
            this.columnNBACKDRUGFLAG = this.Columns["NBACKDRUGFLAG"];
            this.columnDBACKDRUGDATE = this.Columns["DBACKDRUGDATE"];
            this.columnNHAVMED = this.Columns["NHAVMED"];
            this.columnVREMARKS = this.Columns["VREMARKS"];
            this.columnNACCT_MODE1 = this.Columns["NACCT_MODE1"];
            this.columnNACCT_MODE2 = this.Columns["NACCT_MODE2"];
            this.columnNACCT_MONEY1 = this.Columns["NACCT_MONEY1"];
            this.columnNACCT_MONEY2 = this.Columns["NACCT_MONEY2"];
            this.columnVPRINTEDRCPTNO = this.Columns["VPRINTEDRCPTNO"];
            this.columnVDRUG_STORAGE = this.Columns["VDRUG_STORAGE"];
            this.columnNTOTALCHARGES = this.Columns["NTOTALCHARGES"];
            this.columnVITEM_TYPE = this.Columns["VITEM_TYPE"];
            this.columnNPRESC = this.Columns["NPRESC"];
            this.columnNCOUNT = this.Columns["NCOUNT"];
            this.columnVISSELF = this.Columns["VISSELF"];
            this.columnVDEPT_CODE = this.Columns["VDEPT_CODE"];
            this.columnNDICTDETAIL_ID = this.Columns["NDICTDETAIL_ID"];
        }
        
        private void InitClass() 
        {	
            this.columnVRCPTDETAILID = new DataColumn("VRCPTDETAILID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVRCPTDETAILID.MaxLength = 10;
            this.columnVRCPTDETAILID.AllowDBNull = false;
            this.columnVRCPTDETAILID.Unique = true;
            
            this.Columns.Add(this.columnVRCPTDETAILID);
			
            this.columnVRCPTID = new DataColumn("VRCPTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVRCPTID.MaxLength = 10;
            this.columnVRCPTID.AllowDBNull = false;
            this.Columns.Add(this.columnVRCPTID);
			
            this.columnVPRESC_ID = new DataColumn("VPRESC_ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPRESC_ID.MaxLength = 10;
            this.columnVPRESC_ID.AllowDBNull = false;
            this.Columns.Add(this.columnVPRESC_ID);
			
            this.columnVITEM_CODE = new DataColumn("VITEM_CODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEM_CODE.MaxLength = 30;
            this.columnVITEM_CODE.AllowDBNull = false;
            this.Columns.Add(this.columnVITEM_CODE);
			
            this.columnVITEM_NAME = new DataColumn("VITEM_NAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEM_NAME.MaxLength = 50;
            this.columnVITEM_NAME.AllowDBNull = false;
            this.Columns.Add(this.columnVITEM_NAME);
			
            this.columnVITEM_SPEC = new DataColumn("VITEM_SPEC", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEM_SPEC.MaxLength = 20;
            this.columnVITEM_SPEC.AllowDBNull = true;
            this.Columns.Add(this.columnVITEM_SPEC);
			
            this.columnVUNITS = new DataColumn("VUNITS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVUNITS.MaxLength = 10;
            this.columnVUNITS.AllowDBNull = true;
            this.Columns.Add(this.columnVUNITS);
			
            this.columnNACCOUNT = new DataColumn("NACCOUNT", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNACCOUNT.AllowDBNull = false;
            this.Columns.Add(this.columnNACCOUNT);
			
            this.columnNDOSAGE = new DataColumn("NDOSAGE", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNDOSAGE.AllowDBNull = true;
            this.Columns.Add(this.columnNDOSAGE);
			
            this.columnVDOSAGE_UNITS = new DataColumn("VDOSAGE_UNITS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDOSAGE_UNITS.MaxLength = 20;
            this.columnVDOSAGE_UNITS.AllowDBNull = true;
            this.Columns.Add(this.columnVDOSAGE_UNITS);
			
            this.columnVADMINISTRATION = new DataColumn("VADMINISTRATION", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVADMINISTRATION.MaxLength = 10;
            this.columnVADMINISTRATION.AllowDBNull = true;
            this.Columns.Add(this.columnVADMINISTRATION);
			
            this.columnVFREQUENCY = new DataColumn("VFREQUENCY", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVFREQUENCY.MaxLength = 20;
            this.columnVFREQUENCY.AllowDBNull = true;
            this.Columns.Add(this.columnVFREQUENCY);
			
            this.columnNDAYS = new DataColumn("NDAYS", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNDAYS.AllowDBNull = true;
            this.Columns.Add(this.columnNDAYS);
			
            this.columnNPRICE = new DataColumn("NPRICE", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNPRICE.AllowDBNull = false;
            this.Columns.Add(this.columnNPRICE);
			
            this.columnNCOSTS = new DataColumn("NCOSTS", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNCOSTS.AllowDBNull = false;
            this.Columns.Add(this.columnNCOSTS);
			
            this.columnVITEM_PRODUCT = new DataColumn("VITEM_PRODUCT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEM_PRODUCT.MaxLength = 60;
            this.columnVITEM_PRODUCT.AllowDBNull = true;
            this.Columns.Add(this.columnVITEM_PRODUCT);
			
            this.columnNSALESCALE = new DataColumn("NSALESCALE", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNSALESCALE.AllowDBNull = true;
            this.Columns.Add(this.columnNSALESCALE);
			
            this.columnNCHARGEFLAG = new DataColumn("NCHARGEFLAG", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNCHARGEFLAG.DefaultValue = "1";
            this.columnNCHARGEFLAG.AllowDBNull = true;
            this.Columns.Add(this.columnNCHARGEFLAG);
			
            this.columnNMEDICINEFLAG = new DataColumn("NMEDICINEFLAG", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNMEDICINEFLAG.DefaultValue = "0";
            this.columnNMEDICINEFLAG.AllowDBNull = true;
            this.Columns.Add(this.columnNMEDICINEFLAG);
			
            this.columnDMEDICINEDATE = new DataColumn("DMEDICINEDATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDMEDICINEDATE.AllowDBNull = true;
            this.Columns.Add(this.columnDMEDICINEDATE);
			
            this.columnNBACKDRUGFLAG = new DataColumn("NBACKDRUGFLAG", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNBACKDRUGFLAG.DefaultValue = "0";
            this.columnNBACKDRUGFLAG.AllowDBNull = true;
            this.Columns.Add(this.columnNBACKDRUGFLAG);
			
            this.columnDBACKDRUGDATE = new DataColumn("DBACKDRUGDATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDBACKDRUGDATE.AllowDBNull = true;
            this.Columns.Add(this.columnDBACKDRUGDATE);
			
            this.columnNHAVMED = new DataColumn("NHAVMED", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNHAVMED.AllowDBNull = true;
            this.Columns.Add(this.columnNHAVMED);
			
            this.columnVREMARKS = new DataColumn("VREMARKS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVREMARKS.MaxLength = 50;
            this.columnVREMARKS.AllowDBNull = true;
            this.Columns.Add(this.columnVREMARKS);
			
            this.columnNACCT_MODE1 = new DataColumn("NACCT_MODE1", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNACCT_MODE1.AllowDBNull = false;
            this.Columns.Add(this.columnNACCT_MODE1);
			
            this.columnNACCT_MODE2 = new DataColumn("NACCT_MODE2", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNACCT_MODE2.AllowDBNull = true;
            this.Columns.Add(this.columnNACCT_MODE2);
			
            this.columnNACCT_MONEY1 = new DataColumn("NACCT_MONEY1", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNACCT_MONEY1.AllowDBNull = false;
            this.Columns.Add(this.columnNACCT_MONEY1);
			
            this.columnNACCT_MONEY2 = new DataColumn("NACCT_MONEY2", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNACCT_MONEY2.AllowDBNull = true;
            this.Columns.Add(this.columnNACCT_MONEY2);
			
            this.columnVPRINTEDRCPTNO = new DataColumn("VPRINTEDRCPTNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPRINTEDRCPTNO.MaxLength = 20;
            this.columnVPRINTEDRCPTNO.AllowDBNull = false;
            this.Columns.Add(this.columnVPRINTEDRCPTNO);
			
            this.columnVDRUG_STORAGE = new DataColumn("VDRUG_STORAGE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDRUG_STORAGE.MaxLength = 10;
            this.columnVDRUG_STORAGE.AllowDBNull = true;
            this.Columns.Add(this.columnVDRUG_STORAGE);
			
            this.columnNTOTALCHARGES = new DataColumn("NTOTALCHARGES", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNTOTALCHARGES.AllowDBNull = true;
            this.Columns.Add(this.columnNTOTALCHARGES);
			
            this.columnVITEM_TYPE = new DataColumn("VITEM_TYPE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEM_TYPE.MaxLength = 20;
            this.columnVITEM_TYPE.AllowDBNull = true;
            this.Columns.Add(this.columnVITEM_TYPE);
			
            this.columnNPRESC = new DataColumn("NPRESC", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNPRESC.AllowDBNull = true;
            this.Columns.Add(this.columnNPRESC);
			
            this.columnNCOUNT = new DataColumn("NCOUNT", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNCOUNT.AllowDBNull = true;
            this.Columns.Add(this.columnNCOUNT);
			
            this.columnVISSELF = new DataColumn("VISSELF", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnVISSELF.DefaultValue = "0";
            this.columnVISSELF.AllowDBNull = true;
            this.Columns.Add(this.columnVISSELF);
			
            this.columnVDEPT_CODE = new DataColumn("VDEPT_CODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPT_CODE.MaxLength = 50;
            this.columnVDEPT_CODE.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPT_CODE);
			
            this.columnNDICTDETAIL_ID = new DataColumn("NDICTDETAIL_ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNDICTDETAIL_ID.MaxLength = 30;
            this.columnNDICTDETAIL_ID.AllowDBNull = true;
            this.Columns.Add(this.columnNDICTDETAIL_ID);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowGHSF_GHSF_CHARGEDETAIL NewRowGHSF_GHSF_CHARGEDETAIL() {
            return ((RowGHSF_GHSF_CHARGEDETAIL)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowGHSF_GHSF_CHARGEDETAIL(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowGHSF_GHSF_CHARGEDETAIL);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedGHSF_GHSF_CHARGEDETAIL != null)) {
                this.RowChangedGHSF_GHSF_CHARGEDETAIL(this, new RowChangeEventGHSF_GHSF_CHARGEDETAIL(((RowGHSF_GHSF_CHARGEDETAIL)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingGHSF_GHSF_CHARGEDETAIL != null)) {
                this.RowChangingGHSF_GHSF_CHARGEDETAIL(this, new RowChangeEventGHSF_GHSF_CHARGEDETAIL(((RowGHSF_GHSF_CHARGEDETAIL)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedGHSF_GHSF_CHARGEDETAIL != null)) {
                this.RowDeletedGHSF_GHSF_CHARGEDETAIL(this, new RowChangeEventGHSF_GHSF_CHARGEDETAIL(((RowGHSF_GHSF_CHARGEDETAIL)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingGHSF_GHSF_CHARGEDETAIL != null)) {
                this.RowDeletingGHSF_GHSF_CHARGEDETAIL(this, new RowChangeEventGHSF_GHSF_CHARGEDETAIL(((RowGHSF_GHSF_CHARGEDETAIL)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowGHSF_GHSF_CHARGEDETAIL(RowGHSF_GHSF_CHARGEDETAIL row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowGHSF_GHSF_CHARGEDETAIL
	/// 
	/// 数据表GHSF_GHSF_CHARGEDETAIL行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowGHSF_GHSF_CHARGEDETAIL : DataRow 
    {
        
        private DataTableGHSF_GHSF_CHARGEDETAIL tableGHSF_GHSF_CHARGEDETAIL;
        
        internal RowGHSF_GHSF_CHARGEDETAIL(DataRowBuilder rb) : base(rb) 
        {
            this.tableGHSF_GHSF_CHARGEDETAIL = ((DataTableGHSF_GHSF_CHARGEDETAIL)(this.Table));
        }        
		
		/// 
		/// 字段VRCPTDETAILID所映射的属性。
		/// 
        public System.String VRCPTDETAILID
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVRCPTDETAILID])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVRCPTDETAILID] = value;
            }
        }
        
		/// 
		/// 字段VRCPTID所映射的属性。
		/// 
        public System.String VRCPTID
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVRCPTID])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVRCPTID] = value;
            }
        }
        
		/// 
		/// 字段VPRESC_ID所映射的属性。
		/// 
        public System.String VPRESC_ID
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVPRESC_ID])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVPRESC_ID] = value;
            }
        }
        
		/// 
		/// 字段VITEM_CODE所映射的属性。
		/// 
        public System.String VITEM_CODE
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVITEM_CODE])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVITEM_CODE] = value;
            }
        }
        
		/// 
		/// 字段VITEM_NAME所映射的属性。
		/// 
        public System.String VITEM_NAME
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVITEM_NAME])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVITEM_NAME] = value;
            }
        }
        
		/// 
		/// 字段VITEM_SPEC所映射的属性。
		/// 
        public System.String VITEM_SPEC
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVITEM_SPEC])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVITEM_SPEC] = value;
            }
        }
        
		/// 
		/// 字段VUNITS所映射的属性。
		/// 
        public System.String VUNITS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVUNITS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVUNITS] = value;
            }
        }
        
		/// 
		/// 字段NACCOUNT所映射的属性。
		/// 
        public System.Decimal NACCOUNT
        {
            get 
            {	
                return ((System.Decimal)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNACCOUNT])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNACCOUNT] = value;
            }
        }
        
		/// 
		/// 字段NDOSAGE所映射的属性。
		/// 
        public System.Decimal NDOSAGE
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNDOSAGE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNDOSAGE] = value;
            }
        }
        
		/// 
		/// 字段VDOSAGE_UNITS所映射的属性。
		/// 
        public System.String VDOSAGE_UNITS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVDOSAGE_UNITS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVDOSAGE_UNITS] = value;
            }
        }
        
		/// 
		/// 字段VADMINISTRATION所映射的属性。
		/// 
        public System.String VADMINISTRATION
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVADMINISTRATION])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVADMINISTRATION] = value;
            }
        }
        
		/// 
		/// 字段VFREQUENCY所映射的属性。
		/// 
        public System.String VFREQUENCY
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVFREQUENCY])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVFREQUENCY] = value;
            }
        }
        
		/// 
		/// 字段NDAYS所映射的属性。
		/// 
        public System.Int16 NDAYS
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNDAYS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNDAYS] = value;
            }
        }
        
		/// 
		/// 字段NPRICE所映射的属性。
		/// 
        public System.Decimal NPRICE
        {
            get 
            {	
                return ((System.Decimal)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNPRICE])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNPRICE] = value;
            }
        }
        
		/// 
		/// 字段NCOSTS所映射的属性。
		/// 
        public System.Decimal NCOSTS
        {
            get 
            {	
                return ((System.Decimal)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNCOSTS])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNCOSTS] = value;
            }
        }
        
		/// 
		/// 字段VITEM_PRODUCT所映射的属性。
		/// 
        public System.String VITEM_PRODUCT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVITEM_PRODUCT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVITEM_PRODUCT] = value;
            }
        }
        
		/// 
		/// 字段NSALESCALE所映射的属性。
		/// 
        public System.Decimal NSALESCALE
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNSALESCALE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNSALESCALE] = value;
            }
        }
        
		/// 
		/// 字段NCHARGEFLAG所映射的属性。
		/// 
        public System.Int16 NCHARGEFLAG
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNCHARGEFLAG])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNCHARGEFLAG] = value;
            }
        }
        
		/// 
		/// 字段NMEDICINEFLAG所映射的属性。
		/// 
        public System.Int16 NMEDICINEFLAG
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNMEDICINEFLAG])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNMEDICINEFLAG] = value;
            }
        }
        
		/// 
		/// 字段DMEDICINEDATE所映射的属性。
		/// 
        public System.DateTime DMEDICINEDATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnDMEDICINEDATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnDMEDICINEDATE] = value;
            }
        }
        
		/// 
		/// 字段NBACKDRUGFLAG所映射的属性。
		/// 
        public System.Int16 NBACKDRUGFLAG
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNBACKDRUGFLAG])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNBACKDRUGFLAG] = value;
            }
        }
        
		/// 
		/// 字段DBACKDRUGDATE所映射的属性。
		/// 
        public System.DateTime DBACKDRUGDATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnDBACKDRUGDATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnDBACKDRUGDATE] = value;
            }
        }
        
		/// 
		/// 字段NHAVMED所映射的属性。
		/// 
        public System.Int16 NHAVMED
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNHAVMED])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNHAVMED] = value;
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
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVREMARKS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVREMARKS] = value;
            }
        }
        
		/// 
		/// 字段NACCT_MODE1所映射的属性。
		/// 
        public System.Int32 NACCT_MODE1
        {
            get 
            {	
                return ((System.Int32)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNACCT_MODE1])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNACCT_MODE1] = value;
            }
        }
        
		/// 
		/// 字段NACCT_MODE2所映射的属性。
		/// 
        public System.Int32 NACCT_MODE2
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNACCT_MODE2])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNACCT_MODE2] = value;
            }
        }
        
		/// 
		/// 字段NACCT_MONEY1所映射的属性。
		/// 
        public System.Decimal NACCT_MONEY1
        {
            get 
            {	
                return ((System.Decimal)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNACCT_MONEY1])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNACCT_MONEY1] = value;
            }
        }
        
		/// 
		/// 字段NACCT_MONEY2所映射的属性。
		/// 
        public System.Decimal NACCT_MONEY2
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNACCT_MONEY2])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNACCT_MONEY2] = value;
            }
        }
        
		/// 
		/// 字段VPRINTEDRCPTNO所映射的属性。
		/// 
        public System.String VPRINTEDRCPTNO
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVPRINTEDRCPTNO])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVPRINTEDRCPTNO] = value;
            }
        }
        
		/// 
		/// 字段VDRUG_STORAGE所映射的属性。
		/// 
        public System.String VDRUG_STORAGE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVDRUG_STORAGE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVDRUG_STORAGE] = value;
            }
        }
        
		/// 
		/// 字段NTOTALCHARGES所映射的属性。
		/// 
        public System.Decimal NTOTALCHARGES
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNTOTALCHARGES])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNTOTALCHARGES] = value;
            }
        }
        
		/// 
		/// 字段VITEM_TYPE所映射的属性。
		/// 
        public System.String VITEM_TYPE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVITEM_TYPE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVITEM_TYPE] = value;
            }
        }
        
		/// 
		/// 字段NPRESC所映射的属性。
		/// 
        public System.Int16 NPRESC
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNPRESC])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNPRESC] = value;
            }
        }
        
		/// 
		/// 字段NCOUNT所映射的属性。
		/// 
        public System.Int16 NCOUNT
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNCOUNT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNCOUNT] = value;
            }
        }
        
		/// 
		/// 字段VISSELF所映射的属性。
		/// 
        public System.Int16 VISSELF
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVISSELF])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVISSELF] = value;
            }
        }
        
		/// 
		/// 字段VDEPT_CODE所映射的属性。
		/// 
        public System.String VDEPT_CODE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVDEPT_CODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVDEPT_CODE] = value;
            }
        }
        
		/// 
		/// 字段NDICTDETAIL_ID所映射的属性。
		/// 
        public System.String NDICTDETAIL_ID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNDICTDETAIL_ID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNDICTDETAIL_ID] = value;
            }
        }
        
		/// 
		/// 判断字段VITEM_SPEC是否为空。
		/// 
        public bool IsVITEM_SPECNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVITEM_SPEC);
        }

		/// 
		/// 设置字段VITEM_SPEC为空值。
		/// 
        public void SetVITEM_SPECNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVITEM_SPEC] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VUNITS是否为空。
		/// 
        public bool IsVUNITSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVUNITS);
        }

		/// 
		/// 设置字段VUNITS为空值。
		/// 
        public void SetVUNITSNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVUNITS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NDOSAGE是否为空。
		/// 
        public bool IsNDOSAGENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNDOSAGE);
        }

		/// 
		/// 设置字段NDOSAGE为空值。
		/// 
        public void SetNDOSAGENull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNDOSAGE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDOSAGE_UNITS是否为空。
		/// 
        public bool IsVDOSAGE_UNITSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVDOSAGE_UNITS);
        }

		/// 
		/// 设置字段VDOSAGE_UNITS为空值。
		/// 
        public void SetVDOSAGE_UNITSNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVDOSAGE_UNITS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VADMINISTRATION是否为空。
		/// 
        public bool IsVADMINISTRATIONNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVADMINISTRATION);
        }

		/// 
		/// 设置字段VADMINISTRATION为空值。
		/// 
        public void SetVADMINISTRATIONNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVADMINISTRATION] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VFREQUENCY是否为空。
		/// 
        public bool IsVFREQUENCYNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVFREQUENCY);
        }

		/// 
		/// 设置字段VFREQUENCY为空值。
		/// 
        public void SetVFREQUENCYNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVFREQUENCY] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NDAYS是否为空。
		/// 
        public bool IsNDAYSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNDAYS);
        }

		/// 
		/// 设置字段NDAYS为空值。
		/// 
        public void SetNDAYSNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNDAYS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEM_PRODUCT是否为空。
		/// 
        public bool IsVITEM_PRODUCTNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVITEM_PRODUCT);
        }

		/// 
		/// 设置字段VITEM_PRODUCT为空值。
		/// 
        public void SetVITEM_PRODUCTNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVITEM_PRODUCT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSALESCALE是否为空。
		/// 
        public bool IsNSALESCALENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNSALESCALE);
        }

		/// 
		/// 设置字段NSALESCALE为空值。
		/// 
        public void SetNSALESCALENull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNSALESCALE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCHARGEFLAG是否为空。
		/// 
        public bool IsNCHARGEFLAGNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNCHARGEFLAG);
        }

		/// 
		/// 设置字段NCHARGEFLAG为空值。
		/// 
        public void SetNCHARGEFLAGNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNCHARGEFLAG] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NMEDICINEFLAG是否为空。
		/// 
        public bool IsNMEDICINEFLAGNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNMEDICINEFLAG);
        }

		/// 
		/// 设置字段NMEDICINEFLAG为空值。
		/// 
        public void SetNMEDICINEFLAGNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNMEDICINEFLAG] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DMEDICINEDATE是否为空。
		/// 
        public bool IsDMEDICINEDATENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnDMEDICINEDATE);
        }

		/// 
		/// 设置字段DMEDICINEDATE为空值。
		/// 
        public void SetDMEDICINEDATENull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnDMEDICINEDATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NBACKDRUGFLAG是否为空。
		/// 
        public bool IsNBACKDRUGFLAGNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNBACKDRUGFLAG);
        }

		/// 
		/// 设置字段NBACKDRUGFLAG为空值。
		/// 
        public void SetNBACKDRUGFLAGNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNBACKDRUGFLAG] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DBACKDRUGDATE是否为空。
		/// 
        public bool IsDBACKDRUGDATENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnDBACKDRUGDATE);
        }

		/// 
		/// 设置字段DBACKDRUGDATE为空值。
		/// 
        public void SetDBACKDRUGDATENull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnDBACKDRUGDATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NHAVMED是否为空。
		/// 
        public bool IsNHAVMEDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNHAVMED);
        }

		/// 
		/// 设置字段NHAVMED为空值。
		/// 
        public void SetNHAVMEDNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNHAVMED] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VREMARKS是否为空。
		/// 
        public bool IsVREMARKSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVREMARKS);
        }

		/// 
		/// 设置字段VREMARKS为空值。
		/// 
        public void SetVREMARKSNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVREMARKS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NACCT_MODE2是否为空。
		/// 
        public bool IsNACCT_MODE2Null()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNACCT_MODE2);
        }

		/// 
		/// 设置字段NACCT_MODE2为空值。
		/// 
        public void SetNACCT_MODE2Null() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNACCT_MODE2] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NACCT_MONEY2是否为空。
		/// 
        public bool IsNACCT_MONEY2Null()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNACCT_MONEY2);
        }

		/// 
		/// 设置字段NACCT_MONEY2为空值。
		/// 
        public void SetNACCT_MONEY2Null() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNACCT_MONEY2] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDRUG_STORAGE是否为空。
		/// 
        public bool IsVDRUG_STORAGENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVDRUG_STORAGE);
        }

		/// 
		/// 设置字段VDRUG_STORAGE为空值。
		/// 
        public void SetVDRUG_STORAGENull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVDRUG_STORAGE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NTOTALCHARGES是否为空。
		/// 
        public bool IsNTOTALCHARGESNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNTOTALCHARGES);
        }

		/// 
		/// 设置字段NTOTALCHARGES为空值。
		/// 
        public void SetNTOTALCHARGESNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNTOTALCHARGES] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEM_TYPE是否为空。
		/// 
        public bool IsVITEM_TYPENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVITEM_TYPE);
        }

		/// 
		/// 设置字段VITEM_TYPE为空值。
		/// 
        public void SetVITEM_TYPENull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVITEM_TYPE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NPRESC是否为空。
		/// 
        public bool IsNPRESCNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNPRESC);
        }

		/// 
		/// 设置字段NPRESC为空值。
		/// 
        public void SetNPRESCNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNPRESC] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCOUNT是否为空。
		/// 
        public bool IsNCOUNTNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNCOUNT);
        }

		/// 
		/// 设置字段NCOUNT为空值。
		/// 
        public void SetNCOUNTNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNCOUNT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VISSELF是否为空。
		/// 
        public bool IsVISSELFNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVISSELF);
        }

		/// 
		/// 设置字段VISSELF为空值。
		/// 
        public void SetVISSELFNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVISSELF] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDEPT_CODE是否为空。
		/// 
        public bool IsVDEPT_CODENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVDEPT_CODE);
        }

		/// 
		/// 设置字段VDEPT_CODE为空值。
		/// 
        public void SetVDEPT_CODENull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnVDEPT_CODE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NDICTDETAIL_ID是否为空。
		/// 
        public bool IsNDICTDETAIL_IDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNDICTDETAIL_ID);
        }

		/// 
		/// 设置字段NDICTDETAIL_ID为空值。
		/// 
        public void SetNDICTDETAIL_IDNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEDETAIL.ColumnNDICTDETAIL_ID] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventGHSF_GHSF_CHARGEDETAIL : EventArgs {
        
        private RowGHSF_GHSF_CHARGEDETAIL eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventGHSF_GHSF_CHARGEDETAIL(RowGHSF_GHSF_CHARGEDETAIL row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowGHSF_GHSF_CHARGEDETAIL Row {
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
	