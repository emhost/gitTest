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
	#region DataSetJZHZ_RELATION
	/// 
	/// 对于JZHZ_RELATION的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetJZHZ_RELATION : DataSet
    {
		
		private DataTableJZHZ_RELATION tableJZHZ_RELATION;
		
        public DataSetJZHZ_RELATION() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetJZHZ_RELATION实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetJZHZ_RELATION GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetJZHZ_RELATION dataSet = (DataSetJZHZ_RELATION)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetJZHZ_RELATION entity = new DataSetJZHZ_RELATION();
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
        
        protected DataSetJZHZ_RELATION(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["JZHZ_RELATION"] != null)) 
                {
                    this.Tables.Add(new DataTableJZHZ_RELATION(ds.Tables["JZHZ_RELATION"]));
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
		/// 对于数据表JZHZ_RELATION的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableJZHZ_RELATION JZHZ_RELATION 
		{
			get
			{
				return this.tableJZHZ_RELATION;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetJZHZ_RELATION cln = ((DataSetJZHZ_RELATION)(base.Clone()));
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
			
			if ((ds.Tables["JZHZ_RELATION"] != null)) 
			{
				this.Tables.Add(new DataTableJZHZ_RELATION(ds.Tables["JZHZ_RELATION"]));
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
			
			this.tableJZHZ_RELATION = ((DataTableJZHZ_RELATION)(this.Tables["JZHZ_RELATION"]));
			if ((this.tableJZHZ_RELATION != null)) {
				this.tableJZHZ_RELATION.InitVars();
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
			
			this.tableJZHZ_RELATION = new DataTableJZHZ_RELATION();
			this.Tables.Add(this.tableJZHZ_RELATION);
			
		}
		
		private bool ShouldSerializeJZHZ_RELATION() 
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
	
    public delegate void RowChangeEventHandlerJZHZ_RELATION(object sender, RowChangeEventJZHZ_RELATION e);
	
	#region DataTableJZHZ_RELATION
	/// 
	/// 对于数据表JZHZ_RELATION的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableJZHZ_RELATION : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnNISDEF;
		
        private DataColumn columnID;
		
        private DataColumn columnNPHONE;
		
        private DataColumn columnVNAME;
		
        private DataColumn columnVSFZH;
		
        private DataColumn columnVCARD;
		
        private DataColumn columnVGX;
		
        private DataColumn columnVGLID;
		
        private DataColumn columnVPYM;
		
        private DataColumn columnNSEX;
		
        private DataColumn columnDBIRTHDAY;
		
        private DataColumn columnVPATIENTID;
		
        private DataColumn columnDCREATE;
		
        internal DataTableJZHZ_RELATION() : base("JZHZ_RELATION") 
        {
            this.InitClass();
        }
        
        internal DataTableJZHZ_RELATION(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnNISDEF 
        {
            get 
            {
                return this.columnNISDEF;
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
		
        public DataColumn ColumnVGX 
        {
            get 
            {
                return this.columnVGX;
            }
        }
		
        public DataColumn ColumnVGLID 
        {
            get 
            {
                return this.columnVGLID;
            }
        }
		
        public DataColumn ColumnVPYM 
        {
            get 
            {
                return this.columnVPYM;
            }
        }
		
        public DataColumn ColumnNSEX 
        {
            get 
            {
                return this.columnNSEX;
            }
        }
		
        public DataColumn ColumnDBIRTHDAY 
        {
            get 
            {
                return this.columnDBIRTHDAY;
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
        public RowJZHZ_RELATION this[int index] 
        {
            get 
            {
                return ((RowJZHZ_RELATION)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerJZHZ_RELATION RowChangedJZHZ_RELATION;
        
        public event RowChangeEventHandlerJZHZ_RELATION RowChangingJZHZ_RELATION;
        
        public event RowChangeEventHandlerJZHZ_RELATION RowDeletedJZHZ_RELATION;
        
        public event RowChangeEventHandlerJZHZ_RELATION RowDeletingJZHZ_RELATION;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowJZHZ_RELATION(RowJZHZ_RELATION row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowJZHZ_RELATION AddRowJZHZ_RELATION(System.Int16 NISDEF,System.String ID,System.Int64 NPHONE,System.String VNAME,System.String VSFZH,System.String VCARD,System.String VGX,System.String VGLID,System.String VPYM,System.String NSEX,System.DateTime DBIRTHDAY,System.String VPATIENTID,System.DateTime DCREATE) 
        {
            RowJZHZ_RELATION row = ((RowJZHZ_RELATION)(this.NewRow()));
            row.ItemArray = new object[] {NISDEF,ID,NPHONE,VNAME,VSFZH,VCARD,VGX,VGLID,VPYM,NSEX,DBIRTHDAY,VPATIENTID,DCREATE};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowJZHZ_RELATION FindByID(System.String ID) {
            return ((RowJZHZ_RELATION)(this.Rows.Find(new object[] {
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
            DataTableJZHZ_RELATION cln = ((DataTableJZHZ_RELATION)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableJZHZ_RELATION();
        }
        
        internal void InitVars() 
        {	
            this.columnNISDEF = this.Columns["NISDEF"];
            this.columnID = this.Columns["ID"];
            this.columnNPHONE = this.Columns["NPHONE"];
            this.columnVNAME = this.Columns["VNAME"];
            this.columnVSFZH = this.Columns["VSFZH"];
            this.columnVCARD = this.Columns["VCARD"];
            this.columnVGX = this.Columns["VGX"];
            this.columnVGLID = this.Columns["VGLID"];
            this.columnVPYM = this.Columns["VPYM"];
            this.columnNSEX = this.Columns["NSEX"];
            this.columnDBIRTHDAY = this.Columns["DBIRTHDAY"];
            this.columnVPATIENTID = this.Columns["VPATIENTID"];
            this.columnDCREATE = this.Columns["DCREATE"];
        }
        
        private void InitClass() 
        {	
            this.columnNISDEF = new DataColumn("NISDEF", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNISDEF.AllowDBNull = true;
            this.Columns.Add(this.columnNISDEF);
			
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
			
            this.columnVSFZH = new DataColumn("VSFZH", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVSFZH.MaxLength = 20;
            this.columnVSFZH.AllowDBNull = true;
            this.Columns.Add(this.columnVSFZH);
			
            this.columnVCARD = new DataColumn("VCARD", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCARD.MaxLength = 20;
            this.columnVCARD.AllowDBNull = true;
            this.Columns.Add(this.columnVCARD);
			
            this.columnVGX = new DataColumn("VGX", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVGX.MaxLength = 20;
            this.columnVGX.AllowDBNull = true;
            this.Columns.Add(this.columnVGX);
			
            this.columnVGLID = new DataColumn("VGLID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVGLID.MaxLength = 36;
            this.columnVGLID.AllowDBNull = true;
            this.Columns.Add(this.columnVGLID);
			
            this.columnVPYM = new DataColumn("VPYM", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPYM.MaxLength = 20;
            this.columnVPYM.AllowDBNull = true;
            this.Columns.Add(this.columnVPYM);
			
            this.columnNSEX = new DataColumn("NSEX", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNSEX.MaxLength = 10;
            this.columnNSEX.AllowDBNull = true;
            this.Columns.Add(this.columnNSEX);
			
            this.columnDBIRTHDAY = new DataColumn("DBIRTHDAY", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDBIRTHDAY.AllowDBNull = true;
            this.Columns.Add(this.columnDBIRTHDAY);
			
            this.columnVPATIENTID = new DataColumn("VPATIENTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPATIENTID.MaxLength = 20;
            this.columnVPATIENTID.AllowDBNull = true;
            this.Columns.Add(this.columnVPATIENTID);
			
            this.columnDCREATE = new DataColumn("DCREATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDCREATE.AllowDBNull = true;
            this.Columns.Add(this.columnDCREATE);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowJZHZ_RELATION NewRowJZHZ_RELATION() {
            return ((RowJZHZ_RELATION)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowJZHZ_RELATION(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowJZHZ_RELATION);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedJZHZ_RELATION != null)) {
                this.RowChangedJZHZ_RELATION(this, new RowChangeEventJZHZ_RELATION(((RowJZHZ_RELATION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingJZHZ_RELATION != null)) {
                this.RowChangingJZHZ_RELATION(this, new RowChangeEventJZHZ_RELATION(((RowJZHZ_RELATION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedJZHZ_RELATION != null)) {
                this.RowDeletedJZHZ_RELATION(this, new RowChangeEventJZHZ_RELATION(((RowJZHZ_RELATION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingJZHZ_RELATION != null)) {
                this.RowDeletingJZHZ_RELATION(this, new RowChangeEventJZHZ_RELATION(((RowJZHZ_RELATION)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowJZHZ_RELATION(RowJZHZ_RELATION row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowJZHZ_RELATION
	/// 
	/// 数据表JZHZ_RELATION行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowJZHZ_RELATION : DataRow 
    {
        
        private DataTableJZHZ_RELATION tableJZHZ_RELATION;
        
        internal RowJZHZ_RELATION(DataRowBuilder rb) : base(rb) 
        {
            this.tableJZHZ_RELATION = ((DataTableJZHZ_RELATION)(this.Table));
        }        
		
		/// 
		/// 字段NISDEF所映射的属性。
		/// 
        public System.Int16 NISDEF
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableJZHZ_RELATION.ColumnNISDEF])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableJZHZ_RELATION.ColumnNISDEF] = value;
            }
        }
        
		/// 
		/// 字段ID所映射的属性。
		/// 
        public System.String ID
        {
            get 
            {	
                return ((System.String)(this[this.tableJZHZ_RELATION.ColumnID])); 
            }
            set 
            {
                this[this.tableJZHZ_RELATION.ColumnID] = value;
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
	                return ((System.Int64)(this[this.tableJZHZ_RELATION.ColumnNPHONE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableJZHZ_RELATION.ColumnNPHONE] = value;
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
	                return ((System.String)(this[this.tableJZHZ_RELATION.ColumnVNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableJZHZ_RELATION.ColumnVNAME] = value;
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
	                return ((System.String)(this[this.tableJZHZ_RELATION.ColumnVSFZH])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableJZHZ_RELATION.ColumnVSFZH] = value;
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
	                return ((System.String)(this[this.tableJZHZ_RELATION.ColumnVCARD])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableJZHZ_RELATION.ColumnVCARD] = value;
            }
        }
        
		/// 
		/// 字段VGX所映射的属性。
		/// 
        public System.String VGX
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableJZHZ_RELATION.ColumnVGX])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableJZHZ_RELATION.ColumnVGX] = value;
            }
        }
        
		/// 
		/// 字段VGLID所映射的属性。
		/// 
        public System.String VGLID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableJZHZ_RELATION.ColumnVGLID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableJZHZ_RELATION.ColumnVGLID] = value;
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
	                return ((System.String)(this[this.tableJZHZ_RELATION.ColumnVPYM])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableJZHZ_RELATION.ColumnVPYM] = value;
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
	                return ((System.String)(this[this.tableJZHZ_RELATION.ColumnNSEX])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableJZHZ_RELATION.ColumnNSEX] = value;
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
	                return ((System.DateTime)(this[this.tableJZHZ_RELATION.ColumnDBIRTHDAY])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableJZHZ_RELATION.ColumnDBIRTHDAY] = value;
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
	                return ((System.String)(this[this.tableJZHZ_RELATION.ColumnVPATIENTID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableJZHZ_RELATION.ColumnVPATIENTID] = value;
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
	                return ((System.DateTime)(this[this.tableJZHZ_RELATION.ColumnDCREATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableJZHZ_RELATION.ColumnDCREATE] = value;
            }
        }
        
		/// 
		/// 判断字段NISDEF是否为空。
		/// 
        public bool IsNISDEFNull()
        {
            return this.IsNull(this.tableJZHZ_RELATION.ColumnNISDEF);
        }

		/// 
		/// 设置字段NISDEF为空值。
		/// 
        public void SetNISDEFNull() 
        {
            this[this.tableJZHZ_RELATION.ColumnNISDEF] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NPHONE是否为空。
		/// 
        public bool IsNPHONENull()
        {
            return this.IsNull(this.tableJZHZ_RELATION.ColumnNPHONE);
        }

		/// 
		/// 设置字段NPHONE为空值。
		/// 
        public void SetNPHONENull() 
        {
            this[this.tableJZHZ_RELATION.ColumnNPHONE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VNAME是否为空。
		/// 
        public bool IsVNAMENull()
        {
            return this.IsNull(this.tableJZHZ_RELATION.ColumnVNAME);
        }

		/// 
		/// 设置字段VNAME为空值。
		/// 
        public void SetVNAMENull() 
        {
            this[this.tableJZHZ_RELATION.ColumnVNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VSFZH是否为空。
		/// 
        public bool IsVSFZHNull()
        {
            return this.IsNull(this.tableJZHZ_RELATION.ColumnVSFZH);
        }

		/// 
		/// 设置字段VSFZH为空值。
		/// 
        public void SetVSFZHNull() 
        {
            this[this.tableJZHZ_RELATION.ColumnVSFZH] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VCARD是否为空。
		/// 
        public bool IsVCARDNull()
        {
            return this.IsNull(this.tableJZHZ_RELATION.ColumnVCARD);
        }

		/// 
		/// 设置字段VCARD为空值。
		/// 
        public void SetVCARDNull() 
        {
            this[this.tableJZHZ_RELATION.ColumnVCARD] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VGX是否为空。
		/// 
        public bool IsVGXNull()
        {
            return this.IsNull(this.tableJZHZ_RELATION.ColumnVGX);
        }

		/// 
		/// 设置字段VGX为空值。
		/// 
        public void SetVGXNull() 
        {
            this[this.tableJZHZ_RELATION.ColumnVGX] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VGLID是否为空。
		/// 
        public bool IsVGLIDNull()
        {
            return this.IsNull(this.tableJZHZ_RELATION.ColumnVGLID);
        }

		/// 
		/// 设置字段VGLID为空值。
		/// 
        public void SetVGLIDNull() 
        {
            this[this.tableJZHZ_RELATION.ColumnVGLID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPYM是否为空。
		/// 
        public bool IsVPYMNull()
        {
            return this.IsNull(this.tableJZHZ_RELATION.ColumnVPYM);
        }

		/// 
		/// 设置字段VPYM为空值。
		/// 
        public void SetVPYMNull() 
        {
            this[this.tableJZHZ_RELATION.ColumnVPYM] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSEX是否为空。
		/// 
        public bool IsNSEXNull()
        {
            return this.IsNull(this.tableJZHZ_RELATION.ColumnNSEX);
        }

		/// 
		/// 设置字段NSEX为空值。
		/// 
        public void SetNSEXNull() 
        {
            this[this.tableJZHZ_RELATION.ColumnNSEX] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DBIRTHDAY是否为空。
		/// 
        public bool IsDBIRTHDAYNull()
        {
            return this.IsNull(this.tableJZHZ_RELATION.ColumnDBIRTHDAY);
        }

		/// 
		/// 设置字段DBIRTHDAY为空值。
		/// 
        public void SetDBIRTHDAYNull() 
        {
            this[this.tableJZHZ_RELATION.ColumnDBIRTHDAY] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPATIENTID是否为空。
		/// 
        public bool IsVPATIENTIDNull()
        {
            return this.IsNull(this.tableJZHZ_RELATION.ColumnVPATIENTID);
        }

		/// 
		/// 设置字段VPATIENTID为空值。
		/// 
        public void SetVPATIENTIDNull() 
        {
            this[this.tableJZHZ_RELATION.ColumnVPATIENTID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DCREATE是否为空。
		/// 
        public bool IsDCREATENull()
        {
            return this.IsNull(this.tableJZHZ_RELATION.ColumnDCREATE);
        }

		/// 
		/// 设置字段DCREATE为空值。
		/// 
        public void SetDCREATENull() 
        {
            this[this.tableJZHZ_RELATION.ColumnDCREATE] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventJZHZ_RELATION : EventArgs {
        
        private RowJZHZ_RELATION eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventJZHZ_RELATION(RowJZHZ_RELATION row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowJZHZ_RELATION Row {
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
	