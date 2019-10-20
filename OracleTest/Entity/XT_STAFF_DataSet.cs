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
	#region DataSetXT_STAFF
	/// 
	/// 对于XT_STAFF的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetXT_STAFF : DataSet
    {
		
		private DataTableXT_XT_STAFF tableXT_XT_STAFF;
		
        public DataSetXT_STAFF() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetXT_STAFF实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetXT_STAFF GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetXT_STAFF dataSet = (DataSetXT_STAFF)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetXT_STAFF entity = new DataSetXT_STAFF();
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
        
        protected DataSetXT_STAFF(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["XT_XT_STAFF"] != null)) 
                {
                    this.Tables.Add(new DataTableXT_XT_STAFF(ds.Tables["XT_XT_STAFF"]));
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
		/// 对于数据表XT_XT_STAFF的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableXT_XT_STAFF XT_XT_STAFF 
		{
			get
			{
				return this.tableXT_XT_STAFF;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetXT_STAFF cln = ((DataSetXT_STAFF)(base.Clone()));
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
			
			if ((ds.Tables["XT_XT_STAFF"] != null)) 
			{
				this.Tables.Add(new DataTableXT_XT_STAFF(ds.Tables["XT_XT_STAFF"]));
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
			
			this.tableXT_XT_STAFF = ((DataTableXT_XT_STAFF)(this.Tables["XT_XT_STAFF"]));
			if ((this.tableXT_XT_STAFF != null)) {
				this.tableXT_XT_STAFF.InitVars();
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
			
			this.tableXT_XT_STAFF = new DataTableXT_XT_STAFF();
			this.Tables.Add(this.tableXT_XT_STAFF);
			
		}
		
		private bool ShouldSerializeXT_XT_STAFF() 
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
	
    public delegate void RowChangeEventHandlerXT_XT_STAFF(object sender, RowChangeEventXT_XT_STAFF e);
	
	#region DataTableXT_XT_STAFF
	/// 
	/// 对于数据表XT_XT_STAFF的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableXT_XT_STAFF : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVSTAFFCODE;
		
        private DataColumn columnVSTAFFNAME;
		
        private DataColumn columnPINYINMA;
		
        private DataColumn columnWUBIMA;
		
        private DataColumn columnVLOGINUSERNAME;
		
        private DataColumn columnVLOGINPASSWORD;
		
        private DataColumn columnNSTAFFSTATUS;
		
        private DataColumn columnNROLEID;
		
        private DataColumn columnVDEPARTCODE;
		
        private DataColumn columnNJOBID;
		
        private DataColumn columnNPROFESSIONID;
		
        private DataColumn columnNOPHZID;
		
        private DataColumn columnNISDUMA;
		
        private DataColumn columnDFHTIME;
		
        private DataColumn columnDTHTIME;
		
        private DataColumn columnVTMETHOD;
		
        private DataColumn columnVSCHOOL;
		
        private DataColumn columnNSEX;
		
        private DataColumn columnNBIRTHDAY;
		
        private DataColumn columnVMINZU;
		
        private DataColumn columnVJIGUAN;
		
        private DataColumn columnVXUELI;
		
        private DataColumn columnNISKSS;
		
        private DataColumn columnNSENDMSG;
		
        private DataColumn columnNHOSID;
		
        private DataColumn columnVYBNO;
		
        private DataColumn columnVSXYS;
		
        private DataColumn columnVSEALCODE;
		
        private DataColumn columnINVOICE_KEY;
		
        internal DataTableXT_XT_STAFF() : base("XT_XT_STAFF") 
        {
            this.InitClass();
        }
        
        internal DataTableXT_XT_STAFF(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVSTAFFCODE 
        {
            get 
            {
                return this.columnVSTAFFCODE;
            }
        }
		
        public DataColumn ColumnVSTAFFNAME 
        {
            get 
            {
                return this.columnVSTAFFNAME;
            }
        }
		
        public DataColumn ColumnPINYINMA 
        {
            get 
            {
                return this.columnPINYINMA;
            }
        }
		
        public DataColumn ColumnWUBIMA 
        {
            get 
            {
                return this.columnWUBIMA;
            }
        }
		
        public DataColumn ColumnVLOGINUSERNAME 
        {
            get 
            {
                return this.columnVLOGINUSERNAME;
            }
        }
		
        public DataColumn ColumnVLOGINPASSWORD 
        {
            get 
            {
                return this.columnVLOGINPASSWORD;
            }
        }
		
        public DataColumn ColumnNSTAFFSTATUS 
        {
            get 
            {
                return this.columnNSTAFFSTATUS;
            }
        }
		
        public DataColumn ColumnNROLEID 
        {
            get 
            {
                return this.columnNROLEID;
            }
        }
		
        public DataColumn ColumnVDEPARTCODE 
        {
            get 
            {
                return this.columnVDEPARTCODE;
            }
        }
		
        public DataColumn ColumnNJOBID 
        {
            get 
            {
                return this.columnNJOBID;
            }
        }
		
        public DataColumn ColumnNPROFESSIONID 
        {
            get 
            {
                return this.columnNPROFESSIONID;
            }
        }
		
        public DataColumn ColumnNOPHZID 
        {
            get 
            {
                return this.columnNOPHZID;
            }
        }
		
        public DataColumn ColumnNISDUMA 
        {
            get 
            {
                return this.columnNISDUMA;
            }
        }
		
        public DataColumn ColumnDFHTIME 
        {
            get 
            {
                return this.columnDFHTIME;
            }
        }
		
        public DataColumn ColumnDTHTIME 
        {
            get 
            {
                return this.columnDTHTIME;
            }
        }
		
        public DataColumn ColumnVTMETHOD 
        {
            get 
            {
                return this.columnVTMETHOD;
            }
        }
		
        public DataColumn ColumnVSCHOOL 
        {
            get 
            {
                return this.columnVSCHOOL;
            }
        }
		
        public DataColumn ColumnNSEX 
        {
            get 
            {
                return this.columnNSEX;
            }
        }
		
        public DataColumn ColumnNBIRTHDAY 
        {
            get 
            {
                return this.columnNBIRTHDAY;
            }
        }
		
        public DataColumn ColumnVMINZU 
        {
            get 
            {
                return this.columnVMINZU;
            }
        }
		
        public DataColumn ColumnVJIGUAN 
        {
            get 
            {
                return this.columnVJIGUAN;
            }
        }
		
        public DataColumn ColumnVXUELI 
        {
            get 
            {
                return this.columnVXUELI;
            }
        }
		
        public DataColumn ColumnNISKSS 
        {
            get 
            {
                return this.columnNISKSS;
            }
        }
		
        public DataColumn ColumnNSENDMSG 
        {
            get 
            {
                return this.columnNSENDMSG;
            }
        }
		
        public DataColumn ColumnNHOSID 
        {
            get 
            {
                return this.columnNHOSID;
            }
        }
		
        public DataColumn ColumnVYBNO 
        {
            get 
            {
                return this.columnVYBNO;
            }
        }
		
        public DataColumn ColumnVSXYS 
        {
            get 
            {
                return this.columnVSXYS;
            }
        }
		
        public DataColumn ColumnVSEALCODE 
        {
            get 
            {
                return this.columnVSEALCODE;
            }
        }
		
        public DataColumn ColumnINVOICE_KEY 
        {
            get 
            {
                return this.columnINVOICE_KEY;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowXT_XT_STAFF this[int index] 
        {
            get 
            {
                return ((RowXT_XT_STAFF)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerXT_XT_STAFF RowChangedXT_XT_STAFF;
        
        public event RowChangeEventHandlerXT_XT_STAFF RowChangingXT_XT_STAFF;
        
        public event RowChangeEventHandlerXT_XT_STAFF RowDeletedXT_XT_STAFF;
        
        public event RowChangeEventHandlerXT_XT_STAFF RowDeletingXT_XT_STAFF;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowXT_XT_STAFF(RowXT_XT_STAFF row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowXT_XT_STAFF AddRowXT_XT_STAFF(System.String VSTAFFCODE,System.String VSTAFFNAME,System.String PINYINMA,System.String WUBIMA,System.String VLOGINUSERNAME,System.String VLOGINPASSWORD,System.Int32 NSTAFFSTATUS,System.Int32 NROLEID,System.String VDEPARTCODE,System.Int32 NJOBID,System.Int32 NPROFESSIONID,System.Int32 NOPHZID,System.Int16 NISDUMA,System.DateTime DFHTIME,System.DateTime DTHTIME,System.String VTMETHOD,System.String VSCHOOL,System.Int16 NSEX,System.DateTime NBIRTHDAY,System.String VMINZU,System.String VJIGUAN,System.String VXUELI,System.Int16 NISKSS,System.Int16 NSENDMSG,System.Int32 NHOSID,System.String VYBNO,System.String VSXYS,System.String VSEALCODE,System.String INVOICE_KEY) 
        {
            RowXT_XT_STAFF row = ((RowXT_XT_STAFF)(this.NewRow()));
            row.ItemArray = new object[] {VSTAFFCODE,VSTAFFNAME,PINYINMA,WUBIMA,VLOGINUSERNAME,VLOGINPASSWORD,NSTAFFSTATUS,NROLEID,VDEPARTCODE,NJOBID,NPROFESSIONID,NOPHZID,NISDUMA,DFHTIME,DTHTIME,VTMETHOD,VSCHOOL,NSEX,NBIRTHDAY,VMINZU,VJIGUAN,VXUELI,NISKSS,NSENDMSG,NHOSID,VYBNO,VSXYS,VSEALCODE,INVOICE_KEY};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowXT_XT_STAFF FindByVSTAFFCODE(System.String VSTAFFCODE) {
            return ((RowXT_XT_STAFF)(this.Rows.Find(new object[] {
                        VSTAFFCODE})));
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
            DataTableXT_XT_STAFF cln = ((DataTableXT_XT_STAFF)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableXT_XT_STAFF();
        }
        
        internal void InitVars() 
        {	
            this.columnVSTAFFCODE = this.Columns["VSTAFFCODE"];
            this.columnVSTAFFNAME = this.Columns["VSTAFFNAME"];
            this.columnPINYINMA = this.Columns["PINYINMA"];
            this.columnWUBIMA = this.Columns["WUBIMA"];
            this.columnVLOGINUSERNAME = this.Columns["VLOGINUSERNAME"];
            this.columnVLOGINPASSWORD = this.Columns["VLOGINPASSWORD"];
            this.columnNSTAFFSTATUS = this.Columns["NSTAFFSTATUS"];
            this.columnNROLEID = this.Columns["NROLEID"];
            this.columnVDEPARTCODE = this.Columns["VDEPARTCODE"];
            this.columnNJOBID = this.Columns["NJOBID"];
            this.columnNPROFESSIONID = this.Columns["NPROFESSIONID"];
            this.columnNOPHZID = this.Columns["NOPHZID"];
            this.columnNISDUMA = this.Columns["NISDUMA"];
            this.columnDFHTIME = this.Columns["DFHTIME"];
            this.columnDTHTIME = this.Columns["DTHTIME"];
            this.columnVTMETHOD = this.Columns["VTMETHOD"];
            this.columnVSCHOOL = this.Columns["VSCHOOL"];
            this.columnNSEX = this.Columns["NSEX"];
            this.columnNBIRTHDAY = this.Columns["NBIRTHDAY"];
            this.columnVMINZU = this.Columns["VMINZU"];
            this.columnVJIGUAN = this.Columns["VJIGUAN"];
            this.columnVXUELI = this.Columns["VXUELI"];
            this.columnNISKSS = this.Columns["NISKSS"];
            this.columnNSENDMSG = this.Columns["NSENDMSG"];
            this.columnNHOSID = this.Columns["NHOSID"];
            this.columnVYBNO = this.Columns["VYBNO"];
            this.columnVSXYS = this.Columns["VSXYS"];
            this.columnVSEALCODE = this.Columns["VSEALCODE"];
            this.columnINVOICE_KEY = this.Columns["INVOICE_KEY"];
        }
        
        private void InitClass() 
        {	
            this.columnVSTAFFCODE = new DataColumn("VSTAFFCODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVSTAFFCODE.MaxLength = 20;
            this.columnVSTAFFCODE.AllowDBNull = false;
            this.columnVSTAFFCODE.Unique = true;
            
            this.Columns.Add(this.columnVSTAFFCODE);
			
            this.columnVSTAFFNAME = new DataColumn("VSTAFFNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVSTAFFNAME.MaxLength = 60;
            this.columnVSTAFFNAME.AllowDBNull = false;
            this.Columns.Add(this.columnVSTAFFNAME);
			
            this.columnPINYINMA = new DataColumn("PINYINMA", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnPINYINMA.MaxLength = 120;
            this.columnPINYINMA.AllowDBNull = false;
            this.Columns.Add(this.columnPINYINMA);
			
            this.columnWUBIMA = new DataColumn("WUBIMA", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnWUBIMA.MaxLength = 60;
            this.columnWUBIMA.AllowDBNull = false;
            this.Columns.Add(this.columnWUBIMA);
			
            this.columnVLOGINUSERNAME = new DataColumn("VLOGINUSERNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVLOGINUSERNAME.MaxLength = 20;
            this.columnVLOGINUSERNAME.AllowDBNull = false;
            this.Columns.Add(this.columnVLOGINUSERNAME);
			
            this.columnVLOGINPASSWORD = new DataColumn("VLOGINPASSWORD", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVLOGINPASSWORD.MaxLength = 100;
            this.columnVLOGINPASSWORD.AllowDBNull = false;
            this.Columns.Add(this.columnVLOGINPASSWORD);
			
            this.columnNSTAFFSTATUS = new DataColumn("NSTAFFSTATUS", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNSTAFFSTATUS.DefaultValue = "1";
            this.columnNSTAFFSTATUS.AllowDBNull = false;
            this.Columns.Add(this.columnNSTAFFSTATUS);
			
            this.columnNROLEID = new DataColumn("NROLEID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNROLEID.AllowDBNull = true;
            this.Columns.Add(this.columnNROLEID);
			
            this.columnVDEPARTCODE = new DataColumn("VDEPARTCODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPARTCODE.MaxLength = 10;
            this.columnVDEPARTCODE.AllowDBNull = false;
            this.Columns.Add(this.columnVDEPARTCODE);
			
            this.columnNJOBID = new DataColumn("NJOBID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNJOBID.AllowDBNull = false;
            this.Columns.Add(this.columnNJOBID);
			
            this.columnNPROFESSIONID = new DataColumn("NPROFESSIONID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNPROFESSIONID.AllowDBNull = false;
            this.Columns.Add(this.columnNPROFESSIONID);
			
            this.columnNOPHZID = new DataColumn("NOPHZID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNOPHZID.AllowDBNull = false;
            this.Columns.Add(this.columnNOPHZID);
			
            this.columnNISDUMA = new DataColumn("NISDUMA", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNISDUMA.AllowDBNull = false;
            this.Columns.Add(this.columnNISDUMA);
			
            this.columnDFHTIME = new DataColumn("DFHTIME", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDFHTIME.AllowDBNull = true;
            this.Columns.Add(this.columnDFHTIME);
			
            this.columnDTHTIME = new DataColumn("DTHTIME", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDTHTIME.AllowDBNull = true;
            this.Columns.Add(this.columnDTHTIME);
			
            this.columnVTMETHOD = new DataColumn("VTMETHOD", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVTMETHOD.MaxLength = 100;
            this.columnVTMETHOD.AllowDBNull = true;
            this.Columns.Add(this.columnVTMETHOD);
			
            this.columnVSCHOOL = new DataColumn("VSCHOOL", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVSCHOOL.MaxLength = 40;
            this.columnVSCHOOL.AllowDBNull = true;
            this.Columns.Add(this.columnVSCHOOL);
			
            this.columnNSEX = new DataColumn("NSEX", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNSEX.AllowDBNull = true;
            this.Columns.Add(this.columnNSEX);
			
            this.columnNBIRTHDAY = new DataColumn("NBIRTHDAY", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnNBIRTHDAY.AllowDBNull = true;
            this.Columns.Add(this.columnNBIRTHDAY);
			
            this.columnVMINZU = new DataColumn("VMINZU", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVMINZU.MaxLength = 20;
            this.columnVMINZU.AllowDBNull = true;
            this.Columns.Add(this.columnVMINZU);
			
            this.columnVJIGUAN = new DataColumn("VJIGUAN", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVJIGUAN.MaxLength = 40;
            this.columnVJIGUAN.AllowDBNull = true;
            this.Columns.Add(this.columnVJIGUAN);
			
            this.columnVXUELI = new DataColumn("VXUELI", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVXUELI.MaxLength = 20;
            this.columnVXUELI.AllowDBNull = true;
            this.Columns.Add(this.columnVXUELI);
			
            this.columnNISKSS = new DataColumn("NISKSS", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNISKSS.AllowDBNull = true;
            this.Columns.Add(this.columnNISKSS);
			
            this.columnNSENDMSG = new DataColumn("NSENDMSG", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNSENDMSG.AllowDBNull = true;
            this.Columns.Add(this.columnNSENDMSG);
			
            this.columnNHOSID = new DataColumn("NHOSID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNHOSID.AllowDBNull = true;
            this.Columns.Add(this.columnNHOSID);
			
            this.columnVYBNO = new DataColumn("VYBNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVYBNO.MaxLength = 32;
            this.columnVYBNO.AllowDBNull = true;
            this.Columns.Add(this.columnVYBNO);
			
            this.columnVSXYS = new DataColumn("VSXYS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVSXYS.MaxLength = 60;
            this.columnVSXYS.AllowDBNull = true;
            this.Columns.Add(this.columnVSXYS);
			
            this.columnVSEALCODE = new DataColumn("VSEALCODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVSEALCODE.MaxLength = 20;
            this.columnVSEALCODE.AllowDBNull = true;
            this.Columns.Add(this.columnVSEALCODE);
			
            this.columnINVOICE_KEY = new DataColumn("INVOICE_KEY", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnINVOICE_KEY.MaxLength = 200;
            this.columnINVOICE_KEY.AllowDBNull = true;
            this.Columns.Add(this.columnINVOICE_KEY);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowXT_XT_STAFF NewRowXT_XT_STAFF() {
            return ((RowXT_XT_STAFF)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowXT_XT_STAFF(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowXT_XT_STAFF);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedXT_XT_STAFF != null)) {
                this.RowChangedXT_XT_STAFF(this, new RowChangeEventXT_XT_STAFF(((RowXT_XT_STAFF)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingXT_XT_STAFF != null)) {
                this.RowChangingXT_XT_STAFF(this, new RowChangeEventXT_XT_STAFF(((RowXT_XT_STAFF)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedXT_XT_STAFF != null)) {
                this.RowDeletedXT_XT_STAFF(this, new RowChangeEventXT_XT_STAFF(((RowXT_XT_STAFF)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingXT_XT_STAFF != null)) {
                this.RowDeletingXT_XT_STAFF(this, new RowChangeEventXT_XT_STAFF(((RowXT_XT_STAFF)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowXT_XT_STAFF(RowXT_XT_STAFF row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowXT_XT_STAFF
	/// 
	/// 数据表XT_XT_STAFF行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowXT_XT_STAFF : DataRow 
    {
        
        private DataTableXT_XT_STAFF tableXT_XT_STAFF;
        
        internal RowXT_XT_STAFF(DataRowBuilder rb) : base(rb) 
        {
            this.tableXT_XT_STAFF = ((DataTableXT_XT_STAFF)(this.Table));
        }        
		
		/// 
		/// 字段VSTAFFCODE所映射的属性。
		/// 
        public System.String VSTAFFCODE
        {
            get 
            {	
                return ((System.String)(this[this.tableXT_XT_STAFF.ColumnVSTAFFCODE])); 
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnVSTAFFCODE] = value;
            }
        }
        
		/// 
		/// 字段VSTAFFNAME所映射的属性。
		/// 
        public System.String VSTAFFNAME
        {
            get 
            {	
                return ((System.String)(this[this.tableXT_XT_STAFF.ColumnVSTAFFNAME])); 
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnVSTAFFNAME] = value;
            }
        }
        
		/// 
		/// 字段PINYINMA所映射的属性。
		/// 
        public System.String PINYINMA
        {
            get 
            {	
                return ((System.String)(this[this.tableXT_XT_STAFF.ColumnPINYINMA])); 
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnPINYINMA] = value;
            }
        }
        
		/// 
		/// 字段WUBIMA所映射的属性。
		/// 
        public System.String WUBIMA
        {
            get 
            {	
                return ((System.String)(this[this.tableXT_XT_STAFF.ColumnWUBIMA])); 
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnWUBIMA] = value;
            }
        }
        
		/// 
		/// 字段VLOGINUSERNAME所映射的属性。
		/// 
        public System.String VLOGINUSERNAME
        {
            get 
            {	
                return ((System.String)(this[this.tableXT_XT_STAFF.ColumnVLOGINUSERNAME])); 
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnVLOGINUSERNAME] = value;
            }
        }
        
		/// 
		/// 字段VLOGINPASSWORD所映射的属性。
		/// 
        public System.String VLOGINPASSWORD
        {
            get 
            {	
                return ((System.String)(this[this.tableXT_XT_STAFF.ColumnVLOGINPASSWORD])); 
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnVLOGINPASSWORD] = value;
            }
        }
        
		/// 
		/// 字段NSTAFFSTATUS所映射的属性。
		/// 
        public System.Int32 NSTAFFSTATUS
        {
            get 
            {	
                return ((System.Int32)(this[this.tableXT_XT_STAFF.ColumnNSTAFFSTATUS])); 
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnNSTAFFSTATUS] = value;
            }
        }
        
		/// 
		/// 字段NROLEID所映射的属性。
		/// 
        public System.Int32 NROLEID
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableXT_XT_STAFF.ColumnNROLEID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnNROLEID] = value;
            }
        }
        
		/// 
		/// 字段VDEPARTCODE所映射的属性。
		/// 
        public System.String VDEPARTCODE
        {
            get 
            {	
                return ((System.String)(this[this.tableXT_XT_STAFF.ColumnVDEPARTCODE])); 
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnVDEPARTCODE] = value;
            }
        }
        
		/// 
		/// 字段NJOBID所映射的属性。
		/// 
        public System.Int32 NJOBID
        {
            get 
            {	
                return ((System.Int32)(this[this.tableXT_XT_STAFF.ColumnNJOBID])); 
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnNJOBID] = value;
            }
        }
        
		/// 
		/// 字段NPROFESSIONID所映射的属性。
		/// 
        public System.Int32 NPROFESSIONID
        {
            get 
            {	
                return ((System.Int32)(this[this.tableXT_XT_STAFF.ColumnNPROFESSIONID])); 
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnNPROFESSIONID] = value;
            }
        }
        
		/// 
		/// 字段NOPHZID所映射的属性。
		/// 
        public System.Int32 NOPHZID
        {
            get 
            {	
                return ((System.Int32)(this[this.tableXT_XT_STAFF.ColumnNOPHZID])); 
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnNOPHZID] = value;
            }
        }
        
		/// 
		/// 字段NISDUMA所映射的属性。
		/// 
        public System.Int16 NISDUMA
        {
            get 
            {	
                return ((System.Int16)(this[this.tableXT_XT_STAFF.ColumnNISDUMA])); 
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnNISDUMA] = value;
            }
        }
        
		/// 
		/// 字段DFHTIME所映射的属性。
		/// 
        public System.DateTime DFHTIME
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableXT_XT_STAFF.ColumnDFHTIME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnDFHTIME] = value;
            }
        }
        
		/// 
		/// 字段DTHTIME所映射的属性。
		/// 
        public System.DateTime DTHTIME
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableXT_XT_STAFF.ColumnDTHTIME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnDTHTIME] = value;
            }
        }
        
		/// 
		/// 字段VTMETHOD所映射的属性。
		/// 
        public System.String VTMETHOD
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableXT_XT_STAFF.ColumnVTMETHOD])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnVTMETHOD] = value;
            }
        }
        
		/// 
		/// 字段VSCHOOL所映射的属性。
		/// 
        public System.String VSCHOOL
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableXT_XT_STAFF.ColumnVSCHOOL])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnVSCHOOL] = value;
            }
        }
        
		/// 
		/// 字段NSEX所映射的属性。
		/// 
        public System.Int16 NSEX
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableXT_XT_STAFF.ColumnNSEX])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnNSEX] = value;
            }
        }
        
		/// 
		/// 字段NBIRTHDAY所映射的属性。
		/// 
        public System.DateTime NBIRTHDAY
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableXT_XT_STAFF.ColumnNBIRTHDAY])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnNBIRTHDAY] = value;
            }
        }
        
		/// 
		/// 字段VMINZU所映射的属性。
		/// 
        public System.String VMINZU
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableXT_XT_STAFF.ColumnVMINZU])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnVMINZU] = value;
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
	                return ((System.String)(this[this.tableXT_XT_STAFF.ColumnVJIGUAN])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnVJIGUAN] = value;
            }
        }
        
		/// 
		/// 字段VXUELI所映射的属性。
		/// 
        public System.String VXUELI
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableXT_XT_STAFF.ColumnVXUELI])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnVXUELI] = value;
            }
        }
        
		/// 
		/// 字段NISKSS所映射的属性。
		/// 
        public System.Int16 NISKSS
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableXT_XT_STAFF.ColumnNISKSS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnNISKSS] = value;
            }
        }
        
		/// 
		/// 字段NSENDMSG所映射的属性。
		/// 
        public System.Int16 NSENDMSG
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableXT_XT_STAFF.ColumnNSENDMSG])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnNSENDMSG] = value;
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
	                return ((System.Int32)(this[this.tableXT_XT_STAFF.ColumnNHOSID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnNHOSID] = value;
            }
        }
        
		/// 
		/// 字段VYBNO所映射的属性。
		/// 
        public System.String VYBNO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableXT_XT_STAFF.ColumnVYBNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnVYBNO] = value;
            }
        }
        
		/// 
		/// 字段VSXYS所映射的属性。
		/// 
        public System.String VSXYS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableXT_XT_STAFF.ColumnVSXYS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnVSXYS] = value;
            }
        }
        
		/// 
		/// 字段VSEALCODE所映射的属性。
		/// 
        public System.String VSEALCODE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableXT_XT_STAFF.ColumnVSEALCODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnVSEALCODE] = value;
            }
        }
        
		/// 
		/// 字段INVOICE_KEY所映射的属性。
		/// 
        public System.String INVOICE_KEY
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableXT_XT_STAFF.ColumnINVOICE_KEY])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableXT_XT_STAFF.ColumnINVOICE_KEY] = value;
            }
        }
        
		/// 
		/// 判断字段NROLEID是否为空。
		/// 
        public bool IsNROLEIDNull()
        {
            return this.IsNull(this.tableXT_XT_STAFF.ColumnNROLEID);
        }

		/// 
		/// 设置字段NROLEID为空值。
		/// 
        public void SetNROLEIDNull() 
        {
            this[this.tableXT_XT_STAFF.ColumnNROLEID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DFHTIME是否为空。
		/// 
        public bool IsDFHTIMENull()
        {
            return this.IsNull(this.tableXT_XT_STAFF.ColumnDFHTIME);
        }

		/// 
		/// 设置字段DFHTIME为空值。
		/// 
        public void SetDFHTIMENull() 
        {
            this[this.tableXT_XT_STAFF.ColumnDFHTIME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DTHTIME是否为空。
		/// 
        public bool IsDTHTIMENull()
        {
            return this.IsNull(this.tableXT_XT_STAFF.ColumnDTHTIME);
        }

		/// 
		/// 设置字段DTHTIME为空值。
		/// 
        public void SetDTHTIMENull() 
        {
            this[this.tableXT_XT_STAFF.ColumnDTHTIME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VTMETHOD是否为空。
		/// 
        public bool IsVTMETHODNull()
        {
            return this.IsNull(this.tableXT_XT_STAFF.ColumnVTMETHOD);
        }

		/// 
		/// 设置字段VTMETHOD为空值。
		/// 
        public void SetVTMETHODNull() 
        {
            this[this.tableXT_XT_STAFF.ColumnVTMETHOD] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VSCHOOL是否为空。
		/// 
        public bool IsVSCHOOLNull()
        {
            return this.IsNull(this.tableXT_XT_STAFF.ColumnVSCHOOL);
        }

		/// 
		/// 设置字段VSCHOOL为空值。
		/// 
        public void SetVSCHOOLNull() 
        {
            this[this.tableXT_XT_STAFF.ColumnVSCHOOL] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSEX是否为空。
		/// 
        public bool IsNSEXNull()
        {
            return this.IsNull(this.tableXT_XT_STAFF.ColumnNSEX);
        }

		/// 
		/// 设置字段NSEX为空值。
		/// 
        public void SetNSEXNull() 
        {
            this[this.tableXT_XT_STAFF.ColumnNSEX] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NBIRTHDAY是否为空。
		/// 
        public bool IsNBIRTHDAYNull()
        {
            return this.IsNull(this.tableXT_XT_STAFF.ColumnNBIRTHDAY);
        }

		/// 
		/// 设置字段NBIRTHDAY为空值。
		/// 
        public void SetNBIRTHDAYNull() 
        {
            this[this.tableXT_XT_STAFF.ColumnNBIRTHDAY] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VMINZU是否为空。
		/// 
        public bool IsVMINZUNull()
        {
            return this.IsNull(this.tableXT_XT_STAFF.ColumnVMINZU);
        }

		/// 
		/// 设置字段VMINZU为空值。
		/// 
        public void SetVMINZUNull() 
        {
            this[this.tableXT_XT_STAFF.ColumnVMINZU] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VJIGUAN是否为空。
		/// 
        public bool IsVJIGUANNull()
        {
            return this.IsNull(this.tableXT_XT_STAFF.ColumnVJIGUAN);
        }

		/// 
		/// 设置字段VJIGUAN为空值。
		/// 
        public void SetVJIGUANNull() 
        {
            this[this.tableXT_XT_STAFF.ColumnVJIGUAN] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VXUELI是否为空。
		/// 
        public bool IsVXUELINull()
        {
            return this.IsNull(this.tableXT_XT_STAFF.ColumnVXUELI);
        }

		/// 
		/// 设置字段VXUELI为空值。
		/// 
        public void SetVXUELINull() 
        {
            this[this.tableXT_XT_STAFF.ColumnVXUELI] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NISKSS是否为空。
		/// 
        public bool IsNISKSSNull()
        {
            return this.IsNull(this.tableXT_XT_STAFF.ColumnNISKSS);
        }

		/// 
		/// 设置字段NISKSS为空值。
		/// 
        public void SetNISKSSNull() 
        {
            this[this.tableXT_XT_STAFF.ColumnNISKSS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSENDMSG是否为空。
		/// 
        public bool IsNSENDMSGNull()
        {
            return this.IsNull(this.tableXT_XT_STAFF.ColumnNSENDMSG);
        }

		/// 
		/// 设置字段NSENDMSG为空值。
		/// 
        public void SetNSENDMSGNull() 
        {
            this[this.tableXT_XT_STAFF.ColumnNSENDMSG] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NHOSID是否为空。
		/// 
        public bool IsNHOSIDNull()
        {
            return this.IsNull(this.tableXT_XT_STAFF.ColumnNHOSID);
        }

		/// 
		/// 设置字段NHOSID为空值。
		/// 
        public void SetNHOSIDNull() 
        {
            this[this.tableXT_XT_STAFF.ColumnNHOSID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VYBNO是否为空。
		/// 
        public bool IsVYBNONull()
        {
            return this.IsNull(this.tableXT_XT_STAFF.ColumnVYBNO);
        }

		/// 
		/// 设置字段VYBNO为空值。
		/// 
        public void SetVYBNONull() 
        {
            this[this.tableXT_XT_STAFF.ColumnVYBNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VSXYS是否为空。
		/// 
        public bool IsVSXYSNull()
        {
            return this.IsNull(this.tableXT_XT_STAFF.ColumnVSXYS);
        }

		/// 
		/// 设置字段VSXYS为空值。
		/// 
        public void SetVSXYSNull() 
        {
            this[this.tableXT_XT_STAFF.ColumnVSXYS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VSEALCODE是否为空。
		/// 
        public bool IsVSEALCODENull()
        {
            return this.IsNull(this.tableXT_XT_STAFF.ColumnVSEALCODE);
        }

		/// 
		/// 设置字段VSEALCODE为空值。
		/// 
        public void SetVSEALCODENull() 
        {
            this[this.tableXT_XT_STAFF.ColumnVSEALCODE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段INVOICE_KEY是否为空。
		/// 
        public bool IsINVOICE_KEYNull()
        {
            return this.IsNull(this.tableXT_XT_STAFF.ColumnINVOICE_KEY);
        }

		/// 
		/// 设置字段INVOICE_KEY为空值。
		/// 
        public void SetINVOICE_KEYNull() 
        {
            this[this.tableXT_XT_STAFF.ColumnINVOICE_KEY] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventXT_XT_STAFF : EventArgs {
        
        private RowXT_XT_STAFF eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventXT_XT_STAFF(RowXT_XT_STAFF row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowXT_XT_STAFF Row {
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
	