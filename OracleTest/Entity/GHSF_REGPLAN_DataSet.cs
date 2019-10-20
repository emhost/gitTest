//------------------------------------------------------------------------------
//     这部分代码属于实体定义层，是由实体编辑器工具自动产生的。
//     (Runtime Version: 2.2017.3.2)
//     对此代码进行的任何修改会导致其它的行为错误，并且重新生成时所有的修改会丢失。
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Xml;
using System.Runtime.Serialization;

namespace HYGHSF.Entity
{
	#region DataSetGHSF_REGPLAN
	/// 
	/// 对于GHSF_REGPLAN的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetGHSF_REGPLAN : DataSet
    {
		
		private DataTableGHSF_GHSF_REGPLAN tableGHSF_GHSF_REGPLAN;
		
        public DataSetGHSF_REGPLAN() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetGHSF_REGPLAN实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetGHSF_REGPLAN GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetGHSF_REGPLAN dataSet = (DataSetGHSF_REGPLAN)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetGHSF_REGPLAN entity = new DataSetGHSF_REGPLAN();
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
        
        protected DataSetGHSF_REGPLAN(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["GHSF_GHSF_REGPLAN"] != null)) 
                {
                    this.Tables.Add(new DataTableGHSF_GHSF_REGPLAN(ds.Tables["GHSF_GHSF_REGPLAN"]));
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
		/// 对于数据表GHSF_GHSF_REGPLAN的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableGHSF_GHSF_REGPLAN GHSF_GHSF_REGPLAN 
		{
			get
			{
				return this.tableGHSF_GHSF_REGPLAN;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetGHSF_REGPLAN cln = ((DataSetGHSF_REGPLAN)(base.Clone()));
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
			
			if ((ds.Tables["GHSF_GHSF_REGPLAN"] != null)) 
			{
				this.Tables.Add(new DataTableGHSF_GHSF_REGPLAN(ds.Tables["GHSF_GHSF_REGPLAN"]));
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
			
			this.tableGHSF_GHSF_REGPLAN = ((DataTableGHSF_GHSF_REGPLAN)(this.Tables["GHSF_GHSF_REGPLAN"]));
			if ((this.tableGHSF_GHSF_REGPLAN != null)) {
				this.tableGHSF_GHSF_REGPLAN.InitVars();
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
			
			this.tableGHSF_GHSF_REGPLAN = new DataTableGHSF_GHSF_REGPLAN();
			this.Tables.Add(this.tableGHSF_GHSF_REGPLAN);
			
		}
		
		private bool ShouldSerializeGHSF_GHSF_REGPLAN() 
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
	
    public delegate void RowChangeEventHandlerGHSF_GHSF_REGPLAN(object sender, RowChangeEventGHSF_GHSF_REGPLAN e);
	
	#region DataTableGHSF_GHSF_REGPLAN
	/// 
	/// 对于数据表GHSF_GHSF_REGPLAN的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableGHSF_GHSF_REGPLAN : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVPLANID;
		
        private DataColumn columnVDOCTORID;
		
        private DataColumn columnNTIMEDESC;
		
        private DataColumn columnNREGLIMITS;
		
        private DataColumn columnNAPPLIMITS;
		
        private DataColumn columnNREGNUMBER;
		
        private DataColumn columnNAPPNUMBER;
		
        private DataColumn columnNREGPRICE;
		
        private DataColumn columnVOPERATORID;
		
        private DataColumn columnDCREATEDATE;
		
        private DataColumn columnVREMARKS;
		
        private DataColumn columnDCLINICDATE;
		
        private DataColumn columnVDEPTID;
		
        private DataColumn columnNHOSID;
		
        internal DataTableGHSF_GHSF_REGPLAN() : base("GHSF_GHSF_REGPLAN") 
        {
            this.InitClass();
        }
        
        internal DataTableGHSF_GHSF_REGPLAN(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVPLANID 
        {
            get 
            {
                return this.columnVPLANID;
            }
        }
		
        public DataColumn ColumnVDOCTORID 
        {
            get 
            {
                return this.columnVDOCTORID;
            }
        }
		
        public DataColumn ColumnNTIMEDESC 
        {
            get 
            {
                return this.columnNTIMEDESC;
            }
        }
		
        public DataColumn ColumnNREGLIMITS 
        {
            get 
            {
                return this.columnNREGLIMITS;
            }
        }
		
        public DataColumn ColumnNAPPLIMITS 
        {
            get 
            {
                return this.columnNAPPLIMITS;
            }
        }
		
        public DataColumn ColumnNREGNUMBER 
        {
            get 
            {
                return this.columnNREGNUMBER;
            }
        }
		
        public DataColumn ColumnNAPPNUMBER 
        {
            get 
            {
                return this.columnNAPPNUMBER;
            }
        }
		
        public DataColumn ColumnNREGPRICE 
        {
            get 
            {
                return this.columnNREGPRICE;
            }
        }
		
        public DataColumn ColumnVOPERATORID 
        {
            get 
            {
                return this.columnVOPERATORID;
            }
        }
		
        public DataColumn ColumnDCREATEDATE 
        {
            get 
            {
                return this.columnDCREATEDATE;
            }
        }
		
        public DataColumn ColumnVREMARKS 
        {
            get 
            {
                return this.columnVREMARKS;
            }
        }
		
        public DataColumn ColumnDCLINICDATE 
        {
            get 
            {
                return this.columnDCLINICDATE;
            }
        }
		
        public DataColumn ColumnVDEPTID 
        {
            get 
            {
                return this.columnVDEPTID;
            }
        }
		
        public DataColumn ColumnNHOSID 
        {
            get 
            {
                return this.columnNHOSID;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowGHSF_GHSF_REGPLAN this[int index] 
        {
            get 
            {
                return ((RowGHSF_GHSF_REGPLAN)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerGHSF_GHSF_REGPLAN RowChangedGHSF_GHSF_REGPLAN;
        
        public event RowChangeEventHandlerGHSF_GHSF_REGPLAN RowChangingGHSF_GHSF_REGPLAN;
        
        public event RowChangeEventHandlerGHSF_GHSF_REGPLAN RowDeletedGHSF_GHSF_REGPLAN;
        
        public event RowChangeEventHandlerGHSF_GHSF_REGPLAN RowDeletingGHSF_GHSF_REGPLAN;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowGHSF_GHSF_REGPLAN(RowGHSF_GHSF_REGPLAN row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowGHSF_GHSF_REGPLAN AddRowGHSF_GHSF_REGPLAN(System.String VPLANID,System.String VDOCTORID,System.Int16 NTIMEDESC,System.Int32 NREGLIMITS,System.Int32 NAPPLIMITS,System.Int32 NREGNUMBER,System.Int32 NAPPNUMBER,System.Int32 NREGPRICE,System.String VOPERATORID,System.DateTime DCREATEDATE,System.String VREMARKS,System.DateTime DCLINICDATE,System.String VDEPTID,System.Int32 NHOSID) 
        {
            RowGHSF_GHSF_REGPLAN row = ((RowGHSF_GHSF_REGPLAN)(this.NewRow()));
            row.ItemArray = new object[] {VPLANID,VDOCTORID,NTIMEDESC,NREGLIMITS,NAPPLIMITS,NREGNUMBER,NAPPNUMBER,NREGPRICE,VOPERATORID,DCREATEDATE,VREMARKS,DCLINICDATE,VDEPTID,NHOSID};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowGHSF_GHSF_REGPLAN FindByVPLANID(System.String VPLANID) {
            return ((RowGHSF_GHSF_REGPLAN)(this.Rows.Find(new object[] {
                        VPLANID})));
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
            DataTableGHSF_GHSF_REGPLAN cln = ((DataTableGHSF_GHSF_REGPLAN)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableGHSF_GHSF_REGPLAN();
        }
        
        internal void InitVars() 
        {	
            this.columnVPLANID = this.Columns["VPLANID"];
            this.columnVDOCTORID = this.Columns["VDOCTORID"];
            this.columnNTIMEDESC = this.Columns["NTIMEDESC"];
            this.columnNREGLIMITS = this.Columns["NREGLIMITS"];
            this.columnNAPPLIMITS = this.Columns["NAPPLIMITS"];
            this.columnNREGNUMBER = this.Columns["NREGNUMBER"];
            this.columnNAPPNUMBER = this.Columns["NAPPNUMBER"];
            this.columnNREGPRICE = this.Columns["NREGPRICE"];
            this.columnVOPERATORID = this.Columns["VOPERATORID"];
            this.columnDCREATEDATE = this.Columns["DCREATEDATE"];
            this.columnVREMARKS = this.Columns["VREMARKS"];
            this.columnDCLINICDATE = this.Columns["DCLINICDATE"];
            this.columnVDEPTID = this.Columns["VDEPTID"];
            this.columnNHOSID = this.Columns["NHOSID"];
        }
        
        private void InitClass() 
        {	
            this.columnVPLANID = new DataColumn("VPLANID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPLANID.MaxLength = 10;
            this.columnVPLANID.AllowDBNull = false;
            this.columnVPLANID.Unique = true;
            
            this.Columns.Add(this.columnVPLANID);
			
            this.columnVDOCTORID = new DataColumn("VDOCTORID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDOCTORID.MaxLength = 10;
            this.columnVDOCTORID.AllowDBNull = true;
            this.Columns.Add(this.columnVDOCTORID);
			
            this.columnNTIMEDESC = new DataColumn("NTIMEDESC", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNTIMEDESC.AllowDBNull = true;
            this.Columns.Add(this.columnNTIMEDESC);
			
            this.columnNREGLIMITS = new DataColumn("NREGLIMITS", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNREGLIMITS.AllowDBNull = true;
            this.Columns.Add(this.columnNREGLIMITS);
			
            this.columnNAPPLIMITS = new DataColumn("NAPPLIMITS", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNAPPLIMITS.AllowDBNull = true;
            this.Columns.Add(this.columnNAPPLIMITS);
			
            this.columnNREGNUMBER = new DataColumn("NREGNUMBER", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNREGNUMBER.AllowDBNull = true;
            this.Columns.Add(this.columnNREGNUMBER);
			
            this.columnNAPPNUMBER = new DataColumn("NAPPNUMBER", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNAPPNUMBER.AllowDBNull = true;
            this.Columns.Add(this.columnNAPPNUMBER);
			
            this.columnNREGPRICE = new DataColumn("NREGPRICE", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNREGPRICE.AllowDBNull = true;
            this.Columns.Add(this.columnNREGPRICE);
			
            this.columnVOPERATORID = new DataColumn("VOPERATORID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVOPERATORID.MaxLength = 20;
            this.columnVOPERATORID.AllowDBNull = true;
            this.Columns.Add(this.columnVOPERATORID);
			
            this.columnDCREATEDATE = new DataColumn("DCREATEDATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDCREATEDATE.AllowDBNull = true;
            this.Columns.Add(this.columnDCREATEDATE);
			
            this.columnVREMARKS = new DataColumn("VREMARKS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVREMARKS.MaxLength = 50;
            this.columnVREMARKS.AllowDBNull = true;
            this.Columns.Add(this.columnVREMARKS);
			
            this.columnDCLINICDATE = new DataColumn("DCLINICDATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDCLINICDATE.AllowDBNull = false;
            this.Columns.Add(this.columnDCLINICDATE);
			
            this.columnVDEPTID = new DataColumn("VDEPTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPTID.MaxLength = 20;
            this.columnVDEPTID.AllowDBNull = false;
            this.Columns.Add(this.columnVDEPTID);
			
            this.columnNHOSID = new DataColumn("NHOSID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNHOSID.AllowDBNull = true;
            this.Columns.Add(this.columnNHOSID);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowGHSF_GHSF_REGPLAN NewRowGHSF_GHSF_REGPLAN() {
            return ((RowGHSF_GHSF_REGPLAN)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowGHSF_GHSF_REGPLAN(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowGHSF_GHSF_REGPLAN);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedGHSF_GHSF_REGPLAN != null)) {
                this.RowChangedGHSF_GHSF_REGPLAN(this, new RowChangeEventGHSF_GHSF_REGPLAN(((RowGHSF_GHSF_REGPLAN)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingGHSF_GHSF_REGPLAN != null)) {
                this.RowChangingGHSF_GHSF_REGPLAN(this, new RowChangeEventGHSF_GHSF_REGPLAN(((RowGHSF_GHSF_REGPLAN)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedGHSF_GHSF_REGPLAN != null)) {
                this.RowDeletedGHSF_GHSF_REGPLAN(this, new RowChangeEventGHSF_GHSF_REGPLAN(((RowGHSF_GHSF_REGPLAN)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingGHSF_GHSF_REGPLAN != null)) {
                this.RowDeletingGHSF_GHSF_REGPLAN(this, new RowChangeEventGHSF_GHSF_REGPLAN(((RowGHSF_GHSF_REGPLAN)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowGHSF_GHSF_REGPLAN(RowGHSF_GHSF_REGPLAN row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowGHSF_GHSF_REGPLAN
	/// 
	/// 数据表GHSF_GHSF_REGPLAN行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowGHSF_GHSF_REGPLAN : DataRow 
    {
        
        private DataTableGHSF_GHSF_REGPLAN tableGHSF_GHSF_REGPLAN;
        
        internal RowGHSF_GHSF_REGPLAN(DataRowBuilder rb) : base(rb) 
        {
            this.tableGHSF_GHSF_REGPLAN = ((DataTableGHSF_GHSF_REGPLAN)(this.Table));
        }        
		
		/// 
		/// 字段VPLANID所映射的属性。
		/// 
        public System.String VPLANID
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_REGPLAN.ColumnVPLANID])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGPLAN.ColumnVPLANID] = value;
            }
        }
        
		/// 
		/// 字段VDOCTORID所映射的属性。
		/// 
        public System.String VDOCTORID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGPLAN.ColumnVDOCTORID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGPLAN.ColumnVDOCTORID] = value;
            }
        }
        
		/// 
		/// 字段NTIMEDESC所映射的属性。
		/// 
        public System.Int16 NTIMEDESC
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_REGPLAN.ColumnNTIMEDESC])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGPLAN.ColumnNTIMEDESC] = value;
            }
        }
        
		/// 
		/// 字段NREGLIMITS所映射的属性。
		/// 
        public System.Int32 NREGLIMITS
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_REGPLAN.ColumnNREGLIMITS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGPLAN.ColumnNREGLIMITS] = value;
            }
        }
        
		/// 
		/// 字段NAPPLIMITS所映射的属性。
		/// 
        public System.Int32 NAPPLIMITS
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_REGPLAN.ColumnNAPPLIMITS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGPLAN.ColumnNAPPLIMITS] = value;
            }
        }
        
		/// 
		/// 字段NREGNUMBER所映射的属性。
		/// 
        public System.Int32 NREGNUMBER
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_REGPLAN.ColumnNREGNUMBER])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGPLAN.ColumnNREGNUMBER] = value;
            }
        }
        
		/// 
		/// 字段NAPPNUMBER所映射的属性。
		/// 
        public System.Int32 NAPPNUMBER
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_REGPLAN.ColumnNAPPNUMBER])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGPLAN.ColumnNAPPNUMBER] = value;
            }
        }
        
		/// 
		/// 字段NREGPRICE所映射的属性。
		/// 
        public System.Int32 NREGPRICE
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_REGPLAN.ColumnNREGPRICE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGPLAN.ColumnNREGPRICE] = value;
            }
        }
        
		/// 
		/// 字段VOPERATORID所映射的属性。
		/// 
        public System.String VOPERATORID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGPLAN.ColumnVOPERATORID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGPLAN.ColumnVOPERATORID] = value;
            }
        }
        
		/// 
		/// 字段DCREATEDATE所映射的属性。
		/// 
        public System.DateTime DCREATEDATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableGHSF_GHSF_REGPLAN.ColumnDCREATEDATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGPLAN.ColumnDCREATEDATE] = value;
            }
        }
        
		/// 
		/// 字段VREMARKS所映射的属性。
		/// 
        public System.String VREMARKS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_REGPLAN.ColumnVREMARKS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGPLAN.ColumnVREMARKS] = value;
            }
        }
        
		/// 
		/// 字段DCLINICDATE所映射的属性。
		/// 
        public System.DateTime DCLINICDATE
        {
            get 
            {	
                return ((System.DateTime)(this[this.tableGHSF_GHSF_REGPLAN.ColumnDCLINICDATE])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGPLAN.ColumnDCLINICDATE] = value;
            }
        }
        
		/// 
		/// 字段VDEPTID所映射的属性。
		/// 
        public System.String VDEPTID
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_REGPLAN.ColumnVDEPTID])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGPLAN.ColumnVDEPTID] = value;
            }
        }
        
		/// 
		/// 字段NHOSID所映射的属性。
		/// 
        public System.Int32 NHOSID
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_REGPLAN.ColumnNHOSID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_REGPLAN.ColumnNHOSID] = value;
            }
        }
        
		/// 
		/// 判断字段VDOCTORID是否为空。
		/// 
        public bool IsVDOCTORIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGPLAN.ColumnVDOCTORID);
        }

		/// 
		/// 设置字段VDOCTORID为空值。
		/// 
        public void SetVDOCTORIDNull() 
        {
            this[this.tableGHSF_GHSF_REGPLAN.ColumnVDOCTORID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NTIMEDESC是否为空。
		/// 
        public bool IsNTIMEDESCNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGPLAN.ColumnNTIMEDESC);
        }

		/// 
		/// 设置字段NTIMEDESC为空值。
		/// 
        public void SetNTIMEDESCNull() 
        {
            this[this.tableGHSF_GHSF_REGPLAN.ColumnNTIMEDESC] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NREGLIMITS是否为空。
		/// 
        public bool IsNREGLIMITSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGPLAN.ColumnNREGLIMITS);
        }

		/// 
		/// 设置字段NREGLIMITS为空值。
		/// 
        public void SetNREGLIMITSNull() 
        {
            this[this.tableGHSF_GHSF_REGPLAN.ColumnNREGLIMITS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NAPPLIMITS是否为空。
		/// 
        public bool IsNAPPLIMITSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGPLAN.ColumnNAPPLIMITS);
        }

		/// 
		/// 设置字段NAPPLIMITS为空值。
		/// 
        public void SetNAPPLIMITSNull() 
        {
            this[this.tableGHSF_GHSF_REGPLAN.ColumnNAPPLIMITS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NREGNUMBER是否为空。
		/// 
        public bool IsNREGNUMBERNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGPLAN.ColumnNREGNUMBER);
        }

		/// 
		/// 设置字段NREGNUMBER为空值。
		/// 
        public void SetNREGNUMBERNull() 
        {
            this[this.tableGHSF_GHSF_REGPLAN.ColumnNREGNUMBER] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NAPPNUMBER是否为空。
		/// 
        public bool IsNAPPNUMBERNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGPLAN.ColumnNAPPNUMBER);
        }

		/// 
		/// 设置字段NAPPNUMBER为空值。
		/// 
        public void SetNAPPNUMBERNull() 
        {
            this[this.tableGHSF_GHSF_REGPLAN.ColumnNAPPNUMBER] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NREGPRICE是否为空。
		/// 
        public bool IsNREGPRICENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGPLAN.ColumnNREGPRICE);
        }

		/// 
		/// 设置字段NREGPRICE为空值。
		/// 
        public void SetNREGPRICENull() 
        {
            this[this.tableGHSF_GHSF_REGPLAN.ColumnNREGPRICE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VOPERATORID是否为空。
		/// 
        public bool IsVOPERATORIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGPLAN.ColumnVOPERATORID);
        }

		/// 
		/// 设置字段VOPERATORID为空值。
		/// 
        public void SetVOPERATORIDNull() 
        {
            this[this.tableGHSF_GHSF_REGPLAN.ColumnVOPERATORID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DCREATEDATE是否为空。
		/// 
        public bool IsDCREATEDATENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGPLAN.ColumnDCREATEDATE);
        }

		/// 
		/// 设置字段DCREATEDATE为空值。
		/// 
        public void SetDCREATEDATENull() 
        {
            this[this.tableGHSF_GHSF_REGPLAN.ColumnDCREATEDATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VREMARKS是否为空。
		/// 
        public bool IsVREMARKSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGPLAN.ColumnVREMARKS);
        }

		/// 
		/// 设置字段VREMARKS为空值。
		/// 
        public void SetVREMARKSNull() 
        {
            this[this.tableGHSF_GHSF_REGPLAN.ColumnVREMARKS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NHOSID是否为空。
		/// 
        public bool IsNHOSIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_REGPLAN.ColumnNHOSID);
        }

		/// 
		/// 设置字段NHOSID为空值。
		/// 
        public void SetNHOSIDNull() 
        {
            this[this.tableGHSF_GHSF_REGPLAN.ColumnNHOSID] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventGHSF_GHSF_REGPLAN : EventArgs {
        
        private RowGHSF_GHSF_REGPLAN eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventGHSF_GHSF_REGPLAN(RowGHSF_GHSF_REGPLAN row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowGHSF_GHSF_REGPLAN Row {
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
	