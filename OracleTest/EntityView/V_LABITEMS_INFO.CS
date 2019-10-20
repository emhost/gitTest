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
	#region DataSetV_LABITEMS_INFO
	/// 
	/// ,V_LABITEMS_INFO的视图实体。
	/// 
    [Serializable()]
    public class DataSetV_LABITEMS_INFO : DataSet
    {
	
		private DataTableV_LABITEMS_INFO tableV_LABITEMS_INFO;

	
        public DataSetV_LABITEMS_INFO() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetV_LABITEMS_INFO实体。
		/// 
		public DataSetV_LABITEMS_INFO GetChangesEntity(DataRowState ds)
		{
			DataSetV_LABITEMS_INFO dataSet = (DataSetV_LABITEMS_INFO)this.GetChanges(ds);
			return dataSet;		
		}
        
        protected DataSetV_LABITEMS_INFO(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
		
                if ((ds.Tables["V_LABITEMS_INFO"] != null)) 
                {
                    this.Tables.Add(new DataTableV_LABITEMS_INFO(ds.Tables["V_LABITEMS_INFO"]));
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
		/// 对于数据表V_LABITEMS_INFO的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableV_LABITEMS_INFO V_LABITEMS_INFO 
		{
			get
			{
				return this.tableV_LABITEMS_INFO;
			}
		}	
	
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetV_LABITEMS_INFO cln = ((DataSetV_LABITEMS_INFO)(base.Clone()));
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
		
			if ((ds.Tables["V_LABITEMS_INFO"] != null)) 
			{
				this.Tables.Add(new DataTableV_LABITEMS_INFO(ds.Tables["V_LABITEMS_INFO"]));
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
		
			this.tableV_LABITEMS_INFO = ((DataTableV_LABITEMS_INFO)(this.Tables["V_LABITEMS_INFO"]));
			if ((this.tableV_LABITEMS_INFO != null)) {
				this.tableV_LABITEMS_INFO.InitVars();
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
			
			this.tableV_LABITEMS_INFO = new DataTableV_LABITEMS_INFO();
			this.Tables.Add(this.tableV_LABITEMS_INFO);
		
			
		
		}
	
		private bool ShouldSerializeV_LABITEMS_INFO() 
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

    public delegate void RowChangeEventHandlerV_LABITEMS_INFO(object sender, RowChangeEventV_LABITEMS_INFO e);
	
	
	#region DataTableV_LABITEMS_INFO
	/// 
	/// 对于数据表V_LABITEMS_INFO的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableV_LABITEMS_INFO : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnEXEDOCTORNAME;
		
        private DataColumn columnVLAB_ID;
		
        private DataColumn columnVITEM_CODE;
		
        private DataColumn columnITEMNAMEMX;
		
        private DataColumn columnVITEM_NAME;
		
        private DataColumn columnNUNITS;
		
        private DataColumn columnNACCOUNT;
		
        private DataColumn columnVPATIENT_ID;
		
        private DataColumn columnDAPPLY_DATE;
		
        private DataColumn columnVAPPLY_DEPT;
		
        private DataColumn columnVAPPLY_DOCTOR;
		
        private DataColumn columnNLAB_RESULT;
		
        private DataColumn columnNFLAG;
		
        private DataColumn columnVCLINICNO;
		
        private DataColumn columnDEXECUTE;
		
        private DataColumn columnSQDEPART;
		
        private DataColumn columnSQSTAFFNAME;
		
        private DataColumn columnPATIENTNAME;
		
        private DataColumn columnNSEX;
		
        private DataColumn columnNAGE;
		
        internal DataTableV_LABITEMS_INFO() : base("V_LABITEMS_INFO") 
        {
            this.InitClass();
        }
        
        internal DataTableV_LABITEMS_INFO(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnEXEDOCTORNAME 
        {
            get 
            {
                return this.columnEXEDOCTORNAME;
            }
        }
		
        public DataColumn ColumnVLAB_ID 
        {
            get 
            {
                return this.columnVLAB_ID;
            }
        }
		
        public DataColumn ColumnVITEM_CODE 
        {
            get 
            {
                return this.columnVITEM_CODE;
            }
        }
		
        public DataColumn ColumnITEMNAMEMX 
        {
            get 
            {
                return this.columnITEMNAMEMX;
            }
        }
		
        public DataColumn ColumnVITEM_NAME 
        {
            get 
            {
                return this.columnVITEM_NAME;
            }
        }
		
        public DataColumn ColumnNUNITS 
        {
            get 
            {
                return this.columnNUNITS;
            }
        }
		
        public DataColumn ColumnNACCOUNT 
        {
            get 
            {
                return this.columnNACCOUNT;
            }
        }
		
        public DataColumn ColumnVPATIENT_ID 
        {
            get 
            {
                return this.columnVPATIENT_ID;
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
		
        public DataColumn ColumnNLAB_RESULT 
        {
            get 
            {
                return this.columnNLAB_RESULT;
            }
        }
		
        public DataColumn ColumnNFLAG 
        {
            get 
            {
                return this.columnNFLAG;
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
		
        public DataColumn ColumnSQDEPART 
        {
            get 
            {
                return this.columnSQDEPART;
            }
        }
		
        public DataColumn ColumnSQSTAFFNAME 
        {
            get 
            {
                return this.columnSQSTAFFNAME;
            }
        }
		
        public DataColumn ColumnPATIENTNAME 
        {
            get 
            {
                return this.columnPATIENTNAME;
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
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowV_LABITEMS_INFO this[int index] 
        {
            get 
            {
                return ((RowV_LABITEMS_INFO)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerV_LABITEMS_INFO RowChangedV_LABITEMS_INFO;
        
        public event RowChangeEventHandlerV_LABITEMS_INFO RowChangingV_LABITEMS_INFO;
        
        public event RowChangeEventHandlerV_LABITEMS_INFO RowDeletedV_LABITEMS_INFO;
        
        public event RowChangeEventHandlerV_LABITEMS_INFO RowDeletingV_LABITEMS_INFO;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowV_LABITEMS_INFO(RowV_LABITEMS_INFO row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowV_LABITEMS_INFO AddRowV_LABITEMS_INFO(System.String EXEDOCTORNAME,System.String VLAB_ID,System.String VITEM_CODE,System.String ITEMNAMEMX,System.String VITEM_NAME,System.String NUNITS,System.Int16 NACCOUNT,System.String VPATIENT_ID,System.DateTime DAPPLY_DATE,System.String VAPPLY_DEPT,System.String VAPPLY_DOCTOR,System.Int16 NLAB_RESULT,System.Int16 NFLAG,System.String VCLINICNO,System.DateTime DEXECUTE,System.String SQDEPART,System.String SQSTAFFNAME,System.String PATIENTNAME,System.String NSEX,System.String NAGE) 
        {
            RowV_LABITEMS_INFO row = ((RowV_LABITEMS_INFO)(this.NewRow()));
            row.ItemArray = new object[] {EXEDOCTORNAME,VLAB_ID,VITEM_CODE,ITEMNAMEMX,VITEM_NAME,NUNITS,NACCOUNT,VPATIENT_ID,DAPPLY_DATE,VAPPLY_DEPT,VAPPLY_DOCTOR,NLAB_RESULT,NFLAG,VCLINICNO,DEXECUTE,SQDEPART,SQSTAFFNAME,PATIENTNAME,NSEX,NAGE};
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
            DataTableV_LABITEMS_INFO cln = ((DataTableV_LABITEMS_INFO)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableV_LABITEMS_INFO();
        }
        
        internal void InitVars() 
        {	
            this.columnEXEDOCTORNAME = this.Columns["EXEDOCTORNAME"];
            this.columnVLAB_ID = this.Columns["VLAB_ID"];
            this.columnVITEM_CODE = this.Columns["VITEM_CODE"];
            this.columnITEMNAMEMX = this.Columns["ITEMNAMEMX"];
            this.columnVITEM_NAME = this.Columns["VITEM_NAME"];
            this.columnNUNITS = this.Columns["NUNITS"];
            this.columnNACCOUNT = this.Columns["NACCOUNT"];
            this.columnVPATIENT_ID = this.Columns["VPATIENT_ID"];
            this.columnDAPPLY_DATE = this.Columns["DAPPLY_DATE"];
            this.columnVAPPLY_DEPT = this.Columns["VAPPLY_DEPT"];
            this.columnVAPPLY_DOCTOR = this.Columns["VAPPLY_DOCTOR"];
            this.columnNLAB_RESULT = this.Columns["NLAB_RESULT"];
            this.columnNFLAG = this.Columns["NFLAG"];
            this.columnVCLINICNO = this.Columns["VCLINICNO"];
            this.columnDEXECUTE = this.Columns["DEXECUTE"];
            this.columnSQDEPART = this.Columns["SQDEPART"];
            this.columnSQSTAFFNAME = this.Columns["SQSTAFFNAME"];
            this.columnPATIENTNAME = this.Columns["PATIENTNAME"];
            this.columnNSEX = this.Columns["NSEX"];
            this.columnNAGE = this.Columns["NAGE"];
        }
        
        private void InitClass() 
        {	
            this.columnEXEDOCTORNAME = new DataColumn("EXEDOCTORNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnEXEDOCTORNAME.AllowDBNull = true;
            this.Columns.Add(this.columnEXEDOCTORNAME);
			
            this.columnVLAB_ID = new DataColumn("VLAB_ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVLAB_ID.AllowDBNull = true;
            this.Columns.Add(this.columnVLAB_ID);
			
            this.columnVITEM_CODE = new DataColumn("VITEM_CODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEM_CODE.AllowDBNull = true;
            this.Columns.Add(this.columnVITEM_CODE);
			
            this.columnITEMNAMEMX = new DataColumn("ITEMNAMEMX", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnITEMNAMEMX.AllowDBNull = true;
            this.Columns.Add(this.columnITEMNAMEMX);
			
            this.columnVITEM_NAME = new DataColumn("VITEM_NAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEM_NAME.AllowDBNull = true;
            this.Columns.Add(this.columnVITEM_NAME);
			
            this.columnNUNITS = new DataColumn("NUNITS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNUNITS.AllowDBNull = true;
            this.Columns.Add(this.columnNUNITS);
			
            this.columnNACCOUNT = new DataColumn("NACCOUNT", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNACCOUNT.AllowDBNull = true;
            this.Columns.Add(this.columnNACCOUNT);
			
            this.columnVPATIENT_ID = new DataColumn("VPATIENT_ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPATIENT_ID.AllowDBNull = true;
            this.Columns.Add(this.columnVPATIENT_ID);
			
            this.columnDAPPLY_DATE = new DataColumn("DAPPLY_DATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDAPPLY_DATE.AllowDBNull = true;
            this.Columns.Add(this.columnDAPPLY_DATE);
			
            this.columnVAPPLY_DEPT = new DataColumn("VAPPLY_DEPT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVAPPLY_DEPT.AllowDBNull = true;
            this.Columns.Add(this.columnVAPPLY_DEPT);
			
            this.columnVAPPLY_DOCTOR = new DataColumn("VAPPLY_DOCTOR", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVAPPLY_DOCTOR.AllowDBNull = true;
            this.Columns.Add(this.columnVAPPLY_DOCTOR);
			
            this.columnNLAB_RESULT = new DataColumn("NLAB_RESULT", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNLAB_RESULT.AllowDBNull = true;
            this.Columns.Add(this.columnNLAB_RESULT);
			
            this.columnNFLAG = new DataColumn("NFLAG", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNFLAG.AllowDBNull = true;
            this.Columns.Add(this.columnNFLAG);
			
            this.columnVCLINICNO = new DataColumn("VCLINICNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCLINICNO.AllowDBNull = true;
            this.Columns.Add(this.columnVCLINICNO);
			
            this.columnDEXECUTE = new DataColumn("DEXECUTE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDEXECUTE.AllowDBNull = true;
            this.Columns.Add(this.columnDEXECUTE);
			
            this.columnSQDEPART = new DataColumn("SQDEPART", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnSQDEPART.AllowDBNull = true;
            this.Columns.Add(this.columnSQDEPART);
			
            this.columnSQSTAFFNAME = new DataColumn("SQSTAFFNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnSQSTAFFNAME.AllowDBNull = true;
            this.Columns.Add(this.columnSQSTAFFNAME);
			
            this.columnPATIENTNAME = new DataColumn("PATIENTNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnPATIENTNAME.AllowDBNull = true;
            this.Columns.Add(this.columnPATIENTNAME);
			
            this.columnNSEX = new DataColumn("NSEX", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNSEX.AllowDBNull = true;
            this.Columns.Add(this.columnNSEX);
			
            this.columnNAGE = new DataColumn("NAGE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNAGE.AllowDBNull = true;
            this.Columns.Add(this.columnNAGE);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowV_LABITEMS_INFO NewRowV_LABITEMS_INFO() {
            return ((RowV_LABITEMS_INFO)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowV_LABITEMS_INFO(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowV_LABITEMS_INFO);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedV_LABITEMS_INFO != null)) {
                this.RowChangedV_LABITEMS_INFO(this, new RowChangeEventV_LABITEMS_INFO(((RowV_LABITEMS_INFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingV_LABITEMS_INFO != null)) {
                this.RowChangingV_LABITEMS_INFO(this, new RowChangeEventV_LABITEMS_INFO(((RowV_LABITEMS_INFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedV_LABITEMS_INFO != null)) {
                this.RowDeletedV_LABITEMS_INFO(this, new RowChangeEventV_LABITEMS_INFO(((RowV_LABITEMS_INFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingV_LABITEMS_INFO != null)) {
                this.RowDeletingV_LABITEMS_INFO(this, new RowChangeEventV_LABITEMS_INFO(((RowV_LABITEMS_INFO)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowV_LABITEMS_INFO(RowV_LABITEMS_INFO row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowV_LABITEMS_INFO
	/// 
	/// 数据表V_LABITEMS_INFO行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowV_LABITEMS_INFO : DataRow 
    {
        
        private DataTableV_LABITEMS_INFO tableV_LABITEMS_INFO;
        
        internal RowV_LABITEMS_INFO(DataRowBuilder rb) : base(rb) 
        {
            this.tableV_LABITEMS_INFO = ((DataTableV_LABITEMS_INFO)(this.Table));
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
	                return ((System.String)(this[this.tableV_LABITEMS_INFO.ColumnEXEDOCTORNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnEXEDOCTORNAME] = value;
            }
        }
        
		/// 
		/// 字段VLAB_ID所映射的属性。
		/// 
        public System.String VLAB_ID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_LABITEMS_INFO.ColumnVLAB_ID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnVLAB_ID] = value;
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
	                return ((System.String)(this[this.tableV_LABITEMS_INFO.ColumnVITEM_CODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnVITEM_CODE] = value;
            }
        }
        
		/// 
		/// 字段ITEMNAMEMX所映射的属性。
		/// 
        public System.String ITEMNAMEMX
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_LABITEMS_INFO.ColumnITEMNAMEMX])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnITEMNAMEMX] = value;
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
	                return ((System.String)(this[this.tableV_LABITEMS_INFO.ColumnVITEM_NAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnVITEM_NAME] = value;
            }
        }
        
		/// 
		/// 字段NUNITS所映射的属性。
		/// 
        public System.String NUNITS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_LABITEMS_INFO.ColumnNUNITS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnNUNITS] = value;
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
	                return ((System.Int16)(this[this.tableV_LABITEMS_INFO.ColumnNACCOUNT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnNACCOUNT] = value;
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
	                return ((System.String)(this[this.tableV_LABITEMS_INFO.ColumnVPATIENT_ID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnVPATIENT_ID] = value;
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
	                return ((System.DateTime)(this[this.tableV_LABITEMS_INFO.ColumnDAPPLY_DATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnDAPPLY_DATE] = value;
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
	                return ((System.String)(this[this.tableV_LABITEMS_INFO.ColumnVAPPLY_DEPT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnVAPPLY_DEPT] = value;
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
	                return ((System.String)(this[this.tableV_LABITEMS_INFO.ColumnVAPPLY_DOCTOR])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnVAPPLY_DOCTOR] = value;
            }
        }
        
		/// 
		/// 字段NLAB_RESULT所映射的属性。
		/// 
        public System.Int16 NLAB_RESULT
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableV_LABITEMS_INFO.ColumnNLAB_RESULT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnNLAB_RESULT] = value;
            }
        }
        
		/// 
		/// 字段NFLAG所映射的属性。
		/// 
        public System.Int16 NFLAG
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableV_LABITEMS_INFO.ColumnNFLAG])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnNFLAG] = value;
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
	                return ((System.String)(this[this.tableV_LABITEMS_INFO.ColumnVCLINICNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnVCLINICNO] = value;
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
	                return ((System.DateTime)(this[this.tableV_LABITEMS_INFO.ColumnDEXECUTE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnDEXECUTE] = value;
            }
        }
        
		/// 
		/// 字段SQDEPART所映射的属性。
		/// 
        public System.String SQDEPART
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_LABITEMS_INFO.ColumnSQDEPART])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnSQDEPART] = value;
            }
        }
        
		/// 
		/// 字段SQSTAFFNAME所映射的属性。
		/// 
        public System.String SQSTAFFNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_LABITEMS_INFO.ColumnSQSTAFFNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnSQSTAFFNAME] = value;
            }
        }
        
		/// 
		/// 字段PATIENTNAME所映射的属性。
		/// 
        public System.String PATIENTNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_LABITEMS_INFO.ColumnPATIENTNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnPATIENTNAME] = value;
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
	                return ((System.String)(this[this.tableV_LABITEMS_INFO.ColumnNSEX])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnNSEX] = value;
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
	                return ((System.String)(this[this.tableV_LABITEMS_INFO.ColumnNAGE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_LABITEMS_INFO.ColumnNAGE] = value;
            }
        }
        
		/// 
		/// 判断字段EXEDOCTORNAME是否为空。
		/// 
        public bool IsEXEDOCTORNAMENull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnEXEDOCTORNAME);
        }

		/// 
		/// 设置字段EXEDOCTORNAME为空值。
		/// 
        public void SetEXEDOCTORNAMENull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnEXEDOCTORNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VLAB_ID是否为空。
		/// 
        public bool IsVLAB_IDNull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnVLAB_ID);
        }

		/// 
		/// 设置字段VLAB_ID为空值。
		/// 
        public void SetVLAB_IDNull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnVLAB_ID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEM_CODE是否为空。
		/// 
        public bool IsVITEM_CODENull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnVITEM_CODE);
        }

		/// 
		/// 设置字段VITEM_CODE为空值。
		/// 
        public void SetVITEM_CODENull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnVITEM_CODE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段ITEMNAMEMX是否为空。
		/// 
        public bool IsITEMNAMEMXNull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnITEMNAMEMX);
        }

		/// 
		/// 设置字段ITEMNAMEMX为空值。
		/// 
        public void SetITEMNAMEMXNull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnITEMNAMEMX] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEM_NAME是否为空。
		/// 
        public bool IsVITEM_NAMENull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnVITEM_NAME);
        }

		/// 
		/// 设置字段VITEM_NAME为空值。
		/// 
        public void SetVITEM_NAMENull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnVITEM_NAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NUNITS是否为空。
		/// 
        public bool IsNUNITSNull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnNUNITS);
        }

		/// 
		/// 设置字段NUNITS为空值。
		/// 
        public void SetNUNITSNull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnNUNITS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NACCOUNT是否为空。
		/// 
        public bool IsNACCOUNTNull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnNACCOUNT);
        }

		/// 
		/// 设置字段NACCOUNT为空值。
		/// 
        public void SetNACCOUNTNull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnNACCOUNT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPATIENT_ID是否为空。
		/// 
        public bool IsVPATIENT_IDNull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnVPATIENT_ID);
        }

		/// 
		/// 设置字段VPATIENT_ID为空值。
		/// 
        public void SetVPATIENT_IDNull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnVPATIENT_ID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DAPPLY_DATE是否为空。
		/// 
        public bool IsDAPPLY_DATENull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnDAPPLY_DATE);
        }

		/// 
		/// 设置字段DAPPLY_DATE为空值。
		/// 
        public void SetDAPPLY_DATENull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnDAPPLY_DATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VAPPLY_DEPT是否为空。
		/// 
        public bool IsVAPPLY_DEPTNull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnVAPPLY_DEPT);
        }

		/// 
		/// 设置字段VAPPLY_DEPT为空值。
		/// 
        public void SetVAPPLY_DEPTNull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnVAPPLY_DEPT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VAPPLY_DOCTOR是否为空。
		/// 
        public bool IsVAPPLY_DOCTORNull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnVAPPLY_DOCTOR);
        }

		/// 
		/// 设置字段VAPPLY_DOCTOR为空值。
		/// 
        public void SetVAPPLY_DOCTORNull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnVAPPLY_DOCTOR] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NLAB_RESULT是否为空。
		/// 
        public bool IsNLAB_RESULTNull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnNLAB_RESULT);
        }

		/// 
		/// 设置字段NLAB_RESULT为空值。
		/// 
        public void SetNLAB_RESULTNull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnNLAB_RESULT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NFLAG是否为空。
		/// 
        public bool IsNFLAGNull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnNFLAG);
        }

		/// 
		/// 设置字段NFLAG为空值。
		/// 
        public void SetNFLAGNull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnNFLAG] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VCLINICNO是否为空。
		/// 
        public bool IsVCLINICNONull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnVCLINICNO);
        }

		/// 
		/// 设置字段VCLINICNO为空值。
		/// 
        public void SetVCLINICNONull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnVCLINICNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DEXECUTE是否为空。
		/// 
        public bool IsDEXECUTENull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnDEXECUTE);
        }

		/// 
		/// 设置字段DEXECUTE为空值。
		/// 
        public void SetDEXECUTENull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnDEXECUTE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段SQDEPART是否为空。
		/// 
        public bool IsSQDEPARTNull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnSQDEPART);
        }

		/// 
		/// 设置字段SQDEPART为空值。
		/// 
        public void SetSQDEPARTNull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnSQDEPART] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段SQSTAFFNAME是否为空。
		/// 
        public bool IsSQSTAFFNAMENull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnSQSTAFFNAME);
        }

		/// 
		/// 设置字段SQSTAFFNAME为空值。
		/// 
        public void SetSQSTAFFNAMENull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnSQSTAFFNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段PATIENTNAME是否为空。
		/// 
        public bool IsPATIENTNAMENull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnPATIENTNAME);
        }

		/// 
		/// 设置字段PATIENTNAME为空值。
		/// 
        public void SetPATIENTNAMENull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnPATIENTNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSEX是否为空。
		/// 
        public bool IsNSEXNull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnNSEX);
        }

		/// 
		/// 设置字段NSEX为空值。
		/// 
        public void SetNSEXNull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnNSEX] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NAGE是否为空。
		/// 
        public bool IsNAGENull()
        {
            return this.IsNull(this.tableV_LABITEMS_INFO.ColumnNAGE);
        }

		/// 
		/// 设置字段NAGE为空值。
		/// 
        public void SetNAGENull() 
        {
            this[this.tableV_LABITEMS_INFO.ColumnNAGE] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventV_LABITEMS_INFO : EventArgs {
        
        private RowV_LABITEMS_INFO eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventV_LABITEMS_INFO(RowV_LABITEMS_INFO row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowV_LABITEMS_INFO Row {
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
	