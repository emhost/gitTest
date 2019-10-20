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
	#region DataSetWJ_RECORD
	/// 
	/// 对于WJ_RECORD的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetWJ_RECORD : DataSet
    {
		
		private DataTableWJ_RECORD tableWJ_RECORD;
		
        public DataSetWJ_RECORD() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetWJ_RECORD实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetWJ_RECORD GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetWJ_RECORD dataSet = (DataSetWJ_RECORD)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetWJ_RECORD entity = new DataSetWJ_RECORD();
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
        
        protected DataSetWJ_RECORD(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["WJ_RECORD"] != null)) 
                {
                    this.Tables.Add(new DataTableWJ_RECORD(ds.Tables["WJ_RECORD"]));
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
		/// 对于数据表WJ_RECORD的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableWJ_RECORD WJ_RECORD 
		{
			get
			{
				return this.tableWJ_RECORD;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetWJ_RECORD cln = ((DataSetWJ_RECORD)(base.Clone()));
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
			
			if ((ds.Tables["WJ_RECORD"] != null)) 
			{
				this.Tables.Add(new DataTableWJ_RECORD(ds.Tables["WJ_RECORD"]));
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
			
			this.tableWJ_RECORD = ((DataTableWJ_RECORD)(this.Tables["WJ_RECORD"]));
			if ((this.tableWJ_RECORD != null)) {
				this.tableWJ_RECORD.InitVars();
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
			
			this.tableWJ_RECORD = new DataTableWJ_RECORD();
			this.Tables.Add(this.tableWJ_RECORD);
			
		}
		
		private bool ShouldSerializeWJ_RECORD() 
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
	
    public delegate void RowChangeEventHandlerWJ_RECORD(object sender, RowChangeEventWJ_RECORD e);
	
	#region DataTableWJ_RECORD
	/// 
	/// 对于数据表WJ_RECORD的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableWJ_RECORD : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVID;
		
        private DataColumn columnVWJID;
		
        private DataColumn columnVWJMC;
		
        private DataColumn columnVQUESID;
		
        private DataColumn columnVINPUTID;
		
        private DataColumn columnDCREATE;
		
        private DataColumn columnVQUESNAME;
		
        private DataColumn columnVANSID;
		
        private DataColumn columnVANSNAME;
		
        private DataColumn columnVDJH;
		
        internal DataTableWJ_RECORD() : base("WJ_RECORD") 
        {
            this.InitClass();
        }
        
        internal DataTableWJ_RECORD(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVWJID 
        {
            get 
            {
                return this.columnVWJID;
            }
        }
		
        public DataColumn ColumnVWJMC 
        {
            get 
            {
                return this.columnVWJMC;
            }
        }
		
        public DataColumn ColumnVQUESID 
        {
            get 
            {
                return this.columnVQUESID;
            }
        }
		
        public DataColumn ColumnVINPUTID 
        {
            get 
            {
                return this.columnVINPUTID;
            }
        }
		
        public DataColumn ColumnDCREATE 
        {
            get 
            {
                return this.columnDCREATE;
            }
        }
		
        public DataColumn ColumnVQUESNAME 
        {
            get 
            {
                return this.columnVQUESNAME;
            }
        }
		
        public DataColumn ColumnVANSID 
        {
            get 
            {
                return this.columnVANSID;
            }
        }
		
        public DataColumn ColumnVANSNAME 
        {
            get 
            {
                return this.columnVANSNAME;
            }
        }
		
        public DataColumn ColumnVDJH 
        {
            get 
            {
                return this.columnVDJH;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowWJ_RECORD this[int index] 
        {
            get 
            {
                return ((RowWJ_RECORD)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerWJ_RECORD RowChangedWJ_RECORD;
        
        public event RowChangeEventHandlerWJ_RECORD RowChangingWJ_RECORD;
        
        public event RowChangeEventHandlerWJ_RECORD RowDeletedWJ_RECORD;
        
        public event RowChangeEventHandlerWJ_RECORD RowDeletingWJ_RECORD;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowWJ_RECORD(RowWJ_RECORD row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowWJ_RECORD AddRowWJ_RECORD(System.String VID,System.String VWJID,System.String VWJMC,System.String VQUESID,System.String VINPUTID,System.DateTime DCREATE,System.String VQUESNAME,System.String VANSID,System.String VANSNAME,System.String VDJH) 
        {
            RowWJ_RECORD row = ((RowWJ_RECORD)(this.NewRow()));
            row.ItemArray = new object[] {VID,VWJID,VWJMC,VQUESID,VINPUTID,DCREATE,VQUESNAME,VANSID,VANSNAME,VDJH};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowWJ_RECORD FindByVID(System.String VID) {
            return ((RowWJ_RECORD)(this.Rows.Find(new object[] {
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
            DataTableWJ_RECORD cln = ((DataTableWJ_RECORD)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableWJ_RECORD();
        }
        
        internal void InitVars() 
        {	
            this.columnVID = this.Columns["VID"];
            this.columnVWJID = this.Columns["VWJID"];
            this.columnVWJMC = this.Columns["VWJMC"];
            this.columnVQUESID = this.Columns["VQUESID"];
            this.columnVINPUTID = this.Columns["VINPUTID"];
            this.columnDCREATE = this.Columns["DCREATE"];
            this.columnVQUESNAME = this.Columns["VQUESNAME"];
            this.columnVANSID = this.Columns["VANSID"];
            this.columnVANSNAME = this.Columns["VANSNAME"];
            this.columnVDJH = this.Columns["VDJH"];
        }
        
        private void InitClass() 
        {	
            this.columnVID = new DataColumn("VID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVID.MaxLength = 36;
            this.columnVID.AllowDBNull = false;
            this.columnVID.Unique = true;
            
            this.Columns.Add(this.columnVID);
			
            this.columnVWJID = new DataColumn("VWJID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVWJID.MaxLength = 36;
            this.columnVWJID.AllowDBNull = false;
            this.Columns.Add(this.columnVWJID);
			
            this.columnVWJMC = new DataColumn("VWJMC", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVWJMC.MaxLength = 50;
            this.columnVWJMC.AllowDBNull = false;
            this.Columns.Add(this.columnVWJMC);
			
            this.columnVQUESID = new DataColumn("VQUESID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVQUESID.MaxLength = 36;
            this.columnVQUESID.AllowDBNull = true;
            this.Columns.Add(this.columnVQUESID);
			
            this.columnVINPUTID = new DataColumn("VINPUTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVINPUTID.MaxLength = 36;
            this.columnVINPUTID.AllowDBNull = true;
            this.Columns.Add(this.columnVINPUTID);
			
            this.columnDCREATE = new DataColumn("DCREATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDCREATE.AllowDBNull = true;
            this.Columns.Add(this.columnDCREATE);
			
            this.columnVQUESNAME = new DataColumn("VQUESNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVQUESNAME.MaxLength = 80;
            this.columnVQUESNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVQUESNAME);
			
            this.columnVANSID = new DataColumn("VANSID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVANSID.MaxLength = 36;
            this.columnVANSID.AllowDBNull = true;
            this.Columns.Add(this.columnVANSID);
			
            this.columnVANSNAME = new DataColumn("VANSNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVANSNAME.MaxLength = 100;
            this.columnVANSNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVANSNAME);
			
            this.columnVDJH = new DataColumn("VDJH", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDJH.MaxLength = 36;
            this.columnVDJH.AllowDBNull = true;
            this.Columns.Add(this.columnVDJH);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowWJ_RECORD NewRowWJ_RECORD() {
            return ((RowWJ_RECORD)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowWJ_RECORD(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowWJ_RECORD);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedWJ_RECORD != null)) {
                this.RowChangedWJ_RECORD(this, new RowChangeEventWJ_RECORD(((RowWJ_RECORD)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingWJ_RECORD != null)) {
                this.RowChangingWJ_RECORD(this, new RowChangeEventWJ_RECORD(((RowWJ_RECORD)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedWJ_RECORD != null)) {
                this.RowDeletedWJ_RECORD(this, new RowChangeEventWJ_RECORD(((RowWJ_RECORD)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingWJ_RECORD != null)) {
                this.RowDeletingWJ_RECORD(this, new RowChangeEventWJ_RECORD(((RowWJ_RECORD)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowWJ_RECORD(RowWJ_RECORD row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowWJ_RECORD
	/// 
	/// 数据表WJ_RECORD行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowWJ_RECORD : DataRow 
    {
        
        private DataTableWJ_RECORD tableWJ_RECORD;
        
        internal RowWJ_RECORD(DataRowBuilder rb) : base(rb) 
        {
            this.tableWJ_RECORD = ((DataTableWJ_RECORD)(this.Table));
        }        
		
		/// 
		/// 字段VID所映射的属性。
		/// 
        public System.String VID
        {
            get 
            {	
                return ((System.String)(this[this.tableWJ_RECORD.ColumnVID])); 
            }
            set 
            {
                this[this.tableWJ_RECORD.ColumnVID] = value;
            }
        }
        
		/// 
		/// 字段VWJID所映射的属性。
		/// 
        public System.String VWJID
        {
            get 
            {	
                return ((System.String)(this[this.tableWJ_RECORD.ColumnVWJID])); 
            }
            set 
            {
                this[this.tableWJ_RECORD.ColumnVWJID] = value;
            }
        }
        
		/// 
		/// 字段VWJMC所映射的属性。
		/// 
        public System.String VWJMC
        {
            get 
            {	
                return ((System.String)(this[this.tableWJ_RECORD.ColumnVWJMC])); 
            }
            set 
            {
                this[this.tableWJ_RECORD.ColumnVWJMC] = value;
            }
        }
        
		/// 
		/// 字段VQUESID所映射的属性。
		/// 
        public System.String VQUESID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableWJ_RECORD.ColumnVQUESID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableWJ_RECORD.ColumnVQUESID] = value;
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
	                return ((System.String)(this[this.tableWJ_RECORD.ColumnVINPUTID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableWJ_RECORD.ColumnVINPUTID] = value;
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
	                return ((System.DateTime)(this[this.tableWJ_RECORD.ColumnDCREATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableWJ_RECORD.ColumnDCREATE] = value;
            }
        }
        
		/// 
		/// 字段VQUESNAME所映射的属性。
		/// 
        public System.String VQUESNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableWJ_RECORD.ColumnVQUESNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableWJ_RECORD.ColumnVQUESNAME] = value;
            }
        }
        
		/// 
		/// 字段VANSID所映射的属性。
		/// 
        public System.String VANSID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableWJ_RECORD.ColumnVANSID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableWJ_RECORD.ColumnVANSID] = value;
            }
        }
        
		/// 
		/// 字段VANSNAME所映射的属性。
		/// 
        public System.String VANSNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableWJ_RECORD.ColumnVANSNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableWJ_RECORD.ColumnVANSNAME] = value;
            }
        }
        
		/// 
		/// 字段VDJH所映射的属性。
		/// 
        public System.String VDJH
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableWJ_RECORD.ColumnVDJH])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableWJ_RECORD.ColumnVDJH] = value;
            }
        }
        
		/// 
		/// 判断字段VQUESID是否为空。
		/// 
        public bool IsVQUESIDNull()
        {
            return this.IsNull(this.tableWJ_RECORD.ColumnVQUESID);
        }

		/// 
		/// 设置字段VQUESID为空值。
		/// 
        public void SetVQUESIDNull() 
        {
            this[this.tableWJ_RECORD.ColumnVQUESID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VINPUTID是否为空。
		/// 
        public bool IsVINPUTIDNull()
        {
            return this.IsNull(this.tableWJ_RECORD.ColumnVINPUTID);
        }

		/// 
		/// 设置字段VINPUTID为空值。
		/// 
        public void SetVINPUTIDNull() 
        {
            this[this.tableWJ_RECORD.ColumnVINPUTID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DCREATE是否为空。
		/// 
        public bool IsDCREATENull()
        {
            return this.IsNull(this.tableWJ_RECORD.ColumnDCREATE);
        }

		/// 
		/// 设置字段DCREATE为空值。
		/// 
        public void SetDCREATENull() 
        {
            this[this.tableWJ_RECORD.ColumnDCREATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VQUESNAME是否为空。
		/// 
        public bool IsVQUESNAMENull()
        {
            return this.IsNull(this.tableWJ_RECORD.ColumnVQUESNAME);
        }

		/// 
		/// 设置字段VQUESNAME为空值。
		/// 
        public void SetVQUESNAMENull() 
        {
            this[this.tableWJ_RECORD.ColumnVQUESNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VANSID是否为空。
		/// 
        public bool IsVANSIDNull()
        {
            return this.IsNull(this.tableWJ_RECORD.ColumnVANSID);
        }

		/// 
		/// 设置字段VANSID为空值。
		/// 
        public void SetVANSIDNull() 
        {
            this[this.tableWJ_RECORD.ColumnVANSID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VANSNAME是否为空。
		/// 
        public bool IsVANSNAMENull()
        {
            return this.IsNull(this.tableWJ_RECORD.ColumnVANSNAME);
        }

		/// 
		/// 设置字段VANSNAME为空值。
		/// 
        public void SetVANSNAMENull() 
        {
            this[this.tableWJ_RECORD.ColumnVANSNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDJH是否为空。
		/// 
        public bool IsVDJHNull()
        {
            return this.IsNull(this.tableWJ_RECORD.ColumnVDJH);
        }

		/// 
		/// 设置字段VDJH为空值。
		/// 
        public void SetVDJHNull() 
        {
            this[this.tableWJ_RECORD.ColumnVDJH] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventWJ_RECORD : EventArgs {
        
        private RowWJ_RECORD eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventWJ_RECORD(RowWJ_RECORD row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowWJ_RECORD Row {
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
	