//------------------------------------------------------------------------------
//     这部分代码属于实体定义层，是由实体编辑器工具自动产生的。
//     (Runtime Version: 2.2017.3.2)
//     对此代码进行的任何修改会导致其它的行为错误，并且重新生成时所有的修改会丢失。
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Xml;
using System.Runtime.Serialization;

namespace hyApp.Entity
{
	#region DataSetDOCTORINTRODUCTION
	/// 
	/// 对于DOCTORINTRODUCTION的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetDOCTORINTRODUCTION : DataSet
    {
		
		private DataTableYWAPP_DOCTOR_INTRODUCTION tableYWAPP_DOCTOR_INTRODUCTION;
		
        public DataSetDOCTORINTRODUCTION() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetDOCTORINTRODUCTION实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetDOCTORINTRODUCTION GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetDOCTORINTRODUCTION dataSet = (DataSetDOCTORINTRODUCTION)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetDOCTORINTRODUCTION entity = new DataSetDOCTORINTRODUCTION();
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
        
        protected DataSetDOCTORINTRODUCTION(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["YWAPP_DOCTOR_INTRODUCTION"] != null)) 
                {
                    this.Tables.Add(new DataTableYWAPP_DOCTOR_INTRODUCTION(ds.Tables["YWAPP_DOCTOR_INTRODUCTION"]));
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
		/// 对于数据表YWAPP_DOCTOR_INTRODUCTION的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableYWAPP_DOCTOR_INTRODUCTION YWAPP_DOCTOR_INTRODUCTION 
		{
			get
			{
				return this.tableYWAPP_DOCTOR_INTRODUCTION;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetDOCTORINTRODUCTION cln = ((DataSetDOCTORINTRODUCTION)(base.Clone()));
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
			
			if ((ds.Tables["YWAPP_DOCTOR_INTRODUCTION"] != null)) 
			{
				this.Tables.Add(new DataTableYWAPP_DOCTOR_INTRODUCTION(ds.Tables["YWAPP_DOCTOR_INTRODUCTION"]));
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
			
			this.tableYWAPP_DOCTOR_INTRODUCTION = ((DataTableYWAPP_DOCTOR_INTRODUCTION)(this.Tables["YWAPP_DOCTOR_INTRODUCTION"]));
			if ((this.tableYWAPP_DOCTOR_INTRODUCTION != null)) {
				this.tableYWAPP_DOCTOR_INTRODUCTION.InitVars();
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
			
			this.tableYWAPP_DOCTOR_INTRODUCTION = new DataTableYWAPP_DOCTOR_INTRODUCTION();
			this.Tables.Add(this.tableYWAPP_DOCTOR_INTRODUCTION);
			
		}
		
		private bool ShouldSerializeYWAPP_DOCTOR_INTRODUCTION() 
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
	
    public delegate void RowChangeEventHandlerYWAPP_DOCTOR_INTRODUCTION(object sender, RowChangeEventYWAPP_DOCTOR_INTRODUCTION e);
	
	#region DataTableYWAPP_DOCTOR_INTRODUCTION
	/// 
	/// 对于数据表YWAPP_DOCTOR_INTRODUCTION的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableYWAPP_DOCTOR_INTRODUCTION : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVGOODAT;
		
        private DataColumn columnID;
		
        private DataColumn columnVSTAFFCODE;
		
        private DataColumn columnDOCTORINTRODUCTION;
		
        private DataColumn columnREMARKS;
		
        private DataColumn columnISENABLE;
		
        private DataColumn columnSPECIALTY;
		
        private DataColumn columnPOSITION;
		
        private DataColumn columnPHOTO;
		
        private DataColumn columnVDEPARTCODE;
		
        internal DataTableYWAPP_DOCTOR_INTRODUCTION() : base("YWAPP_DOCTOR_INTRODUCTION") 
        {
            this.InitClass();
        }
        
        internal DataTableYWAPP_DOCTOR_INTRODUCTION(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVGOODAT 
        {
            get 
            {
                return this.columnVGOODAT;
            }
        }
		
        public DataColumn ColumnID 
        {
            get 
            {
                return this.columnID;
            }
        }
		
        public DataColumn ColumnVSTAFFCODE 
        {
            get 
            {
                return this.columnVSTAFFCODE;
            }
        }
		
        public DataColumn ColumnDOCTORINTRODUCTION 
        {
            get 
            {
                return this.columnDOCTORINTRODUCTION;
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
		
        public DataColumn ColumnSPECIALTY 
        {
            get 
            {
                return this.columnSPECIALTY;
            }
        }
		
        public DataColumn ColumnPOSITION 
        {
            get 
            {
                return this.columnPOSITION;
            }
        }
		
        public DataColumn ColumnPHOTO 
        {
            get 
            {
                return this.columnPHOTO;
            }
        }
		
        public DataColumn ColumnVDEPARTCODE 
        {
            get 
            {
                return this.columnVDEPARTCODE;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowYWAPP_DOCTOR_INTRODUCTION this[int index] 
        {
            get 
            {
                return ((RowYWAPP_DOCTOR_INTRODUCTION)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerYWAPP_DOCTOR_INTRODUCTION RowChangedYWAPP_DOCTOR_INTRODUCTION;
        
        public event RowChangeEventHandlerYWAPP_DOCTOR_INTRODUCTION RowChangingYWAPP_DOCTOR_INTRODUCTION;
        
        public event RowChangeEventHandlerYWAPP_DOCTOR_INTRODUCTION RowDeletedYWAPP_DOCTOR_INTRODUCTION;
        
        public event RowChangeEventHandlerYWAPP_DOCTOR_INTRODUCTION RowDeletingYWAPP_DOCTOR_INTRODUCTION;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowYWAPP_DOCTOR_INTRODUCTION(RowYWAPP_DOCTOR_INTRODUCTION row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowYWAPP_DOCTOR_INTRODUCTION AddRowYWAPP_DOCTOR_INTRODUCTION(System.String VGOODAT,System.String ID,System.String VSTAFFCODE,System.String DOCTORINTRODUCTION,System.String REMARKS,System.Int16 ISENABLE,System.String SPECIALTY,System.String POSITION,System.Byte[] PHOTO,System.String VDEPARTCODE) 
        {
            RowYWAPP_DOCTOR_INTRODUCTION row = ((RowYWAPP_DOCTOR_INTRODUCTION)(this.NewRow()));
            row.ItemArray = new object[] {VGOODAT,ID,VSTAFFCODE,DOCTORINTRODUCTION,REMARKS,ISENABLE,SPECIALTY,POSITION,PHOTO,VDEPARTCODE};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowYWAPP_DOCTOR_INTRODUCTION FindByID(System.String ID) {
            return ((RowYWAPP_DOCTOR_INTRODUCTION)(this.Rows.Find(new object[] {
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
            DataTableYWAPP_DOCTOR_INTRODUCTION cln = ((DataTableYWAPP_DOCTOR_INTRODUCTION)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableYWAPP_DOCTOR_INTRODUCTION();
        }
        
        internal void InitVars() 
        {	
            this.columnVGOODAT = this.Columns["VGOODAT"];
            this.columnID = this.Columns["ID"];
            this.columnVSTAFFCODE = this.Columns["VSTAFFCODE"];
            this.columnDOCTORINTRODUCTION = this.Columns["DOCTORINTRODUCTION"];
            this.columnREMARKS = this.Columns["REMARKS"];
            this.columnISENABLE = this.Columns["ISENABLE"];
            this.columnSPECIALTY = this.Columns["SPECIALTY"];
            this.columnPOSITION = this.Columns["POSITION"];
            this.columnPHOTO = this.Columns["PHOTO"];
            this.columnVDEPARTCODE = this.Columns["VDEPARTCODE"];
        }
        
        private void InitClass() 
        {	
            this.columnVGOODAT = new DataColumn("VGOODAT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVGOODAT.MaxLength = 50;
            this.columnVGOODAT.AllowDBNull = true;
            this.Columns.Add(this.columnVGOODAT);
			
            this.columnID = new DataColumn("ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnID.MaxLength = 36;
            this.columnID.AllowDBNull = false;
            this.columnID.Unique = true;
            
            this.Columns.Add(this.columnID);
			
            this.columnVSTAFFCODE = new DataColumn("VSTAFFCODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVSTAFFCODE.MaxLength = 36;
            this.columnVSTAFFCODE.AllowDBNull = true;
            this.Columns.Add(this.columnVSTAFFCODE);
			
            this.columnDOCTORINTRODUCTION = new DataColumn("DOCTORINTRODUCTION", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnDOCTORINTRODUCTION.MaxLength = 500;
            this.columnDOCTORINTRODUCTION.AllowDBNull = true;
            this.Columns.Add(this.columnDOCTORINTRODUCTION);
			
            this.columnREMARKS = new DataColumn("REMARKS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnREMARKS.MaxLength = 100;
            this.columnREMARKS.AllowDBNull = true;
            this.Columns.Add(this.columnREMARKS);
			
            this.columnISENABLE = new DataColumn("ISENABLE", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnISENABLE.DefaultValue = "0";
            this.columnISENABLE.AllowDBNull = true;
            this.Columns.Add(this.columnISENABLE);
			
            this.columnSPECIALTY = new DataColumn("SPECIALTY", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnSPECIALTY.MaxLength = 20;
            this.columnSPECIALTY.AllowDBNull = true;
            this.Columns.Add(this.columnSPECIALTY);
			
            this.columnPOSITION = new DataColumn("POSITION", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnPOSITION.MaxLength = 20;
            this.columnPOSITION.AllowDBNull = true;
            this.Columns.Add(this.columnPOSITION);
			
            this.columnPHOTO = new DataColumn("PHOTO", typeof(System.Byte[]), null, System.Data.MappingType.Element);
            this.columnPHOTO.AllowDBNull = true;
            this.Columns.Add(this.columnPHOTO);
			
            this.columnVDEPARTCODE = new DataColumn("VDEPARTCODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPARTCODE.MaxLength = 36;
            this.columnVDEPARTCODE.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPARTCODE);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowYWAPP_DOCTOR_INTRODUCTION NewRowYWAPP_DOCTOR_INTRODUCTION() {
            return ((RowYWAPP_DOCTOR_INTRODUCTION)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowYWAPP_DOCTOR_INTRODUCTION(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowYWAPP_DOCTOR_INTRODUCTION);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedYWAPP_DOCTOR_INTRODUCTION != null)) {
                this.RowChangedYWAPP_DOCTOR_INTRODUCTION(this, new RowChangeEventYWAPP_DOCTOR_INTRODUCTION(((RowYWAPP_DOCTOR_INTRODUCTION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingYWAPP_DOCTOR_INTRODUCTION != null)) {
                this.RowChangingYWAPP_DOCTOR_INTRODUCTION(this, new RowChangeEventYWAPP_DOCTOR_INTRODUCTION(((RowYWAPP_DOCTOR_INTRODUCTION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedYWAPP_DOCTOR_INTRODUCTION != null)) {
                this.RowDeletedYWAPP_DOCTOR_INTRODUCTION(this, new RowChangeEventYWAPP_DOCTOR_INTRODUCTION(((RowYWAPP_DOCTOR_INTRODUCTION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingYWAPP_DOCTOR_INTRODUCTION != null)) {
                this.RowDeletingYWAPP_DOCTOR_INTRODUCTION(this, new RowChangeEventYWAPP_DOCTOR_INTRODUCTION(((RowYWAPP_DOCTOR_INTRODUCTION)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowYWAPP_DOCTOR_INTRODUCTION(RowYWAPP_DOCTOR_INTRODUCTION row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowYWAPP_DOCTOR_INTRODUCTION
	/// 
	/// 数据表YWAPP_DOCTOR_INTRODUCTION行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowYWAPP_DOCTOR_INTRODUCTION : DataRow 
    {
        
        private DataTableYWAPP_DOCTOR_INTRODUCTION tableYWAPP_DOCTOR_INTRODUCTION;
        
        internal RowYWAPP_DOCTOR_INTRODUCTION(DataRowBuilder rb) : base(rb) 
        {
            this.tableYWAPP_DOCTOR_INTRODUCTION = ((DataTableYWAPP_DOCTOR_INTRODUCTION)(this.Table));
        }        
		
		/// 
		/// 字段VGOODAT所映射的属性。
		/// 
        public System.String VGOODAT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnVGOODAT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnVGOODAT] = value;
            }
        }
        
		/// 
		/// 字段ID所映射的属性。
		/// 
        public System.String ID
        {
            get 
            {	
                return ((System.String)(this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnID])); 
            }
            set 
            {
                this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnID] = value;
            }
        }
        
		/// 
		/// 字段VSTAFFCODE所映射的属性。
		/// 
        public System.String VSTAFFCODE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnVSTAFFCODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnVSTAFFCODE] = value;
            }
        }
        
		/// 
		/// 字段DOCTORINTRODUCTION所映射的属性。
		/// 
        public System.String DOCTORINTRODUCTION
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnDOCTORINTRODUCTION])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnDOCTORINTRODUCTION] = value;
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
	                return ((System.String)(this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnREMARKS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnREMARKS] = value;
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
	                return ((System.Int16)(this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnISENABLE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnISENABLE] = value;
            }
        }
        
		/// 
		/// 字段SPECIALTY所映射的属性。
		/// 
        public System.String SPECIALTY
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnSPECIALTY])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnSPECIALTY] = value;
            }
        }
        
		/// 
		/// 字段POSITION所映射的属性。
		/// 
        public System.String POSITION
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnPOSITION])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnPOSITION] = value;
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
	                return ((System.Byte[])(this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnPHOTO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnPHOTO] = value;
            }
        }
        
		/// 
		/// 字段VDEPARTCODE所映射的属性。
		/// 
        public System.String VDEPARTCODE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnVDEPARTCODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnVDEPARTCODE] = value;
            }
        }
        
		/// 
		/// 判断字段VGOODAT是否为空。
		/// 
        public bool IsVGOODATNull()
        {
            return this.IsNull(this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnVGOODAT);
        }

		/// 
		/// 设置字段VGOODAT为空值。
		/// 
        public void SetVGOODATNull() 
        {
            this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnVGOODAT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VSTAFFCODE是否为空。
		/// 
        public bool IsVSTAFFCODENull()
        {
            return this.IsNull(this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnVSTAFFCODE);
        }

		/// 
		/// 设置字段VSTAFFCODE为空值。
		/// 
        public void SetVSTAFFCODENull() 
        {
            this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnVSTAFFCODE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DOCTORINTRODUCTION是否为空。
		/// 
        public bool IsDOCTORINTRODUCTIONNull()
        {
            return this.IsNull(this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnDOCTORINTRODUCTION);
        }

		/// 
		/// 设置字段DOCTORINTRODUCTION为空值。
		/// 
        public void SetDOCTORINTRODUCTIONNull() 
        {
            this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnDOCTORINTRODUCTION] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段REMARKS是否为空。
		/// 
        public bool IsREMARKSNull()
        {
            return this.IsNull(this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnREMARKS);
        }

		/// 
		/// 设置字段REMARKS为空值。
		/// 
        public void SetREMARKSNull() 
        {
            this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnREMARKS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段ISENABLE是否为空。
		/// 
        public bool IsISENABLENull()
        {
            return this.IsNull(this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnISENABLE);
        }

		/// 
		/// 设置字段ISENABLE为空值。
		/// 
        public void SetISENABLENull() 
        {
            this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnISENABLE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段SPECIALTY是否为空。
		/// 
        public bool IsSPECIALTYNull()
        {
            return this.IsNull(this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnSPECIALTY);
        }

		/// 
		/// 设置字段SPECIALTY为空值。
		/// 
        public void SetSPECIALTYNull() 
        {
            this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnSPECIALTY] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段POSITION是否为空。
		/// 
        public bool IsPOSITIONNull()
        {
            return this.IsNull(this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnPOSITION);
        }

		/// 
		/// 设置字段POSITION为空值。
		/// 
        public void SetPOSITIONNull() 
        {
            this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnPOSITION] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段PHOTO是否为空。
		/// 
        public bool IsPHOTONull()
        {
            return this.IsNull(this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnPHOTO);
        }

		/// 
		/// 设置字段PHOTO为空值。
		/// 
        public void SetPHOTONull() 
        {
            this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnPHOTO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDEPARTCODE是否为空。
		/// 
        public bool IsVDEPARTCODENull()
        {
            return this.IsNull(this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnVDEPARTCODE);
        }

		/// 
		/// 设置字段VDEPARTCODE为空值。
		/// 
        public void SetVDEPARTCODENull() 
        {
            this[this.tableYWAPP_DOCTOR_INTRODUCTION.ColumnVDEPARTCODE] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventYWAPP_DOCTOR_INTRODUCTION : EventArgs {
        
        private RowYWAPP_DOCTOR_INTRODUCTION eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventYWAPP_DOCTOR_INTRODUCTION(RowYWAPP_DOCTOR_INTRODUCTION row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowYWAPP_DOCTOR_INTRODUCTION Row {
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
	