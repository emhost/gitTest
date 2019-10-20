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
	#region DataSetXT_DICDEPART
	/// 
	/// 对于XT_DICDEPART的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetXT_DICDEPART : DataSet
    {
		
		private DataTableXT_XT_DICDEPART tableXT_XT_DICDEPART;
		
        public DataSetXT_DICDEPART() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetXT_DICDEPART实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetXT_DICDEPART GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetXT_DICDEPART dataSet = (DataSetXT_DICDEPART)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetXT_DICDEPART entity = new DataSetXT_DICDEPART();
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
        
        protected DataSetXT_DICDEPART(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["XT_XT_DICDEPART"] != null)) 
                {
                    this.Tables.Add(new DataTableXT_XT_DICDEPART(ds.Tables["XT_XT_DICDEPART"]));
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
		/// 对于数据表XT_XT_DICDEPART的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableXT_XT_DICDEPART XT_XT_DICDEPART 
		{
			get
			{
				return this.tableXT_XT_DICDEPART;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetXT_DICDEPART cln = ((DataSetXT_DICDEPART)(base.Clone()));
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
			
			if ((ds.Tables["XT_XT_DICDEPART"] != null)) 
			{
				this.Tables.Add(new DataTableXT_XT_DICDEPART(ds.Tables["XT_XT_DICDEPART"]));
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
			
			this.tableXT_XT_DICDEPART = ((DataTableXT_XT_DICDEPART)(this.Tables["XT_XT_DICDEPART"]));
			if ((this.tableXT_XT_DICDEPART != null)) {
				this.tableXT_XT_DICDEPART.InitVars();
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
			
			this.tableXT_XT_DICDEPART = new DataTableXT_XT_DICDEPART();
			this.Tables.Add(this.tableXT_XT_DICDEPART);
			
		}
		
		private bool ShouldSerializeXT_XT_DICDEPART() 
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
	
    public delegate void RowChangeEventHandlerXT_XT_DICDEPART(object sender, RowChangeEventXT_XT_DICDEPART e);
	
	#region DataTableXT_XT_DICDEPART
	/// 
	/// 对于数据表XT_XT_DICDEPART的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableXT_XT_DICDEPART : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVHOSDISTRICTID;
		
        private DataColumn columnVDEPARTCODE;
		
        private DataColumn columnVDEPARTNAME;
		
        private DataColumn columnVPARENTCODE;
		
        private DataColumn columnNDEPARTORDER;
		
        private DataColumn columnPINYINMA;
		
        private DataColumn columnWUBIMA;
		
        private DataColumn columnVDEPARTADDRESS;
		
        private DataColumn columnNISDISABLED;
		
        private DataColumn columnNMESSAGE;
		
        private DataColumn columnNBEDNUM;
		
        private DataColumn columnNHOSID;
		
        private DataColumn columnNALLOWARREARS;
		
        private DataColumn columnISZJKS;
		
        private DataColumn columnVYBCODE;
		
        private DataColumn columnVNHCODE;
		
        private DataColumn columnNOPHZID;
		
        private DataColumn columnVSTORAGEID;
		
        internal DataTableXT_XT_DICDEPART() : base("XT_XT_DICDEPART") 
        {
            this.InitClass();
        }
        
        internal DataTableXT_XT_DICDEPART(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVHOSDISTRICTID 
        {
            get 
            {
                return this.columnVHOSDISTRICTID;
            }
        }
		
        public DataColumn ColumnVDEPARTCODE 
        {
            get 
            {
                return this.columnVDEPARTCODE;
            }
        }
		
        public DataColumn ColumnVDEPARTNAME 
        {
            get 
            {
                return this.columnVDEPARTNAME;
            }
        }
		
        public DataColumn ColumnVPARENTCODE 
        {
            get 
            {
                return this.columnVPARENTCODE;
            }
        }
		
        public DataColumn ColumnNDEPARTORDER 
        {
            get 
            {
                return this.columnNDEPARTORDER;
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
		
        public DataColumn ColumnVDEPARTADDRESS 
        {
            get 
            {
                return this.columnVDEPARTADDRESS;
            }
        }
		
        public DataColumn ColumnNISDISABLED 
        {
            get 
            {
                return this.columnNISDISABLED;
            }
        }
		
        public DataColumn ColumnNMESSAGE 
        {
            get 
            {
                return this.columnNMESSAGE;
            }
        }
		
        public DataColumn ColumnNBEDNUM 
        {
            get 
            {
                return this.columnNBEDNUM;
            }
        }
		
        public DataColumn ColumnNHOSID 
        {
            get 
            {
                return this.columnNHOSID;
            }
        }
		
        public DataColumn ColumnNALLOWARREARS 
        {
            get 
            {
                return this.columnNALLOWARREARS;
            }
        }
		
        public DataColumn ColumnISZJKS 
        {
            get 
            {
                return this.columnISZJKS;
            }
        }
		
        public DataColumn ColumnVYBCODE 
        {
            get 
            {
                return this.columnVYBCODE;
            }
        }
		
        public DataColumn ColumnVNHCODE 
        {
            get 
            {
                return this.columnVNHCODE;
            }
        }
		
        public DataColumn ColumnNOPHZID 
        {
            get 
            {
                return this.columnNOPHZID;
            }
        }
		
        public DataColumn ColumnVSTORAGEID 
        {
            get 
            {
                return this.columnVSTORAGEID;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowXT_XT_DICDEPART this[int index] 
        {
            get 
            {
                return ((RowXT_XT_DICDEPART)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerXT_XT_DICDEPART RowChangedXT_XT_DICDEPART;
        
        public event RowChangeEventHandlerXT_XT_DICDEPART RowChangingXT_XT_DICDEPART;
        
        public event RowChangeEventHandlerXT_XT_DICDEPART RowDeletedXT_XT_DICDEPART;
        
        public event RowChangeEventHandlerXT_XT_DICDEPART RowDeletingXT_XT_DICDEPART;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowXT_XT_DICDEPART(RowXT_XT_DICDEPART row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowXT_XT_DICDEPART AddRowXT_XT_DICDEPART(System.Int32 VHOSDISTRICTID,System.String VDEPARTCODE,System.String VDEPARTNAME,System.String VPARENTCODE,System.Int16 NDEPARTORDER,System.String PINYINMA,System.String WUBIMA,System.String VDEPARTADDRESS,System.Int16 NISDISABLED,System.Int16 NMESSAGE,System.Int32 NBEDNUM,System.Int32 NHOSID,System.Int16 NALLOWARREARS,System.Int16 ISZJKS,System.String VYBCODE,System.String VNHCODE,System.String NOPHZID,System.String VSTORAGEID) 
        {
            RowXT_XT_DICDEPART row = ((RowXT_XT_DICDEPART)(this.NewRow()));
            row.ItemArray = new object[] {VHOSDISTRICTID,VDEPARTCODE,VDEPARTNAME,VPARENTCODE,NDEPARTORDER,PINYINMA,WUBIMA,VDEPARTADDRESS,NISDISABLED,NMESSAGE,NBEDNUM,NHOSID,NALLOWARREARS,ISZJKS,VYBCODE,VNHCODE,NOPHZID,VSTORAGEID};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowXT_XT_DICDEPART FindByVDEPARTCODE(System.String VDEPARTCODE) {
            return ((RowXT_XT_DICDEPART)(this.Rows.Find(new object[] {
                        VDEPARTCODE})));
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
            DataTableXT_XT_DICDEPART cln = ((DataTableXT_XT_DICDEPART)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableXT_XT_DICDEPART();
        }
        
        internal void InitVars() 
        {	
            this.columnVHOSDISTRICTID = this.Columns["VHOSDISTRICTID"];
            this.columnVDEPARTCODE = this.Columns["VDEPARTCODE"];
            this.columnVDEPARTNAME = this.Columns["VDEPARTNAME"];
            this.columnVPARENTCODE = this.Columns["VPARENTCODE"];
            this.columnNDEPARTORDER = this.Columns["NDEPARTORDER"];
            this.columnPINYINMA = this.Columns["PINYINMA"];
            this.columnWUBIMA = this.Columns["WUBIMA"];
            this.columnVDEPARTADDRESS = this.Columns["VDEPARTADDRESS"];
            this.columnNISDISABLED = this.Columns["NISDISABLED"];
            this.columnNMESSAGE = this.Columns["NMESSAGE"];
            this.columnNBEDNUM = this.Columns["NBEDNUM"];
            this.columnNHOSID = this.Columns["NHOSID"];
            this.columnNALLOWARREARS = this.Columns["NALLOWARREARS"];
            this.columnISZJKS = this.Columns["ISZJKS"];
            this.columnVYBCODE = this.Columns["VYBCODE"];
            this.columnVNHCODE = this.Columns["VNHCODE"];
            this.columnNOPHZID = this.Columns["NOPHZID"];
            this.columnVSTORAGEID = this.Columns["VSTORAGEID"];
        }
        
        private void InitClass() 
        {	
            this.columnVHOSDISTRICTID = new DataColumn("VHOSDISTRICTID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnVHOSDISTRICTID.AllowDBNull = true;
            this.Columns.Add(this.columnVHOSDISTRICTID);
			
            this.columnVDEPARTCODE = new DataColumn("VDEPARTCODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPARTCODE.MaxLength = 20;
            this.columnVDEPARTCODE.AllowDBNull = false;
            this.columnVDEPARTCODE.Unique = true;
            
            this.Columns.Add(this.columnVDEPARTCODE);
			
            this.columnVDEPARTNAME = new DataColumn("VDEPARTNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPARTNAME.MaxLength = 40;
            this.columnVDEPARTNAME.AllowDBNull = false;
            this.Columns.Add(this.columnVDEPARTNAME);
			
            this.columnVPARENTCODE = new DataColumn("VPARENTCODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPARENTCODE.MaxLength = 20;
            this.columnVPARENTCODE.DefaultValue = "-1";
            this.columnVPARENTCODE.AllowDBNull = false;
            this.Columns.Add(this.columnVPARENTCODE);
			
            this.columnNDEPARTORDER = new DataColumn("NDEPARTORDER", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNDEPARTORDER.DefaultValue = "0";
            this.columnNDEPARTORDER.AllowDBNull = false;
            this.Columns.Add(this.columnNDEPARTORDER);
			
            this.columnPINYINMA = new DataColumn("PINYINMA", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnPINYINMA.MaxLength = 10;
            this.columnPINYINMA.AllowDBNull = true;
            this.Columns.Add(this.columnPINYINMA);
			
            this.columnWUBIMA = new DataColumn("WUBIMA", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnWUBIMA.MaxLength = 10;
            this.columnWUBIMA.AllowDBNull = true;
            this.Columns.Add(this.columnWUBIMA);
			
            this.columnVDEPARTADDRESS = new DataColumn("VDEPARTADDRESS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPARTADDRESS.MaxLength = 50;
            this.columnVDEPARTADDRESS.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPARTADDRESS);
			
            this.columnNISDISABLED = new DataColumn("NISDISABLED", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNISDISABLED.DefaultValue = "0";
            this.columnNISDISABLED.AllowDBNull = false;
            this.Columns.Add(this.columnNISDISABLED);
			
            this.columnNMESSAGE = new DataColumn("NMESSAGE", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNMESSAGE.DefaultValue = "0";
            this.columnNMESSAGE.AllowDBNull = true;
            this.Columns.Add(this.columnNMESSAGE);
			
            this.columnNBEDNUM = new DataColumn("NBEDNUM", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNBEDNUM.DefaultValue = "-1";
            this.columnNBEDNUM.AllowDBNull = true;
            this.Columns.Add(this.columnNBEDNUM);
			
            this.columnNHOSID = new DataColumn("NHOSID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNHOSID.AllowDBNull = true;
            this.Columns.Add(this.columnNHOSID);
			
            this.columnNALLOWARREARS = new DataColumn("NALLOWARREARS", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNALLOWARREARS.DefaultValue = "0";
            this.columnNALLOWARREARS.AllowDBNull = true;
            this.Columns.Add(this.columnNALLOWARREARS);
			
            this.columnISZJKS = new DataColumn("ISZJKS", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnISZJKS.AllowDBNull = true;
            this.Columns.Add(this.columnISZJKS);
			
            this.columnVYBCODE = new DataColumn("VYBCODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVYBCODE.MaxLength = 10;
            this.columnVYBCODE.AllowDBNull = true;
            this.Columns.Add(this.columnVYBCODE);
			
            this.columnVNHCODE = new DataColumn("VNHCODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNHCODE.MaxLength = 10;
            this.columnVNHCODE.AllowDBNull = true;
            this.Columns.Add(this.columnVNHCODE);
			
            this.columnNOPHZID = new DataColumn("NOPHZID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNOPHZID.MaxLength = 20;
            this.columnNOPHZID.AllowDBNull = true;
            this.Columns.Add(this.columnNOPHZID);
			
            this.columnVSTORAGEID = new DataColumn("VSTORAGEID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVSTORAGEID.MaxLength = 50;
            this.columnVSTORAGEID.AllowDBNull = true;
            this.Columns.Add(this.columnVSTORAGEID);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowXT_XT_DICDEPART NewRowXT_XT_DICDEPART() {
            return ((RowXT_XT_DICDEPART)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowXT_XT_DICDEPART(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowXT_XT_DICDEPART);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedXT_XT_DICDEPART != null)) {
                this.RowChangedXT_XT_DICDEPART(this, new RowChangeEventXT_XT_DICDEPART(((RowXT_XT_DICDEPART)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingXT_XT_DICDEPART != null)) {
                this.RowChangingXT_XT_DICDEPART(this, new RowChangeEventXT_XT_DICDEPART(((RowXT_XT_DICDEPART)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedXT_XT_DICDEPART != null)) {
                this.RowDeletedXT_XT_DICDEPART(this, new RowChangeEventXT_XT_DICDEPART(((RowXT_XT_DICDEPART)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingXT_XT_DICDEPART != null)) {
                this.RowDeletingXT_XT_DICDEPART(this, new RowChangeEventXT_XT_DICDEPART(((RowXT_XT_DICDEPART)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowXT_XT_DICDEPART(RowXT_XT_DICDEPART row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowXT_XT_DICDEPART
	/// 
	/// 数据表XT_XT_DICDEPART行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowXT_XT_DICDEPART : DataRow 
    {
        
        private DataTableXT_XT_DICDEPART tableXT_XT_DICDEPART;
        
        internal RowXT_XT_DICDEPART(DataRowBuilder rb) : base(rb) 
        {
            this.tableXT_XT_DICDEPART = ((DataTableXT_XT_DICDEPART)(this.Table));
        }        
		
		/// 
		/// 字段VHOSDISTRICTID所映射的属性。
		/// 
        public System.Int32 VHOSDISTRICTID
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableXT_XT_DICDEPART.ColumnVHOSDISTRICTID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_DICDEPART.ColumnVHOSDISTRICTID] = value;
            }
        }
        
		/// 
		/// 字段VDEPARTCODE所映射的属性。
		/// 
        public System.String VDEPARTCODE
        {
            get 
            {	
                return ((System.String)(this[this.tableXT_XT_DICDEPART.ColumnVDEPARTCODE])); 
            }
            set 
            {
                this[this.tableXT_XT_DICDEPART.ColumnVDEPARTCODE] = value;
            }
        }
        
		/// 
		/// 字段VDEPARTNAME所映射的属性。
		/// 
        public System.String VDEPARTNAME
        {
            get 
            {	
                return ((System.String)(this[this.tableXT_XT_DICDEPART.ColumnVDEPARTNAME])); 
            }
            set 
            {
                this[this.tableXT_XT_DICDEPART.ColumnVDEPARTNAME] = value;
            }
        }
        
		/// 
		/// 字段VPARENTCODE所映射的属性。
		/// 
        public System.String VPARENTCODE
        {
            get 
            {	
                return ((System.String)(this[this.tableXT_XT_DICDEPART.ColumnVPARENTCODE])); 
            }
            set 
            {
                this[this.tableXT_XT_DICDEPART.ColumnVPARENTCODE] = value;
            }
        }
        
		/// 
		/// 字段NDEPARTORDER所映射的属性。
		/// 
        public System.Int16 NDEPARTORDER
        {
            get 
            {	
                return ((System.Int16)(this[this.tableXT_XT_DICDEPART.ColumnNDEPARTORDER])); 
            }
            set 
            {
                this[this.tableXT_XT_DICDEPART.ColumnNDEPARTORDER] = value;
            }
        }
        
		/// 
		/// 字段PINYINMA所映射的属性。
		/// 
        public System.String PINYINMA
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableXT_XT_DICDEPART.ColumnPINYINMA])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_DICDEPART.ColumnPINYINMA] = value;
            }
        }
        
		/// 
		/// 字段WUBIMA所映射的属性。
		/// 
        public System.String WUBIMA
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableXT_XT_DICDEPART.ColumnWUBIMA])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_DICDEPART.ColumnWUBIMA] = value;
            }
        }
        
		/// 
		/// 字段VDEPARTADDRESS所映射的属性。
		/// 
        public System.String VDEPARTADDRESS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableXT_XT_DICDEPART.ColumnVDEPARTADDRESS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_DICDEPART.ColumnVDEPARTADDRESS] = value;
            }
        }
        
		/// 
		/// 字段NISDISABLED所映射的属性。
		/// 
        public System.Int16 NISDISABLED
        {
            get 
            {	
                return ((System.Int16)(this[this.tableXT_XT_DICDEPART.ColumnNISDISABLED])); 
            }
            set 
            {
                this[this.tableXT_XT_DICDEPART.ColumnNISDISABLED] = value;
            }
        }
        
		/// 
		/// 字段NMESSAGE所映射的属性。
		/// 
        public System.Int16 NMESSAGE
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableXT_XT_DICDEPART.ColumnNMESSAGE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_DICDEPART.ColumnNMESSAGE] = value;
            }
        }
        
		/// 
		/// 字段NBEDNUM所映射的属性。
		/// 
        public System.Int32 NBEDNUM
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableXT_XT_DICDEPART.ColumnNBEDNUM])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_DICDEPART.ColumnNBEDNUM] = value;
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
	                return ((System.Int32)(this[this.tableXT_XT_DICDEPART.ColumnNHOSID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_DICDEPART.ColumnNHOSID] = value;
            }
        }
        
		/// 
		/// 字段NALLOWARREARS所映射的属性。
		/// 
        public System.Int16 NALLOWARREARS
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableXT_XT_DICDEPART.ColumnNALLOWARREARS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_DICDEPART.ColumnNALLOWARREARS] = value;
            }
        }
        
		/// 
		/// 字段ISZJKS所映射的属性。
		/// 
        public System.Int16 ISZJKS
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableXT_XT_DICDEPART.ColumnISZJKS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_DICDEPART.ColumnISZJKS] = value;
            }
        }
        
		/// 
		/// 字段VYBCODE所映射的属性。
		/// 
        public System.String VYBCODE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableXT_XT_DICDEPART.ColumnVYBCODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_DICDEPART.ColumnVYBCODE] = value;
            }
        }
        
		/// 
		/// 字段VNHCODE所映射的属性。
		/// 
        public System.String VNHCODE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableXT_XT_DICDEPART.ColumnVNHCODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_DICDEPART.ColumnVNHCODE] = value;
            }
        }
        
		/// 
		/// 字段NOPHZID所映射的属性。
		/// 
        public System.String NOPHZID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableXT_XT_DICDEPART.ColumnNOPHZID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_DICDEPART.ColumnNOPHZID] = value;
            }
        }
        
		/// 
		/// 字段VSTORAGEID所映射的属性。
		/// 
        public System.String VSTORAGEID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableXT_XT_DICDEPART.ColumnVSTORAGEID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_DICDEPART.ColumnVSTORAGEID] = value;
            }
        }
        
		/// 
		/// 判断字段VHOSDISTRICTID是否为空。
		/// 
        public bool IsVHOSDISTRICTIDNull()
        {
            return this.IsNull(this.tableXT_XT_DICDEPART.ColumnVHOSDISTRICTID);
        }

		/// 
		/// 设置字段VHOSDISTRICTID为空值。
		/// 
        public void SetVHOSDISTRICTIDNull() 
        {
            this[this.tableXT_XT_DICDEPART.ColumnVHOSDISTRICTID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段PINYINMA是否为空。
		/// 
        public bool IsPINYINMANull()
        {
            return this.IsNull(this.tableXT_XT_DICDEPART.ColumnPINYINMA);
        }

		/// 
		/// 设置字段PINYINMA为空值。
		/// 
        public void SetPINYINMANull() 
        {
            this[this.tableXT_XT_DICDEPART.ColumnPINYINMA] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段WUBIMA是否为空。
		/// 
        public bool IsWUBIMANull()
        {
            return this.IsNull(this.tableXT_XT_DICDEPART.ColumnWUBIMA);
        }

		/// 
		/// 设置字段WUBIMA为空值。
		/// 
        public void SetWUBIMANull() 
        {
            this[this.tableXT_XT_DICDEPART.ColumnWUBIMA] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDEPARTADDRESS是否为空。
		/// 
        public bool IsVDEPARTADDRESSNull()
        {
            return this.IsNull(this.tableXT_XT_DICDEPART.ColumnVDEPARTADDRESS);
        }

		/// 
		/// 设置字段VDEPARTADDRESS为空值。
		/// 
        public void SetVDEPARTADDRESSNull() 
        {
            this[this.tableXT_XT_DICDEPART.ColumnVDEPARTADDRESS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NMESSAGE是否为空。
		/// 
        public bool IsNMESSAGENull()
        {
            return this.IsNull(this.tableXT_XT_DICDEPART.ColumnNMESSAGE);
        }

		/// 
		/// 设置字段NMESSAGE为空值。
		/// 
        public void SetNMESSAGENull() 
        {
            this[this.tableXT_XT_DICDEPART.ColumnNMESSAGE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NBEDNUM是否为空。
		/// 
        public bool IsNBEDNUMNull()
        {
            return this.IsNull(this.tableXT_XT_DICDEPART.ColumnNBEDNUM);
        }

		/// 
		/// 设置字段NBEDNUM为空值。
		/// 
        public void SetNBEDNUMNull() 
        {
            this[this.tableXT_XT_DICDEPART.ColumnNBEDNUM] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NHOSID是否为空。
		/// 
        public bool IsNHOSIDNull()
        {
            return this.IsNull(this.tableXT_XT_DICDEPART.ColumnNHOSID);
        }

		/// 
		/// 设置字段NHOSID为空值。
		/// 
        public void SetNHOSIDNull() 
        {
            this[this.tableXT_XT_DICDEPART.ColumnNHOSID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NALLOWARREARS是否为空。
		/// 
        public bool IsNALLOWARREARSNull()
        {
            return this.IsNull(this.tableXT_XT_DICDEPART.ColumnNALLOWARREARS);
        }

		/// 
		/// 设置字段NALLOWARREARS为空值。
		/// 
        public void SetNALLOWARREARSNull() 
        {
            this[this.tableXT_XT_DICDEPART.ColumnNALLOWARREARS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段ISZJKS是否为空。
		/// 
        public bool IsISZJKSNull()
        {
            return this.IsNull(this.tableXT_XT_DICDEPART.ColumnISZJKS);
        }

		/// 
		/// 设置字段ISZJKS为空值。
		/// 
        public void SetISZJKSNull() 
        {
            this[this.tableXT_XT_DICDEPART.ColumnISZJKS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VYBCODE是否为空。
		/// 
        public bool IsVYBCODENull()
        {
            return this.IsNull(this.tableXT_XT_DICDEPART.ColumnVYBCODE);
        }

		/// 
		/// 设置字段VYBCODE为空值。
		/// 
        public void SetVYBCODENull() 
        {
            this[this.tableXT_XT_DICDEPART.ColumnVYBCODE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VNHCODE是否为空。
		/// 
        public bool IsVNHCODENull()
        {
            return this.IsNull(this.tableXT_XT_DICDEPART.ColumnVNHCODE);
        }

		/// 
		/// 设置字段VNHCODE为空值。
		/// 
        public void SetVNHCODENull() 
        {
            this[this.tableXT_XT_DICDEPART.ColumnVNHCODE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NOPHZID是否为空。
		/// 
        public bool IsNOPHZIDNull()
        {
            return this.IsNull(this.tableXT_XT_DICDEPART.ColumnNOPHZID);
        }

		/// 
		/// 设置字段NOPHZID为空值。
		/// 
        public void SetNOPHZIDNull() 
        {
            this[this.tableXT_XT_DICDEPART.ColumnNOPHZID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VSTORAGEID是否为空。
		/// 
        public bool IsVSTORAGEIDNull()
        {
            return this.IsNull(this.tableXT_XT_DICDEPART.ColumnVSTORAGEID);
        }

		/// 
		/// 设置字段VSTORAGEID为空值。
		/// 
        public void SetVSTORAGEIDNull() 
        {
            this[this.tableXT_XT_DICDEPART.ColumnVSTORAGEID] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventXT_XT_DICDEPART : EventArgs {
        
        private RowXT_XT_DICDEPART eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventXT_XT_DICDEPART(RowXT_XT_DICDEPART row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowXT_XT_DICDEPART Row {
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
	