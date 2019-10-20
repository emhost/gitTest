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
	#region DataSetV_EXAMITEMS_INFO
	/// 
	/// ,V_EXAMITEMS_INFO的视图实体。
	/// 
    [Serializable()]
    public class DataSetV_EXAMITEMS_INFO : DataSet
    {
	
		private DataTableV_EXAMITEMS_INFO tableV_EXAMITEMS_INFO;

	
        public DataSetV_EXAMITEMS_INFO() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetV_EXAMITEMS_INFO实体。
		/// 
		public DataSetV_EXAMITEMS_INFO GetChangesEntity(DataRowState ds)
		{
			DataSetV_EXAMITEMS_INFO dataSet = (DataSetV_EXAMITEMS_INFO)this.GetChanges(ds);
			return dataSet;		
		}
        
        protected DataSetV_EXAMITEMS_INFO(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
		
                if ((ds.Tables["V_EXAMITEMS_INFO"] != null)) 
                {
                    this.Tables.Add(new DataTableV_EXAMITEMS_INFO(ds.Tables["V_EXAMITEMS_INFO"]));
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
		/// 对于数据表V_EXAMITEMS_INFO的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableV_EXAMITEMS_INFO V_EXAMITEMS_INFO 
		{
			get
			{
				return this.tableV_EXAMITEMS_INFO;
			}
		}	
	
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetV_EXAMITEMS_INFO cln = ((DataSetV_EXAMITEMS_INFO)(base.Clone()));
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
		
			if ((ds.Tables["V_EXAMITEMS_INFO"] != null)) 
			{
				this.Tables.Add(new DataTableV_EXAMITEMS_INFO(ds.Tables["V_EXAMITEMS_INFO"]));
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
		
			this.tableV_EXAMITEMS_INFO = ((DataTableV_EXAMITEMS_INFO)(this.Tables["V_EXAMITEMS_INFO"]));
			if ((this.tableV_EXAMITEMS_INFO != null)) {
				this.tableV_EXAMITEMS_INFO.InitVars();
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
			
			this.tableV_EXAMITEMS_INFO = new DataTableV_EXAMITEMS_INFO();
			this.Tables.Add(this.tableV_EXAMITEMS_INFO);
		
			
		
		}
	
		private bool ShouldSerializeV_EXAMITEMS_INFO() 
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

    public delegate void RowChangeEventHandlerV_EXAMITEMS_INFO(object sender, RowChangeEventV_EXAMITEMS_INFO e);
	
	
	#region DataTableV_EXAMITEMS_INFO
	/// 
	/// 对于数据表V_EXAMITEMS_INFO的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableV_EXAMITEMS_INFO : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVEXAM_ID;
		
        private DataColumn columnVPATIENT_ID;
		
        private DataColumn columnVEXAM_POSITION;
		
        private DataColumn columnDAPPLY_DATE;
		
        private DataColumn columnVAPPLY_DEPT;
		
        private DataColumn columnVAPPLY_DOCTOR;
		
        private DataColumn columnNEXAM_RESULT;
		
        private DataColumn columnMZORZY;
		
        private DataColumn columnVCLINICNO;
		
        private DataColumn columnDEXECUTE;
		
        private DataColumn columnEXEDOCTORNAME;
		
        private DataColumn columnVITEMNAME;
		
        private DataColumn columnVUNITS;
		
        private DataColumn columnNACCOUNT;
		
        private DataColumn columnVNAME;
		
        private DataColumn columnNSEX;
		
        private DataColumn columnNAGE;
		
        private DataColumn columnSQDEPARTNAME;
		
        private DataColumn columnSQDOCTORNAME;
		
        private DataColumn columnVRESULT_DESP;
		
        private DataColumn columnVDIAGNOSE;
		
        internal DataTableV_EXAMITEMS_INFO() : base("V_EXAMITEMS_INFO") 
        {
            this.InitClass();
        }
        
        internal DataTableV_EXAMITEMS_INFO(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVEXAM_ID 
        {
            get 
            {
                return this.columnVEXAM_ID;
            }
        }
		
        public DataColumn ColumnVPATIENT_ID 
        {
            get 
            {
                return this.columnVPATIENT_ID;
            }
        }
		
        public DataColumn ColumnVEXAM_POSITION 
        {
            get 
            {
                return this.columnVEXAM_POSITION;
            }
        }
		
        public DataColumn ColumnDAPPLY_DATE 
        {
            get 
            {
                return this.columnDAPPLY_DATE;
            }
        }
		
        public DataColumn ColumnVAPPLY_DEPT 
        {
            get 
            {
                return this.columnVAPPLY_DEPT;
            }
        }
		
        public DataColumn ColumnVAPPLY_DOCTOR 
        {
            get 
            {
                return this.columnVAPPLY_DOCTOR;
            }
        }
		
        public DataColumn ColumnNEXAM_RESULT 
        {
            get 
            {
                return this.columnNEXAM_RESULT;
            }
        }
		
        public DataColumn ColumnMZORZY 
        {
            get 
            {
                return this.columnMZORZY;
            }
        }
		
        public DataColumn ColumnVCLINICNO 
        {
            get 
            {
                return this.columnVCLINICNO;
            }
        }
		
        public DataColumn ColumnDEXECUTE 
        {
            get 
            {
                return this.columnDEXECUTE;
            }
        }
		
        public DataColumn ColumnEXEDOCTORNAME 
        {
            get 
            {
                return this.columnEXEDOCTORNAME;
            }
        }
		
        public DataColumn ColumnVITEMNAME 
        {
            get 
            {
                return this.columnVITEMNAME;
            }
        }
		
        public DataColumn ColumnVUNITS 
        {
            get 
            {
                return this.columnVUNITS;
            }
        }
		
        public DataColumn ColumnNACCOUNT 
        {
            get 
            {
                return this.columnNACCOUNT;
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
		
        public DataColumn ColumnNAGE 
        {
            get 
            {
                return this.columnNAGE;
            }
        }
		
        public DataColumn ColumnSQDEPARTNAME 
        {
            get 
            {
                return this.columnSQDEPARTNAME;
            }
        }
		
        public DataColumn ColumnSQDOCTORNAME 
        {
            get 
            {
                return this.columnSQDOCTORNAME;
            }
        }
		
        public DataColumn ColumnVRESULT_DESP 
        {
            get 
            {
                return this.columnVRESULT_DESP;
            }
        }
		
        public DataColumn ColumnVDIAGNOSE 
        {
            get 
            {
                return this.columnVDIAGNOSE;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowV_EXAMITEMS_INFO this[int index] 
        {
            get 
            {
                return ((RowV_EXAMITEMS_INFO)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerV_EXAMITEMS_INFO RowChangedV_EXAMITEMS_INFO;
        
        public event RowChangeEventHandlerV_EXAMITEMS_INFO RowChangingV_EXAMITEMS_INFO;
        
        public event RowChangeEventHandlerV_EXAMITEMS_INFO RowDeletedV_EXAMITEMS_INFO;
        
        public event RowChangeEventHandlerV_EXAMITEMS_INFO RowDeletingV_EXAMITEMS_INFO;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowV_EXAMITEMS_INFO(RowV_EXAMITEMS_INFO row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowV_EXAMITEMS_INFO AddRowV_EXAMITEMS_INFO(System.String VEXAM_ID,System.String VPATIENT_ID,System.String VEXAM_POSITION,System.DateTime DAPPLY_DATE,System.String VAPPLY_DEPT,System.String VAPPLY_DOCTOR,System.Int16 NEXAM_RESULT,System.Int16 MZORZY,System.String VCLINICNO,System.DateTime DEXECUTE,System.String EXEDOCTORNAME,System.String VITEMNAME,System.String VUNITS,System.Int16 NACCOUNT,System.String VNAME,System.String NSEX,System.String NAGE,System.String SQDEPARTNAME,System.String SQDOCTORNAME,System.String VRESULT_DESP,System.String VDIAGNOSE) 
        {
            RowV_EXAMITEMS_INFO row = ((RowV_EXAMITEMS_INFO)(this.NewRow()));
            row.ItemArray = new object[] {VEXAM_ID,VPATIENT_ID,VEXAM_POSITION,DAPPLY_DATE,VAPPLY_DEPT,VAPPLY_DOCTOR,NEXAM_RESULT,MZORZY,VCLINICNO,DEXECUTE,EXEDOCTORNAME,VITEMNAME,VUNITS,NACCOUNT,VNAME,NSEX,NAGE,SQDEPARTNAME,SQDOCTORNAME,VRESULT_DESP,VDIAGNOSE};
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
            DataTableV_EXAMITEMS_INFO cln = ((DataTableV_EXAMITEMS_INFO)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableV_EXAMITEMS_INFO();
        }
        
        internal void InitVars() 
        {	
            this.columnVEXAM_ID = this.Columns["VEXAM_ID"];
            this.columnVPATIENT_ID = this.Columns["VPATIENT_ID"];
            this.columnVEXAM_POSITION = this.Columns["VEXAM_POSITION"];
            this.columnDAPPLY_DATE = this.Columns["DAPPLY_DATE"];
            this.columnVAPPLY_DEPT = this.Columns["VAPPLY_DEPT"];
            this.columnVAPPLY_DOCTOR = this.Columns["VAPPLY_DOCTOR"];
            this.columnNEXAM_RESULT = this.Columns["NEXAM_RESULT"];
            this.columnMZORZY = this.Columns["MZORZY"];
            this.columnVCLINICNO = this.Columns["VCLINICNO"];
            this.columnDEXECUTE = this.Columns["DEXECUTE"];
            this.columnEXEDOCTORNAME = this.Columns["EXEDOCTORNAME"];
            this.columnVITEMNAME = this.Columns["VITEMNAME"];
            this.columnVUNITS = this.Columns["VUNITS"];
            this.columnNACCOUNT = this.Columns["NACCOUNT"];
            this.columnVNAME = this.Columns["VNAME"];
            this.columnNSEX = this.Columns["NSEX"];
            this.columnNAGE = this.Columns["NAGE"];
            this.columnSQDEPARTNAME = this.Columns["SQDEPARTNAME"];
            this.columnSQDOCTORNAME = this.Columns["SQDOCTORNAME"];
            this.columnVRESULT_DESP = this.Columns["VRESULT_DESP"];
            this.columnVDIAGNOSE = this.Columns["VDIAGNOSE"];
        }
        
        private void InitClass() 
        {	
            this.columnVEXAM_ID = new DataColumn("VEXAM_ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVEXAM_ID.AllowDBNull = true;
            this.Columns.Add(this.columnVEXAM_ID);
			
            this.columnVPATIENT_ID = new DataColumn("VPATIENT_ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPATIENT_ID.AllowDBNull = true;
            this.Columns.Add(this.columnVPATIENT_ID);
			
            this.columnVEXAM_POSITION = new DataColumn("VEXAM_POSITION", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVEXAM_POSITION.AllowDBNull = true;
            this.Columns.Add(this.columnVEXAM_POSITION);
			
            this.columnDAPPLY_DATE = new DataColumn("DAPPLY_DATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDAPPLY_DATE.AllowDBNull = true;
            this.Columns.Add(this.columnDAPPLY_DATE);
			
            this.columnVAPPLY_DEPT = new DataColumn("VAPPLY_DEPT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVAPPLY_DEPT.AllowDBNull = true;
            this.Columns.Add(this.columnVAPPLY_DEPT);
			
            this.columnVAPPLY_DOCTOR = new DataColumn("VAPPLY_DOCTOR", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVAPPLY_DOCTOR.AllowDBNull = true;
            this.Columns.Add(this.columnVAPPLY_DOCTOR);
			
            this.columnNEXAM_RESULT = new DataColumn("NEXAM_RESULT", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNEXAM_RESULT.AllowDBNull = true;
            this.Columns.Add(this.columnNEXAM_RESULT);
			
            this.columnMZORZY = new DataColumn("MZORZY", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnMZORZY.AllowDBNull = true;
            this.Columns.Add(this.columnMZORZY);
			
            this.columnVCLINICNO = new DataColumn("VCLINICNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCLINICNO.AllowDBNull = true;
            this.Columns.Add(this.columnVCLINICNO);
			
            this.columnDEXECUTE = new DataColumn("DEXECUTE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDEXECUTE.AllowDBNull = true;
            this.Columns.Add(this.columnDEXECUTE);
			
            this.columnEXEDOCTORNAME = new DataColumn("EXEDOCTORNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnEXEDOCTORNAME.AllowDBNull = true;
            this.Columns.Add(this.columnEXEDOCTORNAME);
			
            this.columnVITEMNAME = new DataColumn("VITEMNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEMNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVITEMNAME);
			
            this.columnVUNITS = new DataColumn("VUNITS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVUNITS.AllowDBNull = true;
            this.Columns.Add(this.columnVUNITS);
			
            this.columnNACCOUNT = new DataColumn("NACCOUNT", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNACCOUNT.AllowDBNull = true;
            this.Columns.Add(this.columnNACCOUNT);
			
            this.columnVNAME = new DataColumn("VNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVNAME);
			
            this.columnNSEX = new DataColumn("NSEX", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNSEX.AllowDBNull = true;
            this.Columns.Add(this.columnNSEX);
			
            this.columnNAGE = new DataColumn("NAGE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNAGE.AllowDBNull = true;
            this.Columns.Add(this.columnNAGE);
			
            this.columnSQDEPARTNAME = new DataColumn("SQDEPARTNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnSQDEPARTNAME.AllowDBNull = true;
            this.Columns.Add(this.columnSQDEPARTNAME);
			
            this.columnSQDOCTORNAME = new DataColumn("SQDOCTORNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnSQDOCTORNAME.AllowDBNull = true;
            this.Columns.Add(this.columnSQDOCTORNAME);
			
            this.columnVRESULT_DESP = new DataColumn("VRESULT_DESP", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVRESULT_DESP.AllowDBNull = true;
            this.Columns.Add(this.columnVRESULT_DESP);
			
            this.columnVDIAGNOSE = new DataColumn("VDIAGNOSE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDIAGNOSE.AllowDBNull = true;
            this.Columns.Add(this.columnVDIAGNOSE);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowV_EXAMITEMS_INFO NewRowV_EXAMITEMS_INFO() {
            return ((RowV_EXAMITEMS_INFO)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowV_EXAMITEMS_INFO(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowV_EXAMITEMS_INFO);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedV_EXAMITEMS_INFO != null)) {
                this.RowChangedV_EXAMITEMS_INFO(this, new RowChangeEventV_EXAMITEMS_INFO(((RowV_EXAMITEMS_INFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingV_EXAMITEMS_INFO != null)) {
                this.RowChangingV_EXAMITEMS_INFO(this, new RowChangeEventV_EXAMITEMS_INFO(((RowV_EXAMITEMS_INFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedV_EXAMITEMS_INFO != null)) {
                this.RowDeletedV_EXAMITEMS_INFO(this, new RowChangeEventV_EXAMITEMS_INFO(((RowV_EXAMITEMS_INFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingV_EXAMITEMS_INFO != null)) {
                this.RowDeletingV_EXAMITEMS_INFO(this, new RowChangeEventV_EXAMITEMS_INFO(((RowV_EXAMITEMS_INFO)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowV_EXAMITEMS_INFO(RowV_EXAMITEMS_INFO row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowV_EXAMITEMS_INFO
	/// 
	/// 数据表V_EXAMITEMS_INFO行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowV_EXAMITEMS_INFO : DataRow 
    {
        
        private DataTableV_EXAMITEMS_INFO tableV_EXAMITEMS_INFO;
        
        internal RowV_EXAMITEMS_INFO(DataRowBuilder rb) : base(rb) 
        {
            this.tableV_EXAMITEMS_INFO = ((DataTableV_EXAMITEMS_INFO)(this.Table));
        }        
		
		/// 
		/// 字段VEXAM_ID所映射的属性。
		/// 
        public System.String VEXAM_ID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_EXAMITEMS_INFO.ColumnVEXAM_ID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnVEXAM_ID] = value;
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
	                return ((System.String)(this[this.tableV_EXAMITEMS_INFO.ColumnVPATIENT_ID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnVPATIENT_ID] = value;
            }
        }
        
		/// 
		/// 字段VEXAM_POSITION所映射的属性。
		/// 
        public System.String VEXAM_POSITION
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_EXAMITEMS_INFO.ColumnVEXAM_POSITION])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnVEXAM_POSITION] = value;
            }
        }
        
		/// 
		/// 字段DAPPLY_DATE所映射的属性。
		/// 
        public System.DateTime DAPPLY_DATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableV_EXAMITEMS_INFO.ColumnDAPPLY_DATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnDAPPLY_DATE] = value;
            }
        }
        
		/// 
		/// 字段VAPPLY_DEPT所映射的属性。
		/// 
        public System.String VAPPLY_DEPT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_EXAMITEMS_INFO.ColumnVAPPLY_DEPT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnVAPPLY_DEPT] = value;
            }
        }
        
		/// 
		/// 字段VAPPLY_DOCTOR所映射的属性。
		/// 
        public System.String VAPPLY_DOCTOR
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_EXAMITEMS_INFO.ColumnVAPPLY_DOCTOR])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnVAPPLY_DOCTOR] = value;
            }
        }
        
		/// 
		/// 字段NEXAM_RESULT所映射的属性。
		/// 
        public System.Int16 NEXAM_RESULT
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableV_EXAMITEMS_INFO.ColumnNEXAM_RESULT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnNEXAM_RESULT] = value;
            }
        }
        
		/// 
		/// 字段MZORZY所映射的属性。
		/// 
        public System.Int16 MZORZY
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableV_EXAMITEMS_INFO.ColumnMZORZY])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnMZORZY] = value;
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
	                return ((System.String)(this[this.tableV_EXAMITEMS_INFO.ColumnVCLINICNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnVCLINICNO] = value;
            }
        }
        
		/// 
		/// 字段DEXECUTE所映射的属性。
		/// 
        public System.DateTime DEXECUTE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableV_EXAMITEMS_INFO.ColumnDEXECUTE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnDEXECUTE] = value;
            }
        }
        
		/// 
		/// 字段EXEDOCTORNAME所映射的属性。
		/// 
        public System.String EXEDOCTORNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_EXAMITEMS_INFO.ColumnEXEDOCTORNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnEXEDOCTORNAME] = value;
            }
        }
        
		/// 
		/// 字段VITEMNAME所映射的属性。
		/// 
        public System.String VITEMNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_EXAMITEMS_INFO.ColumnVITEMNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnVITEMNAME] = value;
            }
        }
        
		/// 
		/// 字段VUNITS所映射的属性。
		/// 
        public System.String VUNITS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_EXAMITEMS_INFO.ColumnVUNITS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnVUNITS] = value;
            }
        }
        
		/// 
		/// 字段NACCOUNT所映射的属性。
		/// 
        public System.Int16 NACCOUNT
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableV_EXAMITEMS_INFO.ColumnNACCOUNT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnNACCOUNT] = value;
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
	                return ((System.String)(this[this.tableV_EXAMITEMS_INFO.ColumnVNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnVNAME] = value;
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
	                return ((System.String)(this[this.tableV_EXAMITEMS_INFO.ColumnNSEX])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnNSEX] = value;
            }
        }
        
		/// 
		/// 字段NAGE所映射的属性。
		/// 
        public System.String NAGE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_EXAMITEMS_INFO.ColumnNAGE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnNAGE] = value;
            }
        }
        
		/// 
		/// 字段SQDEPARTNAME所映射的属性。
		/// 
        public System.String SQDEPARTNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_EXAMITEMS_INFO.ColumnSQDEPARTNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnSQDEPARTNAME] = value;
            }
        }
        
		/// 
		/// 字段SQDOCTORNAME所映射的属性。
		/// 
        public System.String SQDOCTORNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_EXAMITEMS_INFO.ColumnSQDOCTORNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnSQDOCTORNAME] = value;
            }
        }
        
		/// 
		/// 字段VRESULT_DESP所映射的属性。
		/// 
        public System.String VRESULT_DESP
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_EXAMITEMS_INFO.ColumnVRESULT_DESP])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnVRESULT_DESP] = value;
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
	                return ((System.String)(this[this.tableV_EXAMITEMS_INFO.ColumnVDIAGNOSE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_EXAMITEMS_INFO.ColumnVDIAGNOSE] = value;
            }
        }
        
		/// 
		/// 判断字段VEXAM_ID是否为空。
		/// 
        public bool IsVEXAM_IDNull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnVEXAM_ID);
        }

		/// 
		/// 设置字段VEXAM_ID为空值。
		/// 
        public void SetVEXAM_IDNull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnVEXAM_ID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPATIENT_ID是否为空。
		/// 
        public bool IsVPATIENT_IDNull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnVPATIENT_ID);
        }

		/// 
		/// 设置字段VPATIENT_ID为空值。
		/// 
        public void SetVPATIENT_IDNull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnVPATIENT_ID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VEXAM_POSITION是否为空。
		/// 
        public bool IsVEXAM_POSITIONNull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnVEXAM_POSITION);
        }

		/// 
		/// 设置字段VEXAM_POSITION为空值。
		/// 
        public void SetVEXAM_POSITIONNull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnVEXAM_POSITION] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DAPPLY_DATE是否为空。
		/// 
        public bool IsDAPPLY_DATENull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnDAPPLY_DATE);
        }

		/// 
		/// 设置字段DAPPLY_DATE为空值。
		/// 
        public void SetDAPPLY_DATENull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnDAPPLY_DATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VAPPLY_DEPT是否为空。
		/// 
        public bool IsVAPPLY_DEPTNull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnVAPPLY_DEPT);
        }

		/// 
		/// 设置字段VAPPLY_DEPT为空值。
		/// 
        public void SetVAPPLY_DEPTNull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnVAPPLY_DEPT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VAPPLY_DOCTOR是否为空。
		/// 
        public bool IsVAPPLY_DOCTORNull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnVAPPLY_DOCTOR);
        }

		/// 
		/// 设置字段VAPPLY_DOCTOR为空值。
		/// 
        public void SetVAPPLY_DOCTORNull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnVAPPLY_DOCTOR] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NEXAM_RESULT是否为空。
		/// 
        public bool IsNEXAM_RESULTNull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnNEXAM_RESULT);
        }

		/// 
		/// 设置字段NEXAM_RESULT为空值。
		/// 
        public void SetNEXAM_RESULTNull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnNEXAM_RESULT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段MZORZY是否为空。
		/// 
        public bool IsMZORZYNull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnMZORZY);
        }

		/// 
		/// 设置字段MZORZY为空值。
		/// 
        public void SetMZORZYNull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnMZORZY] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VCLINICNO是否为空。
		/// 
        public bool IsVCLINICNONull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnVCLINICNO);
        }

		/// 
		/// 设置字段VCLINICNO为空值。
		/// 
        public void SetVCLINICNONull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnVCLINICNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DEXECUTE是否为空。
		/// 
        public bool IsDEXECUTENull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnDEXECUTE);
        }

		/// 
		/// 设置字段DEXECUTE为空值。
		/// 
        public void SetDEXECUTENull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnDEXECUTE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段EXEDOCTORNAME是否为空。
		/// 
        public bool IsEXEDOCTORNAMENull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnEXEDOCTORNAME);
        }

		/// 
		/// 设置字段EXEDOCTORNAME为空值。
		/// 
        public void SetEXEDOCTORNAMENull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnEXEDOCTORNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEMNAME是否为空。
		/// 
        public bool IsVITEMNAMENull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnVITEMNAME);
        }

		/// 
		/// 设置字段VITEMNAME为空值。
		/// 
        public void SetVITEMNAMENull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnVITEMNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VUNITS是否为空。
		/// 
        public bool IsVUNITSNull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnVUNITS);
        }

		/// 
		/// 设置字段VUNITS为空值。
		/// 
        public void SetVUNITSNull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnVUNITS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NACCOUNT是否为空。
		/// 
        public bool IsNACCOUNTNull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnNACCOUNT);
        }

		/// 
		/// 设置字段NACCOUNT为空值。
		/// 
        public void SetNACCOUNTNull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnNACCOUNT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VNAME是否为空。
		/// 
        public bool IsVNAMENull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnVNAME);
        }

		/// 
		/// 设置字段VNAME为空值。
		/// 
        public void SetVNAMENull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnVNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSEX是否为空。
		/// 
        public bool IsNSEXNull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnNSEX);
        }

		/// 
		/// 设置字段NSEX为空值。
		/// 
        public void SetNSEXNull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnNSEX] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NAGE是否为空。
		/// 
        public bool IsNAGENull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnNAGE);
        }

		/// 
		/// 设置字段NAGE为空值。
		/// 
        public void SetNAGENull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnNAGE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段SQDEPARTNAME是否为空。
		/// 
        public bool IsSQDEPARTNAMENull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnSQDEPARTNAME);
        }

		/// 
		/// 设置字段SQDEPARTNAME为空值。
		/// 
        public void SetSQDEPARTNAMENull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnSQDEPARTNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段SQDOCTORNAME是否为空。
		/// 
        public bool IsSQDOCTORNAMENull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnSQDOCTORNAME);
        }

		/// 
		/// 设置字段SQDOCTORNAME为空值。
		/// 
        public void SetSQDOCTORNAMENull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnSQDOCTORNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VRESULT_DESP是否为空。
		/// 
        public bool IsVRESULT_DESPNull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnVRESULT_DESP);
        }

		/// 
		/// 设置字段VRESULT_DESP为空值。
		/// 
        public void SetVRESULT_DESPNull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnVRESULT_DESP] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDIAGNOSE是否为空。
		/// 
        public bool IsVDIAGNOSENull()
        {
            return this.IsNull(this.tableV_EXAMITEMS_INFO.ColumnVDIAGNOSE);
        }

		/// 
		/// 设置字段VDIAGNOSE为空值。
		/// 
        public void SetVDIAGNOSENull() 
        {
            this[this.tableV_EXAMITEMS_INFO.ColumnVDIAGNOSE] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventV_EXAMITEMS_INFO : EventArgs {
        
        private RowV_EXAMITEMS_INFO eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventV_EXAMITEMS_INFO(RowV_EXAMITEMS_INFO row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowV_EXAMITEMS_INFO Row {
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
	