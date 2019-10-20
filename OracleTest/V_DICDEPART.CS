//------------------------------------------------------------------------------
//     这部分代码属于实体定义层，是由实体编辑器工具自动产生的。
//     (Runtime Version: 1.0.0.0)
//     对此代码进行的任何修改会导致其它的行为错误，并且重新生成时所有的修改会丢失。
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Xml;
using System.Runtime.Serialization;

namespace hyhisapp.Entity
{
	#region DataSetV_DICDEPART
	/// 
	/// ,V_DICDEPART的视图实体。
	/// 
    [Serializable()]
    public class DataSetV_DICDEPART : DataSet
    {
	
		private DataTableV_DICDEPART tableV_DICDEPART;

	
        public DataSetV_DICDEPART() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetV_DICDEPART实体。
		/// 
		public DataSetV_DICDEPART GetChangesEntity(DataRowState ds)
		{
			DataSetV_DICDEPART dataSet = (DataSetV_DICDEPART)this.GetChanges(ds);
			return dataSet;		
		}
        
        protected DataSetV_DICDEPART(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
		
                if ((ds.Tables["V_DICDEPART"] != null)) 
                {
                    this.Tables.Add(new DataTableV_DICDEPART(ds.Tables["V_DICDEPART"]));
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
		/// 对于数据表V_DICDEPART的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableV_DICDEPART V_DICDEPART 
		{
			get
			{
				return this.tableV_DICDEPART;
			}
		}	
	
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetV_DICDEPART cln = ((DataSetV_DICDEPART)(base.Clone()));
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
		
			if ((ds.Tables["V_DICDEPART"] != null)) 
			{
				this.Tables.Add(new DataTableV_DICDEPART(ds.Tables["V_DICDEPART"]));
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
		
			this.tableV_DICDEPART = ((DataTableV_DICDEPART)(this.Tables["V_DICDEPART"]));
			if ((this.tableV_DICDEPART != null)) {
				this.tableV_DICDEPART.InitVars();
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
			
			this.tableV_DICDEPART = new DataTableV_DICDEPART();
			this.Tables.Add(this.tableV_DICDEPART);
		
			
		
		}
	
		private bool ShouldSerializeV_DICDEPART() 
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

    public delegate void RowChangeEventHandlerV_DICDEPART(object sender, RowChangeEventV_DICDEPART e);
	
	
	#region DataTableV_DICDEPART
	/// 
	/// 对于数据表V_DICDEPART的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableV_DICDEPART : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVDEPARTNAME;
		
        private DataColumn columnNOPHZID;
		
        private DataColumn columnPINYINMA;
		
        private DataColumn columnNISDISABLED;
		
        private DataColumn columnNHOSID;
		
        private DataColumn columnVDEPARTCODE;
		
        internal DataTableV_DICDEPART() : base("V_DICDEPART") 
        {
            this.InitClass();
        }
        
        internal DataTableV_DICDEPART(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVDEPARTNAME 
        {
            get 
            {
                return this.columnVDEPARTNAME;
            }
        }
		
        public DataColumn ColumnNOPHZID 
        {
            get 
            {
                return this.columnNOPHZID;
            }
        }
		
        public DataColumn ColumnPINYINMA 
        {
            get 
            {
                return this.columnPINYINMA;
            }
        }
		
        public DataColumn ColumnNISDISABLED 
        {
            get 
            {
                return this.columnNISDISABLED;
            }
        }
		
        public DataColumn ColumnNHOSID 
        {
            get 
            {
                return this.columnNHOSID;
            }
        }
		
        public DataColumn ColumnVDEPARTCODE 
        {
            get 
            {
                return this.columnVDEPARTCODE;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowV_DICDEPART this[int index] 
        {
            get 
            {
                return ((RowV_DICDEPART)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerV_DICDEPART RowChangedV_DICDEPART;
        
        public event RowChangeEventHandlerV_DICDEPART RowChangingV_DICDEPART;
        
        public event RowChangeEventHandlerV_DICDEPART RowDeletedV_DICDEPART;
        
        public event RowChangeEventHandlerV_DICDEPART RowDeletingV_DICDEPART;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowV_DICDEPART(RowV_DICDEPART row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowV_DICDEPART AddRowV_DICDEPART(System.String VDEPARTNAME,System.String NOPHZID,System.String PINYINMA,System.Int16 NISDISABLED,System.Int32 NHOSID,System.String VDEPARTCODE) 
        {
            RowV_DICDEPART row = ((RowV_DICDEPART)(this.NewRow()));
            row.ItemArray = new object[] {VDEPARTNAME,NOPHZID,PINYINMA,NISDISABLED,NHOSID,VDEPARTCODE};
            this.Rows.Add(row);
            return row;
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
            DataTableV_DICDEPART cln = ((DataTableV_DICDEPART)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableV_DICDEPART();
        }
        
        internal void InitVars() 
        {	
            this.columnVDEPARTNAME = this.Columns["VDEPARTNAME"];
            this.columnNOPHZID = this.Columns["NOPHZID"];
            this.columnPINYINMA = this.Columns["PINYINMA"];
            this.columnNISDISABLED = this.Columns["NISDISABLED"];
            this.columnNHOSID = this.Columns["NHOSID"];
            this.columnVDEPARTCODE = this.Columns["VDEPARTCODE"];
        }
        
        private void InitClass() 
        {	
            this.columnVDEPARTNAME = new DataColumn("VDEPARTNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPARTNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPARTNAME);
			
            this.columnNOPHZID = new DataColumn("NOPHZID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNOPHZID.AllowDBNull = true;
            this.Columns.Add(this.columnNOPHZID);
			
            this.columnPINYINMA = new DataColumn("PINYINMA", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnPINYINMA.AllowDBNull = true;
            this.Columns.Add(this.columnPINYINMA);
			
            this.columnNISDISABLED = new DataColumn("NISDISABLED", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNISDISABLED.AllowDBNull = true;
            this.Columns.Add(this.columnNISDISABLED);
			
            this.columnNHOSID = new DataColumn("NHOSID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNHOSID.AllowDBNull = true;
            this.Columns.Add(this.columnNHOSID);
			
            this.columnVDEPARTCODE = new DataColumn("VDEPARTCODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPARTCODE.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPARTCODE);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowV_DICDEPART NewRowV_DICDEPART() {
            return ((RowV_DICDEPART)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowV_DICDEPART(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowV_DICDEPART);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedV_DICDEPART != null)) {
                this.RowChangedV_DICDEPART(this, new RowChangeEventV_DICDEPART(((RowV_DICDEPART)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingV_DICDEPART != null)) {
                this.RowChangingV_DICDEPART(this, new RowChangeEventV_DICDEPART(((RowV_DICDEPART)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedV_DICDEPART != null)) {
                this.RowDeletedV_DICDEPART(this, new RowChangeEventV_DICDEPART(((RowV_DICDEPART)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingV_DICDEPART != null)) {
                this.RowDeletingV_DICDEPART(this, new RowChangeEventV_DICDEPART(((RowV_DICDEPART)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowV_DICDEPART(RowV_DICDEPART row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowV_DICDEPART
	/// 
	/// 数据表V_DICDEPART行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowV_DICDEPART : DataRow 
    {
        
        private DataTableV_DICDEPART tableV_DICDEPART;
        
        internal RowV_DICDEPART(DataRowBuilder rb) : base(rb) 
        {
            this.tableV_DICDEPART = ((DataTableV_DICDEPART)(this.Table));
        }        
		
		/// 
		/// 字段VDEPARTNAME所映射的属性。
		/// 
        public System.String VDEPARTNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_DICDEPART.ColumnVDEPARTNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_DICDEPART.ColumnVDEPARTNAME] = value;
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
	                return ((System.String)(this[this.tableV_DICDEPART.ColumnNOPHZID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_DICDEPART.ColumnNOPHZID] = value;
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
	                return ((System.String)(this[this.tableV_DICDEPART.ColumnPINYINMA])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_DICDEPART.ColumnPINYINMA] = value;
            }
        }
        
		/// 
		/// 字段NISDISABLED所映射的属性。
		/// 
        public System.Int16 NISDISABLED
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableV_DICDEPART.ColumnNISDISABLED])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableV_DICDEPART.ColumnNISDISABLED] = value;
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
	                return ((System.Int32)(this[this.tableV_DICDEPART.ColumnNHOSID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableV_DICDEPART.ColumnNHOSID] = value;
            }
        }
        
		/// 
		/// 字段VDEPARTCODE所映射的属性。
		/// 
        public System.String VDEPARTCODE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_DICDEPART.ColumnVDEPARTCODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_DICDEPART.ColumnVDEPARTCODE] = value;
            }
        }
        
		/// 
		/// 判断字段VDEPARTNAME是否为空。
		/// 
        public bool IsVDEPARTNAMENull()
        {
            return this.IsNull(this.tableV_DICDEPART.ColumnVDEPARTNAME);
        }

		/// 
		/// 设置字段VDEPARTNAME为空值。
		/// 
        public void SetVDEPARTNAMENull() 
        {
            this[this.tableV_DICDEPART.ColumnVDEPARTNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NOPHZID是否为空。
		/// 
        public bool IsNOPHZIDNull()
        {
            return this.IsNull(this.tableV_DICDEPART.ColumnNOPHZID);
        }

		/// 
		/// 设置字段NOPHZID为空值。
		/// 
        public void SetNOPHZIDNull() 
        {
            this[this.tableV_DICDEPART.ColumnNOPHZID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段PINYINMA是否为空。
		/// 
        public bool IsPINYINMANull()
        {
            return this.IsNull(this.tableV_DICDEPART.ColumnPINYINMA);
        }

		/// 
		/// 设置字段PINYINMA为空值。
		/// 
        public void SetPINYINMANull() 
        {
            this[this.tableV_DICDEPART.ColumnPINYINMA] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NISDISABLED是否为空。
		/// 
        public bool IsNISDISABLEDNull()
        {
            return this.IsNull(this.tableV_DICDEPART.ColumnNISDISABLED);
        }

		/// 
		/// 设置字段NISDISABLED为空值。
		/// 
        public void SetNISDISABLEDNull() 
        {
            this[this.tableV_DICDEPART.ColumnNISDISABLED] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NHOSID是否为空。
		/// 
        public bool IsNHOSIDNull()
        {
            return this.IsNull(this.tableV_DICDEPART.ColumnNHOSID);
        }

		/// 
		/// 设置字段NHOSID为空值。
		/// 
        public void SetNHOSIDNull() 
        {
            this[this.tableV_DICDEPART.ColumnNHOSID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDEPARTCODE是否为空。
		/// 
        public bool IsVDEPARTCODENull()
        {
            return this.IsNull(this.tableV_DICDEPART.ColumnVDEPARTCODE);
        }

		/// 
		/// 设置字段VDEPARTCODE为空值。
		/// 
        public void SetVDEPARTCODENull() 
        {
            this[this.tableV_DICDEPART.ColumnVDEPARTCODE] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventV_DICDEPART : EventArgs {
        
        private RowV_DICDEPART eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventV_DICDEPART(RowV_DICDEPART row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowV_DICDEPART Row {
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
	