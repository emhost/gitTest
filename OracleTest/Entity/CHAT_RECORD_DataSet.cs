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
	#region DataSetCHAT_RECORD
	/// 
	/// 对于CHAT_RECORD的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetCHAT_RECORD : DataSet
    {
		
		private DataTableCHAT_RECORD tableCHAT_RECORD;
		
        public DataSetCHAT_RECORD() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetCHAT_RECORD实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetCHAT_RECORD GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetCHAT_RECORD dataSet = (DataSetCHAT_RECORD)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetCHAT_RECORD entity = new DataSetCHAT_RECORD();
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
        
        protected DataSetCHAT_RECORD(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["CHAT_RECORD"] != null)) 
                {
                    this.Tables.Add(new DataTableCHAT_RECORD(ds.Tables["CHAT_RECORD"]));
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
		/// 对于数据表CHAT_RECORD的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableCHAT_RECORD CHAT_RECORD 
		{
			get
			{
				return this.tableCHAT_RECORD;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetCHAT_RECORD cln = ((DataSetCHAT_RECORD)(base.Clone()));
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
			
			if ((ds.Tables["CHAT_RECORD"] != null)) 
			{
				this.Tables.Add(new DataTableCHAT_RECORD(ds.Tables["CHAT_RECORD"]));
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
			
			this.tableCHAT_RECORD = ((DataTableCHAT_RECORD)(this.Tables["CHAT_RECORD"]));
			if ((this.tableCHAT_RECORD != null)) {
				this.tableCHAT_RECORD.InitVars();
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
			
			this.tableCHAT_RECORD = new DataTableCHAT_RECORD();
			this.Tables.Add(this.tableCHAT_RECORD);
			
		}
		
		private bool ShouldSerializeCHAT_RECORD() 
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
	
    public delegate void RowChangeEventHandlerCHAT_RECORD(object sender, RowChangeEventCHAT_RECORD e);
	
	#region DataTableCHAT_RECORD
	/// 
	/// 对于数据表CHAT_RECORD的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableCHAT_RECORD : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnDREAD;
		
        private DataColumn columnVID;
		
        private DataColumn columnVSID;
		
        private DataColumn columnVRID;
		
        private DataColumn columnVSNAME;
		
        private DataColumn columnVRNAME;
		
        private DataColumn columnDCREATE;
		
        private DataColumn columnCONTENT;
		
        private DataColumn columnTYPE;
		
        private DataColumn columnNREAD;
		
        internal DataTableCHAT_RECORD() : base("CHAT_RECORD") 
        {
            this.InitClass();
        }
        
        internal DataTableCHAT_RECORD(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnDREAD 
        {
            get 
            {
                return this.columnDREAD;
            }
        }
		
        public DataColumn ColumnVID 
        {
            get 
            {
                return this.columnVID;
            }
        }
		
        public DataColumn ColumnVSID 
        {
            get 
            {
                return this.columnVSID;
            }
        }
		
        public DataColumn ColumnVRID 
        {
            get 
            {
                return this.columnVRID;
            }
        }
		
        public DataColumn ColumnVSNAME 
        {
            get 
            {
                return this.columnVSNAME;
            }
        }
		
        public DataColumn ColumnVRNAME 
        {
            get 
            {
                return this.columnVRNAME;
            }
        }
		
        public DataColumn ColumnDCREATE 
        {
            get 
            {
                return this.columnDCREATE;
            }
        }
		
        public DataColumn ColumnCONTENT 
        {
            get 
            {
                return this.columnCONTENT;
            }
        }
		
        public DataColumn ColumnTYPE 
        {
            get 
            {
                return this.columnTYPE;
            }
        }
		
        public DataColumn ColumnNREAD 
        {
            get 
            {
                return this.columnNREAD;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowCHAT_RECORD this[int index] 
        {
            get 
            {
                return ((RowCHAT_RECORD)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerCHAT_RECORD RowChangedCHAT_RECORD;
        
        public event RowChangeEventHandlerCHAT_RECORD RowChangingCHAT_RECORD;
        
        public event RowChangeEventHandlerCHAT_RECORD RowDeletedCHAT_RECORD;
        
        public event RowChangeEventHandlerCHAT_RECORD RowDeletingCHAT_RECORD;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowCHAT_RECORD(RowCHAT_RECORD row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowCHAT_RECORD AddRowCHAT_RECORD(System.DateTime DREAD,System.String VID,System.String VSID,System.String VRID,System.String VSNAME,System.String VRNAME,System.DateTime DCREATE,System.Byte[] CONTENT,System.String TYPE,System.Int16 NREAD) 
        {
            RowCHAT_RECORD row = ((RowCHAT_RECORD)(this.NewRow()));
            row.ItemArray = new object[] {DREAD,VID,VSID,VRID,VSNAME,VRNAME,DCREATE,CONTENT,TYPE,NREAD};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowCHAT_RECORD FindByVID(System.String VID) {
            return ((RowCHAT_RECORD)(this.Rows.Find(new object[] {
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
            DataTableCHAT_RECORD cln = ((DataTableCHAT_RECORD)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableCHAT_RECORD();
        }
        
        internal void InitVars() 
        {	
            this.columnDREAD = this.Columns["DREAD"];
            this.columnVID = this.Columns["VID"];
            this.columnVSID = this.Columns["VSID"];
            this.columnVRID = this.Columns["VRID"];
            this.columnVSNAME = this.Columns["VSNAME"];
            this.columnVRNAME = this.Columns["VRNAME"];
            this.columnDCREATE = this.Columns["DCREATE"];
            this.columnCONTENT = this.Columns["CONTENT"];
            this.columnTYPE = this.Columns["TYPE"];
            this.columnNREAD = this.Columns["NREAD"];
        }
        
        private void InitClass() 
        {	
            this.columnDREAD = new DataColumn("DREAD", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDREAD.AllowDBNull = true;
            this.Columns.Add(this.columnDREAD);
			
            this.columnVID = new DataColumn("VID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVID.MaxLength = 36;
            this.columnVID.AllowDBNull = false;
            this.columnVID.Unique = true;
            
            this.Columns.Add(this.columnVID);
			
            this.columnVSID = new DataColumn("VSID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVSID.MaxLength = 36;
            this.columnVSID.AllowDBNull = true;
            this.Columns.Add(this.columnVSID);
			
            this.columnVRID = new DataColumn("VRID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVRID.MaxLength = 36;
            this.columnVRID.AllowDBNull = true;
            this.Columns.Add(this.columnVRID);
			
            this.columnVSNAME = new DataColumn("VSNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVSNAME.MaxLength = 10;
            this.columnVSNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVSNAME);
			
            this.columnVRNAME = new DataColumn("VRNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVRNAME.MaxLength = 10;
            this.columnVRNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVRNAME);
			
            this.columnDCREATE = new DataColumn("DCREATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDCREATE.AllowDBNull = true;
            this.Columns.Add(this.columnDCREATE);
			
            this.columnCONTENT = new DataColumn("CONTENT", typeof(System.Byte[]), null, System.Data.MappingType.Element);
            this.columnCONTENT.AllowDBNull = true;
            this.Columns.Add(this.columnCONTENT);
			
            this.columnTYPE = new DataColumn("TYPE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnTYPE.MaxLength = 10;
            this.columnTYPE.AllowDBNull = true;
            this.Columns.Add(this.columnTYPE);
			
            this.columnNREAD = new DataColumn("NREAD", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNREAD.AllowDBNull = true;
            this.Columns.Add(this.columnNREAD);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowCHAT_RECORD NewRowCHAT_RECORD() {
            return ((RowCHAT_RECORD)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowCHAT_RECORD(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowCHAT_RECORD);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedCHAT_RECORD != null)) {
                this.RowChangedCHAT_RECORD(this, new RowChangeEventCHAT_RECORD(((RowCHAT_RECORD)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingCHAT_RECORD != null)) {
                this.RowChangingCHAT_RECORD(this, new RowChangeEventCHAT_RECORD(((RowCHAT_RECORD)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedCHAT_RECORD != null)) {
                this.RowDeletedCHAT_RECORD(this, new RowChangeEventCHAT_RECORD(((RowCHAT_RECORD)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingCHAT_RECORD != null)) {
                this.RowDeletingCHAT_RECORD(this, new RowChangeEventCHAT_RECORD(((RowCHAT_RECORD)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowCHAT_RECORD(RowCHAT_RECORD row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowCHAT_RECORD
	/// 
	/// 数据表CHAT_RECORD行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowCHAT_RECORD : DataRow 
    {
        
        private DataTableCHAT_RECORD tableCHAT_RECORD;
        
        internal RowCHAT_RECORD(DataRowBuilder rb) : base(rb) 
        {
            this.tableCHAT_RECORD = ((DataTableCHAT_RECORD)(this.Table));
        }        
		
		/// 
		/// 字段DREAD所映射的属性。
		/// 
        public System.DateTime DREAD
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableCHAT_RECORD.ColumnDREAD])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableCHAT_RECORD.ColumnDREAD] = value;
            }
        }
        
		/// 
		/// 字段VID所映射的属性。
		/// 
        public System.String VID
        {
            get 
            {	
                return ((System.String)(this[this.tableCHAT_RECORD.ColumnVID])); 
            }
            set 
            {
                this[this.tableCHAT_RECORD.ColumnVID] = value;
            }
        }
        
		/// 
		/// 字段VSID所映射的属性。
		/// 
        public System.String VSID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableCHAT_RECORD.ColumnVSID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableCHAT_RECORD.ColumnVSID] = value;
            }
        }
        
		/// 
		/// 字段VRID所映射的属性。
		/// 
        public System.String VRID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableCHAT_RECORD.ColumnVRID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableCHAT_RECORD.ColumnVRID] = value;
            }
        }
        
		/// 
		/// 字段VSNAME所映射的属性。
		/// 
        public System.String VSNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableCHAT_RECORD.ColumnVSNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableCHAT_RECORD.ColumnVSNAME] = value;
            }
        }
        
		/// 
		/// 字段VRNAME所映射的属性。
		/// 
        public System.String VRNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableCHAT_RECORD.ColumnVRNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableCHAT_RECORD.ColumnVRNAME] = value;
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
	                return ((System.DateTime)(this[this.tableCHAT_RECORD.ColumnDCREATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableCHAT_RECORD.ColumnDCREATE] = value;
            }
        }
        
		/// 
		/// 字段CONTENT所映射的属性。
		/// 
        public System.Byte[] CONTENT
        {
            get 
            {	
                try 
                {
	                return ((System.Byte[])(this[this.tableCHAT_RECORD.ColumnCONTENT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableCHAT_RECORD.ColumnCONTENT] = value;
            }
        }
        
		/// 
		/// 字段TYPE所映射的属性。
		/// 
        public System.String TYPE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableCHAT_RECORD.ColumnTYPE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableCHAT_RECORD.ColumnTYPE] = value;
            }
        }
        
		/// 
		/// 字段NREAD所映射的属性。
		/// 
        public System.Int16 NREAD
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableCHAT_RECORD.ColumnNREAD])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableCHAT_RECORD.ColumnNREAD] = value;
            }
        }
        
		/// 
		/// 判断字段DREAD是否为空。
		/// 
        public bool IsDREADNull()
        {
            return this.IsNull(this.tableCHAT_RECORD.ColumnDREAD);
        }

		/// 
		/// 设置字段DREAD为空值。
		/// 
        public void SetDREADNull() 
        {
            this[this.tableCHAT_RECORD.ColumnDREAD] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VSID是否为空。
		/// 
        public bool IsVSIDNull()
        {
            return this.IsNull(this.tableCHAT_RECORD.ColumnVSID);
        }

		/// 
		/// 设置字段VSID为空值。
		/// 
        public void SetVSIDNull() 
        {
            this[this.tableCHAT_RECORD.ColumnVSID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VRID是否为空。
		/// 
        public bool IsVRIDNull()
        {
            return this.IsNull(this.tableCHAT_RECORD.ColumnVRID);
        }

		/// 
		/// 设置字段VRID为空值。
		/// 
        public void SetVRIDNull() 
        {
            this[this.tableCHAT_RECORD.ColumnVRID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VSNAME是否为空。
		/// 
        public bool IsVSNAMENull()
        {
            return this.IsNull(this.tableCHAT_RECORD.ColumnVSNAME);
        }

		/// 
		/// 设置字段VSNAME为空值。
		/// 
        public void SetVSNAMENull() 
        {
            this[this.tableCHAT_RECORD.ColumnVSNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VRNAME是否为空。
		/// 
        public bool IsVRNAMENull()
        {
            return this.IsNull(this.tableCHAT_RECORD.ColumnVRNAME);
        }

		/// 
		/// 设置字段VRNAME为空值。
		/// 
        public void SetVRNAMENull() 
        {
            this[this.tableCHAT_RECORD.ColumnVRNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DCREATE是否为空。
		/// 
        public bool IsDCREATENull()
        {
            return this.IsNull(this.tableCHAT_RECORD.ColumnDCREATE);
        }

		/// 
		/// 设置字段DCREATE为空值。
		/// 
        public void SetDCREATENull() 
        {
            this[this.tableCHAT_RECORD.ColumnDCREATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段CONTENT是否为空。
		/// 
        public bool IsCONTENTNull()
        {
            return this.IsNull(this.tableCHAT_RECORD.ColumnCONTENT);
        }

		/// 
		/// 设置字段CONTENT为空值。
		/// 
        public void SetCONTENTNull() 
        {
            this[this.tableCHAT_RECORD.ColumnCONTENT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段TYPE是否为空。
		/// 
        public bool IsTYPENull()
        {
            return this.IsNull(this.tableCHAT_RECORD.ColumnTYPE);
        }

		/// 
		/// 设置字段TYPE为空值。
		/// 
        public void SetTYPENull() 
        {
            this[this.tableCHAT_RECORD.ColumnTYPE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NREAD是否为空。
		/// 
        public bool IsNREADNull()
        {
            return this.IsNull(this.tableCHAT_RECORD.ColumnNREAD);
        }

		/// 
		/// 设置字段NREAD为空值。
		/// 
        public void SetNREADNull() 
        {
            this[this.tableCHAT_RECORD.ColumnNREAD] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventCHAT_RECORD : EventArgs {
        
        private RowCHAT_RECORD eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventCHAT_RECORD(RowCHAT_RECORD row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowCHAT_RECORD Row {
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
	