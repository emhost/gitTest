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
	#region DataSetGHSF_JZ
	/// 
	/// 对于GHSF_JZ的定义类的实现（数据集定义）。注意：自动建立表之间的关联（Relations），并创建主键唯一性约束（如果主键存在），但并没有建立外键约束（ForeignKeyConstraint）。
	/// 
    [Serializable()]
    public class DataSetGHSF_JZ : DataSet
    {
		
		private DataTableGHSF_GHSF_JZ tableGHSF_GHSF_JZ;
		
        public DataSetGHSF_JZ() 
        {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
		/// 
		/// 得到改变的DataSetGHSF_JZ实体。注意：得到的实体里面的Relations（如果存在）已经被删除，也就是说得到的实体表之间时没有任何关联的， 并且得到的数据集呈现无改变状态。
		/// 
		public DataSetGHSF_JZ GetChangesEntity(DataRowState ds)
		{

			///////// 2006-02-21
			DataSetGHSF_JZ dataSet = (DataSetGHSF_JZ)this.GetChanges(ds);
			return dataSet;		
			
/*	2006=02-21
			DataSetGHSF_JZ entity = new DataSetGHSF_JZ();
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
        
        protected DataSetGHSF_JZ(SerializationInfo info, StreamingContext context) 
        {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) 
            {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
				
                if ((ds.Tables["GHSF_GHSF_JZ"] != null)) 
                {
                    this.Tables.Add(new DataTableGHSF_GHSF_JZ(ds.Tables["GHSF_GHSF_JZ"]));
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
		/// 对于数据表GHSF_GHSF_JZ的映射类的一个实例。
		/// 
		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
		public DataTableGHSF_GHSF_JZ GHSF_GHSF_JZ 
		{
			get
			{
				return this.tableGHSF_GHSF_JZ;
			}
		}	
		
		/// 
		/// Clone新的DataSet。
		/// 
		public override DataSet Clone() 
		{
			DataSetGHSF_JZ cln = ((DataSetGHSF_JZ)(base.Clone()));
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
			
			if ((ds.Tables["GHSF_GHSF_JZ"] != null)) 
			{
				this.Tables.Add(new DataTableGHSF_GHSF_JZ(ds.Tables["GHSF_GHSF_JZ"]));
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
			
			this.tableGHSF_GHSF_JZ = ((DataTableGHSF_GHSF_JZ)(this.Tables["GHSF_GHSF_JZ"]));
			if ((this.tableGHSF_GHSF_JZ != null)) {
				this.tableGHSF_GHSF_JZ.InitVars();
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
			
			this.tableGHSF_GHSF_JZ = new DataTableGHSF_GHSF_JZ();
			this.Tables.Add(this.tableGHSF_GHSF_JZ);
			
		}
		
		private bool ShouldSerializeGHSF_GHSF_JZ() 
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
	
    public delegate void RowChangeEventHandlerGHSF_GHSF_JZ(object sender, RowChangeEventGHSF_GHSF_JZ e);
	
	#region DataTableGHSF_GHSF_JZ
	/// 
	/// 对于数据表GHSF_GHSF_JZ的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class DataTableGHSF_GHSF_JZ : DataTable, System.Collections.IEnumerable 
    {
		
        private DataColumn columnVACCOUNTSID;
		
        private DataColumn columnVRCPTID;
		
        private DataColumn columnVPRESCNO;
		
        private DataColumn columnVITEMID;
		
        private DataColumn columnVITEMNAME;
		
        private DataColumn columnNPRICE;
		
        private DataColumn columnNCOSTS;
		
        private DataColumn columnNACCOUNTSCOSTS;
		
        private DataColumn columnNCHARGEFLAG;
		
        private DataColumn columnDMEDICINEDATE;
		
        private DataColumn columnVOPERATORID;
		
        private DataColumn columnNSETTLE;
		
        private DataColumn columnDSETTLEDATE;
		
        private DataColumn columnVSETTLEID;
		
        private DataColumn columnVCARDNO;
		
        private DataColumn columnNACCOUNT;
		
        private DataColumn columnVINVOICENO;
		
        private DataColumn columnNFLAG;
		
        private DataColumn columnVVISITDEPT;
		
        private DataColumn columnVREMARKS;
		
        private DataColumn columnVPATIENTID;
		
        private DataColumn columnNACCT_MODE;
		
        private DataColumn columnVCOUNTDEPT;
		
        private DataColumn columnVDOCTOR_ID;
		
        private DataColumn columnVACCTID;
		
        private DataColumn columnNACCOUNTTF;
		
        private DataColumn columnVACCOUNTSIDTF;
		
        private DataColumn columnNOPHZID;
		
        private DataColumn columnVCLINICNO;
		
        private DataColumn columnNHOSID;
		
        internal DataTableGHSF_GHSF_JZ() : base("GHSF_GHSF_JZ") 
        {
            this.InitClass();
        }
        
        internal DataTableGHSF_GHSF_JZ(DataTable table) : base(table.TableName) 
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
		
        public DataColumn ColumnVACCOUNTSID 
        {
            get 
            {
                return this.columnVACCOUNTSID;
            }
        }
		
        public DataColumn ColumnVRCPTID 
        {
            get 
            {
                return this.columnVRCPTID;
            }
        }
		
        public DataColumn ColumnVPRESCNO 
        {
            get 
            {
                return this.columnVPRESCNO;
            }
        }
		
        public DataColumn ColumnVITEMID 
        {
            get 
            {
                return this.columnVITEMID;
            }
        }
		
        public DataColumn ColumnVITEMNAME 
        {
            get 
            {
                return this.columnVITEMNAME;
            }
        }
		
        public DataColumn ColumnNPRICE 
        {
            get 
            {
                return this.columnNPRICE;
            }
        }
		
        public DataColumn ColumnNCOSTS 
        {
            get 
            {
                return this.columnNCOSTS;
            }
        }
		
        public DataColumn ColumnNACCOUNTSCOSTS 
        {
            get 
            {
                return this.columnNACCOUNTSCOSTS;
            }
        }
		
        public DataColumn ColumnNCHARGEFLAG 
        {
            get 
            {
                return this.columnNCHARGEFLAG;
            }
        }
		
        public DataColumn ColumnDMEDICINEDATE 
        {
            get 
            {
                return this.columnDMEDICINEDATE;
            }
        }
		
        public DataColumn ColumnVOPERATORID 
        {
            get 
            {
                return this.columnVOPERATORID;
            }
        }
		
        public DataColumn ColumnNSETTLE 
        {
            get 
            {
                return this.columnNSETTLE;
            }
        }
		
        public DataColumn ColumnDSETTLEDATE 
        {
            get 
            {
                return this.columnDSETTLEDATE;
            }
        }
		
        public DataColumn ColumnVSETTLEID 
        {
            get 
            {
                return this.columnVSETTLEID;
            }
        }
		
        public DataColumn ColumnVCARDNO 
        {
            get 
            {
                return this.columnVCARDNO;
            }
        }
		
        public DataColumn ColumnNACCOUNT 
        {
            get 
            {
                return this.columnNACCOUNT;
            }
        }
		
        public DataColumn ColumnVINVOICENO 
        {
            get 
            {
                return this.columnVINVOICENO;
            }
        }
		
        public DataColumn ColumnNFLAG 
        {
            get 
            {
                return this.columnNFLAG;
            }
        }
		
        public DataColumn ColumnVVISITDEPT 
        {
            get 
            {
                return this.columnVVISITDEPT;
            }
        }
		
        public DataColumn ColumnVREMARKS 
        {
            get 
            {
                return this.columnVREMARKS;
            }
        }
		
        public DataColumn ColumnVPATIENTID 
        {
            get 
            {
                return this.columnVPATIENTID;
            }
        }
		
        public DataColumn ColumnNACCT_MODE 
        {
            get 
            {
                return this.columnNACCT_MODE;
            }
        }
		
        public DataColumn ColumnVCOUNTDEPT 
        {
            get 
            {
                return this.columnVCOUNTDEPT;
            }
        }
		
        public DataColumn ColumnVDOCTOR_ID 
        {
            get 
            {
                return this.columnVDOCTOR_ID;
            }
        }
		
        public DataColumn ColumnVACCTID 
        {
            get 
            {
                return this.columnVACCTID;
            }
        }
		
        public DataColumn ColumnNACCOUNTTF 
        {
            get 
            {
                return this.columnNACCOUNTTF;
            }
        }
		
        public DataColumn ColumnVACCOUNTSIDTF 
        {
            get 
            {
                return this.columnVACCOUNTSIDTF;
            }
        }
		
        public DataColumn ColumnNOPHZID 
        {
            get 
            {
                return this.columnNOPHZID;
            }
        }
		
        public DataColumn ColumnVCLINICNO 
        {
            get 
            {
                return this.columnVCLINICNO;
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
        public RowGHSF_GHSF_JZ this[int index] 
        {
            get 
            {
                return ((RowGHSF_GHSF_JZ)(this.Rows[index]));
            }
        }

        public event RowChangeEventHandlerGHSF_GHSF_JZ RowChangedGHSF_GHSF_JZ;
        
        public event RowChangeEventHandlerGHSF_GHSF_JZ RowChangingGHSF_GHSF_JZ;
        
        public event RowChangeEventHandlerGHSF_GHSF_JZ RowDeletedGHSF_GHSF_JZ;
        
        public event RowChangeEventHandlerGHSF_GHSF_JZ RowDeletingGHSF_GHSF_JZ;

		/// 
		/// 增加新一条新记录。
		/// 
        public void AddRowGHSF_GHSF_JZ(RowGHSF_GHSF_JZ row) 
        {
            this.Rows.Add(row);
        }
        
		/// 
		/// 增加新一条新记录。
		/// 
        public RowGHSF_GHSF_JZ AddRowGHSF_GHSF_JZ(System.String VACCOUNTSID,System.String VRCPTID,System.String VPRESCNO,System.String VITEMID,System.String VITEMNAME,System.Decimal NPRICE,System.Decimal NCOSTS,System.Decimal NACCOUNTSCOSTS,System.Int16 NCHARGEFLAG,System.DateTime DMEDICINEDATE,System.String VOPERATORID,System.Int16 NSETTLE,System.DateTime DSETTLEDATE,System.String VSETTLEID,System.String VCARDNO,System.Decimal NACCOUNT,System.String VINVOICENO,System.String NFLAG,System.String VVISITDEPT,System.String VREMARKS,System.String VPATIENTID,System.Int32 NACCT_MODE,System.String VCOUNTDEPT,System.String VDOCTOR_ID,System.String VACCTID,System.Decimal NACCOUNTTF,System.String VACCOUNTSIDTF,System.Int16 NOPHZID,System.String VCLINICNO,System.Int32 NHOSID) 
        {
            RowGHSF_GHSF_JZ row = ((RowGHSF_GHSF_JZ)(this.NewRow()));
            row.ItemArray = new object[] {VACCOUNTSID,VRCPTID,VPRESCNO,VITEMID,VITEMNAME,NPRICE,NCOSTS,NACCOUNTSCOSTS,NCHARGEFLAG,DMEDICINEDATE,VOPERATORID,NSETTLE,DSETTLEDATE,VSETTLEID,VCARDNO,NACCOUNT,VINVOICENO,NFLAG,VVISITDEPT,VREMARKS,VPATIENTID,NACCT_MODE,VCOUNTDEPT,VDOCTOR_ID,VACCTID,NACCOUNTTF,VACCOUNTSIDTF,NOPHZID,VCLINICNO,NHOSID};
            this.Rows.Add(row);
            return row;
        }
		
		/// 
		/// 找到指定主键的记录。
		/// 
        public RowGHSF_GHSF_JZ FindByVACCOUNTSID(System.String VACCOUNTSID) {
            return ((RowGHSF_GHSF_JZ)(this.Rows.Find(new object[] {
                        VACCOUNTSID})));
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
            DataTableGHSF_GHSF_JZ cln = ((DataTableGHSF_GHSF_JZ)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override DataTable CreateInstance() {
            return new DataTableGHSF_GHSF_JZ();
        }
        
        internal void InitVars() 
        {	
            this.columnVACCOUNTSID = this.Columns["VACCOUNTSID"];
            this.columnVRCPTID = this.Columns["VRCPTID"];
            this.columnVPRESCNO = this.Columns["VPRESCNO"];
            this.columnVITEMID = this.Columns["VITEMID"];
            this.columnVITEMNAME = this.Columns["VITEMNAME"];
            this.columnNPRICE = this.Columns["NPRICE"];
            this.columnNCOSTS = this.Columns["NCOSTS"];
            this.columnNACCOUNTSCOSTS = this.Columns["NACCOUNTSCOSTS"];
            this.columnNCHARGEFLAG = this.Columns["NCHARGEFLAG"];
            this.columnDMEDICINEDATE = this.Columns["DMEDICINEDATE"];
            this.columnVOPERATORID = this.Columns["VOPERATORID"];
            this.columnNSETTLE = this.Columns["NSETTLE"];
            this.columnDSETTLEDATE = this.Columns["DSETTLEDATE"];
            this.columnVSETTLEID = this.Columns["VSETTLEID"];
            this.columnVCARDNO = this.Columns["VCARDNO"];
            this.columnNACCOUNT = this.Columns["NACCOUNT"];
            this.columnVINVOICENO = this.Columns["VINVOICENO"];
            this.columnNFLAG = this.Columns["NFLAG"];
            this.columnVVISITDEPT = this.Columns["VVISITDEPT"];
            this.columnVREMARKS = this.Columns["VREMARKS"];
            this.columnVPATIENTID = this.Columns["VPATIENTID"];
            this.columnNACCT_MODE = this.Columns["NACCT_MODE"];
            this.columnVCOUNTDEPT = this.Columns["VCOUNTDEPT"];
            this.columnVDOCTOR_ID = this.Columns["VDOCTOR_ID"];
            this.columnVACCTID = this.Columns["VACCTID"];
            this.columnNACCOUNTTF = this.Columns["NACCOUNTTF"];
            this.columnVACCOUNTSIDTF = this.Columns["VACCOUNTSIDTF"];
            this.columnNOPHZID = this.Columns["NOPHZID"];
            this.columnVCLINICNO = this.Columns["VCLINICNO"];
            this.columnNHOSID = this.Columns["NHOSID"];
        }
        
        private void InitClass() 
        {	
            this.columnVACCOUNTSID = new DataColumn("VACCOUNTSID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVACCOUNTSID.MaxLength = 10;
            this.columnVACCOUNTSID.AllowDBNull = false;
            this.columnVACCOUNTSID.Unique = true;
            
            this.Columns.Add(this.columnVACCOUNTSID);
			
            this.columnVRCPTID = new DataColumn("VRCPTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVRCPTID.MaxLength = 2;
            this.columnVRCPTID.AllowDBNull = false;
            this.Columns.Add(this.columnVRCPTID);
			
            this.columnVPRESCNO = new DataColumn("VPRESCNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPRESCNO.MaxLength = 20;
            this.columnVPRESCNO.AllowDBNull = false;
            this.Columns.Add(this.columnVPRESCNO);
			
            this.columnVITEMID = new DataColumn("VITEMID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEMID.MaxLength = 50;
            this.columnVITEMID.AllowDBNull = true;
            this.Columns.Add(this.columnVITEMID);
			
            this.columnVITEMNAME = new DataColumn("VITEMNAME", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVITEMNAME.MaxLength = 50;
            this.columnVITEMNAME.AllowDBNull = true;
            this.Columns.Add(this.columnVITEMNAME);
			
            this.columnNPRICE = new DataColumn("NPRICE", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNPRICE.AllowDBNull = true;
            this.Columns.Add(this.columnNPRICE);
			
            this.columnNCOSTS = new DataColumn("NCOSTS", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNCOSTS.AllowDBNull = true;
            this.Columns.Add(this.columnNCOSTS);
			
            this.columnNACCOUNTSCOSTS = new DataColumn("NACCOUNTSCOSTS", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNACCOUNTSCOSTS.AllowDBNull = false;
            this.Columns.Add(this.columnNACCOUNTSCOSTS);
			
            this.columnNCHARGEFLAG = new DataColumn("NCHARGEFLAG", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNCHARGEFLAG.DefaultValue = "1";
            this.columnNCHARGEFLAG.AllowDBNull = true;
            this.Columns.Add(this.columnNCHARGEFLAG);
			
            this.columnDMEDICINEDATE = new DataColumn("DMEDICINEDATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDMEDICINEDATE.AllowDBNull = true;
            this.Columns.Add(this.columnDMEDICINEDATE);
			
            this.columnVOPERATORID = new DataColumn("VOPERATORID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVOPERATORID.MaxLength = 20;
            this.columnVOPERATORID.AllowDBNull = true;
            this.Columns.Add(this.columnVOPERATORID);
			
            this.columnNSETTLE = new DataColumn("NSETTLE", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNSETTLE.DefaultValue = "0";
            this.columnNSETTLE.AllowDBNull = true;
            this.Columns.Add(this.columnNSETTLE);
			
            this.columnDSETTLEDATE = new DataColumn("DSETTLEDATE", typeof(System.DateTime), null, System.Data.MappingType.Element);
            this.columnDSETTLEDATE.AllowDBNull = true;
            this.Columns.Add(this.columnDSETTLEDATE);
			
            this.columnVSETTLEID = new DataColumn("VSETTLEID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVSETTLEID.MaxLength = 20;
            this.columnVSETTLEID.AllowDBNull = true;
            this.Columns.Add(this.columnVSETTLEID);
			
            this.columnVCARDNO = new DataColumn("VCARDNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCARDNO.MaxLength = 10;
            this.columnVCARDNO.AllowDBNull = true;
            this.Columns.Add(this.columnVCARDNO);
			
            this.columnNACCOUNT = new DataColumn("NACCOUNT", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNACCOUNT.AllowDBNull = true;
            this.Columns.Add(this.columnNACCOUNT);
			
            this.columnVINVOICENO = new DataColumn("VINVOICENO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVINVOICENO.MaxLength = 20;
            this.columnVINVOICENO.AllowDBNull = true;
            this.Columns.Add(this.columnVINVOICENO);
			
            this.columnNFLAG = new DataColumn("NFLAG", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnNFLAG.MaxLength = 10;
            this.columnNFLAG.AllowDBNull = true;
            this.Columns.Add(this.columnNFLAG);
			
            this.columnVVISITDEPT = new DataColumn("VVISITDEPT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVVISITDEPT.MaxLength = 20;
            this.columnVVISITDEPT.AllowDBNull = true;
            this.Columns.Add(this.columnVVISITDEPT);
			
            this.columnVREMARKS = new DataColumn("VREMARKS", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVREMARKS.MaxLength = 50;
            this.columnVREMARKS.AllowDBNull = true;
            this.Columns.Add(this.columnVREMARKS);
			
            this.columnVPATIENTID = new DataColumn("VPATIENTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVPATIENTID.MaxLength = 10;
            this.columnVPATIENTID.AllowDBNull = true;
            this.Columns.Add(this.columnVPATIENTID);
			
            this.columnNACCT_MODE = new DataColumn("NACCT_MODE", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNACCT_MODE.AllowDBNull = true;
            this.Columns.Add(this.columnNACCT_MODE);
			
            this.columnVCOUNTDEPT = new DataColumn("VCOUNTDEPT", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCOUNTDEPT.MaxLength = 20;
            this.columnVCOUNTDEPT.AllowDBNull = true;
            this.Columns.Add(this.columnVCOUNTDEPT);
			
            this.columnVDOCTOR_ID = new DataColumn("VDOCTOR_ID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVDOCTOR_ID.MaxLength = 20;
            this.columnVDOCTOR_ID.AllowDBNull = true;
            this.Columns.Add(this.columnVDOCTOR_ID);
			
            this.columnVACCTID = new DataColumn("VACCTID", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVACCTID.MaxLength = 10;
            this.columnVACCTID.AllowDBNull = true;
            this.Columns.Add(this.columnVACCTID);
			
            this.columnNACCOUNTTF = new DataColumn("NACCOUNTTF", typeof(System.Decimal), null, System.Data.MappingType.Element);
            this.columnNACCOUNTTF.DefaultValue = "0";
            this.columnNACCOUNTTF.AllowDBNull = true;
            this.Columns.Add(this.columnNACCOUNTTF);
			
            this.columnVACCOUNTSIDTF = new DataColumn("VACCOUNTSIDTF", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVACCOUNTSIDTF.MaxLength = 10;
            this.columnVACCOUNTSIDTF.AllowDBNull = true;
            this.Columns.Add(this.columnVACCOUNTSIDTF);
			
            this.columnNOPHZID = new DataColumn("NOPHZID", typeof(System.Int16), null, System.Data.MappingType.Element);
            this.columnNOPHZID.DefaultValue = "0";
            this.columnNOPHZID.AllowDBNull = true;
            this.Columns.Add(this.columnNOPHZID);
			
            this.columnVCLINICNO = new DataColumn("VCLINICNO", typeof(System.String), null, System.Data.MappingType.Element);
            this.columnVCLINICNO.MaxLength = 20;
            this.columnVCLINICNO.AllowDBNull = true;
            this.Columns.Add(this.columnVCLINICNO);
			
            this.columnNHOSID = new DataColumn("NHOSID", typeof(System.Int32), null, System.Data.MappingType.Element);
            this.columnNHOSID.AllowDBNull = true;
            this.Columns.Add(this.columnNHOSID);
			
        }
        
		/// 
		/// 得到与此表模式相同的一条新记录。
		/// 
        public RowGHSF_GHSF_JZ NewRowGHSF_GHSF_JZ() {
            return ((RowGHSF_GHSF_JZ)(this.NewRow()));
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
            return new RowGHSF_GHSF_JZ(builder);
        }
        
        protected override System.Type GetRowType() {
            return typeof(RowGHSF_GHSF_JZ);
        }
        
        protected override void OnRowChanged(DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.RowChangedGHSF_GHSF_JZ != null)) {
                this.RowChangedGHSF_GHSF_JZ(this, new RowChangeEventGHSF_GHSF_JZ(((RowGHSF_GHSF_JZ)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanging(DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.RowChangingGHSF_GHSF_JZ != null)) {
                this.RowChangingGHSF_GHSF_JZ(this, new RowChangeEventGHSF_GHSF_JZ(((RowGHSF_GHSF_JZ)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.RowDeletedGHSF_GHSF_JZ != null)) {
                this.RowDeletedGHSF_GHSF_JZ(this, new RowChangeEventGHSF_GHSF_JZ(((RowGHSF_GHSF_JZ)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.RowDeletingGHSF_GHSF_JZ != null)) {
                this.RowDeletingGHSF_GHSF_JZ(this, new RowChangeEventGHSF_GHSF_JZ(((RowGHSF_GHSF_JZ)(e.Row)), e.Action));
            }
        }
        
		/// 
		/// 删除指定的记录。
		/// 
        public void RemoveRowGHSF_GHSF_JZ(RowGHSF_GHSF_JZ row) {
            this.Rows.Remove(row);
        }
    }
    #endregion
    
    #region RowGHSF_GHSF_JZ
	/// 
	/// 数据表GHSF_GHSF_JZ行的映射类。
	/// 
    [System.Diagnostics.DebuggerStepThrough()]
    public class RowGHSF_GHSF_JZ : DataRow 
    {
        
        private DataTableGHSF_GHSF_JZ tableGHSF_GHSF_JZ;
        
        internal RowGHSF_GHSF_JZ(DataRowBuilder rb) : base(rb) 
        {
            this.tableGHSF_GHSF_JZ = ((DataTableGHSF_GHSF_JZ)(this.Table));
        }        
		
		/// 
		/// 字段VACCOUNTSID所映射的属性。
		/// 
        public System.String VACCOUNTSID
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_JZ.ColumnVACCOUNTSID])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnVACCOUNTSID] = value;
            }
        }
        
		/// 
		/// 字段VRCPTID所映射的属性。
		/// 
        public System.String VRCPTID
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_JZ.ColumnVRCPTID])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnVRCPTID] = value;
            }
        }
        
		/// 
		/// 字段VPRESCNO所映射的属性。
		/// 
        public System.String VPRESCNO
        {
            get 
            {	
                return ((System.String)(this[this.tableGHSF_GHSF_JZ.ColumnVPRESCNO])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnVPRESCNO] = value;
            }
        }
        
		/// 
		/// 字段VITEMID所映射的属性。
		/// 
        public System.String VITEMID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_JZ.ColumnVITEMID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnVITEMID] = value;
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
	                return ((System.String)(this[this.tableGHSF_GHSF_JZ.ColumnVITEMNAME])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnVITEMNAME] = value;
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
	                return ((System.Decimal)(this[this.tableGHSF_GHSF_JZ.ColumnNPRICE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnNPRICE] = value;
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
	                return ((System.Decimal)(this[this.tableGHSF_GHSF_JZ.ColumnNCOSTS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnNCOSTS] = value;
            }
        }
        
		/// 
		/// 字段NACCOUNTSCOSTS所映射的属性。
		/// 
        public System.Decimal NACCOUNTSCOSTS
        {
            get 
            {	
                return ((System.Decimal)(this[this.tableGHSF_GHSF_JZ.ColumnNACCOUNTSCOSTS])); 
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnNACCOUNTSCOSTS] = value;
            }
        }
        
		/// 
		/// 字段NCHARGEFLAG所映射的属性。
		/// 
        public System.Int16 NCHARGEFLAG
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_JZ.ColumnNCHARGEFLAG])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnNCHARGEFLAG] = value;
            }
        }
        
		/// 
		/// 字段DMEDICINEDATE所映射的属性。
		/// 
        public System.DateTime DMEDICINEDATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableGHSF_GHSF_JZ.ColumnDMEDICINEDATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnDMEDICINEDATE] = value;
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
	                return ((System.String)(this[this.tableGHSF_GHSF_JZ.ColumnVOPERATORID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnVOPERATORID] = value;
            }
        }
        
		/// 
		/// 字段NSETTLE所映射的属性。
		/// 
        public System.Int16 NSETTLE
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_JZ.ColumnNSETTLE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnNSETTLE] = value;
            }
        }
        
		/// 
		/// 字段DSETTLEDATE所映射的属性。
		/// 
        public System.DateTime DSETTLEDATE
        {
            get 
            {	
                try 
                {
	                return ((System.DateTime)(this[this.tableGHSF_GHSF_JZ.ColumnDSETTLEDATE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnDSETTLEDATE] = value;
            }
        }
        
		/// 
		/// 字段VSETTLEID所映射的属性。
		/// 
        public System.String VSETTLEID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_JZ.ColumnVSETTLEID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnVSETTLEID] = value;
            }
        }
        
		/// 
		/// 字段VCARDNO所映射的属性。
		/// 
        public System.String VCARDNO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_JZ.ColumnVCARDNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnVCARDNO] = value;
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
	                return ((System.Decimal)(this[this.tableGHSF_GHSF_JZ.ColumnNACCOUNT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnNACCOUNT] = value;
            }
        }
        
		/// 
		/// 字段VINVOICENO所映射的属性。
		/// 
        public System.String VINVOICENO
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_JZ.ColumnVINVOICENO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnVINVOICENO] = value;
            }
        }
        
		/// 
		/// 字段NFLAG所映射的属性。
		/// 
        public System.String NFLAG
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_JZ.ColumnNFLAG])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnNFLAG] = value;
            }
        }
        
		/// 
		/// 字段VVISITDEPT所映射的属性。
		/// 
        public System.String VVISITDEPT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_JZ.ColumnVVISITDEPT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnVVISITDEPT] = value;
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
	                return ((System.String)(this[this.tableGHSF_GHSF_JZ.ColumnVREMARKS])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnVREMARKS] = value;
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
	                return ((System.String)(this[this.tableGHSF_GHSF_JZ.ColumnVPATIENTID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnVPATIENTID] = value;
            }
        }
        
		/// 
		/// 字段NACCT_MODE所映射的属性。
		/// 
        public System.Int32 NACCT_MODE
        {
            get 
            {	
                try 
                {
	                return ((System.Int32)(this[this.tableGHSF_GHSF_JZ.ColumnNACCT_MODE])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnNACCT_MODE] = value;
            }
        }
        
		/// 
		/// 字段VCOUNTDEPT所映射的属性。
		/// 
        public System.String VCOUNTDEPT
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_JZ.ColumnVCOUNTDEPT])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnVCOUNTDEPT] = value;
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
	                return ((System.String)(this[this.tableGHSF_GHSF_JZ.ColumnVDOCTOR_ID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnVDOCTOR_ID] = value;
            }
        }
        
		/// 
		/// 字段VACCTID所映射的属性。
		/// 
        public System.String VACCTID
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_JZ.ColumnVACCTID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnVACCTID] = value;
            }
        }
        
		/// 
		/// 字段NACCOUNTTF所映射的属性。
		/// 
        public System.Decimal NACCOUNTTF
        {
            get 
            {	
                try 
                {
	                return ((System.Decimal)(this[this.tableGHSF_GHSF_JZ.ColumnNACCOUNTTF])); 
                }
                catch (InvalidCastException e) 
                {
                   
                    throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnNACCOUNTTF] = value;
            }
        }
        
		/// 
		/// 字段VACCOUNTSIDTF所映射的属性。
		/// 
        public System.String VACCOUNTSIDTF
        {
            get 
            {	
                try 
                {
	                return ((System.String)(this[this.tableGHSF_GHSF_JZ.ColumnVACCOUNTSIDTF])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnVACCOUNTSIDTF] = value;
            }
        }
        
		/// 
		/// 字段NOPHZID所映射的属性。
		/// 
        public System.Int16 NOPHZID
        {
            get 
            {	
                try 
                {
	                return ((System.Int16)(this[this.tableGHSF_GHSF_JZ.ColumnNOPHZID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnNOPHZID] = value;
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
	                return ((System.String)(this[this.tableGHSF_GHSF_JZ.ColumnVCLINICNO])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return "";
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnVCLINICNO] = value;
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
	                return ((System.Int32)(this[this.tableGHSF_GHSF_JZ.ColumnNHOSID])); 
                }
                catch (InvalidCastException e) 
                {
                   
                       return 0;
                   
                }
                
            }
            set 
            {
                this[this.tableGHSF_GHSF_JZ.ColumnNHOSID] = value;
            }
        }
        
		/// 
		/// 判断字段VITEMID是否为空。
		/// 
        public bool IsVITEMIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnVITEMID);
        }

		/// 
		/// 设置字段VITEMID为空值。
		/// 
        public void SetVITEMIDNull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnVITEMID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VITEMNAME是否为空。
		/// 
        public bool IsVITEMNAMENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnVITEMNAME);
        }

		/// 
		/// 设置字段VITEMNAME为空值。
		/// 
        public void SetVITEMNAMENull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnVITEMNAME] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NPRICE是否为空。
		/// 
        public bool IsNPRICENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnNPRICE);
        }

		/// 
		/// 设置字段NPRICE为空值。
		/// 
        public void SetNPRICENull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnNPRICE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCOSTS是否为空。
		/// 
        public bool IsNCOSTSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnNCOSTS);
        }

		/// 
		/// 设置字段NCOSTS为空值。
		/// 
        public void SetNCOSTSNull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnNCOSTS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NCHARGEFLAG是否为空。
		/// 
        public bool IsNCHARGEFLAGNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnNCHARGEFLAG);
        }

		/// 
		/// 设置字段NCHARGEFLAG为空值。
		/// 
        public void SetNCHARGEFLAGNull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnNCHARGEFLAG] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DMEDICINEDATE是否为空。
		/// 
        public bool IsDMEDICINEDATENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnDMEDICINEDATE);
        }

		/// 
		/// 设置字段DMEDICINEDATE为空值。
		/// 
        public void SetDMEDICINEDATENull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnDMEDICINEDATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VOPERATORID是否为空。
		/// 
        public bool IsVOPERATORIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnVOPERATORID);
        }

		/// 
		/// 设置字段VOPERATORID为空值。
		/// 
        public void SetVOPERATORIDNull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnVOPERATORID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NSETTLE是否为空。
		/// 
        public bool IsNSETTLENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnNSETTLE);
        }

		/// 
		/// 设置字段NSETTLE为空值。
		/// 
        public void SetNSETTLENull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnNSETTLE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段DSETTLEDATE是否为空。
		/// 
        public bool IsDSETTLEDATENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnDSETTLEDATE);
        }

		/// 
		/// 设置字段DSETTLEDATE为空值。
		/// 
        public void SetDSETTLEDATENull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnDSETTLEDATE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VSETTLEID是否为空。
		/// 
        public bool IsVSETTLEIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnVSETTLEID);
        }

		/// 
		/// 设置字段VSETTLEID为空值。
		/// 
        public void SetVSETTLEIDNull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnVSETTLEID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VCARDNO是否为空。
		/// 
        public bool IsVCARDNONull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnVCARDNO);
        }

		/// 
		/// 设置字段VCARDNO为空值。
		/// 
        public void SetVCARDNONull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnVCARDNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NACCOUNT是否为空。
		/// 
        public bool IsNACCOUNTNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnNACCOUNT);
        }

		/// 
		/// 设置字段NACCOUNT为空值。
		/// 
        public void SetNACCOUNTNull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnNACCOUNT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VINVOICENO是否为空。
		/// 
        public bool IsVINVOICENONull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnVINVOICENO);
        }

		/// 
		/// 设置字段VINVOICENO为空值。
		/// 
        public void SetVINVOICENONull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnVINVOICENO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NFLAG是否为空。
		/// 
        public bool IsNFLAGNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnNFLAG);
        }

		/// 
		/// 设置字段NFLAG为空值。
		/// 
        public void SetNFLAGNull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnNFLAG] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VVISITDEPT是否为空。
		/// 
        public bool IsVVISITDEPTNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnVVISITDEPT);
        }

		/// 
		/// 设置字段VVISITDEPT为空值。
		/// 
        public void SetVVISITDEPTNull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnVVISITDEPT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VREMARKS是否为空。
		/// 
        public bool IsVREMARKSNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnVREMARKS);
        }

		/// 
		/// 设置字段VREMARKS为空值。
		/// 
        public void SetVREMARKSNull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnVREMARKS] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VPATIENTID是否为空。
		/// 
        public bool IsVPATIENTIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnVPATIENTID);
        }

		/// 
		/// 设置字段VPATIENTID为空值。
		/// 
        public void SetVPATIENTIDNull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnVPATIENTID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NACCT_MODE是否为空。
		/// 
        public bool IsNACCT_MODENull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnNACCT_MODE);
        }

		/// 
		/// 设置字段NACCT_MODE为空值。
		/// 
        public void SetNACCT_MODENull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnNACCT_MODE] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VCOUNTDEPT是否为空。
		/// 
        public bool IsVCOUNTDEPTNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnVCOUNTDEPT);
        }

		/// 
		/// 设置字段VCOUNTDEPT为空值。
		/// 
        public void SetVCOUNTDEPTNull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnVCOUNTDEPT] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VDOCTOR_ID是否为空。
		/// 
        public bool IsVDOCTOR_IDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnVDOCTOR_ID);
        }

		/// 
		/// 设置字段VDOCTOR_ID为空值。
		/// 
        public void SetVDOCTOR_IDNull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnVDOCTOR_ID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VACCTID是否为空。
		/// 
        public bool IsVACCTIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnVACCTID);
        }

		/// 
		/// 设置字段VACCTID为空值。
		/// 
        public void SetVACCTIDNull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnVACCTID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NACCOUNTTF是否为空。
		/// 
        public bool IsNACCOUNTTFNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnNACCOUNTTF);
        }

		/// 
		/// 设置字段NACCOUNTTF为空值。
		/// 
        public void SetNACCOUNTTFNull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnNACCOUNTTF] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VACCOUNTSIDTF是否为空。
		/// 
        public bool IsVACCOUNTSIDTFNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnVACCOUNTSIDTF);
        }

		/// 
		/// 设置字段VACCOUNTSIDTF为空值。
		/// 
        public void SetVACCOUNTSIDTFNull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnVACCOUNTSIDTF] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NOPHZID是否为空。
		/// 
        public bool IsNOPHZIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnNOPHZID);
        }

		/// 
		/// 设置字段NOPHZID为空值。
		/// 
        public void SetNOPHZIDNull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnNOPHZID] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段VCLINICNO是否为空。
		/// 
        public bool IsVCLINICNONull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnVCLINICNO);
        }

		/// 
		/// 设置字段VCLINICNO为空值。
		/// 
        public void SetVCLINICNONull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnVCLINICNO] = System.Convert.DBNull;
        }
        
		/// 
		/// 判断字段NHOSID是否为空。
		/// 
        public bool IsNHOSIDNull()
        {
            return this.IsNull(this.tableGHSF_GHSF_JZ.ColumnNHOSID);
        }

		/// 
		/// 设置字段NHOSID为空值。
		/// 
        public void SetNHOSIDNull() 
        {
            this[this.tableGHSF_GHSF_JZ.ColumnNHOSID] = System.Convert.DBNull;
        }
        
    }

    [System.Diagnostics.DebuggerStepThrough()]
    public class RowChangeEventGHSF_GHSF_JZ : EventArgs {
        
        private RowGHSF_GHSF_JZ eventRow;
        
        private DataRowAction eventAction;
        
        public RowChangeEventGHSF_GHSF_JZ(RowGHSF_GHSF_JZ row, DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        public RowGHSF_GHSF_JZ Row {
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
	