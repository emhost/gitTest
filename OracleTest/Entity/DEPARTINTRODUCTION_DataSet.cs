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
	#region DataSetDEPARTINTRODUCTION
	/// 
	/// 对于DEPARTINTRODUCTION的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetDEPARTINTRODUCTION : DataSet
    {
		
		private DataTableYWAPP_DEPART_INTRODUCTION tableYWAPP_DEPART_INTRODUCTION;
		
        public DataSetDEPARTINTRODUCTION() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetDEPARTINTRODUCTION实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetDEPARTINTRODUCTION GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetDEPARTINTRODUCTION dataSet = (DataSetDEPARTINTRODUCTION)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetDEPARTINTRODUCTION entity = new DataSetDEPARTINTRODUCTION();
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
        
        protected DataSetDEPARTINTRODUCTION(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["YWAPP_DEPART_INTRODUCTION"] != null)) 
                {
                    this.Tables.Add(new DataTableYWAPP_DEPART_INTRODUCTION(ds.Tables["YWAPP_DEPART_INTRODUCTION"]));
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
		/// 对于数据表YWAPP_DEPART_INTRODUCTION的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableYWAPP_DEPART_INTRODUCTION YWAPP_DEPART_INTRODUCTION 
		{
			get
			{
				return this.tableYWAPP_DEPART_INTRODUCTION;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetDEPARTINTRODUCTION cln = ((DataSetDEPARTINTRODUCTION)(base.Clone()));
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
			
			if ((ds.Tables["YWAPP_DEPART_INTRODUCTION"] != null)) 
			{
				this.Tables.Add(new DataTableYWAPP_DEPART_INTRODUCTION(ds.Tables["YWAPP_DEPART_INTRODUCTION"]));
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
			
			this.tableYWAPP_DEPART_INTRODUCTION = ((DataTableYWAPP_DEPART_INTRODUCTION)(this.Tables["YWAPP_DEPART_INTRODUCTION"]));
			if ((this.tableYWAPP_DEPART_INTRODUCTION != null)) {
				this.tableYWAPP_DEPART_INTRODUCTION.InitVars();
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
			
			this.tableYWAPP_DEPART_INTRODUCTION = new DataTableYWAPP_DEPART_INTRODUCTION();
			this.Tables.Add(this.tableYWAPP_DEPART_INTRODUCTION);
			
		}
		
		private bool ShouldSerializeYWAPP_DEPART_INTRODUCTION() 
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
	
    public delegate void RowChangeEventHandlerYWAPP_DEPART_INTRODUCTION(object sender, RowChangeEventYWAPP_DEPART_INTRODUCTION e);
	
	#region DataTableYWAPP_DEPART_INTRODUCTION
	/// 
	/// 对于数据表YWAPP_DEPART_INTRODUCTION的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableYWAPP_DEPART_INTRODUCTION : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnID;
		
        private DataColumn columnVDEPARTMENTCODE;
		
        private DataColumn columnINTRODUCTION;
		
        private DataColumn columnREMARKS;
		
        private DataColumn columnISENABLE;
		
        private DataColumn columnPHOTO;
		
        internal DataTableYWAPP_DEPART_INTRODUCTION() : base("YWAPP_DEPART_INTRODUCTION") 
        {
            this.InitClass();
        }
        
        internal DataTableYWAPP_DEPART_INTRODUCTION(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVDEPARTMENTCODE 
        {
            get 
            {
                return this.columnVDEPARTMENTCODE;
            }
        }
		
        public DataColumn ColumnINTRODUCTION 
        {
            get 
            {
                return this.columnINTRODUCTION;
            }
        }
		
        public DataColumn ColumnREMARKS 
        {
            get 
            {
                return this.columnREMARKS;
            }
        }
		
        public DataColumn ColumnISENABLE 
        {
            get 
            {
                return this.columnISENABLE;
            }
        }
		
        public DataColumn ColumnPHOTO 
        {
            get 
            {
                return this.columnPHOTO;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowYWAPP_DEPART_INTRODUCTION this[int index] 
        {
            get 
            {
                return ((RowYWAPP_DEPART_INTRODUCTION)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerYWAPP_DEPART_INTRODUCTION RowChangedYWAPP_DEPART_INTRODUCTION;
        
        public event RowChangeEventHandlerYWAPP_DEPART_INTRODUCTION RowChangingYWAPP_DEPART_INTRODUCTION;
        
        public event RowChangeEventHandlerYWAPP_DEPART_INTRODUCTION RowDeletedYWAPP_DEPART_INTRODUCTION;
        
        public event RowChangeEventHandlerYWAPP_DEPART_INTRODUCTION RowDeletingYWAPP_DEPART_INTRODUCTION;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowYWAPP_DEPART_INTRODUCTION(RowYWAPP_DEPART_INTRODUCTION row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowYWAPP_DEPART_INTRODUCTION AddRowYWAPP_DEPART_INTRODUCTION(System.String ID,System.String VDEPARTMENTCODE,System.String INTRODUCTION,System.String REMARKS,System.Int16 ISENABLE,System.Byte[] PHOTO) 
        {
            RowYWAPP_DEPART_INTRODUCTION row = ((RowYWAPP_DEPART_INTRODUCTION)(this.NewRow()));
            row.ItemArray = new object[] {ID,VDEPARTMENTCODE,INTRODUCTION,REMARKS,ISENABLE,PHOTO};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowYWAPP_DEPART_INTRODUCTION FindByID(System.String ID) {
            return ((RowYWAPP_DEPART_INTRODUCTION)(this.Rows.Find(new object[] {
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
            DataTableYWAPP_DEPART_INTRODUCTION cln = ((DataTableYWAPP_DEPART_INTRODUCTION)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableYWAPP_DEPART_INTRODUCTION();
        }
        
        internal void InitVars() 
        {	
            this.columnID = this.Columns["ID"];
            this.columnVDEPARTMENTCODE = this.Columns["VDEPARTMENTCODE"];
            this.columnINTRODUCTION = this.Columns["INTRODUCTION"];
            this.columnREMARKS = this.Columns["REMARKS"];
            this.columnISENABLE = this.Columns["ISENABLE"];
            this.columnPHOTO = this.Columns["PHOTO"];
        }
        
        private void InitClass() 
        {	
            this.columnID = new DataColumn("ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnID.MaxLength = 36;
            this.columnID.AllowDBNull = false;
            this.columnID.Unique = true;
            
            this.Columns.Add(this.columnID);
			
            this.columnVDEPARTMENTCODE = new DataColumn("VDEPARTMENTCODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPARTMENTCODE.MaxLength = 36;
            this.columnVDEPARTMENTCODE.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPARTMENTCODE);
			
            this.columnINTRODUCTION = new DataColumn("INTRODUCTION", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnINTRODUCTION.MaxLength = 200;
            this.columnINTRODUCTION.AllowDBNull = true;
            this.Columns.Add(this.columnINTRODUCTION);
			
            this.columnREMARKS = new DataColumn("REMARKS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnREMARKS.MaxLength = 100;
            this.columnREMARKS.AllowDBNull = true;
            this.Columns.Add(this.columnREMARKS);
			
            this.columnISENABLE = new DataColumn("ISENABLE", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnISENABLE.DefaultValue = "0";
            this.columnISENABLE.AllowDBNull = true;
            this.Columns.Add(this.columnISENABLE);
			
            this.columnPHOTO = new DataColumn("PHOTO", typeof(System.Byte[]), null, System.Data.MappingType.Element);
            this.columnPHOTO.AllowDBNull = true;
            this.Columns.Add(this.columnPHOTO);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowYWAPP_DEPART_INTRODUCTION NewRowYWAPP_DEPART_INTRODUCTION() {
            return ((RowYWAPP_DEPART_INTRODUCTION)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowYWAPP_DEPART_INTRODUCTION(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowYWAPP_DEPART_INTRODUCTION);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedYWAPP_DEPART_INTRODUCTION != null)) {
                this.RowChangedYWAPP_DEPART_INTRODUCTION(this, new RowChangeEventYWAPP_DEPART_INTRODUCTION(((RowYWAPP_DEPART_INTRODUCTION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingYWAPP_DEPART_INTRODUCTION != null)) {
                this.RowChangingYWAPP_DEPART_INTRODUCTION(this, new RowChangeEventYWAPP_DEPART_INTRODUCTION(((RowYWAPP_DEPART_INTRODUCTION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedYWAPP_DEPART_INTRODUCTION != null)) {
                this.RowDeletedYWAPP_DEPART_INTRODUCTION(this, new RowChangeEventYWAPP_DEPART_INTRODUCTION(((RowYWAPP_DEPART_INTRODUCTION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingYWAPP_DEPART_INTRODUCTION != null)) {
                this.RowDeletingYWAPP_DEPART_INTRODUCTION(this, new RowChangeEventYWAPP_DEPART_INTRODUCTION(((RowYWAPP_DEPART_INTRODUCTION)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowYWAPP_DEPART_INTRODUCTION(RowYWAPP_DEPART_INTRODUCTION row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowYWAPP_DEPART_INTRODUCTION
	/// 
	/// 数据表YWAPP_DEPART_INTRODUCTION行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowYWAPP_DEPART_INTRODUCTION : DataRow 
    {
        
        private DataTableYWAPP_DEPART_INTRODUCTION tableYWAPP_DEPART_INTRODUCTION;
        
        internal RowYWAPP_DEPART_INTRODUCTION(DataRowBuilder rb) : base(rb) 
        {
            this.tableYWAPP_DEPART_INTRODUCTION = ((DataTableYWAPP_DEPART_INTRODUCTION)(this.Table));
        }        
		
		/// 
		/// 字段ID所映射的属性。
		/// 
        public System.String ID
        {
            get 
            {	
                return ((System.String)(this[this.tableYWAPP_DEPART_INTRODUCTION.ColumnID])); 
            }
            set 
            {
                this[this.tableYWAPP_DEPART_INTRODUCTION.ColumnID] = value;
            }
        }
        
		/// 
		/// 字段VDEPARTMENTCODE所映射的属性。
		/// 
        public System.String VDEPARTMENTCODE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableYWAPP_DEPART_INTRODUCTION.ColumnVDEPARTMENTCODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_DEPART_INTRODUCTION.ColumnVDEPARTMENTCODE] = value;
            }
        }
        
		/// 
		/// 字段INTRODUCTION所映射的属性。
		/// 
        public System.String INTRODUCTION
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableYWAPP_DEPART_INTRODUCTION.ColumnINTRODUCTION])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_DEPART_INTRODUCTION.ColumnINTRODUCTION] = value;
            }
        }
        
		/// 
		/// 字段REMARKS所映射的属性。
		/// 
        public System.String REMARKS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableYWAPP_DEPART_INTRODUCTION.ColumnREMARKS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_DEPART_INTRODUCTION.ColumnREMARKS] = value;
            }
        }
        
		/// 
		/// 字段ISENABLE所映射的属性。
		/// 
        public System.Int16 ISENABLE
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableYWAPP_DEPART_INTRODUCTION.ColumnISENABLE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_DEPART_INTRODUCTION.ColumnISENABLE] = value;
            }
        }
        
		/// 
		/// 字段PHOTO所映射的属性。
		/// 
        public System.Byte[] PHOTO
        {
            get 
            {	
                try 
                {
	                return ((System.Byte[])(this[this.tableYWAPP_DEPART_INTRODUCTION.ColumnPHOTO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableYWAPP_DEPART_INTRODUCTION.ColumnPHOTO] = value;
            }
        }
        
		/// 
		/// 判断字段VDEPARTMENTCODE是否为空。
		/// 
        public bool IsVDEPARTMENTCODENull()
        {
            return this.IsNull(this.tableYWAPP_DEPART_INTRODUCTION.ColumnVDEPARTMENTCODE);
        }

		/// 
		/// 设置字段VDEPARTMENTCODE为空值。
		/// 
        public void SetVDEPARTMENTCODENull() 
        {
            this[this.tableYWAPP_DEPART_INTRODUCTION.ColumnVDEPARTMENTCODE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段INTRODUCTION是否为空。
		/// 
        public bool IsINTRODUCTIONNull()
        {
            return this.IsNull(this.tableYWAPP_DEPART_INTRODUCTION.ColumnINTRODUCTION);
        }

		/// 
		/// 设置字段INTRODUCTION为空值。
		/// 
        public void SetINTRODUCTIONNull() 
        {
            this[this.tableYWAPP_DEPART_INTRODUCTION.ColumnINTRODUCTION] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段REMARKS是否为空。
		/// 
        public bool IsREMARKSNull()
        {
            return this.IsNull(this.tableYWAPP_DEPART_INTRODUCTION.ColumnREMARKS);
        }

		/// 
		/// 设置字段REMARKS为空值。
		/// 
        public void SetREMARKSNull() 
        {
            this[this.tableYWAPP_DEPART_INTRODUCTION.ColumnREMARKS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段ISENABLE是否为空。
		/// 
        public bool IsISENABLENull()
        {
            return this.IsNull(this.tableYWAPP_DEPART_INTRODUCTION.ColumnISENABLE);
        }

		/// 
		/// 设置字段ISENABLE为空值。
		/// 
        public void SetISENABLENull() 
        {
            this[this.tableYWAPP_DEPART_INTRODUCTION.ColumnISENABLE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段PHOTO是否为空。
		/// 
        public bool IsPHOTONull()
        {
            return this.IsNull(this.tableYWAPP_DEPART_INTRODUCTION.ColumnPHOTO);
        }

		/// 
		/// 设置字段PHOTO为空值。
		/// 
        public void SetPHOTONull() 
        {
            this[this.tableYWAPP_DEPART_INTRODUCTION.ColumnPHOTO] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventYWAPP_DEPART_INTRODUCTION : EventArgs {
        
        private RowYWAPP_DEPART_INTRODUCTION eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventYWAPP_DEPART_INTRODUCTION(RowYWAPP_DEPART_INTRODUCTION row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowYWAPP_DEPART_INTRODUCTION Row {
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
	