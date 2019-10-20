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
	#region DataSetGHSF_CHARGEMAIN
	/// 
	/// 对于GHSF_CHARGEMAIN的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetGHSF_CHARGEMAIN : DataSet
    {
		
		private DataTableGHSF_GHSF_CHARGEMAIN tableGHSF_GHSF_CHARGEMAIN;
		
        public DataSetGHSF_CHARGEMAIN() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetGHSF_CHARGEMAIN实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetGHSF_CHARGEMAIN GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetGHSF_CHARGEMAIN dataSet = (DataSetGHSF_CHARGEMAIN)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetGHSF_CHARGEMAIN entity = new DataSetGHSF_CHARGEMAIN();
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
        
        protected DataSetGHSF_CHARGEMAIN(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["GHSF_GHSF_CHARGEMAIN"] != null)) 
                {
                    this.Tables.Add(new DataTableGHSF_GHSF_CHARGEMAIN(ds.Tables["GHSF_GHSF_CHARGEMAIN"]));
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
		/// 对于数据表GHSF_GHSF_CHARGEMAIN的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableGHSF_GHSF_CHARGEMAIN GHSF_GHSF_CHARGEMAIN 
		{
			get
			{
				return this.tableGHSF_GHSF_CHARGEMAIN;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetGHSF_CHARGEMAIN cln = ((DataSetGHSF_CHARGEMAIN)(base.Clone()));
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
			
			if ((ds.Tables["GHSF_GHSF_CHARGEMAIN"] != null)) 
			{
				this.Tables.Add(new DataTableGHSF_GHSF_CHARGEMAIN(ds.Tables["GHSF_GHSF_CHARGEMAIN"]));
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
			
			this.tableGHSF_GHSF_CHARGEMAIN = ((DataTableGHSF_GHSF_CHARGEMAIN)(this.Tables["GHSF_GHSF_CHARGEMAIN"]));
			if ((this.tableGHSF_GHSF_CHARGEMAIN != null)) {
				this.tableGHSF_GHSF_CHARGEMAIN.InitVars();
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
			
			this.tableGHSF_GHSF_CHARGEMAIN = new DataTableGHSF_GHSF_CHARGEMAIN();
			this.Tables.Add(this.tableGHSF_GHSF_CHARGEMAIN);
			
		}
		
		private bool ShouldSerializeGHSF_GHSF_CHARGEMAIN() 
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
	
    public delegate void RowChangeEventHandlerGHSF_GHSF_CHARGEMAIN(object sender, RowChangeEventGHSF_GHSF_CHARGEMAIN e);
	
	#region DataTableGHSF_GHSF_CHARGEMAIN
	/// 
	/// 对于数据表GHSF_GHSF_CHARGEMAIN的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableGHSF_GHSF_CHARGEMAIN : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVPRESC_TYPE;
		
        private DataColumn columnDPRESC_DATE;
		
        private DataColumn columnVDEPT_CODE;
		
        private DataColumn columnVACCTID;
		
        private DataColumn columnBBAIYAO;
		
        private DataColumn columnNHOSID;
		
        private DataColumn columnVRCPTID;
		
        private DataColumn columnVPATIENTID;
		
        private DataColumn columnVREGIST_ID;
		
        private DataColumn columnVPRESC_ID;
		
        private DataColumn columnVDIAGNOSE;
		
        private DataColumn columnNCOUNT;
		
        private DataColumn columnVUSERAGE;
		
        private DataColumn columnVDOCTOR_ID;
		
        private DataColumn columnVOPERATORID;
		
        private DataColumn columnVREFUNDEDRCPTNO;
		
        private DataColumn columnVACCTNO;
		
        private DataColumn columnVPRINTEDOPERATORID;
		
        private DataColumn columnVPRINTEDDATE;
		
        private DataColumn columnVPRINTEDRCPTNO;
		
        private DataColumn columnVINVOICENO;
		
        private DataColumn columnNSETTLE;
		
        private DataColumn columnVREMARKS;
		
        private DataColumn columnDCHARGE_DATE;
		
        private DataColumn columnVDEPTID;
		
        private DataColumn columnNSTATUS;
		
        internal DataTableGHSF_GHSF_CHARGEMAIN() : base("GHSF_GHSF_CHARGEMAIN") 
        {
            this.InitClass();
        }
        
        internal DataTableGHSF_GHSF_CHARGEMAIN(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVPRESC_TYPE 
        {
            get 
            {
                return this.columnVPRESC_TYPE;
            }
        }
		
        public DataColumn ColumnDPRESC_DATE 
        {
            get 
            {
                return this.columnDPRESC_DATE;
            }
        }
		
        public DataColumn ColumnVDEPT_CODE 
        {
            get 
            {
                return this.columnVDEPT_CODE;
            }
        }
		
        public DataColumn ColumnVACCTID 
        {
            get 
            {
                return this.columnVACCTID;
            }
        }
		
        public DataColumn ColumnBBAIYAO 
        {
            get 
            {
                return this.columnBBAIYAO;
            }
        }
		
        public DataColumn ColumnNHOSID 
        {
            get 
            {
                return this.columnNHOSID;
            }
        }
		
        public DataColumn ColumnVRCPTID 
        {
            get 
            {
                return this.columnVRCPTID;
            }
        }
		
        public DataColumn ColumnVPATIENTID 
        {
            get 
            {
                return this.columnVPATIENTID;
            }
        }
		
        public DataColumn ColumnVREGIST_ID 
        {
            get 
            {
                return this.columnVREGIST_ID;
            }
        }
		
        public DataColumn ColumnVPRESC_ID 
        {
            get 
            {
                return this.columnVPRESC_ID;
            }
        }
		
        public DataColumn ColumnVDIAGNOSE 
        {
            get 
            {
                return this.columnVDIAGNOSE;
            }
        }
		
        public DataColumn ColumnNCOUNT 
        {
            get 
            {
                return this.columnNCOUNT;
            }
        }
		
        public DataColumn ColumnVUSERAGE 
        {
            get 
            {
                return this.columnVUSERAGE;
            }
        }
		
        public DataColumn ColumnVDOCTOR_ID 
        {
            get 
            {
                return this.columnVDOCTOR_ID;
            }
        }
		
        public DataColumn ColumnVOPERATORID 
        {
            get 
            {
                return this.columnVOPERATORID;
            }
        }
		
        public DataColumn ColumnVREFUNDEDRCPTNO 
        {
            get 
            {
                return this.columnVREFUNDEDRCPTNO;
            }
        }
		
        public DataColumn ColumnVACCTNO 
        {
            get 
            {
                return this.columnVACCTNO;
            }
        }
		
        public DataColumn ColumnVPRINTEDOPERATORID 
        {
            get 
            {
                return this.columnVPRINTEDOPERATORID;
            }
        }
		
        public DataColumn ColumnVPRINTEDDATE 
        {
            get 
            {
                return this.columnVPRINTEDDATE;
            }
        }
		
        public DataColumn ColumnVPRINTEDRCPTNO 
        {
            get 
            {
                return this.columnVPRINTEDRCPTNO;
            }
        }
		
        public DataColumn ColumnVINVOICENO 
        {
            get 
            {
                return this.columnVINVOICENO;
            }
        }
		
        public DataColumn ColumnNSETTLE 
        {
            get 
            {
                return this.columnNSETTLE;
            }
        }
		
        public DataColumn ColumnVREMARKS 
        {
            get 
            {
                return this.columnVREMARKS;
            }
        }
		
        public DataColumn ColumnDCHARGE_DATE 
        {
            get 
            {
                return this.columnDCHARGE_DATE;
            }
        }
		
        public DataColumn ColumnVDEPTID 
        {
            get 
            {
                return this.columnVDEPTID;
            }
        }
		
        public DataColumn ColumnNSTATUS 
        {
            get 
            {
                return this.columnNSTATUS;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowGHSF_GHSF_CHARGEMAIN this[int index] 
        {
            get 
            {
                return ((RowGHSF_GHSF_CHARGEMAIN)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerGHSF_GHSF_CHARGEMAIN RowChangedGHSF_GHSF_CHARGEMAIN;
        
        public event RowChangeEventHandlerGHSF_GHSF_CHARGEMAIN RowChangingGHSF_GHSF_CHARGEMAIN;
        
        public event RowChangeEventHandlerGHSF_GHSF_CHARGEMAIN RowDeletedGHSF_GHSF_CHARGEMAIN;
        
        public event RowChangeEventHandlerGHSF_GHSF_CHARGEMAIN RowDeletingGHSF_GHSF_CHARGEMAIN;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowGHSF_GHSF_CHARGEMAIN(RowGHSF_GHSF_CHARGEMAIN row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowGHSF_GHSF_CHARGEMAIN AddRowGHSF_GHSF_CHARGEMAIN(System.String VPRESC_TYPE,System.DateTime DPRESC_DATE,System.String VDEPT_CODE,System.String VACCTID,System.Int16 BBAIYAO,System.Int32 NHOSID,System.String VRCPTID,System.String VPATIENTID,System.String VREGIST_ID,System.String VPRESC_ID,System.String VDIAGNOSE,System.Int16 NCOUNT,System.String VUSERAGE,System.String VDOCTOR_ID,System.String VOPERATORID,System.String VREFUNDEDRCPTNO,System.String VACCTNO,System.String VPRINTEDOPERATORID,System.DateTime VPRINTEDDATE,System.String VPRINTEDRCPTNO,System.String VINVOICENO,System.Int16 NSETTLE,System.String VREMARKS,System.DateTime DCHARGE_DATE,System.String VDEPTID,System.Int16 NSTATUS) 
        {
            RowGHSF_GHSF_CHARGEMAIN row = ((RowGHSF_GHSF_CHARGEMAIN)(this.NewRow()));
            row.ItemArray = new object[] {VPRESC_TYPE,DPRESC_DATE,VDEPT_CODE,VACCTID,BBAIYAO,NHOSID,VRCPTID,VPATIENTID,VREGIST_ID,VPRESC_ID,VDIAGNOSE,NCOUNT,VUSERAGE,VDOCTOR_ID,VOPERATORID,VREFUNDEDRCPTNO,VACCTNO,VPRINTEDOPERATORID,VPRINTEDDATE,VPRINTEDRCPTNO,VINVOICENO,NSETTLE,VREMARKS,DCHARGE_DATE,VDEPTID,NSTATUS};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowGHSF_GHSF_CHARGEMAIN FindByVRCPTID(System.String VRCPTID) {
            return ((RowGHSF_GHSF_CHARGEMAIN)(this.Rows.Find(new object[] {
                        VRCPTID})));
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
            DataTableGHSF_GHSF_CHARGEMAIN cln = ((DataTableGHSF_GHSF_CHARGEMAIN)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableGHSF_GHSF_CHARGEMAIN();
        }
        
        internal void InitVars() 
        {	
            this.columnVPRESC_TYPE = this.Columns["VPRESC_TYPE"];
            this.columnDPRESC_DATE = this.Columns["DPRESC_DATE"];
            this.columnVDEPT_CODE = this.Columns["VDEPT_CODE"];
            this.columnVACCTID = this.Columns["VACCTID"];
            this.columnBBAIYAO = this.Columns["BBAIYAO"];
            this.columnNHOSID = this.Columns["NHOSID"];
            this.columnVRCPTID = this.Columns["VRCPTID"];
            this.columnVPATIENTID = this.Columns["VPATIENTID"];
            this.columnVREGIST_ID = this.Columns["VREGIST_ID"];
            this.columnVPRESC_ID = this.Columns["VPRESC_ID"];
            this.columnVDIAGNOSE = this.Columns["VDIAGNOSE"];
            this.columnNCOUNT = this.Columns["NCOUNT"];
            this.columnVUSERAGE = this.Columns["VUSERAGE"];
            this.columnVDOCTOR_ID = this.Columns["VDOCTOR_ID"];
            this.columnVOPERATORID = this.Columns["VOPERATORID"];
            this.columnVREFUNDEDRCPTNO = this.Columns["VREFUNDEDRCPTNO"];
            this.columnVACCTNO = this.Columns["VACCTNO"];
            this.columnVPRINTEDOPERATORID = this.Columns["VPRINTEDOPERATORID"];
            this.columnVPRINTEDDATE = this.Columns["VPRINTEDDATE"];
            this.columnVPRINTEDRCPTNO = this.Columns["VPRINTEDRCPTNO"];
            this.columnVINVOICENO = this.Columns["VINVOICENO"];
            this.columnNSETTLE = this.Columns["NSETTLE"];
            this.columnVREMARKS = this.Columns["VREMARKS"];
            this.columnDCHARGE_DATE = this.Columns["DCHARGE_DATE"];
            this.columnVDEPTID = this.Columns["VDEPTID"];
            this.columnNSTATUS = this.Columns["NSTATUS"];
        }
        
        private void InitClass() 
        {	
            this.columnVPRESC_TYPE = new DataColumn("VPRESC_TYPE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPRESC_TYPE.MaxLength = 12;
            this.columnVPRESC_TYPE.AllowDBNull = true;
            this.Columns.Add(this.columnVPRESC_TYPE);
			
            this.columnDPRESC_DATE = new DataColumn("DPRESC_DATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDPRESC_DATE.AllowDBNull = true;
            this.Columns.Add(this.columnDPRESC_DATE);
			
            this.columnVDEPT_CODE = new DataColumn("VDEPT_CODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPT_CODE.MaxLength = 20;
            this.columnVDEPT_CODE.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPT_CODE);
			
            this.columnVACCTID = new DataColumn("VACCTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVACCTID.MaxLength = 10;
            this.columnVACCTID.AllowDBNull = true;
            this.Columns.Add(this.columnVACCTID);
			
            this.columnBBAIYAO = new DataColumn("BBAIYAO", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnBBAIYAO.DefaultValue = "0";
            this.columnBBAIYAO.AllowDBNull = true;
            this.Columns.Add(this.columnBBAIYAO);
			
            this.columnNHOSID = new DataColumn("NHOSID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNHOSID.AllowDBNull = true;
            this.Columns.Add(this.columnNHOSID);
			
            this.columnVRCPTID = new DataColumn("VRCPTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVRCPTID.MaxLength = 20;
            this.columnVRCPTID.AllowDBNull = false;
            this.columnVRCPTID.Unique = true;
            
            this.Columns.Add(this.columnVRCPTID);
			
            this.columnVPATIENTID = new DataColumn("VPATIENTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPATIENTID.MaxLength = 20;
            this.columnVPATIENTID.AllowDBNull = false;
            this.Columns.Add(this.columnVPATIENTID);
			
            this.columnVREGIST_ID = new DataColumn("VREGIST_ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVREGIST_ID.MaxLength = 20;
            this.columnVREGIST_ID.AllowDBNull = true;
            this.Columns.Add(this.columnVREGIST_ID);
			
            this.columnVPRESC_ID = new DataColumn("VPRESC_ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPRESC_ID.MaxLength = 60;
            this.columnVPRESC_ID.AllowDBNull = false;
            this.Columns.Add(this.columnVPRESC_ID);
			
            this.columnVDIAGNOSE = new DataColumn("VDIAGNOSE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDIAGNOSE.MaxLength = 50;
            this.columnVDIAGNOSE.AllowDBNull = true;
            this.Columns.Add(this.columnVDIAGNOSE);
			
            this.columnNCOUNT = new DataColumn("NCOUNT", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNCOUNT.AllowDBNull = true;
            this.Columns.Add(this.columnNCOUNT);
			
            this.columnVUSERAGE = new DataColumn("VUSERAGE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVUSERAGE.MaxLength = 10;
            this.columnVUSERAGE.AllowDBNull = true;
            this.Columns.Add(this.columnVUSERAGE);
			
            this.columnVDOCTOR_ID = new DataColumn("VDOCTOR_ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDOCTOR_ID.MaxLength = 20;
            this.columnVDOCTOR_ID.AllowDBNull = true;
            this.Columns.Add(this.columnVDOCTOR_ID);
			
            this.columnVOPERATORID = new DataColumn("VOPERATORID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVOPERATORID.MaxLength = 20;
            this.columnVOPERATORID.AllowDBNull = false;
            this.Columns.Add(this.columnVOPERATORID);
			
            this.columnVREFUNDEDRCPTNO = new DataColumn("VREFUNDEDRCPTNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVREFUNDEDRCPTNO.MaxLength = 20;
            this.columnVREFUNDEDRCPTNO.AllowDBNull = true;
            this.Columns.Add(this.columnVREFUNDEDRCPTNO);
			
            this.columnVACCTNO = new DataColumn("VACCTNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVACCTNO.MaxLength = 6;
            this.columnVACCTNO.AllowDBNull = true;
            this.Columns.Add(this.columnVACCTNO);
			
            this.columnVPRINTEDOPERATORID = new DataColumn("VPRINTEDOPERATORID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPRINTEDOPERATORID.MaxLength = 20;
            this.columnVPRINTEDOPERATORID.AllowDBNull = true;
            this.Columns.Add(this.columnVPRINTEDOPERATORID);
			
            this.columnVPRINTEDDATE = new DataColumn("VPRINTEDDATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnVPRINTEDDATE.AllowDBNull = true;
            this.Columns.Add(this.columnVPRINTEDDATE);
			
            this.columnVPRINTEDRCPTNO = new DataColumn("VPRINTEDRCPTNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPRINTEDRCPTNO.MaxLength = 20;
            this.columnVPRINTEDRCPTNO.AllowDBNull = true;
            this.Columns.Add(this.columnVPRINTEDRCPTNO);
			
            this.columnVINVOICENO = new DataColumn("VINVOICENO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVINVOICENO.MaxLength = 20;
            this.columnVINVOICENO.AllowDBNull = true;
            this.Columns.Add(this.columnVINVOICENO);
			
            this.columnNSETTLE = new DataColumn("NSETTLE", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNSETTLE.DefaultValue = "0";
            this.columnNSETTLE.AllowDBNull = true;
            this.Columns.Add(this.columnNSETTLE);
			
            this.columnVREMARKS = new DataColumn("VREMARKS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVREMARKS.MaxLength = 50;
            this.columnVREMARKS.AllowDBNull = true;
            this.Columns.Add(this.columnVREMARKS);
			
            this.columnDCHARGE_DATE = new DataColumn("DCHARGE_DATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDCHARGE_DATE.AllowDBNull = false;
            this.Columns.Add(this.columnDCHARGE_DATE);
			
            this.columnVDEPTID = new DataColumn("VDEPTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPTID.MaxLength = 20;
            this.columnVDEPTID.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPTID);
			
            this.columnNSTATUS = new DataColumn("NSTATUS", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNSTATUS.AllowDBNull = true;
            this.Columns.Add(this.columnNSTATUS);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowGHSF_GHSF_CHARGEMAIN NewRowGHSF_GHSF_CHARGEMAIN() {
            return ((RowGHSF_GHSF_CHARGEMAIN)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowGHSF_GHSF_CHARGEMAIN(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowGHSF_GHSF_CHARGEMAIN);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedGHSF_GHSF_CHARGEMAIN != null)) {
                this.RowChangedGHSF_GHSF_CHARGEMAIN(this, new RowChangeEventGHSF_GHSF_CHARGEMAIN(((RowGHSF_GHSF_CHARGEMAIN)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingGHSF_GHSF_CHARGEMAIN != null)) {
                this.RowChangingGHSF_GHSF_CHARGEMAIN(this, new RowChangeEventGHSF_GHSF_CHARGEMAIN(((RowGHSF_GHSF_CHARGEMAIN)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedGHSF_GHSF_CHARGEMAIN != null)) {
                this.RowDeletedGHSF_GHSF_CHARGEMAIN(this, new RowChangeEventGHSF_GHSF_CHARGEMAIN(((RowGHSF_GHSF_CHARGEMAIN)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingGHSF_GHSF_CHARGEMAIN != null)) {
                this.RowDeletingGHSF_GHSF_CHARGEMAIN(this, new RowChangeEventGHSF_GHSF_CHARGEMAIN(((RowGHSF_GHSF_CHARGEMAIN)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowGHSF_GHSF_CHARGEMAIN(RowGHSF_GHSF_CHARGEMAIN row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowGHSF_GHSF_CHARGEMAIN
	/// 
	/// 数据表GHSF_GHSF_CHARGEMAIN行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowGHSF_GHSF_CHARGEMAIN : DataRow 
    {
        
        private DataTableGHSF_GHSF_CHARGEMAIN tableGHSF_GHSF_CHARGEMAIN;
        
        internal RowGHSF_GHSF_CHARGEMAIN(DataRowBuilder rb) : base(rb) 
        {
            this.tableGHSF_GHSF_CHARGEMAIN = ((DataTableGHSF_GHSF_CHARGEMAIN)(this.Table));
        }        
		
		/// 
		/// 字段VPRESC_TYPE所映射的属性。
		/// 
        public System.String VPRESC_TYPE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPRESC_TYPE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPRESC_TYPE] = value;
            }
        }
        
		/// 
		/// 字段DPRESC_DATE所映射的属性。
		/// 
        public System.DateTime DPRESC_DATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnDPRESC_DATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnDPRESC_DATE] = value;
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
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVDEPT_CODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVDEPT_CODE] = value;
            }
        }
        
		/// 
		/// 字段VACCTID所映射的属性。
		/// 
        public System.String VACCTID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVACCTID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVACCTID] = value;
            }
        }
        
		/// 
		/// 字段BBAIYAO所映射的属性。
		/// 
        public System.Int16 BBAIYAO
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnBBAIYAO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnBBAIYAO] = value;
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
	                return ((System.Int32)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnNHOSID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnNHOSID] = value;
            }
        }
        
		/// 
		/// 字段VRCPTID所映射的属性。
		/// 
        public System.String VRCPTID
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVRCPTID])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVRCPTID] = value;
            }
        }
        
		/// 
		/// 字段VPATIENTID所映射的属性。
		/// 
        public System.String VPATIENTID
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPATIENTID])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPATIENTID] = value;
            }
        }
        
		/// 
		/// 字段VREGIST_ID所映射的属性。
		/// 
        public System.String VREGIST_ID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVREGIST_ID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVREGIST_ID] = value;
            }
        }
        
		/// 
		/// 字段VPRESC_ID所映射的属性。
		/// 
        public System.String VPRESC_ID
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPRESC_ID])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPRESC_ID] = value;
            }
        }
        
		/// 
		/// 字段VDIAGNOSE所映射的属性。
		/// 
        public System.String VDIAGNOSE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVDIAGNOSE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVDIAGNOSE] = value;
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
	                return ((System.Int16)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnNCOUNT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnNCOUNT] = value;
            }
        }
        
		/// 
		/// 字段VUSERAGE所映射的属性。
		/// 
        public System.String VUSERAGE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVUSERAGE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVUSERAGE] = value;
            }
        }
        
		/// 
		/// 字段VDOCTOR_ID所映射的属性。
		/// 
        public System.String VDOCTOR_ID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVDOCTOR_ID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVDOCTOR_ID] = value;
            }
        }
        
		/// 
		/// 字段VOPERATORID所映射的属性。
		/// 
        public System.String VOPERATORID
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVOPERATORID])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVOPERATORID] = value;
            }
        }
        
		/// 
		/// 字段VREFUNDEDRCPTNO所映射的属性。
		/// 
        public System.String VREFUNDEDRCPTNO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVREFUNDEDRCPTNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVREFUNDEDRCPTNO] = value;
            }
        }
        
		/// 
		/// 字段VACCTNO所映射的属性。
		/// 
        public System.String VACCTNO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVACCTNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVACCTNO] = value;
            }
        }
        
		/// 
		/// 字段VPRINTEDOPERATORID所映射的属性。
		/// 
        public System.String VPRINTEDOPERATORID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPRINTEDOPERATORID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPRINTEDOPERATORID] = value;
            }
        }
        
		/// 
		/// 字段VPRINTEDDATE所映射的属性。
		/// 
        public System.DateTime VPRINTEDDATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPRINTEDDATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPRINTEDDATE] = value;
            }
        }
        
		/// 
		/// 字段VPRINTEDRCPTNO所映射的属性。
		/// 
        public System.String VPRINTEDRCPTNO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPRINTEDRCPTNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPRINTEDRCPTNO] = value;
            }
        }
        
		/// 
		/// 字段VINVOICENO所映射的属性。
		/// 
        public System.String VINVOICENO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVINVOICENO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVINVOICENO] = value;
            }
        }
        
		/// 
		/// 字段NSETTLE所映射的属性。
		/// 
        public System.Int16 NSETTLE
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnNSETTLE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnNSETTLE] = value;
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
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVREMARKS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVREMARKS] = value;
            }
        }
        
		/// 
		/// 字段DCHARGE_DATE所映射的属性。
		/// 
        public System.DateTime DCHARGE_DATE
        {
            get 
            {	
                return ((System.DateTime)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnDCHARGE_DATE])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnDCHARGE_DATE] = value;
            }
        }
        
		/// 
		/// 字段VDEPTID所映射的属性。
		/// 
        public System.String VDEPTID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVDEPTID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVDEPTID] = value;
            }
        }
        
		/// 
		/// 字段NSTATUS所映射的属性。
		/// 
        public System.Int16 NSTATUS
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnNSTATUS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnNSTATUS] = value;
            }
        }
        
		/// 
		/// 判断字段VPRESC_TYPE是否为空。
		/// 
        public bool IsVPRESC_TYPENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPRESC_TYPE);
        }

		/// 
		/// 设置字段VPRESC_TYPE为空值。
		/// 
        public void SetVPRESC_TYPENull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPRESC_TYPE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DPRESC_DATE是否为空。
		/// 
        public bool IsDPRESC_DATENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnDPRESC_DATE);
        }

		/// 
		/// 设置字段DPRESC_DATE为空值。
		/// 
        public void SetDPRESC_DATENull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnDPRESC_DATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDEPT_CODE是否为空。
		/// 
        public bool IsVDEPT_CODENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnVDEPT_CODE);
        }

		/// 
		/// 设置字段VDEPT_CODE为空值。
		/// 
        public void SetVDEPT_CODENull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVDEPT_CODE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VACCTID是否为空。
		/// 
        public bool IsVACCTIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnVACCTID);
        }

		/// 
		/// 设置字段VACCTID为空值。
		/// 
        public void SetVACCTIDNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVACCTID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段BBAIYAO是否为空。
		/// 
        public bool IsBBAIYAONull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnBBAIYAO);
        }

		/// 
		/// 设置字段BBAIYAO为空值。
		/// 
        public void SetBBAIYAONull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnBBAIYAO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NHOSID是否为空。
		/// 
        public bool IsNHOSIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnNHOSID);
        }

		/// 
		/// 设置字段NHOSID为空值。
		/// 
        public void SetNHOSIDNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnNHOSID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VREGIST_ID是否为空。
		/// 
        public bool IsVREGIST_IDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnVREGIST_ID);
        }

		/// 
		/// 设置字段VREGIST_ID为空值。
		/// 
        public void SetVREGIST_IDNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVREGIST_ID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDIAGNOSE是否为空。
		/// 
        public bool IsVDIAGNOSENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnVDIAGNOSE);
        }

		/// 
		/// 设置字段VDIAGNOSE为空值。
		/// 
        public void SetVDIAGNOSENull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVDIAGNOSE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCOUNT是否为空。
		/// 
        public bool IsNCOUNTNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnNCOUNT);
        }

		/// 
		/// 设置字段NCOUNT为空值。
		/// 
        public void SetNCOUNTNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnNCOUNT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VUSERAGE是否为空。
		/// 
        public bool IsVUSERAGENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnVUSERAGE);
        }

		/// 
		/// 设置字段VUSERAGE为空值。
		/// 
        public void SetVUSERAGENull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVUSERAGE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDOCTOR_ID是否为空。
		/// 
        public bool IsVDOCTOR_IDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnVDOCTOR_ID);
        }

		/// 
		/// 设置字段VDOCTOR_ID为空值。
		/// 
        public void SetVDOCTOR_IDNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVDOCTOR_ID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VREFUNDEDRCPTNO是否为空。
		/// 
        public bool IsVREFUNDEDRCPTNONull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnVREFUNDEDRCPTNO);
        }

		/// 
		/// 设置字段VREFUNDEDRCPTNO为空值。
		/// 
        public void SetVREFUNDEDRCPTNONull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVREFUNDEDRCPTNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VACCTNO是否为空。
		/// 
        public bool IsVACCTNONull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnVACCTNO);
        }

		/// 
		/// 设置字段VACCTNO为空值。
		/// 
        public void SetVACCTNONull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVACCTNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPRINTEDOPERATORID是否为空。
		/// 
        public bool IsVPRINTEDOPERATORIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPRINTEDOPERATORID);
        }

		/// 
		/// 设置字段VPRINTEDOPERATORID为空值。
		/// 
        public void SetVPRINTEDOPERATORIDNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPRINTEDOPERATORID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPRINTEDDATE是否为空。
		/// 
        public bool IsVPRINTEDDATENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPRINTEDDATE);
        }

		/// 
		/// 设置字段VPRINTEDDATE为空值。
		/// 
        public void SetVPRINTEDDATENull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPRINTEDDATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPRINTEDRCPTNO是否为空。
		/// 
        public bool IsVPRINTEDRCPTNONull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPRINTEDRCPTNO);
        }

		/// 
		/// 设置字段VPRINTEDRCPTNO为空值。
		/// 
        public void SetVPRINTEDRCPTNONull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVPRINTEDRCPTNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VINVOICENO是否为空。
		/// 
        public bool IsVINVOICENONull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnVINVOICENO);
        }

		/// 
		/// 设置字段VINVOICENO为空值。
		/// 
        public void SetVINVOICENONull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVINVOICENO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSETTLE是否为空。
		/// 
        public bool IsNSETTLENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnNSETTLE);
        }

		/// 
		/// 设置字段NSETTLE为空值。
		/// 
        public void SetNSETTLENull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnNSETTLE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VREMARKS是否为空。
		/// 
        public bool IsVREMARKSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnVREMARKS);
        }

		/// 
		/// 设置字段VREMARKS为空值。
		/// 
        public void SetVREMARKSNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVREMARKS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDEPTID是否为空。
		/// 
        public bool IsVDEPTIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnVDEPTID);
        }

		/// 
		/// 设置字段VDEPTID为空值。
		/// 
        public void SetVDEPTIDNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnVDEPTID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSTATUS是否为空。
		/// 
        public bool IsNSTATUSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_CHARGEMAIN.ColumnNSTATUS);
        }

		/// 
		/// 设置字段NSTATUS为空值。
		/// 
        public void SetNSTATUSNull() 
        {
            this[this.tableGHSF_GHSF_CHARGEMAIN.ColumnNSTATUS] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventGHSF_GHSF_CHARGEMAIN : EventArgs {
        
        private RowGHSF_GHSF_CHARGEMAIN eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventGHSF_GHSF_CHARGEMAIN(RowGHSF_GHSF_CHARGEMAIN row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowGHSF_GHSF_CHARGEMAIN Row {
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
	