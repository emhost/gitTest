//------------------------------------------------------------------------------
//     这部分代码属于实体定义层，是由实体编辑器工具自动产生的。
//     (Runtime Version: 1.0.0.0)
//     对此代码进行的任何修改会导致其它的行为错误，并且重新生成时所有的修改会丢失。
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Xml;
using System.Runtime.Serialization;

namespace HYHISAPPView.Entity
{
	#region DataSetHY_DEPARTMENT
	/// 
	/// ,HY_DEPARTMENT的视图实体。
	/// 
    [Serializable()]
    public class DataSetHY_DEPARTMENT : DataSet
    {
	
		private DataTableHY_DEPARTMENT tableHY_DEPARTMENT;

	
        public DataSetHY_DEPARTMENT() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetHY_DEPARTMENT实体。
		/// 
		public DataSetHY_DEPARTMENT GetChangesEntity(DataRowState ds)
		{
			DataSetHY_DEPARTMENT dataSet = (DataSetHY_DEPARTMENT)this.GetChanges(ds);
			return dataSet;		
		}
        
        protected DataSetHY_DEPARTMENT(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
		
                if ((ds.Tables["HY_DEPARTMENT"] != null)) 
                {
                    this.Tables.Add(new DataTableHY_DEPARTMENT(ds.Tables["HY_DEPARTMENT"]));
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
		/// 对于数据表HY_DEPARTMENT的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableHY_DEPARTMENT HY_DEPARTMENT 
		{
			get
			{
				return this.tableHY_DEPARTMENT;
			}
		}	
	
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetHY_DEPARTMENT cln = ((DataSetHY_DEPARTMENT)(base.Clone()));
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
		
			if ((ds.Tables["HY_DEPARTMENT"] != null)) 
			{
				this.Tables.Add(new DataTableHY_DEPARTMENT(ds.Tables["HY_DEPARTMENT"]));
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
		
			this.tableHY_DEPARTMENT = ((DataTableHY_DEPARTMENT)(this.Tables["HY_DEPARTMENT"]));
			if ((this.tableHY_DEPARTMENT != null)) {
				this.tableHY_DEPARTMENT.InitVars();
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
			
			this.tableHY_DEPARTMENT = new DataTableHY_DEPARTMENT();
			this.Tables.Add(this.tableHY_DEPARTMENT);
		
			
		
		}
	
		private bool ShouldSerializeHY_DEPARTMENT() 
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

    public delegate void RowChangeEventHandlerHY_DEPARTMENT(object sender, RowChangeEventHY_DEPARTMENT e);
	
	
	#region DataTableHY_DEPARTMENT
	/// 
	/// 对于数据表HY_DEPARTMENT的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableHY_DEPARTMENT : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVDEPARTMENTNAME;
		
        private DataColumn columnVDEPARTMENTCODE;
		
        internal DataTableHY_DEPARTMENT() : base("HY_DEPARTMENT") 
        {
            this.InitClass();
        }
        
        internal DataTableHY_DEPARTMENT(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVDEPARTMENTNAME 
        {
            get 
            {
                return this.columnVDEPARTMENTNAME;
            }
        }
		
        public DataColumn ColumnVDEPARTMENTCODE 
        {
            get 
            {
                return this.columnVDEPARTMENTCODE;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowHY_DEPARTMENT this[int index] 
        {
            get 
            {
                return ((RowHY_DEPARTMENT)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerHY_DEPARTMENT RowChangedHY_DEPARTMENT;
        
        public event RowChangeEventHandlerHY_DEPARTMENT RowChangingHY_DEPARTMENT;
        
        public event RowChangeEventHandlerHY_DEPARTMENT RowDeletedHY_DEPARTMENT;
        
        public event RowChangeEventHandlerHY_DEPARTMENT RowDeletingHY_DEPARTMENT;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowHY_DEPARTMENT(RowHY_DEPARTMENT row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowHY_DEPARTMENT AddRowHY_DEPARTMENT(System.String VDEPARTMENTNAME,System.String VDEPARTMENTCODE) 
        {
            RowHY_DEPARTMENT row = ((RowHY_DEPARTMENT)(this.NewRow()));
            row.ItemArray = new object[] {VDEPARTMENTNAME,VDEPARTMENTCODE};
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
            DataTableHY_DEPARTMENT cln = ((DataTableHY_DEPARTMENT)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableHY_DEPARTMENT();
        }
        
        internal void InitVars() 
        {	
            this.columnVDEPARTMENTNAME = this.Columns["VDEPARTMENTNAME"];
            this.columnVDEPARTMENTCODE = this.Columns["VDEPARTMENTCODE"];
        }
        
        private void InitClass() 
        {	
            this.columnVDEPARTMENTNAME = new DataColumn("VDEPARTMENTNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPARTMENTNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPARTMENTNAME);
			
            this.columnVDEPARTMENTCODE = new DataColumn("VDEPARTMENTCODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPARTMENTCODE.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPARTMENTCODE);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowHY_DEPARTMENT NewRowHY_DEPARTMENT() {
            return ((RowHY_DEPARTMENT)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowHY_DEPARTMENT(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowHY_DEPARTMENT);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedHY_DEPARTMENT != null)) {
                this.RowChangedHY_DEPARTMENT(this, new RowChangeEventHY_DEPARTMENT(((RowHY_DEPARTMENT)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingHY_DEPARTMENT != null)) {
                this.RowChangingHY_DEPARTMENT(this, new RowChangeEventHY_DEPARTMENT(((RowHY_DEPARTMENT)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedHY_DEPARTMENT != null)) {
                this.RowDeletedHY_DEPARTMENT(this, new RowChangeEventHY_DEPARTMENT(((RowHY_DEPARTMENT)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingHY_DEPARTMENT != null)) {
                this.RowDeletingHY_DEPARTMENT(this, new RowChangeEventHY_DEPARTMENT(((RowHY_DEPARTMENT)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowHY_DEPARTMENT(RowHY_DEPARTMENT row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowHY_DEPARTMENT
	/// 
	/// 数据表HY_DEPARTMENT行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowHY_DEPARTMENT : DataRow 
    {
        
        private DataTableHY_DEPARTMENT tableHY_DEPARTMENT;
        
        internal RowHY_DEPARTMENT(DataRowBuilder rb) : base(rb) 
        {
            this.tableHY_DEPARTMENT = ((DataTableHY_DEPARTMENT)(this.Table));
        }        
		
		/// 
		/// 字段VDEPARTMENTNAME所映射的属性。
		/// 
        public System.String VDEPARTMENTNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableHY_DEPARTMENT.ColumnVDEPARTMENTNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableHY_DEPARTMENT.ColumnVDEPARTMENTNAME] = value;
            }
        }
        
		/// 
		/// 字段VDEPARTMENTCODE所映射的属性。
		/// 
        public System.String VDEPARTMENTCODE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableHY_DEPARTMENT.ColumnVDEPARTMENTCODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableHY_DEPARTMENT.ColumnVDEPARTMENTCODE] = value;
            }
        }
        
		/// 
		/// 判断字段VDEPARTMENTNAME是否为空。
		/// 
        public bool IsVDEPARTMENTNAMENull()
        {
            return this.IsNull(this.tableHY_DEPARTMENT.ColumnVDEPARTMENTNAME);
        }

		/// 
		/// 设置字段VDEPARTMENTNAME为空值。
		/// 
        public void SetVDEPARTMENTNAMENull() 
        {
            this[this.tableHY_DEPARTMENT.ColumnVDEPARTMENTNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDEPARTMENTCODE是否为空。
		/// 
        public bool IsVDEPARTMENTCODENull()
        {
            return this.IsNull(this.tableHY_DEPARTMENT.ColumnVDEPARTMENTCODE);
        }

		/// 
		/// 设置字段VDEPARTMENTCODE为空值。
		/// 
        public void SetVDEPARTMENTCODENull() 
        {
            this[this.tableHY_DEPARTMENT.ColumnVDEPARTMENTCODE] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventHY_DEPARTMENT : EventArgs {
        
        private RowHY_DEPARTMENT eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventHY_DEPARTMENT(RowHY_DEPARTMENT row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowHY_DEPARTMENT Row {
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
	