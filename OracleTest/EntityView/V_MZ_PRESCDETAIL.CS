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
	#region DataSetV_MZ_PRESCDETAIL
	/// 
	/// ,V_MZ_PRESCDETAIL的视图实体。
	/// 
    [Serializable()]
    public class DataSetV_MZ_PRESCDETAIL : DataSet
    {
	
		private DataTableV_MZ_PRESCDETAIL tableV_MZ_PRESCDETAIL;

	
        public DataSetV_MZ_PRESCDETAIL() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetV_MZ_PRESCDETAIL实体。
		/// 
		public DataSetV_MZ_PRESCDETAIL GetChangesEntity(DataRowState ds)
		{
			DataSetV_MZ_PRESCDETAIL dataSet = (DataSetV_MZ_PRESCDETAIL)this.GetChanges(ds);
			return dataSet;		
		}
        
        protected DataSetV_MZ_PRESCDETAIL(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
		
                if ((ds.Tables["V_MZ_PRESCDETAIL"] != null)) 
                {
                    this.Tables.Add(new DataTableV_MZ_PRESCDETAIL(ds.Tables["V_MZ_PRESCDETAIL"]));
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
		/// 对于数据表V_MZ_PRESCDETAIL的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableV_MZ_PRESCDETAIL V_MZ_PRESCDETAIL 
		{
			get
			{
				return this.tableV_MZ_PRESCDETAIL;
			}
		}	
	
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetV_MZ_PRESCDETAIL cln = ((DataSetV_MZ_PRESCDETAIL)(base.Clone()));
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
		
			if ((ds.Tables["V_MZ_PRESCDETAIL"] != null)) 
			{
				this.Tables.Add(new DataTableV_MZ_PRESCDETAIL(ds.Tables["V_MZ_PRESCDETAIL"]));
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
		
			this.tableV_MZ_PRESCDETAIL = ((DataTableV_MZ_PRESCDETAIL)(this.Tables["V_MZ_PRESCDETAIL"]));
			if ((this.tableV_MZ_PRESCDETAIL != null)) {
				this.tableV_MZ_PRESCDETAIL.InitVars();
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
			
			this.tableV_MZ_PRESCDETAIL = new DataTableV_MZ_PRESCDETAIL();
			this.Tables.Add(this.tableV_MZ_PRESCDETAIL);
		
			
		
		}
	
		private bool ShouldSerializeV_MZ_PRESCDETAIL() 
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

    public delegate void RowChangeEventHandlerV_MZ_PRESCDETAIL(object sender, RowChangeEventV_MZ_PRESCDETAIL e);
	
	
	#region DataTableV_MZ_PRESCDETAIL
	/// 
	/// 对于数据表V_MZ_PRESCDETAIL的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableV_MZ_PRESCDETAIL : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnDPRESC_DATE;
		
        private DataColumn columnNPRESC;
		
        private DataColumn columnNCOUNT;
		
        private DataColumn columnVISSELF;
		
        private DataColumn columnVDEPT_CODE;
		
        private DataColumn columnVDEPT_NAME;
		
        private DataColumn columnVPATIENTID;
		
        private DataColumn columnVCLINICNO;
		
        private DataColumn columnVPRESC_ID;
		
        private DataColumn columnVITEM_TYPE;
		
        private DataColumn columnVITEM_TYPE_NAME;
		
        private DataColumn columnVITEM_CODE;
		
        private DataColumn columnVITEM_NAME;
		
        private DataColumn columnNPRICE;
		
        private DataColumn columnNACCOUNT;
		
        private DataColumn columnNCOSTS;
		
        private DataColumn columnVITEM_SPEC;
		
        private DataColumn columnVUNITS;
		
        private DataColumn columnVDOSAGE_UNITS;
		
        private DataColumn columnNDOSAGE;
		
        private DataColumn columnNTOTALCHARGES;
		
        private DataColumn columnVADMINISTRATION;
		
        private DataColumn columnVFREQUENCY;
		
        private DataColumn columnNDAYS;
		
        private DataColumn columnNSALESCALE;
		
        private DataColumn columnVITEM_PRODUCT;
		
        private DataColumn columnVREMARKS;
		
        private DataColumn columnVDRUG_STORAGE;
		
        internal DataTableV_MZ_PRESCDETAIL() : base("V_MZ_PRESCDETAIL") 
        {
            this.InitClass();
        }
        
        internal DataTableV_MZ_PRESCDETAIL(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnDPRESC_DATE 
        {
            get 
            {
                return this.columnDPRESC_DATE;
            }
        }
		
        public DataColumn ColumnNPRESC 
        {
            get 
            {
                return this.columnNPRESC;
            }
        }
		
        public DataColumn ColumnNCOUNT 
        {
            get 
            {
                return this.columnNCOUNT;
            }
        }
		
        public DataColumn ColumnVISSELF 
        {
            get 
            {
                return this.columnVISSELF;
            }
        }
		
        public DataColumn ColumnVDEPT_CODE 
        {
            get 
            {
                return this.columnVDEPT_CODE;
            }
        }
		
        public DataColumn ColumnVDEPT_NAME 
        {
            get 
            {
                return this.columnVDEPT_NAME;
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
		
        public DataColumn ColumnVPRESC_ID 
        {
            get 
            {
                return this.columnVPRESC_ID;
            }
        }
		
        public DataColumn ColumnVITEM_TYPE 
        {
            get 
            {
                return this.columnVITEM_TYPE;
            }
        }
		
        public DataColumn ColumnVITEM_TYPE_NAME 
        {
            get 
            {
                return this.columnVITEM_TYPE_NAME;
            }
        }
		
        public DataColumn ColumnVITEM_CODE 
        {
            get 
            {
                return this.columnVITEM_CODE;
            }
        }
		
        public DataColumn ColumnVITEM_NAME 
        {
            get 
            {
                return this.columnVITEM_NAME;
            }
        }
		
        public DataColumn ColumnNPRICE 
        {
            get 
            {
                return this.columnNPRICE;
            }
        }
		
        public DataColumn ColumnNACCOUNT 
        {
            get 
            {
                return this.columnNACCOUNT;
            }
        }
		
        public DataColumn ColumnNCOSTS 
        {
            get 
            {
                return this.columnNCOSTS;
            }
        }
		
        public DataColumn ColumnVITEM_SPEC 
        {
            get 
            {
                return this.columnVITEM_SPEC;
            }
        }
		
        public DataColumn ColumnVUNITS 
        {
            get 
            {
                return this.columnVUNITS;
            }
        }
		
        public DataColumn ColumnVDOSAGE_UNITS 
        {
            get 
            {
                return this.columnVDOSAGE_UNITS;
            }
        }
		
        public DataColumn ColumnNDOSAGE 
        {
            get 
            {
                return this.columnNDOSAGE;
            }
        }
		
        public DataColumn ColumnNTOTALCHARGES 
        {
            get 
            {
                return this.columnNTOTALCHARGES;
            }
        }
		
        public DataColumn ColumnVADMINISTRATION 
        {
            get 
            {
                return this.columnVADMINISTRATION;
            }
        }
		
        public DataColumn ColumnVFREQUENCY 
        {
            get 
            {
                return this.columnVFREQUENCY;
            }
        }
		
        public DataColumn ColumnNDAYS 
        {
            get 
            {
                return this.columnNDAYS;
            }
        }
		
        public DataColumn ColumnNSALESCALE 
        {
            get 
            {
                return this.columnNSALESCALE;
            }
        }
		
        public DataColumn ColumnVITEM_PRODUCT 
        {
            get 
            {
                return this.columnVITEM_PRODUCT;
            }
        }
		
        public DataColumn ColumnVREMARKS 
        {
            get 
            {
                return this.columnVREMARKS;
            }
        }
		
        public DataColumn ColumnVDRUG_STORAGE 
        {
            get 
            {
                return this.columnVDRUG_STORAGE;
            }
        }
		
		/// 
		/// 得到此表中指定索引处的记录。
		/// 
        public RowV_MZ_PRESCDETAIL this[int index] 
        {
            get 
            {
                return ((RowV_MZ_PRESCDETAIL)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerV_MZ_PRESCDETAIL RowChangedV_MZ_PRESCDETAIL;
        
        public event RowChangeEventHandlerV_MZ_PRESCDETAIL RowChangingV_MZ_PRESCDETAIL;
        
        public event RowChangeEventHandlerV_MZ_PRESCDETAIL RowDeletedV_MZ_PRESCDETAIL;
        
        public event RowChangeEventHandlerV_MZ_PRESCDETAIL RowDeletingV_MZ_PRESCDETAIL;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowV_MZ_PRESCDETAIL(RowV_MZ_PRESCDETAIL row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowV_MZ_PRESCDETAIL AddRowV_MZ_PRESCDETAIL(System.DateTime DPRESC_DATE,System.Int16 NPRESC,System.Int16 NCOUNT,System.Int16 VISSELF,System.String VDEPT_CODE,System.String VDEPT_NAME,System.String VPATIENTID,System.String VCLINICNO,System.String VPRESC_ID,System.String VITEM_TYPE,System.String VITEM_TYPE_NAME,System.String VITEM_CODE,System.String VITEM_NAME,System.Decimal NPRICE,System.Decimal NACCOUNT,System.Decimal NCOSTS,System.String VITEM_SPEC,System.String VUNITS,System.String VDOSAGE_UNITS,System.Decimal NDOSAGE,System.Decimal NTOTALCHARGES,System.String VADMINISTRATION,System.String VFREQUENCY,System.Int16 NDAYS,System.Decimal NSALESCALE,System.String VITEM_PRODUCT,System.String VREMARKS,System.String VDRUG_STORAGE) 
        {
            RowV_MZ_PRESCDETAIL row = ((RowV_MZ_PRESCDETAIL)(this.NewRow()));
            row.ItemArray = new object[] {DPRESC_DATE,NPRESC,NCOUNT,VISSELF,VDEPT_CODE,VDEPT_NAME,VPATIENTID,VCLINICNO,VPRESC_ID,VITEM_TYPE,VITEM_TYPE_NAME,VITEM_CODE,VITEM_NAME,NPRICE,NACCOUNT,NCOSTS,VITEM_SPEC,VUNITS,VDOSAGE_UNITS,NDOSAGE,NTOTALCHARGES,VADMINISTRATION,VFREQUENCY,NDAYS,NSALESCALE,VITEM_PRODUCT,VREMARKS,VDRUG_STORAGE};
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
            DataTableV_MZ_PRESCDETAIL cln = ((DataTableV_MZ_PRESCDETAIL)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableV_MZ_PRESCDETAIL();
        }
        
        internal void InitVars() 
        {	
            this.columnDPRESC_DATE = this.Columns["DPRESC_DATE"];
            this.columnNPRESC = this.Columns["NPRESC"];
            this.columnNCOUNT = this.Columns["NCOUNT"];
            this.columnVISSELF = this.Columns["VISSELF"];
            this.columnVDEPT_CODE = this.Columns["VDEPT_CODE"];
            this.columnVDEPT_NAME = this.Columns["VDEPT_NAME"];
            this.columnVPATIENTID = this.Columns["VPATIENTID"];
            this.columnVCLINICNO = this.Columns["VCLINICNO"];
            this.columnVPRESC_ID = this.Columns["VPRESC_ID"];
            this.columnVITEM_TYPE = this.Columns["VITEM_TYPE"];
            this.columnVITEM_TYPE_NAME = this.Columns["VITEM_TYPE_NAME"];
            this.columnVITEM_CODE = this.Columns["VITEM_CODE"];
            this.columnVITEM_NAME = this.Columns["VITEM_NAME"];
            this.columnNPRICE = this.Columns["NPRICE"];
            this.columnNACCOUNT = this.Columns["NACCOUNT"];
            this.columnNCOSTS = this.Columns["NCOSTS"];
            this.columnVITEM_SPEC = this.Columns["VITEM_SPEC"];
            this.columnVUNITS = this.Columns["VUNITS"];
            this.columnVDOSAGE_UNITS = this.Columns["VDOSAGE_UNITS"];
            this.columnNDOSAGE = this.Columns["NDOSAGE"];
            this.columnNTOTALCHARGES = this.Columns["NTOTALCHARGES"];
            this.columnVADMINISTRATION = this.Columns["VADMINISTRATION"];
            this.columnVFREQUENCY = this.Columns["VFREQUENCY"];
            this.columnNDAYS = this.Columns["NDAYS"];
            this.columnNSALESCALE = this.Columns["NSALESCALE"];
            this.columnVITEM_PRODUCT = this.Columns["VITEM_PRODUCT"];
            this.columnVREMARKS = this.Columns["VREMARKS"];
            this.columnVDRUG_STORAGE = this.Columns["VDRUG_STORAGE"];
        }
        
        private void InitClass() 
        {	
            this.columnDPRESC_DATE = new DataColumn("DPRESC_DATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDPRESC_DATE.AllowDBNull = true;
            this.Columns.Add(this.columnDPRESC_DATE);
			
            this.columnNPRESC = new DataColumn("NPRESC", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNPRESC.AllowDBNull = true;
            this.Columns.Add(this.columnNPRESC);
			
            this.columnNCOUNT = new DataColumn("NCOUNT", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNCOUNT.AllowDBNull = true;
            this.Columns.Add(this.columnNCOUNT);
			
            this.columnVISSELF = new DataColumn("VISSELF", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnVISSELF.AllowDBNull = true;
            this.Columns.Add(this.columnVISSELF);
			
            this.columnVDEPT_CODE = new DataColumn("VDEPT_CODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPT_CODE.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPT_CODE);
			
            this.columnVDEPT_NAME = new DataColumn("VDEPT_NAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDEPT_NAME.AllowDBNull = true;
            this.Columns.Add(this.columnVDEPT_NAME);
			
            this.columnVPATIENTID = new DataColumn("VPATIENTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPATIENTID.AllowDBNull = true;
            this.Columns.Add(this.columnVPATIENTID);
			
            this.columnVCLINICNO = new DataColumn("VCLINICNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCLINICNO.AllowDBNull = true;
            this.Columns.Add(this.columnVCLINICNO);
			
            this.columnVPRESC_ID = new DataColumn("VPRESC_ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPRESC_ID.AllowDBNull = true;
            this.Columns.Add(this.columnVPRESC_ID);
			
            this.columnVITEM_TYPE = new DataColumn("VITEM_TYPE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEM_TYPE.AllowDBNull = true;
            this.Columns.Add(this.columnVITEM_TYPE);
			
            this.columnVITEM_TYPE_NAME = new DataColumn("VITEM_TYPE_NAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEM_TYPE_NAME.AllowDBNull = true;
            this.Columns.Add(this.columnVITEM_TYPE_NAME);
			
            this.columnVITEM_CODE = new DataColumn("VITEM_CODE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEM_CODE.AllowDBNull = true;
            this.Columns.Add(this.columnVITEM_CODE);
			
            this.columnVITEM_NAME = new DataColumn("VITEM_NAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEM_NAME.AllowDBNull = true;
            this.Columns.Add(this.columnVITEM_NAME);
			
            this.columnNPRICE = new DataColumn("NPRICE", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNPRICE.AllowDBNull = true;
            this.Columns.Add(this.columnNPRICE);
			
            this.columnNACCOUNT = new DataColumn("NACCOUNT", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNACCOUNT.AllowDBNull = true;
            this.Columns.Add(this.columnNACCOUNT);
			
            this.columnNCOSTS = new DataColumn("NCOSTS", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNCOSTS.AllowDBNull = true;
            this.Columns.Add(this.columnNCOSTS);
			
            this.columnVITEM_SPEC = new DataColumn("VITEM_SPEC", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEM_SPEC.AllowDBNull = true;
            this.Columns.Add(this.columnVITEM_SPEC);
			
            this.columnVUNITS = new DataColumn("VUNITS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVUNITS.AllowDBNull = true;
            this.Columns.Add(this.columnVUNITS);
			
            this.columnVDOSAGE_UNITS = new DataColumn("VDOSAGE_UNITS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDOSAGE_UNITS.AllowDBNull = true;
            this.Columns.Add(this.columnVDOSAGE_UNITS);
			
            this.columnNDOSAGE = new DataColumn("NDOSAGE", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNDOSAGE.AllowDBNull = true;
            this.Columns.Add(this.columnNDOSAGE);
			
            this.columnNTOTALCHARGES = new DataColumn("NTOTALCHARGES", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNTOTALCHARGES.AllowDBNull = true;
            this.Columns.Add(this.columnNTOTALCHARGES);
			
            this.columnVADMINISTRATION = new DataColumn("VADMINISTRATION", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVADMINISTRATION.AllowDBNull = true;
            this.Columns.Add(this.columnVADMINISTRATION);
			
            this.columnVFREQUENCY = new DataColumn("VFREQUENCY", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVFREQUENCY.AllowDBNull = true;
            this.Columns.Add(this.columnVFREQUENCY);
			
            this.columnNDAYS = new DataColumn("NDAYS", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNDAYS.AllowDBNull = true;
            this.Columns.Add(this.columnNDAYS);
			
            this.columnNSALESCALE = new DataColumn("NSALESCALE", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNSALESCALE.AllowDBNull = true;
            this.Columns.Add(this.columnNSALESCALE);
			
            this.columnVITEM_PRODUCT = new DataColumn("VITEM_PRODUCT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEM_PRODUCT.AllowDBNull = true;
            this.Columns.Add(this.columnVITEM_PRODUCT);
			
            this.columnVREMARKS = new DataColumn("VREMARKS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVREMARKS.AllowDBNull = true;
            this.Columns.Add(this.columnVREMARKS);
			
            this.columnVDRUG_STORAGE = new DataColumn("VDRUG_STORAGE", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDRUG_STORAGE.AllowDBNull = true;
            this.Columns.Add(this.columnVDRUG_STORAGE);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowV_MZ_PRESCDETAIL NewRowV_MZ_PRESCDETAIL() {
            return ((RowV_MZ_PRESCDETAIL)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowV_MZ_PRESCDETAIL(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowV_MZ_PRESCDETAIL);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedV_MZ_PRESCDETAIL != null)) {
                this.RowChangedV_MZ_PRESCDETAIL(this, new RowChangeEventV_MZ_PRESCDETAIL(((RowV_MZ_PRESCDETAIL)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingV_MZ_PRESCDETAIL != null)) {
                this.RowChangingV_MZ_PRESCDETAIL(this, new RowChangeEventV_MZ_PRESCDETAIL(((RowV_MZ_PRESCDETAIL)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedV_MZ_PRESCDETAIL != null)) {
                this.RowDeletedV_MZ_PRESCDETAIL(this, new RowChangeEventV_MZ_PRESCDETAIL(((RowV_MZ_PRESCDETAIL)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingV_MZ_PRESCDETAIL != null)) {
                this.RowDeletingV_MZ_PRESCDETAIL(this, new RowChangeEventV_MZ_PRESCDETAIL(((RowV_MZ_PRESCDETAIL)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowV_MZ_PRESCDETAIL(RowV_MZ_PRESCDETAIL row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowV_MZ_PRESCDETAIL
	/// 
	/// 数据表V_MZ_PRESCDETAIL行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowV_MZ_PRESCDETAIL : DataRow 
    {
        
        private DataTableV_MZ_PRESCDETAIL tableV_MZ_PRESCDETAIL;
        
        internal RowV_MZ_PRESCDETAIL(DataRowBuilder rb) : base(rb) 
        {
            this.tableV_MZ_PRESCDETAIL = ((DataTableV_MZ_PRESCDETAIL)(this.Table));
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
	                return ((System.DateTime)(this[this.tableV_MZ_PRESCDETAIL.ColumnDPRESC_DATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnDPRESC_DATE] = value;
            }
        }
        
		/// 
		/// 字段NPRESC所映射的属性。
		/// 
        public System.Int16 NPRESC
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableV_MZ_PRESCDETAIL.ColumnNPRESC])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnNPRESC] = value;
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
	                return ((System.Int16)(this[this.tableV_MZ_PRESCDETAIL.ColumnNCOUNT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnNCOUNT] = value;
            }
        }
        
		/// 
		/// 字段VISSELF所映射的属性。
		/// 
        public System.Int16 VISSELF
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableV_MZ_PRESCDETAIL.ColumnVISSELF])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnVISSELF] = value;
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
	                return ((System.String)(this[this.tableV_MZ_PRESCDETAIL.ColumnVDEPT_CODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnVDEPT_CODE] = value;
            }
        }
        
		/// 
		/// 字段VDEPT_NAME所映射的属性。
		/// 
        public System.String VDEPT_NAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCDETAIL.ColumnVDEPT_NAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnVDEPT_NAME] = value;
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
	                return ((System.String)(this[this.tableV_MZ_PRESCDETAIL.ColumnVPATIENTID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnVPATIENTID] = value;
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
	                return ((System.String)(this[this.tableV_MZ_PRESCDETAIL.ColumnVCLINICNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnVCLINICNO] = value;
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
	                return ((System.String)(this[this.tableV_MZ_PRESCDETAIL.ColumnVPRESC_ID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnVPRESC_ID] = value;
            }
        }
        
		/// 
		/// 字段VITEM_TYPE所映射的属性。
		/// 
        public System.String VITEM_TYPE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCDETAIL.ColumnVITEM_TYPE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnVITEM_TYPE] = value;
            }
        }
        
		/// 
		/// 字段VITEM_TYPE_NAME所映射的属性。
		/// 
        public System.String VITEM_TYPE_NAME
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCDETAIL.ColumnVITEM_TYPE_NAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnVITEM_TYPE_NAME] = value;
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
	                return ((System.String)(this[this.tableV_MZ_PRESCDETAIL.ColumnVITEM_CODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnVITEM_CODE] = value;
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
	                return ((System.String)(this[this.tableV_MZ_PRESCDETAIL.ColumnVITEM_NAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnVITEM_NAME] = value;
            }
        }
        
		/// 
		/// 字段NPRICE所映射的属性。
		/// 
        public System.Decimal NPRICE
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableV_MZ_PRESCDETAIL.ColumnNPRICE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnNPRICE] = value;
            }
        }
        
		/// 
		/// 字段NACCOUNT所映射的属性。
		/// 
        public System.Decimal NACCOUNT
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableV_MZ_PRESCDETAIL.ColumnNACCOUNT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnNACCOUNT] = value;
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
	                return ((System.Decimal)(this[this.tableV_MZ_PRESCDETAIL.ColumnNCOSTS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnNCOSTS] = value;
            }
        }
        
		/// 
		/// 字段VITEM_SPEC所映射的属性。
		/// 
        public System.String VITEM_SPEC
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCDETAIL.ColumnVITEM_SPEC])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnVITEM_SPEC] = value;
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
	                return ((System.String)(this[this.tableV_MZ_PRESCDETAIL.ColumnVUNITS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnVUNITS] = value;
            }
        }
        
		/// 
		/// 字段VDOSAGE_UNITS所映射的属性。
		/// 
        public System.String VDOSAGE_UNITS
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCDETAIL.ColumnVDOSAGE_UNITS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnVDOSAGE_UNITS] = value;
            }
        }
        
		/// 
		/// 字段NDOSAGE所映射的属性。
		/// 
        public System.Decimal NDOSAGE
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableV_MZ_PRESCDETAIL.ColumnNDOSAGE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnNDOSAGE] = value;
            }
        }
        
		/// 
		/// 字段NTOTALCHARGES所映射的属性。
		/// 
        public System.Decimal NTOTALCHARGES
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableV_MZ_PRESCDETAIL.ColumnNTOTALCHARGES])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnNTOTALCHARGES] = value;
            }
        }
        
		/// 
		/// 字段VADMINISTRATION所映射的属性。
		/// 
        public System.String VADMINISTRATION
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCDETAIL.ColumnVADMINISTRATION])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnVADMINISTRATION] = value;
            }
        }
        
		/// 
		/// 字段VFREQUENCY所映射的属性。
		/// 
        public System.String VFREQUENCY
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCDETAIL.ColumnVFREQUENCY])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnVFREQUENCY] = value;
            }
        }
        
		/// 
		/// 字段NDAYS所映射的属性。
		/// 
        public System.Int16 NDAYS
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableV_MZ_PRESCDETAIL.ColumnNDAYS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnNDAYS] = value;
            }
        }
        
		/// 
		/// 字段NSALESCALE所映射的属性。
		/// 
        public System.Decimal NSALESCALE
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableV_MZ_PRESCDETAIL.ColumnNSALESCALE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnNSALESCALE] = value;
            }
        }
        
		/// 
		/// 字段VITEM_PRODUCT所映射的属性。
		/// 
        public System.String VITEM_PRODUCT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCDETAIL.ColumnVITEM_PRODUCT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnVITEM_PRODUCT] = value;
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
	                return ((System.String)(this[this.tableV_MZ_PRESCDETAIL.ColumnVREMARKS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnVREMARKS] = value;
            }
        }
        
		/// 
		/// 字段VDRUG_STORAGE所映射的属性。
		/// 
        public System.String VDRUG_STORAGE
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableV_MZ_PRESCDETAIL.ColumnVDRUG_STORAGE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableV_MZ_PRESCDETAIL.ColumnVDRUG_STORAGE] = value;
            }
        }
        
		/// 
		/// 判断字段DPRESC_DATE是否为空。
		/// 
        public bool IsDPRESC_DATENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnDPRESC_DATE);
        }

		/// 
		/// 设置字段DPRESC_DATE为空值。
		/// 
        public void SetDPRESC_DATENull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnDPRESC_DATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NPRESC是否为空。
		/// 
        public bool IsNPRESCNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnNPRESC);
        }

		/// 
		/// 设置字段NPRESC为空值。
		/// 
        public void SetNPRESCNull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnNPRESC] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCOUNT是否为空。
		/// 
        public bool IsNCOUNTNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnNCOUNT);
        }

		/// 
		/// 设置字段NCOUNT为空值。
		/// 
        public void SetNCOUNTNull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnNCOUNT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VISSELF是否为空。
		/// 
        public bool IsVISSELFNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnVISSELF);
        }

		/// 
		/// 设置字段VISSELF为空值。
		/// 
        public void SetVISSELFNull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnVISSELF] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDEPT_CODE是否为空。
		/// 
        public bool IsVDEPT_CODENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnVDEPT_CODE);
        }

		/// 
		/// 设置字段VDEPT_CODE为空值。
		/// 
        public void SetVDEPT_CODENull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnVDEPT_CODE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDEPT_NAME是否为空。
		/// 
        public bool IsVDEPT_NAMENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnVDEPT_NAME);
        }

		/// 
		/// 设置字段VDEPT_NAME为空值。
		/// 
        public void SetVDEPT_NAMENull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnVDEPT_NAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPATIENTID是否为空。
		/// 
        public bool IsVPATIENTIDNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnVPATIENTID);
        }

		/// 
		/// 设置字段VPATIENTID为空值。
		/// 
        public void SetVPATIENTIDNull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnVPATIENTID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VCLINICNO是否为空。
		/// 
        public bool IsVCLINICNONull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnVCLINICNO);
        }

		/// 
		/// 设置字段VCLINICNO为空值。
		/// 
        public void SetVCLINICNONull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnVCLINICNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPRESC_ID是否为空。
		/// 
        public bool IsVPRESC_IDNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnVPRESC_ID);
        }

		/// 
		/// 设置字段VPRESC_ID为空值。
		/// 
        public void SetVPRESC_IDNull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnVPRESC_ID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEM_TYPE是否为空。
		/// 
        public bool IsVITEM_TYPENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnVITEM_TYPE);
        }

		/// 
		/// 设置字段VITEM_TYPE为空值。
		/// 
        public void SetVITEM_TYPENull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnVITEM_TYPE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEM_TYPE_NAME是否为空。
		/// 
        public bool IsVITEM_TYPE_NAMENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnVITEM_TYPE_NAME);
        }

		/// 
		/// 设置字段VITEM_TYPE_NAME为空值。
		/// 
        public void SetVITEM_TYPE_NAMENull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnVITEM_TYPE_NAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEM_CODE是否为空。
		/// 
        public bool IsVITEM_CODENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnVITEM_CODE);
        }

		/// 
		/// 设置字段VITEM_CODE为空值。
		/// 
        public void SetVITEM_CODENull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnVITEM_CODE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEM_NAME是否为空。
		/// 
        public bool IsVITEM_NAMENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnVITEM_NAME);
        }

		/// 
		/// 设置字段VITEM_NAME为空值。
		/// 
        public void SetVITEM_NAMENull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnVITEM_NAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NPRICE是否为空。
		/// 
        public bool IsNPRICENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnNPRICE);
        }

		/// 
		/// 设置字段NPRICE为空值。
		/// 
        public void SetNPRICENull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnNPRICE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NACCOUNT是否为空。
		/// 
        public bool IsNACCOUNTNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnNACCOUNT);
        }

		/// 
		/// 设置字段NACCOUNT为空值。
		/// 
        public void SetNACCOUNTNull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnNACCOUNT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCOSTS是否为空。
		/// 
        public bool IsNCOSTSNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnNCOSTS);
        }

		/// 
		/// 设置字段NCOSTS为空值。
		/// 
        public void SetNCOSTSNull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnNCOSTS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEM_SPEC是否为空。
		/// 
        public bool IsVITEM_SPECNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnVITEM_SPEC);
        }

		/// 
		/// 设置字段VITEM_SPEC为空值。
		/// 
        public void SetVITEM_SPECNull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnVITEM_SPEC] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VUNITS是否为空。
		/// 
        public bool IsVUNITSNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnVUNITS);
        }

		/// 
		/// 设置字段VUNITS为空值。
		/// 
        public void SetVUNITSNull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnVUNITS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDOSAGE_UNITS是否为空。
		/// 
        public bool IsVDOSAGE_UNITSNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnVDOSAGE_UNITS);
        }

		/// 
		/// 设置字段VDOSAGE_UNITS为空值。
		/// 
        public void SetVDOSAGE_UNITSNull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnVDOSAGE_UNITS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NDOSAGE是否为空。
		/// 
        public bool IsNDOSAGENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnNDOSAGE);
        }

		/// 
		/// 设置字段NDOSAGE为空值。
		/// 
        public void SetNDOSAGENull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnNDOSAGE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NTOTALCHARGES是否为空。
		/// 
        public bool IsNTOTALCHARGESNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnNTOTALCHARGES);
        }

		/// 
		/// 设置字段NTOTALCHARGES为空值。
		/// 
        public void SetNTOTALCHARGESNull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnNTOTALCHARGES] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VADMINISTRATION是否为空。
		/// 
        public bool IsVADMINISTRATIONNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnVADMINISTRATION);
        }

		/// 
		/// 设置字段VADMINISTRATION为空值。
		/// 
        public void SetVADMINISTRATIONNull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnVADMINISTRATION] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VFREQUENCY是否为空。
		/// 
        public bool IsVFREQUENCYNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnVFREQUENCY);
        }

		/// 
		/// 设置字段VFREQUENCY为空值。
		/// 
        public void SetVFREQUENCYNull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnVFREQUENCY] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NDAYS是否为空。
		/// 
        public bool IsNDAYSNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnNDAYS);
        }

		/// 
		/// 设置字段NDAYS为空值。
		/// 
        public void SetNDAYSNull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnNDAYS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSALESCALE是否为空。
		/// 
        public bool IsNSALESCALENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnNSALESCALE);
        }

		/// 
		/// 设置字段NSALESCALE为空值。
		/// 
        public void SetNSALESCALENull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnNSALESCALE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEM_PRODUCT是否为空。
		/// 
        public bool IsVITEM_PRODUCTNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnVITEM_PRODUCT);
        }

		/// 
		/// 设置字段VITEM_PRODUCT为空值。
		/// 
        public void SetVITEM_PRODUCTNull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnVITEM_PRODUCT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VREMARKS是否为空。
		/// 
        public bool IsVREMARKSNull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnVREMARKS);
        }

		/// 
		/// 设置字段VREMARKS为空值。
		/// 
        public void SetVREMARKSNull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnVREMARKS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDRUG_STORAGE是否为空。
		/// 
        public bool IsVDRUG_STORAGENull()
        {
            return this.IsNull(this.tableV_MZ_PRESCDETAIL.ColumnVDRUG_STORAGE);
        }

		/// 
		/// 设置字段VDRUG_STORAGE为空值。
		/// 
        public void SetVDRUG_STORAGENull() 
        {
            this[this.tableV_MZ_PRESCDETAIL.ColumnVDRUG_STORAGE] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventV_MZ_PRESCDETAIL : EventArgs {
        
        private RowV_MZ_PRESCDETAIL eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventV_MZ_PRESCDETAIL(RowV_MZ_PRESCDETAIL row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowV_MZ_PRESCDETAIL Row {
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
	