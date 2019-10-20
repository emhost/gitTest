//------------------------------------------------------------------------------
//     这部分代码属于实体定义层，是由实体编辑器工具自动产生的。
//     (Runtime Version: 2.2017.3.2)
//     对此代码进行的任何修改会导致其它的行为错误，并且重新生成时所有的修改会丢失。
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Xml;
using System.Runtime.Serialization;

namespace HYHISAPP.Entity
{
	#region DataSetSIGNIN
	/// 
	/// 对于SIGNIN的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetSIGNIN : DataSet
    {
		
		private DataTableSIGNIN tableSIGNIN;
		
        public DataSetSIGNIN() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetSIGNIN实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetSIGNIN GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetSIGNIN dataSet = (DataSetSIGNIN)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetSIGNIN entity = new DataSetSIGNIN();
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
        
        protected DataSetSIGNIN(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["SIGNIN"] != null)) 
                {
                    this.Tables.Add(new DataTableSIGNIN(ds.Tables["SIGNIN"]));
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
		/// 对于数据表SIGNIN的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableSIGNIN SIGNIN 
		{
			get
			{
				return this.tableSIGNIN;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetSIGNIN cln = ((DataSetSIGNIN)(base.Clone()));
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
			
			if ((ds.Tables["SIGNIN"] != null)) 
			{
				this.Tables.Add(new DataTableSIGNIN(ds.Tables["SIGNIN"]));
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
			
			this.tableSIGNIN = ((DataTableSIGNIN)(this.Tables["SIGNIN"]));
			if ((this.tableSIGNIN != null)) {
				this.tableSIGNIN.InitVars();
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
			
			this.tableSIGNIN = new DataTableSIGNIN();
			this.Tables.Add(this.tableSIGNIN);
			
		}
		
		private bool ShouldSerializeSIGNIN() 
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
	
    public delegate void RowChangeEventHandlerSIGNIN(object sender, RowChangeEventSIGNIN e);
	
	#region DataTableSIGNIN
	/// 
	/// 对于数据表SIGNIN的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableSIGNIN : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVCLINICNO;
		
        private DataColumn columnDCREATE;
		
        private DataColumn columnNNUM;
		
        internal DataTableSIGNIN() : base("SIGNIN") 
        {
            this.InitClass();
        }
        
        internal DataTableSIGNIN(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnDCREATE 
        {
            get 
            {
                return this.columnDCREATE;
            }
        }
		
        public DataColumn ColumnNNUM 
        {
            get 
            {
                return this.columnNNUM;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowSIGNIN this[int index] 
        {
            get 
            {
                return ((RowSIGNIN)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerSIGNIN RowChangedSIGNIN;
        
        public event RowChangeEventHandlerSIGNIN RowChangingSIGNIN;
        
        public event RowChangeEventHandlerSIGNIN RowDeletedSIGNIN;
        
        public event RowChangeEventHandlerSIGNIN RowDeletingSIGNIN;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowSIGNIN(RowSIGNIN row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowSIGNIN AddRowSIGNIN(System.String VCLINICNO,System.DateTime DCREATE,System.Int16 NNUM) 
        {
            RowSIGNIN row = ((RowSIGNIN)(this.NewRow()));
            row.ItemArray = new object[] {VCLINICNO,DCREATE,NNUM};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowSIGNIN FindByVCLINICNO(System.String VCLINICNO) {
            return ((RowSIGNIN)(this.Rows.Find(new object[] {
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
            DataTableSIGNIN cln = ((DataTableSIGNIN)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableSIGNIN();
        }
        
        internal void InitVars() 
        {	
            this.columnVCLINICNO = this.Columns["VCLINICNO"];
            this.columnDCREATE = this.Columns["DCREATE"];
            this.columnNNUM = this.Columns["NNUM"];
        }
        
        private void InitClass() 
        {	
            this.columnVCLINICNO = new DataColumn("VCLINICNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCLINICNO.MaxLength = 10;
            this.columnVCLINICNO.AllowDBNull = false;
            this.columnVCLINICNO.Unique = true;
            
            this.Columns.Add(this.columnVCLINICNO);
			
            this.columnDCREATE = new DataColumn("DCREATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDCREATE.AllowDBNull = true;
            this.Columns.Add(this.columnDCREATE);
			
            this.columnNNUM = new DataColumn("NNUM", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNNUM.AllowDBNull = true;
            this.Columns.Add(this.columnNNUM);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowSIGNIN NewRowSIGNIN() {
            return ((RowSIGNIN)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowSIGNIN(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowSIGNIN);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedSIGNIN != null)) {
                this.RowChangedSIGNIN(this, new RowChangeEventSIGNIN(((RowSIGNIN)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingSIGNIN != null)) {
                this.RowChangingSIGNIN(this, new RowChangeEventSIGNIN(((RowSIGNIN)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedSIGNIN != null)) {
                this.RowDeletedSIGNIN(this, new RowChangeEventSIGNIN(((RowSIGNIN)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingSIGNIN != null)) {
                this.RowDeletingSIGNIN(this, new RowChangeEventSIGNIN(((RowSIGNIN)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowSIGNIN(RowSIGNIN row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowSIGNIN
	/// 
	/// 数据表SIGNIN行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowSIGNIN : DataRow 
    {
        
        private DataTableSIGNIN tableSIGNIN;
        
        internal RowSIGNIN(DataRowBuilder rb) : base(rb) 
        {
            this.tableSIGNIN = ((DataTableSIGNIN)(this.Table));
        }        
		
		/// 
		/// 字段VCLINICNO所映射的属性。
		/// 
        public System.String VCLINICNO
        {
            get 
            {	
                return ((System.String)(this[this.tableSIGNIN.ColumnVCLINICNO])); 
            }
            set 
            {
                this[this.tableSIGNIN.ColumnVCLINICNO] = value;
            }
        }
        
		/// 
		/// 字段DCREATE所映射的属性。
		/// 
        public System.DateTime DCREATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableSIGNIN.ColumnDCREATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableSIGNIN.ColumnDCREATE] = value;
            }
        }
        
		/// 
		/// 字段NNUM所映射的属性。
		/// 
        public System.Int16 NNUM
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableSIGNIN.ColumnNNUM])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableSIGNIN.ColumnNNUM] = value;
            }
        }
        
		/// 
		/// 判断字段DCREATE是否为空。
		/// 
        public bool IsDCREATENull()
        {
            return this.IsNull(this.tableSIGNIN.ColumnDCREATE);
        }

		/// 
		/// 设置字段DCREATE为空值。
		/// 
        public void SetDCREATENull() 
        {
            this[this.tableSIGNIN.ColumnDCREATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NNUM是否为空。
		/// 
        public bool IsNNUMNull()
        {
            return this.IsNull(this.tableSIGNIN.ColumnNNUM);
        }

		/// 
		/// 设置字段NNUM为空值。
		/// 
        public void SetNNUMNull() 
        {
            this[this.tableSIGNIN.ColumnNNUM] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventSIGNIN : EventArgs {
        
        private RowSIGNIN eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventSIGNIN(RowSIGNIN row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowSIGNIN Row {
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
	