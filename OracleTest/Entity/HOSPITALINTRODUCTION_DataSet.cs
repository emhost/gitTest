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
	#region DataSetHOSPITALINTRODUCTION
	/// 
	/// 对于HOSPITALINTRODUCTION的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetHOSPITALINTRODUCTION : DataSet
    {
		
		private DataTableYWAPP_HOSPITAL_INTRODUCTION tableYWAPP_HOSPITAL_INTRODUCTION;
		
        public DataSetHOSPITALINTRODUCTION() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetHOSPITALINTRODUCTION实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetHOSPITALINTRODUCTION GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetHOSPITALINTRODUCTION dataSet = (DataSetHOSPITALINTRODUCTION)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetHOSPITALINTRODUCTION entity = new DataSetHOSPITALINTRODUCTION();
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
        
        protected DataSetHOSPITALINTRODUCTION(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["YWAPP_HOSPITAL_INTRODUCTION"] != null)) 
                {
                    this.Tables.Add(new DataTableYWAPP_HOSPITAL_INTRODUCTION(ds.Tables["YWAPP_HOSPITAL_INTRODUCTION"]));
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
		/// 对于数据表YWAPP_HOSPITAL_INTRODUCTION的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableYWAPP_HOSPITAL_INTRODUCTION YWAPP_HOSPITAL_INTRODUCTION 
		{
			get
			{
				return this.tableYWAPP_HOSPITAL_INTRODUCTION;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetHOSPITALINTRODUCTION cln = ((DataSetHOSPITALINTRODUCTION)(base.Clone()));
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
			
			if ((ds.Tables["YWAPP_HOSPITAL_INTRODUCTION"] != null)) 
			{
				this.Tables.Add(new DataTableYWAPP_HOSPITAL_INTRODUCTION(ds.Tables["YWAPP_HOSPITAL_INTRODUCTION"]));
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
			
			this.tableYWAPP_HOSPITAL_INTRODUCTION = ((DataTableYWAPP_HOSPITAL_INTRODUCTION)(this.Tables["YWAPP_HOSPITAL_INTRODUCTION"]));
			if ((this.tableYWAPP_HOSPITAL_INTRODUCTION != null)) {
				this.tableYWAPP_HOSPITAL_INTRODUCTION.InitVars();
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
			
			this.tableYWAPP_HOSPITAL_INTRODUCTION = new DataTableYWAPP_HOSPITAL_INTRODUCTION();
			this.Tables.Add(this.tableYWAPP_HOSPITAL_INTRODUCTION);
			
		}
		
		private bool ShouldSerializeYWAPP_HOSPITAL_INTRODUCTION() 
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
	
    public delegate void RowChangeEventHandlerYWAPP_HOSPITAL_INTRODUCTION(object sender, RowChangeEventYWAPP_HOSPITAL_INTRODUCTION e);
	
	#region DataTableYWAPP_HOSPITAL_INTRODUCTION
	/// 
	/// 对于数据表YWAPP_HOSPITAL_INTRODUCTION的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableYWAPP_HOSPITAL_INTRODUCTION : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnID;
		
        private DataColumn columnHOSPITALNAME;
		
        private DataColumn columnHOSPITALADDRESS;
		
        private DataColumn columnHOSPITALTEL;
		
        private DataColumn columnHOSPITALINTRODUCTION;
		
        private DataColumn columnREMARKS;
		
        private DataColumn columnISENABLE;
		
        private DataColumn columnPHOTO;
		
        private DataColumn columnPHOTO1;
		
        private DataColumn columnPHOTO2;
		
        private DataColumn columnHOSPITALID;
		
        internal DataTableYWAPP_HOSPITAL_INTRODUCTION() : base("YWAPP_HOSPITAL_INTRODUCTION") 
        {
            this.InitClass();
        }
        
        internal DataTableYWAPP_HOSPITAL_INTRODUCTION(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnHOSPITALNAME 
        {
            get 
            {
                return this.columnHOSPITALNAME;
            }
        }
		
        public DataColumn ColumnHOSPITALADDRESS 
        {
            get 
            {
                return this.columnHOSPITALADDRESS;
            }
        }
		
        public DataColumn ColumnHOSPITALTEL 
        {
            get 
            {
                return this.columnHOSPITALTEL;
            }
        }
		
        public DataColumn ColumnHOSPITALINTRODUCTION 
        {
            get 
            {
                return this.columnHOSPITALINTRODUCTION;
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
		
        public DataColumn ColumnPHOTO1 
        {
            get 
            {
                return this.columnPHOTO1;
            }
        }
		
        public DataColumn ColumnPHOTO2 
        {
            get 
            {
                return this.columnPHOTO2;
            }
        }
		
        public DataColumn ColumnHOSPITALID 
        {
            get 
            {
                return this.columnHOSPITALID;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowYWAPP_HOSPITAL_INTRODUCTION this[int index] 
        {
            get 
            {
                return ((RowYWAPP_HOSPITAL_INTRODUCTION)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerYWAPP_HOSPITAL_INTRODUCTION RowChangedYWAPP_HOSPITAL_INTRODUCTION;
        
        public event RowChangeEventHandlerYWAPP_HOSPITAL_INTRODUCTION RowChangingYWAPP_HOSPITAL_INTRODUCTION;
        
        public event RowChangeEventHandlerYWAPP_HOSPITAL_INTRODUCTION RowDeletedYWAPP_HOSPITAL_INTRODUCTION;
        
        public event RowChangeEventHandlerYWAPP_HOSPITAL_INTRODUCTION RowDeletingYWAPP_HOSPITAL_INTRODUCTION;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowYWAPP_HOSPITAL_INTRODUCTION(RowYWAPP_HOSPITAL_INTRODUCTION row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowYWAPP_HOSPITAL_INTRODUCTION AddRowYWAPP_HOSPITAL_INTRODUCTION(System.String ID,System.String HOSPITALNAME,System.String HOSPITALADDRESS,System.String HOSPITALTEL,System.String HOSPITALINTRODUCTION,System.String REMARKS,System.Int16 ISENABLE,System.Byte[] PHOTO,System.Byte[] PHOTO1,System.Byte[] PHOTO2,System.String HOSPITALID) 
        {
            RowYWAPP_HOSPITAL_INTRODUCTION row = ((RowYWAPP_HOSPITAL_INTRODUCTION)(this.NewRow()));
            row.ItemArray = new object[] {ID,HOSPITALNAME,HOSPITALADDRESS,HOSPITALTEL,HOSPITALINTRODUCTION,REMARKS,ISENABLE,PHOTO,PHOTO1,PHOTO2,HOSPITALID};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowYWAPP_HOSPITAL_INTRODUCTION FindByID(System.String ID) {
            return ((RowYWAPP_HOSPITAL_INTRODUCTION)(this.Rows.Find(new object[] {
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
            DataTableYWAPP_HOSPITAL_INTRODUCTION cln = ((DataTableYWAPP_HOSPITAL_INTRODUCTION)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableYWAPP_HOSPITAL_INTRODUCTION();
        }
        
        internal void InitVars() 
        {	
            this.columnID = this.Columns["ID"];
            this.columnHOSPITALNAME = this.Columns["HOSPITALNAME"];
            this.columnHOSPITALADDRESS = this.Columns["HOSPITALADDRESS"];
            this.columnHOSPITALTEL = this.Columns["HOSPITALTEL"];
            this.columnHOSPITALINTRODUCTION = this.Columns["HOSPITALINTRODUCTION"];
            this.columnREMARKS = this.Columns["REMARKS"];
            this.columnISENABLE = this.Columns["ISENABLE"];
            this.columnPHOTO = this.Columns["PHOTO"];
            this.columnPHOTO1 = this.Columns["PHOTO1"];
            this.columnPHOTO2 = this.Columns["PHOTO2"];
            this.columnHOSPITALID = this.Columns["HOSPITALID"];
        }
        
        private void InitClass() 
        {	
            this.columnID = new DataColumn("ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnID.MaxLength = 36;
            this.columnID.AllowDBNull = false;
            this.columnID.Unique = true;
            
            this.Columns.Add(this.columnID);
			
            this.columnHOSPITALNAME = new DataColumn("HOSPITALNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnHOSPITALNAME.MaxLength = 50;
            this.columnHOSPITALNAME.AllowDBNull = true;
            this.Columns.Add(this.columnHOSPITALNAME);
			
            this.columnHOSPITALADDRESS = new DataColumn("HOSPITALADDRESS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnHOSPITALADDRESS.MaxLength = 100;
            this.columnHOSPITALADDRESS.AllowDBNull = true;
            this.Columns.Add(this.columnHOSPITALADDRESS);
			
            this.columnHOSPITALTEL = new DataColumn("HOSPITALTEL", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnHOSPITALTEL.MaxLength = 20;
            this.columnHOSPITALTEL.AllowDBNull = true;
            this.Columns.Add(this.columnHOSPITALTEL);
			
            this.columnHOSPITALINTRODUCTION = new DataColumn("HOSPITALINTRODUCTION", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnHOSPITALINTRODUCTION.MaxLength = 1500;
            this.columnHOSPITALINTRODUCTION.AllowDBNull = true;
            this.Columns.Add(this.columnHOSPITALINTRODUCTION);
			
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
			
            this.columnPHOTO1 = new DataColumn("PHOTO1", typeof(System.Byte[]), null, System.Data.MappingType.Element);
            this.columnPHOTO1.AllowDBNull = true;
            this.Columns.Add(this.columnPHOTO1);
			
            this.columnPHOTO2 = new DataColumn("PHOTO2", typeof(System.Byte[]), null, System.Data.MappingType.Element);
            this.columnPHOTO2.AllowDBNull = true;
            this.Columns.Add(this.columnPHOTO2);
			
            this.columnHOSPITALID = new DataColumn("HOSPITALID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnHOSPITALID.MaxLength = 20;
            this.columnHOSPITALID.AllowDBNull = true;
            this.Columns.Add(this.columnHOSPITALID);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowYWAPP_HOSPITAL_INTRODUCTION NewRowYWAPP_HOSPITAL_INTRODUCTION() {
            return ((RowYWAPP_HOSPITAL_INTRODUCTION)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowYWAPP_HOSPITAL_INTRODUCTION(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowYWAPP_HOSPITAL_INTRODUCTION);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedYWAPP_HOSPITAL_INTRODUCTION != null)) {
                this.RowChangedYWAPP_HOSPITAL_INTRODUCTION(this, new RowChangeEventYWAPP_HOSPITAL_INTRODUCTION(((RowYWAPP_HOSPITAL_INTRODUCTION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingYWAPP_HOSPITAL_INTRODUCTION != null)) {
                this.RowChangingYWAPP_HOSPITAL_INTRODUCTION(this, new RowChangeEventYWAPP_HOSPITAL_INTRODUCTION(((RowYWAPP_HOSPITAL_INTRODUCTION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedYWAPP_HOSPITAL_INTRODUCTION != null)) {
                this.RowDeletedYWAPP_HOSPITAL_INTRODUCTION(this, new RowChangeEventYWAPP_HOSPITAL_INTRODUCTION(((RowYWAPP_HOSPITAL_INTRODUCTION)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingYWAPP_HOSPITAL_INTRODUCTION != null)) {
                this.RowDeletingYWAPP_HOSPITAL_INTRODUCTION(this, new RowChangeEventYWAPP_HOSPITAL_INTRODUCTION(((RowYWAPP_HOSPITAL_INTRODUCTION)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowYWAPP_HOSPITAL_INTRODUCTION(RowYWAPP_HOSPITAL_INTRODUCTION row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowYWAPP_HOSPITAL_INTRODUCTION
	/// 
	/// 数据表YWAPP_HOSPITAL_INTRODUCTION行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowYWAPP_HOSPITAL_INTRODUCTION : DataRow 
    {
        
        private DataTableYWAPP_HOSPITAL_INTRODUCTION tableYWAPP_HOSPITAL_INTRODUCTION;
        
        internal RowYWAPP_HOSPITAL_INTRODUCTION(DataRowBuilder rb) : base(rb) 
        {
            this.tableYWAPP_HOSPITAL_INTRODUCTION = ((DataTableYWAPP_HOSPITAL_INTRODUCTION)(this.Table));
        }        
		
		/// 
		/// 字段ID所映射的属性。
		/// 
        public System.String ID
        {
            get 
            {	
                return ((System.String)(this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnID])); 
            }
            set 
            {
                this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnID] = value;
            }
        }
        
		/// 
		/// 字段HOSPITALNAME所映射的属性。
		/// 
        public System.String HOSPITALNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALNAME] = value;
            }
        }
        
		/// 
		/// 字段HOSPITALADDRESS所映射的属性。
		/// 
        public System.String HOSPITALADDRESS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALADDRESS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALADDRESS] = value;
            }
        }
        
		/// 
		/// 字段HOSPITALTEL所映射的属性。
		/// 
        public System.String HOSPITALTEL
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALTEL])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALTEL] = value;
            }
        }
        
		/// 
		/// 字段HOSPITALINTRODUCTION所映射的属性。
		/// 
        public System.String HOSPITALINTRODUCTION
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALINTRODUCTION])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALINTRODUCTION] = value;
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
	                return ((System.String)(this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnREMARKS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnREMARKS] = value;
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
	                return ((System.Int16)(this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnISENABLE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnISENABLE] = value;
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
	                return ((System.Byte[])(this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnPHOTO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnPHOTO] = value;
            }
        }
        
		/// 
		/// 字段PHOTO1所映射的属性。
		/// 
        public System.Byte[] PHOTO1
        {
            get 
            {	
                try 
                {
	                return ((System.Byte[])(this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnPHOTO1])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnPHOTO1] = value;
            }
        }
        
		/// 
		/// 字段PHOTO2所映射的属性。
		/// 
        public System.Byte[] PHOTO2
        {
            get 
            {	
                try 
                {
	                return ((System.Byte[])(this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnPHOTO2])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnPHOTO2] = value;
            }
        }
        
		/// 
		/// 字段HOSPITALID所映射的属性。
		/// 
        public System.String HOSPITALID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALID] = value;
            }
        }
        
		/// 
		/// 判断字段HOSPITALNAME是否为空。
		/// 
        public bool IsHOSPITALNAMENull()
        {
            return this.IsNull(this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALNAME);
        }

		/// 
		/// 设置字段HOSPITALNAME为空值。
		/// 
        public void SetHOSPITALNAMENull() 
        {
            this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段HOSPITALADDRESS是否为空。
		/// 
        public bool IsHOSPITALADDRESSNull()
        {
            return this.IsNull(this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALADDRESS);
        }

		/// 
		/// 设置字段HOSPITALADDRESS为空值。
		/// 
        public void SetHOSPITALADDRESSNull() 
        {
            this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALADDRESS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段HOSPITALTEL是否为空。
		/// 
        public bool IsHOSPITALTELNull()
        {
            return this.IsNull(this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALTEL);
        }

		/// 
		/// 设置字段HOSPITALTEL为空值。
		/// 
        public void SetHOSPITALTELNull() 
        {
            this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALTEL] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段HOSPITALINTRODUCTION是否为空。
		/// 
        public bool IsHOSPITALINTRODUCTIONNull()
        {
            return this.IsNull(this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALINTRODUCTION);
        }

		/// 
		/// 设置字段HOSPITALINTRODUCTION为空值。
		/// 
        public void SetHOSPITALINTRODUCTIONNull() 
        {
            this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALINTRODUCTION] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段REMARKS是否为空。
		/// 
        public bool IsREMARKSNull()
        {
            return this.IsNull(this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnREMARKS);
        }

		/// 
		/// 设置字段REMARKS为空值。
		/// 
        public void SetREMARKSNull() 
        {
            this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnREMARKS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段ISENABLE是否为空。
		/// 
        public bool IsISENABLENull()
        {
            return this.IsNull(this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnISENABLE);
        }

		/// 
		/// 设置字段ISENABLE为空值。
		/// 
        public void SetISENABLENull() 
        {
            this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnISENABLE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段PHOTO是否为空。
		/// 
        public bool IsPHOTONull()
        {
            return this.IsNull(this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnPHOTO);
        }

		/// 
		/// 设置字段PHOTO为空值。
		/// 
        public void SetPHOTONull() 
        {
            this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnPHOTO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段PHOTO1是否为空。
		/// 
        public bool IsPHOTO1Null()
        {
            return this.IsNull(this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnPHOTO1);
        }

		/// 
		/// 设置字段PHOTO1为空值。
		/// 
        public void SetPHOTO1Null() 
        {
            this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnPHOTO1] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段PHOTO2是否为空。
		/// 
        public bool IsPHOTO2Null()
        {
            return this.IsNull(this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnPHOTO2);
        }

		/// 
		/// 设置字段PHOTO2为空值。
		/// 
        public void SetPHOTO2Null() 
        {
            this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnPHOTO2] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段HOSPITALID是否为空。
		/// 
        public bool IsHOSPITALIDNull()
        {
            return this.IsNull(this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALID);
        }

		/// 
		/// 设置字段HOSPITALID为空值。
		/// 
        public void SetHOSPITALIDNull() 
        {
            this[this.tableYWAPP_HOSPITAL_INTRODUCTION.ColumnHOSPITALID] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventYWAPP_HOSPITAL_INTRODUCTION : EventArgs {
        
        private RowYWAPP_HOSPITAL_INTRODUCTION eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventYWAPP_HOSPITAL_INTRODUCTION(RowYWAPP_HOSPITAL_INTRODUCTION row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowYWAPP_HOSPITAL_INTRODUCTION Row {
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
	