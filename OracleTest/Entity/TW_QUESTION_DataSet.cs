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
	#region DataSetTW_QUESTION
	/// 
	/// 对于TW_QUESTION的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetTW_QUESTION : DataSet
    {
		
		private DataTableTW_QUESTION tableTW_QUESTION;
		
        public DataSetTW_QUESTION() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetTW_QUESTION实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetTW_QUESTION GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetTW_QUESTION dataSet = (DataSetTW_QUESTION)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetTW_QUESTION entity = new DataSetTW_QUESTION();
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
        
        protected DataSetTW_QUESTION(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["TW_QUESTION"] != null)) 
                {
                    this.Tables.Add(new DataTableTW_QUESTION(ds.Tables["TW_QUESTION"]));
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
		/// 对于数据表TW_QUESTION的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableTW_QUESTION TW_QUESTION 
		{
			get
			{
				return this.tableTW_QUESTION;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetTW_QUESTION cln = ((DataSetTW_QUESTION)(base.Clone()));
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
			
			if ((ds.Tables["TW_QUESTION"] != null)) 
			{
				this.Tables.Add(new DataTableTW_QUESTION(ds.Tables["TW_QUESTION"]));
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
			
			this.tableTW_QUESTION = ((DataTableTW_QUESTION)(this.Tables["TW_QUESTION"]));
			if ((this.tableTW_QUESTION != null)) {
				this.tableTW_QUESTION.InitVars();
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
			
			this.tableTW_QUESTION = new DataTableTW_QUESTION();
			this.Tables.Add(this.tableTW_QUESTION);
			
		}
		
		private bool ShouldSerializeTW_QUESTION() 
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
	
    public delegate void RowChangeEventHandlerTW_QUESTION(object sender, RowChangeEventTW_QUESTION e);
	
	#region DataTableTW_QUESTION
	/// 
	/// 对于数据表TW_QUESTION的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableTW_QUESTION : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVID;
		
        private DataColumn columnVTITLE;
		
        private DataColumn columnVDETAIL;
		
        private DataColumn columnDCREATE;
		
        private DataColumn columnVINPUTID;
		
        private DataColumn columnIMG;
		
        private DataColumn columnNSTATUS;
		
        private DataColumn columnNDEL;
		
        internal DataTableTW_QUESTION() : base("TW_QUESTION") 
        {
            this.InitClass();
        }
        
        internal DataTableTW_QUESTION(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVTITLE 
        {
            get 
            {
                return this.columnVTITLE;
            }
        }
		
        public DataColumn ColumnVDETAIL 
        {
            get 
            {
                return this.columnVDETAIL;
            }
        }
		
        public DataColumn ColumnDCREATE 
        {
            get 
            {
                return this.columnDCREATE;
            }
        }
		
        public DataColumn ColumnVINPUTID 
        {
            get 
            {
                return this.columnVINPUTID;
            }
        }
		
        public DataColumn ColumnIMG 
        {
            get 
            {
                return this.columnIMG;
            }
        }
		
        public DataColumn ColumnNSTATUS 
        {
            get 
            {
                return this.columnNSTATUS;
            }
        }
		
        public DataColumn ColumnNDEL 
        {
            get 
            {
                return this.columnNDEL;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowTW_QUESTION this[int index] 
        {
            get 
            {
                return ((RowTW_QUESTION)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerTW_QUESTION RowChangedTW_QUESTION;
        
        public event RowChangeEventHandlerTW_QUESTION RowChangingTW_QUESTION;
        
        public event RowChangeEventHandlerTW_QUESTION RowDeletedTW_QUESTION;
        
        public event RowChangeEventHandlerTW_QUESTION RowDeletingTW_QUESTION;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowTW_QUESTION(RowTW_QUESTION row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowTW_QUESTION AddRowTW_QUESTION(System.String VID,System.String VTITLE,System.String VDETAIL,System.DateTime DCREATE,System.String VINPUTID,System.Byte[] IMG,System.Int16 NSTATUS,System.Int16 NDEL) 
        {
            RowTW_QUESTION row = ((RowTW_QUESTION)(this.NewRow()));
            row.ItemArray = new object[] {VID,VTITLE,VDETAIL,DCREATE,VINPUTID,IMG,NSTATUS,NDEL};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowTW_QUESTION FindByVID(System.String VID) {
            return ((RowTW_QUESTION)(this.Rows.Find(new object[] {
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
            DataTableTW_QUESTION cln = ((DataTableTW_QUESTION)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableTW_QUESTION();
        }
        
        internal void InitVars() 
        {	
            this.columnVID = this.Columns["VID"];
            this.columnVTITLE = this.Columns["VTITLE"];
            this.columnVDETAIL = this.Columns["VDETAIL"];
            this.columnDCREATE = this.Columns["DCREATE"];
            this.columnVINPUTID = this.Columns["VINPUTID"];
            this.columnIMG = this.Columns["IMG"];
            this.columnNSTATUS = this.Columns["NSTATUS"];
            this.columnNDEL = this.Columns["NDEL"];
        }
        
        private void InitClass() 
        {	
            this.columnVID = new DataColumn("VID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVID.MaxLength = 36;
            this.columnVID.AllowDBNull = false;
            this.columnVID.Unique = true;
            
            this.Columns.Add(this.columnVID);
			
            this.columnVTITLE = new DataColumn("VTITLE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVTITLE.MaxLength = 20;
            this.columnVTITLE.AllowDBNull = false;
            this.Columns.Add(this.columnVTITLE);
			
            this.columnVDETAIL = new DataColumn("VDETAIL", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDETAIL.MaxLength = 255;
            this.columnVDETAIL.AllowDBNull = true;
            this.Columns.Add(this.columnVDETAIL);
			
            this.columnDCREATE = new DataColumn("DCREATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDCREATE.AllowDBNull = false;
            this.Columns.Add(this.columnDCREATE);
			
            this.columnVINPUTID = new DataColumn("VINPUTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVINPUTID.MaxLength = 36;
            this.columnVINPUTID.AllowDBNull = true;
            this.Columns.Add(this.columnVINPUTID);
			
            this.columnIMG = new DataColumn("IMG", typeof(System.Byte[]), null, System.Data.MappingType.Element);
            this.columnIMG.AllowDBNull = true;
            this.Columns.Add(this.columnIMG);
			
            this.columnNSTATUS = new DataColumn("NSTATUS", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNSTATUS.DefaultValue = "0";
            this.columnNSTATUS.AllowDBNull = true;
            this.Columns.Add(this.columnNSTATUS);
			
            this.columnNDEL = new DataColumn("NDEL", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNDEL.DefaultValue = "0";
            this.columnNDEL.AllowDBNull = true;
            this.Columns.Add(this.columnNDEL);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowTW_QUESTION NewRowTW_QUESTION() {
            return ((RowTW_QUESTION)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowTW_QUESTION(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowTW_QUESTION);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedTW_QUESTION != null)) {
                this.RowChangedTW_QUESTION(this, new RowChangeEventTW_QUESTION(((RowTW_QUESTION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingTW_QUESTION != null)) {
                this.RowChangingTW_QUESTION(this, new RowChangeEventTW_QUESTION(((RowTW_QUESTION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedTW_QUESTION != null)) {
                this.RowDeletedTW_QUESTION(this, new RowChangeEventTW_QUESTION(((RowTW_QUESTION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingTW_QUESTION != null)) {
                this.RowDeletingTW_QUESTION(this, new RowChangeEventTW_QUESTION(((RowTW_QUESTION)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowTW_QUESTION(RowTW_QUESTION row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowTW_QUESTION
	/// 
	/// 数据表TW_QUESTION行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowTW_QUESTION : DataRow 
    {
        
        private DataTableTW_QUESTION tableTW_QUESTION;
        
        internal RowTW_QUESTION(DataRowBuilder rb) : base(rb) 
        {
            this.tableTW_QUESTION = ((DataTableTW_QUESTION)(this.Table));
        }        
		
		/// 
		/// 字段VID所映射的属性。
		/// 
        public System.String VID
        {
            get 
            {	
                return ((System.String)(this[this.tableTW_QUESTION.ColumnVID])); 
            }
            set 
            {
                this[this.tableTW_QUESTION.ColumnVID] = value;
            }
        }
        
		/// 
		/// 字段VTITLE所映射的属性。
		/// 
        public System.String VTITLE
        {
            get 
            {	
                return ((System.String)(this[this.tableTW_QUESTION.ColumnVTITLE])); 
            }
            set 
            {
                this[this.tableTW_QUESTION.ColumnVTITLE] = value;
            }
        }
        
		/// 
		/// 字段VDETAIL所映射的属性。
		/// 
        public System.String VDETAIL
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTW_QUESTION.ColumnVDETAIL])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTW_QUESTION.ColumnVDETAIL] = value;
            }
        }
        
		/// 
		/// 字段DCREATE所映射的属性。
		/// 
        public System.DateTime DCREATE
        {
            get 
            {	
                return ((System.DateTime)(this[this.tableTW_QUESTION.ColumnDCREATE])); 
            }
            set 
            {
                this[this.tableTW_QUESTION.ColumnDCREATE] = value;
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
	                return ((System.String)(this[this.tableTW_QUESTION.ColumnVINPUTID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTW_QUESTION.ColumnVINPUTID] = value;
            }
        }
        
		/// 
		/// 字段IMG所映射的属性。
		/// 
        public System.Byte[] IMG
        {
            get 
            {	
                try 
                {
	                return ((System.Byte[])(this[this.tableTW_QUESTION.ColumnIMG])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableTW_QUESTION.ColumnIMG] = value;
            }
        }
        
		/// 
		/// 字段NSTATUS所映射的属性。
		/// 
        public System.Int16 NSTATUS
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableTW_QUESTION.ColumnNSTATUS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableTW_QUESTION.ColumnNSTATUS] = value;
            }
        }
        
		/// 
		/// 字段NDEL所映射的属性。
		/// 
        public System.Int16 NDEL
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableTW_QUESTION.ColumnNDEL])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableTW_QUESTION.ColumnNDEL] = value;
            }
        }
        
		/// 
		/// 判断字段VDETAIL是否为空。
		/// 
        public bool IsVDETAILNull()
        {
            return this.IsNull(this.tableTW_QUESTION.ColumnVDETAIL);
        }

		/// 
		/// 设置字段VDETAIL为空值。
		/// 
        public void SetVDETAILNull() 
        {
            this[this.tableTW_QUESTION.ColumnVDETAIL] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VINPUTID是否为空。
		/// 
        public bool IsVINPUTIDNull()
        {
            return this.IsNull(this.tableTW_QUESTION.ColumnVINPUTID);
        }

		/// 
		/// 设置字段VINPUTID为空值。
		/// 
        public void SetVINPUTIDNull() 
        {
            this[this.tableTW_QUESTION.ColumnVINPUTID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段IMG是否为空。
		/// 
        public bool IsIMGNull()
        {
            return this.IsNull(this.tableTW_QUESTION.ColumnIMG);
        }

		/// 
		/// 设置字段IMG为空值。
		/// 
        public void SetIMGNull() 
        {
            this[this.tableTW_QUESTION.ColumnIMG] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSTATUS是否为空。
		/// 
        public bool IsNSTATUSNull()
        {
            return this.IsNull(this.tableTW_QUESTION.ColumnNSTATUS);
        }

		/// 
		/// 设置字段NSTATUS为空值。
		/// 
        public void SetNSTATUSNull() 
        {
            this[this.tableTW_QUESTION.ColumnNSTATUS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NDEL是否为空。
		/// 
        public bool IsNDELNull()
        {
            return this.IsNull(this.tableTW_QUESTION.ColumnNDEL);
        }

		/// 
		/// 设置字段NDEL为空值。
		/// 
        public void SetNDELNull() 
        {
            this[this.tableTW_QUESTION.ColumnNDEL] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventTW_QUESTION : EventArgs {
        
        private RowTW_QUESTION eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventTW_QUESTION(RowTW_QUESTION row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowTW_QUESTION Row {
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
	