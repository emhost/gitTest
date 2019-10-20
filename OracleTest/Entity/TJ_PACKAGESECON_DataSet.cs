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
	#region DataSetTJ_PACKAGESECON
	/// 
	/// 对于TJ_PACKAGESECON的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetTJ_PACKAGESECON : DataSet
    {
		
		private DataTableTJ_TJ_PACKAGESECON tableTJ_TJ_PACKAGESECON;
		
        public DataSetTJ_PACKAGESECON() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetTJ_PACKAGESECON实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetTJ_PACKAGESECON GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetTJ_PACKAGESECON dataSet = (DataSetTJ_PACKAGESECON)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetTJ_PACKAGESECON entity = new DataSetTJ_PACKAGESECON();
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
        
        protected DataSetTJ_PACKAGESECON(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["TJ_TJ_PACKAGESECON"] != null)) 
                {
                    this.Tables.Add(new DataTableTJ_TJ_PACKAGESECON(ds.Tables["TJ_TJ_PACKAGESECON"]));
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
		/// 对于数据表TJ_TJ_PACKAGESECON的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableTJ_TJ_PACKAGESECON TJ_TJ_PACKAGESECON 
		{
			get
			{
				return this.tableTJ_TJ_PACKAGESECON;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetTJ_PACKAGESECON cln = ((DataSetTJ_PACKAGESECON)(base.Clone()));
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
			
			if ((ds.Tables["TJ_TJ_PACKAGESECON"] != null)) 
			{
				this.Tables.Add(new DataTableTJ_TJ_PACKAGESECON(ds.Tables["TJ_TJ_PACKAGESECON"]));
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
			
			this.tableTJ_TJ_PACKAGESECON = ((DataTableTJ_TJ_PACKAGESECON)(this.Tables["TJ_TJ_PACKAGESECON"]));
			if ((this.tableTJ_TJ_PACKAGESECON != null)) {
				this.tableTJ_TJ_PACKAGESECON.InitVars();
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
			
			this.tableTJ_TJ_PACKAGESECON = new DataTableTJ_TJ_PACKAGESECON();
			this.Tables.Add(this.tableTJ_TJ_PACKAGESECON);
			
		}
		
		private bool ShouldSerializeTJ_TJ_PACKAGESECON() 
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
	
    public delegate void RowChangeEventHandlerTJ_TJ_PACKAGESECON(object sender, RowChangeEventTJ_TJ_PACKAGESECON e);
	
	#region DataTableTJ_TJ_PACKAGESECON
	/// 
	/// 对于数据表TJ_TJ_PACKAGESECON的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableTJ_TJ_PACKAGESECON : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnCREATEDEPARTID;
		
        private DataColumn columnCREATEDEPARTNAME;
		
        private DataColumn columnNSECID;
		
        private DataColumn columnNPACKAGEID;
		
        private DataColumn columnNITEMID;
		
        private DataColumn columnVITEMNAME;
		
        private DataColumn columnNVPRICE;
		
        private DataColumn columnNISDISCOUNTS;
		
        private DataColumn columnNDISCOUNTS;
		
        private DataColumn columnNMONEY;
		
        private DataColumn columnCREATEDATE;
		
        private DataColumn columnCREATESTAFFCODE;
		
        private DataColumn columnCREATESTAFFNAME;
		
        internal DataTableTJ_TJ_PACKAGESECON() : base("TJ_TJ_PACKAGESECON") 
        {
            this.InitClass();
        }
        
        internal DataTableTJ_TJ_PACKAGESECON(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnCREATEDEPARTID 
        {
            get 
            {
                return this.columnCREATEDEPARTID;
            }
        }
		
        public DataColumn ColumnCREATEDEPARTNAME 
        {
            get 
            {
                return this.columnCREATEDEPARTNAME;
            }
        }
		
        public DataColumn ColumnNSECID 
        {
            get 
            {
                return this.columnNSECID;
            }
        }
		
        public DataColumn ColumnNPACKAGEID 
        {
            get 
            {
                return this.columnNPACKAGEID;
            }
        }
		
        public DataColumn ColumnNITEMID 
        {
            get 
            {
                return this.columnNITEMID;
            }
        }
		
        public DataColumn ColumnVITEMNAME 
        {
            get 
            {
                return this.columnVITEMNAME;
            }
        }
		
        public DataColumn ColumnNVPRICE 
        {
            get 
            {
                return this.columnNVPRICE;
            }
        }
		
        public DataColumn ColumnNISDISCOUNTS 
        {
            get 
            {
                return this.columnNISDISCOUNTS;
            }
        }
		
        public DataColumn ColumnNDISCOUNTS 
        {
            get 
            {
                return this.columnNDISCOUNTS;
            }
        }
		
        public DataColumn ColumnNMONEY 
        {
            get 
            {
                return this.columnNMONEY;
            }
        }
		
        public DataColumn ColumnCREATEDATE 
        {
            get 
            {
                return this.columnCREATEDATE;
            }
        }
		
        public DataColumn ColumnCREATESTAFFCODE 
        {
            get 
            {
                return this.columnCREATESTAFFCODE;
            }
        }
		
        public DataColumn ColumnCREATESTAFFNAME 
        {
            get 
            {
                return this.columnCREATESTAFFNAME;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowTJ_TJ_PACKAGESECON this[int index] 
        {
            get 
            {
                return ((RowTJ_TJ_PACKAGESECON)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerTJ_TJ_PACKAGESECON RowChangedTJ_TJ_PACKAGESECON;
        
        public event RowChangeEventHandlerTJ_TJ_PACKAGESECON RowChangingTJ_TJ_PACKAGESECON;
        
        public event RowChangeEventHandlerTJ_TJ_PACKAGESECON RowDeletedTJ_TJ_PACKAGESECON;
        
        public event RowChangeEventHandlerTJ_TJ_PACKAGESECON RowDeletingTJ_TJ_PACKAGESECON;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowTJ_TJ_PACKAGESECON(RowTJ_TJ_PACKAGESECON row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowTJ_TJ_PACKAGESECON AddRowTJ_TJ_PACKAGESECON(System.String CREATEDEPARTID,System.String CREATEDEPARTNAME,System.String NSECID,System.String NPACKAGEID,System.String NITEMID,System.String VITEMNAME,System.Decimal NVPRICE,System.Int16 NISDISCOUNTS,System.Decimal NDISCOUNTS,System.Decimal NMONEY,System.DateTime CREATEDATE,System.String CREATESTAFFCODE,System.String CREATESTAFFNAME) 
        {
            RowTJ_TJ_PACKAGESECON row = ((RowTJ_TJ_PACKAGESECON)(this.NewRow()));
            row.ItemArray = new object[] {CREATEDEPARTID,CREATEDEPARTNAME,NSECID,NPACKAGEID,NITEMID,VITEMNAME,NVPRICE,NISDISCOUNTS,NDISCOUNTS,NMONEY,CREATEDATE,CREATESTAFFCODE,CREATESTAFFNAME};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowTJ_TJ_PACKAGESECON FindByNSECID(System.String NSECID) {
            return ((RowTJ_TJ_PACKAGESECON)(this.Rows.Find(new object[] {
                        NSECID})));
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
            DataTableTJ_TJ_PACKAGESECON cln = ((DataTableTJ_TJ_PACKAGESECON)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableTJ_TJ_PACKAGESECON();
        }
        
        internal void InitVars() 
        {	
            this.columnCREATEDEPARTID = this.Columns["CREATEDEPARTID"];
            this.columnCREATEDEPARTNAME = this.Columns["CREATEDEPARTNAME"];
            this.columnNSECID = this.Columns["NSECID"];
            this.columnNPACKAGEID = this.Columns["NPACKAGEID"];
            this.columnNITEMID = this.Columns["NITEMID"];
            this.columnVITEMNAME = this.Columns["VITEMNAME"];
            this.columnNVPRICE = this.Columns["NVPRICE"];
            this.columnNISDISCOUNTS = this.Columns["NISDISCOUNTS"];
            this.columnNDISCOUNTS = this.Columns["NDISCOUNTS"];
            this.columnNMONEY = this.Columns["NMONEY"];
            this.columnCREATEDATE = this.Columns["CREATEDATE"];
            this.columnCREATESTAFFCODE = this.Columns["CREATESTAFFCODE"];
            this.columnCREATESTAFFNAME = this.Columns["CREATESTAFFNAME"];
        }
        
        private void InitClass() 
        {	
            this.columnCREATEDEPARTID = new DataColumn("CREATEDEPARTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnCREATEDEPARTID.MaxLength = 20;
            this.columnCREATEDEPARTID.AllowDBNull = true;
            this.Columns.Add(this.columnCREATEDEPARTID);
			
            this.columnCREATEDEPARTNAME = new DataColumn("CREATEDEPARTNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnCREATEDEPARTNAME.MaxLength = 40;
            this.columnCREATEDEPARTNAME.AllowDBNull = true;
            this.Columns.Add(this.columnCREATEDEPARTNAME);
			
            this.columnNSECID = new DataColumn("NSECID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNSECID.MaxLength = 36;
            this.columnNSECID.AllowDBNull = false;
            this.columnNSECID.Unique = true;
            
            this.Columns.Add(this.columnNSECID);
			
            this.columnNPACKAGEID = new DataColumn("NPACKAGEID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNPACKAGEID.MaxLength = 36;
            this.columnNPACKAGEID.AllowDBNull = false;
            this.Columns.Add(this.columnNPACKAGEID);
			
            this.columnNITEMID = new DataColumn("NITEMID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNITEMID.MaxLength = 36;
            this.columnNITEMID.AllowDBNull = false;
            this.Columns.Add(this.columnNITEMID);
			
            this.columnVITEMNAME = new DataColumn("VITEMNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEMNAME.MaxLength = 60;
            this.columnVITEMNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVITEMNAME);
			
            this.columnNVPRICE = new DataColumn("NVPRICE", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNVPRICE.AllowDBNull = false;
            this.Columns.Add(this.columnNVPRICE);
			
            this.columnNISDISCOUNTS = new DataColumn("NISDISCOUNTS", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNISDISCOUNTS.AllowDBNull = false;
            this.Columns.Add(this.columnNISDISCOUNTS);
			
            this.columnNDISCOUNTS = new DataColumn("NDISCOUNTS", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNDISCOUNTS.AllowDBNull = false;
            this.Columns.Add(this.columnNDISCOUNTS);
			
            this.columnNMONEY = new DataColumn("NMONEY", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNMONEY.AllowDBNull = false;
            this.Columns.Add(this.columnNMONEY);
			
            this.columnCREATEDATE = new DataColumn("CREATEDATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnCREATEDATE.AllowDBNull = true;
            this.Columns.Add(this.columnCREATEDATE);
			
            this.columnCREATESTAFFCODE = new DataColumn("CREATESTAFFCODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnCREATESTAFFCODE.MaxLength = 20;
            this.columnCREATESTAFFCODE.AllowDBNull = true;
            this.Columns.Add(this.columnCREATESTAFFCODE);
			
            this.columnCREATESTAFFNAME = new DataColumn("CREATESTAFFNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnCREATESTAFFNAME.MaxLength = 60;
            this.columnCREATESTAFFNAME.AllowDBNull = true;
            this.Columns.Add(this.columnCREATESTAFFNAME);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowTJ_TJ_PACKAGESECON NewRowTJ_TJ_PACKAGESECON() {
            return ((RowTJ_TJ_PACKAGESECON)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowTJ_TJ_PACKAGESECON(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowTJ_TJ_PACKAGESECON);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedTJ_TJ_PACKAGESECON != null)) {
                this.RowChangedTJ_TJ_PACKAGESECON(this, new RowChangeEventTJ_TJ_PACKAGESECON(((RowTJ_TJ_PACKAGESECON)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingTJ_TJ_PACKAGESECON != null)) {
                this.RowChangingTJ_TJ_PACKAGESECON(this, new RowChangeEventTJ_TJ_PACKAGESECON(((RowTJ_TJ_PACKAGESECON)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedTJ_TJ_PACKAGESECON != null)) {
                this.RowDeletedTJ_TJ_PACKAGESECON(this, new RowChangeEventTJ_TJ_PACKAGESECON(((RowTJ_TJ_PACKAGESECON)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingTJ_TJ_PACKAGESECON != null)) {
                this.RowDeletingTJ_TJ_PACKAGESECON(this, new RowChangeEventTJ_TJ_PACKAGESECON(((RowTJ_TJ_PACKAGESECON)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowTJ_TJ_PACKAGESECON(RowTJ_TJ_PACKAGESECON row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowTJ_TJ_PACKAGESECON
	/// 
	/// 数据表TJ_TJ_PACKAGESECON行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowTJ_TJ_PACKAGESECON : DataRow 
    {
        
        private DataTableTJ_TJ_PACKAGESECON tableTJ_TJ_PACKAGESECON;
        
        internal RowTJ_TJ_PACKAGESECON(DataRowBuilder rb) : base(rb) 
        {
            this.tableTJ_TJ_PACKAGESECON = ((DataTableTJ_TJ_PACKAGESECON)(this.Table));
        }        
		
		/// 
		/// 字段CREATEDEPARTID所映射的属性。
		/// 
        public System.String CREATEDEPARTID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_PACKAGESECON.ColumnCREATEDEPARTID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGESECON.ColumnCREATEDEPARTID] = value;
            }
        }
        
		/// 
		/// 字段CREATEDEPARTNAME所映射的属性。
		/// 
        public System.String CREATEDEPARTNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_PACKAGESECON.ColumnCREATEDEPARTNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGESECON.ColumnCREATEDEPARTNAME] = value;
            }
        }
        
		/// 
		/// 字段NSECID所映射的属性。
		/// 
        public System.String NSECID
        {
            get 
            {	
                return ((System.String)(this[this.tableTJ_TJ_PACKAGESECON.ColumnNSECID])); 
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGESECON.ColumnNSECID] = value;
            }
        }
        
		/// 
		/// 字段NPACKAGEID所映射的属性。
		/// 
        public System.String NPACKAGEID
        {
            get 
            {	
                return ((System.String)(this[this.tableTJ_TJ_PACKAGESECON.ColumnNPACKAGEID])); 
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGESECON.ColumnNPACKAGEID] = value;
            }
        }
        
		/// 
		/// 字段NITEMID所映射的属性。
		/// 
        public System.String NITEMID
        {
            get 
            {	
                return ((System.String)(this[this.tableTJ_TJ_PACKAGESECON.ColumnNITEMID])); 
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGESECON.ColumnNITEMID] = value;
            }
        }
        
		/// 
		/// 字段VITEMNAME所映射的属性。
		/// 
        public System.String VITEMNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_PACKAGESECON.ColumnVITEMNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGESECON.ColumnVITEMNAME] = value;
            }
        }
        
		/// 
		/// 字段NVPRICE所映射的属性。
		/// 
        public System.Decimal NVPRICE
        {
            get 
            {	
                return ((System.Decimal)(this[this.tableTJ_TJ_PACKAGESECON.ColumnNVPRICE])); 
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGESECON.ColumnNVPRICE] = value;
            }
        }
        
		/// 
		/// 字段NISDISCOUNTS所映射的属性。
		/// 
        public System.Int16 NISDISCOUNTS
        {
            get 
            {	
                return ((System.Int16)(this[this.tableTJ_TJ_PACKAGESECON.ColumnNISDISCOUNTS])); 
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGESECON.ColumnNISDISCOUNTS] = value;
            }
        }
        
		/// 
		/// 字段NDISCOUNTS所映射的属性。
		/// 
        public System.Decimal NDISCOUNTS
        {
            get 
            {	
                return ((System.Decimal)(this[this.tableTJ_TJ_PACKAGESECON.ColumnNDISCOUNTS])); 
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGESECON.ColumnNDISCOUNTS] = value;
            }
        }
        
		/// 
		/// 字段NMONEY所映射的属性。
		/// 
        public System.Decimal NMONEY
        {
            get 
            {	
                return ((System.Decimal)(this[this.tableTJ_TJ_PACKAGESECON.ColumnNMONEY])); 
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGESECON.ColumnNMONEY] = value;
            }
        }
        
		/// 
		/// 字段CREATEDATE所映射的属性。
		/// 
        public System.DateTime CREATEDATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableTJ_TJ_PACKAGESECON.ColumnCREATEDATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGESECON.ColumnCREATEDATE] = value;
            }
        }
        
		/// 
		/// 字段CREATESTAFFCODE所映射的属性。
		/// 
        public System.String CREATESTAFFCODE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_PACKAGESECON.ColumnCREATESTAFFCODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGESECON.ColumnCREATESTAFFCODE] = value;
            }
        }
        
		/// 
		/// 字段CREATESTAFFNAME所映射的属性。
		/// 
        public System.String CREATESTAFFNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_PACKAGESECON.ColumnCREATESTAFFNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGESECON.ColumnCREATESTAFFNAME] = value;
            }
        }
        
		/// 
		/// 判断字段CREATEDEPARTID是否为空。
		/// 
        public bool IsCREATEDEPARTIDNull()
        {
            return this.IsNull(this.tableTJ_TJ_PACKAGESECON.ColumnCREATEDEPARTID);
        }

		/// 
		/// 设置字段CREATEDEPARTID为空值。
		/// 
        public void SetCREATEDEPARTIDNull() 
        {
            this[this.tableTJ_TJ_PACKAGESECON.ColumnCREATEDEPARTID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段CREATEDEPARTNAME是否为空。
		/// 
        public bool IsCREATEDEPARTNAMENull()
        {
            return this.IsNull(this.tableTJ_TJ_PACKAGESECON.ColumnCREATEDEPARTNAME);
        }

		/// 
		/// 设置字段CREATEDEPARTNAME为空值。
		/// 
        public void SetCREATEDEPARTNAMENull() 
        {
            this[this.tableTJ_TJ_PACKAGESECON.ColumnCREATEDEPARTNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEMNAME是否为空。
		/// 
        public bool IsVITEMNAMENull()
        {
            return this.IsNull(this.tableTJ_TJ_PACKAGESECON.ColumnVITEMNAME);
        }

		/// 
		/// 设置字段VITEMNAME为空值。
		/// 
        public void SetVITEMNAMENull() 
        {
            this[this.tableTJ_TJ_PACKAGESECON.ColumnVITEMNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段CREATEDATE是否为空。
		/// 
        public bool IsCREATEDATENull()
        {
            return this.IsNull(this.tableTJ_TJ_PACKAGESECON.ColumnCREATEDATE);
        }

		/// 
		/// 设置字段CREATEDATE为空值。
		/// 
        public void SetCREATEDATENull() 
        {
            this[this.tableTJ_TJ_PACKAGESECON.ColumnCREATEDATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段CREATESTAFFCODE是否为空。
		/// 
        public bool IsCREATESTAFFCODENull()
        {
            return this.IsNull(this.tableTJ_TJ_PACKAGESECON.ColumnCREATESTAFFCODE);
        }

		/// 
		/// 设置字段CREATESTAFFCODE为空值。
		/// 
        public void SetCREATESTAFFCODENull() 
        {
            this[this.tableTJ_TJ_PACKAGESECON.ColumnCREATESTAFFCODE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段CREATESTAFFNAME是否为空。
		/// 
        public bool IsCREATESTAFFNAMENull()
        {
            return this.IsNull(this.tableTJ_TJ_PACKAGESECON.ColumnCREATESTAFFNAME);
        }

		/// 
		/// 设置字段CREATESTAFFNAME为空值。
		/// 
        public void SetCREATESTAFFNAMENull() 
        {
            this[this.tableTJ_TJ_PACKAGESECON.ColumnCREATESTAFFNAME] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventTJ_TJ_PACKAGESECON : EventArgs {
        
        private RowTJ_TJ_PACKAGESECON eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventTJ_TJ_PACKAGESECON(RowTJ_TJ_PACKAGESECON row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowTJ_TJ_PACKAGESECON Row {
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
	