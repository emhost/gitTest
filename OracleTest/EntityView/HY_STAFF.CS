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
	#region DataSetHY_STAFF
	/// 
	/// ,HY_STAFF的视图实体。
	/// 
    [Serializable()]
    public class DataSetHY_STAFF : DataSet
    {
	
		private DataTableHY_STAFF tableHY_STAFF;

	
        public DataSetHY_STAFF() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetHY_STAFF实体。
		/// 
		public DataSetHY_STAFF GetChangesEntity(DataRowState ds)
		{
			DataSetHY_STAFF dataSet = (DataSetHY_STAFF)this.GetChanges(ds);
			return dataSet;		
		}
        
        protected DataSetHY_STAFF(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
		
                if ((ds.Tables["HY_STAFF"] != null)) 
                {
                    this.Tables.Add(new DataTableHY_STAFF(ds.Tables["HY_STAFF"]));
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
		/// 对于数据表HY_STAFF的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableHY_STAFF HY_STAFF 
		{
			get
			{
				return this.tableHY_STAFF;
			}
		}	
	
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetHY_STAFF cln = ((DataSetHY_STAFF)(base.Clone()));
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
		
			if ((ds.Tables["HY_STAFF"] != null)) 
			{
				this.Tables.Add(new DataTableHY_STAFF(ds.Tables["HY_STAFF"]));
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
		
			this.tableHY_STAFF = ((DataTableHY_STAFF)(this.Tables["HY_STAFF"]));
			if ((this.tableHY_STAFF != null)) {
				this.tableHY_STAFF.InitVars();
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
			
			this.tableHY_STAFF = new DataTableHY_STAFF();
			this.Tables.Add(this.tableHY_STAFF);
		
			
		
		}
	
		private bool ShouldSerializeHY_STAFF() 
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

    public delegate void RowChangeEventHandlerHY_STAFF(object sender, RowChangeEventHY_STAFF e);
	
	
	#region DataTableHY_STAFF
	/// 
	/// 对于数据表HY_STAFF的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableHY_STAFF : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVSTAFFCODE;
		
        private DataColumn columnVSTAFFNAME;
		
        private DataColumn columnNSEX;
		
        private DataColumn columnSEXNAME;
		
        private DataColumn columnNBIRTHDAY;
		
        private DataColumn columnVLOGINUSERNAME;
		
        private DataColumn columnVLOGINPASSWORD;
		
        private DataColumn columnNSTAFFSTATUS;
		
        private DataColumn columnISSTOP;
		
        private DataColumn columnNJOBID;
		
        private DataColumn columnJOBNAME;
		
        private DataColumn columnVDEPARTCODE;
		
        private DataColumn columnVDEPARTNAME;
		
        private DataColumn columnNROLEID;
		
        private DataColumn columnVROLENAME;
		
        private DataColumn columnNPROFESSIONID;
		
        private DataColumn columnVPROFESSIONNAME;
		
        internal DataTableHY_STAFF() : base("HY_STAFF") 
        {
            this.InitClass();
        }
        
        internal DataTableHY_STAFF(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVSTAFFCODE 
        {
            get 
            {
                return this.columnVSTAFFCODE;
            }
        }
		
        public DataColumn ColumnVSTAFFNAME 
        {
            get 
            {
                return this.columnVSTAFFNAME;
            }
        }
		
        public DataColumn ColumnNSEX 
        {
            get 
            {
                return this.columnNSEX;
            }
        }
		
        public DataColumn ColumnSEXNAME 
        {
            get 
            {
                return this.columnSEXNAME;
            }
        }
		
        public DataColumn ColumnNBIRTHDAY 
        {
            get 
            {
                return this.columnNBIRTHDAY;
            }
        }
		
        public DataColumn ColumnVLOGINUSERNAME 
        {
            get 
            {
                return this.columnVLOGINUSERNAME;
            }
        }
		
        public DataColumn ColumnVLOGINPASSWORD 
        {
            get 
            {
                return this.columnVLOGINPASSWORD;
            }
        }
		
        public DataColumn ColumnNSTAFFSTATUS 
        {
            get 
            {
                return this.columnNSTAFFSTATUS;
            }
        }
		
        public DataColumn ColumnISSTOP 
        {
            get 
            {
                return this.columnISSTOP;
            }
        }
		
        public DataColumn ColumnNJOBID 
        {
            get 
            {
                return this.columnNJOBID;
            }
        }
		
        public DataColumn ColumnJOBNAME 
        {
            get 
            {
                return this.columnJOBNAME;
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
		
        public DataColumn ColumnNROLEID 
        {
            get 
            {
                return this.columnNROLEID;
            }
        }
		
        public DataColumn ColumnVROLENAME 
        {
            get 
            {
                return this.columnVROLENAME;
            }
        }
		
        public DataColumn ColumnNPROFESSIONID 
        {
            get 
            {
                return this.columnNPROFESSIONID;
            }
        }
		
        public DataColumn ColumnVPROFESSIONNAME 
        {
            get 
            {
                return this.columnVPROFESSIONNAME;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowHY_STAFF this[int index] 
        {
            get 
            {
                return ((RowHY_STAFF)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerHY_STAFF RowChangedHY_STAFF;
        
        public event RowChangeEventHandlerHY_STAFF RowChangingHY_STAFF;
        
        public event RowChangeEventHandlerHY_STAFF RowDeletedHY_STAFF;
        
        public event RowChangeEventHandlerHY_STAFF RowDeletingHY_STAFF;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowHY_STAFF(RowHY_STAFF row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowHY_STAFF AddRowHY_STAFF(System.String VSTAFFCODE,System.String VSTAFFNAME,System.Int16 NSEX,System.String SEXNAME,System.String NBIRTHDAY,System.String VLOGINUSERNAME,System.String VLOGINPASSWORD,System.Int32 NSTAFFSTATUS,System.String ISSTOP,System.Int32 NJOBID,System.String JOBNAME,System.String VDEPARTCODE,System.String VDEPARTNAME,System.Int32 NROLEID,System.String VROLENAME,System.Int32 NPROFESSIONID,System.String VPROFESSIONNAME) 
        {
            RowHY_STAFF row = ((RowHY_STAFF)(this.NewRow()));
            row.ItemArray = new object[] {VSTAFFCODE,VSTAFFNAME,NSEX,SEXNAME,NBIRTHDAY,VLOGINUSERNAME,VLOGINPASSWORD,NSTAFFSTATUS,ISSTOP,NJOBID,JOBNAME,VDEPARTCODE,VDEPARTNAME,NROLEID,VROLENAME,NPROFESSIONID,VPROFESSIONNAME};
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
            DataTableHY_STAFF cln = ((DataTableHY_STAFF)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableHY_STAFF();
        }
        
        internal void InitVars() 
        {	
            this.columnVSTAFFCODE = this.Columns["VSTAFFCODE"];
            this.columnVSTAFFNAME = this.Columns["VSTAFFNAME"];
            this.columnNSEX = this.Columns["NSEX"];
            this.columnSEXNAME = this.Columns["SEXNAME"];
            this.columnNBIRTHDAY = this.Columns["NBIRTHDAY"];
            this.columnVLOGINUSERNAME = this.Columns["VLOGINUSERNAME"];
            this.columnVLOGINPASSWORD = this.Columns["VLOGINPASSWORD"];
            this.columnNSTAFFSTATUS = this.Columns["NSTAFFSTATUS"];
            this.columnISSTOP = this.Columns["ISSTOP"];
            this.columnNJOBID = this.Columns["NJOBID"];
            this.columnJOBNAME = this.Columns["JOBNAME"];
            this.columnVDEPARTCODE = this.Columns["VDEPARTCODE"];
            this.columnVDEPARTNAME = this.Columns["VDEPARTNAME"];
            this.columnNROLEID = this.Columns["NROLEID"];
            this.columnVROLENAME = this.Columns["VROLENAME"];
            this.columnNPROFESSIONID = this.Columns["NPROFESSIONID"];
            this.columnVPROFESSIONNAME = this.Columns["VPROFESSIONNAME"];
        }
        
        private void InitClass() 
        {	
            this.columnVSTAFFCODE = new DataColumn("VSTAFFCODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVSTAFFCODE.AllowDBNull = true;
            this.Columns.Add(this.columnVSTAFFCODE);
			
            this.columnVSTAFFNAME = new DataColumn("VSTAFFNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVSTAFFNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVSTAFFNAME);
			
            this.columnNSEX = new DataColumn("NSEX", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNSEX.AllowDBNull = true;
            this.Columns.Add(this.columnNSEX);
			
            this.columnSEXNAME = new DataColumn("SEXNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnSEXNAME.AllowDBNull = true;
            this.Columns.Add(this.columnSEXNAME);
			
            this.columnNBIRTHDAY = new DataColumn("NBIRTHDAY", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNBIRTHDAY.AllowDBNull = true;
            this.Columns.Add(this.columnNBIRTHDAY);
			
            this.columnVLOGINUSERNAME = new DataColumn("VLOGINUSERNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVLOGINUSERNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVLOGINUSERNAME);
			
            this.columnVLOGINPASSWORD = new DataColumn("VLOGINPASSWORD", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVLOGINPASSWORD.AllowDBNull = true;
            this.Columns.Add(this.columnVLOGINPASSWORD);
			
            this.columnNSTAFFSTATUS = new DataColumn("NSTAFFSTATUS", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNSTAFFSTATUS.AllowDBNull = true;
            this.Columns.Add(this.columnNSTAFFSTATUS);
			
            this.columnISSTOP = new DataColumn("ISSTOP", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnISSTOP.AllowDBNull = true;
            this.Columns.Add(this.columnISSTOP);
			
            this.columnNJOBID = new DataColumn("NJOBID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNJOBID.AllowDBNull = true;
            this.Columns.Add(this.columnNJOBID);
			
            this.columnJOBNAME = new DataColumn("JOBNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnJOBNAME.AllowDBNull = true;
            this.Columns.Add(this.columnJOBNAME);
			
            this.columnVDEPARTCODE = new DataColumn("VDEPARTCODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPARTCODE.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPARTCODE);
			
            this.columnVDEPARTNAME = new DataColumn("VDEPARTNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPARTNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPARTNAME);
			
            this.columnNROLEID = new DataColumn("NROLEID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNROLEID.AllowDBNull = true;
            this.Columns.Add(this.columnNROLEID);
			
            this.columnVROLENAME = new DataColumn("VROLENAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVROLENAME.AllowDBNull = true;
            this.Columns.Add(this.columnVROLENAME);
			
            this.columnNPROFESSIONID = new DataColumn("NPROFESSIONID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNPROFESSIONID.AllowDBNull = true;
            this.Columns.Add(this.columnNPROFESSIONID);
			
            this.columnVPROFESSIONNAME = new DataColumn("VPROFESSIONNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPROFESSIONNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVPROFESSIONNAME);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowHY_STAFF NewRowHY_STAFF() {
            return ((RowHY_STAFF)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowHY_STAFF(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowHY_STAFF);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedHY_STAFF != null)) {
                this.RowChangedHY_STAFF(this, new RowChangeEventHY_STAFF(((RowHY_STAFF)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingHY_STAFF != null)) {
                this.RowChangingHY_STAFF(this, new RowChangeEventHY_STAFF(((RowHY_STAFF)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedHY_STAFF != null)) {
                this.RowDeletedHY_STAFF(this, new RowChangeEventHY_STAFF(((RowHY_STAFF)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingHY_STAFF != null)) {
                this.RowDeletingHY_STAFF(this, new RowChangeEventHY_STAFF(((RowHY_STAFF)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowHY_STAFF(RowHY_STAFF row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowHY_STAFF
	/// 
	/// 数据表HY_STAFF行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowHY_STAFF : DataRow 
    {
        
        private DataTableHY_STAFF tableHY_STAFF;
        
        internal RowHY_STAFF(DataRowBuilder rb) : base(rb) 
        {
            this.tableHY_STAFF = ((DataTableHY_STAFF)(this.Table));
        }        
		
		/// 
		/// 字段VSTAFFCODE所映射的属性。
		/// 
        public System.String VSTAFFCODE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableHY_STAFF.ColumnVSTAFFCODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableHY_STAFF.ColumnVSTAFFCODE] = value;
            }
        }
        
		/// 
		/// 字段VSTAFFNAME所映射的属性。
		/// 
        public System.String VSTAFFNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableHY_STAFF.ColumnVSTAFFNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableHY_STAFF.ColumnVSTAFFNAME] = value;
            }
        }
        
		/// 
		/// 字段NSEX所映射的属性。
		/// 
        public System.Int16 NSEX
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableHY_STAFF.ColumnNSEX])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableHY_STAFF.ColumnNSEX] = value;
            }
        }
        
		/// 
		/// 字段SEXNAME所映射的属性。
		/// 
        public System.String SEXNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableHY_STAFF.ColumnSEXNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableHY_STAFF.ColumnSEXNAME] = value;
            }
        }
        
		/// 
		/// 字段NBIRTHDAY所映射的属性。
		/// 
        public System.String NBIRTHDAY
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableHY_STAFF.ColumnNBIRTHDAY])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableHY_STAFF.ColumnNBIRTHDAY] = value;
            }
        }
        
		/// 
		/// 字段VLOGINUSERNAME所映射的属性。
		/// 
        public System.String VLOGINUSERNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableHY_STAFF.ColumnVLOGINUSERNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableHY_STAFF.ColumnVLOGINUSERNAME] = value;
            }
        }
        
		/// 
		/// 字段VLOGINPASSWORD所映射的属性。
		/// 
        public System.String VLOGINPASSWORD
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableHY_STAFF.ColumnVLOGINPASSWORD])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableHY_STAFF.ColumnVLOGINPASSWORD] = value;
            }
        }
        
		/// 
		/// 字段NSTAFFSTATUS所映射的属性。
		/// 
        public System.Int32 NSTAFFSTATUS
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableHY_STAFF.ColumnNSTAFFSTATUS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableHY_STAFF.ColumnNSTAFFSTATUS] = value;
            }
        }
        
		/// 
		/// 字段ISSTOP所映射的属性。
		/// 
        public System.String ISSTOP
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableHY_STAFF.ColumnISSTOP])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableHY_STAFF.ColumnISSTOP] = value;
            }
        }
        
		/// 
		/// 字段NJOBID所映射的属性。
		/// 
        public System.Int32 NJOBID
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableHY_STAFF.ColumnNJOBID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableHY_STAFF.ColumnNJOBID] = value;
            }
        }
        
		/// 
		/// 字段JOBNAME所映射的属性。
		/// 
        public System.String JOBNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableHY_STAFF.ColumnJOBNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableHY_STAFF.ColumnJOBNAME] = value;
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
	                return ((System.String)(this[this.tableHY_STAFF.ColumnVDEPARTCODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableHY_STAFF.ColumnVDEPARTCODE] = value;
            }
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
	                return ((System.String)(this[this.tableHY_STAFF.ColumnVDEPARTNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableHY_STAFF.ColumnVDEPARTNAME] = value;
            }
        }
        
		/// 
		/// 字段NROLEID所映射的属性。
		/// 
        public System.Int32 NROLEID
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableHY_STAFF.ColumnNROLEID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableHY_STAFF.ColumnNROLEID] = value;
            }
        }
        
		/// 
		/// 字段VROLENAME所映射的属性。
		/// 
        public System.String VROLENAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableHY_STAFF.ColumnVROLENAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableHY_STAFF.ColumnVROLENAME] = value;
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
	                return ((System.Int32)(this[this.tableHY_STAFF.ColumnNPROFESSIONID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableHY_STAFF.ColumnNPROFESSIONID] = value;
            }
        }
        
		/// 
		/// 字段VPROFESSIONNAME所映射的属性。
		/// 
        public System.String VPROFESSIONNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableHY_STAFF.ColumnVPROFESSIONNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableHY_STAFF.ColumnVPROFESSIONNAME] = value;
            }
        }
        
		/// 
		/// 判断字段VSTAFFCODE是否为空。
		/// 
        public bool IsVSTAFFCODENull()
        {
            return this.IsNull(this.tableHY_STAFF.ColumnVSTAFFCODE);
        }

		/// 
		/// 设置字段VSTAFFCODE为空值。
		/// 
        public void SetVSTAFFCODENull() 
        {
            this[this.tableHY_STAFF.ColumnVSTAFFCODE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VSTAFFNAME是否为空。
		/// 
        public bool IsVSTAFFNAMENull()
        {
            return this.IsNull(this.tableHY_STAFF.ColumnVSTAFFNAME);
        }

		/// 
		/// 设置字段VSTAFFNAME为空值。
		/// 
        public void SetVSTAFFNAMENull() 
        {
            this[this.tableHY_STAFF.ColumnVSTAFFNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSEX是否为空。
		/// 
        public bool IsNSEXNull()
        {
            return this.IsNull(this.tableHY_STAFF.ColumnNSEX);
        }

		/// 
		/// 设置字段NSEX为空值。
		/// 
        public void SetNSEXNull() 
        {
            this[this.tableHY_STAFF.ColumnNSEX] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段SEXNAME是否为空。
		/// 
        public bool IsSEXNAMENull()
        {
            return this.IsNull(this.tableHY_STAFF.ColumnSEXNAME);
        }

		/// 
		/// 设置字段SEXNAME为空值。
		/// 
        public void SetSEXNAMENull() 
        {
            this[this.tableHY_STAFF.ColumnSEXNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NBIRTHDAY是否为空。
		/// 
        public bool IsNBIRTHDAYNull()
        {
            return this.IsNull(this.tableHY_STAFF.ColumnNBIRTHDAY);
        }

		/// 
		/// 设置字段NBIRTHDAY为空值。
		/// 
        public void SetNBIRTHDAYNull() 
        {
            this[this.tableHY_STAFF.ColumnNBIRTHDAY] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VLOGINUSERNAME是否为空。
		/// 
        public bool IsVLOGINUSERNAMENull()
        {
            return this.IsNull(this.tableHY_STAFF.ColumnVLOGINUSERNAME);
        }

		/// 
		/// 设置字段VLOGINUSERNAME为空值。
		/// 
        public void SetVLOGINUSERNAMENull() 
        {
            this[this.tableHY_STAFF.ColumnVLOGINUSERNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VLOGINPASSWORD是否为空。
		/// 
        public bool IsVLOGINPASSWORDNull()
        {
            return this.IsNull(this.tableHY_STAFF.ColumnVLOGINPASSWORD);
        }

		/// 
		/// 设置字段VLOGINPASSWORD为空值。
		/// 
        public void SetVLOGINPASSWORDNull() 
        {
            this[this.tableHY_STAFF.ColumnVLOGINPASSWORD] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSTAFFSTATUS是否为空。
		/// 
        public bool IsNSTAFFSTATUSNull()
        {
            return this.IsNull(this.tableHY_STAFF.ColumnNSTAFFSTATUS);
        }

		/// 
		/// 设置字段NSTAFFSTATUS为空值。
		/// 
        public void SetNSTAFFSTATUSNull() 
        {
            this[this.tableHY_STAFF.ColumnNSTAFFSTATUS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段ISSTOP是否为空。
		/// 
        public bool IsISSTOPNull()
        {
            return this.IsNull(this.tableHY_STAFF.ColumnISSTOP);
        }

		/// 
		/// 设置字段ISSTOP为空值。
		/// 
        public void SetISSTOPNull() 
        {
            this[this.tableHY_STAFF.ColumnISSTOP] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NJOBID是否为空。
		/// 
        public bool IsNJOBIDNull()
        {
            return this.IsNull(this.tableHY_STAFF.ColumnNJOBID);
        }

		/// 
		/// 设置字段NJOBID为空值。
		/// 
        public void SetNJOBIDNull() 
        {
            this[this.tableHY_STAFF.ColumnNJOBID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段JOBNAME是否为空。
		/// 
        public bool IsJOBNAMENull()
        {
            return this.IsNull(this.tableHY_STAFF.ColumnJOBNAME);
        }

		/// 
		/// 设置字段JOBNAME为空值。
		/// 
        public void SetJOBNAMENull() 
        {
            this[this.tableHY_STAFF.ColumnJOBNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDEPARTCODE是否为空。
		/// 
        public bool IsVDEPARTCODENull()
        {
            return this.IsNull(this.tableHY_STAFF.ColumnVDEPARTCODE);
        }

		/// 
		/// 设置字段VDEPARTCODE为空值。
		/// 
        public void SetVDEPARTCODENull() 
        {
            this[this.tableHY_STAFF.ColumnVDEPARTCODE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDEPARTNAME是否为空。
		/// 
        public bool IsVDEPARTNAMENull()
        {
            return this.IsNull(this.tableHY_STAFF.ColumnVDEPARTNAME);
        }

		/// 
		/// 设置字段VDEPARTNAME为空值。
		/// 
        public void SetVDEPARTNAMENull() 
        {
            this[this.tableHY_STAFF.ColumnVDEPARTNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NROLEID是否为空。
		/// 
        public bool IsNROLEIDNull()
        {
            return this.IsNull(this.tableHY_STAFF.ColumnNROLEID);
        }

		/// 
		/// 设置字段NROLEID为空值。
		/// 
        public void SetNROLEIDNull() 
        {
            this[this.tableHY_STAFF.ColumnNROLEID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VROLENAME是否为空。
		/// 
        public bool IsVROLENAMENull()
        {
            return this.IsNull(this.tableHY_STAFF.ColumnVROLENAME);
        }

		/// 
		/// 设置字段VROLENAME为空值。
		/// 
        public void SetVROLENAMENull() 
        {
            this[this.tableHY_STAFF.ColumnVROLENAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NPROFESSIONID是否为空。
		/// 
        public bool IsNPROFESSIONIDNull()
        {
            return this.IsNull(this.tableHY_STAFF.ColumnNPROFESSIONID);
        }

		/// 
		/// 设置字段NPROFESSIONID为空值。
		/// 
        public void SetNPROFESSIONIDNull() 
        {
            this[this.tableHY_STAFF.ColumnNPROFESSIONID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPROFESSIONNAME是否为空。
		/// 
        public bool IsVPROFESSIONNAMENull()
        {
            return this.IsNull(this.tableHY_STAFF.ColumnVPROFESSIONNAME);
        }

		/// 
		/// 设置字段VPROFESSIONNAME为空值。
		/// 
        public void SetVPROFESSIONNAMENull() 
        {
            this[this.tableHY_STAFF.ColumnVPROFESSIONNAME] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventHY_STAFF : EventArgs {
        
        private RowHY_STAFF eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventHY_STAFF(RowHY_STAFF row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowHY_STAFF Row {
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
	