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
	#region DataSetV_DAOHANG_INFO
	/// 
	/// ,V_DAOHANG_INFO的视图实体。
	/// 
    [Serializable()]
    public class DataSetV_DAOHANG_INFO : DataSet
    {
	
		private DataTableV_DAOHANG_INFO tableV_DAOHANG_INFO;

	
        public DataSetV_DAOHANG_INFO() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetV_DAOHANG_INFO实体。
		/// 
		public DataSetV_DAOHANG_INFO GetChangesEntity(DataRowState ds)
		{
			DataSetV_DAOHANG_INFO dataSet = (DataSetV_DAOHANG_INFO)this.GetChanges(ds);
			return dataSet;		
		}
        
        protected DataSetV_DAOHANG_INFO(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
		
                if ((ds.Tables["V_DAOHANG_INFO"] != null)) 
                {
                    this.Tables.Add(new DataTableV_DAOHANG_INFO(ds.Tables["V_DAOHANG_INFO"]));
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
		/// 对于数据表V_DAOHANG_INFO的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableV_DAOHANG_INFO V_DAOHANG_INFO 
		{
			get
			{
				return this.tableV_DAOHANG_INFO;
			}
		}	
	
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetV_DAOHANG_INFO cln = ((DataSetV_DAOHANG_INFO)(base.Clone()));
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
		
			if ((ds.Tables["V_DAOHANG_INFO"] != null)) 
			{
				this.Tables.Add(new DataTableV_DAOHANG_INFO(ds.Tables["V_DAOHANG_INFO"]));
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
		
			this.tableV_DAOHANG_INFO = ((DataTableV_DAOHANG_INFO)(this.Tables["V_DAOHANG_INFO"]));
			if ((this.tableV_DAOHANG_INFO != null)) {
				this.tableV_DAOHANG_INFO.InitVars();
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
			
			this.tableV_DAOHANG_INFO = new DataTableV_DAOHANG_INFO();
			this.Tables.Add(this.tableV_DAOHANG_INFO);
		
			
		
		}
	
		private bool ShouldSerializeV_DAOHANG_INFO() 
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

    public delegate void RowChangeEventHandlerV_DAOHANG_INFO(object sender, RowChangeEventV_DAOHANG_INFO e);
	
	
	#region DataTableV_DAOHANG_INFO
	/// 
	/// 对于数据表V_DAOHANG_INFO的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableV_DAOHANG_INFO : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnFLOORNAME;
		
        private DataColumn columnFLOORMAP;
		
        private DataColumn columnHOSPITALID;
		
        private DataColumn columnFLOORNUM;
		
        private DataColumn columnDEPARTCODE;
		
        private DataColumn columnID;
		
        private DataColumn columnDEPARTNAME;
		
        private DataColumn columnFLOORNUMMAP;
		
        private DataColumn columnINID;
		
        internal DataTableV_DAOHANG_INFO() : base("V_DAOHANG_INFO") 
        {
            this.InitClass();
        }
        
        internal DataTableV_DAOHANG_INFO(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnFLOORNAME 
        {
            get 
            {
                return this.columnFLOORNAME;
            }
        }
		
        public DataColumn ColumnFLOORMAP 
        {
            get 
            {
                return this.columnFLOORMAP;
            }
        }
		
        public DataColumn ColumnHOSPITALID 
        {
            get 
            {
                return this.columnHOSPITALID;
            }
        }
		
        public DataColumn ColumnFLOORNUM 
        {
            get 
            {
                return this.columnFLOORNUM;
            }
        }
		
        public DataColumn ColumnDEPARTCODE 
        {
            get 
            {
                return this.columnDEPARTCODE;
            }
        }
		
        public DataColumn ColumnID 
        {
            get 
            {
                return this.columnID;
            }
        }
		
        public DataColumn ColumnDEPARTNAME 
        {
            get 
            {
                return this.columnDEPARTNAME;
            }
        }
		
        public DataColumn ColumnFLOORNUMMAP 
        {
            get 
            {
                return this.columnFLOORNUMMAP;
            }
        }
		
        public DataColumn ColumnINID 
        {
            get 
            {
                return this.columnINID;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowV_DAOHANG_INFO this[int index] 
        {
            get 
            {
                return ((RowV_DAOHANG_INFO)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerV_DAOHANG_INFO RowChangedV_DAOHANG_INFO;
        
        public event RowChangeEventHandlerV_DAOHANG_INFO RowChangingV_DAOHANG_INFO;
        
        public event RowChangeEventHandlerV_DAOHANG_INFO RowDeletedV_DAOHANG_INFO;
        
        public event RowChangeEventHandlerV_DAOHANG_INFO RowDeletingV_DAOHANG_INFO;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowV_DAOHANG_INFO(RowV_DAOHANG_INFO row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowV_DAOHANG_INFO AddRowV_DAOHANG_INFO(System.String FLOORNAME,System.Byte[] FLOORMAP,System.String HOSPITALID,System.String FLOORNUM,System.String DEPARTCODE,System.String ID,System.String DEPARTNAME,System.Byte[] FLOORNUMMAP,System.String INID) 
        {
            RowV_DAOHANG_INFO row = ((RowV_DAOHANG_INFO)(this.NewRow()));
            row.ItemArray = new object[] {FLOORNAME,FLOORMAP,HOSPITALID,FLOORNUM,DEPARTCODE,ID,DEPARTNAME,FLOORNUMMAP,INID};
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
            DataTableV_DAOHANG_INFO cln = ((DataTableV_DAOHANG_INFO)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableV_DAOHANG_INFO();
        }
        
        internal void InitVars() 
        {	
            this.columnFLOORNAME = this.Columns["FLOORNAME"];
            this.columnFLOORMAP = this.Columns["FLOORMAP"];
            this.columnHOSPITALID = this.Columns["HOSPITALID"];
            this.columnFLOORNUM = this.Columns["FLOORNUM"];
            this.columnDEPARTCODE = this.Columns["DEPARTCODE"];
            this.columnID = this.Columns["ID"];
            this.columnDEPARTNAME = this.Columns["DEPARTNAME"];
            this.columnFLOORNUMMAP = this.Columns["FLOORNUMMAP"];
            this.columnINID = this.Columns["INID"];
        }
        
        private void InitClass() 
        {	
            this.columnFLOORNAME = new DataColumn("FLOORNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnFLOORNAME.AllowDBNull = true;
            this.Columns.Add(this.columnFLOORNAME);
			
            this.columnFLOORMAP = new DataColumn("FLOORMAP", typeof(System.Byte[]), null, System.Data.MappingType.Element);
            this.columnFLOORMAP.AllowDBNull = true;
            this.Columns.Add(this.columnFLOORMAP);
			
            this.columnHOSPITALID = new DataColumn("HOSPITALID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnHOSPITALID.AllowDBNull = true;
            this.Columns.Add(this.columnHOSPITALID);
			
            this.columnFLOORNUM = new DataColumn("FLOORNUM", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnFLOORNUM.AllowDBNull = true;
            this.Columns.Add(this.columnFLOORNUM);
			
            this.columnDEPARTCODE = new DataColumn("DEPARTCODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnDEPARTCODE.AllowDBNull = true;
            this.Columns.Add(this.columnDEPARTCODE);
			
            this.columnID = new DataColumn("ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnID.AllowDBNull = true;
            this.Columns.Add(this.columnID);
			
            this.columnDEPARTNAME = new DataColumn("DEPARTNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnDEPARTNAME.AllowDBNull = true;
            this.Columns.Add(this.columnDEPARTNAME);
			
            this.columnFLOORNUMMAP = new DataColumn("FLOORNUMMAP", typeof(System.Byte[]), null, System.Data.MappingType.Element);
            this.columnFLOORNUMMAP.AllowDBNull = true;
            this.Columns.Add(this.columnFLOORNUMMAP);
			
            this.columnINID = new DataColumn("INID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnINID.AllowDBNull = true;
            this.Columns.Add(this.columnINID);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowV_DAOHANG_INFO NewRowV_DAOHANG_INFO() {
            return ((RowV_DAOHANG_INFO)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowV_DAOHANG_INFO(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowV_DAOHANG_INFO);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedV_DAOHANG_INFO != null)) {
                this.RowChangedV_DAOHANG_INFO(this, new RowChangeEventV_DAOHANG_INFO(((RowV_DAOHANG_INFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingV_DAOHANG_INFO != null)) {
                this.RowChangingV_DAOHANG_INFO(this, new RowChangeEventV_DAOHANG_INFO(((RowV_DAOHANG_INFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedV_DAOHANG_INFO != null)) {
                this.RowDeletedV_DAOHANG_INFO(this, new RowChangeEventV_DAOHANG_INFO(((RowV_DAOHANG_INFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingV_DAOHANG_INFO != null)) {
                this.RowDeletingV_DAOHANG_INFO(this, new RowChangeEventV_DAOHANG_INFO(((RowV_DAOHANG_INFO)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowV_DAOHANG_INFO(RowV_DAOHANG_INFO row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowV_DAOHANG_INFO
	/// 
	/// 数据表V_DAOHANG_INFO行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowV_DAOHANG_INFO : DataRow 
    {
        
        private DataTableV_DAOHANG_INFO tableV_DAOHANG_INFO;
        
        internal RowV_DAOHANG_INFO(DataRowBuilder rb) : base(rb) 
        {
            this.tableV_DAOHANG_INFO = ((DataTableV_DAOHANG_INFO)(this.Table));
        }        
		
		/// 
		/// 字段FLOORNAME所映射的属性。
		/// 
        public System.String FLOORNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_DAOHANG_INFO.ColumnFLOORNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_DAOHANG_INFO.ColumnFLOORNAME] = value;
            }
        }
        
		/// 
		/// 字段FLOORMAP所映射的属性。
		/// 
        public System.Byte[] FLOORMAP
        {
            get 
            {	
                try 
                {
	                return ((System.Byte[])(this[this.tableV_DAOHANG_INFO.ColumnFLOORMAP])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_DAOHANG_INFO.ColumnFLOORMAP] = value;
            }
        }
        
		/// 
		/// 字段HOSPITALID所映射的属性。
		/// 
        public System.String HOSPITALID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_DAOHANG_INFO.ColumnHOSPITALID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_DAOHANG_INFO.ColumnHOSPITALID] = value;
            }
        }
        
		/// 
		/// 字段FLOORNUM所映射的属性。
		/// 
        public System.String FLOORNUM
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_DAOHANG_INFO.ColumnFLOORNUM])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_DAOHANG_INFO.ColumnFLOORNUM] = value;
            }
        }
        
		/// 
		/// 字段DEPARTCODE所映射的属性。
		/// 
        public System.String DEPARTCODE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_DAOHANG_INFO.ColumnDEPARTCODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_DAOHANG_INFO.ColumnDEPARTCODE] = value;
            }
        }
        
		/// 
		/// 字段ID所映射的属性。
		/// 
        public System.String ID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_DAOHANG_INFO.ColumnID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_DAOHANG_INFO.ColumnID] = value;
            }
        }
        
		/// 
		/// 字段DEPARTNAME所映射的属性。
		/// 
        public System.String DEPARTNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_DAOHANG_INFO.ColumnDEPARTNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_DAOHANG_INFO.ColumnDEPARTNAME] = value;
            }
        }
        
		/// 
		/// 字段FLOORNUMMAP所映射的属性。
		/// 
        public System.Byte[] FLOORNUMMAP
        {
            get 
            {	
                try 
                {
	                return ((System.Byte[])(this[this.tableV_DAOHANG_INFO.ColumnFLOORNUMMAP])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_DAOHANG_INFO.ColumnFLOORNUMMAP] = value;
            }
        }
        
		/// 
		/// 字段INID所映射的属性。
		/// 
        public System.String INID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_DAOHANG_INFO.ColumnINID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_DAOHANG_INFO.ColumnINID] = value;
            }
        }
        
		/// 
		/// 判断字段FLOORNAME是否为空。
		/// 
        public bool IsFLOORNAMENull()
        {
            return this.IsNull(this.tableV_DAOHANG_INFO.ColumnFLOORNAME);
        }

		/// 
		/// 设置字段FLOORNAME为空值。
		/// 
        public void SetFLOORNAMENull() 
        {
            this[this.tableV_DAOHANG_INFO.ColumnFLOORNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段FLOORMAP是否为空。
		/// 
        public bool IsFLOORMAPNull()
        {
            return this.IsNull(this.tableV_DAOHANG_INFO.ColumnFLOORMAP);
        }

		/// 
		/// 设置字段FLOORMAP为空值。
		/// 
        public void SetFLOORMAPNull() 
        {
            this[this.tableV_DAOHANG_INFO.ColumnFLOORMAP] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段HOSPITALID是否为空。
		/// 
        public bool IsHOSPITALIDNull()
        {
            return this.IsNull(this.tableV_DAOHANG_INFO.ColumnHOSPITALID);
        }

		/// 
		/// 设置字段HOSPITALID为空值。
		/// 
        public void SetHOSPITALIDNull() 
        {
            this[this.tableV_DAOHANG_INFO.ColumnHOSPITALID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段FLOORNUM是否为空。
		/// 
        public bool IsFLOORNUMNull()
        {
            return this.IsNull(this.tableV_DAOHANG_INFO.ColumnFLOORNUM);
        }

		/// 
		/// 设置字段FLOORNUM为空值。
		/// 
        public void SetFLOORNUMNull() 
        {
            this[this.tableV_DAOHANG_INFO.ColumnFLOORNUM] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DEPARTCODE是否为空。
		/// 
        public bool IsDEPARTCODENull()
        {
            return this.IsNull(this.tableV_DAOHANG_INFO.ColumnDEPARTCODE);
        }

		/// 
		/// 设置字段DEPARTCODE为空值。
		/// 
        public void SetDEPARTCODENull() 
        {
            this[this.tableV_DAOHANG_INFO.ColumnDEPARTCODE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段ID是否为空。
		/// 
        public bool IsIDNull()
        {
            return this.IsNull(this.tableV_DAOHANG_INFO.ColumnID);
        }

		/// 
		/// 设置字段ID为空值。
		/// 
        public void SetIDNull() 
        {
            this[this.tableV_DAOHANG_INFO.ColumnID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DEPARTNAME是否为空。
		/// 
        public bool IsDEPARTNAMENull()
        {
            return this.IsNull(this.tableV_DAOHANG_INFO.ColumnDEPARTNAME);
        }

		/// 
		/// 设置字段DEPARTNAME为空值。
		/// 
        public void SetDEPARTNAMENull() 
        {
            this[this.tableV_DAOHANG_INFO.ColumnDEPARTNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段FLOORNUMMAP是否为空。
		/// 
        public bool IsFLOORNUMMAPNull()
        {
            return this.IsNull(this.tableV_DAOHANG_INFO.ColumnFLOORNUMMAP);
        }

		/// 
		/// 设置字段FLOORNUMMAP为空值。
		/// 
        public void SetFLOORNUMMAPNull() 
        {
            this[this.tableV_DAOHANG_INFO.ColumnFLOORNUMMAP] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段INID是否为空。
		/// 
        public bool IsINIDNull()
        {
            return this.IsNull(this.tableV_DAOHANG_INFO.ColumnINID);
        }

		/// 
		/// 设置字段INID为空值。
		/// 
        public void SetINIDNull() 
        {
            this[this.tableV_DAOHANG_INFO.ColumnINID] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventV_DAOHANG_INFO : EventArgs {
        
        private RowV_DAOHANG_INFO eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventV_DAOHANG_INFO(RowV_DAOHANG_INFO row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowV_DAOHANG_INFO Row {
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
	