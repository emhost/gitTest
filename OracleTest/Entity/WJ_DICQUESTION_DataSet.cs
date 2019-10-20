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
	#region DataSetWJ_DICQUESTION
	/// 
	/// 对于WJ_DICQUESTION的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetWJ_DICQUESTION : DataSet
    {
		
		private DataTableWJ_DICQUESTION tableWJ_DICQUESTION;
		
        public DataSetWJ_DICQUESTION() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetWJ_DICQUESTION实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetWJ_DICQUESTION GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetWJ_DICQUESTION dataSet = (DataSetWJ_DICQUESTION)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetWJ_DICQUESTION entity = new DataSetWJ_DICQUESTION();
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
        
        protected DataSetWJ_DICQUESTION(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["WJ_DICQUESTION"] != null)) 
                {
                    this.Tables.Add(new DataTableWJ_DICQUESTION(ds.Tables["WJ_DICQUESTION"]));
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
		/// 对于数据表WJ_DICQUESTION的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableWJ_DICQUESTION WJ_DICQUESTION 
		{
			get
			{
				return this.tableWJ_DICQUESTION;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetWJ_DICQUESTION cln = ((DataSetWJ_DICQUESTION)(base.Clone()));
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
			
			if ((ds.Tables["WJ_DICQUESTION"] != null)) 
			{
				this.Tables.Add(new DataTableWJ_DICQUESTION(ds.Tables["WJ_DICQUESTION"]));
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
			
			this.tableWJ_DICQUESTION = ((DataTableWJ_DICQUESTION)(this.Tables["WJ_DICQUESTION"]));
			if ((this.tableWJ_DICQUESTION != null)) {
				this.tableWJ_DICQUESTION.InitVars();
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
			
			this.tableWJ_DICQUESTION = new DataTableWJ_DICQUESTION();
			this.Tables.Add(this.tableWJ_DICQUESTION);
			
		}
		
		private bool ShouldSerializeWJ_DICQUESTION() 
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
	
    public delegate void RowChangeEventHandlerWJ_DICQUESTION(object sender, RowChangeEventWJ_DICQUESTION e);
	
	#region DataTableWJ_DICQUESTION
	/// 
	/// 对于数据表WJ_DICQUESTION的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableWJ_DICQUESTION : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVID;
		
        private DataColumn columnVNAME;
		
        private DataColumn columnNSTOP;
		
        private DataColumn columnNLX;
		
        private DataColumn columnVPID;
		
        private DataColumn columnDCREATE;
		
        private DataColumn columnNSORT;
		
        private DataColumn columnNBIXUAN;
		
        internal DataTableWJ_DICQUESTION() : base("WJ_DICQUESTION") 
        {
            this.InitClass();
        }
        
        internal DataTableWJ_DICQUESTION(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnNSTOP 
        {
            get 
            {
                return this.columnNSTOP;
            }
        }
		
        public DataColumn ColumnNLX 
        {
            get 
            {
                return this.columnNLX;
            }
        }
		
        public DataColumn ColumnVPID 
        {
            get 
            {
                return this.columnVPID;
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
		
        public DataColumn ColumnNBIXUAN 
        {
            get 
            {
                return this.columnNBIXUAN;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowWJ_DICQUESTION this[int index] 
        {
            get 
            {
                return ((RowWJ_DICQUESTION)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerWJ_DICQUESTION RowChangedWJ_DICQUESTION;
        
        public event RowChangeEventHandlerWJ_DICQUESTION RowChangingWJ_DICQUESTION;
        
        public event RowChangeEventHandlerWJ_DICQUESTION RowDeletedWJ_DICQUESTION;
        
        public event RowChangeEventHandlerWJ_DICQUESTION RowDeletingWJ_DICQUESTION;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowWJ_DICQUESTION(RowWJ_DICQUESTION row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowWJ_DICQUESTION AddRowWJ_DICQUESTION(System.String VID,System.String VNAME,System.Int16 NSTOP,System.Int16 NLX,System.String VPID,System.DateTime DCREATE,System.Int16 NSORT,System.Int16 NBIXUAN) 
        {
            RowWJ_DICQUESTION row = ((RowWJ_DICQUESTION)(this.NewRow()));
            row.ItemArray = new object[] {VID,VNAME,NSTOP,NLX,VPID,DCREATE,NSORT,NBIXUAN};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowWJ_DICQUESTION FindByVID(System.String VID) {
            return ((RowWJ_DICQUESTION)(this.Rows.Find(new object[] {
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
            DataTableWJ_DICQUESTION cln = ((DataTableWJ_DICQUESTION)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableWJ_DICQUESTION();
        }
        
        internal void InitVars() 
        {	
            this.columnVID = this.Columns["VID"];
            this.columnVNAME = this.Columns["VNAME"];
            this.columnNSTOP = this.Columns["NSTOP"];
            this.columnNLX = this.Columns["NLX"];
            this.columnVPID = this.Columns["VPID"];
            this.columnDCREATE = this.Columns["DCREATE"];
            this.columnNSORT = this.Columns["NSORT"];
            this.columnNBIXUAN = this.Columns["NBIXUAN"];
        }
        
        private void InitClass() 
        {	
            this.columnVID = new DataColumn("VID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVID.MaxLength = 36;
            this.columnVID.AllowDBNull = false;
            this.columnVID.Unique = true;
            
            this.Columns.Add(this.columnVID);
			
            this.columnVNAME = new DataColumn("VNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNAME.MaxLength = 30;
            this.columnVNAME.AllowDBNull = false;
            this.Columns.Add(this.columnVNAME);
			
            this.columnNSTOP = new DataColumn("NSTOP", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNSTOP.DefaultValue = "0";
            this.columnNSTOP.AllowDBNull = false;
            this.Columns.Add(this.columnNSTOP);
			
            this.columnNLX = new DataColumn("NLX", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNLX.AllowDBNull = false;
            this.Columns.Add(this.columnNLX);
			
            this.columnVPID = new DataColumn("VPID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPID.MaxLength = 36;
            this.columnVPID.AllowDBNull = false;
            this.Columns.Add(this.columnVPID);
			
            this.columnDCREATE = new DataColumn("DCREATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDCREATE.AllowDBNull = true;
            this.Columns.Add(this.columnDCREATE);
			
            this.columnNSORT = new DataColumn("NSORT", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNSORT.AllowDBNull = true;
            this.Columns.Add(this.columnNSORT);
			
            this.columnNBIXUAN = new DataColumn("NBIXUAN", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNBIXUAN.AllowDBNull = true;
            this.Columns.Add(this.columnNBIXUAN);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowWJ_DICQUESTION NewRowWJ_DICQUESTION() {
            return ((RowWJ_DICQUESTION)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowWJ_DICQUESTION(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowWJ_DICQUESTION);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedWJ_DICQUESTION != null)) {
                this.RowChangedWJ_DICQUESTION(this, new RowChangeEventWJ_DICQUESTION(((RowWJ_DICQUESTION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingWJ_DICQUESTION != null)) {
                this.RowChangingWJ_DICQUESTION(this, new RowChangeEventWJ_DICQUESTION(((RowWJ_DICQUESTION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedWJ_DICQUESTION != null)) {
                this.RowDeletedWJ_DICQUESTION(this, new RowChangeEventWJ_DICQUESTION(((RowWJ_DICQUESTION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingWJ_DICQUESTION != null)) {
                this.RowDeletingWJ_DICQUESTION(this, new RowChangeEventWJ_DICQUESTION(((RowWJ_DICQUESTION)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowWJ_DICQUESTION(RowWJ_DICQUESTION row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowWJ_DICQUESTION
	/// 
	/// 数据表WJ_DICQUESTION行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowWJ_DICQUESTION : DataRow 
    {
        
        private DataTableWJ_DICQUESTION tableWJ_DICQUESTION;
        
        internal RowWJ_DICQUESTION(DataRowBuilder rb) : base(rb) 
        {
            this.tableWJ_DICQUESTION = ((DataTableWJ_DICQUESTION)(this.Table));
        }        
		
		/// 
		/// 字段VID所映射的属性。
		/// 
        public System.String VID
        {
            get 
            {	
                return ((System.String)(this[this.tableWJ_DICQUESTION.ColumnVID])); 
            }
            set 
            {
                this[this.tableWJ_DICQUESTION.ColumnVID] = value;
            }
        }
        
		/// 
		/// 字段VNAME所映射的属性。
		/// 
        public System.String VNAME
        {
            get 
            {	
                return ((System.String)(this[this.tableWJ_DICQUESTION.ColumnVNAME])); 
            }
            set 
            {
                this[this.tableWJ_DICQUESTION.ColumnVNAME] = value;
            }
        }
        
		/// 
		/// 字段NSTOP所映射的属性。
		/// 
        public System.Int16 NSTOP
        {
            get 
            {	
                return ((System.Int16)(this[this.tableWJ_DICQUESTION.ColumnNSTOP])); 
            }
            set 
            {
                this[this.tableWJ_DICQUESTION.ColumnNSTOP] = value;
            }
        }
        
		/// 
		/// 字段NLX所映射的属性。
		/// 
        public System.Int16 NLX
        {
            get 
            {	
                return ((System.Int16)(this[this.tableWJ_DICQUESTION.ColumnNLX])); 
            }
            set 
            {
                this[this.tableWJ_DICQUESTION.ColumnNLX] = value;
            }
        }
        
		/// 
		/// 字段VPID所映射的属性。
		/// 
        public System.String VPID
        {
            get 
            {	
                return ((System.String)(this[this.tableWJ_DICQUESTION.ColumnVPID])); 
            }
            set 
            {
                this[this.tableWJ_DICQUESTION.ColumnVPID] = value;
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
	                return ((System.DateTime)(this[this.tableWJ_DICQUESTION.ColumnDCREATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableWJ_DICQUESTION.ColumnDCREATE] = value;
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
	                return ((System.Int16)(this[this.tableWJ_DICQUESTION.ColumnNSORT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableWJ_DICQUESTION.ColumnNSORT] = value;
            }
        }
        
		/// 
		/// 字段NBIXUAN所映射的属性。
		/// 
        public System.Int16 NBIXUAN
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableWJ_DICQUESTION.ColumnNBIXUAN])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableWJ_DICQUESTION.ColumnNBIXUAN] = value;
            }
        }
        
		/// 
		/// 判断字段DCREATE是否为空。
		/// 
        public bool IsDCREATENull()
        {
            return this.IsNull(this.tableWJ_DICQUESTION.ColumnDCREATE);
        }

		/// 
		/// 设置字段DCREATE为空值。
		/// 
        public void SetDCREATENull() 
        {
            this[this.tableWJ_DICQUESTION.ColumnDCREATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSORT是否为空。
		/// 
        public bool IsNSORTNull()
        {
            return this.IsNull(this.tableWJ_DICQUESTION.ColumnNSORT);
        }

		/// 
		/// 设置字段NSORT为空值。
		/// 
        public void SetNSORTNull() 
        {
            this[this.tableWJ_DICQUESTION.ColumnNSORT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NBIXUAN是否为空。
		/// 
        public bool IsNBIXUANNull()
        {
            return this.IsNull(this.tableWJ_DICQUESTION.ColumnNBIXUAN);
        }

		/// 
		/// 设置字段NBIXUAN为空值。
		/// 
        public void SetNBIXUANNull() 
        {
            this[this.tableWJ_DICQUESTION.ColumnNBIXUAN] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventWJ_DICQUESTION : EventArgs {
        
        private RowWJ_DICQUESTION eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventWJ_DICQUESTION(RowWJ_DICQUESTION row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowWJ_DICQUESTION Row {
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
	