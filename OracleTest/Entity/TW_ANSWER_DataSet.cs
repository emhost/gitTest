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
	#region DataSetTW_ANSWER
	/// 
	/// 对于TW_ANSWER的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetTW_ANSWER : DataSet
    {
		
		private DataTableTW_ANSWER tableTW_ANSWER;
		
        public DataSetTW_ANSWER() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetTW_ANSWER实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetTW_ANSWER GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetTW_ANSWER dataSet = (DataSetTW_ANSWER)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetTW_ANSWER entity = new DataSetTW_ANSWER();
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
        
        protected DataSetTW_ANSWER(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["TW_ANSWER"] != null)) 
                {
                    this.Tables.Add(new DataTableTW_ANSWER(ds.Tables["TW_ANSWER"]));
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
		/// 对于数据表TW_ANSWER的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableTW_ANSWER TW_ANSWER 
		{
			get
			{
				return this.tableTW_ANSWER;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetTW_ANSWER cln = ((DataSetTW_ANSWER)(base.Clone()));
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
			
			if ((ds.Tables["TW_ANSWER"] != null)) 
			{
				this.Tables.Add(new DataTableTW_ANSWER(ds.Tables["TW_ANSWER"]));
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
			
			this.tableTW_ANSWER = ((DataTableTW_ANSWER)(this.Tables["TW_ANSWER"]));
			if ((this.tableTW_ANSWER != null)) {
				this.tableTW_ANSWER.InitVars();
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
			
			this.tableTW_ANSWER = new DataTableTW_ANSWER();
			this.Tables.Add(this.tableTW_ANSWER);
			
		}
		
		private bool ShouldSerializeTW_ANSWER() 
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
	
    public delegate void RowChangeEventHandlerTW_ANSWER(object sender, RowChangeEventTW_ANSWER e);
	
	#region DataTableTW_ANSWER
	/// 
	/// 对于数据表TW_ANSWER的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableTW_ANSWER : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnIMG;
		
        private DataColumn columnNDEL;
		
        private DataColumn columnDMODIFY;
		
        private DataColumn columnVHUIFUID;
		
        private DataColumn columnVID;
		
        private DataColumn columnVQUESID;
		
        private DataColumn columnVCONTENT;
		
        private DataColumn columnDCREATE;
		
        private DataColumn columnVINPUTID;
		
        internal DataTableTW_ANSWER() : base("TW_ANSWER") 
        {
            this.InitClass();
        }
        
        internal DataTableTW_ANSWER(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnIMG 
        {
            get 
            {
                return this.columnIMG;
            }
        }
		
        public DataColumn ColumnNDEL 
        {
            get 
            {
                return this.columnNDEL;
            }
        }
		
        public DataColumn ColumnDMODIFY 
        {
            get 
            {
                return this.columnDMODIFY;
            }
        }
		
        public DataColumn ColumnVHUIFUID 
        {
            get 
            {
                return this.columnVHUIFUID;
            }
        }
		
        public DataColumn ColumnVID 
        {
            get 
            {
                return this.columnVID;
            }
        }
		
        public DataColumn ColumnVQUESID 
        {
            get 
            {
                return this.columnVQUESID;
            }
        }
		
        public DataColumn ColumnVCONTENT 
        {
            get 
            {
                return this.columnVCONTENT;
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
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowTW_ANSWER this[int index] 
        {
            get 
            {
                return ((RowTW_ANSWER)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerTW_ANSWER RowChangedTW_ANSWER;
        
        public event RowChangeEventHandlerTW_ANSWER RowChangingTW_ANSWER;
        
        public event RowChangeEventHandlerTW_ANSWER RowDeletedTW_ANSWER;
        
        public event RowChangeEventHandlerTW_ANSWER RowDeletingTW_ANSWER;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowTW_ANSWER(RowTW_ANSWER row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowTW_ANSWER AddRowTW_ANSWER(System.Byte[] IMG,System.Int16 NDEL,System.DateTime DMODIFY,System.String VHUIFUID,System.String VID,System.String VQUESID,System.String VCONTENT,System.DateTime DCREATE,System.String VINPUTID) 
        {
            RowTW_ANSWER row = ((RowTW_ANSWER)(this.NewRow()));
            row.ItemArray = new object[] {IMG,NDEL,DMODIFY,VHUIFUID,VID,VQUESID,VCONTENT,DCREATE,VINPUTID};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowTW_ANSWER FindByVID(System.String VID) {
            return ((RowTW_ANSWER)(this.Rows.Find(new object[] {
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
            DataTableTW_ANSWER cln = ((DataTableTW_ANSWER)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableTW_ANSWER();
        }
        
        internal void InitVars() 
        {	
            this.columnIMG = this.Columns["IMG"];
            this.columnNDEL = this.Columns["NDEL"];
            this.columnDMODIFY = this.Columns["DMODIFY"];
            this.columnVHUIFUID = this.Columns["VHUIFUID"];
            this.columnVID = this.Columns["VID"];
            this.columnVQUESID = this.Columns["VQUESID"];
            this.columnVCONTENT = this.Columns["VCONTENT"];
            this.columnDCREATE = this.Columns["DCREATE"];
            this.columnVINPUTID = this.Columns["VINPUTID"];
        }
        
        private void InitClass() 
        {	
            this.columnIMG = new DataColumn("IMG", typeof(System.Byte[]), null, System.Data.MappingType.Element);
            this.columnIMG.AllowDBNull = true;
            this.Columns.Add(this.columnIMG);
			
            this.columnNDEL = new DataColumn("NDEL", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNDEL.AllowDBNull = true;
            this.Columns.Add(this.columnNDEL);
			
            this.columnDMODIFY = new DataColumn("DMODIFY", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDMODIFY.AllowDBNull = true;
            this.Columns.Add(this.columnDMODIFY);
			
            this.columnVHUIFUID = new DataColumn("VHUIFUID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVHUIFUID.MaxLength = 36;
            this.columnVHUIFUID.AllowDBNull = true;
            this.Columns.Add(this.columnVHUIFUID);
			
            this.columnVID = new DataColumn("VID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVID.MaxLength = 36;
            this.columnVID.AllowDBNull = false;
            this.columnVID.Unique = true;
            
            this.Columns.Add(this.columnVID);
			
            this.columnVQUESID = new DataColumn("VQUESID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVQUESID.MaxLength = 36;
            this.columnVQUESID.AllowDBNull = false;
            this.Columns.Add(this.columnVQUESID);
			
            this.columnVCONTENT = new DataColumn("VCONTENT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCONTENT.MaxLength = 255;
            this.columnVCONTENT.AllowDBNull = true;
            this.Columns.Add(this.columnVCONTENT);
			
            this.columnDCREATE = new DataColumn("DCREATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDCREATE.AllowDBNull = false;
            this.Columns.Add(this.columnDCREATE);
			
            this.columnVINPUTID = new DataColumn("VINPUTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVINPUTID.MaxLength = 36;
            this.columnVINPUTID.AllowDBNull = true;
            this.Columns.Add(this.columnVINPUTID);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowTW_ANSWER NewRowTW_ANSWER() {
            return ((RowTW_ANSWER)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowTW_ANSWER(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowTW_ANSWER);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedTW_ANSWER != null)) {
                this.RowChangedTW_ANSWER(this, new RowChangeEventTW_ANSWER(((RowTW_ANSWER)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingTW_ANSWER != null)) {
                this.RowChangingTW_ANSWER(this, new RowChangeEventTW_ANSWER(((RowTW_ANSWER)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedTW_ANSWER != null)) {
                this.RowDeletedTW_ANSWER(this, new RowChangeEventTW_ANSWER(((RowTW_ANSWER)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingTW_ANSWER != null)) {
                this.RowDeletingTW_ANSWER(this, new RowChangeEventTW_ANSWER(((RowTW_ANSWER)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowTW_ANSWER(RowTW_ANSWER row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowTW_ANSWER
	/// 
	/// 数据表TW_ANSWER行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowTW_ANSWER : DataRow 
    {
        
        private DataTableTW_ANSWER tableTW_ANSWER;
        
        internal RowTW_ANSWER(DataRowBuilder rb) : base(rb) 
        {
            this.tableTW_ANSWER = ((DataTableTW_ANSWER)(this.Table));
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
	                return ((System.Byte[])(this[this.tableTW_ANSWER.ColumnIMG])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableTW_ANSWER.ColumnIMG] = value;
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
	                return ((System.Int16)(this[this.tableTW_ANSWER.ColumnNDEL])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableTW_ANSWER.ColumnNDEL] = value;
            }
        }
        
		/// 
		/// 字段DMODIFY所映射的属性。
		/// 
        public System.DateTime DMODIFY
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableTW_ANSWER.ColumnDMODIFY])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableTW_ANSWER.ColumnDMODIFY] = value;
            }
        }
        
		/// 
		/// 字段VHUIFUID所映射的属性。
		/// 
        public System.String VHUIFUID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTW_ANSWER.ColumnVHUIFUID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTW_ANSWER.ColumnVHUIFUID] = value;
            }
        }
        
		/// 
		/// 字段VID所映射的属性。
		/// 
        public System.String VID
        {
            get 
            {	
                return ((System.String)(this[this.tableTW_ANSWER.ColumnVID])); 
            }
            set 
            {
                this[this.tableTW_ANSWER.ColumnVID] = value;
            }
        }
        
		/// 
		/// 字段VQUESID所映射的属性。
		/// 
        public System.String VQUESID
        {
            get 
            {	
                return ((System.String)(this[this.tableTW_ANSWER.ColumnVQUESID])); 
            }
            set 
            {
                this[this.tableTW_ANSWER.ColumnVQUESID] = value;
            }
        }
        
		/// 
		/// 字段VCONTENT所映射的属性。
		/// 
        public System.String VCONTENT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableTW_ANSWER.ColumnVCONTENT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTW_ANSWER.ColumnVCONTENT] = value;
            }
        }
        
		/// 
		/// 字段DCREATE所映射的属性。
		/// 
        public System.DateTime DCREATE
        {
            get 
            {	
                return ((System.DateTime)(this[this.tableTW_ANSWER.ColumnDCREATE])); 
            }
            set 
            {
                this[this.tableTW_ANSWER.ColumnDCREATE] = value;
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
	                return ((System.String)(this[this.tableTW_ANSWER.ColumnVINPUTID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableTW_ANSWER.ColumnVINPUTID] = value;
            }
        }
        
		/// 
		/// 判断字段IMG是否为空。
		/// 
        public bool IsIMGNull()
        {
            return this.IsNull(this.tableTW_ANSWER.ColumnIMG);
        }

		/// 
		/// 设置字段IMG为空值。
		/// 
        public void SetIMGNull() 
        {
            this[this.tableTW_ANSWER.ColumnIMG] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NDEL是否为空。
		/// 
        public bool IsNDELNull()
        {
            return this.IsNull(this.tableTW_ANSWER.ColumnNDEL);
        }

		/// 
		/// 设置字段NDEL为空值。
		/// 
        public void SetNDELNull() 
        {
            this[this.tableTW_ANSWER.ColumnNDEL] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DMODIFY是否为空。
		/// 
        public bool IsDMODIFYNull()
        {
            return this.IsNull(this.tableTW_ANSWER.ColumnDMODIFY);
        }

		/// 
		/// 设置字段DMODIFY为空值。
		/// 
        public void SetDMODIFYNull() 
        {
            this[this.tableTW_ANSWER.ColumnDMODIFY] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VHUIFUID是否为空。
		/// 
        public bool IsVHUIFUIDNull()
        {
            return this.IsNull(this.tableTW_ANSWER.ColumnVHUIFUID);
        }

		/// 
		/// 设置字段VHUIFUID为空值。
		/// 
        public void SetVHUIFUIDNull() 
        {
            this[this.tableTW_ANSWER.ColumnVHUIFUID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VCONTENT是否为空。
		/// 
        public bool IsVCONTENTNull()
        {
            return this.IsNull(this.tableTW_ANSWER.ColumnVCONTENT);
        }

		/// 
		/// 设置字段VCONTENT为空值。
		/// 
        public void SetVCONTENTNull() 
        {
            this[this.tableTW_ANSWER.ColumnVCONTENT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VINPUTID是否为空。
		/// 
        public bool IsVINPUTIDNull()
        {
            return this.IsNull(this.tableTW_ANSWER.ColumnVINPUTID);
        }

		/// 
		/// 设置字段VINPUTID为空值。
		/// 
        public void SetVINPUTIDNull() 
        {
            this[this.tableTW_ANSWER.ColumnVINPUTID] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventTW_ANSWER : EventArgs {
        
        private RowTW_ANSWER eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventTW_ANSWER(RowTW_ANSWER row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowTW_ANSWER Row {
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
	