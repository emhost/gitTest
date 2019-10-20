//------------------------------------------------------------------------------
//     这部分代码属于实体定义层，是由实体编辑器工具自动产生的。
//     (Runtime Version: 1.0.0.0)
//     对此代码进行的任何修改会导致其它的行为错误，并且重新生成时所有的修改会丢失。
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Xml;
using System.Runtime.Serialization;

namespace HYHISAPPView.Entity
{
	#region DataSetV_MZ_PRESCMASTER
	/// 
	/// ,V_MZ_PRESCMASTER的视图实体。
	/// 
    [Serializable()]
    public class DataSetV_MZ_PRESCMASTER : DataSet
    {
	
		private DataTableV_MZ_PRESCMASTER tableV_MZ_PRESCMASTER;

	
        public DataSetV_MZ_PRESCMASTER() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetV_MZ_PRESCMASTER实体。
		/// 
		public DataSetV_MZ_PRESCMASTER GetChangesEntity(DataRowState ds)
		{
			DataSetV_MZ_PRESCMASTER dataSet = (DataSetV_MZ_PRESCMASTER)this.GetChanges(ds);
			return dataSet;		
		}
        
        protected DataSetV_MZ_PRESCMASTER(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
		
                if ((ds.Tables["V_MZ_PRESCMASTER"] != null)) 
                {
                    this.Tables.Add(new DataTableV_MZ_PRESCMASTER(ds.Tables["V_MZ_PRESCMASTER"]));
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
		/// 对于数据表V_MZ_PRESCMASTER的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableV_MZ_PRESCMASTER V_MZ_PRESCMASTER 
		{
			get
			{
				return this.tableV_MZ_PRESCMASTER;
			}
		}	
	
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetV_MZ_PRESCMASTER cln = ((DataSetV_MZ_PRESCMASTER)(base.Clone()));
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
		
			if ((ds.Tables["V_MZ_PRESCMASTER"] != null)) 
			{
				this.Tables.Add(new DataTableV_MZ_PRESCMASTER(ds.Tables["V_MZ_PRESCMASTER"]));
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
		
			this.tableV_MZ_PRESCMASTER = ((DataTableV_MZ_PRESCMASTER)(this.Tables["V_MZ_PRESCMASTER"]));
			if ((this.tableV_MZ_PRESCMASTER != null)) {
				this.tableV_MZ_PRESCMASTER.InitVars();
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
			
			this.tableV_MZ_PRESCMASTER = new DataTableV_MZ_PRESCMASTER();
			this.Tables.Add(this.tableV_MZ_PRESCMASTER);
		
			
		
		}
	
		private bool ShouldSerializeV_MZ_PRESCMASTER() 
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

    public delegate void RowChangeEventHandlerV_MZ_PRESCMASTER(object sender, RowChangeEventV_MZ_PRESCMASTER e);
	
	
	#region DataTableV_MZ_PRESCMASTER
	/// 
	/// 对于数据表V_MZ_PRESCMASTER的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableV_MZ_PRESCMASTER : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVTIMESTAMP;
		
        private DataColumn columnVPATIENTID;
		
        private DataColumn columnVPRESC_ID;
		
        private DataColumn columnDPRESC_DATE;
		
        private DataColumn columnVPRESC_TYPE;
		
        private DataColumn columnVPRESC_TYPE_NAME;
		
        private DataColumn columnVPATIENT_ID;
		
        private DataColumn columnVDIAGNOSE;
		
        private DataColumn columnNCOUNT;
		
        private DataColumn columnVUSERAGE;
		
        private DataColumn columnVDOCTOR_ID;
		
        private DataColumn columnVDOCTOR_NAME;
		
        private DataColumn columnNSTATUS;
		
        private DataColumn columnVCHARGE_USER;
		
        private DataColumn columnDCHARGE_DATE;
		
        private DataColumn columnVMEMO;
		
        private DataColumn columnVDEPT_CODE;
		
        private DataColumn columnVDEPARTNAME;
		
        private DataColumn columnVCLINICNO;
		
        internal DataTableV_MZ_PRESCMASTER() : base("V_MZ_PRESCMASTER") 
        {
            this.InitClass();
        }
        
        internal DataTableV_MZ_PRESCMASTER(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVTIMESTAMP 
        {
            get 
            {
                return this.columnVTIMESTAMP;
            }
        }
		
        public DataColumn ColumnVPATIENTID 
        {
            get 
            {
                return this.columnVPATIENTID;
            }
        }
		
        public DataColumn ColumnVPRESC_ID 
        {
            get 
            {
                return this.columnVPRESC_ID;
            }
        }
		
        public DataColumn ColumnDPRESC_DATE 
        {
            get 
            {
                return this.columnDPRESC_DATE;
            }
        }
		
        public DataColumn ColumnVPRESC_TYPE 
        {
            get 
            {
                return this.columnVPRESC_TYPE;
            }
        }
		
        public DataColumn ColumnVPRESC_TYPE_NAME 
        {
            get 
            {
                return this.columnVPRESC_TYPE_NAME;
            }
        }
		
        public DataColumn ColumnVPATIENT_ID 
        {
            get 
            {
                return this.columnVPATIENT_ID;
            }
        }
		
        public DataColumn ColumnVDIAGNOSE 
        {
            get 
            {
                return this.columnVDIAGNOSE;
            }
        }
		
        public DataColumn ColumnNCOUNT 
        {
            get 
            {
                return this.columnNCOUNT;
            }
        }
		
        public DataColumn ColumnVUSERAGE 
        {
            get 
            {
                return this.columnVUSERAGE;
            }
        }
		
        public DataColumn ColumnVDOCTOR_ID 
        {
            get 
            {
                return this.columnVDOCTOR_ID;
            }
        }
		
        public DataColumn ColumnVDOCTOR_NAME 
        {
            get 
            {
                return this.columnVDOCTOR_NAME;
            }
        }
		
        public DataColumn ColumnNSTATUS 
        {
            get 
            {
                return this.columnNSTATUS;
            }
        }
		
        public DataColumn ColumnVCHARGE_USER 
        {
            get 
            {
                return this.columnVCHARGE_USER;
            }
        }
		
        public DataColumn ColumnDCHARGE_DATE 
        {
            get 
            {
                return this.columnDCHARGE_DATE;
            }
        }
		
        public DataColumn ColumnVMEMO 
        {
            get 
            {
                return this.columnVMEMO;
            }
        }
		
        public DataColumn ColumnVDEPT_CODE 
        {
            get 
            {
                return this.columnVDEPT_CODE;
            }
        }
		
        public DataColumn ColumnVDEPARTNAME 
        {
            get 
            {
                return this.columnVDEPARTNAME;
            }
        }
		
        public DataColumn ColumnVCLINICNO 
        {
            get 
            {
                return this.columnVCLINICNO;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowV_MZ_PRESCMASTER this[int index] 
        {
            get 
            {
                return ((RowV_MZ_PRESCMASTER)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerV_MZ_PRESCMASTER RowChangedV_MZ_PRESCMASTER;
        
        public event RowChangeEventHandlerV_MZ_PRESCMASTER RowChangingV_MZ_PRESCMASTER;
        
        public event RowChangeEventHandlerV_MZ_PRESCMASTER RowDeletedV_MZ_PRESCMASTER;
        
        public event RowChangeEventHandlerV_MZ_PRESCMASTER RowDeletingV_MZ_PRESCMASTER;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowV_MZ_PRESCMASTER(RowV_MZ_PRESCMASTER row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowV_MZ_PRESCMASTER AddRowV_MZ_PRESCMASTER(System.String VTIMESTAMP,System.String VPATIENTID,System.String VPRESC_ID,System.DateTime DPRESC_DATE,System.String VPRESC_TYPE,System.String VPRESC_TYPE_NAME,System.String VPATIENT_ID,System.String VDIAGNOSE,System.Int16 NCOUNT,System.String VUSERAGE,System.String VDOCTOR_ID,System.String VDOCTOR_NAME,System.Int16 NSTATUS,System.String VCHARGE_USER,System.DateTime DCHARGE_DATE,System.String VMEMO,System.String VDEPT_CODE,System.String VDEPARTNAME,System.String VCLINICNO) 
        {
            RowV_MZ_PRESCMASTER row = ((RowV_MZ_PRESCMASTER)(this.NewRow()));
            row.ItemArray = new object[] {VTIMESTAMP,VPATIENTID,VPRESC_ID,DPRESC_DATE,VPRESC_TYPE,VPRESC_TYPE_NAME,VPATIENT_ID,VDIAGNOSE,NCOUNT,VUSERAGE,VDOCTOR_ID,VDOCTOR_NAME,NSTATUS,VCHARGE_USER,DCHARGE_DATE,VMEMO,VDEPT_CODE,VDEPARTNAME,VCLINICNO};
            this.Rows.Add(row);
            return row;
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
            DataTableV_MZ_PRESCMASTER cln = ((DataTableV_MZ_PRESCMASTER)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableV_MZ_PRESCMASTER();
        }
        
        internal void InitVars() 
        {	
            this.columnVTIMESTAMP = this.Columns["VTIMESTAMP"];
            this.columnVPATIENTID = this.Columns["VPATIENTID"];
            this.columnVPRESC_ID = this.Columns["VPRESC_ID"];
            this.columnDPRESC_DATE = this.Columns["DPRESC_DATE"];
            this.columnVPRESC_TYPE = this.Columns["VPRESC_TYPE"];
            this.columnVPRESC_TYPE_NAME = this.Columns["VPRESC_TYPE_NAME"];
            this.columnVPATIENT_ID = this.Columns["VPATIENT_ID"];
            this.columnVDIAGNOSE = this.Columns["VDIAGNOSE"];
            this.columnNCOUNT = this.Columns["NCOUNT"];
            this.columnVUSERAGE = this.Columns["VUSERAGE"];
            this.columnVDOCTOR_ID = this.Columns["VDOCTOR_ID"];
            this.columnVDOCTOR_NAME = this.Columns["VDOCTOR_NAME"];
            this.columnNSTATUS = this.Columns["NSTATUS"];
            this.columnVCHARGE_USER = this.Columns["VCHARGE_USER"];
            this.columnDCHARGE_DATE = this.Columns["DCHARGE_DATE"];
            this.columnVMEMO = this.Columns["VMEMO"];
            this.columnVDEPT_CODE = this.Columns["VDEPT_CODE"];
            this.columnVDEPARTNAME = this.Columns["VDEPARTNAME"];
            this.columnVCLINICNO = this.Columns["VCLINICNO"];
        }
        
        private void InitClass() 
        {	
            this.columnVTIMESTAMP = new DataColumn("VTIMESTAMP", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVTIMESTAMP.AllowDBNull = true;
            this.Columns.Add(this.columnVTIMESTAMP);
			
            this.columnVPATIENTID = new DataColumn("VPATIENTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPATIENTID.AllowDBNull = true;
            this.Columns.Add(this.columnVPATIENTID);
			
            this.columnVPRESC_ID = new DataColumn("VPRESC_ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPRESC_ID.AllowDBNull = true;
            this.Columns.Add(this.columnVPRESC_ID);
			
            this.columnDPRESC_DATE = new DataColumn("DPRESC_DATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDPRESC_DATE.AllowDBNull = true;
            this.Columns.Add(this.columnDPRESC_DATE);
			
            this.columnVPRESC_TYPE = new DataColumn("VPRESC_TYPE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPRESC_TYPE.AllowDBNull = true;
            this.Columns.Add(this.columnVPRESC_TYPE);
			
            this.columnVPRESC_TYPE_NAME = new DataColumn("VPRESC_TYPE_NAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPRESC_TYPE_NAME.AllowDBNull = true;
            this.Columns.Add(this.columnVPRESC_TYPE_NAME);
			
            this.columnVPATIENT_ID = new DataColumn("VPATIENT_ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPATIENT_ID.AllowDBNull = true;
            this.Columns.Add(this.columnVPATIENT_ID);
			
            this.columnVDIAGNOSE = new DataColumn("VDIAGNOSE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDIAGNOSE.AllowDBNull = true;
            this.Columns.Add(this.columnVDIAGNOSE);
			
            this.columnNCOUNT = new DataColumn("NCOUNT", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNCOUNT.AllowDBNull = true;
            this.Columns.Add(this.columnNCOUNT);
			
            this.columnVUSERAGE = new DataColumn("VUSERAGE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVUSERAGE.AllowDBNull = true;
            this.Columns.Add(this.columnVUSERAGE);
			
            this.columnVDOCTOR_ID = new DataColumn("VDOCTOR_ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDOCTOR_ID.AllowDBNull = true;
            this.Columns.Add(this.columnVDOCTOR_ID);
			
            this.columnVDOCTOR_NAME = new DataColumn("VDOCTOR_NAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDOCTOR_NAME.AllowDBNull = true;
            this.Columns.Add(this.columnVDOCTOR_NAME);
			
            this.columnNSTATUS = new DataColumn("NSTATUS", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNSTATUS.AllowDBNull = true;
            this.Columns.Add(this.columnNSTATUS);
			
            this.columnVCHARGE_USER = new DataColumn("VCHARGE_USER", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCHARGE_USER.AllowDBNull = true;
            this.Columns.Add(this.columnVCHARGE_USER);
			
            this.columnDCHARGE_DATE = new DataColumn("DCHARGE_DATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDCHARGE_DATE.AllowDBNull = true;
            this.Columns.Add(this.columnDCHARGE_DATE);
			
            this.columnVMEMO = new DataColumn("VMEMO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVMEMO.AllowDBNull = true;
            this.Columns.Add(this.columnVMEMO);
			
            this.columnVDEPT_CODE = new DataColumn("VDEPT_CODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPT_CODE.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPT_CODE);
			
            this.columnVDEPARTNAME = new DataColumn("VDEPARTNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPARTNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPARTNAME);
			
            this.columnVCLINICNO = new DataColumn("VCLINICNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCLINICNO.AllowDBNull = true;
            this.Columns.Add(this.columnVCLINICNO);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowV_MZ_PRESCMASTER NewRowV_MZ_PRESCMASTER() {
            return ((RowV_MZ_PRESCMASTER)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowV_MZ_PRESCMASTER(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowV_MZ_PRESCMASTER);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedV_MZ_PRESCMASTER != null)) {
                this.RowChangedV_MZ_PRESCMASTER(this, new RowChangeEventV_MZ_PRESCMASTER(((RowV_MZ_PRESCMASTER)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingV_MZ_PRESCMASTER != null)) {
                this.RowChangingV_MZ_PRESCMASTER(this, new RowChangeEventV_MZ_PRESCMASTER(((RowV_MZ_PRESCMASTER)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedV_MZ_PRESCMASTER != null)) {
                this.RowDeletedV_MZ_PRESCMASTER(this, new RowChangeEventV_MZ_PRESCMASTER(((RowV_MZ_PRESCMASTER)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingV_MZ_PRESCMASTER != null)) {
                this.RowDeletingV_MZ_PRESCMASTER(this, new RowChangeEventV_MZ_PRESCMASTER(((RowV_MZ_PRESCMASTER)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowV_MZ_PRESCMASTER(RowV_MZ_PRESCMASTER row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowV_MZ_PRESCMASTER
	/// 
	/// 数据表V_MZ_PRESCMASTER行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowV_MZ_PRESCMASTER : DataRow 
    {
        
        private DataTableV_MZ_PRESCMASTER tableV_MZ_PRESCMASTER;
        
        internal RowV_MZ_PRESCMASTER(DataRowBuilder rb) : base(rb) 
        {
            this.tableV_MZ_PRESCMASTER = ((DataTableV_MZ_PRESCMASTER)(this.Table));
        }        
		
		/// 
		/// 字段VTIMESTAMP所映射的属性。
		/// 
        public System.String VTIMESTAMP
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCMASTER.ColumnVTIMESTAMP])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnVTIMESTAMP] = value;
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
	                return ((System.String)(this[this.tableV_MZ_PRESCMASTER.ColumnVPATIENTID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnVPATIENTID] = value;
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
	                return ((System.String)(this[this.tableV_MZ_PRESCMASTER.ColumnVPRESC_ID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnVPRESC_ID] = value;
            }
        }
        
		/// 
		/// 字段DPRESC_DATE所映射的属性。
		/// 
        public System.DateTime DPRESC_DATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableV_MZ_PRESCMASTER.ColumnDPRESC_DATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnDPRESC_DATE] = value;
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
	                return ((System.String)(this[this.tableV_MZ_PRESCMASTER.ColumnVPRESC_TYPE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnVPRESC_TYPE] = value;
            }
        }
        
		/// 
		/// 字段VPRESC_TYPE_NAME所映射的属性。
		/// 
        public System.String VPRESC_TYPE_NAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCMASTER.ColumnVPRESC_TYPE_NAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnVPRESC_TYPE_NAME] = value;
            }
        }
        
		/// 
		/// 字段VPATIENT_ID所映射的属性。
		/// 
        public System.String VPATIENT_ID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCMASTER.ColumnVPATIENT_ID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnVPATIENT_ID] = value;
            }
        }
        
		/// 
		/// 字段VDIAGNOSE所映射的属性。
		/// 
        public System.String VDIAGNOSE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCMASTER.ColumnVDIAGNOSE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnVDIAGNOSE] = value;
            }
        }
        
		/// 
		/// 字段NCOUNT所映射的属性。
		/// 
        public System.Int16 NCOUNT
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableV_MZ_PRESCMASTER.ColumnNCOUNT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnNCOUNT] = value;
            }
        }
        
		/// 
		/// 字段VUSERAGE所映射的属性。
		/// 
        public System.String VUSERAGE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCMASTER.ColumnVUSERAGE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnVUSERAGE] = value;
            }
        }
        
		/// 
		/// 字段VDOCTOR_ID所映射的属性。
		/// 
        public System.String VDOCTOR_ID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCMASTER.ColumnVDOCTOR_ID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnVDOCTOR_ID] = value;
            }
        }
        
		/// 
		/// 字段VDOCTOR_NAME所映射的属性。
		/// 
        public System.String VDOCTOR_NAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCMASTER.ColumnVDOCTOR_NAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnVDOCTOR_NAME] = value;
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
	                return ((System.Int16)(this[this.tableV_MZ_PRESCMASTER.ColumnNSTATUS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnNSTATUS] = value;
            }
        }
        
		/// 
		/// 字段VCHARGE_USER所映射的属性。
		/// 
        public System.String VCHARGE_USER
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCMASTER.ColumnVCHARGE_USER])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnVCHARGE_USER] = value;
            }
        }
        
		/// 
		/// 字段DCHARGE_DATE所映射的属性。
		/// 
        public System.DateTime DCHARGE_DATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableV_MZ_PRESCMASTER.ColumnDCHARGE_DATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnDCHARGE_DATE] = value;
            }
        }
        
		/// 
		/// 字段VMEMO所映射的属性。
		/// 
        public System.String VMEMO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCMASTER.ColumnVMEMO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnVMEMO] = value;
            }
        }
        
		/// 
		/// 字段VDEPT_CODE所映射的属性。
		/// 
        public System.String VDEPT_CODE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCMASTER.ColumnVDEPT_CODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnVDEPT_CODE] = value;
            }
        }
        
		/// 
		/// 字段VDEPARTNAME所映射的属性。
		/// 
        public System.String VDEPARTNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCMASTER.ColumnVDEPARTNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnVDEPARTNAME] = value;
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
	                return ((System.String)(this[this.tableV_MZ_PRESCMASTER.ColumnVCLINICNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCMASTER.ColumnVCLINICNO] = value;
            }
        }
        
		/// 
		/// 判断字段VTIMESTAMP是否为空。
		/// 
        public bool IsVTIMESTAMPNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnVTIMESTAMP);
        }

		/// 
		/// 设置字段VTIMESTAMP为空值。
		/// 
        public void SetVTIMESTAMPNull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnVTIMESTAMP] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPATIENTID是否为空。
		/// 
        public bool IsVPATIENTIDNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnVPATIENTID);
        }

		/// 
		/// 设置字段VPATIENTID为空值。
		/// 
        public void SetVPATIENTIDNull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnVPATIENTID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPRESC_ID是否为空。
		/// 
        public bool IsVPRESC_IDNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnVPRESC_ID);
        }

		/// 
		/// 设置字段VPRESC_ID为空值。
		/// 
        public void SetVPRESC_IDNull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnVPRESC_ID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DPRESC_DATE是否为空。
		/// 
        public bool IsDPRESC_DATENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnDPRESC_DATE);
        }

		/// 
		/// 设置字段DPRESC_DATE为空值。
		/// 
        public void SetDPRESC_DATENull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnDPRESC_DATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPRESC_TYPE是否为空。
		/// 
        public bool IsVPRESC_TYPENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnVPRESC_TYPE);
        }

		/// 
		/// 设置字段VPRESC_TYPE为空值。
		/// 
        public void SetVPRESC_TYPENull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnVPRESC_TYPE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPRESC_TYPE_NAME是否为空。
		/// 
        public bool IsVPRESC_TYPE_NAMENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnVPRESC_TYPE_NAME);
        }

		/// 
		/// 设置字段VPRESC_TYPE_NAME为空值。
		/// 
        public void SetVPRESC_TYPE_NAMENull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnVPRESC_TYPE_NAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPATIENT_ID是否为空。
		/// 
        public bool IsVPATIENT_IDNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnVPATIENT_ID);
        }

		/// 
		/// 设置字段VPATIENT_ID为空值。
		/// 
        public void SetVPATIENT_IDNull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnVPATIENT_ID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDIAGNOSE是否为空。
		/// 
        public bool IsVDIAGNOSENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnVDIAGNOSE);
        }

		/// 
		/// 设置字段VDIAGNOSE为空值。
		/// 
        public void SetVDIAGNOSENull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnVDIAGNOSE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCOUNT是否为空。
		/// 
        public bool IsNCOUNTNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnNCOUNT);
        }

		/// 
		/// 设置字段NCOUNT为空值。
		/// 
        public void SetNCOUNTNull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnNCOUNT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VUSERAGE是否为空。
		/// 
        public bool IsVUSERAGENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnVUSERAGE);
        }

		/// 
		/// 设置字段VUSERAGE为空值。
		/// 
        public void SetVUSERAGENull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnVUSERAGE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDOCTOR_ID是否为空。
		/// 
        public bool IsVDOCTOR_IDNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnVDOCTOR_ID);
        }

		/// 
		/// 设置字段VDOCTOR_ID为空值。
		/// 
        public void SetVDOCTOR_IDNull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnVDOCTOR_ID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDOCTOR_NAME是否为空。
		/// 
        public bool IsVDOCTOR_NAMENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnVDOCTOR_NAME);
        }

		/// 
		/// 设置字段VDOCTOR_NAME为空值。
		/// 
        public void SetVDOCTOR_NAMENull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnVDOCTOR_NAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSTATUS是否为空。
		/// 
        public bool IsNSTATUSNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnNSTATUS);
        }

		/// 
		/// 设置字段NSTATUS为空值。
		/// 
        public void SetNSTATUSNull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnNSTATUS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VCHARGE_USER是否为空。
		/// 
        public bool IsVCHARGE_USERNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnVCHARGE_USER);
        }

		/// 
		/// 设置字段VCHARGE_USER为空值。
		/// 
        public void SetVCHARGE_USERNull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnVCHARGE_USER] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DCHARGE_DATE是否为空。
		/// 
        public bool IsDCHARGE_DATENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnDCHARGE_DATE);
        }

		/// 
		/// 设置字段DCHARGE_DATE为空值。
		/// 
        public void SetDCHARGE_DATENull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnDCHARGE_DATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VMEMO是否为空。
		/// 
        public bool IsVMEMONull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnVMEMO);
        }

		/// 
		/// 设置字段VMEMO为空值。
		/// 
        public void SetVMEMONull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnVMEMO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDEPT_CODE是否为空。
		/// 
        public bool IsVDEPT_CODENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnVDEPT_CODE);
        }

		/// 
		/// 设置字段VDEPT_CODE为空值。
		/// 
        public void SetVDEPT_CODENull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnVDEPT_CODE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDEPARTNAME是否为空。
		/// 
        public bool IsVDEPARTNAMENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnVDEPARTNAME);
        }

		/// 
		/// 设置字段VDEPARTNAME为空值。
		/// 
        public void SetVDEPARTNAMENull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnVDEPARTNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VCLINICNO是否为空。
		/// 
        public bool IsVCLINICNONull()
        {
            return this.IsNull(this.tableV_MZ_PRESCMASTER.ColumnVCLINICNO);
        }

		/// 
		/// 设置字段VCLINICNO为空值。
		/// 
        public void SetVCLINICNONull() 
        {
            this[this.tableV_MZ_PRESCMASTER.ColumnVCLINICNO] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventV_MZ_PRESCMASTER : EventArgs {
        
        private RowV_MZ_PRESCMASTER eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventV_MZ_PRESCMASTER(RowV_MZ_PRESCMASTER row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowV_MZ_PRESCMASTER Row {
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
	