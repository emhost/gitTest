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
	#region DataSetV_PATIENT_BASIC_INFO
	/// 
	/// ,V_PATIENT_BASIC_INFO的视图实体。
	/// 
    [Serializable()]
    public class DataSetV_PATIENT_BASIC_INFO : DataSet
    {
	
		private DataTableV_PATIENT_BASIC_INFO tableV_PATIENT_BASIC_INFO;

	
        public DataSetV_PATIENT_BASIC_INFO() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetV_PATIENT_BASIC_INFO实体。
		/// 
		public DataSetV_PATIENT_BASIC_INFO GetChangesEntity(DataRowState ds)
		{
			DataSetV_PATIENT_BASIC_INFO dataSet = (DataSetV_PATIENT_BASIC_INFO)this.GetChanges(ds);
			return dataSet;		
		}
        
        protected DataSetV_PATIENT_BASIC_INFO(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
		
                if ((ds.Tables["V_PATIENT_BASIC_INFO"] != null)) 
                {
                    this.Tables.Add(new DataTableV_PATIENT_BASIC_INFO(ds.Tables["V_PATIENT_BASIC_INFO"]));
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
		/// 对于数据表V_PATIENT_BASIC_INFO的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableV_PATIENT_BASIC_INFO V_PATIENT_BASIC_INFO 
		{
			get
			{
				return this.tableV_PATIENT_BASIC_INFO;
			}
		}	
	
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetV_PATIENT_BASIC_INFO cln = ((DataSetV_PATIENT_BASIC_INFO)(base.Clone()));
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
		
			if ((ds.Tables["V_PATIENT_BASIC_INFO"] != null)) 
			{
				this.Tables.Add(new DataTableV_PATIENT_BASIC_INFO(ds.Tables["V_PATIENT_BASIC_INFO"]));
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
		
			this.tableV_PATIENT_BASIC_INFO = ((DataTableV_PATIENT_BASIC_INFO)(this.Tables["V_PATIENT_BASIC_INFO"]));
			if ((this.tableV_PATIENT_BASIC_INFO != null)) {
				this.tableV_PATIENT_BASIC_INFO.InitVars();
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
			
			this.tableV_PATIENT_BASIC_INFO = new DataTableV_PATIENT_BASIC_INFO();
			this.Tables.Add(this.tableV_PATIENT_BASIC_INFO);
		
			
		
		}
	
		private bool ShouldSerializeV_PATIENT_BASIC_INFO() 
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

    public delegate void RowChangeEventHandlerV_PATIENT_BASIC_INFO(object sender, RowChangeEventV_PATIENT_BASIC_INFO e);
	
	
	#region DataTableV_PATIENT_BASIC_INFO
	/// 
	/// 对于数据表V_PATIENT_BASIC_INFO的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableV_PATIENT_BASIC_INFO : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVPATIENTID;
		
        private DataColumn columnVNAME;
		
        private DataColumn columnVSEX;
		
        private DataColumn columnVBIRTHDATE;
		
        private DataColumn columnVAGE;
		
        private DataColumn columnVIDNO;
		
        private DataColumn columnVBIRTHPLACE;
		
        private DataColumn columnVNATIONNAME;
		
        private DataColumn columnVCOUNTRY;
		
        private DataColumn columnVJIGUAN;
		
        private DataColumn columnVPRESENTADDRESS;
		
        internal DataTableV_PATIENT_BASIC_INFO() : base("V_PATIENT_BASIC_INFO") 
        {
            this.InitClass();
        }
        
        internal DataTableV_PATIENT_BASIC_INFO(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVNAME 
        {
            get 
            {
                return this.columnVNAME;
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
		
        public DataColumn ColumnVBIRTHPLACE 
        {
            get 
            {
                return this.columnVBIRTHPLACE;
            }
        }
		
        public DataColumn ColumnVNATIONNAME 
        {
            get 
            {
                return this.columnVNATIONNAME;
            }
        }
		
        public DataColumn ColumnVCOUNTRY 
        {
            get 
            {
                return this.columnVCOUNTRY;
            }
        }
		
        public DataColumn ColumnVJIGUAN 
        {
            get 
            {
                return this.columnVJIGUAN;
            }
        }
		
        public DataColumn ColumnVPRESENTADDRESS 
        {
            get 
            {
                return this.columnVPRESENTADDRESS;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowV_PATIENT_BASIC_INFO this[int index] 
        {
            get 
            {
                return ((RowV_PATIENT_BASIC_INFO)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerV_PATIENT_BASIC_INFO RowChangedV_PATIENT_BASIC_INFO;
        
        public event RowChangeEventHandlerV_PATIENT_BASIC_INFO RowChangingV_PATIENT_BASIC_INFO;
        
        public event RowChangeEventHandlerV_PATIENT_BASIC_INFO RowDeletedV_PATIENT_BASIC_INFO;
        
        public event RowChangeEventHandlerV_PATIENT_BASIC_INFO RowDeletingV_PATIENT_BASIC_INFO;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowV_PATIENT_BASIC_INFO(RowV_PATIENT_BASIC_INFO row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowV_PATIENT_BASIC_INFO AddRowV_PATIENT_BASIC_INFO(System.String VPATIENTID,System.String VNAME,System.String VSEX,System.String VBIRTHDATE,System.String VAGE,System.String VIDNO,System.String VBIRTHPLACE,System.String VNATIONNAME,System.String VCOUNTRY,System.String VJIGUAN,System.String VPRESENTADDRESS) 
        {
            RowV_PATIENT_BASIC_INFO row = ((RowV_PATIENT_BASIC_INFO)(this.NewRow()));
            row.ItemArray = new object[] {VPATIENTID,VNAME,VSEX,VBIRTHDATE,VAGE,VIDNO,VBIRTHPLACE,VNATIONNAME,VCOUNTRY,VJIGUAN,VPRESENTADDRESS};
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
            DataTableV_PATIENT_BASIC_INFO cln = ((DataTableV_PATIENT_BASIC_INFO)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableV_PATIENT_BASIC_INFO();
        }
        
        internal void InitVars() 
        {	
            this.columnVPATIENTID = this.Columns["VPATIENTID"];
            this.columnVNAME = this.Columns["VNAME"];
            this.columnVSEX = this.Columns["VSEX"];
            this.columnVBIRTHDATE = this.Columns["VBIRTHDATE"];
            this.columnVAGE = this.Columns["VAGE"];
            this.columnVIDNO = this.Columns["VIDNO"];
            this.columnVBIRTHPLACE = this.Columns["VBIRTHPLACE"];
            this.columnVNATIONNAME = this.Columns["VNATIONNAME"];
            this.columnVCOUNTRY = this.Columns["VCOUNTRY"];
            this.columnVJIGUAN = this.Columns["VJIGUAN"];
            this.columnVPRESENTADDRESS = this.Columns["VPRESENTADDRESS"];
        }
        
        private void InitClass() 
        {	
            this.columnVPATIENTID = new DataColumn("VPATIENTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPATIENTID.AllowDBNull = true;
            this.Columns.Add(this.columnVPATIENTID);
			
            this.columnVNAME = new DataColumn("VNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVNAME);
			
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
			
            this.columnVBIRTHPLACE = new DataColumn("VBIRTHPLACE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVBIRTHPLACE.AllowDBNull = true;
            this.Columns.Add(this.columnVBIRTHPLACE);
			
            this.columnVNATIONNAME = new DataColumn("VNATIONNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNATIONNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVNATIONNAME);
			
            this.columnVCOUNTRY = new DataColumn("VCOUNTRY", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCOUNTRY.AllowDBNull = true;
            this.Columns.Add(this.columnVCOUNTRY);
			
            this.columnVJIGUAN = new DataColumn("VJIGUAN", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVJIGUAN.AllowDBNull = true;
            this.Columns.Add(this.columnVJIGUAN);
			
            this.columnVPRESENTADDRESS = new DataColumn("VPRESENTADDRESS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPRESENTADDRESS.AllowDBNull = true;
            this.Columns.Add(this.columnVPRESENTADDRESS);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowV_PATIENT_BASIC_INFO NewRowV_PATIENT_BASIC_INFO() {
            return ((RowV_PATIENT_BASIC_INFO)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowV_PATIENT_BASIC_INFO(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowV_PATIENT_BASIC_INFO);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedV_PATIENT_BASIC_INFO != null)) {
                this.RowChangedV_PATIENT_BASIC_INFO(this, new RowChangeEventV_PATIENT_BASIC_INFO(((RowV_PATIENT_BASIC_INFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingV_PATIENT_BASIC_INFO != null)) {
                this.RowChangingV_PATIENT_BASIC_INFO(this, new RowChangeEventV_PATIENT_BASIC_INFO(((RowV_PATIENT_BASIC_INFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedV_PATIENT_BASIC_INFO != null)) {
                this.RowDeletedV_PATIENT_BASIC_INFO(this, new RowChangeEventV_PATIENT_BASIC_INFO(((RowV_PATIENT_BASIC_INFO)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingV_PATIENT_BASIC_INFO != null)) {
                this.RowDeletingV_PATIENT_BASIC_INFO(this, new RowChangeEventV_PATIENT_BASIC_INFO(((RowV_PATIENT_BASIC_INFO)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowV_PATIENT_BASIC_INFO(RowV_PATIENT_BASIC_INFO row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowV_PATIENT_BASIC_INFO
	/// 
	/// 数据表V_PATIENT_BASIC_INFO行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowV_PATIENT_BASIC_INFO : DataRow 
    {
        
        private DataTableV_PATIENT_BASIC_INFO tableV_PATIENT_BASIC_INFO;
        
        internal RowV_PATIENT_BASIC_INFO(DataRowBuilder rb) : base(rb) 
        {
            this.tableV_PATIENT_BASIC_INFO = ((DataTableV_PATIENT_BASIC_INFO)(this.Table));
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
	                return ((System.String)(this[this.tableV_PATIENT_BASIC_INFO.ColumnVPATIENTID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_BASIC_INFO.ColumnVPATIENTID] = value;
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
	                return ((System.String)(this[this.tableV_PATIENT_BASIC_INFO.ColumnVNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_BASIC_INFO.ColumnVNAME] = value;
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
	                return ((System.String)(this[this.tableV_PATIENT_BASIC_INFO.ColumnVSEX])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_BASIC_INFO.ColumnVSEX] = value;
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
	                return ((System.String)(this[this.tableV_PATIENT_BASIC_INFO.ColumnVBIRTHDATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_BASIC_INFO.ColumnVBIRTHDATE] = value;
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
	                return ((System.String)(this[this.tableV_PATIENT_BASIC_INFO.ColumnVAGE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_BASIC_INFO.ColumnVAGE] = value;
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
	                return ((System.String)(this[this.tableV_PATIENT_BASIC_INFO.ColumnVIDNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_BASIC_INFO.ColumnVIDNO] = value;
            }
        }
        
		/// 
		/// 字段VBIRTHPLACE所映射的属性。
		/// 
        public System.String VBIRTHPLACE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_PATIENT_BASIC_INFO.ColumnVBIRTHPLACE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_BASIC_INFO.ColumnVBIRTHPLACE] = value;
            }
        }
        
		/// 
		/// 字段VNATIONNAME所映射的属性。
		/// 
        public System.String VNATIONNAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_PATIENT_BASIC_INFO.ColumnVNATIONNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_BASIC_INFO.ColumnVNATIONNAME] = value;
            }
        }
        
		/// 
		/// 字段VCOUNTRY所映射的属性。
		/// 
        public System.String VCOUNTRY
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_PATIENT_BASIC_INFO.ColumnVCOUNTRY])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_BASIC_INFO.ColumnVCOUNTRY] = value;
            }
        }
        
		/// 
		/// 字段VJIGUAN所映射的属性。
		/// 
        public System.String VJIGUAN
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_PATIENT_BASIC_INFO.ColumnVJIGUAN])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_BASIC_INFO.ColumnVJIGUAN] = value;
            }
        }
        
		/// 
		/// 字段VPRESENTADDRESS所映射的属性。
		/// 
        public System.String VPRESENTADDRESS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_PATIENT_BASIC_INFO.ColumnVPRESENTADDRESS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_PATIENT_BASIC_INFO.ColumnVPRESENTADDRESS] = value;
            }
        }
        
		/// 
		/// 判断字段VPATIENTID是否为空。
		/// 
        public bool IsVPATIENTIDNull()
        {
            return this.IsNull(this.tableV_PATIENT_BASIC_INFO.ColumnVPATIENTID);
        }

		/// 
		/// 设置字段VPATIENTID为空值。
		/// 
        public void SetVPATIENTIDNull() 
        {
            this[this.tableV_PATIENT_BASIC_INFO.ColumnVPATIENTID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VNAME是否为空。
		/// 
        public bool IsVNAMENull()
        {
            return this.IsNull(this.tableV_PATIENT_BASIC_INFO.ColumnVNAME);
        }

		/// 
		/// 设置字段VNAME为空值。
		/// 
        public void SetVNAMENull() 
        {
            this[this.tableV_PATIENT_BASIC_INFO.ColumnVNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VSEX是否为空。
		/// 
        public bool IsVSEXNull()
        {
            return this.IsNull(this.tableV_PATIENT_BASIC_INFO.ColumnVSEX);
        }

		/// 
		/// 设置字段VSEX为空值。
		/// 
        public void SetVSEXNull() 
        {
            this[this.tableV_PATIENT_BASIC_INFO.ColumnVSEX] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VBIRTHDATE是否为空。
		/// 
        public bool IsVBIRTHDATENull()
        {
            return this.IsNull(this.tableV_PATIENT_BASIC_INFO.ColumnVBIRTHDATE);
        }

		/// 
		/// 设置字段VBIRTHDATE为空值。
		/// 
        public void SetVBIRTHDATENull() 
        {
            this[this.tableV_PATIENT_BASIC_INFO.ColumnVBIRTHDATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VAGE是否为空。
		/// 
        public bool IsVAGENull()
        {
            return this.IsNull(this.tableV_PATIENT_BASIC_INFO.ColumnVAGE);
        }

		/// 
		/// 设置字段VAGE为空值。
		/// 
        public void SetVAGENull() 
        {
            this[this.tableV_PATIENT_BASIC_INFO.ColumnVAGE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VIDNO是否为空。
		/// 
        public bool IsVIDNONull()
        {
            return this.IsNull(this.tableV_PATIENT_BASIC_INFO.ColumnVIDNO);
        }

		/// 
		/// 设置字段VIDNO为空值。
		/// 
        public void SetVIDNONull() 
        {
            this[this.tableV_PATIENT_BASIC_INFO.ColumnVIDNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VBIRTHPLACE是否为空。
		/// 
        public bool IsVBIRTHPLACENull()
        {
            return this.IsNull(this.tableV_PATIENT_BASIC_INFO.ColumnVBIRTHPLACE);
        }

		/// 
		/// 设置字段VBIRTHPLACE为空值。
		/// 
        public void SetVBIRTHPLACENull() 
        {
            this[this.tableV_PATIENT_BASIC_INFO.ColumnVBIRTHPLACE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VNATIONNAME是否为空。
		/// 
        public bool IsVNATIONNAMENull()
        {
            return this.IsNull(this.tableV_PATIENT_BASIC_INFO.ColumnVNATIONNAME);
        }

		/// 
		/// 设置字段VNATIONNAME为空值。
		/// 
        public void SetVNATIONNAMENull() 
        {
            this[this.tableV_PATIENT_BASIC_INFO.ColumnVNATIONNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VCOUNTRY是否为空。
		/// 
        public bool IsVCOUNTRYNull()
        {
            return this.IsNull(this.tableV_PATIENT_BASIC_INFO.ColumnVCOUNTRY);
        }

		/// 
		/// 设置字段VCOUNTRY为空值。
		/// 
        public void SetVCOUNTRYNull() 
        {
            this[this.tableV_PATIENT_BASIC_INFO.ColumnVCOUNTRY] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VJIGUAN是否为空。
		/// 
        public bool IsVJIGUANNull()
        {
            return this.IsNull(this.tableV_PATIENT_BASIC_INFO.ColumnVJIGUAN);
        }

		/// 
		/// 设置字段VJIGUAN为空值。
		/// 
        public void SetVJIGUANNull() 
        {
            this[this.tableV_PATIENT_BASIC_INFO.ColumnVJIGUAN] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPRESENTADDRESS是否为空。
		/// 
        public bool IsVPRESENTADDRESSNull()
        {
            return this.IsNull(this.tableV_PATIENT_BASIC_INFO.ColumnVPRESENTADDRESS);
        }

		/// 
		/// 设置字段VPRESENTADDRESS为空值。
		/// 
        public void SetVPRESENTADDRESSNull() 
        {
            this[this.tableV_PATIENT_BASIC_INFO.ColumnVPRESENTADDRESS] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventV_PATIENT_BASIC_INFO : EventArgs {
        
        private RowV_PATIENT_BASIC_INFO eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventV_PATIENT_BASIC_INFO(RowV_PATIENT_BASIC_INFO row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowV_PATIENT_BASIC_INFO Row {
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
	