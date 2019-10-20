//------------------------------------------------------------------------------
//     这部分代码属于实体定义层，是由实体编辑器工具自动产生的。
//     (Runtime Version: 2.2017.9.9)
//     对此代码进行的任何修改会导致其它的行为错误，并且重新生成时所有的修改会丢失。
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Xml;
using System.Runtime.Serialization;

namespace hyApp.Entity
{
	#region DataSetIN_NAVIGATION_DETAILS
	/// 
	/// 对于IN_NAVIGATION_DETAILS的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetIN_NAVIGATION_DETAILS : DataSet
    {
		
		private DataTableYWAPP_INHOSPITAL_NAVIGATION_DETAIL tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL;
		
        public DataSetIN_NAVIGATION_DETAILS() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetIN_NAVIGATION_DETAILS实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetIN_NAVIGATION_DETAILS GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetIN_NAVIGATION_DETAILS dataSet = (DataSetIN_NAVIGATION_DETAILS)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetIN_NAVIGATION_DETAILS entity = new DataSetIN_NAVIGATION_DETAILS();
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
        
        protected DataSetIN_NAVIGATION_DETAILS(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["YWAPP_INHOSPITAL_NAVIGATION_DETAIL"] != null)) 
                {
                    this.Tables.Add(new DataTableYWAPP_INHOSPITAL_NAVIGATION_DETAIL(ds.Tables["YWAPP_INHOSPITAL_NAVIGATION_DETAIL"]));
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
		/// 对于数据表YWAPP_INHOSPITAL_NAVIGATION_DETAIL的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableYWAPP_INHOSPITAL_NAVIGATION_DETAIL YWAPP_INHOSPITAL_NAVIGATION_DETAIL 
		{
			get
			{
				return this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetIN_NAVIGATION_DETAILS cln = ((DataSetIN_NAVIGATION_DETAILS)(base.Clone()));
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
			
			if ((ds.Tables["YWAPP_INHOSPITAL_NAVIGATION_DETAIL"] != null)) 
			{
				this.Tables.Add(new DataTableYWAPP_INHOSPITAL_NAVIGATION_DETAIL(ds.Tables["YWAPP_INHOSPITAL_NAVIGATION_DETAIL"]));
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
			
			this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL = ((DataTableYWAPP_INHOSPITAL_NAVIGATION_DETAIL)(this.Tables["YWAPP_INHOSPITAL_NAVIGATION_DETAIL"]));
			if ((this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL != null)) {
				this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.InitVars();
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
			
			this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL = new DataTableYWAPP_INHOSPITAL_NAVIGATION_DETAIL();
			this.Tables.Add(this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL);
			
		}
		
		private bool ShouldSerializeYWAPP_INHOSPITAL_NAVIGATION_DETAIL() 
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
	
    public delegate void RowChangeEventHandlerYWAPP_INHOSPITAL_NAVIGATION_DETAIL(object sender, RowChangeEventYWAPP_INHOSPITAL_NAVIGATION_DETAIL e);
	
	#region DataTableYWAPP_INHOSPITAL_NAVIGATION_DETAIL
	/// 
	/// 对于数据表YWAPP_INHOSPITAL_NAVIGATION_DETAIL的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableYWAPP_INHOSPITAL_NAVIGATION_DETAIL : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnINID;
		
        private DataColumn columnID;
		
        private DataColumn columnFLOORNUM;
		
        private DataColumn columnDEPARTCODE;
		
        private DataColumn columnDEPARTNAME;
		
        private DataColumn columnFLOORNUMMAP;
		
        internal DataTableYWAPP_INHOSPITAL_NAVIGATION_DETAIL() : base("YWAPP_INHOSPITAL_NAVIGATION_DETAIL") 
        {
            this.InitClass();
        }
        
        internal DataTableYWAPP_INHOSPITAL_NAVIGATION_DETAIL(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnINID 
        {
            get 
            {
                return this.columnINID;
            }
        }
		
        public DataColumn ColumnID 
        {
            get 
            {
                return this.columnID;
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
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL this[int index] 
        {
            get 
            {
                return ((RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerYWAPP_INHOSPITAL_NAVIGATION_DETAIL RowChangedYWAPP_INHOSPITAL_NAVIGATION_DETAIL;
        
        public event RowChangeEventHandlerYWAPP_INHOSPITAL_NAVIGATION_DETAIL RowChangingYWAPP_INHOSPITAL_NAVIGATION_DETAIL;
        
        public event RowChangeEventHandlerYWAPP_INHOSPITAL_NAVIGATION_DETAIL RowDeletedYWAPP_INHOSPITAL_NAVIGATION_DETAIL;
        
        public event RowChangeEventHandlerYWAPP_INHOSPITAL_NAVIGATION_DETAIL RowDeletingYWAPP_INHOSPITAL_NAVIGATION_DETAIL;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowYWAPP_INHOSPITAL_NAVIGATION_DETAIL(RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL AddRowYWAPP_INHOSPITAL_NAVIGATION_DETAIL(System.String INID,System.String ID,System.String FLOORNUM,System.String DEPARTCODE,System.String DEPARTNAME,System.Byte[] FLOORNUMMAP) 
        {
            RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL row = ((RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL)(this.NewRow()));
            row.ItemArray = new object[] {INID,ID,FLOORNUM,DEPARTCODE,DEPARTNAME,FLOORNUMMAP};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL FindByID(System.String ID) {
            return ((RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL)(this.Rows.Find(new object[] {
                        ID})));
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
            DataTableYWAPP_INHOSPITAL_NAVIGATION_DETAIL cln = ((DataTableYWAPP_INHOSPITAL_NAVIGATION_DETAIL)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableYWAPP_INHOSPITAL_NAVIGATION_DETAIL();
        }
        
        internal void InitVars() 
        {	
            this.columnINID = this.Columns["INID"];
            this.columnID = this.Columns["ID"];
            this.columnFLOORNUM = this.Columns["FLOORNUM"];
            this.columnDEPARTCODE = this.Columns["DEPARTCODE"];
            this.columnDEPARTNAME = this.Columns["DEPARTNAME"];
            this.columnFLOORNUMMAP = this.Columns["FLOORNUMMAP"];
        }
        
        private void InitClass() 
        {	
            this.columnINID = new DataColumn("INID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnINID.MaxLength = 36;
            this.columnINID.AllowDBNull = true;
            this.Columns.Add(this.columnINID);
			
            this.columnID = new DataColumn("ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnID.MaxLength = 36;
            this.columnID.AllowDBNull = false;
            this.columnID.Unique = true;
            
            this.Columns.Add(this.columnID);
			
            this.columnFLOORNUM = new DataColumn("FLOORNUM", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnFLOORNUM.MaxLength = 20;
            this.columnFLOORNUM.AllowDBNull = true;
            this.Columns.Add(this.columnFLOORNUM);
			
            this.columnDEPARTCODE = new DataColumn("DEPARTCODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnDEPARTCODE.MaxLength = 36;
            this.columnDEPARTCODE.AllowDBNull = true;
            this.Columns.Add(this.columnDEPARTCODE);
			
            this.columnDEPARTNAME = new DataColumn("DEPARTNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnDEPARTNAME.MaxLength = 20;
            this.columnDEPARTNAME.AllowDBNull = true;
            this.Columns.Add(this.columnDEPARTNAME);
			
            this.columnFLOORNUMMAP = new DataColumn("FLOORNUMMAP", typeof(System.Byte[]), null, System.Data.MappingType.Element);
            this.columnFLOORNUMMAP.AllowDBNull = true;
            this.Columns.Add(this.columnFLOORNUMMAP);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL NewRowYWAPP_INHOSPITAL_NAVIGATION_DETAIL() {
            return ((RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedYWAPP_INHOSPITAL_NAVIGATION_DETAIL != null)) {
                this.RowChangedYWAPP_INHOSPITAL_NAVIGATION_DETAIL(this, new RowChangeEventYWAPP_INHOSPITAL_NAVIGATION_DETAIL(((RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingYWAPP_INHOSPITAL_NAVIGATION_DETAIL != null)) {
                this.RowChangingYWAPP_INHOSPITAL_NAVIGATION_DETAIL(this, new RowChangeEventYWAPP_INHOSPITAL_NAVIGATION_DETAIL(((RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedYWAPP_INHOSPITAL_NAVIGATION_DETAIL != null)) {
                this.RowDeletedYWAPP_INHOSPITAL_NAVIGATION_DETAIL(this, new RowChangeEventYWAPP_INHOSPITAL_NAVIGATION_DETAIL(((RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingYWAPP_INHOSPITAL_NAVIGATION_DETAIL != null)) {
                this.RowDeletingYWAPP_INHOSPITAL_NAVIGATION_DETAIL(this, new RowChangeEventYWAPP_INHOSPITAL_NAVIGATION_DETAIL(((RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowYWAPP_INHOSPITAL_NAVIGATION_DETAIL(RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL
	/// 
	/// 数据表YWAPP_INHOSPITAL_NAVIGATION_DETAIL行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL : DataRow 
    {
        
        private DataTableYWAPP_INHOSPITAL_NAVIGATION_DETAIL tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL;
        
        internal RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL(DataRowBuilder rb) : base(rb) 
        {
            this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL = ((DataTableYWAPP_INHOSPITAL_NAVIGATION_DETAIL)(this.Table));
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
	                return ((System.String)(this[this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnINID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnINID] = value;
            }
        }
        
		/// 
		/// 字段ID所映射的属性。
		/// 
        public System.String ID
        {
            get 
            {	
                return ((System.String)(this[this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnID])); 
            }
            set 
            {
                this[this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnID] = value;
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
	                return ((System.String)(this[this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnFLOORNUM])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnFLOORNUM] = value;
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
	                return ((System.String)(this[this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnDEPARTCODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnDEPARTCODE] = value;
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
	                return ((System.String)(this[this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnDEPARTNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnDEPARTNAME] = value;
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
	                return ((System.Byte[])(this[this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnFLOORNUMMAP])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnFLOORNUMMAP] = value;
            }
        }
        
		/// 
		/// 判断字段INID是否为空。
		/// 
        public bool IsINIDNull()
        {
            return this.IsNull(this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnINID);
        }

		/// 
		/// 设置字段INID为空值。
		/// 
        public void SetINIDNull() 
        {
            this[this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnINID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段FLOORNUM是否为空。
		/// 
        public bool IsFLOORNUMNull()
        {
            return this.IsNull(this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnFLOORNUM);
        }

		/// 
		/// 设置字段FLOORNUM为空值。
		/// 
        public void SetFLOORNUMNull() 
        {
            this[this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnFLOORNUM] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DEPARTCODE是否为空。
		/// 
        public bool IsDEPARTCODENull()
        {
            return this.IsNull(this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnDEPARTCODE);
        }

		/// 
		/// 设置字段DEPARTCODE为空值。
		/// 
        public void SetDEPARTCODENull() 
        {
            this[this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnDEPARTCODE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DEPARTNAME是否为空。
		/// 
        public bool IsDEPARTNAMENull()
        {
            return this.IsNull(this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnDEPARTNAME);
        }

		/// 
		/// 设置字段DEPARTNAME为空值。
		/// 
        public void SetDEPARTNAMENull() 
        {
            this[this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnDEPARTNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段FLOORNUMMAP是否为空。
		/// 
        public bool IsFLOORNUMMAPNull()
        {
            return this.IsNull(this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnFLOORNUMMAP);
        }

		/// 
		/// 设置字段FLOORNUMMAP为空值。
		/// 
        public void SetFLOORNUMMAPNull() 
        {
            this[this.tableYWAPP_INHOSPITAL_NAVIGATION_DETAIL.ColumnFLOORNUMMAP] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventYWAPP_INHOSPITAL_NAVIGATION_DETAIL : EventArgs {
        
        private RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventYWAPP_INHOSPITAL_NAVIGATION_DETAIL(RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowYWAPP_INHOSPITAL_NAVIGATION_DETAIL Row {
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
	