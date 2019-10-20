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
	#region DataSetPAYMENT_DETAIL
	/// 
	/// 对于PAYMENT_DETAIL的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetPAYMENT_DETAIL : DataSet
    {
		
		private DataTablePAYMENT_DETAIL tablePAYMENT_DETAIL;
		
        public DataSetPAYMENT_DETAIL() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetPAYMENT_DETAIL实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetPAYMENT_DETAIL GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetPAYMENT_DETAIL dataSet = (DataSetPAYMENT_DETAIL)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetPAYMENT_DETAIL entity = new DataSetPAYMENT_DETAIL();
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
        
        protected DataSetPAYMENT_DETAIL(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["PAYMENT_DETAIL"] != null)) 
                {
                    this.Tables.Add(new DataTablePAYMENT_DETAIL(ds.Tables["PAYMENT_DETAIL"]));
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
		/// 对于数据表PAYMENT_DETAIL的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTablePAYMENT_DETAIL PAYMENT_DETAIL 
		{
			get
			{
				return this.tablePAYMENT_DETAIL;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetPAYMENT_DETAIL cln = ((DataSetPAYMENT_DETAIL)(base.Clone()));
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
			
			if ((ds.Tables["PAYMENT_DETAIL"] != null)) 
			{
				this.Tables.Add(new DataTablePAYMENT_DETAIL(ds.Tables["PAYMENT_DETAIL"]));
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
			
			this.tablePAYMENT_DETAIL = ((DataTablePAYMENT_DETAIL)(this.Tables["PAYMENT_DETAIL"]));
			if ((this.tablePAYMENT_DETAIL != null)) {
				this.tablePAYMENT_DETAIL.InitVars();
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
			
			this.tablePAYMENT_DETAIL = new DataTablePAYMENT_DETAIL();
			this.Tables.Add(this.tablePAYMENT_DETAIL);
			
		}
		
		private bool ShouldSerializePAYMENT_DETAIL() 
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
	
    public delegate void RowChangeEventHandlerPAYMENT_DETAIL(object sender, RowChangeEventPAYMENT_DETAIL e);
	
	#region DataTablePAYMENT_DETAIL
	/// 
	/// 对于数据表PAYMENT_DETAIL的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTablePAYMENT_DETAIL : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVID;
		
        private DataColumn columnVPRESC_ID;
		
        private DataColumn columnVPRESC_TYPE;
		
        private DataColumn columnVITEM_CODE;
		
        private DataColumn columnVITEM_NAME;
		
        private DataColumn columnNPRICE;
		
        private DataColumn columnNSL;
		
        private DataColumn columnVPRESC_DETAIL_ID;
		
        private DataColumn columnVCLINICNO;
		
        private DataColumn columnVITEM_TYPE;
		
        private DataColumn columnVDDLSH;
		
        internal DataTablePAYMENT_DETAIL() : base("PAYMENT_DETAIL") 
        {
            this.InitClass();
        }
        
        internal DataTablePAYMENT_DETAIL(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVPRESC_ID 
        {
            get 
            {
                return this.columnVPRESC_ID;
            }
        }
		
        public DataColumn ColumnVPRESC_TYPE 
        {
            get 
            {
                return this.columnVPRESC_TYPE;
            }
        }
		
        public DataColumn ColumnVITEM_CODE 
        {
            get 
            {
                return this.columnVITEM_CODE;
            }
        }
		
        public DataColumn ColumnVITEM_NAME 
        {
            get 
            {
                return this.columnVITEM_NAME;
            }
        }
		
        public DataColumn ColumnNPRICE 
        {
            get 
            {
                return this.columnNPRICE;
            }
        }
		
        public DataColumn ColumnNSL 
        {
            get 
            {
                return this.columnNSL;
            }
        }
		
        public DataColumn ColumnVPRESC_DETAIL_ID 
        {
            get 
            {
                return this.columnVPRESC_DETAIL_ID;
            }
        }
		
        public DataColumn ColumnVCLINICNO 
        {
            get 
            {
                return this.columnVCLINICNO;
            }
        }
		
        public DataColumn ColumnVITEM_TYPE 
        {
            get 
            {
                return this.columnVITEM_TYPE;
            }
        }
		
        public DataColumn ColumnVDDLSH 
        {
            get 
            {
                return this.columnVDDLSH;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowPAYMENT_DETAIL this[int index] 
        {
            get 
            {
                return ((RowPAYMENT_DETAIL)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerPAYMENT_DETAIL RowChangedPAYMENT_DETAIL;
        
        public event RowChangeEventHandlerPAYMENT_DETAIL RowChangingPAYMENT_DETAIL;
        
        public event RowChangeEventHandlerPAYMENT_DETAIL RowDeletedPAYMENT_DETAIL;
        
        public event RowChangeEventHandlerPAYMENT_DETAIL RowDeletingPAYMENT_DETAIL;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowPAYMENT_DETAIL(RowPAYMENT_DETAIL row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowPAYMENT_DETAIL AddRowPAYMENT_DETAIL(System.String VID,System.String VPRESC_ID,System.String VPRESC_TYPE,System.String VITEM_CODE,System.String VITEM_NAME,System.Decimal NPRICE,System.Decimal NSL,System.String VPRESC_DETAIL_ID,System.String VCLINICNO,System.String VITEM_TYPE,System.String VDDLSH) 
        {
            RowPAYMENT_DETAIL row = ((RowPAYMENT_DETAIL)(this.NewRow()));
            row.ItemArray = new object[] {VID,VPRESC_ID,VPRESC_TYPE,VITEM_CODE,VITEM_NAME,NPRICE,NSL,VPRESC_DETAIL_ID,VCLINICNO,VITEM_TYPE,VDDLSH};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowPAYMENT_DETAIL FindByVID(System.String VID) {
            return ((RowPAYMENT_DETAIL)(this.Rows.Find(new object[] {
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
            DataTablePAYMENT_DETAIL cln = ((DataTablePAYMENT_DETAIL)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTablePAYMENT_DETAIL();
        }
        
        internal void InitVars() 
        {	
            this.columnVID = this.Columns["VID"];
            this.columnVPRESC_ID = this.Columns["VPRESC_ID"];
            this.columnVPRESC_TYPE = this.Columns["VPRESC_TYPE"];
            this.columnVITEM_CODE = this.Columns["VITEM_CODE"];
            this.columnVITEM_NAME = this.Columns["VITEM_NAME"];
            this.columnNPRICE = this.Columns["NPRICE"];
            this.columnNSL = this.Columns["NSL"];
            this.columnVPRESC_DETAIL_ID = this.Columns["VPRESC_DETAIL_ID"];
            this.columnVCLINICNO = this.Columns["VCLINICNO"];
            this.columnVITEM_TYPE = this.Columns["VITEM_TYPE"];
            this.columnVDDLSH = this.Columns["VDDLSH"];
        }
        
        private void InitClass() 
        {	
            this.columnVID = new DataColumn("VID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVID.MaxLength = 50;
            this.columnVID.AllowDBNull = false;
            this.columnVID.Unique = true;
            
            this.Columns.Add(this.columnVID);
			
            this.columnVPRESC_ID = new DataColumn("VPRESC_ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPRESC_ID.MaxLength = 20;
            this.columnVPRESC_ID.AllowDBNull = true;
            this.Columns.Add(this.columnVPRESC_ID);
			
            this.columnVPRESC_TYPE = new DataColumn("VPRESC_TYPE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPRESC_TYPE.MaxLength = 20;
            this.columnVPRESC_TYPE.AllowDBNull = true;
            this.Columns.Add(this.columnVPRESC_TYPE);
			
            this.columnVITEM_CODE = new DataColumn("VITEM_CODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEM_CODE.MaxLength = 20;
            this.columnVITEM_CODE.AllowDBNull = true;
            this.Columns.Add(this.columnVITEM_CODE);
			
            this.columnVITEM_NAME = new DataColumn("VITEM_NAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEM_NAME.MaxLength = 20;
            this.columnVITEM_NAME.AllowDBNull = true;
            this.Columns.Add(this.columnVITEM_NAME);
			
            this.columnNPRICE = new DataColumn("NPRICE", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNPRICE.AllowDBNull = true;
            this.Columns.Add(this.columnNPRICE);
			
            this.columnNSL = new DataColumn("NSL", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNSL.AllowDBNull = true;
            this.Columns.Add(this.columnNSL);
			
            this.columnVPRESC_DETAIL_ID = new DataColumn("VPRESC_DETAIL_ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPRESC_DETAIL_ID.MaxLength = 20;
            this.columnVPRESC_DETAIL_ID.AllowDBNull = true;
            this.Columns.Add(this.columnVPRESC_DETAIL_ID);
			
            this.columnVCLINICNO = new DataColumn("VCLINICNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCLINICNO.MaxLength = 20;
            this.columnVCLINICNO.AllowDBNull = true;
            this.Columns.Add(this.columnVCLINICNO);
			
            this.columnVITEM_TYPE = new DataColumn("VITEM_TYPE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEM_TYPE.MaxLength = 20;
            this.columnVITEM_TYPE.AllowDBNull = true;
            this.Columns.Add(this.columnVITEM_TYPE);
			
            this.columnVDDLSH = new DataColumn("VDDLSH", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDDLSH.MaxLength = 50;
            this.columnVDDLSH.AllowDBNull = true;
            this.Columns.Add(this.columnVDDLSH);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowPAYMENT_DETAIL NewRowPAYMENT_DETAIL() {
            return ((RowPAYMENT_DETAIL)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowPAYMENT_DETAIL(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowPAYMENT_DETAIL);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedPAYMENT_DETAIL != null)) {
                this.RowChangedPAYMENT_DETAIL(this, new RowChangeEventPAYMENT_DETAIL(((RowPAYMENT_DETAIL)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingPAYMENT_DETAIL != null)) {
                this.RowChangingPAYMENT_DETAIL(this, new RowChangeEventPAYMENT_DETAIL(((RowPAYMENT_DETAIL)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedPAYMENT_DETAIL != null)) {
                this.RowDeletedPAYMENT_DETAIL(this, new RowChangeEventPAYMENT_DETAIL(((RowPAYMENT_DETAIL)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingPAYMENT_DETAIL != null)) {
                this.RowDeletingPAYMENT_DETAIL(this, new RowChangeEventPAYMENT_DETAIL(((RowPAYMENT_DETAIL)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowPAYMENT_DETAIL(RowPAYMENT_DETAIL row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowPAYMENT_DETAIL
	/// 
	/// 数据表PAYMENT_DETAIL行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowPAYMENT_DETAIL : DataRow 
    {
        
        private DataTablePAYMENT_DETAIL tablePAYMENT_DETAIL;
        
        internal RowPAYMENT_DETAIL(DataRowBuilder rb) : base(rb) 
        {
            this.tablePAYMENT_DETAIL = ((DataTablePAYMENT_DETAIL)(this.Table));
        }        
		
		/// 
		/// 字段VID所映射的属性。
		/// 
        public System.String VID
        {
            get 
            {	
                return ((System.String)(this[this.tablePAYMENT_DETAIL.ColumnVID])); 
            }
            set 
            {
                this[this.tablePAYMENT_DETAIL.ColumnVID] = value;
            }
        }
        
		/// 
		/// 字段VPRESC_ID所映射的属性。
		/// 
        public System.String VPRESC_ID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tablePAYMENT_DETAIL.ColumnVPRESC_ID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT_DETAIL.ColumnVPRESC_ID] = value;
            }
        }
        
		/// 
		/// 字段VPRESC_TYPE所映射的属性。
		/// 
        public System.String VPRESC_TYPE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tablePAYMENT_DETAIL.ColumnVPRESC_TYPE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT_DETAIL.ColumnVPRESC_TYPE] = value;
            }
        }
        
		/// 
		/// 字段VITEM_CODE所映射的属性。
		/// 
        public System.String VITEM_CODE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tablePAYMENT_DETAIL.ColumnVITEM_CODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT_DETAIL.ColumnVITEM_CODE] = value;
            }
        }
        
		/// 
		/// 字段VITEM_NAME所映射的属性。
		/// 
        public System.String VITEM_NAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tablePAYMENT_DETAIL.ColumnVITEM_NAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT_DETAIL.ColumnVITEM_NAME] = value;
            }
        }
        
		/// 
		/// 字段NPRICE所映射的属性。
		/// 
        public System.Decimal NPRICE
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tablePAYMENT_DETAIL.ColumnNPRICE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tablePAYMENT_DETAIL.ColumnNPRICE] = value;
            }
        }
        
		/// 
		/// 字段NSL所映射的属性。
		/// 
        public System.Decimal NSL
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tablePAYMENT_DETAIL.ColumnNSL])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tablePAYMENT_DETAIL.ColumnNSL] = value;
            }
        }
        
		/// 
		/// 字段VPRESC_DETAIL_ID所映射的属性。
		/// 
        public System.String VPRESC_DETAIL_ID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tablePAYMENT_DETAIL.ColumnVPRESC_DETAIL_ID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT_DETAIL.ColumnVPRESC_DETAIL_ID] = value;
            }
        }
        
		/// 
		/// 字段VCLINICNO所映射的属性。
		/// 
        public System.String VCLINICNO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tablePAYMENT_DETAIL.ColumnVCLINICNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT_DETAIL.ColumnVCLINICNO] = value;
            }
        }
        
		/// 
		/// 字段VITEM_TYPE所映射的属性。
		/// 
        public System.String VITEM_TYPE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tablePAYMENT_DETAIL.ColumnVITEM_TYPE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT_DETAIL.ColumnVITEM_TYPE] = value;
            }
        }
        
		/// 
		/// 字段VDDLSH所映射的属性。
		/// 
        public System.String VDDLSH
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tablePAYMENT_DETAIL.ColumnVDDLSH])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT_DETAIL.ColumnVDDLSH] = value;
            }
        }
        
		/// 
		/// 判断字段VPRESC_ID是否为空。
		/// 
        public bool IsVPRESC_IDNull()
        {
            return this.IsNull(this.tablePAYMENT_DETAIL.ColumnVPRESC_ID);
        }

		/// 
		/// 设置字段VPRESC_ID为空值。
		/// 
        public void SetVPRESC_IDNull() 
        {
            this[this.tablePAYMENT_DETAIL.ColumnVPRESC_ID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPRESC_TYPE是否为空。
		/// 
        public bool IsVPRESC_TYPENull()
        {
            return this.IsNull(this.tablePAYMENT_DETAIL.ColumnVPRESC_TYPE);
        }

		/// 
		/// 设置字段VPRESC_TYPE为空值。
		/// 
        public void SetVPRESC_TYPENull() 
        {
            this[this.tablePAYMENT_DETAIL.ColumnVPRESC_TYPE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEM_CODE是否为空。
		/// 
        public bool IsVITEM_CODENull()
        {
            return this.IsNull(this.tablePAYMENT_DETAIL.ColumnVITEM_CODE);
        }

		/// 
		/// 设置字段VITEM_CODE为空值。
		/// 
        public void SetVITEM_CODENull() 
        {
            this[this.tablePAYMENT_DETAIL.ColumnVITEM_CODE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEM_NAME是否为空。
		/// 
        public bool IsVITEM_NAMENull()
        {
            return this.IsNull(this.tablePAYMENT_DETAIL.ColumnVITEM_NAME);
        }

		/// 
		/// 设置字段VITEM_NAME为空值。
		/// 
        public void SetVITEM_NAMENull() 
        {
            this[this.tablePAYMENT_DETAIL.ColumnVITEM_NAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NPRICE是否为空。
		/// 
        public bool IsNPRICENull()
        {
            return this.IsNull(this.tablePAYMENT_DETAIL.ColumnNPRICE);
        }

		/// 
		/// 设置字段NPRICE为空值。
		/// 
        public void SetNPRICENull() 
        {
            this[this.tablePAYMENT_DETAIL.ColumnNPRICE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSL是否为空。
		/// 
        public bool IsNSLNull()
        {
            return this.IsNull(this.tablePAYMENT_DETAIL.ColumnNSL);
        }

		/// 
		/// 设置字段NSL为空值。
		/// 
        public void SetNSLNull() 
        {
            this[this.tablePAYMENT_DETAIL.ColumnNSL] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPRESC_DETAIL_ID是否为空。
		/// 
        public bool IsVPRESC_DETAIL_IDNull()
        {
            return this.IsNull(this.tablePAYMENT_DETAIL.ColumnVPRESC_DETAIL_ID);
        }

		/// 
		/// 设置字段VPRESC_DETAIL_ID为空值。
		/// 
        public void SetVPRESC_DETAIL_IDNull() 
        {
            this[this.tablePAYMENT_DETAIL.ColumnVPRESC_DETAIL_ID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VCLINICNO是否为空。
		/// 
        public bool IsVCLINICNONull()
        {
            return this.IsNull(this.tablePAYMENT_DETAIL.ColumnVCLINICNO);
        }

		/// 
		/// 设置字段VCLINICNO为空值。
		/// 
        public void SetVCLINICNONull() 
        {
            this[this.tablePAYMENT_DETAIL.ColumnVCLINICNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEM_TYPE是否为空。
		/// 
        public bool IsVITEM_TYPENull()
        {
            return this.IsNull(this.tablePAYMENT_DETAIL.ColumnVITEM_TYPE);
        }

		/// 
		/// 设置字段VITEM_TYPE为空值。
		/// 
        public void SetVITEM_TYPENull() 
        {
            this[this.tablePAYMENT_DETAIL.ColumnVITEM_TYPE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDDLSH是否为空。
		/// 
        public bool IsVDDLSHNull()
        {
            return this.IsNull(this.tablePAYMENT_DETAIL.ColumnVDDLSH);
        }

		/// 
		/// 设置字段VDDLSH为空值。
		/// 
        public void SetVDDLSHNull() 
        {
            this[this.tablePAYMENT_DETAIL.ColumnVDDLSH] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventPAYMENT_DETAIL : EventArgs {
        
        private RowPAYMENT_DETAIL eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventPAYMENT_DETAIL(RowPAYMENT_DETAIL row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowPAYMENT_DETAIL Row {
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
	