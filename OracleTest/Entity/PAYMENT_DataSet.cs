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
	#region DataSetPAYMENT
	/// 
	/// 对于PAYMENT的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetPAYMENT : DataSet
    {
		
		private DataTablePAYMENT tablePAYMENT;
		
        public DataSetPAYMENT() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetPAYMENT实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetPAYMENT GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetPAYMENT dataSet = (DataSetPAYMENT)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetPAYMENT entity = new DataSetPAYMENT();
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
        
        protected DataSetPAYMENT(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["PAYMENT"] != null)) 
                {
                    this.Tables.Add(new DataTablePAYMENT(ds.Tables["PAYMENT"]));
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
		/// 对于数据表PAYMENT的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTablePAYMENT PAYMENT 
		{
			get
			{
				return this.tablePAYMENT;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetPAYMENT cln = ((DataSetPAYMENT)(base.Clone()));
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
			
			if ((ds.Tables["PAYMENT"] != null)) 
			{
				this.Tables.Add(new DataTablePAYMENT(ds.Tables["PAYMENT"]));
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
			
			this.tablePAYMENT = ((DataTablePAYMENT)(this.Tables["PAYMENT"]));
			if ((this.tablePAYMENT != null)) {
				this.tablePAYMENT.InitVars();
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
			
			this.tablePAYMENT = new DataTablePAYMENT();
			this.Tables.Add(this.tablePAYMENT);
			
		}
		
		private bool ShouldSerializePAYMENT() 
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
	
    public delegate void RowChangeEventHandlerPAYMENT(object sender, RowChangeEventPAYMENT e);
	
	#region DataTablePAYMENT
	/// 
	/// 对于数据表PAYMENT的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTablePAYMENT : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnNGHF;
		
        private DataColumn columnNZLF;
		
        private DataColumn columnVSPMC;
		
        private DataColumn columnVPHONE;
		
        private DataColumn columnDZFRQ;
		
        private DataColumn columnVHAOBIE;
		
        private DataColumn columnVDDLSH;
		
        private DataColumn columnVNAME;
		
        private DataColumn columnVCLINICNO;
		
        private DataColumn columnVCARD;
		
        private DataColumn columnVSFZH;
		
        private DataColumn columnVDEPT;
		
        private DataColumn columnVDOCTOR;
		
        private DataColumn columnDDDRQ;
		
        private DataColumn columnNCOSTS;
		
        private DataColumn columnNDDLX;
		
        private DataColumn columnVREMARKS;
		
        private DataColumn columnNSTATE;
		
        private DataColumn columnDJZRQ;
		
        private DataColumn columnNDEL;
		
        private DataColumn columnVAPPTIME;
		
        private DataColumn columnVHZID;
		
        private DataColumn columnNPAYTYPE;
		
        internal DataTablePAYMENT() : base("PAYMENT") 
        {
            this.InitClass();
        }
        
        internal DataTablePAYMENT(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnNGHF 
        {
            get 
            {
                return this.columnNGHF;
            }
        }
		
        public DataColumn ColumnNZLF 
        {
            get 
            {
                return this.columnNZLF;
            }
        }
		
        public DataColumn ColumnVSPMC 
        {
            get 
            {
                return this.columnVSPMC;
            }
        }
		
        public DataColumn ColumnVPHONE 
        {
            get 
            {
                return this.columnVPHONE;
            }
        }
		
        public DataColumn ColumnDZFRQ 
        {
            get 
            {
                return this.columnDZFRQ;
            }
        }
		
        public DataColumn ColumnVHAOBIE 
        {
            get 
            {
                return this.columnVHAOBIE;
            }
        }
		
        public DataColumn ColumnVDDLSH 
        {
            get 
            {
                return this.columnVDDLSH;
            }
        }
		
        public DataColumn ColumnVNAME 
        {
            get 
            {
                return this.columnVNAME;
            }
        }
		
        public DataColumn ColumnVCLINICNO 
        {
            get 
            {
                return this.columnVCLINICNO;
            }
        }
		
        public DataColumn ColumnVCARD 
        {
            get 
            {
                return this.columnVCARD;
            }
        }
		
        public DataColumn ColumnVSFZH 
        {
            get 
            {
                return this.columnVSFZH;
            }
        }
		
        public DataColumn ColumnVDEPT 
        {
            get 
            {
                return this.columnVDEPT;
            }
        }
		
        public DataColumn ColumnVDOCTOR 
        {
            get 
            {
                return this.columnVDOCTOR;
            }
        }
		
        public DataColumn ColumnDDDRQ 
        {
            get 
            {
                return this.columnDDDRQ;
            }
        }
		
        public DataColumn ColumnNCOSTS 
        {
            get 
            {
                return this.columnNCOSTS;
            }
        }
		
        public DataColumn ColumnNDDLX 
        {
            get 
            {
                return this.columnNDDLX;
            }
        }
		
        public DataColumn ColumnVREMARKS 
        {
            get 
            {
                return this.columnVREMARKS;
            }
        }
		
        public DataColumn ColumnNSTATE 
        {
            get 
            {
                return this.columnNSTATE;
            }
        }
		
        public DataColumn ColumnDJZRQ 
        {
            get 
            {
                return this.columnDJZRQ;
            }
        }
		
        public DataColumn ColumnNDEL 
        {
            get 
            {
                return this.columnNDEL;
            }
        }
		
        public DataColumn ColumnVAPPTIME 
        {
            get 
            {
                return this.columnVAPPTIME;
            }
        }
		
        public DataColumn ColumnVHZID 
        {
            get 
            {
                return this.columnVHZID;
            }
        }
		
        public DataColumn ColumnNPAYTYPE 
        {
            get 
            {
                return this.columnNPAYTYPE;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowPAYMENT this[int index] 
        {
            get 
            {
                return ((RowPAYMENT)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerPAYMENT RowChangedPAYMENT;
        
        public event RowChangeEventHandlerPAYMENT RowChangingPAYMENT;
        
        public event RowChangeEventHandlerPAYMENT RowDeletedPAYMENT;
        
        public event RowChangeEventHandlerPAYMENT RowDeletingPAYMENT;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowPAYMENT(RowPAYMENT row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowPAYMENT AddRowPAYMENT(System.Decimal NGHF,System.Decimal NZLF,System.String VSPMC,System.String VPHONE,System.DateTime DZFRQ,System.String VHAOBIE,System.String VDDLSH,System.String VNAME,System.String VCLINICNO,System.String VCARD,System.String VSFZH,System.String VDEPT,System.String VDOCTOR,System.DateTime DDDRQ,System.Decimal NCOSTS,System.Int16 NDDLX,System.String VREMARKS,System.Int16 NSTATE,System.DateTime DJZRQ,System.Int16 NDEL,System.String VAPPTIME,System.String VHZID,System.Int16 NPAYTYPE) 
        {
            RowPAYMENT row = ((RowPAYMENT)(this.NewRow()));
            row.ItemArray = new object[] {NGHF,NZLF,VSPMC,VPHONE,DZFRQ,VHAOBIE,VDDLSH,VNAME,VCLINICNO,VCARD,VSFZH,VDEPT,VDOCTOR,DDDRQ,NCOSTS,NDDLX,VREMARKS,NSTATE,DJZRQ,NDEL,VAPPTIME,VHZID,NPAYTYPE};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowPAYMENT FindByVDDLSH(System.String VDDLSH) {
            return ((RowPAYMENT)(this.Rows.Find(new object[] {
                        VDDLSH})));
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
            DataTablePAYMENT cln = ((DataTablePAYMENT)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTablePAYMENT();
        }
        
        internal void InitVars() 
        {	
            this.columnNGHF = this.Columns["NGHF"];
            this.columnNZLF = this.Columns["NZLF"];
            this.columnVSPMC = this.Columns["VSPMC"];
            this.columnVPHONE = this.Columns["VPHONE"];
            this.columnDZFRQ = this.Columns["DZFRQ"];
            this.columnVHAOBIE = this.Columns["VHAOBIE"];
            this.columnVDDLSH = this.Columns["VDDLSH"];
            this.columnVNAME = this.Columns["VNAME"];
            this.columnVCLINICNO = this.Columns["VCLINICNO"];
            this.columnVCARD = this.Columns["VCARD"];
            this.columnVSFZH = this.Columns["VSFZH"];
            this.columnVDEPT = this.Columns["VDEPT"];
            this.columnVDOCTOR = this.Columns["VDOCTOR"];
            this.columnDDDRQ = this.Columns["DDDRQ"];
            this.columnNCOSTS = this.Columns["NCOSTS"];
            this.columnNDDLX = this.Columns["NDDLX"];
            this.columnVREMARKS = this.Columns["VREMARKS"];
            this.columnNSTATE = this.Columns["NSTATE"];
            this.columnDJZRQ = this.Columns["DJZRQ"];
            this.columnNDEL = this.Columns["NDEL"];
            this.columnVAPPTIME = this.Columns["VAPPTIME"];
            this.columnVHZID = this.Columns["VHZID"];
            this.columnNPAYTYPE = this.Columns["NPAYTYPE"];
        }
        
        private void InitClass() 
        {	
            this.columnNGHF = new DataColumn("NGHF", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNGHF.AllowDBNull = true;
            this.Columns.Add(this.columnNGHF);
			
            this.columnNZLF = new DataColumn("NZLF", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNZLF.AllowDBNull = true;
            this.Columns.Add(this.columnNZLF);
			
            this.columnVSPMC = new DataColumn("VSPMC", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVSPMC.MaxLength = 50;
            this.columnVSPMC.AllowDBNull = true;
            this.Columns.Add(this.columnVSPMC);
			
            this.columnVPHONE = new DataColumn("VPHONE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPHONE.MaxLength = 20;
            this.columnVPHONE.AllowDBNull = true;
            this.Columns.Add(this.columnVPHONE);
			
            this.columnDZFRQ = new DataColumn("DZFRQ", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDZFRQ.AllowDBNull = true;
            this.Columns.Add(this.columnDZFRQ);
			
            this.columnVHAOBIE = new DataColumn("VHAOBIE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVHAOBIE.MaxLength = 50;
            this.columnVHAOBIE.AllowDBNull = true;
            this.Columns.Add(this.columnVHAOBIE);
			
            this.columnVDDLSH = new DataColumn("VDDLSH", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDDLSH.MaxLength = 50;
            this.columnVDDLSH.AllowDBNull = false;
            this.columnVDDLSH.Unique = true;
            
            this.Columns.Add(this.columnVDDLSH);
			
            this.columnVNAME = new DataColumn("VNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVNAME.MaxLength = 10;
            this.columnVNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVNAME);
			
            this.columnVCLINICNO = new DataColumn("VCLINICNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCLINICNO.MaxLength = 20;
            this.columnVCLINICNO.AllowDBNull = true;
            this.Columns.Add(this.columnVCLINICNO);
			
            this.columnVCARD = new DataColumn("VCARD", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCARD.MaxLength = 20;
            this.columnVCARD.AllowDBNull = true;
            this.Columns.Add(this.columnVCARD);
			
            this.columnVSFZH = new DataColumn("VSFZH", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVSFZH.MaxLength = 20;
            this.columnVSFZH.AllowDBNull = true;
            this.Columns.Add(this.columnVSFZH);
			
            this.columnVDEPT = new DataColumn("VDEPT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPT.MaxLength = 20;
            this.columnVDEPT.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPT);
			
            this.columnVDOCTOR = new DataColumn("VDOCTOR", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDOCTOR.MaxLength = 20;
            this.columnVDOCTOR.AllowDBNull = true;
            this.Columns.Add(this.columnVDOCTOR);
			
            this.columnDDDRQ = new DataColumn("DDDRQ", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDDDRQ.AllowDBNull = true;
            this.Columns.Add(this.columnDDDRQ);
			
            this.columnNCOSTS = new DataColumn("NCOSTS", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNCOSTS.AllowDBNull = true;
            this.Columns.Add(this.columnNCOSTS);
			
            this.columnNDDLX = new DataColumn("NDDLX", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNDDLX.AllowDBNull = true;
            this.Columns.Add(this.columnNDDLX);
			
            this.columnVREMARKS = new DataColumn("VREMARKS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVREMARKS.MaxLength = 200;
            this.columnVREMARKS.AllowDBNull = true;
            this.Columns.Add(this.columnVREMARKS);
			
            this.columnNSTATE = new DataColumn("NSTATE", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNSTATE.AllowDBNull = true;
            this.Columns.Add(this.columnNSTATE);
			
            this.columnDJZRQ = new DataColumn("DJZRQ", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDJZRQ.AllowDBNull = true;
            this.Columns.Add(this.columnDJZRQ);
			
            this.columnNDEL = new DataColumn("NDEL", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNDEL.DefaultValue = "0";
            this.columnNDEL.AllowDBNull = true;
            this.Columns.Add(this.columnNDEL);
			
            this.columnVAPPTIME = new DataColumn("VAPPTIME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVAPPTIME.MaxLength = 8;
            this.columnVAPPTIME.AllowDBNull = true;
            this.Columns.Add(this.columnVAPPTIME);
			
            this.columnVHZID = new DataColumn("VHZID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVHZID.MaxLength = 50;
            this.columnVHZID.AllowDBNull = true;
            this.Columns.Add(this.columnVHZID);
			
            this.columnNPAYTYPE = new DataColumn("NPAYTYPE", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNPAYTYPE.AllowDBNull = true;
            this.Columns.Add(this.columnNPAYTYPE);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowPAYMENT NewRowPAYMENT() {
            return ((RowPAYMENT)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowPAYMENT(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowPAYMENT);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedPAYMENT != null)) {
                this.RowChangedPAYMENT(this, new RowChangeEventPAYMENT(((RowPAYMENT)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingPAYMENT != null)) {
                this.RowChangingPAYMENT(this, new RowChangeEventPAYMENT(((RowPAYMENT)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedPAYMENT != null)) {
                this.RowDeletedPAYMENT(this, new RowChangeEventPAYMENT(((RowPAYMENT)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingPAYMENT != null)) {
                this.RowDeletingPAYMENT(this, new RowChangeEventPAYMENT(((RowPAYMENT)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowPAYMENT(RowPAYMENT row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowPAYMENT
	/// 
	/// 数据表PAYMENT行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowPAYMENT : DataRow 
    {
        
        private DataTablePAYMENT tablePAYMENT;
        
        internal RowPAYMENT(DataRowBuilder rb) : base(rb) 
        {
            this.tablePAYMENT = ((DataTablePAYMENT)(this.Table));
        }        
		
		/// 
		/// 字段NGHF所映射的属性。
		/// 
        public System.Decimal NGHF
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tablePAYMENT.ColumnNGHF])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnNGHF] = value;
            }
        }
        
		/// 
		/// 字段NZLF所映射的属性。
		/// 
        public System.Decimal NZLF
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tablePAYMENT.ColumnNZLF])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnNZLF] = value;
            }
        }
        
		/// 
		/// 字段VSPMC所映射的属性。
		/// 
        public System.String VSPMC
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tablePAYMENT.ColumnVSPMC])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnVSPMC] = value;
            }
        }
        
		/// 
		/// 字段VPHONE所映射的属性。
		/// 
        public System.String VPHONE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tablePAYMENT.ColumnVPHONE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnVPHONE] = value;
            }
        }
        
		/// 
		/// 字段DZFRQ所映射的属性。
		/// 
        public System.DateTime DZFRQ
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tablePAYMENT.ColumnDZFRQ])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnDZFRQ] = value;
            }
        }
        
		/// 
		/// 字段VHAOBIE所映射的属性。
		/// 
        public System.String VHAOBIE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tablePAYMENT.ColumnVHAOBIE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnVHAOBIE] = value;
            }
        }
        
		/// 
		/// 字段VDDLSH所映射的属性。
		/// 
        public System.String VDDLSH
        {
            get 
            {	
                return ((System.String)(this[this.tablePAYMENT.ColumnVDDLSH])); 
            }
            set 
            {
                this[this.tablePAYMENT.ColumnVDDLSH] = value;
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
	                return ((System.String)(this[this.tablePAYMENT.ColumnVNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnVNAME] = value;
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
	                return ((System.String)(this[this.tablePAYMENT.ColumnVCLINICNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnVCLINICNO] = value;
            }
        }
        
		/// 
		/// 字段VCARD所映射的属性。
		/// 
        public System.String VCARD
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tablePAYMENT.ColumnVCARD])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnVCARD] = value;
            }
        }
        
		/// 
		/// 字段VSFZH所映射的属性。
		/// 
        public System.String VSFZH
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tablePAYMENT.ColumnVSFZH])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnVSFZH] = value;
            }
        }
        
		/// 
		/// 字段VDEPT所映射的属性。
		/// 
        public System.String VDEPT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tablePAYMENT.ColumnVDEPT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnVDEPT] = value;
            }
        }
        
		/// 
		/// 字段VDOCTOR所映射的属性。
		/// 
        public System.String VDOCTOR
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tablePAYMENT.ColumnVDOCTOR])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnVDOCTOR] = value;
            }
        }
        
		/// 
		/// 字段DDDRQ所映射的属性。
		/// 
        public System.DateTime DDDRQ
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tablePAYMENT.ColumnDDDRQ])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnDDDRQ] = value;
            }
        }
        
		/// 
		/// 字段NCOSTS所映射的属性。
		/// 
        public System.Decimal NCOSTS
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tablePAYMENT.ColumnNCOSTS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnNCOSTS] = value;
            }
        }
        
		/// 
		/// 字段NDDLX所映射的属性。
		/// 
        public System.Int16 NDDLX
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tablePAYMENT.ColumnNDDLX])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnNDDLX] = value;
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
	                return ((System.String)(this[this.tablePAYMENT.ColumnVREMARKS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnVREMARKS] = value;
            }
        }
        
		/// 
		/// 字段NSTATE所映射的属性。
		/// 
        public System.Int16 NSTATE
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tablePAYMENT.ColumnNSTATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnNSTATE] = value;
            }
        }
        
		/// 
		/// 字段DJZRQ所映射的属性。
		/// 
        public System.DateTime DJZRQ
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tablePAYMENT.ColumnDJZRQ])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnDJZRQ] = value;
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
	                return ((System.Int16)(this[this.tablePAYMENT.ColumnNDEL])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnNDEL] = value;
            }
        }
        
		/// 
		/// 字段VAPPTIME所映射的属性。
		/// 
        public System.String VAPPTIME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tablePAYMENT.ColumnVAPPTIME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnVAPPTIME] = value;
            }
        }
        
		/// 
		/// 字段VHZID所映射的属性。
		/// 
        public System.String VHZID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tablePAYMENT.ColumnVHZID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnVHZID] = value;
            }
        }
        
		/// 
		/// 字段NPAYTYPE所映射的属性。
		/// 
        public System.Int16 NPAYTYPE
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tablePAYMENT.ColumnNPAYTYPE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tablePAYMENT.ColumnNPAYTYPE] = value;
            }
        }
        
		/// 
		/// 判断字段NGHF是否为空。
		/// 
        public bool IsNGHFNull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnNGHF);
        }

		/// 
		/// 设置字段NGHF为空值。
		/// 
        public void SetNGHFNull() 
        {
            this[this.tablePAYMENT.ColumnNGHF] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NZLF是否为空。
		/// 
        public bool IsNZLFNull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnNZLF);
        }

		/// 
		/// 设置字段NZLF为空值。
		/// 
        public void SetNZLFNull() 
        {
            this[this.tablePAYMENT.ColumnNZLF] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VSPMC是否为空。
		/// 
        public bool IsVSPMCNull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnVSPMC);
        }

		/// 
		/// 设置字段VSPMC为空值。
		/// 
        public void SetVSPMCNull() 
        {
            this[this.tablePAYMENT.ColumnVSPMC] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPHONE是否为空。
		/// 
        public bool IsVPHONENull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnVPHONE);
        }

		/// 
		/// 设置字段VPHONE为空值。
		/// 
        public void SetVPHONENull() 
        {
            this[this.tablePAYMENT.ColumnVPHONE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DZFRQ是否为空。
		/// 
        public bool IsDZFRQNull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnDZFRQ);
        }

		/// 
		/// 设置字段DZFRQ为空值。
		/// 
        public void SetDZFRQNull() 
        {
            this[this.tablePAYMENT.ColumnDZFRQ] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VHAOBIE是否为空。
		/// 
        public bool IsVHAOBIENull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnVHAOBIE);
        }

		/// 
		/// 设置字段VHAOBIE为空值。
		/// 
        public void SetVHAOBIENull() 
        {
            this[this.tablePAYMENT.ColumnVHAOBIE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VNAME是否为空。
		/// 
        public bool IsVNAMENull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnVNAME);
        }

		/// 
		/// 设置字段VNAME为空值。
		/// 
        public void SetVNAMENull() 
        {
            this[this.tablePAYMENT.ColumnVNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VCLINICNO是否为空。
		/// 
        public bool IsVCLINICNONull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnVCLINICNO);
        }

		/// 
		/// 设置字段VCLINICNO为空值。
		/// 
        public void SetVCLINICNONull() 
        {
            this[this.tablePAYMENT.ColumnVCLINICNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VCARD是否为空。
		/// 
        public bool IsVCARDNull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnVCARD);
        }

		/// 
		/// 设置字段VCARD为空值。
		/// 
        public void SetVCARDNull() 
        {
            this[this.tablePAYMENT.ColumnVCARD] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VSFZH是否为空。
		/// 
        public bool IsVSFZHNull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnVSFZH);
        }

		/// 
		/// 设置字段VSFZH为空值。
		/// 
        public void SetVSFZHNull() 
        {
            this[this.tablePAYMENT.ColumnVSFZH] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDEPT是否为空。
		/// 
        public bool IsVDEPTNull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnVDEPT);
        }

		/// 
		/// 设置字段VDEPT为空值。
		/// 
        public void SetVDEPTNull() 
        {
            this[this.tablePAYMENT.ColumnVDEPT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDOCTOR是否为空。
		/// 
        public bool IsVDOCTORNull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnVDOCTOR);
        }

		/// 
		/// 设置字段VDOCTOR为空值。
		/// 
        public void SetVDOCTORNull() 
        {
            this[this.tablePAYMENT.ColumnVDOCTOR] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DDDRQ是否为空。
		/// 
        public bool IsDDDRQNull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnDDDRQ);
        }

		/// 
		/// 设置字段DDDRQ为空值。
		/// 
        public void SetDDDRQNull() 
        {
            this[this.tablePAYMENT.ColumnDDDRQ] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCOSTS是否为空。
		/// 
        public bool IsNCOSTSNull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnNCOSTS);
        }

		/// 
		/// 设置字段NCOSTS为空值。
		/// 
        public void SetNCOSTSNull() 
        {
            this[this.tablePAYMENT.ColumnNCOSTS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NDDLX是否为空。
		/// 
        public bool IsNDDLXNull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnNDDLX);
        }

		/// 
		/// 设置字段NDDLX为空值。
		/// 
        public void SetNDDLXNull() 
        {
            this[this.tablePAYMENT.ColumnNDDLX] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VREMARKS是否为空。
		/// 
        public bool IsVREMARKSNull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnVREMARKS);
        }

		/// 
		/// 设置字段VREMARKS为空值。
		/// 
        public void SetVREMARKSNull() 
        {
            this[this.tablePAYMENT.ColumnVREMARKS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSTATE是否为空。
		/// 
        public bool IsNSTATENull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnNSTATE);
        }

		/// 
		/// 设置字段NSTATE为空值。
		/// 
        public void SetNSTATENull() 
        {
            this[this.tablePAYMENT.ColumnNSTATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DJZRQ是否为空。
		/// 
        public bool IsDJZRQNull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnDJZRQ);
        }

		/// 
		/// 设置字段DJZRQ为空值。
		/// 
        public void SetDJZRQNull() 
        {
            this[this.tablePAYMENT.ColumnDJZRQ] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NDEL是否为空。
		/// 
        public bool IsNDELNull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnNDEL);
        }

		/// 
		/// 设置字段NDEL为空值。
		/// 
        public void SetNDELNull() 
        {
            this[this.tablePAYMENT.ColumnNDEL] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VAPPTIME是否为空。
		/// 
        public bool IsVAPPTIMENull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnVAPPTIME);
        }

		/// 
		/// 设置字段VAPPTIME为空值。
		/// 
        public void SetVAPPTIMENull() 
        {
            this[this.tablePAYMENT.ColumnVAPPTIME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VHZID是否为空。
		/// 
        public bool IsVHZIDNull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnVHZID);
        }

		/// 
		/// 设置字段VHZID为空值。
		/// 
        public void SetVHZIDNull() 
        {
            this[this.tablePAYMENT.ColumnVHZID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NPAYTYPE是否为空。
		/// 
        public bool IsNPAYTYPENull()
        {
            return this.IsNull(this.tablePAYMENT.ColumnNPAYTYPE);
        }

		/// 
		/// 设置字段NPAYTYPE为空值。
		/// 
        public void SetNPAYTYPENull() 
        {
            this[this.tablePAYMENT.ColumnNPAYTYPE] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventPAYMENT : EventArgs {
        
        private RowPAYMENT eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventPAYMENT(RowPAYMENT row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowPAYMENT Row {
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
	