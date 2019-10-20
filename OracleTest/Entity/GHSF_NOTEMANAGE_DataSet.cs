//------------------------------------------------------------------------------
//     这部分代码属于实体定义层，是由实体编辑器工具自动产生的。
//     (Runtime Version: 2.2017.3.2)
//     对此代码进行的任何修改会导致其它的行为错误，并且重新生成时所有的修改会丢失。
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Xml;
using System.Runtime.Serialization;

namespace HYGHSF.Entity
{
	#region DataSetGHSF_NOTEMANAGE
	/// 
	/// 对于GHSF_NOTEMANAGE的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetGHSF_NOTEMANAGE : DataSet
    {
		
		private DataTableGHSF_GHSF_NOTEMANAGE tableGHSF_GHSF_NOTEMANAGE;
		
        public DataSetGHSF_NOTEMANAGE() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetGHSF_NOTEMANAGE实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetGHSF_NOTEMANAGE GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetGHSF_NOTEMANAGE dataSet = (DataSetGHSF_NOTEMANAGE)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetGHSF_NOTEMANAGE entity = new DataSetGHSF_NOTEMANAGE();
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
        
        protected DataSetGHSF_NOTEMANAGE(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["GHSF_GHSF_NOTEMANAGE"] != null)) 
                {
                    this.Tables.Add(new DataTableGHSF_GHSF_NOTEMANAGE(ds.Tables["GHSF_GHSF_NOTEMANAGE"]));
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
		/// 对于数据表GHSF_GHSF_NOTEMANAGE的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableGHSF_GHSF_NOTEMANAGE GHSF_GHSF_NOTEMANAGE 
		{
			get
			{
				return this.tableGHSF_GHSF_NOTEMANAGE;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetGHSF_NOTEMANAGE cln = ((DataSetGHSF_NOTEMANAGE)(base.Clone()));
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
			
			if ((ds.Tables["GHSF_GHSF_NOTEMANAGE"] != null)) 
			{
				this.Tables.Add(new DataTableGHSF_GHSF_NOTEMANAGE(ds.Tables["GHSF_GHSF_NOTEMANAGE"]));
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
			
			this.tableGHSF_GHSF_NOTEMANAGE = ((DataTableGHSF_GHSF_NOTEMANAGE)(this.Tables["GHSF_GHSF_NOTEMANAGE"]));
			if ((this.tableGHSF_GHSF_NOTEMANAGE != null)) {
				this.tableGHSF_GHSF_NOTEMANAGE.InitVars();
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
			
			this.tableGHSF_GHSF_NOTEMANAGE = new DataTableGHSF_GHSF_NOTEMANAGE();
			this.Tables.Add(this.tableGHSF_GHSF_NOTEMANAGE);
			
		}
		
		private bool ShouldSerializeGHSF_GHSF_NOTEMANAGE() 
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
	
    public delegate void RowChangeEventHandlerGHSF_GHSF_NOTEMANAGE(object sender, RowChangeEventGHSF_GHSF_NOTEMANAGE e);
	
	#region DataTableGHSF_GHSF_NOTEMANAGE
	/// 
	/// 对于数据表GHSF_GHSF_NOTEMANAGE的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableGHSF_GHSF_NOTEMANAGE : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVNOTEMANAGEID;
		
        private DataColumn columnNPIAOJVLB;
		
        private DataColumn columnNQISHIH;
		
        private DataColumn columnNZHONGZHIH;
		
        private DataColumn columnNYISHIYH;
		
        private DataColumn columnVLINGYONGR;
		
        private DataColumn columnVJINGBANR;
		
        private DataColumn columnDLINGYONGRQ;
		
        private DataColumn columnVREMARKS;
		
        private DataColumn columnVOPERATORID;
		
        private DataColumn columnDOPERATORDATE;
		
        internal DataTableGHSF_GHSF_NOTEMANAGE() : base("GHSF_GHSF_NOTEMANAGE") 
        {
            this.InitClass();
        }
        
        internal DataTableGHSF_GHSF_NOTEMANAGE(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVNOTEMANAGEID 
        {
            get 
            {
                return this.columnVNOTEMANAGEID;
            }
        }
		
        public DataColumn ColumnNPIAOJVLB 
        {
            get 
            {
                return this.columnNPIAOJVLB;
            }
        }
		
        public DataColumn ColumnNQISHIH 
        {
            get 
            {
                return this.columnNQISHIH;
            }
        }
		
        public DataColumn ColumnNZHONGZHIH 
        {
            get 
            {
                return this.columnNZHONGZHIH;
            }
        }
		
        public DataColumn ColumnNYISHIYH 
        {
            get 
            {
                return this.columnNYISHIYH;
            }
        }
		
        public DataColumn ColumnVLINGYONGR 
        {
            get 
            {
                return this.columnVLINGYONGR;
            }
        }
		
        public DataColumn ColumnVJINGBANR 
        {
            get 
            {
                return this.columnVJINGBANR;
            }
        }
		
        public DataColumn ColumnDLINGYONGRQ 
        {
            get 
            {
                return this.columnDLINGYONGRQ;
            }
        }
		
        public DataColumn ColumnVREMARKS 
        {
            get 
            {
                return this.columnVREMARKS;
            }
        }
		
        public DataColumn ColumnVOPERATORID 
        {
            get 
            {
                return this.columnVOPERATORID;
            }
        }
		
        public DataColumn ColumnDOPERATORDATE 
        {
            get 
            {
                return this.columnDOPERATORDATE;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowGHSF_GHSF_NOTEMANAGE this[int index] 
        {
            get 
            {
                return ((RowGHSF_GHSF_NOTEMANAGE)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerGHSF_GHSF_NOTEMANAGE RowChangedGHSF_GHSF_NOTEMANAGE;
        
        public event RowChangeEventHandlerGHSF_GHSF_NOTEMANAGE RowChangingGHSF_GHSF_NOTEMANAGE;
        
        public event RowChangeEventHandlerGHSF_GHSF_NOTEMANAGE RowDeletedGHSF_GHSF_NOTEMANAGE;
        
        public event RowChangeEventHandlerGHSF_GHSF_NOTEMANAGE RowDeletingGHSF_GHSF_NOTEMANAGE;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowGHSF_GHSF_NOTEMANAGE(RowGHSF_GHSF_NOTEMANAGE row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowGHSF_GHSF_NOTEMANAGE AddRowGHSF_GHSF_NOTEMANAGE(System.String VNOTEMANAGEID,System.Int32 NPIAOJVLB,System.Decimal NQISHIH,System.Decimal NZHONGZHIH,System.Decimal NYISHIYH,System.String VLINGYONGR,System.String VJINGBANR,System.DateTime DLINGYONGRQ,System.String VREMARKS,System.String VOPERATORID,System.DateTime DOPERATORDATE) 
        {
            RowGHSF_GHSF_NOTEMANAGE row = ((RowGHSF_GHSF_NOTEMANAGE)(this.NewRow()));
            row.ItemArray = new object[] {VNOTEMANAGEID,NPIAOJVLB,NQISHIH,NZHONGZHIH,NYISHIYH,VLINGYONGR,VJINGBANR,DLINGYONGRQ,VREMARKS,VOPERATORID,DOPERATORDATE};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowGHSF_GHSF_NOTEMANAGE FindByVNOTEMANAGEID(System.String VNOTEMANAGEID) {
            return ((RowGHSF_GHSF_NOTEMANAGE)(this.Rows.Find(new object[] {
                        VNOTEMANAGEID})));
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
            DataTableGHSF_GHSF_NOTEMANAGE cln = ((DataTableGHSF_GHSF_NOTEMANAGE)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableGHSF_GHSF_NOTEMANAGE();
        }
        
        internal void InitVars() 
        {	
            this.columnVNOTEMANAGEID = this.Columns["VNOTEMANAGEID"];
            this.columnNPIAOJVLB = this.Columns["NPIAOJVLB"];
            this.columnNQISHIH = this.Columns["NQISHIH"];
            this.columnNZHONGZHIH = this.Columns["NZHONGZHIH"];
            this.columnNYISHIYH = this.Columns["NYISHIYH"];
            this.columnVLINGYONGR = this.Columns["VLINGYONGR"];
            this.columnVJINGBANR = this.Columns["VJINGBANR"];
            this.columnDLINGYONGRQ = this.Columns["DLINGYONGRQ"];
            this.columnVREMARKS = this.Columns["VREMARKS"];
            this.columnVOPERATORID = this.Columns["VOPERATORID"];
            this.columnDOPERATORDATE = this.Columns["DOPERATORDATE"];
        }
        
        private void InitClass() 
        {	
            this.columnVNOTEMANAGEID = new DataColumn("VNOTEMANAGEID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNOTEMANAGEID.MaxLength = 10;
            this.columnVNOTEMANAGEID.AllowDBNull = false;
            this.columnVNOTEMANAGEID.Unique = true;
            
            this.Columns.Add(this.columnVNOTEMANAGEID);
			
            this.columnNPIAOJVLB = new DataColumn("NPIAOJVLB", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNPIAOJVLB.AllowDBNull = false;
            this.Columns.Add(this.columnNPIAOJVLB);
			
            this.columnNQISHIH = new DataColumn("NQISHIH", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNQISHIH.AllowDBNull = false;
            this.Columns.Add(this.columnNQISHIH);
			
            this.columnNZHONGZHIH = new DataColumn("NZHONGZHIH", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNZHONGZHIH.AllowDBNull = false;
            this.Columns.Add(this.columnNZHONGZHIH);
			
            this.columnNYISHIYH = new DataColumn("NYISHIYH", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNYISHIYH.AllowDBNull = true;
            this.Columns.Add(this.columnNYISHIYH);
			
            this.columnVLINGYONGR = new DataColumn("VLINGYONGR", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVLINGYONGR.MaxLength = 20;
            this.columnVLINGYONGR.AllowDBNull = true;
            this.Columns.Add(this.columnVLINGYONGR);
			
            this.columnVJINGBANR = new DataColumn("VJINGBANR", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVJINGBANR.MaxLength = 20;
            this.columnVJINGBANR.AllowDBNull = true;
            this.Columns.Add(this.columnVJINGBANR);
			
            this.columnDLINGYONGRQ = new DataColumn("DLINGYONGRQ", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDLINGYONGRQ.AllowDBNull = false;
            this.Columns.Add(this.columnDLINGYONGRQ);
			
            this.columnVREMARKS = new DataColumn("VREMARKS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVREMARKS.MaxLength = 50;
            this.columnVREMARKS.AllowDBNull = true;
            this.Columns.Add(this.columnVREMARKS);
			
            this.columnVOPERATORID = new DataColumn("VOPERATORID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVOPERATORID.MaxLength = 20;
            this.columnVOPERATORID.AllowDBNull = false;
            this.Columns.Add(this.columnVOPERATORID);
			
            this.columnDOPERATORDATE = new DataColumn("DOPERATORDATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDOPERATORDATE.AllowDBNull = false;
            this.Columns.Add(this.columnDOPERATORDATE);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowGHSF_GHSF_NOTEMANAGE NewRowGHSF_GHSF_NOTEMANAGE() {
            return ((RowGHSF_GHSF_NOTEMANAGE)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowGHSF_GHSF_NOTEMANAGE(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowGHSF_GHSF_NOTEMANAGE);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedGHSF_GHSF_NOTEMANAGE != null)) {
                this.RowChangedGHSF_GHSF_NOTEMANAGE(this, new RowChangeEventGHSF_GHSF_NOTEMANAGE(((RowGHSF_GHSF_NOTEMANAGE)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingGHSF_GHSF_NOTEMANAGE != null)) {
                this.RowChangingGHSF_GHSF_NOTEMANAGE(this, new RowChangeEventGHSF_GHSF_NOTEMANAGE(((RowGHSF_GHSF_NOTEMANAGE)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedGHSF_GHSF_NOTEMANAGE != null)) {
                this.RowDeletedGHSF_GHSF_NOTEMANAGE(this, new RowChangeEventGHSF_GHSF_NOTEMANAGE(((RowGHSF_GHSF_NOTEMANAGE)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingGHSF_GHSF_NOTEMANAGE != null)) {
                this.RowDeletingGHSF_GHSF_NOTEMANAGE(this, new RowChangeEventGHSF_GHSF_NOTEMANAGE(((RowGHSF_GHSF_NOTEMANAGE)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowGHSF_GHSF_NOTEMANAGE(RowGHSF_GHSF_NOTEMANAGE row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowGHSF_GHSF_NOTEMANAGE
	/// 
	/// 数据表GHSF_GHSF_NOTEMANAGE行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowGHSF_GHSF_NOTEMANAGE : DataRow 
    {
        
        private DataTableGHSF_GHSF_NOTEMANAGE tableGHSF_GHSF_NOTEMANAGE;
        
        internal RowGHSF_GHSF_NOTEMANAGE(DataRowBuilder rb) : base(rb) 
        {
            this.tableGHSF_GHSF_NOTEMANAGE = ((DataTableGHSF_GHSF_NOTEMANAGE)(this.Table));
        }        
		
		/// 
		/// 字段VNOTEMANAGEID所映射的属性。
		/// 
        public System.String VNOTEMANAGEID
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnVNOTEMANAGEID])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnVNOTEMANAGEID] = value;
            }
        }
        
		/// 
		/// 字段NPIAOJVLB所映射的属性。
		/// 
        public System.Int32 NPIAOJVLB
        {
            get 
            {	
                return ((System.Int32)(this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnNPIAOJVLB])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnNPIAOJVLB] = value;
            }
        }
        
		/// 
		/// 字段NQISHIH所映射的属性。
		/// 
        public System.Decimal NQISHIH
        {
            get 
            {	
                return ((System.Decimal)(this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnNQISHIH])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnNQISHIH] = value;
            }
        }
        
		/// 
		/// 字段NZHONGZHIH所映射的属性。
		/// 
        public System.Decimal NZHONGZHIH
        {
            get 
            {	
                return ((System.Decimal)(this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnNZHONGZHIH])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnNZHONGZHIH] = value;
            }
        }
        
		/// 
		/// 字段NYISHIYH所映射的属性。
		/// 
        public System.Decimal NYISHIYH
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnNYISHIYH])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnNYISHIYH] = value;
            }
        }
        
		/// 
		/// 字段VLINGYONGR所映射的属性。
		/// 
        public System.String VLINGYONGR
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnVLINGYONGR])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnVLINGYONGR] = value;
            }
        }
        
		/// 
		/// 字段VJINGBANR所映射的属性。
		/// 
        public System.String VJINGBANR
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnVJINGBANR])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnVJINGBANR] = value;
            }
        }
        
		/// 
		/// 字段DLINGYONGRQ所映射的属性。
		/// 
        public System.DateTime DLINGYONGRQ
        {
            get 
            {	
                return ((System.DateTime)(this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnDLINGYONGRQ])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnDLINGYONGRQ] = value;
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
	                return ((System.String)(this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnVREMARKS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnVREMARKS] = value;
            }
        }
        
		/// 
		/// 字段VOPERATORID所映射的属性。
		/// 
        public System.String VOPERATORID
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnVOPERATORID])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnVOPERATORID] = value;
            }
        }
        
		/// 
		/// 字段DOPERATORDATE所映射的属性。
		/// 
        public System.DateTime DOPERATORDATE
        {
            get 
            {	
                return ((System.DateTime)(this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnDOPERATORDATE])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnDOPERATORDATE] = value;
            }
        }
        
		/// 
		/// 判断字段NYISHIYH是否为空。
		/// 
        public bool IsNYISHIYHNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_NOTEMANAGE.ColumnNYISHIYH);
        }

		/// 
		/// 设置字段NYISHIYH为空值。
		/// 
        public void SetNYISHIYHNull() 
        {
            this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnNYISHIYH] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VLINGYONGR是否为空。
		/// 
        public bool IsVLINGYONGRNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_NOTEMANAGE.ColumnVLINGYONGR);
        }

		/// 
		/// 设置字段VLINGYONGR为空值。
		/// 
        public void SetVLINGYONGRNull() 
        {
            this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnVLINGYONGR] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VJINGBANR是否为空。
		/// 
        public bool IsVJINGBANRNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_NOTEMANAGE.ColumnVJINGBANR);
        }

		/// 
		/// 设置字段VJINGBANR为空值。
		/// 
        public void SetVJINGBANRNull() 
        {
            this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnVJINGBANR] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VREMARKS是否为空。
		/// 
        public bool IsVREMARKSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_NOTEMANAGE.ColumnVREMARKS);
        }

		/// 
		/// 设置字段VREMARKS为空值。
		/// 
        public void SetVREMARKSNull() 
        {
            this[this.tableGHSF_GHSF_NOTEMANAGE.ColumnVREMARKS] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventGHSF_GHSF_NOTEMANAGE : EventArgs {
        
        private RowGHSF_GHSF_NOTEMANAGE eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventGHSF_GHSF_NOTEMANAGE(RowGHSF_GHSF_NOTEMANAGE row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowGHSF_GHSF_NOTEMANAGE Row {
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
	