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
	#region DataSetTJ_PACKAGE
	/// 
	/// 对于TJ_PACKAGE的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetTJ_PACKAGE : DataSet
    {
		
		private DataTableTJ_TJ_PACKAGE tableTJ_TJ_PACKAGE;
		
        public DataSetTJ_PACKAGE() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetTJ_PACKAGE实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetTJ_PACKAGE GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetTJ_PACKAGE dataSet = (DataSetTJ_PACKAGE)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetTJ_PACKAGE entity = new DataSetTJ_PACKAGE();
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
        
        protected DataSetTJ_PACKAGE(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["TJ_TJ_PACKAGE"] != null)) 
                {
                    this.Tables.Add(new DataTableTJ_TJ_PACKAGE(ds.Tables["TJ_TJ_PACKAGE"]));
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
		/// 对于数据表TJ_TJ_PACKAGE的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableTJ_TJ_PACKAGE TJ_TJ_PACKAGE 
		{
			get
			{
				return this.tableTJ_TJ_PACKAGE;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetTJ_PACKAGE cln = ((DataSetTJ_PACKAGE)(base.Clone()));
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
			
			if ((ds.Tables["TJ_TJ_PACKAGE"] != null)) 
			{
				this.Tables.Add(new DataTableTJ_TJ_PACKAGE(ds.Tables["TJ_TJ_PACKAGE"]));
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
			
			this.tableTJ_TJ_PACKAGE = ((DataTableTJ_TJ_PACKAGE)(this.Tables["TJ_TJ_PACKAGE"]));
			if ((this.tableTJ_TJ_PACKAGE != null)) {
				this.tableTJ_TJ_PACKAGE.InitVars();
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
			
			this.tableTJ_TJ_PACKAGE = new DataTableTJ_TJ_PACKAGE();
			this.Tables.Add(this.tableTJ_TJ_PACKAGE);
			
		}
		
		private bool ShouldSerializeTJ_TJ_PACKAGE() 
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
	
    public delegate void RowChangeEventHandlerTJ_TJ_PACKAGE(object sender, RowChangeEventTJ_TJ_PACKAGE e);
	
	#region DataTableTJ_TJ_PACKAGE
	/// 
	/// 对于数据表TJ_TJ_PACKAGE的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableTJ_TJ_PACKAGE : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnNPACKAGEID;
		
        private DataColumn columnVPEGROUPNAME;
		
        private DataColumn columnWUBIMA;
		
        private DataColumn columnPINYINMA;
		
        private DataColumn columnNVPRICE;
		
        private DataColumn columnNISDISCOUNTS;
		
        private DataColumn columnNDISCOUNTS;
		
        private DataColumn columnNMONEY;
		
        private DataColumn columnNENABLE;
		
        private DataColumn columnVDESCRIPTION;
		
        private DataColumn columnNHOSID;
		
        private DataColumn columnNPACKAGETYPE;
		
        private DataColumn columnCREATE_DATE;
		
        private DataColumn columnCREATE_DEPT;
		
        private DataColumn columnCREATE_DOCT;
		
        private DataColumn columnLAST_DATE;
		
        private DataColumn columnLAST_DOCT;
		
        private DataColumn columnNORGAID;
		
        internal DataTableTJ_TJ_PACKAGE() : base("TJ_TJ_PACKAGE") 
        {
            this.InitClass();
        }
        
        internal DataTableTJ_TJ_PACKAGE(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnNPACKAGEID 
        {
            get 
            {
                return this.columnNPACKAGEID;
            }
        }
		
        public DataColumn ColumnVPEGROUPNAME 
        {
            get 
            {
                return this.columnVPEGROUPNAME;
            }
        }
		
        public DataColumn ColumnWUBIMA 
        {
            get 
            {
                return this.columnWUBIMA;
            }
        }
		
        public DataColumn ColumnPINYINMA 
        {
            get 
            {
                return this.columnPINYINMA;
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
		
        public DataColumn ColumnNENABLE 
        {
            get 
            {
                return this.columnNENABLE;
            }
        }
		
        public DataColumn ColumnVDESCRIPTION 
        {
            get 
            {
                return this.columnVDESCRIPTION;
            }
        }
		
        public DataColumn ColumnNHOSID 
        {
            get 
            {
                return this.columnNHOSID;
            }
        }
		
        public DataColumn ColumnNPACKAGETYPE 
        {
            get 
            {
                return this.columnNPACKAGETYPE;
            }
        }
		
        public DataColumn ColumnCREATE_DATE 
        {
            get 
            {
                return this.columnCREATE_DATE;
            }
        }
		
        public DataColumn ColumnCREATE_DEPT 
        {
            get 
            {
                return this.columnCREATE_DEPT;
            }
        }
		
        public DataColumn ColumnCREATE_DOCT 
        {
            get 
            {
                return this.columnCREATE_DOCT;
            }
        }
		
        public DataColumn ColumnLAST_DATE 
        {
            get 
            {
                return this.columnLAST_DATE;
            }
        }
		
        public DataColumn ColumnLAST_DOCT 
        {
            get 
            {
                return this.columnLAST_DOCT;
            }
        }
		
        public DataColumn ColumnNORGAID 
        {
            get 
            {
                return this.columnNORGAID;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowTJ_TJ_PACKAGE this[int index] 
        {
            get 
            {
                return ((RowTJ_TJ_PACKAGE)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerTJ_TJ_PACKAGE RowChangedTJ_TJ_PACKAGE;
        
        public event RowChangeEventHandlerTJ_TJ_PACKAGE RowChangingTJ_TJ_PACKAGE;
        
        public event RowChangeEventHandlerTJ_TJ_PACKAGE RowDeletedTJ_TJ_PACKAGE;
        
        public event RowChangeEventHandlerTJ_TJ_PACKAGE RowDeletingTJ_TJ_PACKAGE;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowTJ_TJ_PACKAGE(RowTJ_TJ_PACKAGE row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowTJ_TJ_PACKAGE AddRowTJ_TJ_PACKAGE(System.String NPACKAGEID,System.String VPEGROUPNAME,System.String WUBIMA,System.String PINYINMA,System.Decimal NVPRICE,System.Int16 NISDISCOUNTS,System.Decimal NDISCOUNTS,System.Decimal NMONEY,System.Int16 NENABLE,System.String VDESCRIPTION,System.Int32 NHOSID,System.Int16 NPACKAGETYPE,System.DateTime CREATE_DATE,System.String CREATE_DEPT,System.String CREATE_DOCT,System.DateTime LAST_DATE,System.String LAST_DOCT,System.String NORGAID) 
        {
            RowTJ_TJ_PACKAGE row = ((RowTJ_TJ_PACKAGE)(this.NewRow()));
            row.ItemArray = new object[] {NPACKAGEID,VPEGROUPNAME,WUBIMA,PINYINMA,NVPRICE,NISDISCOUNTS,NDISCOUNTS,NMONEY,NENABLE,VDESCRIPTION,NHOSID,NPACKAGETYPE,CREATE_DATE,CREATE_DEPT,CREATE_DOCT,LAST_DATE,LAST_DOCT,NORGAID};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowTJ_TJ_PACKAGE FindByNPACKAGEID(System.String NPACKAGEID) {
            return ((RowTJ_TJ_PACKAGE)(this.Rows.Find(new object[] {
                        NPACKAGEID})));
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
            DataTableTJ_TJ_PACKAGE cln = ((DataTableTJ_TJ_PACKAGE)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableTJ_TJ_PACKAGE();
        }
        
        internal void InitVars() 
        {	
            this.columnNPACKAGEID = this.Columns["NPACKAGEID"];
            this.columnVPEGROUPNAME = this.Columns["VPEGROUPNAME"];
            this.columnWUBIMA = this.Columns["WUBIMA"];
            this.columnPINYINMA = this.Columns["PINYINMA"];
            this.columnNVPRICE = this.Columns["NVPRICE"];
            this.columnNISDISCOUNTS = this.Columns["NISDISCOUNTS"];
            this.columnNDISCOUNTS = this.Columns["NDISCOUNTS"];
            this.columnNMONEY = this.Columns["NMONEY"];
            this.columnNENABLE = this.Columns["NENABLE"];
            this.columnVDESCRIPTION = this.Columns["VDESCRIPTION"];
            this.columnNHOSID = this.Columns["NHOSID"];
            this.columnNPACKAGETYPE = this.Columns["NPACKAGETYPE"];
            this.columnCREATE_DATE = this.Columns["CREATE_DATE"];
            this.columnCREATE_DEPT = this.Columns["CREATE_DEPT"];
            this.columnCREATE_DOCT = this.Columns["CREATE_DOCT"];
            this.columnLAST_DATE = this.Columns["LAST_DATE"];
            this.columnLAST_DOCT = this.Columns["LAST_DOCT"];
            this.columnNORGAID = this.Columns["NORGAID"];
        }
        
        private void InitClass() 
        {	
            this.columnNPACKAGEID = new DataColumn("NPACKAGEID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNPACKAGEID.MaxLength = 36;
            this.columnNPACKAGEID.AllowDBNull = false;
            this.columnNPACKAGEID.Unique = true;
            
            this.Columns.Add(this.columnNPACKAGEID);
			
            this.columnVPEGROUPNAME = new DataColumn("VPEGROUPNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPEGROUPNAME.MaxLength = 40;
            this.columnVPEGROUPNAME.AllowDBNull = false;
            this.Columns.Add(this.columnVPEGROUPNAME);
			
            this.columnWUBIMA = new DataColumn("WUBIMA", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnWUBIMA.MaxLength = 40;
            this.columnWUBIMA.AllowDBNull = true;
            this.Columns.Add(this.columnWUBIMA);
			
            this.columnPINYINMA = new DataColumn("PINYINMA", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnPINYINMA.MaxLength = 40;
            this.columnPINYINMA.AllowDBNull = true;
            this.Columns.Add(this.columnPINYINMA);
			
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
			
            this.columnNENABLE = new DataColumn("NENABLE", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNENABLE.AllowDBNull = false;
            this.Columns.Add(this.columnNENABLE);
			
            this.columnVDESCRIPTION = new DataColumn("VDESCRIPTION", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDESCRIPTION.MaxLength = 255;
            this.columnVDESCRIPTION.AllowDBNull = true;
            this.Columns.Add(this.columnVDESCRIPTION);
			
            this.columnNHOSID = new DataColumn("NHOSID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNHOSID.AllowDBNull = true;
            this.Columns.Add(this.columnNHOSID);
			
            this.columnNPACKAGETYPE = new DataColumn("NPACKAGETYPE", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNPACKAGETYPE.AllowDBNull = true;
            this.Columns.Add(this.columnNPACKAGETYPE);
			
            this.columnCREATE_DATE = new DataColumn("CREATE_DATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnCREATE_DATE.AllowDBNull = true;
            this.Columns.Add(this.columnCREATE_DATE);
			
            this.columnCREATE_DEPT = new DataColumn("CREATE_DEPT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnCREATE_DEPT.MaxLength = 20;
            this.columnCREATE_DEPT.AllowDBNull = true;
            this.Columns.Add(this.columnCREATE_DEPT);
			
            this.columnCREATE_DOCT = new DataColumn("CREATE_DOCT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnCREATE_DOCT.MaxLength = 20;
            this.columnCREATE_DOCT.AllowDBNull = true;
            this.Columns.Add(this.columnCREATE_DOCT);
			
            this.columnLAST_DATE = new DataColumn("LAST_DATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnLAST_DATE.AllowDBNull = true;
            this.Columns.Add(this.columnLAST_DATE);
			
            this.columnLAST_DOCT = new DataColumn("LAST_DOCT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnLAST_DOCT.MaxLength = 20;
            this.columnLAST_DOCT.AllowDBNull = true;
            this.Columns.Add(this.columnLAST_DOCT);
			
            this.columnNORGAID = new DataColumn("NORGAID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNORGAID.MaxLength = 36;
            this.columnNORGAID.AllowDBNull = true;
            this.Columns.Add(this.columnNORGAID);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowTJ_TJ_PACKAGE NewRowTJ_TJ_PACKAGE() {
            return ((RowTJ_TJ_PACKAGE)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowTJ_TJ_PACKAGE(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowTJ_TJ_PACKAGE);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedTJ_TJ_PACKAGE != null)) {
                this.RowChangedTJ_TJ_PACKAGE(this, new RowChangeEventTJ_TJ_PACKAGE(((RowTJ_TJ_PACKAGE)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingTJ_TJ_PACKAGE != null)) {
                this.RowChangingTJ_TJ_PACKAGE(this, new RowChangeEventTJ_TJ_PACKAGE(((RowTJ_TJ_PACKAGE)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedTJ_TJ_PACKAGE != null)) {
                this.RowDeletedTJ_TJ_PACKAGE(this, new RowChangeEventTJ_TJ_PACKAGE(((RowTJ_TJ_PACKAGE)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingTJ_TJ_PACKAGE != null)) {
                this.RowDeletingTJ_TJ_PACKAGE(this, new RowChangeEventTJ_TJ_PACKAGE(((RowTJ_TJ_PACKAGE)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowTJ_TJ_PACKAGE(RowTJ_TJ_PACKAGE row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowTJ_TJ_PACKAGE
	/// 
	/// 数据表TJ_TJ_PACKAGE行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowTJ_TJ_PACKAGE : DataRow 
    {
        
        private DataTableTJ_TJ_PACKAGE tableTJ_TJ_PACKAGE;
        
        internal RowTJ_TJ_PACKAGE(DataRowBuilder rb) : base(rb) 
        {
            this.tableTJ_TJ_PACKAGE = ((DataTableTJ_TJ_PACKAGE)(this.Table));
        }        
		
		/// 
		/// 字段NPACKAGEID所映射的属性。
		/// 
        public System.String NPACKAGEID
        {
            get 
            {	
                return ((System.String)(this[this.tableTJ_TJ_PACKAGE.ColumnNPACKAGEID])); 
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGE.ColumnNPACKAGEID] = value;
            }
        }
        
		/// 
		/// 字段VPEGROUPNAME所映射的属性。
		/// 
        public System.String VPEGROUPNAME
        {
            get 
            {	
                return ((System.String)(this[this.tableTJ_TJ_PACKAGE.ColumnVPEGROUPNAME])); 
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGE.ColumnVPEGROUPNAME] = value;
            }
        }
        
		/// 
		/// 字段WUBIMA所映射的属性。
		/// 
        public System.String WUBIMA
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_PACKAGE.ColumnWUBIMA])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGE.ColumnWUBIMA] = value;
            }
        }
        
		/// 
		/// 字段PINYINMA所映射的属性。
		/// 
        public System.String PINYINMA
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_PACKAGE.ColumnPINYINMA])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGE.ColumnPINYINMA] = value;
            }
        }
        
		/// 
		/// 字段NVPRICE所映射的属性。
		/// 
        public System.Decimal NVPRICE
        {
            get 
            {	
                return ((System.Decimal)(this[this.tableTJ_TJ_PACKAGE.ColumnNVPRICE])); 
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGE.ColumnNVPRICE] = value;
            }
        }
        
		/// 
		/// 字段NISDISCOUNTS所映射的属性。
		/// 
        public System.Int16 NISDISCOUNTS
        {
            get 
            {	
                return ((System.Int16)(this[this.tableTJ_TJ_PACKAGE.ColumnNISDISCOUNTS])); 
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGE.ColumnNISDISCOUNTS] = value;
            }
        }
        
		/// 
		/// 字段NDISCOUNTS所映射的属性。
		/// 
        public System.Decimal NDISCOUNTS
        {
            get 
            {	
                return ((System.Decimal)(this[this.tableTJ_TJ_PACKAGE.ColumnNDISCOUNTS])); 
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGE.ColumnNDISCOUNTS] = value;
            }
        }
        
		/// 
		/// 字段NMONEY所映射的属性。
		/// 
        public System.Decimal NMONEY
        {
            get 
            {	
                return ((System.Decimal)(this[this.tableTJ_TJ_PACKAGE.ColumnNMONEY])); 
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGE.ColumnNMONEY] = value;
            }
        }
        
		/// 
		/// 字段NENABLE所映射的属性。
		/// 
        public System.Int16 NENABLE
        {
            get 
            {	
                return ((System.Int16)(this[this.tableTJ_TJ_PACKAGE.ColumnNENABLE])); 
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGE.ColumnNENABLE] = value;
            }
        }
        
		/// 
		/// 字段VDESCRIPTION所映射的属性。
		/// 
        public System.String VDESCRIPTION
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_PACKAGE.ColumnVDESCRIPTION])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGE.ColumnVDESCRIPTION] = value;
            }
        }
        
		/// 
		/// 字段NHOSID所映射的属性。
		/// 
        public System.Int32 NHOSID
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableTJ_TJ_PACKAGE.ColumnNHOSID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGE.ColumnNHOSID] = value;
            }
        }
        
		/// 
		/// 字段NPACKAGETYPE所映射的属性。
		/// 
        public System.Int16 NPACKAGETYPE
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableTJ_TJ_PACKAGE.ColumnNPACKAGETYPE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGE.ColumnNPACKAGETYPE] = value;
            }
        }
        
		/// 
		/// 字段CREATE_DATE所映射的属性。
		/// 
        public System.DateTime CREATE_DATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableTJ_TJ_PACKAGE.ColumnCREATE_DATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGE.ColumnCREATE_DATE] = value;
            }
        }
        
		/// 
		/// 字段CREATE_DEPT所映射的属性。
		/// 
        public System.String CREATE_DEPT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_PACKAGE.ColumnCREATE_DEPT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGE.ColumnCREATE_DEPT] = value;
            }
        }
        
		/// 
		/// 字段CREATE_DOCT所映射的属性。
		/// 
        public System.String CREATE_DOCT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_PACKAGE.ColumnCREATE_DOCT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGE.ColumnCREATE_DOCT] = value;
            }
        }
        
		/// 
		/// 字段LAST_DATE所映射的属性。
		/// 
        public System.DateTime LAST_DATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableTJ_TJ_PACKAGE.ColumnLAST_DATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGE.ColumnLAST_DATE] = value;
            }
        }
        
		/// 
		/// 字段LAST_DOCT所映射的属性。
		/// 
        public System.String LAST_DOCT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_PACKAGE.ColumnLAST_DOCT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGE.ColumnLAST_DOCT] = value;
            }
        }
        
		/// 
		/// 字段NORGAID所映射的属性。
		/// 
        public System.String NORGAID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTJ_TJ_PACKAGE.ColumnNORGAID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTJ_TJ_PACKAGE.ColumnNORGAID] = value;
            }
        }
        
		/// 
		/// 判断字段WUBIMA是否为空。
		/// 
        public bool IsWUBIMANull()
        {
            return this.IsNull(this.tableTJ_TJ_PACKAGE.ColumnWUBIMA);
        }

		/// 
		/// 设置字段WUBIMA为空值。
		/// 
        public void SetWUBIMANull() 
        {
            this[this.tableTJ_TJ_PACKAGE.ColumnWUBIMA] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段PINYINMA是否为空。
		/// 
        public bool IsPINYINMANull()
        {
            return this.IsNull(this.tableTJ_TJ_PACKAGE.ColumnPINYINMA);
        }

		/// 
		/// 设置字段PINYINMA为空值。
		/// 
        public void SetPINYINMANull() 
        {
            this[this.tableTJ_TJ_PACKAGE.ColumnPINYINMA] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDESCRIPTION是否为空。
		/// 
        public bool IsVDESCRIPTIONNull()
        {
            return this.IsNull(this.tableTJ_TJ_PACKAGE.ColumnVDESCRIPTION);
        }

		/// 
		/// 设置字段VDESCRIPTION为空值。
		/// 
        public void SetVDESCRIPTIONNull() 
        {
            this[this.tableTJ_TJ_PACKAGE.ColumnVDESCRIPTION] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NHOSID是否为空。
		/// 
        public bool IsNHOSIDNull()
        {
            return this.IsNull(this.tableTJ_TJ_PACKAGE.ColumnNHOSID);
        }

		/// 
		/// 设置字段NHOSID为空值。
		/// 
        public void SetNHOSIDNull() 
        {
            this[this.tableTJ_TJ_PACKAGE.ColumnNHOSID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NPACKAGETYPE是否为空。
		/// 
        public bool IsNPACKAGETYPENull()
        {
            return this.IsNull(this.tableTJ_TJ_PACKAGE.ColumnNPACKAGETYPE);
        }

		/// 
		/// 设置字段NPACKAGETYPE为空值。
		/// 
        public void SetNPACKAGETYPENull() 
        {
            this[this.tableTJ_TJ_PACKAGE.ColumnNPACKAGETYPE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段CREATE_DATE是否为空。
		/// 
        public bool IsCREATE_DATENull()
        {
            return this.IsNull(this.tableTJ_TJ_PACKAGE.ColumnCREATE_DATE);
        }

		/// 
		/// 设置字段CREATE_DATE为空值。
		/// 
        public void SetCREATE_DATENull() 
        {
            this[this.tableTJ_TJ_PACKAGE.ColumnCREATE_DATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段CREATE_DEPT是否为空。
		/// 
        public bool IsCREATE_DEPTNull()
        {
            return this.IsNull(this.tableTJ_TJ_PACKAGE.ColumnCREATE_DEPT);
        }

		/// 
		/// 设置字段CREATE_DEPT为空值。
		/// 
        public void SetCREATE_DEPTNull() 
        {
            this[this.tableTJ_TJ_PACKAGE.ColumnCREATE_DEPT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段CREATE_DOCT是否为空。
		/// 
        public bool IsCREATE_DOCTNull()
        {
            return this.IsNull(this.tableTJ_TJ_PACKAGE.ColumnCREATE_DOCT);
        }

		/// 
		/// 设置字段CREATE_DOCT为空值。
		/// 
        public void SetCREATE_DOCTNull() 
        {
            this[this.tableTJ_TJ_PACKAGE.ColumnCREATE_DOCT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段LAST_DATE是否为空。
		/// 
        public bool IsLAST_DATENull()
        {
            return this.IsNull(this.tableTJ_TJ_PACKAGE.ColumnLAST_DATE);
        }

		/// 
		/// 设置字段LAST_DATE为空值。
		/// 
        public void SetLAST_DATENull() 
        {
            this[this.tableTJ_TJ_PACKAGE.ColumnLAST_DATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段LAST_DOCT是否为空。
		/// 
        public bool IsLAST_DOCTNull()
        {
            return this.IsNull(this.tableTJ_TJ_PACKAGE.ColumnLAST_DOCT);
        }

		/// 
		/// 设置字段LAST_DOCT为空值。
		/// 
        public void SetLAST_DOCTNull() 
        {
            this[this.tableTJ_TJ_PACKAGE.ColumnLAST_DOCT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NORGAID是否为空。
		/// 
        public bool IsNORGAIDNull()
        {
            return this.IsNull(this.tableTJ_TJ_PACKAGE.ColumnNORGAID);
        }

		/// 
		/// 设置字段NORGAID为空值。
		/// 
        public void SetNORGAIDNull() 
        {
            this[this.tableTJ_TJ_PACKAGE.ColumnNORGAID] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventTJ_TJ_PACKAGE : EventArgs {
        
        private RowTJ_TJ_PACKAGE eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventTJ_TJ_PACKAGE(RowTJ_TJ_PACKAGE row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowTJ_TJ_PACKAGE Row {
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
	