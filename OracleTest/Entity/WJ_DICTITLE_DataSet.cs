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
	#region DataSetWJ_DICTITLE
	/// 
	/// 对于WJ_DICTITLE的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetWJ_DICTITLE : DataSet
    {
		
		private DataTableWJ_DICTITLE tableWJ_DICTITLE;
		
        public DataSetWJ_DICTITLE() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetWJ_DICTITLE实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetWJ_DICTITLE GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetWJ_DICTITLE dataSet = (DataSetWJ_DICTITLE)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetWJ_DICTITLE entity = new DataSetWJ_DICTITLE();
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
        
        protected DataSetWJ_DICTITLE(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["WJ_DICTITLE"] != null)) 
                {
                    this.Tables.Add(new DataTableWJ_DICTITLE(ds.Tables["WJ_DICTITLE"]));
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
		/// 对于数据表WJ_DICTITLE的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableWJ_DICTITLE WJ_DICTITLE 
		{
			get
			{
				return this.tableWJ_DICTITLE;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetWJ_DICTITLE cln = ((DataSetWJ_DICTITLE)(base.Clone()));
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
			
			if ((ds.Tables["WJ_DICTITLE"] != null)) 
			{
				this.Tables.Add(new DataTableWJ_DICTITLE(ds.Tables["WJ_DICTITLE"]));
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
			
			this.tableWJ_DICTITLE = ((DataTableWJ_DICTITLE)(this.Tables["WJ_DICTITLE"]));
			if ((this.tableWJ_DICTITLE != null)) {
				this.tableWJ_DICTITLE.InitVars();
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
			
			this.tableWJ_DICTITLE = new DataTableWJ_DICTITLE();
			this.Tables.Add(this.tableWJ_DICTITLE);
			
		}
		
		private bool ShouldSerializeWJ_DICTITLE() 
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
	
    public delegate void RowChangeEventHandlerWJ_DICTITLE(object sender, RowChangeEventWJ_DICTITLE e);
	
	#region DataTableWJ_DICTITLE
	/// 
	/// 对于数据表WJ_DICTITLE的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableWJ_DICTITLE : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVID;
		
        private DataColumn columnVNAME;
		
        private DataColumn columnVREMARKS;
		
        private DataColumn columnDCREATE;
		
        private DataColumn columnVINPUTID;
		
        private DataColumn columnNSTOP;
		
        private DataColumn columnNSORT;
		
        internal DataTableWJ_DICTITLE() : base("WJ_DICTITLE") 
        {
            this.InitClass();
        }
        
        internal DataTableWJ_DICTITLE(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVREMARKS 
        {
            get 
            {
                return this.columnVREMARKS;
            }
        }
		
        public DataColumn ColumnDCREATE 
        {
            get 
            {
                return this.columnDCREATE;
            }
        }
		
        public DataColumn ColumnVINPUTID 
        {
            get 
            {
                return this.columnVINPUTID;
            }
        }
		
        public DataColumn ColumnNSTOP 
        {
            get 
            {
                return this.columnNSTOP;
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
        public RowWJ_DICTITLE this[int index] 
        {
            get 
            {
                return ((RowWJ_DICTITLE)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerWJ_DICTITLE RowChangedWJ_DICTITLE;
        
        public event RowChangeEventHandlerWJ_DICTITLE RowChangingWJ_DICTITLE;
        
        public event RowChangeEventHandlerWJ_DICTITLE RowDeletedWJ_DICTITLE;
        
        public event RowChangeEventHandlerWJ_DICTITLE RowDeletingWJ_DICTITLE;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowWJ_DICTITLE(RowWJ_DICTITLE row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowWJ_DICTITLE AddRowWJ_DICTITLE(System.String VID,System.String VNAME,System.String VREMARKS,System.DateTime DCREATE,System.String VINPUTID,System.Int16 NSTOP,System.Int32 NSORT) 
        {
            RowWJ_DICTITLE row = ((RowWJ_DICTITLE)(this.NewRow()));
            row.ItemArray = new object[] {VID,VNAME,VREMARKS,DCREATE,VINPUTID,NSTOP,NSORT};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowWJ_DICTITLE FindByVID(System.String VID) {
            return ((RowWJ_DICTITLE)(this.Rows.Find(new object[] {
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
            DataTableWJ_DICTITLE cln = ((DataTableWJ_DICTITLE)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableWJ_DICTITLE();
        }
        
        internal void InitVars() 
        {	
            this.columnVID = this.Columns["VID"];
            this.columnVNAME = this.Columns["VNAME"];
            this.columnVREMARKS = this.Columns["VREMARKS"];
            this.columnDCREATE = this.Columns["DCREATE"];
            this.columnVINPUTID = this.Columns["VINPUTID"];
            this.columnNSTOP = this.Columns["NSTOP"];
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
            this.columnVNAME.MaxLength = 20;
            this.columnVNAME.AllowDBNull = false;
            this.Columns.Add(this.columnVNAME);
			
            this.columnVREMARKS = new DataColumn("VREMARKS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVREMARKS.MaxLength = 30;
            this.columnVREMARKS.AllowDBNull = true;
            this.Columns.Add(this.columnVREMARKS);
			
            this.columnDCREATE = new DataColumn("DCREATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDCREATE.AllowDBNull = false;
            this.Columns.Add(this.columnDCREATE);
			
            this.columnVINPUTID = new DataColumn("VINPUTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVINPUTID.MaxLength = 36;
            this.columnVINPUTID.AllowDBNull = true;
            this.Columns.Add(this.columnVINPUTID);
			
            this.columnNSTOP = new DataColumn("NSTOP", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNSTOP.DefaultValue = "0";
            this.columnNSTOP.AllowDBNull = false;
            this.Columns.Add(this.columnNSTOP);
			
            this.columnNSORT = new DataColumn("NSORT", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNSORT.AllowDBNull = true;
            this.Columns.Add(this.columnNSORT);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowWJ_DICTITLE NewRowWJ_DICTITLE() {
            return ((RowWJ_DICTITLE)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowWJ_DICTITLE(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowWJ_DICTITLE);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedWJ_DICTITLE != null)) {
                this.RowChangedWJ_DICTITLE(this, new RowChangeEventWJ_DICTITLE(((RowWJ_DICTITLE)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingWJ_DICTITLE != null)) {
                this.RowChangingWJ_DICTITLE(this, new RowChangeEventWJ_DICTITLE(((RowWJ_DICTITLE)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedWJ_DICTITLE != null)) {
                this.RowDeletedWJ_DICTITLE(this, new RowChangeEventWJ_DICTITLE(((RowWJ_DICTITLE)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingWJ_DICTITLE != null)) {
                this.RowDeletingWJ_DICTITLE(this, new RowChangeEventWJ_DICTITLE(((RowWJ_DICTITLE)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowWJ_DICTITLE(RowWJ_DICTITLE row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowWJ_DICTITLE
	/// 
	/// 数据表WJ_DICTITLE行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowWJ_DICTITLE : DataRow 
    {
        
        private DataTableWJ_DICTITLE tableWJ_DICTITLE;
        
        internal RowWJ_DICTITLE(DataRowBuilder rb) : base(rb) 
        {
            this.tableWJ_DICTITLE = ((DataTableWJ_DICTITLE)(this.Table));
        }        
		
		/// 
		/// 字段VID所映射的属性。
		/// 
        public System.String VID
        {
            get 
            {	
                return ((System.String)(this[this.tableWJ_DICTITLE.ColumnVID])); 
            }
            set 
            {
                this[this.tableWJ_DICTITLE.ColumnVID] = value;
            }
        }
        
		/// 
		/// 字段VNAME所映射的属性。
		/// 
        public System.String VNAME
        {
            get 
            {	
                return ((System.String)(this[this.tableWJ_DICTITLE.ColumnVNAME])); 
            }
            set 
            {
                this[this.tableWJ_DICTITLE.ColumnVNAME] = value;
            }
        }
        
		/// 
		/// 字段VREMARKS所映射的属性。
		/// 
        public System.String VREMARKS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableWJ_DICTITLE.ColumnVREMARKS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableWJ_DICTITLE.ColumnVREMARKS] = value;
            }
        }
        
		/// 
		/// 字段DCREATE所映射的属性。
		/// 
        public System.DateTime DCREATE
        {
            get 
            {	
                return ((System.DateTime)(this[this.tableWJ_DICTITLE.ColumnDCREATE])); 
            }
            set 
            {
                this[this.tableWJ_DICTITLE.ColumnDCREATE] = value;
            }
        }
        
		/// 
		/// 字段VINPUTID所映射的属性。
		/// 
        public System.String VINPUTID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableWJ_DICTITLE.ColumnVINPUTID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableWJ_DICTITLE.ColumnVINPUTID] = value;
            }
        }
        
		/// 
		/// 字段NSTOP所映射的属性。
		/// 
        public System.Int16 NSTOP
        {
            get 
            {	
                return ((System.Int16)(this[this.tableWJ_DICTITLE.ColumnNSTOP])); 
            }
            set 
            {
                this[this.tableWJ_DICTITLE.ColumnNSTOP] = value;
            }
        }
        
		/// 
		/// 字段NSORT所映射的属性。
		/// 
        public System.Int32 NSORT
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableWJ_DICTITLE.ColumnNSORT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableWJ_DICTITLE.ColumnNSORT] = value;
            }
        }
        
		/// 
		/// 判断字段VREMARKS是否为空。
		/// 
        public bool IsVREMARKSNull()
        {
            return this.IsNull(this.tableWJ_DICTITLE.ColumnVREMARKS);
        }

		/// 
		/// 设置字段VREMARKS为空值。
		/// 
        public void SetVREMARKSNull() 
        {
            this[this.tableWJ_DICTITLE.ColumnVREMARKS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VINPUTID是否为空。
		/// 
        public bool IsVINPUTIDNull()
        {
            return this.IsNull(this.tableWJ_DICTITLE.ColumnVINPUTID);
        }

		/// 
		/// 设置字段VINPUTID为空值。
		/// 
        public void SetVINPUTIDNull() 
        {
            this[this.tableWJ_DICTITLE.ColumnVINPUTID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSORT是否为空。
		/// 
        public bool IsNSORTNull()
        {
            return this.IsNull(this.tableWJ_DICTITLE.ColumnNSORT);
        }

		/// 
		/// 设置字段NSORT为空值。
		/// 
        public void SetNSORTNull() 
        {
            this[this.tableWJ_DICTITLE.ColumnNSORT] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventWJ_DICTITLE : EventArgs {
        
        private RowWJ_DICTITLE eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventWJ_DICTITLE(RowWJ_DICTITLE row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowWJ_DICTITLE Row {
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
	