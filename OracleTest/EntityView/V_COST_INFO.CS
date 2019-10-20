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
	#region DataSetV_COST_INFO
	/// 
	/// ,V_COST_INFO的视图实体。
	/// 
    [Serializable()]
    public class DataSetV_COST_INFO : DataSet
    {
	
		private DataTableV_COST_INFO tableV_COST_INFO;

	
        public DataSetV_COST_INFO() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetV_COST_INFO实体。
		/// 
		public DataSetV_COST_INFO GetChangesEntity(DataRowState ds)
		{
			DataSetV_COST_INFO dataSet = (DataSetV_COST_INFO)this.GetChanges(ds);
			return dataSet;		
		}
        
        protected DataSetV_COST_INFO(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
		
                if ((ds.Tables["V_COST_INFO"] != null)) 
                {
                    this.Tables.Add(new DataTableV_COST_INFO(ds.Tables["V_COST_INFO"]));
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
		/// 对于数据表V_COST_INFO的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableV_COST_INFO V_COST_INFO 
		{
			get
			{
				return this.tableV_COST_INFO;
			}
		}	
	
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetV_COST_INFO cln = ((DataSetV_COST_INFO)(base.Clone()));
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
		
			if ((ds.Tables["V_COST_INFO"] != null)) 
			{
				this.Tables.Add(new DataTableV_COST_INFO(ds.Tables["V_COST_INFO"]));
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
		
			this.tableV_COST_INFO = ((DataTableV_COST_INFO)(this.Tables["V_COST_INFO"]));
			if ((this.tableV_COST_INFO != null)) {
				this.tableV_COST_INFO.InitVars();
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
			
			this.tableV_COST_INFO = new DataTableV_COST_INFO();
			this.Tables.Add(this.tableV_COST_INFO);
		
			
		
		}
	
		private bool ShouldSerializeV_COST_INFO() 
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

    public delegate void RowChangeEventHandlerV_COST_INFO(object sender, RowChangeEventV_COST_INFO e);
	
	
	#region DataTableV_COST_INFO
	/// 
	/// 对于数据表V_COST_INFO的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableV_COST_INFO : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnNFEE_ID;
		
        private DataColumn columnVCLINICNO;
		
        private DataColumn columnVITEM_NAME;
		
        private DataColumn columnDFEE_DATE;
		
        private DataColumn columnVITEM_UNITS;
		
        private DataColumn columnNITEM_PRICE;
		
        private DataColumn columnNITEM_SL;
		
        private DataColumn columnNITEM_MONEY;
		
        private DataColumn columnVDEPARTNAME;
		
        private DataColumn columnVFEE_OPERATENAME;
		
        private DataColumn columnNBACK_SL;
		
        internal DataTableV_COST_INFO() : base("V_COST_INFO") 
        {
            this.InitClass();
        }
        
        internal DataTableV_COST_INFO(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnNFEE_ID 
        {
            get 
            {
                return this.columnNFEE_ID;
            }
        }
		
        public DataColumn ColumnVCLINICNO 
        {
            get 
            {
                return this.columnVCLINICNO;
            }
        }
		
        public DataColumn ColumnVITEM_NAME 
        {
            get 
            {
                return this.columnVITEM_NAME;
            }
        }
		
        public DataColumn ColumnDFEE_DATE 
        {
            get 
            {
                return this.columnDFEE_DATE;
            }
        }
		
        public DataColumn ColumnVITEM_UNITS 
        {
            get 
            {
                return this.columnVITEM_UNITS;
            }
        }
		
        public DataColumn ColumnNITEM_PRICE 
        {
            get 
            {
                return this.columnNITEM_PRICE;
            }
        }
		
        public DataColumn ColumnNITEM_SL 
        {
            get 
            {
                return this.columnNITEM_SL;
            }
        }
		
        public DataColumn ColumnNITEM_MONEY 
        {
            get 
            {
                return this.columnNITEM_MONEY;
            }
        }
		
        public DataColumn ColumnVDEPARTNAME 
        {
            get 
            {
                return this.columnVDEPARTNAME;
            }
        }
		
        public DataColumn ColumnVFEE_OPERATENAME 
        {
            get 
            {
                return this.columnVFEE_OPERATENAME;
            }
        }
		
        public DataColumn ColumnNBACK_SL 
        {
            get 
            {
                return this.columnNBACK_SL;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowV_COST_INFO this[int index] 
        {
            get 
            {
                return ((RowV_COST_INFO)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerV_COST_INFO RowChangedV_COST_INFO;
        
        public event RowChangeEventHandlerV_COST_INFO RowChangingV_COST_INFO;
        
        public event RowChangeEventHandlerV_COST_INFO RowDeletedV_COST_INFO;
        
        public event RowChangeEventHandlerV_COST_INFO RowDeletingV_COST_INFO;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowV_COST_INFO(RowV_COST_INFO row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowV_COST_INFO AddRowV_COST_INFO(System.Int64 NFEE_ID,System.String VCLINICNO,System.String VITEM_NAME,System.DateTime DFEE_DATE,System.String VITEM_UNITS,System.Decimal NITEM_PRICE,System.Decimal NITEM_SL,System.Decimal NITEM_MONEY,System.String VDEPARTNAME,System.String VFEE_OPERATENAME,System.Decimal NBACK_SL) 
        {
            RowV_COST_INFO row = ((RowV_COST_INFO)(this.NewRow()));
            row.ItemArray = new object[] {NFEE_ID,VCLINICNO,VITEM_NAME,DFEE_DATE,VITEM_UNITS,NITEM_PRICE,NITEM_SL,NITEM_MONEY,VDEPARTNAME,VFEE_OPERATENAME,NBACK_SL};
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
            DataTableV_COST_INFO cln = ((DataTableV_COST_INFO)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableV_COST_INFO();
        }
        
        internal void InitVars() 
        {	
            this.columnNFEE_ID = this.Columns["NFEE_ID"];
            this.columnVCLINICNO = this.Columns["VCLINICNO"];
            this.columnVITEM_NAME = this.Columns["VITEM_NAME"];
            this.columnDFEE_DATE = this.Columns["DFEE_DATE"];
            this.columnVITEM_UNITS = this.Columns["VITEM_UNITS"];
            this.columnNITEM_PRICE = this.Columns["NITEM_PRICE"];
            this.columnNITEM_SL = this.Columns["NITEM_SL"];
            this.columnNITEM_MONEY = this.Columns["NITEM_MONEY"];
            this.columnVDEPARTNAME = this.Columns["VDEPARTNAME"];
            this.columnVFEE_OPERATENAME = this.Columns["VFEE_OPERATENAME"];
            this.columnNBACK_SL = this.Columns["NBACK_SL"];
        }
        
        private void InitClass() 
        {	
            this.columnNFEE_ID = new DataColumn("NFEE_ID", typeof(System.Int64), null, System.Data.MappingType.Element);
            this.columnNFEE_ID.AllowDBNull = true;
            this.Columns.Add(this.columnNFEE_ID);
			
            this.columnVCLINICNO = new DataColumn("VCLINICNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCLINICNO.AllowDBNull = true;
            this.Columns.Add(this.columnVCLINICNO);
			
            this.columnVITEM_NAME = new DataColumn("VITEM_NAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEM_NAME.AllowDBNull = true;
            this.Columns.Add(this.columnVITEM_NAME);
			
            this.columnDFEE_DATE = new DataColumn("DFEE_DATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDFEE_DATE.AllowDBNull = true;
            this.Columns.Add(this.columnDFEE_DATE);
			
            this.columnVITEM_UNITS = new DataColumn("VITEM_UNITS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEM_UNITS.AllowDBNull = true;
            this.Columns.Add(this.columnVITEM_UNITS);
			
            this.columnNITEM_PRICE = new DataColumn("NITEM_PRICE", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNITEM_PRICE.AllowDBNull = true;
            this.Columns.Add(this.columnNITEM_PRICE);
			
            this.columnNITEM_SL = new DataColumn("NITEM_SL", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNITEM_SL.AllowDBNull = true;
            this.Columns.Add(this.columnNITEM_SL);
			
            this.columnNITEM_MONEY = new DataColumn("NITEM_MONEY", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNITEM_MONEY.AllowDBNull = true;
            this.Columns.Add(this.columnNITEM_MONEY);
			
            this.columnVDEPARTNAME = new DataColumn("VDEPARTNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPARTNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPARTNAME);
			
            this.columnVFEE_OPERATENAME = new DataColumn("VFEE_OPERATENAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVFEE_OPERATENAME.AllowDBNull = true;
            this.Columns.Add(this.columnVFEE_OPERATENAME);
			
            this.columnNBACK_SL = new DataColumn("NBACK_SL", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNBACK_SL.AllowDBNull = true;
            this.Columns.Add(this.columnNBACK_SL);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowV_COST_INFO NewRowV_COST_INFO() {
            return ((RowV_COST_INFO)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowV_COST_INFO(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowV_COST_INFO);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedV_COST_INFO != null)) {
                this.RowChangedV_COST_INFO(this, new RowChangeEventV_COST_INFO(((RowV_COST_INFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingV_COST_INFO != null)) {
                this.RowChangingV_COST_INFO(this, new RowChangeEventV_COST_INFO(((RowV_COST_INFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedV_COST_INFO != null)) {
                this.RowDeletedV_COST_INFO(this, new RowChangeEventV_COST_INFO(((RowV_COST_INFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingV_COST_INFO != null)) {
                this.RowDeletingV_COST_INFO(this, new RowChangeEventV_COST_INFO(((RowV_COST_INFO)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowV_COST_INFO(RowV_COST_INFO row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowV_COST_INFO
	/// 
	/// 数据表V_COST_INFO行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowV_COST_INFO : DataRow 
    {
        
        private DataTableV_COST_INFO tableV_COST_INFO;
        
        internal RowV_COST_INFO(DataRowBuilder rb) : base(rb) 
        {
            this.tableV_COST_INFO = ((DataTableV_COST_INFO)(this.Table));
        }        
		
		/// 
		/// 字段NFEE_ID所映射的属性。
		/// 
        public System.Int64 NFEE_ID
        {
            get 
            {	
                try 
                {
	                return ((System.Int64)(this[this.tableV_COST_INFO.ColumnNFEE_ID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_COST_INFO.ColumnNFEE_ID] = value;
            }
        }
        
		/// 
		/// 字段VCLINICNO所映射的属性。
		/// 
        public System.String VCLINICNO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_COST_INFO.ColumnVCLINICNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_COST_INFO.ColumnVCLINICNO] = value;
            }
        }
        
		/// 
		/// 字段VITEM_NAME所映射的属性。
		/// 
        public System.String VITEM_NAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_COST_INFO.ColumnVITEM_NAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_COST_INFO.ColumnVITEM_NAME] = value;
            }
        }
        
		/// 
		/// 字段DFEE_DATE所映射的属性。
		/// 
        public System.DateTime DFEE_DATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableV_COST_INFO.ColumnDFEE_DATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_COST_INFO.ColumnDFEE_DATE] = value;
            }
        }
        
		/// 
		/// 字段VITEM_UNITS所映射的属性。
		/// 
        public System.String VITEM_UNITS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_COST_INFO.ColumnVITEM_UNITS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_COST_INFO.ColumnVITEM_UNITS] = value;
            }
        }
        
		/// 
		/// 字段NITEM_PRICE所映射的属性。
		/// 
        public System.Decimal NITEM_PRICE
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableV_COST_INFO.ColumnNITEM_PRICE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_COST_INFO.ColumnNITEM_PRICE] = value;
            }
        }
        
		/// 
		/// 字段NITEM_SL所映射的属性。
		/// 
        public System.Decimal NITEM_SL
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableV_COST_INFO.ColumnNITEM_SL])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_COST_INFO.ColumnNITEM_SL] = value;
            }
        }
        
		/// 
		/// 字段NITEM_MONEY所映射的属性。
		/// 
        public System.Decimal NITEM_MONEY
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableV_COST_INFO.ColumnNITEM_MONEY])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_COST_INFO.ColumnNITEM_MONEY] = value;
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
	                return ((System.String)(this[this.tableV_COST_INFO.ColumnVDEPARTNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_COST_INFO.ColumnVDEPARTNAME] = value;
            }
        }
        
		/// 
		/// 字段VFEE_OPERATENAME所映射的属性。
		/// 
        public System.String VFEE_OPERATENAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_COST_INFO.ColumnVFEE_OPERATENAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_COST_INFO.ColumnVFEE_OPERATENAME] = value;
            }
        }
        
		/// 
		/// 字段NBACK_SL所映射的属性。
		/// 
        public System.Decimal NBACK_SL
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableV_COST_INFO.ColumnNBACK_SL])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_COST_INFO.ColumnNBACK_SL] = value;
            }
        }
        
		/// 
		/// 判断字段NFEE_ID是否为空。
		/// 
        public bool IsNFEE_IDNull()
        {
            return this.IsNull(this.tableV_COST_INFO.ColumnNFEE_ID);
        }

		/// 
		/// 设置字段NFEE_ID为空值。
		/// 
        public void SetNFEE_IDNull() 
        {
            this[this.tableV_COST_INFO.ColumnNFEE_ID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VCLINICNO是否为空。
		/// 
        public bool IsVCLINICNONull()
        {
            return this.IsNull(this.tableV_COST_INFO.ColumnVCLINICNO);
        }

		/// 
		/// 设置字段VCLINICNO为空值。
		/// 
        public void SetVCLINICNONull() 
        {
            this[this.tableV_COST_INFO.ColumnVCLINICNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEM_NAME是否为空。
		/// 
        public bool IsVITEM_NAMENull()
        {
            return this.IsNull(this.tableV_COST_INFO.ColumnVITEM_NAME);
        }

		/// 
		/// 设置字段VITEM_NAME为空值。
		/// 
        public void SetVITEM_NAMENull() 
        {
            this[this.tableV_COST_INFO.ColumnVITEM_NAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DFEE_DATE是否为空。
		/// 
        public bool IsDFEE_DATENull()
        {
            return this.IsNull(this.tableV_COST_INFO.ColumnDFEE_DATE);
        }

		/// 
		/// 设置字段DFEE_DATE为空值。
		/// 
        public void SetDFEE_DATENull() 
        {
            this[this.tableV_COST_INFO.ColumnDFEE_DATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEM_UNITS是否为空。
		/// 
        public bool IsVITEM_UNITSNull()
        {
            return this.IsNull(this.tableV_COST_INFO.ColumnVITEM_UNITS);
        }

		/// 
		/// 设置字段VITEM_UNITS为空值。
		/// 
        public void SetVITEM_UNITSNull() 
        {
            this[this.tableV_COST_INFO.ColumnVITEM_UNITS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NITEM_PRICE是否为空。
		/// 
        public bool IsNITEM_PRICENull()
        {
            return this.IsNull(this.tableV_COST_INFO.ColumnNITEM_PRICE);
        }

		/// 
		/// 设置字段NITEM_PRICE为空值。
		/// 
        public void SetNITEM_PRICENull() 
        {
            this[this.tableV_COST_INFO.ColumnNITEM_PRICE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NITEM_SL是否为空。
		/// 
        public bool IsNITEM_SLNull()
        {
            return this.IsNull(this.tableV_COST_INFO.ColumnNITEM_SL);
        }

		/// 
		/// 设置字段NITEM_SL为空值。
		/// 
        public void SetNITEM_SLNull() 
        {
            this[this.tableV_COST_INFO.ColumnNITEM_SL] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NITEM_MONEY是否为空。
		/// 
        public bool IsNITEM_MONEYNull()
        {
            return this.IsNull(this.tableV_COST_INFO.ColumnNITEM_MONEY);
        }

		/// 
		/// 设置字段NITEM_MONEY为空值。
		/// 
        public void SetNITEM_MONEYNull() 
        {
            this[this.tableV_COST_INFO.ColumnNITEM_MONEY] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDEPARTNAME是否为空。
		/// 
        public bool IsVDEPARTNAMENull()
        {
            return this.IsNull(this.tableV_COST_INFO.ColumnVDEPARTNAME);
        }

		/// 
		/// 设置字段VDEPARTNAME为空值。
		/// 
        public void SetVDEPARTNAMENull() 
        {
            this[this.tableV_COST_INFO.ColumnVDEPARTNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VFEE_OPERATENAME是否为空。
		/// 
        public bool IsVFEE_OPERATENAMENull()
        {
            return this.IsNull(this.tableV_COST_INFO.ColumnVFEE_OPERATENAME);
        }

		/// 
		/// 设置字段VFEE_OPERATENAME为空值。
		/// 
        public void SetVFEE_OPERATENAMENull() 
        {
            this[this.tableV_COST_INFO.ColumnVFEE_OPERATENAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NBACK_SL是否为空。
		/// 
        public bool IsNBACK_SLNull()
        {
            return this.IsNull(this.tableV_COST_INFO.ColumnNBACK_SL);
        }

		/// 
		/// 设置字段NBACK_SL为空值。
		/// 
        public void SetNBACK_SLNull() 
        {
            this[this.tableV_COST_INFO.ColumnNBACK_SL] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventV_COST_INFO : EventArgs {
        
        private RowV_COST_INFO eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventV_COST_INFO(RowV_COST_INFO row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowV_COST_INFO Row {
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
	