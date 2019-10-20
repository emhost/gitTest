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
	#region DataSetWJ_DICANSWER
	/// 
	/// 对于WJ_DICANSWER的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetWJ_DICANSWER : DataSet
    {
		
		private DataTableWJ_DICANSWER tableWJ_DICANSWER;
		
        public DataSetWJ_DICANSWER() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetWJ_DICANSWER实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetWJ_DICANSWER GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetWJ_DICANSWER dataSet = (DataSetWJ_DICANSWER)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetWJ_DICANSWER entity = new DataSetWJ_DICANSWER();
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
        
        protected DataSetWJ_DICANSWER(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["WJ_DICANSWER"] != null)) 
                {
                    this.Tables.Add(new DataTableWJ_DICANSWER(ds.Tables["WJ_DICANSWER"]));
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
		/// 对于数据表WJ_DICANSWER的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableWJ_DICANSWER WJ_DICANSWER 
		{
			get
			{
				return this.tableWJ_DICANSWER;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetWJ_DICANSWER cln = ((DataSetWJ_DICANSWER)(base.Clone()));
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
			
			if ((ds.Tables["WJ_DICANSWER"] != null)) 
			{
				this.Tables.Add(new DataTableWJ_DICANSWER(ds.Tables["WJ_DICANSWER"]));
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
			
			this.tableWJ_DICANSWER = ((DataTableWJ_DICANSWER)(this.Tables["WJ_DICANSWER"]));
			if ((this.tableWJ_DICANSWER != null)) {
				this.tableWJ_DICANSWER.InitVars();
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
			
			this.tableWJ_DICANSWER = new DataTableWJ_DICANSWER();
			this.Tables.Add(this.tableWJ_DICANSWER);
			
		}
		
		private bool ShouldSerializeWJ_DICANSWER() 
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
	
    public delegate void RowChangeEventHandlerWJ_DICANSWER(object sender, RowChangeEventWJ_DICANSWER e);
	
	#region DataTableWJ_DICANSWER
	/// 
	/// 对于数据表WJ_DICANSWER的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableWJ_DICANSWER : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVID;
		
        private DataColumn columnVNAME;
		
        private DataColumn columnVPID;
		
        private DataColumn columnNSTOP;
		
        private DataColumn columnDCREATE;
		
        private DataColumn columnNSORT;
		
        internal DataTableWJ_DICANSWER() : base("WJ_DICANSWER") 
        {
            this.InitClass();
        }
        
        internal DataTableWJ_DICANSWER(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVID 
        {
            get 
            {
                return this.columnVID;
            }
        }
		
        public DataColumn ColumnVNAME 
        {
            get 
            {
                return this.columnVNAME;
            }
        }
		
        public DataColumn ColumnVPID 
        {
            get 
            {
                return this.columnVPID;
            }
        }
		
        public DataColumn ColumnNSTOP 
        {
            get 
            {
                return this.columnNSTOP;
            }
        }
		
        public DataColumn ColumnDCREATE 
        {
            get 
            {
                return this.columnDCREATE;
            }
        }
		
        public DataColumn ColumnNSORT 
        {
            get 
            {
                return this.columnNSORT;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowWJ_DICANSWER this[int index] 
        {
            get 
            {
                return ((RowWJ_DICANSWER)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerWJ_DICANSWER RowChangedWJ_DICANSWER;
        
        public event RowChangeEventHandlerWJ_DICANSWER RowChangingWJ_DICANSWER;
        
        public event RowChangeEventHandlerWJ_DICANSWER RowDeletedWJ_DICANSWER;
        
        public event RowChangeEventHandlerWJ_DICANSWER RowDeletingWJ_DICANSWER;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowWJ_DICANSWER(RowWJ_DICANSWER row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowWJ_DICANSWER AddRowWJ_DICANSWER(System.String VID,System.String VNAME,System.String VPID,System.Int16 NSTOP,System.DateTime DCREATE,System.Int16 NSORT) 
        {
            RowWJ_DICANSWER row = ((RowWJ_DICANSWER)(this.NewRow()));
            row.ItemArray = new object[] {VID,VNAME,VPID,NSTOP,DCREATE,NSORT};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowWJ_DICANSWER FindByVID(System.String VID) {
            return ((RowWJ_DICANSWER)(this.Rows.Find(new object[] {
                        VID})));
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
            DataTableWJ_DICANSWER cln = ((DataTableWJ_DICANSWER)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableWJ_DICANSWER();
        }
        
        internal void InitVars() 
        {	
            this.columnVID = this.Columns["VID"];
            this.columnVNAME = this.Columns["VNAME"];
            this.columnVPID = this.Columns["VPID"];
            this.columnNSTOP = this.Columns["NSTOP"];
            this.columnDCREATE = this.Columns["DCREATE"];
            this.columnNSORT = this.Columns["NSORT"];
        }
        
        private void InitClass() 
        {	
            this.columnVID = new DataColumn("VID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVID.MaxLength = 36;
            this.columnVID.AllowDBNull = false;
            this.columnVID.Unique = true;
            
            this.Columns.Add(this.columnVID);
			
            this.columnVNAME = new DataColumn("VNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNAME.MaxLength = 50;
            this.columnVNAME.AllowDBNull = false;
            this.Columns.Add(this.columnVNAME);
			
            this.columnVPID = new DataColumn("VPID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPID.MaxLength = 36;
            this.columnVPID.AllowDBNull = false;
            this.Columns.Add(this.columnVPID);
			
            this.columnNSTOP = new DataColumn("NSTOP", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNSTOP.DefaultValue = "0";
            this.columnNSTOP.AllowDBNull = false;
            this.Columns.Add(this.columnNSTOP);
			
            this.columnDCREATE = new DataColumn("DCREATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDCREATE.AllowDBNull = true;
            this.Columns.Add(this.columnDCREATE);
			
            this.columnNSORT = new DataColumn("NSORT", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNSORT.AllowDBNull = true;
            this.Columns.Add(this.columnNSORT);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowWJ_DICANSWER NewRowWJ_DICANSWER() {
            return ((RowWJ_DICANSWER)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowWJ_DICANSWER(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowWJ_DICANSWER);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedWJ_DICANSWER != null)) {
                this.RowChangedWJ_DICANSWER(this, new RowChangeEventWJ_DICANSWER(((RowWJ_DICANSWER)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingWJ_DICANSWER != null)) {
                this.RowChangingWJ_DICANSWER(this, new RowChangeEventWJ_DICANSWER(((RowWJ_DICANSWER)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedWJ_DICANSWER != null)) {
                this.RowDeletedWJ_DICANSWER(this, new RowChangeEventWJ_DICANSWER(((RowWJ_DICANSWER)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingWJ_DICANSWER != null)) {
                this.RowDeletingWJ_DICANSWER(this, new RowChangeEventWJ_DICANSWER(((RowWJ_DICANSWER)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowWJ_DICANSWER(RowWJ_DICANSWER row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowWJ_DICANSWER
	/// 
	/// 数据表WJ_DICANSWER行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowWJ_DICANSWER : DataRow 
    {
        
        private DataTableWJ_DICANSWER tableWJ_DICANSWER;
        
        internal RowWJ_DICANSWER(DataRowBuilder rb) : base(rb) 
        {
            this.tableWJ_DICANSWER = ((DataTableWJ_DICANSWER)(this.Table));
        }        
		
		/// 
		/// 字段VID所映射的属性。
		/// 
        public System.String VID
        {
            get 
            {	
                return ((System.String)(this[this.tableWJ_DICANSWER.ColumnVID])); 
            }
            set 
            {
                this[this.tableWJ_DICANSWER.ColumnVID] = value;
            }
        }
        
		/// 
		/// 字段VNAME所映射的属性。
		/// 
        public System.String VNAME
        {
            get 
            {	
                return ((System.String)(this[this.tableWJ_DICANSWER.ColumnVNAME])); 
            }
            set 
            {
                this[this.tableWJ_DICANSWER.ColumnVNAME] = value;
            }
        }
        
		/// 
		/// 字段VPID所映射的属性。
		/// 
        public System.String VPID
        {
            get 
            {	
                return ((System.String)(this[this.tableWJ_DICANSWER.ColumnVPID])); 
            }
            set 
            {
                this[this.tableWJ_DICANSWER.ColumnVPID] = value;
            }
        }
        
		/// 
		/// 字段NSTOP所映射的属性。
		/// 
        public System.Int16 NSTOP
        {
            get 
            {	
                return ((System.Int16)(this[this.tableWJ_DICANSWER.ColumnNSTOP])); 
            }
            set 
            {
                this[this.tableWJ_DICANSWER.ColumnNSTOP] = value;
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
	                return ((System.DateTime)(this[this.tableWJ_DICANSWER.ColumnDCREATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableWJ_DICANSWER.ColumnDCREATE] = value;
            }
        }
        
		/// 
		/// 字段NSORT所映射的属性。
		/// 
        public System.Int16 NSORT
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableWJ_DICANSWER.ColumnNSORT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableWJ_DICANSWER.ColumnNSORT] = value;
            }
        }
        
		/// 
		/// 判断字段DCREATE是否为空。
		/// 
        public bool IsDCREATENull()
        {
            return this.IsNull(this.tableWJ_DICANSWER.ColumnDCREATE);
        }

		/// 
		/// 设置字段DCREATE为空值。
		/// 
        public void SetDCREATENull() 
        {
            this[this.tableWJ_DICANSWER.ColumnDCREATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSORT是否为空。
		/// 
        public bool IsNSORTNull()
        {
            return this.IsNull(this.tableWJ_DICANSWER.ColumnNSORT);
        }

		/// 
		/// 设置字段NSORT为空值。
		/// 
        public void SetNSORTNull() 
        {
            this[this.tableWJ_DICANSWER.ColumnNSORT] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventWJ_DICANSWER : EventArgs {
        
        private RowWJ_DICANSWER eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventWJ_DICANSWER(RowWJ_DICANSWER row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowWJ_DICANSWER Row {
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
	