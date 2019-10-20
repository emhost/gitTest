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
	#region DataSetV_PATIENT_ZY_INFO
	/// 
	/// ,V_PATIENT_ZY_INFO的视图实体。
	/// 
    [Serializable()]
    public class DataSetV_PATIENT_ZY_INFO : DataSet
    {
	
		private DataTableV_PATIENT_ZY_INFO tableV_PATIENT_ZY_INFO;

	
        public DataSetV_PATIENT_ZY_INFO() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetV_PATIENT_ZY_INFO实体。
		/// 
		public DataSetV_PATIENT_ZY_INFO GetChangesEntity(DataRowState ds)
		{
			DataSetV_PATIENT_ZY_INFO dataSet = (DataSetV_PATIENT_ZY_INFO)this.GetChanges(ds);
			return dataSet;		
		}
        
        protected DataSetV_PATIENT_ZY_INFO(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
		
                if ((ds.Tables["V_PATIENT_ZY_INFO"] != null)) 
                {
                    this.Tables.Add(new DataTableV_PATIENT_ZY_INFO(ds.Tables["V_PATIENT_ZY_INFO"]));
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
		/// 对于数据表V_PATIENT_ZY_INFO的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableV_PATIENT_ZY_INFO V_PATIENT_ZY_INFO 
		{
			get
			{
				return this.tableV_PATIENT_ZY_INFO;
			}
		}	
	
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetV_PATIENT_ZY_INFO cln = ((DataSetV_PATIENT_ZY_INFO)(base.Clone()));
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
		
			if ((ds.Tables["V_PATIENT_ZY_INFO"] != null)) 
			{
				this.Tables.Add(new DataTableV_PATIENT_ZY_INFO(ds.Tables["V_PATIENT_ZY_INFO"]));
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
		
			this.tableV_PATIENT_ZY_INFO = ((DataTableV_PATIENT_ZY_INFO)(this.Tables["V_PATIENT_ZY_INFO"]));
			if ((this.tableV_PATIENT_ZY_INFO != null)) {
				this.tableV_PATIENT_ZY_INFO.InitVars();
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
			
			this.tableV_PATIENT_ZY_INFO = new DataTableV_PATIENT_ZY_INFO();
			this.Tables.Add(this.tableV_PATIENT_ZY_INFO);
		
			
		
		}
	
		private bool ShouldSerializeV_PATIENT_ZY_INFO() 
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

    public delegate void RowChangeEventHandlerV_PATIENT_ZY_INFO(object sender, RowChangeEventV_PATIENT_ZY_INFO e);
	
	
	#region DataTableV_PATIENT_ZY_INFO
	/// 
	/// 对于数据表V_PATIENT_ZY_INFO的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableV_PATIENT_ZY_INFO : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVPATIENTID;
		
        private DataColumn columnVCLINICNO;
		
        private DataColumn columnVNAME;
		
        private DataColumn columnDVISITDATE;
		
        private DataColumn columnVSEX;
		
        private DataColumn columnVBIRTHDATE;
		
        private DataColumn columnVAGE;
		
        private DataColumn columnVIDNO;
		
        private DataColumn columnVDEPARTNAME;
		
        private DataColumn columnNAPPTIME;
		
        private DataColumn columnNSTATUS;
		
        internal DataTableV_PATIENT_ZY_INFO() : base("V_PATIENT_ZY_INFO") 
        {
            this.InitClass();
        }
        
        internal DataTableV_PATIENT_ZY_INFO(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVPATIENTID 
        {
            get 
            {
                return this.columnVPATIENTID;
            }
        }
		
        public DataColumn ColumnVCLINICNO 
        {
            get 
            {
                return this.columnVCLINICNO;
            }
        }
		
        public DataColumn ColumnVNAME 
        {
            get 
            {
                return this.columnVNAME;
            }
        }
		
        public DataColumn ColumnDVISITDATE 
        {
            get 
            {
                return this.columnDVISITDATE;
            }
        }
		
        public DataColumn ColumnVSEX 
        {
            get 
            {
                return this.columnVSEX;
            }
        }
		
        public DataColumn ColumnVBIRTHDATE 
        {
            get 
            {
                return this.columnVBIRTHDATE;
            }
        }
		
        public DataColumn ColumnVAGE 
        {
            get 
            {
                return this.columnVAGE;
            }
        }
		
        public DataColumn ColumnVIDNO 
        {
            get 
            {
                return this.columnVIDNO;
            }
        }
		
        public DataColumn ColumnVDEPARTNAME 
        {
            get 
            {
                return this.columnVDEPARTNAME;
            }
        }
		
        public DataColumn ColumnNAPPTIME 
        {
            get 
            {
                return this.columnNAPPTIME;
            }
        }
		
        public DataColumn ColumnNSTATUS 
        {
            get 
            {
                return this.columnNSTATUS;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowV_PATIENT_ZY_INFO this[int index] 
        {
            get 
            {
                return ((RowV_PATIENT_ZY_INFO)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerV_PATIENT_ZY_INFO RowChangedV_PATIENT_ZY_INFO;
        
        public event RowChangeEventHandlerV_PATIENT_ZY_INFO RowChangingV_PATIENT_ZY_INFO;
        
        public event RowChangeEventHandlerV_PATIENT_ZY_INFO RowDeletedV_PATIENT_ZY_INFO;
        
        public event RowChangeEventHandlerV_PATIENT_ZY_INFO RowDeletingV_PATIENT_ZY_INFO;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowV_PATIENT_ZY_INFO(RowV_PATIENT_ZY_INFO row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowV_PATIENT_ZY_INFO AddRowV_PATIENT_ZY_INFO(System.String VPATIENTID,System.String VCLINICNO,System.String VNAME,System.DateTime DVISITDATE,System.String VSEX,System.String VBIRTHDATE,System.String VAGE,System.String VIDNO,System.String VDEPARTNAME,System.Int16 NAPPTIME,System.Int16 NSTATUS) 
        {
            RowV_PATIENT_ZY_INFO row = ((RowV_PATIENT_ZY_INFO)(this.NewRow()));
            row.ItemArray = new object[] {VPATIENTID,VCLINICNO,VNAME,DVISITDATE,VSEX,VBIRTHDATE,VAGE,VIDNO,VDEPARTNAME,NAPPTIME,NSTATUS};
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
            DataTableV_PATIENT_ZY_INFO cln = ((DataTableV_PATIENT_ZY_INFO)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableV_PATIENT_ZY_INFO();
        }
        
        internal void InitVars() 
        {	
            this.columnVPATIENTID = this.Columns["VPATIENTID"];
            this.columnVCLINICNO = this.Columns["VCLINICNO"];
            this.columnVNAME = this.Columns["VNAME"];
            this.columnDVISITDATE = this.Columns["DVISITDATE"];
            this.columnVSEX = this.Columns["VSEX"];
            this.columnVBIRTHDATE = this.Columns["VBIRTHDATE"];
            this.columnVAGE = this.Columns["VAGE"];
            this.columnVIDNO = this.Columns["VIDNO"];
            this.columnVDEPARTNAME = this.Columns["VDEPARTNAME"];
            this.columnNAPPTIME = this.Columns["NAPPTIME"];
            this.columnNSTATUS = this.Columns["NSTATUS"];
        }
        
        private void InitClass() 
        {	
            this.columnVPATIENTID = new DataColumn("VPATIENTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPATIENTID.AllowDBNull = true;
            this.Columns.Add(this.columnVPATIENTID);
			
            this.columnVCLINICNO = new DataColumn("VCLINICNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCLINICNO.AllowDBNull = true;
            this.Columns.Add(this.columnVCLINICNO);
			
            this.columnVNAME = new DataColumn("VNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVNAME);
			
            this.columnDVISITDATE = new DataColumn("DVISITDATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDVISITDATE.AllowDBNull = true;
            this.Columns.Add(this.columnDVISITDATE);
			
            this.columnVSEX = new DataColumn("VSEX", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVSEX.AllowDBNull = true;
            this.Columns.Add(this.columnVSEX);
			
            this.columnVBIRTHDATE = new DataColumn("VBIRTHDATE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVBIRTHDATE.AllowDBNull = true;
            this.Columns.Add(this.columnVBIRTHDATE);
			
            this.columnVAGE = new DataColumn("VAGE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVAGE.AllowDBNull = true;
            this.Columns.Add(this.columnVAGE);
			
            this.columnVIDNO = new DataColumn("VIDNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVIDNO.AllowDBNull = true;
            this.Columns.Add(this.columnVIDNO);
			
            this.columnVDEPARTNAME = new DataColumn("VDEPARTNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPARTNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPARTNAME);
			
            this.columnNAPPTIME = new DataColumn("NAPPTIME", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNAPPTIME.AllowDBNull = true;
            this.Columns.Add(this.columnNAPPTIME);
			
            this.columnNSTATUS = new DataColumn("NSTATUS", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNSTATUS.AllowDBNull = true;
            this.Columns.Add(this.columnNSTATUS);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowV_PATIENT_ZY_INFO NewRowV_PATIENT_ZY_INFO() {
            return ((RowV_PATIENT_ZY_INFO)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowV_PATIENT_ZY_INFO(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowV_PATIENT_ZY_INFO);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedV_PATIENT_ZY_INFO != null)) {
                this.RowChangedV_PATIENT_ZY_INFO(this, new RowChangeEventV_PATIENT_ZY_INFO(((RowV_PATIENT_ZY_INFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingV_PATIENT_ZY_INFO != null)) {
                this.RowChangingV_PATIENT_ZY_INFO(this, new RowChangeEventV_PATIENT_ZY_INFO(((RowV_PATIENT_ZY_INFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedV_PATIENT_ZY_INFO != null)) {
                this.RowDeletedV_PATIENT_ZY_INFO(this, new RowChangeEventV_PATIENT_ZY_INFO(((RowV_PATIENT_ZY_INFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingV_PATIENT_ZY_INFO != null)) {
                this.RowDeletingV_PATIENT_ZY_INFO(this, new RowChangeEventV_PATIENT_ZY_INFO(((RowV_PATIENT_ZY_INFO)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowV_PATIENT_ZY_INFO(RowV_PATIENT_ZY_INFO row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowV_PATIENT_ZY_INFO
	/// 
	/// 数据表V_PATIENT_ZY_INFO行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowV_PATIENT_ZY_INFO : DataRow 
    {
        
        private DataTableV_PATIENT_ZY_INFO tableV_PATIENT_ZY_INFO;
        
        internal RowV_PATIENT_ZY_INFO(DataRowBuilder rb) : base(rb) 
        {
            this.tableV_PATIENT_ZY_INFO = ((DataTableV_PATIENT_ZY_INFO)(this.Table));
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
	                return ((System.String)(this[this.tableV_PATIENT_ZY_INFO.ColumnVPATIENTID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_ZY_INFO.ColumnVPATIENTID] = value;
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
	                return ((System.String)(this[this.tableV_PATIENT_ZY_INFO.ColumnVCLINICNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_ZY_INFO.ColumnVCLINICNO] = value;
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
	                return ((System.String)(this[this.tableV_PATIENT_ZY_INFO.ColumnVNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_ZY_INFO.ColumnVNAME] = value;
            }
        }
        
		/// 
		/// 字段DVISITDATE所映射的属性。
		/// 
        public System.DateTime DVISITDATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableV_PATIENT_ZY_INFO.ColumnDVISITDATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_ZY_INFO.ColumnDVISITDATE] = value;
            }
        }
        
		/// 
		/// 字段VSEX所映射的属性。
		/// 
        public System.String VSEX
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_PATIENT_ZY_INFO.ColumnVSEX])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_ZY_INFO.ColumnVSEX] = value;
            }
        }
        
		/// 
		/// 字段VBIRTHDATE所映射的属性。
		/// 
        public System.String VBIRTHDATE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_PATIENT_ZY_INFO.ColumnVBIRTHDATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_ZY_INFO.ColumnVBIRTHDATE] = value;
            }
        }
        
		/// 
		/// 字段VAGE所映射的属性。
		/// 
        public System.String VAGE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_PATIENT_ZY_INFO.ColumnVAGE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_ZY_INFO.ColumnVAGE] = value;
            }
        }
        
		/// 
		/// 字段VIDNO所映射的属性。
		/// 
        public System.String VIDNO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_PATIENT_ZY_INFO.ColumnVIDNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_ZY_INFO.ColumnVIDNO] = value;
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
	                return ((System.String)(this[this.tableV_PATIENT_ZY_INFO.ColumnVDEPARTNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_ZY_INFO.ColumnVDEPARTNAME] = value;
            }
        }
        
		/// 
		/// 字段NAPPTIME所映射的属性。
		/// 
        public System.Int16 NAPPTIME
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableV_PATIENT_ZY_INFO.ColumnNAPPTIME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_ZY_INFO.ColumnNAPPTIME] = value;
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
	                return ((System.Int16)(this[this.tableV_PATIENT_ZY_INFO.ColumnNSTATUS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_ZY_INFO.ColumnNSTATUS] = value;
            }
        }
        
		/// 
		/// 判断字段VPATIENTID是否为空。
		/// 
        public bool IsVPATIENTIDNull()
        {
            return this.IsNull(this.tableV_PATIENT_ZY_INFO.ColumnVPATIENTID);
        }

		/// 
		/// 设置字段VPATIENTID为空值。
		/// 
        public void SetVPATIENTIDNull() 
        {
            this[this.tableV_PATIENT_ZY_INFO.ColumnVPATIENTID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VCLINICNO是否为空。
		/// 
        public bool IsVCLINICNONull()
        {
            return this.IsNull(this.tableV_PATIENT_ZY_INFO.ColumnVCLINICNO);
        }

		/// 
		/// 设置字段VCLINICNO为空值。
		/// 
        public void SetVCLINICNONull() 
        {
            this[this.tableV_PATIENT_ZY_INFO.ColumnVCLINICNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VNAME是否为空。
		/// 
        public bool IsVNAMENull()
        {
            return this.IsNull(this.tableV_PATIENT_ZY_INFO.ColumnVNAME);
        }

		/// 
		/// 设置字段VNAME为空值。
		/// 
        public void SetVNAMENull() 
        {
            this[this.tableV_PATIENT_ZY_INFO.ColumnVNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DVISITDATE是否为空。
		/// 
        public bool IsDVISITDATENull()
        {
            return this.IsNull(this.tableV_PATIENT_ZY_INFO.ColumnDVISITDATE);
        }

		/// 
		/// 设置字段DVISITDATE为空值。
		/// 
        public void SetDVISITDATENull() 
        {
            this[this.tableV_PATIENT_ZY_INFO.ColumnDVISITDATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VSEX是否为空。
		/// 
        public bool IsVSEXNull()
        {
            return this.IsNull(this.tableV_PATIENT_ZY_INFO.ColumnVSEX);
        }

		/// 
		/// 设置字段VSEX为空值。
		/// 
        public void SetVSEXNull() 
        {
            this[this.tableV_PATIENT_ZY_INFO.ColumnVSEX] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VBIRTHDATE是否为空。
		/// 
        public bool IsVBIRTHDATENull()
        {
            return this.IsNull(this.tableV_PATIENT_ZY_INFO.ColumnVBIRTHDATE);
        }

		/// 
		/// 设置字段VBIRTHDATE为空值。
		/// 
        public void SetVBIRTHDATENull() 
        {
            this[this.tableV_PATIENT_ZY_INFO.ColumnVBIRTHDATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VAGE是否为空。
		/// 
        public bool IsVAGENull()
        {
            return this.IsNull(this.tableV_PATIENT_ZY_INFO.ColumnVAGE);
        }

		/// 
		/// 设置字段VAGE为空值。
		/// 
        public void SetVAGENull() 
        {
            this[this.tableV_PATIENT_ZY_INFO.ColumnVAGE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VIDNO是否为空。
		/// 
        public bool IsVIDNONull()
        {
            return this.IsNull(this.tableV_PATIENT_ZY_INFO.ColumnVIDNO);
        }

		/// 
		/// 设置字段VIDNO为空值。
		/// 
        public void SetVIDNONull() 
        {
            this[this.tableV_PATIENT_ZY_INFO.ColumnVIDNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDEPARTNAME是否为空。
		/// 
        public bool IsVDEPARTNAMENull()
        {
            return this.IsNull(this.tableV_PATIENT_ZY_INFO.ColumnVDEPARTNAME);
        }

		/// 
		/// 设置字段VDEPARTNAME为空值。
		/// 
        public void SetVDEPARTNAMENull() 
        {
            this[this.tableV_PATIENT_ZY_INFO.ColumnVDEPARTNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NAPPTIME是否为空。
		/// 
        public bool IsNAPPTIMENull()
        {
            return this.IsNull(this.tableV_PATIENT_ZY_INFO.ColumnNAPPTIME);
        }

		/// 
		/// 设置字段NAPPTIME为空值。
		/// 
        public void SetNAPPTIMENull() 
        {
            this[this.tableV_PATIENT_ZY_INFO.ColumnNAPPTIME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSTATUS是否为空。
		/// 
        public bool IsNSTATUSNull()
        {
            return this.IsNull(this.tableV_PATIENT_ZY_INFO.ColumnNSTATUS);
        }

		/// 
		/// 设置字段NSTATUS为空值。
		/// 
        public void SetNSTATUSNull() 
        {
            this[this.tableV_PATIENT_ZY_INFO.ColumnNSTATUS] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventV_PATIENT_ZY_INFO : EventArgs {
        
        private RowV_PATIENT_ZY_INFO eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventV_PATIENT_ZY_INFO(RowV_PATIENT_ZY_INFO row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowV_PATIENT_ZY_INFO Row {
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
	