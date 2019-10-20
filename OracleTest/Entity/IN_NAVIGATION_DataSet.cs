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
	#region DataSetIN_NAVIGATION
	/// 
	/// 对于IN_NAVIGATION的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetIN_NAVIGATION : DataSet
    {
		
		private DataTableYWAPP_INHOSPITAL_NAVIGATION tableYWAPP_INHOSPITAL_NAVIGATION;
		
        public DataSetIN_NAVIGATION() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetIN_NAVIGATION实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetIN_NAVIGATION GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetIN_NAVIGATION dataSet = (DataSetIN_NAVIGATION)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetIN_NAVIGATION entity = new DataSetIN_NAVIGATION();
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
        
        protected DataSetIN_NAVIGATION(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["YWAPP_INHOSPITAL_NAVIGATION"] != null)) 
                {
                    this.Tables.Add(new DataTableYWAPP_INHOSPITAL_NAVIGATION(ds.Tables["YWAPP_INHOSPITAL_NAVIGATION"]));
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
		/// 对于数据表YWAPP_INHOSPITAL_NAVIGATION的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableYWAPP_INHOSPITAL_NAVIGATION YWAPP_INHOSPITAL_NAVIGATION 
		{
			get
			{
				return this.tableYWAPP_INHOSPITAL_NAVIGATION;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetIN_NAVIGATION cln = ((DataSetIN_NAVIGATION)(base.Clone()));
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
			
			if ((ds.Tables["YWAPP_INHOSPITAL_NAVIGATION"] != null)) 
			{
				this.Tables.Add(new DataTableYWAPP_INHOSPITAL_NAVIGATION(ds.Tables["YWAPP_INHOSPITAL_NAVIGATION"]));
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
			
			this.tableYWAPP_INHOSPITAL_NAVIGATION = ((DataTableYWAPP_INHOSPITAL_NAVIGATION)(this.Tables["YWAPP_INHOSPITAL_NAVIGATION"]));
			if ((this.tableYWAPP_INHOSPITAL_NAVIGATION != null)) {
				this.tableYWAPP_INHOSPITAL_NAVIGATION.InitVars();
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
			
			this.tableYWAPP_INHOSPITAL_NAVIGATION = new DataTableYWAPP_INHOSPITAL_NAVIGATION();
			this.Tables.Add(this.tableYWAPP_INHOSPITAL_NAVIGATION);
			
		}
		
		private bool ShouldSerializeYWAPP_INHOSPITAL_NAVIGATION() 
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
	
    public delegate void RowChangeEventHandlerYWAPP_INHOSPITAL_NAVIGATION(object sender, RowChangeEventYWAPP_INHOSPITAL_NAVIGATION e);
	
	#region DataTableYWAPP_INHOSPITAL_NAVIGATION
	/// 
	/// 对于数据表YWAPP_INHOSPITAL_NAVIGATION的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableYWAPP_INHOSPITAL_NAVIGATION : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnHOSPITALID;
		
        private DataColumn columnID;
		
        private DataColumn columnFLOORNAME;
		
        private DataColumn columnFLOORMAP;
		
        internal DataTableYWAPP_INHOSPITAL_NAVIGATION() : base("YWAPP_INHOSPITAL_NAVIGATION") 
        {
            this.InitClass();
        }
        
        internal DataTableYWAPP_INHOSPITAL_NAVIGATION(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnHOSPITALID 
        {
            get 
            {
                return this.columnHOSPITALID;
            }
        }
		
        public DataColumn ColumnID 
        {
            get 
            {
                return this.columnID;
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
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowYWAPP_INHOSPITAL_NAVIGATION this[int index] 
        {
            get 
            {
                return ((RowYWAPP_INHOSPITAL_NAVIGATION)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerYWAPP_INHOSPITAL_NAVIGATION RowChangedYWAPP_INHOSPITAL_NAVIGATION;
        
        public event RowChangeEventHandlerYWAPP_INHOSPITAL_NAVIGATION RowChangingYWAPP_INHOSPITAL_NAVIGATION;
        
        public event RowChangeEventHandlerYWAPP_INHOSPITAL_NAVIGATION RowDeletedYWAPP_INHOSPITAL_NAVIGATION;
        
        public event RowChangeEventHandlerYWAPP_INHOSPITAL_NAVIGATION RowDeletingYWAPP_INHOSPITAL_NAVIGATION;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowYWAPP_INHOSPITAL_NAVIGATION(RowYWAPP_INHOSPITAL_NAVIGATION row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowYWAPP_INHOSPITAL_NAVIGATION AddRowYWAPP_INHOSPITAL_NAVIGATION(System.String HOSPITALID,System.String ID,System.String FLOORNAME,System.Byte[] FLOORMAP) 
        {
            RowYWAPP_INHOSPITAL_NAVIGATION row = ((RowYWAPP_INHOSPITAL_NAVIGATION)(this.NewRow()));
            row.ItemArray = new object[] {HOSPITALID,ID,FLOORNAME,FLOORMAP};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowYWAPP_INHOSPITAL_NAVIGATION FindByID(System.String ID) {
            return ((RowYWAPP_INHOSPITAL_NAVIGATION)(this.Rows.Find(new object[] {
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
            DataTableYWAPP_INHOSPITAL_NAVIGATION cln = ((DataTableYWAPP_INHOSPITAL_NAVIGATION)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableYWAPP_INHOSPITAL_NAVIGATION();
        }
        
        internal void InitVars() 
        {	
            this.columnHOSPITALID = this.Columns["HOSPITALID"];
            this.columnID = this.Columns["ID"];
            this.columnFLOORNAME = this.Columns["FLOORNAME"];
            this.columnFLOORMAP = this.Columns["FLOORMAP"];
        }
        
        private void InitClass() 
        {	
            this.columnHOSPITALID = new DataColumn("HOSPITALID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnHOSPITALID.MaxLength = 20;
            this.columnHOSPITALID.AllowDBNull = true;
            this.Columns.Add(this.columnHOSPITALID);
			
            this.columnID = new DataColumn("ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnID.MaxLength = 36;
            this.columnID.AllowDBNull = false;
            this.columnID.Unique = true;
            
            this.Columns.Add(this.columnID);
			
            this.columnFLOORNAME = new DataColumn("FLOORNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnFLOORNAME.MaxLength = 20;
            this.columnFLOORNAME.AllowDBNull = true;
            this.Columns.Add(this.columnFLOORNAME);
			
            this.columnFLOORMAP = new DataColumn("FLOORMAP", typeof(System.Byte[]), null, System.Data.MappingType.Element);
            this.columnFLOORMAP.AllowDBNull = true;
            this.Columns.Add(this.columnFLOORMAP);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowYWAPP_INHOSPITAL_NAVIGATION NewRowYWAPP_INHOSPITAL_NAVIGATION() {
            return ((RowYWAPP_INHOSPITAL_NAVIGATION)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowYWAPP_INHOSPITAL_NAVIGATION(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowYWAPP_INHOSPITAL_NAVIGATION);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedYWAPP_INHOSPITAL_NAVIGATION != null)) {
                this.RowChangedYWAPP_INHOSPITAL_NAVIGATION(this, new RowChangeEventYWAPP_INHOSPITAL_NAVIGATION(((RowYWAPP_INHOSPITAL_NAVIGATION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingYWAPP_INHOSPITAL_NAVIGATION != null)) {
                this.RowChangingYWAPP_INHOSPITAL_NAVIGATION(this, new RowChangeEventYWAPP_INHOSPITAL_NAVIGATION(((RowYWAPP_INHOSPITAL_NAVIGATION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedYWAPP_INHOSPITAL_NAVIGATION != null)) {
                this.RowDeletedYWAPP_INHOSPITAL_NAVIGATION(this, new RowChangeEventYWAPP_INHOSPITAL_NAVIGATION(((RowYWAPP_INHOSPITAL_NAVIGATION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingYWAPP_INHOSPITAL_NAVIGATION != null)) {
                this.RowDeletingYWAPP_INHOSPITAL_NAVIGATION(this, new RowChangeEventYWAPP_INHOSPITAL_NAVIGATION(((RowYWAPP_INHOSPITAL_NAVIGATION)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowYWAPP_INHOSPITAL_NAVIGATION(RowYWAPP_INHOSPITAL_NAVIGATION row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowYWAPP_INHOSPITAL_NAVIGATION
	/// 
	/// 数据表YWAPP_INHOSPITAL_NAVIGATION行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowYWAPP_INHOSPITAL_NAVIGATION : DataRow 
    {
        
        private DataTableYWAPP_INHOSPITAL_NAVIGATION tableYWAPP_INHOSPITAL_NAVIGATION;
        
        internal RowYWAPP_INHOSPITAL_NAVIGATION(DataRowBuilder rb) : base(rb) 
        {
            this.tableYWAPP_INHOSPITAL_NAVIGATION = ((DataTableYWAPP_INHOSPITAL_NAVIGATION)(this.Table));
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
	                return ((System.String)(this[this.tableYWAPP_INHOSPITAL_NAVIGATION.ColumnHOSPITALID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_INHOSPITAL_NAVIGATION.ColumnHOSPITALID] = value;
            }
        }
        
		/// 
		/// 字段ID所映射的属性。
		/// 
        public System.String ID
        {
            get 
            {	
                return ((System.String)(this[this.tableYWAPP_INHOSPITAL_NAVIGATION.ColumnID])); 
            }
            set 
            {
                this[this.tableYWAPP_INHOSPITAL_NAVIGATION.ColumnID] = value;
            }
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
	                return ((System.String)(this[this.tableYWAPP_INHOSPITAL_NAVIGATION.ColumnFLOORNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_INHOSPITAL_NAVIGATION.ColumnFLOORNAME] = value;
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
	                return ((System.Byte[])(this[this.tableYWAPP_INHOSPITAL_NAVIGATION.ColumnFLOORMAP])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableYWAPP_INHOSPITAL_NAVIGATION.ColumnFLOORMAP] = value;
            }
        }
        
		/// 
		/// 判断字段HOSPITALID是否为空。
		/// 
        public bool IsHOSPITALIDNull()
        {
            return this.IsNull(this.tableYWAPP_INHOSPITAL_NAVIGATION.ColumnHOSPITALID);
        }

		/// 
		/// 设置字段HOSPITALID为空值。
		/// 
        public void SetHOSPITALIDNull() 
        {
            this[this.tableYWAPP_INHOSPITAL_NAVIGATION.ColumnHOSPITALID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段FLOORNAME是否为空。
		/// 
        public bool IsFLOORNAMENull()
        {
            return this.IsNull(this.tableYWAPP_INHOSPITAL_NAVIGATION.ColumnFLOORNAME);
        }

		/// 
		/// 设置字段FLOORNAME为空值。
		/// 
        public void SetFLOORNAMENull() 
        {
            this[this.tableYWAPP_INHOSPITAL_NAVIGATION.ColumnFLOORNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段FLOORMAP是否为空。
		/// 
        public bool IsFLOORMAPNull()
        {
            return this.IsNull(this.tableYWAPP_INHOSPITAL_NAVIGATION.ColumnFLOORMAP);
        }

		/// 
		/// 设置字段FLOORMAP为空值。
		/// 
        public void SetFLOORMAPNull() 
        {
            this[this.tableYWAPP_INHOSPITAL_NAVIGATION.ColumnFLOORMAP] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventYWAPP_INHOSPITAL_NAVIGATION : EventArgs {
        
        private RowYWAPP_INHOSPITAL_NAVIGATION eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventYWAPP_INHOSPITAL_NAVIGATION(RowYWAPP_INHOSPITAL_NAVIGATION row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowYWAPP_INHOSPITAL_NAVIGATION Row {
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
	