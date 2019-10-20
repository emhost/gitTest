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
	#region DataSetJZHZ
	/// 
	/// 对于JZHZ的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetJZHZ : DataSet
    {
		
		private DataTableJZHZ tableJZHZ;
		
        public DataSetJZHZ() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetJZHZ实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetJZHZ GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetJZHZ dataSet = (DataSetJZHZ)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetJZHZ entity = new DataSetJZHZ();
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
        
        protected DataSetJZHZ(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["JZHZ"] != null)) 
                {
                    this.Tables.Add(new DataTableJZHZ(ds.Tables["JZHZ"]));
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
		/// 对于数据表JZHZ的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableJZHZ JZHZ 
		{
			get
			{
				return this.tableJZHZ;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetJZHZ cln = ((DataSetJZHZ)(base.Clone()));
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
			
			if ((ds.Tables["JZHZ"] != null)) 
			{
				this.Tables.Add(new DataTableJZHZ(ds.Tables["JZHZ"]));
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
			
			this.tableJZHZ = ((DataTableJZHZ)(this.Tables["JZHZ"]));
			if ((this.tableJZHZ != null)) {
				this.tableJZHZ.InitVars();
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
			
			this.tableJZHZ = new DataTableJZHZ();
			this.Tables.Add(this.tableJZHZ);
			
		}
		
		private bool ShouldSerializeJZHZ() 
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
	
    public delegate void RowChangeEventHandlerJZHZ(object sender, RowChangeEventJZHZ e);
	
	#region DataTableJZHZ
	/// 
	/// 对于数据表JZHZ的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableJZHZ : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnID;
		
        private DataColumn columnNPHONE;
		
        private DataColumn columnVNAME;
		
        private DataColumn columnNSEX;
		
        private DataColumn columnVSFZH;
		
        private DataColumn columnVCARD;
		
        private DataColumn columnVPWD;
		
        private DataColumn columnVPYM;
		
        private DataColumn columnDBIRTHDAY;
		
        private DataColumn columnNSTOP;
		
        private DataColumn columnVPATIENTID;
		
        private DataColumn columnDCREATE;
		
        internal DataTableJZHZ() : base("JZHZ") 
        {
            this.InitClass();
        }
        
        internal DataTableJZHZ(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnID 
        {
            get 
            {
                return this.columnID;
            }
        }
		
        public DataColumn ColumnNPHONE 
        {
            get 
            {
                return this.columnNPHONE;
            }
        }
		
        public DataColumn ColumnVNAME 
        {
            get 
            {
                return this.columnVNAME;
            }
        }
		
        public DataColumn ColumnNSEX 
        {
            get 
            {
                return this.columnNSEX;
            }
        }
		
        public DataColumn ColumnVSFZH 
        {
            get 
            {
                return this.columnVSFZH;
            }
        }
		
        public DataColumn ColumnVCARD 
        {
            get 
            {
                return this.columnVCARD;
            }
        }
		
        public DataColumn ColumnVPWD 
        {
            get 
            {
                return this.columnVPWD;
            }
        }
		
        public DataColumn ColumnVPYM 
        {
            get 
            {
                return this.columnVPYM;
            }
        }
		
        public DataColumn ColumnDBIRTHDAY 
        {
            get 
            {
                return this.columnDBIRTHDAY;
            }
        }
		
        public DataColumn ColumnNSTOP 
        {
            get 
            {
                return this.columnNSTOP;
            }
        }
		
        public DataColumn ColumnVPATIENTID 
        {
            get 
            {
                return this.columnVPATIENTID;
            }
        }
		
        public DataColumn ColumnDCREATE 
        {
            get 
            {
                return this.columnDCREATE;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowJZHZ this[int index] 
        {
            get 
            {
                return ((RowJZHZ)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerJZHZ RowChangedJZHZ;
        
        public event RowChangeEventHandlerJZHZ RowChangingJZHZ;
        
        public event RowChangeEventHandlerJZHZ RowDeletedJZHZ;
        
        public event RowChangeEventHandlerJZHZ RowDeletingJZHZ;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowJZHZ(RowJZHZ row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowJZHZ AddRowJZHZ(System.String ID,System.Int64 NPHONE,System.String VNAME,System.String NSEX,System.String VSFZH,System.String VCARD,System.String VPWD,System.String VPYM,System.DateTime DBIRTHDAY,System.Int16 NSTOP,System.String VPATIENTID,System.DateTime DCREATE) 
        {
            RowJZHZ row = ((RowJZHZ)(this.NewRow()));
            row.ItemArray = new object[] {ID,NPHONE,VNAME,NSEX,VSFZH,VCARD,VPWD,VPYM,DBIRTHDAY,NSTOP,VPATIENTID,DCREATE};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowJZHZ FindByID(System.String ID) {
            return ((RowJZHZ)(this.Rows.Find(new object[] {
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
            DataTableJZHZ cln = ((DataTableJZHZ)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableJZHZ();
        }
        
        internal void InitVars() 
        {	
            this.columnID = this.Columns["ID"];
            this.columnNPHONE = this.Columns["NPHONE"];
            this.columnVNAME = this.Columns["VNAME"];
            this.columnNSEX = this.Columns["NSEX"];
            this.columnVSFZH = this.Columns["VSFZH"];
            this.columnVCARD = this.Columns["VCARD"];
            this.columnVPWD = this.Columns["VPWD"];
            this.columnVPYM = this.Columns["VPYM"];
            this.columnDBIRTHDAY = this.Columns["DBIRTHDAY"];
            this.columnNSTOP = this.Columns["NSTOP"];
            this.columnVPATIENTID = this.Columns["VPATIENTID"];
            this.columnDCREATE = this.Columns["DCREATE"];
        }
        
        private void InitClass() 
        {	
            this.columnID = new DataColumn("ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnID.MaxLength = 36;
            this.columnID.AllowDBNull = false;
            this.columnID.Unique = true;
            
            this.Columns.Add(this.columnID);
			
            this.columnNPHONE = new DataColumn("NPHONE", typeof(System.Int64), null, System.Data.MappingType.Element);
            this.columnNPHONE.AllowDBNull = true;
            this.Columns.Add(this.columnNPHONE);
			
            this.columnVNAME = new DataColumn("VNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNAME.MaxLength = 10;
            this.columnVNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVNAME);
			
            this.columnNSEX = new DataColumn("NSEX", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNSEX.MaxLength = 10;
            this.columnNSEX.AllowDBNull = true;
            this.Columns.Add(this.columnNSEX);
			
            this.columnVSFZH = new DataColumn("VSFZH", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVSFZH.MaxLength = 20;
            this.columnVSFZH.AllowDBNull = true;
            this.Columns.Add(this.columnVSFZH);
			
            this.columnVCARD = new DataColumn("VCARD", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCARD.MaxLength = 20;
            this.columnVCARD.AllowDBNull = true;
            this.Columns.Add(this.columnVCARD);
			
            this.columnVPWD = new DataColumn("VPWD", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPWD.MaxLength = 50;
            this.columnVPWD.AllowDBNull = true;
            this.Columns.Add(this.columnVPWD);
			
            this.columnVPYM = new DataColumn("VPYM", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPYM.MaxLength = 10;
            this.columnVPYM.AllowDBNull = true;
            this.Columns.Add(this.columnVPYM);
			
            this.columnDBIRTHDAY = new DataColumn("DBIRTHDAY", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDBIRTHDAY.AllowDBNull = true;
            this.Columns.Add(this.columnDBIRTHDAY);
			
            this.columnNSTOP = new DataColumn("NSTOP", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNSTOP.DefaultValue = "0";
            this.columnNSTOP.AllowDBNull = true;
            this.Columns.Add(this.columnNSTOP);
			
            this.columnVPATIENTID = new DataColumn("VPATIENTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPATIENTID.MaxLength = 30;
            this.columnVPATIENTID.AllowDBNull = true;
            this.Columns.Add(this.columnVPATIENTID);
			
            this.columnDCREATE = new DataColumn("DCREATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDCREATE.AllowDBNull = true;
            this.Columns.Add(this.columnDCREATE);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowJZHZ NewRowJZHZ() {
            return ((RowJZHZ)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowJZHZ(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowJZHZ);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedJZHZ != null)) {
                this.RowChangedJZHZ(this, new RowChangeEventJZHZ(((RowJZHZ)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingJZHZ != null)) {
                this.RowChangingJZHZ(this, new RowChangeEventJZHZ(((RowJZHZ)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedJZHZ != null)) {
                this.RowDeletedJZHZ(this, new RowChangeEventJZHZ(((RowJZHZ)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingJZHZ != null)) {
                this.RowDeletingJZHZ(this, new RowChangeEventJZHZ(((RowJZHZ)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowJZHZ(RowJZHZ row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowJZHZ
	/// 
	/// 数据表JZHZ行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowJZHZ : DataRow 
    {
        
        private DataTableJZHZ tableJZHZ;
        
        internal RowJZHZ(DataRowBuilder rb) : base(rb) 
        {
            this.tableJZHZ = ((DataTableJZHZ)(this.Table));
        }        
		
		/// 
		/// 字段ID所映射的属性。
		/// 
        public System.String ID
        {
            get 
            {	
                return ((System.String)(this[this.tableJZHZ.ColumnID])); 
            }
            set 
            {
                this[this.tableJZHZ.ColumnID] = value;
            }
        }
        
		/// 
		/// 字段NPHONE所映射的属性。
		/// 
        public System.Int64 NPHONE
        {
            get 
            {	
                try 
                {
	                return ((System.Int64)(this[this.tableJZHZ.ColumnNPHONE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableJZHZ.ColumnNPHONE] = value;
            }
        }
        
		/// 
		/// 字段VNAME所映射的属性。
		/// 
        public System.String VNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableJZHZ.ColumnVNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableJZHZ.ColumnVNAME] = value;
            }
        }
        
		/// 
		/// 字段NSEX所映射的属性。
		/// 
        public System.String NSEX
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableJZHZ.ColumnNSEX])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableJZHZ.ColumnNSEX] = value;
            }
        }
        
		/// 
		/// 字段VSFZH所映射的属性。
		/// 
        public System.String VSFZH
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableJZHZ.ColumnVSFZH])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableJZHZ.ColumnVSFZH] = value;
            }
        }
        
		/// 
		/// 字段VCARD所映射的属性。
		/// 
        public System.String VCARD
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableJZHZ.ColumnVCARD])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableJZHZ.ColumnVCARD] = value;
            }
        }
        
		/// 
		/// 字段VPWD所映射的属性。
		/// 
        public System.String VPWD
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableJZHZ.ColumnVPWD])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableJZHZ.ColumnVPWD] = value;
            }
        }
        
		/// 
		/// 字段VPYM所映射的属性。
		/// 
        public System.String VPYM
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableJZHZ.ColumnVPYM])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableJZHZ.ColumnVPYM] = value;
            }
        }
        
		/// 
		/// 字段DBIRTHDAY所映射的属性。
		/// 
        public System.DateTime DBIRTHDAY
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableJZHZ.ColumnDBIRTHDAY])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableJZHZ.ColumnDBIRTHDAY] = value;
            }
        }
        
		/// 
		/// 字段NSTOP所映射的属性。
		/// 
        public System.Int16 NSTOP
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableJZHZ.ColumnNSTOP])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableJZHZ.ColumnNSTOP] = value;
            }
        }
        
		/// 
		/// 字段VPATIENTID所映射的属性。
		/// 
        public System.String VPATIENTID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableJZHZ.ColumnVPATIENTID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableJZHZ.ColumnVPATIENTID] = value;
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
	                return ((System.DateTime)(this[this.tableJZHZ.ColumnDCREATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableJZHZ.ColumnDCREATE] = value;
            }
        }
        
		/// 
		/// 判断字段NPHONE是否为空。
		/// 
        public bool IsNPHONENull()
        {
            return this.IsNull(this.tableJZHZ.ColumnNPHONE);
        }

		/// 
		/// 设置字段NPHONE为空值。
		/// 
        public void SetNPHONENull() 
        {
            this[this.tableJZHZ.ColumnNPHONE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VNAME是否为空。
		/// 
        public bool IsVNAMENull()
        {
            return this.IsNull(this.tableJZHZ.ColumnVNAME);
        }

		/// 
		/// 设置字段VNAME为空值。
		/// 
        public void SetVNAMENull() 
        {
            this[this.tableJZHZ.ColumnVNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSEX是否为空。
		/// 
        public bool IsNSEXNull()
        {
            return this.IsNull(this.tableJZHZ.ColumnNSEX);
        }

		/// 
		/// 设置字段NSEX为空值。
		/// 
        public void SetNSEXNull() 
        {
            this[this.tableJZHZ.ColumnNSEX] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VSFZH是否为空。
		/// 
        public bool IsVSFZHNull()
        {
            return this.IsNull(this.tableJZHZ.ColumnVSFZH);
        }

		/// 
		/// 设置字段VSFZH为空值。
		/// 
        public void SetVSFZHNull() 
        {
            this[this.tableJZHZ.ColumnVSFZH] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VCARD是否为空。
		/// 
        public bool IsVCARDNull()
        {
            return this.IsNull(this.tableJZHZ.ColumnVCARD);
        }

		/// 
		/// 设置字段VCARD为空值。
		/// 
        public void SetVCARDNull() 
        {
            this[this.tableJZHZ.ColumnVCARD] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPWD是否为空。
		/// 
        public bool IsVPWDNull()
        {
            return this.IsNull(this.tableJZHZ.ColumnVPWD);
        }

		/// 
		/// 设置字段VPWD为空值。
		/// 
        public void SetVPWDNull() 
        {
            this[this.tableJZHZ.ColumnVPWD] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPYM是否为空。
		/// 
        public bool IsVPYMNull()
        {
            return this.IsNull(this.tableJZHZ.ColumnVPYM);
        }

		/// 
		/// 设置字段VPYM为空值。
		/// 
        public void SetVPYMNull() 
        {
            this[this.tableJZHZ.ColumnVPYM] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DBIRTHDAY是否为空。
		/// 
        public bool IsDBIRTHDAYNull()
        {
            return this.IsNull(this.tableJZHZ.ColumnDBIRTHDAY);
        }

		/// 
		/// 设置字段DBIRTHDAY为空值。
		/// 
        public void SetDBIRTHDAYNull() 
        {
            this[this.tableJZHZ.ColumnDBIRTHDAY] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSTOP是否为空。
		/// 
        public bool IsNSTOPNull()
        {
            return this.IsNull(this.tableJZHZ.ColumnNSTOP);
        }

		/// 
		/// 设置字段NSTOP为空值。
		/// 
        public void SetNSTOPNull() 
        {
            this[this.tableJZHZ.ColumnNSTOP] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPATIENTID是否为空。
		/// 
        public bool IsVPATIENTIDNull()
        {
            return this.IsNull(this.tableJZHZ.ColumnVPATIENTID);
        }

		/// 
		/// 设置字段VPATIENTID为空值。
		/// 
        public void SetVPATIENTIDNull() 
        {
            this[this.tableJZHZ.ColumnVPATIENTID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DCREATE是否为空。
		/// 
        public bool IsDCREATENull()
        {
            return this.IsNull(this.tableJZHZ.ColumnDCREATE);
        }

		/// 
		/// 设置字段DCREATE为空值。
		/// 
        public void SetDCREATENull() 
        {
            this[this.tableJZHZ.ColumnDCREATE] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventJZHZ : EventArgs {
        
        private RowJZHZ eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventJZHZ(RowJZHZ row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowJZHZ Row {
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
	